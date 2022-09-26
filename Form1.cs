using System.ComponentModel;
using System.Globalization;
using System.IO;
namespace AS2223_3G_INF_PieriEdoardo_RubricaCSV
{
    public class Contatto
    {
        public string Nome;
        public string Cognome;
        public string Citta;
        public Contatto(string nome, string cognome, string citta)
        {
            Nome = nome;
            Cognome = cognome;
            Citta = citta;
        }
        public Contatto(string riga)
        {
            string[] rigaCorrente = riga.Split(',');
            Nome = rigaCorrente[0];
            Cognome = rigaCorrente[1];
            Citta = rigaCorrente[2];
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int LUNGHEZZA_MAX = 50;
        Contatto[] contatti = new Contatto[LUNGHEZZA_MAX];
        int nContatti;
        private void btnApriFile_Click(object sender, EventArgs e)
        {
            nContatti = 0;
            string lineaCorrente = "";
            openFileDialog.ShowDialog();    //apre la selezione file
            txtNomeFile.Text = openFileDialog.FileName; //scrive nella textbox il percorso del file
            StreamReader streamreader = new StreamReader(openFileDialog.FileName);
            while(!streamreader.EndOfStream)    //ciclo che dura fino a quando non trova piu righe da leggere
            {
                lineaCorrente = streamreader.ReadLine();
                lstElenco.Items.Add(lineaCorrente);
                contatti[nContatti] = new Contatto(lineaCorrente);
                nContatti++;
            }
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            lstElenco.Items.Clear();
            switch(cmbRicerca.Text)
            {
                case "Contiene":
                    for(int c = 0; c < nContatti; c++)
                    {
                        if (contatti[c].Cognome.ToLower().Contains(txtCognome.Text.ToLower()))
                        {
                            lstElenco.Items.Add($"{contatti[c].Nome},{contatti[c].Cognome},{contatti[c].Citta}");
                        }
                    }
                    break;
                case "Inizia per":
                    for (int c = 0; c < nContatti; c++) {
                        if (contatti[c].Cognome.Trim().ToLower().StartsWith(txtCognome.Text.ToLower()))  //il metodo Trim rimuove lo spazio davanti al cognome, in modo tale
                        {                                                                       //che non lo conti nella Startswith (nel file csv ho lasciato uno
                            lstElenco.Items.Add($"{contatti[c].Nome},{contatti[c].Cognome},{contatti[c].Citta}");         //spazio dopo la virgola)
                        }
                    }
                    break;
                case "Finisce per":
                    for (int c = 0; c < nContatti; c++)
                    {
                        if (contatti[c].Cognome.ToLower().EndsWith(txtCognome.Text.ToLower()))
                        {
                            lstElenco.Items.Add($"{contatti[c].Nome},{contatti[c].Cognome},{contatti[c].Citta}");
                        }
                    }
                    break;
            }
        }
    }
}