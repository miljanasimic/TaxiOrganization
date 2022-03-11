
namespace TaksiUdruzenje.Forme
{
    partial class VoznjaForm
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
            this.lstVoznje = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pocetna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.krajnja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vremePocetka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstNeaktivne = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vremeKraja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPrikaziVoznju = new ePOSOne.btnProduct.Button_WOC();
            this.btnZavrsiVoznju = new ePOSOne.btnProduct.Button_WOC();
            this.btnIzbrisiVoznju = new ePOSOne.btnProduct.Button_WOC();
            this.btnDodajVoznju = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // lstVoznje
            // 
            this.lstVoznje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lstVoznje.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.pocetna,
            this.krajnja,
            this.cena,
            this.vremePocetka,
            this.vremeKraja});
            this.lstVoznje.FullRowSelect = true;
            this.lstVoznje.GridLines = true;
            this.lstVoznje.HideSelection = false;
            this.lstVoznje.Location = new System.Drawing.Point(45, 94);
            this.lstVoznje.Name = "lstVoznje";
            this.lstVoznje.Size = new System.Drawing.Size(1077, 228);
            this.lstVoznje.TabIndex = 0;
            this.lstVoznje.UseCompatibleStateImageBehavior = false;
            this.lstVoznje.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID Vožnje";
            this.id.Width = 152;
            // 
            // pocetna
            // 
            this.pocetna.Text = "Početna stanica";
            this.pocetna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pocetna.Width = 145;
            // 
            // krajnja
            // 
            this.krajnja.Text = "Krajnja stanica";
            this.krajnja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.krajnja.Width = 154;
            // 
            // vremePocetka
            // 
            this.vremePocetka.Text = "Vreme početka";
            this.vremePocetka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vremePocetka.Width = 193;
            // 
            // lstNeaktivne
            // 
            this.lstNeaktivne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lstNeaktivne.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstNeaktivne.FullRowSelect = true;
            this.lstNeaktivne.GridLines = true;
            this.lstNeaktivne.HideSelection = false;
            this.lstNeaktivne.Location = new System.Drawing.Point(45, 363);
            this.lstNeaktivne.Name = "lstNeaktivne";
            this.lstNeaktivne.Size = new System.Drawing.Size(1080, 238);
            this.lstNeaktivne.TabIndex = 5;
            this.lstNeaktivne.UseCompatibleStateImageBehavior = false;
            this.lstNeaktivne.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "ID Vožnje";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 153;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Početna stanica";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 143;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Krajnja stanica";
            this.columnHeader3.Width = 154;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cena";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 71;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Vreme početka";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 201;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Vreme kraja";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 176;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label1.Location = new System.Drawing.Point(449, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lista aktivnih vožnji";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label2.Location = new System.Drawing.Point(460, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lista završenih vožnji";
            // 
            // cena
            // 
            this.cena.Text = "Cena";
            this.cena.Width = 78;
            // 
            // vremeKraja
            // 
            this.vremeKraja.Text = "Vreme kraja";
            this.vremeKraja.Width = 175;
            // 
            // btnPrikaziVoznju
            // 
            this.btnPrikaziVoznju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnPrikaziVoznju.BorderColor = System.Drawing.Color.Black;
            this.btnPrikaziVoznju.ButtonColor = System.Drawing.Color.Yellow;
            this.btnPrikaziVoznju.FlatAppearance.BorderSize = 0;
            this.btnPrikaziVoznju.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnPrikaziVoznju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikaziVoznju.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrikaziVoznju.Location = new System.Drawing.Point(830, 616);
            this.btnPrikaziVoznju.Name = "btnPrikaziVoznju";
            this.btnPrikaziVoznju.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrikaziVoznju.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.btnPrikaziVoznju.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnPrikaziVoznju.Size = new System.Drawing.Size(203, 53);
            this.btnPrikaziVoznju.TabIndex = 4;
            this.btnPrikaziVoznju.Text = "Prikaži/Izmeni";
            this.btnPrikaziVoznju.TextColor = System.Drawing.Color.Black;
            this.btnPrikaziVoznju.UseVisualStyleBackColor = false;
            this.btnPrikaziVoznju.Click += new System.EventHandler(this.btnPrikaziVoznju_Click);
            // 
            // btnZavrsiVoznju
            // 
            this.btnZavrsiVoznju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnZavrsiVoznju.BorderColor = System.Drawing.Color.Black;
            this.btnZavrsiVoznju.ButtonColor = System.Drawing.Color.Yellow;
            this.btnZavrsiVoznju.FlatAppearance.BorderSize = 0;
            this.btnZavrsiVoznju.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnZavrsiVoznju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZavrsiVoznju.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnZavrsiVoznju.Location = new System.Drawing.Point(585, 616);
            this.btnZavrsiVoznju.Name = "btnZavrsiVoznju";
            this.btnZavrsiVoznju.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnZavrsiVoznju.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.btnZavrsiVoznju.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnZavrsiVoznju.Size = new System.Drawing.Size(203, 53);
            this.btnZavrsiVoznju.TabIndex = 3;
            this.btnZavrsiVoznju.Text = "Završi vožnju";
            this.btnZavrsiVoznju.TextColor = System.Drawing.Color.Black;
            this.btnZavrsiVoznju.UseVisualStyleBackColor = false;
            this.btnZavrsiVoznju.Click += new System.EventHandler(this.btnZavrsiVoznju_Click);
            // 
            // btnIzbrisiVoznju
            // 
            this.btnIzbrisiVoznju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnIzbrisiVoznju.BorderColor = System.Drawing.Color.Black;
            this.btnIzbrisiVoznju.ButtonColor = System.Drawing.Color.Yellow;
            this.btnIzbrisiVoznju.FlatAppearance.BorderSize = 0;
            this.btnIzbrisiVoznju.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnIzbrisiVoznju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzbrisiVoznju.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnIzbrisiVoznju.Location = new System.Drawing.Point(328, 616);
            this.btnIzbrisiVoznju.Name = "btnIzbrisiVoznju";
            this.btnIzbrisiVoznju.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnIzbrisiVoznju.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.btnIzbrisiVoznju.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnIzbrisiVoznju.Size = new System.Drawing.Size(213, 53);
            this.btnIzbrisiVoznju.TabIndex = 2;
            this.btnIzbrisiVoznju.Text = "Obriši vožnju";
            this.btnIzbrisiVoznju.TextColor = System.Drawing.Color.Black;
            this.btnIzbrisiVoznju.UseVisualStyleBackColor = false;
            this.btnIzbrisiVoznju.Click += new System.EventHandler(this.btnIzbrisiVoznju_Click);
            // 
            // btnDodajVoznju
            // 
            this.btnDodajVoznju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnDodajVoznju.BorderColor = System.Drawing.Color.Black;
            this.btnDodajVoznju.ButtonColor = System.Drawing.Color.Yellow;
            this.btnDodajVoznju.FlatAppearance.BorderSize = 0;
            this.btnDodajVoznju.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnDodajVoznju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajVoznju.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodajVoznju.Location = new System.Drawing.Point(82, 616);
            this.btnDodajVoznju.Name = "btnDodajVoznju";
            this.btnDodajVoznju.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDodajVoznju.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.btnDodajVoznju.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnDodajVoznju.Size = new System.Drawing.Size(203, 53);
            this.btnDodajVoznju.TabIndex = 1;
            this.btnDodajVoznju.Text = "Dodaj vožnju";
            this.btnDodajVoznju.TextColor = System.Drawing.Color.Black;
            this.btnDodajVoznju.UseVisualStyleBackColor = false;
            this.btnDodajVoznju.Click += new System.EventHandler(this.btnDodajVoznju_Click);
            // 
            // VoznjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::TaksiUdruzenje.Properties.Resources.taxi_background_city_landscape_many_houses_31606038;
            this.ClientSize = new System.Drawing.Size(1173, 715);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstNeaktivne);
            this.Controls.Add(this.btnPrikaziVoznju);
            this.Controls.Add(this.btnZavrsiVoznju);
            this.Controls.Add(this.btnIzbrisiVoznju);
            this.Controls.Add(this.btnDodajVoznju);
            this.Controls.Add(this.lstVoznje);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1191, 762);
            this.MinimumSize = new System.Drawing.Size(1191, 762);
            this.Name = "VoznjaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vožnje";
            this.Load += new System.EventHandler(this.VoznjaForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.VoznjaForm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstVoznje;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader pocetna;
        private System.Windows.Forms.ColumnHeader krajnja;
        private System.Windows.Forms.ColumnHeader vremePocetka;
        private ePOSOne.btnProduct.Button_WOC btnDodajVoznju;
        private ePOSOne.btnProduct.Button_WOC btnIzbrisiVoznju;
        private ePOSOne.btnProduct.Button_WOC btnZavrsiVoznju;
        private ePOSOne.btnProduct.Button_WOC btnPrikaziVoznju;
        private System.Windows.Forms.ListView lstNeaktivne;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader cena;
        private System.Windows.Forms.ColumnHeader vremeKraja;
    }
}