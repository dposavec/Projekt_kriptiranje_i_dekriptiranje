namespace OS_Projekt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDirektorij = new System.Windows.Forms.TextBox();
            this.txtUlazniPodaci = new System.Windows.Forms.TextBox();
            this.lblDirektorij = new System.Windows.Forms.Label();
            this.btnDirektorij = new System.Windows.Forms.Button();
            this.btnGenerirajKljuceve = new System.Windows.Forms.Button();
            this.btnIzracunajSazetak = new System.Windows.Forms.Button();
            this.btnDigitalnoPotpisi = new System.Windows.Forms.Button();
            this.btnProvjeriDigitalniPotpis = new System.Windows.Forms.Button();
            this.lblTajniKljuc = new System.Windows.Forms.Label();
            this.lblPrivatniKljuc = new System.Windows.Forms.Label();
            this.lblJavniKljuc = new System.Windows.Forms.Label();
            this.lblUlazniPodaci = new System.Windows.Forms.Label();
            this.lblOdabirUlazneDatoteke = new System.Windows.Forms.Label();
            this.btnOdaberiUlaznuDatoteku = new System.Windows.Forms.Button();
            this.lblSimetricno = new System.Windows.Forms.Label();
            this.lblAsimetrično = new System.Windows.Forms.Label();
            this.BtnSimetricnoKriptiraj = new System.Windows.Forms.Button();
            this.btnSimetricnoDekriptiraj = new System.Windows.Forms.Button();
            this.btnAsimetricnoKriptiraj = new System.Windows.Forms.Button();
            this.btnAsimetricnoDekriptiraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDirektorij
            // 
            this.txtDirektorij.Location = new System.Drawing.Point(33, 42);
            this.txtDirektorij.Name = "txtDirektorij";
            this.txtDirektorij.Size = new System.Drawing.Size(410, 20);
            this.txtDirektorij.TabIndex = 0;
            // 
            // txtUlazniPodaci
            // 
            this.txtUlazniPodaci.Location = new System.Drawing.Point(33, 323);
            this.txtUlazniPodaci.Multiline = true;
            this.txtUlazniPodaci.Name = "txtUlazniPodaci";
            this.txtUlazniPodaci.Size = new System.Drawing.Size(410, 93);
            this.txtUlazniPodaci.TabIndex = 1;
            // 
            // lblDirektorij
            // 
            this.lblDirektorij.AutoSize = true;
            this.lblDirektorij.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirektorij.Location = new System.Drawing.Point(83, 26);
            this.lblDirektorij.Name = "lblDirektorij";
            this.lblDirektorij.Size = new System.Drawing.Size(258, 13);
            this.lblDirektorij.TabIndex = 2;
            this.lblDirektorij.Text = "Odaberite radni direktorij za rad s podacima:";
            // 
            // btnDirektorij
            // 
            this.btnDirektorij.Location = new System.Drawing.Point(144, 68);
            this.btnDirektorij.Name = "btnDirektorij";
            this.btnDirektorij.Size = new System.Drawing.Size(144, 23);
            this.btnDirektorij.TabIndex = 3;
            this.btnDirektorij.Text = "Odaberi direktorij";
            this.btnDirektorij.UseVisualStyleBackColor = true;
            this.btnDirektorij.Click += new System.EventHandler(this.btnDirektorij_Click);
            // 
            // btnGenerirajKljuceve
            // 
            this.btnGenerirajKljuceve.Enabled = false;
            this.btnGenerirajKljuceve.Location = new System.Drawing.Point(144, 106);
            this.btnGenerirajKljuceve.Name = "btnGenerirajKljuceve";
            this.btnGenerirajKljuceve.Size = new System.Drawing.Size(144, 27);
            this.btnGenerirajKljuceve.TabIndex = 4;
            this.btnGenerirajKljuceve.Text = "Generiraj ključeve";
            this.btnGenerirajKljuceve.UseVisualStyleBackColor = true;
            this.btnGenerirajKljuceve.Click += new System.EventHandler(this.btnGenerirajKljuceve_Click);
            // 
            // btnIzracunajSazetak
            // 
            this.btnIzracunajSazetak.Enabled = false;
            this.btnIzracunajSazetak.Location = new System.Drawing.Point(34, 500);
            this.btnIzracunajSazetak.Name = "btnIzracunajSazetak";
            this.btnIzracunajSazetak.Size = new System.Drawing.Size(128, 55);
            this.btnIzracunajSazetak.TabIndex = 5;
            this.btnIzracunajSazetak.Text = "Izračunaj sažetak";
            this.btnIzracunajSazetak.UseVisualStyleBackColor = true;
            this.btnIzracunajSazetak.Click += new System.EventHandler(this.btnIzracunajSazetak_Click);
            // 
            // btnDigitalnoPotpisi
            // 
            this.btnDigitalnoPotpisi.Enabled = false;
            this.btnDigitalnoPotpisi.Location = new System.Drawing.Point(179, 500);
            this.btnDigitalnoPotpisi.Name = "btnDigitalnoPotpisi";
            this.btnDigitalnoPotpisi.Size = new System.Drawing.Size(119, 55);
            this.btnDigitalnoPotpisi.TabIndex = 6;
            this.btnDigitalnoPotpisi.Text = "Digitalno potpiši datoteku";
            this.btnDigitalnoPotpisi.UseVisualStyleBackColor = true;
            this.btnDigitalnoPotpisi.Click += new System.EventHandler(this.btnDigitalnoPotpisi_Click);
            // 
            // btnProvjeriDigitalniPotpis
            // 
            this.btnProvjeriDigitalniPotpis.Enabled = false;
            this.btnProvjeriDigitalniPotpis.Location = new System.Drawing.Point(304, 500);
            this.btnProvjeriDigitalniPotpis.Name = "btnProvjeriDigitalniPotpis";
            this.btnProvjeriDigitalniPotpis.Size = new System.Drawing.Size(116, 55);
            this.btnProvjeriDigitalniPotpis.TabIndex = 7;
            this.btnProvjeriDigitalniPotpis.Text = "Provjeri digitalni potpis";
            this.btnProvjeriDigitalniPotpis.UseVisualStyleBackColor = true;
            this.btnProvjeriDigitalniPotpis.Click += new System.EventHandler(this.btnProvjeriDigitalniPotpis_Click);
            // 
            // lblTajniKljuc
            // 
            this.lblTajniKljuc.AutoSize = true;
            this.lblTajniKljuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTajniKljuc.Location = new System.Drawing.Point(30, 156);
            this.lblTajniKljuc.Name = "lblTajniKljuc";
            this.lblTajniKljuc.Size = new System.Drawing.Size(128, 13);
            this.lblTajniKljuc.TabIndex = 8;
            this.lblTajniKljuc.Text = "Generirani tajni ključ:";
            // 
            // lblPrivatniKljuc
            // 
            this.lblPrivatniKljuc.AutoSize = true;
            this.lblPrivatniKljuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivatniKljuc.Location = new System.Drawing.Point(30, 186);
            this.lblPrivatniKljuc.Name = "lblPrivatniKljuc";
            this.lblPrivatniKljuc.Size = new System.Drawing.Size(146, 13);
            this.lblPrivatniKljuc.TabIndex = 9;
            this.lblPrivatniKljuc.Text = "Generirani privatni ključ:";
            // 
            // lblJavniKljuc
            // 
            this.lblJavniKljuc.AutoSize = true;
            this.lblJavniKljuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJavniKljuc.Location = new System.Drawing.Point(30, 213);
            this.lblJavniKljuc.Name = "lblJavniKljuc";
            this.lblJavniKljuc.Size = new System.Drawing.Size(132, 13);
            this.lblJavniKljuc.TabIndex = 10;
            this.lblJavniKljuc.Text = "Generirani javni Ključ:";
            // 
            // lblUlazniPodaci
            // 
            this.lblUlazniPodaci.AutoSize = true;
            this.lblUlazniPodaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUlazniPodaci.Location = new System.Drawing.Point(30, 307);
            this.lblUlazniPodaci.Name = "lblUlazniPodaci";
            this.lblUlazniPodaci.Size = new System.Drawing.Size(199, 13);
            this.lblUlazniPodaci.TabIndex = 11;
            this.lblUlazniPodaci.Text = "Ulazni podaci odabrane datoteke:";
            // 
            // lblOdabirUlazneDatoteke
            // 
            this.lblOdabirUlazneDatoteke.AutoSize = true;
            this.lblOdabirUlazneDatoteke.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdabirUlazneDatoteke.Location = new System.Drawing.Point(30, 260);
            this.lblOdabirUlazneDatoteke.Name = "lblOdabirUlazneDatoteke";
            this.lblOdabirUlazneDatoteke.Size = new System.Drawing.Size(268, 13);
            this.lblOdabirUlazneDatoteke.TabIndex = 12;
            this.lblOdabirUlazneDatoteke.Text = "Odaberite ulaznu datoteku za rad s podacima:";
            // 
            // btnOdaberiUlaznuDatoteku
            // 
            this.btnOdaberiUlaznuDatoteku.Enabled = false;
            this.btnOdaberiUlaznuDatoteku.Location = new System.Drawing.Point(33, 276);
            this.btnOdaberiUlaznuDatoteku.Name = "btnOdaberiUlaznuDatoteku";
            this.btnOdaberiUlaznuDatoteku.Size = new System.Drawing.Size(255, 28);
            this.btnOdaberiUlaznuDatoteku.TabIndex = 13;
            this.btnOdaberiUlaznuDatoteku.Text = "Odaberi ulaznu datoteku";
            this.btnOdaberiUlaznuDatoteku.UseVisualStyleBackColor = true;
            this.btnOdaberiUlaznuDatoteku.Click += new System.EventHandler(this.btnOdaberiUlaznuDatoteku_Click);
            // 
            // lblSimetricno
            // 
            this.lblSimetricno.AutoSize = true;
            this.lblSimetricno.Location = new System.Drawing.Point(30, 419);
            this.lblSimetricno.Name = "lblSimetricno";
            this.lblSimetricno.Size = new System.Drawing.Size(193, 13);
            this.lblSimetricno.TabIndex = 14;
            this.lblSimetricno.Text = "Simetrično kriptiraj i dekriptiraj datoteku:";
            // 
            // lblAsimetrično
            // 
            this.lblAsimetrično.AutoSize = true;
            this.lblAsimetrično.Location = new System.Drawing.Point(245, 419);
            this.lblAsimetrično.Name = "lblAsimetrično";
            this.lblAsimetrično.Size = new System.Drawing.Size(198, 13);
            this.lblAsimetrično.TabIndex = 15;
            this.lblAsimetrično.Text = "Asimetrično kriptiraj i dekriptiraj datoteku:";
            // 
            // BtnSimetricnoKriptiraj
            // 
            this.BtnSimetricnoKriptiraj.Enabled = false;
            this.BtnSimetricnoKriptiraj.Location = new System.Drawing.Point(33, 435);
            this.BtnSimetricnoKriptiraj.Name = "BtnSimetricnoKriptiraj";
            this.BtnSimetricnoKriptiraj.Size = new System.Drawing.Size(87, 50);
            this.BtnSimetricnoKriptiraj.TabIndex = 16;
            this.BtnSimetricnoKriptiraj.Text = "Kriptiraj";
            this.BtnSimetricnoKriptiraj.UseVisualStyleBackColor = true;
            this.BtnSimetricnoKriptiraj.Click += new System.EventHandler(this.BtnSimetricnoKriptiraj_Click);
            // 
            // btnSimetricnoDekriptiraj
            // 
            this.btnSimetricnoDekriptiraj.Enabled = false;
            this.btnSimetricnoDekriptiraj.Location = new System.Drawing.Point(126, 435);
            this.btnSimetricnoDekriptiraj.Name = "btnSimetricnoDekriptiraj";
            this.btnSimetricnoDekriptiraj.Size = new System.Drawing.Size(97, 50);
            this.btnSimetricnoDekriptiraj.TabIndex = 17;
            this.btnSimetricnoDekriptiraj.Text = "Dekriptiraj";
            this.btnSimetricnoDekriptiraj.UseVisualStyleBackColor = true;
            this.btnSimetricnoDekriptiraj.Click += new System.EventHandler(this.btnSimetricnoDekriptiraj_Click);
            // 
            // btnAsimetricnoKriptiraj
            // 
            this.btnAsimetricnoKriptiraj.Enabled = false;
            this.btnAsimetricnoKriptiraj.Location = new System.Drawing.Point(257, 435);
            this.btnAsimetricnoKriptiraj.Name = "btnAsimetricnoKriptiraj";
            this.btnAsimetricnoKriptiraj.Size = new System.Drawing.Size(84, 50);
            this.btnAsimetricnoKriptiraj.TabIndex = 18;
            this.btnAsimetricnoKriptiraj.Text = "Kriptiraj";
            this.btnAsimetricnoKriptiraj.UseVisualStyleBackColor = true;
            this.btnAsimetricnoKriptiraj.Click += new System.EventHandler(this.btnAsimetricnoKriptiraj_Click);
            // 
            // btnAsimetricnoDekriptiraj
            // 
            this.btnAsimetricnoDekriptiraj.Enabled = false;
            this.btnAsimetricnoDekriptiraj.Location = new System.Drawing.Point(347, 435);
            this.btnAsimetricnoDekriptiraj.Name = "btnAsimetricnoDekriptiraj";
            this.btnAsimetricnoDekriptiraj.Size = new System.Drawing.Size(83, 50);
            this.btnAsimetricnoDekriptiraj.TabIndex = 19;
            this.btnAsimetricnoDekriptiraj.Text = "Dekriptiraj";
            this.btnAsimetricnoDekriptiraj.UseVisualStyleBackColor = true;
            this.btnAsimetricnoDekriptiraj.Click += new System.EventHandler(this.btnAsimetricnoDekriptiraj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 570);
            this.Controls.Add(this.btnAsimetricnoDekriptiraj);
            this.Controls.Add(this.btnAsimetricnoKriptiraj);
            this.Controls.Add(this.btnSimetricnoDekriptiraj);
            this.Controls.Add(this.BtnSimetricnoKriptiraj);
            this.Controls.Add(this.lblAsimetrično);
            this.Controls.Add(this.lblSimetricno);
            this.Controls.Add(this.btnOdaberiUlaznuDatoteku);
            this.Controls.Add(this.lblOdabirUlazneDatoteke);
            this.Controls.Add(this.lblUlazniPodaci);
            this.Controls.Add(this.lblJavniKljuc);
            this.Controls.Add(this.lblPrivatniKljuc);
            this.Controls.Add(this.lblTajniKljuc);
            this.Controls.Add(this.btnProvjeriDigitalniPotpis);
            this.Controls.Add(this.btnDigitalnoPotpisi);
            this.Controls.Add(this.btnIzracunajSazetak);
            this.Controls.Add(this.btnGenerirajKljuceve);
            this.Controls.Add(this.btnDirektorij);
            this.Controls.Add(this.lblDirektorij);
            this.Controls.Add(this.txtUlazniPodaci);
            this.Controls.Add(this.txtDirektorij);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDirektorij;
        private System.Windows.Forms.TextBox txtUlazniPodaci;
        private System.Windows.Forms.Label lblDirektorij;
        private System.Windows.Forms.Button btnDirektorij;
        private System.Windows.Forms.Button btnGenerirajKljuceve;
        private System.Windows.Forms.Button btnIzracunajSazetak;
        private System.Windows.Forms.Button btnDigitalnoPotpisi;
        private System.Windows.Forms.Button btnProvjeriDigitalniPotpis;
        private System.Windows.Forms.Label lblTajniKljuc;
        private System.Windows.Forms.Label lblPrivatniKljuc;
        private System.Windows.Forms.Label lblJavniKljuc;
        private System.Windows.Forms.Label lblUlazniPodaci;
        private System.Windows.Forms.Label lblOdabirUlazneDatoteke;
        private System.Windows.Forms.Button btnOdaberiUlaznuDatoteku;
        private System.Windows.Forms.Label lblSimetricno;
        private System.Windows.Forms.Label lblAsimetrično;
        private System.Windows.Forms.Button BtnSimetricnoKriptiraj;
        private System.Windows.Forms.Button btnSimetricnoDekriptiraj;
        private System.Windows.Forms.Button btnAsimetricnoKriptiraj;
        private System.Windows.Forms.Button btnAsimetricnoDekriptiraj;
    }
}

