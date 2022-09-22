using System.IO;
namespace AS2223_3G_INF_PieriEdoardo_RubricaCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int LENGTH = 3;
        private void btnApriFile_Click(object sender, EventArgs e)
        {
            string[] nomi = new string[LENGTH];
            string[] cognomi = new string[LENGTH];
            string[] arrayDiSupporto = new string[LENGTH];
            string lineaCorrente;
            openFileDialog.ShowDialog();    //apre la selezione file
            txtNomeFile.Text = openFileDialog.FileName; //scrive nella textbox il percorso del file
            StreamReader streamreader = new StreamReader(openFileDialog.FileName);
            while(!streamreader.EndOfStream)    //ciclo che si ripete fino a quando non finiscono le righe
            {
                lineaCorrente = streamreader.ReadLine();
                lstElenco.Items.Add(lineaCorrente);
            }
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {

        }
    }
}