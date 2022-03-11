
namespace TaksiUdruzenje.Forme
{
    partial class VoznjaPrikazForm
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblIdValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPocetna = new System.Windows.Forms.TextBox();
            this.txtKrajnja = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lstAdministrativno = new System.Windows.Forms.ListView();
            this.IdAdmin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImeAdmin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrezimeAdmin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sprema = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstVozac = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrDozvole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstMusterija = new System.Windows.Forms.ListView();
            this.IdMusterija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imeMusterija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prezMusterija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brVoznji = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpVremePoziva = new System.Windows.Forms.DateTimePicker();
            this.dtpVremePocetka = new System.Windows.Forms.DateTimePicker();
            this.grpInformacije = new System.Windows.Forms.GroupBox();
            this.btnIzmeni = new ePOSOne.btnProduct.Button_WOC();
            this.dtpVremeKraja = new System.Windows.Forms.TextBox();
            this.grpInformacije.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(332, 21);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(106, 24);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID Voznje : ";
            // 
            // lblIdValue
            // 
            this.lblIdValue.AutoSize = true;
            this.lblIdValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdValue.Location = new System.Drawing.Point(446, 21);
            this.lblIdValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdValue.Name = "lblIdValue";
            this.lblIdValue.Size = new System.Drawing.Size(66, 24);
            this.lblIdValue.TabIndex = 1;
            this.lblIdValue.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pocetna stanica : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Krajnja stanica : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vreme poziva : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(245, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cena voznje : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(433, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Vreme pocetka : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(433, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Vreme kraja : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(433, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Broj telefona : ";
            // 
            // txtPocetna
            // 
            this.txtPocetna.Location = new System.Drawing.Point(201, 39);
            this.txtPocetna.Name = "txtPocetna";
            this.txtPocetna.Size = new System.Drawing.Size(194, 28);
            this.txtPocetna.TabIndex = 9;
            this.txtPocetna.TextChanged += new System.EventHandler(this.txtPocetna_TextChanged);
            // 
            // txtKrajnja
            // 
            this.txtKrajnja.Location = new System.Drawing.Point(201, 104);
            this.txtKrajnja.Name = "txtKrajnja";
            this.txtKrajnja.Size = new System.Drawing.Size(194, 28);
            this.txtKrajnja.TabIndex = 10;
            this.txtKrajnja.TextChanged += new System.EventHandler(this.txtKrajnja_TextChanged);
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(398, 243);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(179, 28);
            this.txtCena.TabIndex = 12;
            this.txtCena.TextChanged += new System.EventHandler(this.txtCena_TextChanged);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Enabled = false;
            this.txtTelefon.Location = new System.Drawing.Point(593, 175);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(195, 28);
            this.txtTelefon.TabIndex = 15;
            // 
            // lstAdministrativno
            // 
            this.lstAdministrativno.BackColor = System.Drawing.Color.Tan;
            this.lstAdministrativno.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdAdmin,
            this.ImeAdmin,
            this.PrezimeAdmin,
            this.sprema});
            this.lstAdministrativno.FullRowSelect = true;
            this.lstAdministrativno.GridLines = true;
            this.lstAdministrativno.HideSelection = false;
            this.lstAdministrativno.Location = new System.Drawing.Point(43, 513);
            this.lstAdministrativno.Name = "lstAdministrativno";
            this.lstAdministrativno.Size = new System.Drawing.Size(831, 73);
            this.lstAdministrativno.TabIndex = 16;
            this.lstAdministrativno.UseCompatibleStateImageBehavior = false;
            this.lstAdministrativno.View = System.Windows.Forms.View.Details;
            this.lstAdministrativno.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstAdministrativno_MouseDoubleClick);
            // 
            // IdAdmin
            // 
            this.IdAdmin.Text = "ID osoblja";
            this.IdAdmin.Width = 162;
            // 
            // ImeAdmin
            // 
            this.ImeAdmin.Text = "Ime";
            this.ImeAdmin.Width = 184;
            // 
            // PrezimeAdmin
            // 
            this.PrezimeAdmin.Text = "Prezime";
            this.PrezimeAdmin.Width = 214;
            // 
            // sprema
            // 
            this.sprema.Text = "Strucna sprema";
            this.sprema.Width = 215;
            // 
            // lstVozac
            // 
            this.lstVozac.BackColor = System.Drawing.Color.Tan;
            this.lstVozac.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Ime,
            this.Prezime,
            this.BrDozvole});
            this.lstVozac.FullRowSelect = true;
            this.lstVozac.GridLines = true;
            this.lstVozac.HideSelection = false;
            this.lstVozac.Location = new System.Drawing.Point(43, 399);
            this.lstVozac.Name = "lstVozac";
            this.lstVozac.Size = new System.Drawing.Size(831, 73);
            this.lstVozac.TabIndex = 17;
            this.lstVozac.UseCompatibleStateImageBehavior = false;
            this.lstVozac.View = System.Windows.Forms.View.Details;
            this.lstVozac.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstVozac_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.Text = "ID vozaca";
            this.Id.Width = 159;
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.Width = 184;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.Width = 209;
            // 
            // BrDozvole
            // 
            this.BrDozvole.Text = "Broj dozvole";
            this.BrDozvole.Width = 221;
            // 
            // lstMusterija
            // 
            this.lstMusterija.BackColor = System.Drawing.Color.Tan;
            this.lstMusterija.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdMusterija,
            this.imeMusterija,
            this.prezMusterija,
            this.adresa,
            this.brVoznji});
            this.lstMusterija.FullRowSelect = true;
            this.lstMusterija.GridLines = true;
            this.lstMusterija.HideSelection = false;
            this.lstMusterija.Location = new System.Drawing.Point(43, 619);
            this.lstMusterija.Name = "lstMusterija";
            this.lstMusterija.Size = new System.Drawing.Size(831, 73);
            this.lstMusterija.TabIndex = 18;
            this.lstMusterija.UseCompatibleStateImageBehavior = false;
            this.lstMusterija.View = System.Windows.Forms.View.Details;
            this.lstMusterija.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstMusterija_MouseDoubleClick);
            // 
            // IdMusterija
            // 
            this.IdMusterija.Text = "ID musterije";
            this.IdMusterija.Width = 132;
            // 
            // imeMusterija
            // 
            this.imeMusterija.Text = "Ime";
            this.imeMusterija.Width = 151;
            // 
            // prezMusterija
            // 
            this.prezMusterija.Text = "Prezime";
            this.prezMusterija.Width = 171;
            // 
            // adresa
            // 
            this.adresa.Text = "Adresa";
            this.adresa.Width = 188;
            // 
            // brVoznji
            // 
            this.brVoznji.Text = "Broj voznji";
            this.brVoznji.Width = 140;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Vozac";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(346, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Administrativno osoblje";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(404, 592);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "Musterija";
            // 
            // dtpVremePoziva
            // 
            this.dtpVremePoziva.CustomFormat = "dd.MM.yy - hh:mm";
            this.dtpVremePoziva.Enabled = false;
            this.dtpVremePoziva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVremePoziva.Location = new System.Drawing.Point(201, 173);
            this.dtpVremePoziva.Name = "dtpVremePoziva";
            this.dtpVremePoziva.Size = new System.Drawing.Size(194, 28);
            this.dtpVremePoziva.TabIndex = 22;
            // 
            // dtpVremePocetka
            // 
            this.dtpVremePocetka.CustomFormat = "dd.MM.yy - hh:mm";
            this.dtpVremePocetka.Enabled = false;
            this.dtpVremePocetka.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVremePocetka.Location = new System.Drawing.Point(593, 37);
            this.dtpVremePocetka.Name = "dtpVremePocetka";
            this.dtpVremePocetka.Size = new System.Drawing.Size(195, 28);
            this.dtpVremePocetka.TabIndex = 23;
            // 
            // grpInformacije
            // 
            this.grpInformacije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpInformacije.Controls.Add(this.dtpVremeKraja);
            this.grpInformacije.Controls.Add(this.dtpVremePocetka);
            this.grpInformacije.Controls.Add(this.dtpVremePoziva);
            this.grpInformacije.Controls.Add(this.txtTelefon);
            this.grpInformacije.Controls.Add(this.txtCena);
            this.grpInformacije.Controls.Add(this.txtKrajnja);
            this.grpInformacije.Controls.Add(this.txtPocetna);
            this.grpInformacije.Controls.Add(this.label7);
            this.grpInformacije.Controls.Add(this.label6);
            this.grpInformacije.Controls.Add(this.label5);
            this.grpInformacije.Controls.Add(this.label4);
            this.grpInformacije.Controls.Add(this.label3);
            this.grpInformacije.Controls.Add(this.label2);
            this.grpInformacije.Controls.Add(this.label1);
            this.grpInformacije.Location = new System.Drawing.Point(43, 59);
            this.grpInformacije.Name = "grpInformacije";
            this.grpInformacije.Size = new System.Drawing.Size(831, 303);
            this.grpInformacije.TabIndex = 25;
            this.grpInformacije.TabStop = false;
            this.grpInformacije.Text = "Informacije";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BorderColor = System.Drawing.Color.Black;
            this.btnIzmeni.ButtonColor = System.Drawing.Color.SandyBrown;
            this.btnIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnIzmeni.Location = new System.Drawing.Point(350, 706);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnIzmeni.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnIzmeni.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnIzmeni.Size = new System.Drawing.Size(209, 57);
            this.btnIzmeni.TabIndex = 26;
            this.btnIzmeni.Text = "Sačuvaj izmene";
            this.btnIzmeni.TextColor = System.Drawing.Color.Black;
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // dtpVremeKraja
            // 
            this.dtpVremeKraja.Enabled = false;
            this.dtpVremeKraja.Location = new System.Drawing.Point(593, 104);
            this.dtpVremeKraja.Name = "dtpVremeKraja";
            this.dtpVremeKraja.Size = new System.Drawing.Size(195, 28);
            this.dtpVremeKraja.TabIndex = 24;
            // 
            // VoznjaPrikazForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(920, 775);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.grpInformacije);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstMusterija);
            this.Controls.Add(this.lstVozac);
            this.Controls.Add(this.lstAdministrativno);
            this.Controls.Add(this.lblIdValue);
            this.Controls.Add(this.lblId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VoznjaPrikazForm";
            this.Text = "Prikaz vožnje";
            this.Load += new System.EventHandler(this.VoznjaPrikazForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.VoznjaPrikazForm_MouseClick);
            this.grpInformacije.ResumeLayout(false);
            this.grpInformacije.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIdValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPocetna;
        private System.Windows.Forms.TextBox txtKrajnja;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.ListView lstAdministrativno;
        private System.Windows.Forms.ListView lstVozac;
        private System.Windows.Forms.ListView lstMusterija;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpVremePoziva;
        private System.Windows.Forms.DateTimePicker dtpVremePocetka;
        private System.Windows.Forms.GroupBox grpInformacije;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader BrDozvole;
        private System.Windows.Forms.ColumnHeader IdAdmin;
        private System.Windows.Forms.ColumnHeader ImeAdmin;
        private System.Windows.Forms.ColumnHeader PrezimeAdmin;
        private System.Windows.Forms.ColumnHeader sprema;
        private System.Windows.Forms.ColumnHeader IdMusterija;
        private System.Windows.Forms.ColumnHeader imeMusterija;
        private System.Windows.Forms.ColumnHeader prezMusterija;
        private System.Windows.Forms.ColumnHeader adresa;
        private System.Windows.Forms.ColumnHeader brVoznji;
        private ePOSOne.btnProduct.Button_WOC btnIzmeni;
        private System.Windows.Forms.TextBox dtpVremeKraja;
    }
}