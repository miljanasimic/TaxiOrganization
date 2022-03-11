
namespace TaksiUdruzenje.Forme
{
    partial class AdministrativnoOsobljePrikaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrativnoOsobljePrikaz));
            this.listPreuzeteVoznje = new System.Windows.Forms.ListView();
            this.IDVoznje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDVozaca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDMusterije = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PocetnaStanica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KrajnjaStanica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VremePoziva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VremePocetka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VremeKraja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CenaVoznje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrojTelefona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtSrSlovo = new System.Windows.Forms.TextBox();
            this.txtJmbg = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtStrucnaSprema = new System.Windows.Forms.TextBox();
            this.txtUlica = new System.Windows.Forms.TextBox();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.groupBoxPodaciAO = new System.Windows.Forms.GroupBox();
            this.btnIzmeniAO = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.borderLabel6 = new cSouza.WinForms.Controls.BorderLabel();
            this.groupBoxPodaciAO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listPreuzeteVoznje
            // 
            this.listPreuzeteVoznje.BackColor = System.Drawing.Color.Tan;
            this.listPreuzeteVoznje.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDVoznje,
            this.IDVozaca,
            this.IDMusterije,
            this.PocetnaStanica,
            this.KrajnjaStanica,
            this.VremePoziva,
            this.VremePocetka,
            this.VremeKraja,
            this.CenaVoznje,
            this.BrojTelefona});
            this.listPreuzeteVoznje.GridLines = true;
            this.listPreuzeteVoznje.HideSelection = false;
            this.listPreuzeteVoznje.Location = new System.Drawing.Point(39, 338);
            this.listPreuzeteVoznje.Name = "listPreuzeteVoznje";
            this.listPreuzeteVoznje.Size = new System.Drawing.Size(1425, 291);
            this.listPreuzeteVoznje.TabIndex = 0;
            this.listPreuzeteVoznje.UseCompatibleStateImageBehavior = false;
            this.listPreuzeteVoznje.View = System.Windows.Forms.View.Details;
            // 
            // IDVoznje
            // 
            this.IDVoznje.Text = "ID Vožnje";
            this.IDVoznje.Width = 70;
            // 
            // IDVozaca
            // 
            this.IDVozaca.Text = "ID Vozača";
            this.IDVozaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IDVozaca.Width = 70;
            // 
            // IDMusterije
            // 
            this.IDMusterije.Text = "ID Mušterije";
            this.IDMusterije.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IDMusterije.Width = 70;
            // 
            // PocetnaStanica
            // 
            this.PocetnaStanica.Text = "Početna stanica";
            this.PocetnaStanica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PocetnaStanica.Width = 119;
            // 
            // KrajnjaStanica
            // 
            this.KrajnjaStanica.Text = "Krajnja stanica";
            this.KrajnjaStanica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KrajnjaStanica.Width = 109;
            // 
            // VremePoziva
            // 
            this.VremePoziva.Text = "Vreme poziva";
            this.VremePoziva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VremePoziva.Width = 115;
            // 
            // VremePocetka
            // 
            this.VremePocetka.Text = "Vreme početka";
            this.VremePocetka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VremePocetka.Width = 115;
            // 
            // VremeKraja
            // 
            this.VremeKraja.Text = "Vreme kraja";
            this.VremeKraja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VremeKraja.Width = 130;
            // 
            // CenaVoznje
            // 
            this.CenaVoznje.Text = "Cena vožnje";
            this.CenaVoznje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CenaVoznje.Width = 133;
            // 
            // BrojTelefona
            // 
            this.BrojTelefona.Text = "Broj telefona poziva";
            this.BrojTelefona.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BrojTelefona.Width = 135;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prezime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(588, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Srednje slovo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Jmbg:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(283, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Broj telefona:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(577, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Stručna sprema:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(340, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Broj:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ulica:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(462, 24);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(75, 25);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "label10";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(96, 47);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(140, 24);
            this.txtIme.TabIndex = 17;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(398, 47);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(140, 24);
            this.txtPrezime.TabIndex = 18;
            // 
            // txtSrSlovo
            // 
            this.txtSrSlovo.Location = new System.Drawing.Point(711, 47);
            this.txtSrSlovo.Name = "txtSrSlovo";
            this.txtSrSlovo.Size = new System.Drawing.Size(140, 24);
            this.txtSrSlovo.TabIndex = 19;
            // 
            // txtJmbg
            // 
            this.txtJmbg.Enabled = false;
            this.txtJmbg.Location = new System.Drawing.Point(96, 87);
            this.txtJmbg.Name = "txtJmbg";
            this.txtJmbg.Size = new System.Drawing.Size(140, 24);
            this.txtJmbg.TabIndex = 20;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(398, 87);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(140, 24);
            this.txtTelefon.TabIndex = 21;
            // 
            // txtStrucnaSprema
            // 
            this.txtStrucnaSprema.Location = new System.Drawing.Point(711, 87);
            this.txtStrucnaSprema.Name = "txtStrucnaSprema";
            this.txtStrucnaSprema.Size = new System.Drawing.Size(140, 24);
            this.txtStrucnaSprema.TabIndex = 22;
            // 
            // txtUlica
            // 
            this.txtUlica.Location = new System.Drawing.Point(96, 125);
            this.txtUlica.Name = "txtUlica";
            this.txtUlica.Size = new System.Drawing.Size(140, 24);
            this.txtUlica.TabIndex = 23;
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(398, 127);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(140, 24);
            this.txtBroj.TabIndex = 24;
            // 
            // groupBoxPodaciAO
            // 
            this.groupBoxPodaciAO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBoxPodaciAO.Controls.Add(this.txtTelefon);
            this.groupBoxPodaciAO.Controls.Add(this.txtBroj);
            this.groupBoxPodaciAO.Controls.Add(this.label2);
            this.groupBoxPodaciAO.Controls.Add(this.txtUlica);
            this.groupBoxPodaciAO.Controls.Add(this.label3);
            this.groupBoxPodaciAO.Controls.Add(this.btnIzmeniAO);
            this.groupBoxPodaciAO.Controls.Add(this.txtStrucnaSprema);
            this.groupBoxPodaciAO.Controls.Add(this.label4);
            this.groupBoxPodaciAO.Controls.Add(this.label5);
            this.groupBoxPodaciAO.Controls.Add(this.txtJmbg);
            this.groupBoxPodaciAO.Controls.Add(this.label6);
            this.groupBoxPodaciAO.Controls.Add(this.txtSrSlovo);
            this.groupBoxPodaciAO.Controls.Add(this.label7);
            this.groupBoxPodaciAO.Controls.Add(this.txtPrezime);
            this.groupBoxPodaciAO.Controls.Add(this.label8);
            this.groupBoxPodaciAO.Controls.Add(this.txtIme);
            this.groupBoxPodaciAO.Controls.Add(this.label9);
            this.groupBoxPodaciAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPodaciAO.Location = new System.Drawing.Point(39, 83);
            this.groupBoxPodaciAO.Name = "groupBoxPodaciAO";
            this.groupBoxPodaciAO.Size = new System.Drawing.Size(901, 207);
            this.groupBoxPodaciAO.TabIndex = 25;
            this.groupBoxPodaciAO.TabStop = false;
            this.groupBoxPodaciAO.Text = "Podaci o administrativnom osoblju";
            // 
            // btnIzmeniAO
            // 
            this.btnIzmeniAO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnIzmeniAO.BorderColor = System.Drawing.Color.Black;
            this.btnIzmeniAO.ButtonColor = System.Drawing.Color.SandyBrown;
            this.btnIzmeniAO.FlatAppearance.BorderSize = 0;
            this.btnIzmeniAO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnIzmeniAO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmeniAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniAO.Location = new System.Drawing.Point(688, 126);
            this.btnIzmeniAO.Name = "btnIzmeniAO";
            this.btnIzmeniAO.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnIzmeniAO.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnIzmeniAO.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnIzmeniAO.Size = new System.Drawing.Size(183, 61);
            this.btnIzmeniAO.TabIndex = 4;
            this.btnIzmeniAO.Text = "Sačuvaj promene";
            this.btnIzmeniAO.TextColor = System.Drawing.Color.Black;
            this.btnIzmeniAO.UseVisualStyleBackColor = false;
            this.btnIzmeniAO.Click += new System.EventHandler(this.btnIzmeniAO_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1004, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1263, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 235);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 24);
            this.label10.TabIndex = 28;
            this.label10.Text = "Lista preuzetih vožnji";
            // 
            // borderLabel6
            // 
            this.borderLabel6.AutoSize = true;
            this.borderLabel6.BackColor = System.Drawing.Color.Transparent;
            this.borderLabel6.BorderColor = System.Drawing.Color.Black;
            this.borderLabel6.BorderSize = 1.5F;
            this.borderLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderLabel6.ForeColor = System.Drawing.Color.Yellow;
            this.borderLabel6.Location = new System.Drawing.Point(-33, -226);
            this.borderLabel6.Name = "borderLabel6";
            this.borderLabel6.Size = new System.Drawing.Size(494, 39);
            this.borderLabel6.TabIndex = 3;
            this.borderLabel6.Text = "LISTA DODELJENIH VOZNJI";
            // 
            // AdministrativnoOsobljePrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1522, 662);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxPodaciAO);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.borderLabel6);
            this.Controls.Add(this.listPreuzeteVoznje);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1540, 709);
            this.MinimumSize = new System.Drawing.Size(1540, 709);
            this.Name = "AdministrativnoOsobljePrikaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sve informacije o administrativnom osoblju";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministrativnoOsobljePrikaz_FormClosing);
            this.groupBoxPodaciAO.ResumeLayout(false);
            this.groupBoxPodaciAO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listPreuzeteVoznje;
        private System.Windows.Forms.ColumnHeader IDVoznje;
        private System.Windows.Forms.ColumnHeader PocetnaStanica;
        private System.Windows.Forms.ColumnHeader KrajnjaStanica;
        private System.Windows.Forms.ColumnHeader VremePoziva;
        private System.Windows.Forms.ColumnHeader VremePocetka;
        private System.Windows.Forms.ColumnHeader VremeKraja;
        private System.Windows.Forms.ColumnHeader CenaVoznje;
        private System.Windows.Forms.ColumnHeader BrojTelefona;
        private cSouza.WinForms.Controls.BorderLabel borderLabel6;
        private ePOSOne.btnProduct.Button_WOC btnIzmeniAO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtSrSlovo;
        private System.Windows.Forms.TextBox txtJmbg;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtStrucnaSprema;
        private System.Windows.Forms.TextBox txtUlica;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.ColumnHeader IDMusterije;
        private System.Windows.Forms.ColumnHeader IDVozaca;
        private System.Windows.Forms.GroupBox groupBoxPodaciAO;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
    }
}