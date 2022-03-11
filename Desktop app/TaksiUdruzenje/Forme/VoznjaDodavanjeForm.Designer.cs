
namespace TaksiUdruzenje.Forme
{
    partial class VoznjaDodavanjeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoznjaDodavanjeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPocetna = new System.Windows.Forms.TextBox();
            this.txtKrajnja = new System.Windows.Forms.TextBox();
            this.lstVozaci = new System.Windows.Forms.ListView();
            this.idVozac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imeVozac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prezimeVozac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brDozvole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kategorija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstOsoblje = new System.Windows.Forms.ListView();
            this.idOsoblje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imeOsoblje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prezimeOsoblje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sprema = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstMusterije = new System.Windows.Forms.ListView();
            this.idMusterija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.musterijaIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prezimeMusterija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brVoznji = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstTelefoni = new System.Windows.Forms.ListView();
            this.idTelefona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.broj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoviTelefon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDodajVoznju = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Početna stanica : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Krajnja stanica : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(570, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtPocetna
            // 
            this.txtPocetna.Location = new System.Drawing.Point(189, 47);
            this.txtPocetna.Name = "txtPocetna";
            this.txtPocetna.Size = new System.Drawing.Size(145, 22);
            this.txtPocetna.TabIndex = 6;
            // 
            // txtKrajnja
            // 
            this.txtKrajnja.Location = new System.Drawing.Point(189, 86);
            this.txtKrajnja.Name = "txtKrajnja";
            this.txtKrajnja.Size = new System.Drawing.Size(145, 22);
            this.txtKrajnja.TabIndex = 7;
            // 
            // lstVozaci
            // 
            this.lstVozaci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lstVozaci.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idVozac,
            this.imeVozac,
            this.prezimeVozac,
            this.brDozvole,
            this.kategorija});
            this.lstVozaci.FullRowSelect = true;
            this.lstVozaci.GridLines = true;
            this.lstVozaci.HideSelection = false;
            this.lstVozaci.Location = new System.Drawing.Point(32, 181);
            this.lstVozaci.MultiSelect = false;
            this.lstVozaci.Name = "lstVozaci";
            this.lstVozaci.Size = new System.Drawing.Size(776, 144);
            this.lstVozaci.TabIndex = 8;
            this.lstVozaci.UseCompatibleStateImageBehavior = false;
            this.lstVozaci.View = System.Windows.Forms.View.Details;
            // 
            // idVozac
            // 
            this.idVozac.Text = "ID Vozača";
            this.idVozac.Width = 100;
            // 
            // imeVozac
            // 
            this.imeVozac.Text = "Ime";
            this.imeVozac.Width = 107;
            // 
            // prezimeVozac
            // 
            this.prezimeVozac.Text = "Prezime";
            this.prezimeVozac.Width = 131;
            // 
            // brDozvole
            // 
            this.brDozvole.Text = "Broj dozvole";
            this.brDozvole.Width = 119;
            // 
            // kategorija
            // 
            this.kategorija.Text = "Kategorija";
            this.kategorija.Width = 120;
            // 
            // lstOsoblje
            // 
            this.lstOsoblje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lstOsoblje.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idOsoblje,
            this.imeOsoblje,
            this.prezimeOsoblje,
            this.sprema});
            this.lstOsoblje.FullRowSelect = true;
            this.lstOsoblje.GridLines = true;
            this.lstOsoblje.HideSelection = false;
            this.lstOsoblje.Location = new System.Drawing.Point(32, 363);
            this.lstOsoblje.MultiSelect = false;
            this.lstOsoblje.Name = "lstOsoblje";
            this.lstOsoblje.Size = new System.Drawing.Size(776, 147);
            this.lstOsoblje.TabIndex = 9;
            this.lstOsoblje.UseCompatibleStateImageBehavior = false;
            this.lstOsoblje.View = System.Windows.Forms.View.Details;
            // 
            // idOsoblje
            // 
            this.idOsoblje.Text = "ID Osoblja";
            this.idOsoblje.Width = 107;
            // 
            // imeOsoblje
            // 
            this.imeOsoblje.Text = "Ime";
            this.imeOsoblje.Width = 152;
            // 
            // prezimeOsoblje
            // 
            this.prezimeOsoblje.Text = "Prezime";
            this.prezimeOsoblje.Width = 185;
            // 
            // sprema
            // 
            this.sprema.Text = "Stručna sprema";
            this.sprema.Width = 118;
            // 
            // lstMusterije
            // 
            this.lstMusterije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lstMusterije.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idMusterija,
            this.musterijaIme,
            this.prezimeMusterija,
            this.brVoznji,
            this.adresa});
            this.lstMusterije.FullRowSelect = true;
            this.lstMusterije.GridLines = true;
            this.lstMusterije.HideSelection = false;
            this.lstMusterije.Location = new System.Drawing.Point(32, 549);
            this.lstMusterije.MultiSelect = false;
            this.lstMusterije.Name = "lstMusterije";
            this.lstMusterije.Size = new System.Drawing.Size(587, 180);
            this.lstMusterije.TabIndex = 10;
            this.lstMusterije.UseCompatibleStateImageBehavior = false;
            this.lstMusterije.View = System.Windows.Forms.View.Details;
            this.lstMusterije.SelectedIndexChanged += new System.EventHandler(this.lstMusterije_SelectedIndexChanged);
            // 
            // idMusterija
            // 
            this.idMusterija.Text = "ID Mušterije";
            this.idMusterija.Width = 104;
            // 
            // musterijaIme
            // 
            this.musterijaIme.Text = "Ime";
            this.musterijaIme.Width = 89;
            // 
            // prezimeMusterija
            // 
            this.prezimeMusterija.Text = "Prezime";
            this.prezimeMusterija.Width = 99;
            // 
            // brVoznji
            // 
            this.brVoznji.Text = "Broj vožnji";
            this.brVoznji.Width = 79;
            // 
            // adresa
            // 
            this.adresa.Text = "Adresa";
            this.adresa.Width = 185;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Izaberite jednog vozača";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(402, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Izaberite koje administrativno osoblje preuzima poziv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Izaberite mušteriju";
            // 
            // lstTelefoni
            // 
            this.lstTelefoni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lstTelefoni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idTelefona,
            this.broj});
            this.lstTelefoni.FullRowSelect = true;
            this.lstTelefoni.GridLines = true;
            this.lstTelefoni.HideSelection = false;
            this.lstTelefoni.Location = new System.Drawing.Point(625, 549);
            this.lstTelefoni.MultiSelect = false;
            this.lstTelefoni.Name = "lstTelefoni";
            this.lstTelefoni.Size = new System.Drawing.Size(183, 131);
            this.lstTelefoni.TabIndex = 15;
            this.lstTelefoni.UseCompatibleStateImageBehavior = false;
            this.lstTelefoni.View = System.Windows.Forms.View.Details;
            // 
            // idTelefona
            // 
            this.idTelefona.Text = "ID";
            this.idTelefona.Width = 45;
            // 
            // broj
            // 
            this.broj.Text = "Broj telefona";
            this.broj.Width = 134;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(647, 526);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Izaberite telefon";
            // 
            // txtNoviTelefon
            // 
            this.txtNoviTelefon.Enabled = false;
            this.txtNoviTelefon.Location = new System.Drawing.Point(625, 706);
            this.txtNoviTelefon.Name = "txtNoviTelefon";
            this.txtNoviTelefon.Size = new System.Drawing.Size(183, 22);
            this.txtNoviTelefon.TabIndex = 17;
            this.txtNoviTelefon.Enter += new System.EventHandler(this.txtNoviTelefon_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(635, 683);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Unesite novi telefon";
            // 
            // btnDodajVoznju
            // 
            this.btnDodajVoznju.BorderColor = System.Drawing.Color.Black;
            this.btnDodajVoznju.ButtonColor = System.Drawing.Color.SandyBrown;
            this.btnDodajVoznju.FlatAppearance.BorderSize = 0;
            this.btnDodajVoznju.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDodajVoznju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajVoznju.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodajVoznju.Location = new System.Drawing.Point(332, 760);
            this.btnDodajVoznju.Name = "btnDodajVoznju";
            this.btnDodajVoznju.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDodajVoznju.OnHoverButtonColor = System.Drawing.Color.Coral;
            this.btnDodajVoznju.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnDodajVoznju.Size = new System.Drawing.Size(165, 58);
            this.btnDodajVoznju.TabIndex = 14;
            this.btnDodajVoznju.Text = "Dodaj vožnju";
            this.btnDodajVoznju.TextColor = System.Drawing.Color.Black;
            this.btnDodajVoznju.UseVisualStyleBackColor = true;
            this.btnDodajVoznju.Click += new System.EventHandler(this.btnDodajVoznju_Click);
            // 
            // VoznjaDodavanjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(838, 965);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNoviTelefon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstTelefoni);
            this.Controls.Add(this.btnDodajVoznju);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstMusterije);
            this.Controls.Add(this.lstOsoblje);
            this.Controls.Add(this.lstVozaci);
            this.Controls.Add(this.txtKrajnja);
            this.Controls.Add(this.txtPocetna);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(856, 1012);
            this.MinimumSize = new System.Drawing.Size(856, 1012);
            this.Name = "VoznjaDodavanjeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje vožnje";
            this.Load += new System.EventHandler(this.VoznjaDodavanjeForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.VoznjaDodavanjeForm_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPocetna;
        private System.Windows.Forms.TextBox txtKrajnja;
        private System.Windows.Forms.ListView lstVozaci;
        private System.Windows.Forms.ListView lstOsoblje;
        private System.Windows.Forms.ListView lstMusterije;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private ePOSOne.btnProduct.Button_WOC btnDodajVoznju;
        private System.Windows.Forms.ColumnHeader idVozac;
        private System.Windows.Forms.ColumnHeader imeVozac;
        private System.Windows.Forms.ColumnHeader prezimeVozac;
        private System.Windows.Forms.ColumnHeader brDozvole;
        private System.Windows.Forms.ColumnHeader kategorija;
        private System.Windows.Forms.ColumnHeader idOsoblje;
        private System.Windows.Forms.ColumnHeader imeOsoblje;
        private System.Windows.Forms.ColumnHeader prezimeOsoblje;
        private System.Windows.Forms.ColumnHeader sprema;
        private System.Windows.Forms.ColumnHeader idMusterija;
        private System.Windows.Forms.ColumnHeader musterijaIme;
        private System.Windows.Forms.ColumnHeader prezimeMusterija;
        private System.Windows.Forms.ColumnHeader brVoznji;
        private System.Windows.Forms.ColumnHeader adresa;
        private System.Windows.Forms.ListView lstTelefoni;
        private System.Windows.Forms.ColumnHeader idTelefona;
        private System.Windows.Forms.ColumnHeader broj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNoviTelefon;
        private System.Windows.Forms.Label label7;
    }
}