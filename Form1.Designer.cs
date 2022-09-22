namespace AS2223_3G_INF_PieriEdoardo_RubricaCSV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeFile = new System.Windows.Forms.TextBox();
            this.btnApriFile = new System.Windows.Forms.Button();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.cmbRicerca = new System.Windows.Forms.ComboBox();
            this.lstElenco = new System.Windows.Forms.ListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "File CSV Rubrica:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cognome:";
            // 
            // txtNomeFile
            // 
            this.txtNomeFile.Location = new System.Drawing.Point(143, 64);
            this.txtNomeFile.Name = "txtNomeFile";
            this.txtNomeFile.Size = new System.Drawing.Size(194, 23);
            this.txtNomeFile.TabIndex = 2;
            // 
            // btnApriFile
            // 
            this.btnApriFile.Location = new System.Drawing.Point(358, 64);
            this.btnApriFile.Name = "btnApriFile";
            this.btnApriFile.Size = new System.Drawing.Size(41, 23);
            this.btnApriFile.TabIndex = 3;
            this.btnApriFile.Text = "...";
            this.btnApriFile.UseVisualStyleBackColor = true;
            this.btnApriFile.Click += new System.EventHandler(this.btnApriFile_Click);
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(143, 110);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(194, 23);
            this.txtCognome.TabIndex = 4;
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(202, 159);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizza.TabIndex = 5;
            this.btnVisualizza.Text = "Visualizza";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // cmbRicerca
            // 
            this.cmbRicerca.FormattingEnabled = true;
            this.cmbRicerca.Items.AddRange(new object[] {
            "Contiene",
            "Inizia per",
            "Finisce per"});
            this.cmbRicerca.Location = new System.Drawing.Point(358, 110);
            this.cmbRicerca.Name = "cmbRicerca";
            this.cmbRicerca.Size = new System.Drawing.Size(84, 23);
            this.cmbRicerca.TabIndex = 6;
            // 
            // lstElenco
            // 
            this.lstElenco.FormattingEnabled = true;
            this.lstElenco.ItemHeight = 15;
            this.lstElenco.Location = new System.Drawing.Point(32, 211);
            this.lstElenco.Name = "lstElenco";
            this.lstElenco.Size = new System.Drawing.Size(410, 184);
            this.lstElenco.TabIndex = 7;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.lstElenco);
            this.Controls.Add(this.cmbRicerca);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.btnApriFile);
            this.Controls.Add(this.txtNomeFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNomeFile;
        private Button btnApriFile;
        private TextBox txtCognome;
        private Button btnVisualizza;
        private ComboBox cmbRicerca;
        private ListBox lstElenco;
        private OpenFileDialog openFileDialog;
    }
}