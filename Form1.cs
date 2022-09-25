using System.Globalization;
using System.IO;
namespace AS2223_3G_INF_PieriEdoardo_RubricaCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] nomi = new string[LENGTH];
        string[] cognomi = new string[LENGTH];
        string[] citta = new string[LENGTH];
        const int LENGTH = 3;
        private void btnApriFile_Click(object sender, EventArgs e)
        {
            string[] stringheCorrenti = new string[3];
            string lineaCorrente;
            openFileDialog.ShowDialog();    //apre la selezione file
            txtNomeFile.Text = openFileDialog.FileName; //scrive nella textbox il percorso del file
            StreamReader streamreader = new StreamReader(openFileDialog.FileName);
            for (int c = 0; c < LENGTH; c++)    //ciclo che si ripete fino a quando non finiscono le righe
            {
                lineaCorrente = streamreader.ReadLine();
                lstElenco.Items.Add(lineaCorrente);
                stringheCorrenti = lineaCorrente.Split(';');
                nomi[c] = stringheCorrenti[0];
                cognomi[c] = stringheCorrenti[1];
                citta[c] = stringheCorrenti[2];
            }
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            lstElenco.Items.Clear();
            switch(cmbRicerca.Text)
            {
                case "Contiene":
                    for(int c = 0; c < LENGTH; c++)
                    {
                        if (cognomi[c].ToLower().Contains(txtCognome.Text.ToLower()))
                        {
                            lstElenco.Items.Add($"{nomi[c]};{cognomi[c]};{citta[c]}");
                        }
                    }
                    break;
                case "Inizia per":
                    for (int c = 0; c < LENGTH; c++) {
                        if (cognomi[c].Trim().ToLower().StartsWith(txtCognome.Text.ToLower()))  //il metodo Trim rimuove lo spazio davanti al cognome, in modo tale
                        {                                                                       //che non lo conti nella Startswith (nel file csv ho lasciato uno
                            lstElenco.Items.Add($"{nomi[c]};{cognomi[c]};{citta[c]}");          //spazio dopo la virgola)
                        }
                    }
                    break;
                case "Finisce per":
                    for (int c = 0; c < LENGTH; c++)
                    {
                        if (cognomi[c].ToLower().EndsWith(txtCognome.Text.ToLower()))
                        {
                            lstElenco.Items.Add($"{nomi[c]};{cognomi[c]};{citta[c]}");
                        }
                    }
                    break;
            }
        }
    }
}