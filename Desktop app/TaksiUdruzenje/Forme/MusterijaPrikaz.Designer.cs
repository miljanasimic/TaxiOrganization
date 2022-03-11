
namespace TaksiUdruzenje.Forme
{
    partial class MusterijaPrikaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusterijaPrikaz));
            this.lblID = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lstPopusti = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vrednost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pocetak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kraj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblTelefoni = new System.Windows.Forms.Label();
            this.lstTelefoni = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.lstVoznje = new System.Windows.Forms.ListView();
            this.IDVoznje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pocetna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Krajnja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrTelefona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPrez = new System.Windows.Forms.Label();
            this.lblIdValue = new System.Windows.Forms.Label();
            this.btnIzmeniPopust = new ePOSOne.btnProduct.Button_WOC();
            this.btnObrisiPopust = new ePOSOne.btnProduct.Button_WOC();
            this.btnPrikaziVoznju = new ePOSOne.btnProduct.Button_WOC();
            this.btnDodajPopust = new ePOSOne.btnProduct.Button_WOC();
            this.btnDodajTelefon = new ePOSOne.btnProduct.Button_WOC();
            this.btnObrisiTelefone = new ePOSOne.btnProduct.Button_WOC();
            this.btnIzmeniMusteriju = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(350, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(42, 24);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID : ";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(40, 25);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(56, 24);
            this.lblIme.TabIndex = 2;
            this.lblIme.Text = "Ime : ";
            // 
            // lstPopusti
            // 
            this.lstPopusti.BackColor = System.Drawing.Color.Tan;
            this.lstPopusti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Vrednost,
            this.Pocetak,
            this.Kraj});
            this.lstPopusti.FullRowSelect = true;
            this.lstPopusti.GridLines = true;
            this.lstPopusti.HideSelection = false;
            this.lstPopusti.Location = new System.Drawing.Point(12, 540);
            this.lstPopusti.Name = "lstPopusti";
            this.lstPopusti.Size = new System.Drawing.Size(776, 128);
            this.lstPopusti.TabIndex = 5;
            this.lstPopusti.UseCompatibleStateImageBehavior = false;
            this.lstPopusti.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 75;
            // 
            // Vrednost
            // 
            this.Vrednost.Text = "Vrednost popusta";
            this.Vrednost.Width = 145;
            // 
            // Pocetak
            // 
            this.Pocetak.Text = "Datum pocetka";
            this.Pocetak.Width = 136;
            // 
            // Kraj
            // 
            this.Kraj.Text = "Datum kraja";
            this.Kraj.Width = 157;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Popusti musterije";
            // 
            // lblTelefoni
            // 
            this.lblTelefoni.AutoSize = true;
            this.lblTelefoni.BackColor = System.Drawing.Color.Khaki;
            this.lblTelefoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoni.Location = new System.Drawing.Point(40, 150);
            this.lblTelefoni.Name = "lblTelefoni";
            this.lblTelefoni.Size = new System.Drawing.Size(93, 24);
            this.lblTelefoni.TabIndex = 7;
            this.lblTelefoni.Text = "Telefoni : ";
            // 
            // lstTelefoni
            // 
            this.lstTelefoni.BackColor = System.Drawing.Color.Tan;
            this.lstTelefoni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstTelefoni.HideSelection = false;
            this.lstTelefoni.Location = new System.Drawing.Point(145, 150);
            this.lstTelefoni.Name = "lstTelefoni";
            this.lstTelefoni.Size = new System.Drawing.Size(136, 93);
            this.lstTelefoni.TabIndex = 8;
            this.lstTelefoni.UseCompatibleStateImageBehavior = false;
            this.lstTelefoni.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Telefoni";
            this.columnHeader1.Width = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Voznje";
            // 
            // lstVoznje
            // 
            this.lstVoznje.BackColor = System.Drawing.Color.Tan;
            this.lstVoznje.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDVoznje,
            this.Pocetna,
            this.Krajnja,
            this.Cena,
            this.BrTelefona});
            this.lstVoznje.FullRowSelect = true;
            this.lstVoznje.GridLines = true;
            this.lstVoznje.HideSelection = false;
            this.lstVoznje.Location = new System.Drawing.Point(12, 291);
            this.lstVoznje.Name = "lstVoznje";
            this.lstVoznje.Size = new System.Drawing.Size(776, 128);
            this.lstVoznje.TabIndex = 10;
            this.lstVoznje.UseCompatibleStateImageBehavior = false;
            this.lstVoznje.View = System.Windows.Forms.View.Details;
            // 
            // IDVoznje
            // 
            this.IDVoznje.Text = "ID";
            this.IDVoznje.Width = 50;
            // 
            // Pocetna
            // 
            this.Pocetna.Text = "Pocetna stanica";
            this.Pocetna.Width = 138;
            // 
            // Krajnja
            // 
            this.Krajnja.Text = "Krajnja stanica";
            this.Krajnja.Width = 218;
            // 
            // Cena
            // 
            this.Cena.Text = "Cena voznje";
            this.Cena.Width = 134;
            // 
            // BrTelefona
            // 
            this.BrTelefona.Text = "Broj telefona poziva";
            this.BrTelefona.Width = 110;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(145, 67);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(136, 22);
            this.txtPrezime.TabIndex = 12;
            this.txtPrezime.TextChanged += new System.EventHandler(this.txtPrezime_TextChanged);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(145, 27);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(136, 22);
            this.txtIme.TabIndex = 13;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresa.Location = new System.Drawing.Point(40, 108);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(85, 24);
            this.lblAdresa.TabIndex = 15;
            this.lblAdresa.Text = "Adresa : ";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(145, 110);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(136, 22);
            this.txtAdresa.TabIndex = 16;
            this.txtAdresa.TextChanged += new System.EventHandler(this.txtAdresa_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Orange;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(538, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 149);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblPrez
            // 
            this.lblPrez.AutoSize = true;
            this.lblPrez.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrez.Location = new System.Drawing.Point(40, 65);
            this.lblPrez.Name = "lblPrez";
            this.lblPrez.Size = new System.Drawing.Size(94, 24);
            this.lblPrez.TabIndex = 24;
            this.lblPrez.Text = "Prezime : ";
            // 
            // lblIdValue
            // 
            this.lblIdValue.AutoSize = true;
            this.lblIdValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdValue.Location = new System.Drawing.Point(398, 25);
            this.lblIdValue.Name = "lblIdValue";
            this.lblIdValue.Size = new System.Drawing.Size(66, 24);
            this.lblIdValue.TabIndex = 25;
            this.lblIdValue.Text = "label3";
            // 
            // btnIzmeniPopust
            // 
            this.btnIzmeniPopust.BorderColor = System.Drawing.Color.Silver;
            this.btnIzmeniPopust.ButtonColor = System.Drawing.Color.Peru;
            this.btnIzmeniPopust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniPopust.Location = new System.Drawing.Point(571, 674);
            this.btnIzmeniPopust.Name = "btnIzmeniPopust";
            this.btnIzmeniPopust.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnIzmeniPopust.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnIzmeniPopust.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnIzmeniPopust.Size = new System.Drawing.Size(157, 42);
            this.btnIzmeniPopust.TabIndex = 23;
            this.btnIzmeniPopust.Text = "Produzi popust";
            this.btnIzmeniPopust.TextColor = System.Drawing.Color.White;
            this.btnIzmeniPopust.UseVisualStyleBackColor = true;
            this.btnIzmeniPopust.Click += new System.EventHandler(this.btnIzmeniPopust_Click);
            // 
            // btnObrisiPopust
            // 
            this.btnObrisiPopust.BorderColor = System.Drawing.Color.Silver;
            this.btnObrisiPopust.ButtonColor = System.Drawing.Color.Peru;
            this.btnObrisiPopust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiPopust.Location = new System.Drawing.Point(324, 674);
            this.btnObrisiPopust.Name = "btnObrisiPopust";
            this.btnObrisiPopust.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnObrisiPopust.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnObrisiPopust.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnObrisiPopust.Size = new System.Drawing.Size(157, 42);
            this.btnObrisiPopust.TabIndex = 22;
            this.btnObrisiPopust.Text = "Obrisi popust";
            this.btnObrisiPopust.TextColor = System.Drawing.Color.White;
            this.btnObrisiPopust.UseVisualStyleBackColor = true;
            this.btnObrisiPopust.Click += new System.EventHandler(this.btnObrisiPopust_Click);
            // 
            // btnPrikaziVoznju
            // 
            this.btnPrikaziVoznju.BorderColor = System.Drawing.Color.Silver;
            this.btnPrikaziVoznju.ButtonColor = System.Drawing.Color.Peru;
            this.btnPrikaziVoznju.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziVoznju.Location = new System.Drawing.Point(324, 425);
            this.btnPrikaziVoznju.Name = "btnPrikaziVoznju";
            this.btnPrikaziVoznju.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnPrikaziVoznju.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnPrikaziVoznju.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnPrikaziVoznju.Size = new System.Drawing.Size(157, 42);
            this.btnPrikaziVoznju.TabIndex = 20;
            this.btnPrikaziVoznju.Text = "Prikazi voznju";
            this.btnPrikaziVoznju.TextColor = System.Drawing.Color.White;
            this.btnPrikaziVoznju.UseVisualStyleBackColor = true;
            this.btnPrikaziVoznju.Click += new System.EventHandler(this.btnPrikaziVoznju_Click);
            // 
            // btnDodajPopust
            // 
            this.btnDodajPopust.BorderColor = System.Drawing.Color.Silver;
            this.btnDodajPopust.ButtonColor = System.Drawing.Color.Peru;
            this.btnDodajPopust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPopust.Location = new System.Drawing.Point(76, 674);
            this.btnDodajPopust.Name = "btnDodajPopust";
            this.btnDodajPopust.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnDodajPopust.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnDodajPopust.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnDodajPopust.Size = new System.Drawing.Size(157, 42);
            this.btnDodajPopust.TabIndex = 18;
            this.btnDodajPopust.Text = "Dodaj popust";
            this.btnDodajPopust.TextColor = System.Drawing.Color.White;
            this.btnDodajPopust.UseVisualStyleBackColor = true;
            this.btnDodajPopust.Click += new System.EventHandler(this.btnDodajPopust_Click);
            // 
            // btnDodajTelefon
            // 
            this.btnDodajTelefon.BorderColor = System.Drawing.Color.Silver;
            this.btnDodajTelefon.ButtonColor = System.Drawing.Color.Peru;
            this.btnDodajTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajTelefon.Location = new System.Drawing.Point(287, 150);
            this.btnDodajTelefon.Name = "btnDodajTelefon";
            this.btnDodajTelefon.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnDodajTelefon.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnDodajTelefon.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnDodajTelefon.Size = new System.Drawing.Size(122, 43);
            this.btnDodajTelefon.TabIndex = 17;
            this.btnDodajTelefon.Text = "Dodaj telefon";
            this.btnDodajTelefon.TextColor = System.Drawing.Color.White;
            this.btnDodajTelefon.UseVisualStyleBackColor = true;
            this.btnDodajTelefon.Click += new System.EventHandler(this.btnDodajTelefon_Click);
            // 
            // btnObrisiTelefone
            // 
            this.btnObrisiTelefone.BorderColor = System.Drawing.Color.Silver;
            this.btnObrisiTelefone.ButtonColor = System.Drawing.Color.Peru;
            this.btnObrisiTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiTelefone.Location = new System.Drawing.Point(287, 199);
            this.btnObrisiTelefone.Name = "btnObrisiTelefone";
            this.btnObrisiTelefone.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnObrisiTelefone.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnObrisiTelefone.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnObrisiTelefone.Size = new System.Drawing.Size(122, 42);
            this.btnObrisiTelefone.TabIndex = 14;
            this.btnObrisiTelefone.Text = "Obrisi telefone";
            this.btnObrisiTelefone.TextColor = System.Drawing.Color.White;
            this.btnObrisiTelefone.UseVisualStyleBackColor = true;
            this.btnObrisiTelefone.Click += new System.EventHandler(this.btnObrisiTelefone_Click);
            // 
            // btnIzmeniMusteriju
            // 
            this.btnIzmeniMusteriju.BorderColor = System.Drawing.Color.Silver;
            this.btnIzmeniMusteriju.ButtonColor = System.Drawing.Color.Peru;
            this.btnIzmeniMusteriju.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniMusteriju.Location = new System.Drawing.Point(287, 779);
            this.btnIzmeniMusteriju.Name = "btnIzmeniMusteriju";
            this.btnIzmeniMusteriju.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnIzmeniMusteriju.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnIzmeniMusteriju.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnIzmeniMusteriju.Size = new System.Drawing.Size(225, 59);
            this.btnIzmeniMusteriju.TabIndex = 11;
            this.btnIzmeniMusteriju.Text = "Sacuvaj izmene";
            this.btnIzmeniMusteriju.TextColor = System.Drawing.Color.White;
            this.btnIzmeniMusteriju.UseVisualStyleBackColor = true;
            this.btnIzmeniMusteriju.Click += new System.EventHandler(this.btnIzmeniMusteriju_Click);
            // 
            // MusterijaPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 850);
            this.Controls.Add(this.lblIdValue);
            this.Controls.Add(this.lblPrez);
            this.Controls.Add(this.btnIzmeniPopust);
            this.Controls.Add(this.btnObrisiPopust);
            this.Controls.Add(this.btnPrikaziVoznju);
            this.Controls.Add(this.btnDodajPopust);
            this.Controls.Add(this.btnDodajTelefon);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.btnObrisiTelefone);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.btnIzmeniMusteriju);
            this.Controls.Add(this.lstVoznje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstTelefoni);
            this.Controls.Add(this.lblTelefoni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPopusti);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MusterijaPrikaz";
            this.Text = "MusterijaPrikaz";
            this.Load += new System.EventHandler(this.MusterijaPrikaz_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MusterijaPrikaz_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.ListView lstPopusti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTelefoni;
        private System.Windows.Forms.ListView lstTelefoni;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstVoznje;
        private ePOSOne.btnProduct.Button_WOC btnIzmeniMusteriju;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private ePOSOne.btnProduct.Button_WOC btnObrisiTelefone;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.ColumnHeader IDVoznje;
        private System.Windows.Forms.ColumnHeader Pocetna;
        private System.Windows.Forms.ColumnHeader Krajnja;
        private System.Windows.Forms.ColumnHeader Cena;
        private System.Windows.Forms.ColumnHeader BrTelefona;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Vrednost;
        private System.Windows.Forms.ColumnHeader Pocetak;
        private System.Windows.Forms.ColumnHeader Kraj;
        private ePOSOne.btnProduct.Button_WOC btnDodajTelefon;
        private ePOSOne.btnProduct.Button_WOC btnDodajPopust;
        private ePOSOne.btnProduct.Button_WOC btnPrikaziVoznju;
        private ePOSOne.btnProduct.Button_WOC btnObrisiPopust;
        private ePOSOne.btnProduct.Button_WOC btnIzmeniPopust;
        private System.Windows.Forms.Label lblPrez;
        private System.Windows.Forms.Label lblIdValue;
    }
}