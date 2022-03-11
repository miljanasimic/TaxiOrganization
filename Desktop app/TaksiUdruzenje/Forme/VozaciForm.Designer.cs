
namespace TaksiUdruzenje.Forme
{
    partial class VozaciForm
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
            this.btnPrikaziVozaca = new ePOSOne.btnProduct.Button_WOC();
            this.btnObrisiVozaca = new ePOSOne.btnProduct.Button_WOC();
            this.btnDodajVozaca = new ePOSOne.btnProduct.Button_WOC();
            this.label1 = new System.Windows.Forms.Label();
            this.listVozaci = new System.Windows.Forms.ListView();
            this.IdVozaca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Jmbg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SrednjeSlovo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrojTelefona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ulica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Broj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrojDozvole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kategorija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnPrikaziVozaca
            // 
            this.btnPrikaziVozaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrikaziVozaca.BorderColor = System.Drawing.Color.Black;
            this.btnPrikaziVozaca.ButtonColor = System.Drawing.Color.Yellow;
            this.btnPrikaziVozaca.FlatAppearance.BorderSize = 0;
            this.btnPrikaziVozaca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrikaziVozaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikaziVozaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrikaziVozaca.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrikaziVozaca.Location = new System.Drawing.Point(884, 382);
            this.btnPrikaziVozaca.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrikaziVozaca.Name = "btnPrikaziVozaca";
            this.btnPrikaziVozaca.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrikaziVozaca.OnHoverButtonColor = System.Drawing.Color.Black;
            this.btnPrikaziVozaca.OnHoverTextColor = System.Drawing.Color.Yellow;
            this.btnPrikaziVozaca.Size = new System.Drawing.Size(188, 53);
            this.btnPrikaziVozaca.TabIndex = 9;
            this.btnPrikaziVozaca.Text = "Prikaži/Izmeni";
            this.btnPrikaziVozaca.TextColor = System.Drawing.Color.Black;
            this.btnPrikaziVozaca.UseVisualStyleBackColor = true;
            this.btnPrikaziVozaca.Click += new System.EventHandler(this.btnPrikaziVozaca_Click);
            // 
            // btnObrisiVozaca
            // 
            this.btnObrisiVozaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnObrisiVozaca.BorderColor = System.Drawing.Color.Black;
            this.btnObrisiVozaca.ButtonColor = System.Drawing.Color.Yellow;
            this.btnObrisiVozaca.FlatAppearance.BorderSize = 0;
            this.btnObrisiVozaca.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnObrisiVozaca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnObrisiVozaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiVozaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnObrisiVozaca.ForeColor = System.Drawing.Color.Transparent;
            this.btnObrisiVozaca.Location = new System.Drawing.Point(487, 382);
            this.btnObrisiVozaca.Name = "btnObrisiVozaca";
            this.btnObrisiVozaca.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnObrisiVozaca.OnHoverButtonColor = System.Drawing.Color.Black;
            this.btnObrisiVozaca.OnHoverTextColor = System.Drawing.Color.Yellow;
            this.btnObrisiVozaca.Size = new System.Drawing.Size(188, 53);
            this.btnObrisiVozaca.TabIndex = 8;
            this.btnObrisiVozaca.Text = "Obriši vozača";
            this.btnObrisiVozaca.TextColor = System.Drawing.Color.Black;
            this.btnObrisiVozaca.UseVisualStyleBackColor = false;
            this.btnObrisiVozaca.Click += new System.EventHandler(this.btnObrisiVozaca_Click);
            // 
            // btnDodajVozaca
            // 
            this.btnDodajVozaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDodajVozaca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDodajVozaca.BorderColor = System.Drawing.Color.Black;
            this.btnDodajVozaca.ButtonColor = System.Drawing.Color.Yellow;
            this.btnDodajVozaca.FlatAppearance.BorderSize = 0;
            this.btnDodajVozaca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDodajVozaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajVozaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodajVozaca.ForeColor = System.Drawing.Color.Transparent;
            this.btnDodajVozaca.Location = new System.Drawing.Point(143, 382);
            this.btnDodajVozaca.Name = "btnDodajVozaca";
            this.btnDodajVozaca.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDodajVozaca.OnHoverButtonColor = System.Drawing.Color.Black;
            this.btnDodajVozaca.OnHoverTextColor = System.Drawing.Color.Yellow;
            this.btnDodajVozaca.Size = new System.Drawing.Size(188, 53);
            this.btnDodajVozaca.TabIndex = 7;
            this.btnDodajVozaca.Text = "Dodaj vozača";
            this.btnDodajVozaca.TextColor = System.Drawing.Color.Black;
            this.btnDodajVozaca.UseVisualStyleBackColor = false;
            this.btnDodajVozaca.Click += new System.EventHandler(this.btnDodajVozaca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label1.Location = new System.Drawing.Point(519, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lista vozača";
            // 
            // listVozaci
            // 
            this.listVozaci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listVozaci.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdVozaca,
            this.Jmbg,
            this.Ime,
            this.SrednjeSlovo,
            this.Prezime,
            this.BrojTelefona,
            this.Ulica,
            this.Broj,
            this.BrojDozvole,
            this.Kategorija});
            this.listVozaci.FullRowSelect = true;
            this.listVozaci.GridLines = true;
            this.listVozaci.HideSelection = false;
            this.listVozaci.Location = new System.Drawing.Point(73, 88);
            this.listVozaci.Name = "listVozaci";
            this.listVozaci.Size = new System.Drawing.Size(1098, 269);
            this.listVozaci.TabIndex = 5;
            this.listVozaci.UseCompatibleStateImageBehavior = false;
            this.listVozaci.View = System.Windows.Forms.View.Details;
            // 
            // IdVozaca
            // 
            this.IdVozaca.Text = "ID Vozača";
            this.IdVozaca.Width = 114;
            // 
            // Jmbg
            // 
            this.Jmbg.DisplayIndex = 4;
            this.Jmbg.Text = "Jmbg";
            this.Jmbg.Width = 115;
            // 
            // Ime
            // 
            this.Ime.DisplayIndex = 1;
            this.Ime.Text = "Ime";
            this.Ime.Width = 126;
            // 
            // SrednjeSlovo
            // 
            this.SrednjeSlovo.DisplayIndex = 2;
            this.SrednjeSlovo.Text = "Srednje Slovo";
            this.SrednjeSlovo.Width = 110;
            // 
            // Prezime
            // 
            this.Prezime.DisplayIndex = 3;
            this.Prezime.Text = "Prezime";
            this.Prezime.Width = 95;
            // 
            // BrojTelefona
            // 
            this.BrojTelefona.Text = "Broj telefona";
            this.BrojTelefona.Width = 137;
            // 
            // Ulica
            // 
            this.Ulica.Text = "Ulica";
            this.Ulica.Width = 118;
            // 
            // Broj
            // 
            this.Broj.Text = "Broj";
            // 
            // BrojDozvole
            // 
            this.BrojDozvole.Text = "Broj dozvole";
            this.BrojDozvole.Width = 143;
            // 
            // Kategorija
            // 
            this.Kategorija.Text = "Kategorija";
            this.Kategorija.Width = 112;
            // 
            // VozaciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::TaksiUdruzenje.Properties.Resources.taxi_background_city_landscape_many_houses_31606038;
            this.ClientSize = new System.Drawing.Size(1233, 532);
            this.Controls.Add(this.btnPrikaziVozaca);
            this.Controls.Add(this.btnObrisiVozaca);
            this.Controls.Add(this.btnDodajVozaca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listVozaci);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VozaciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vozači";
            this.Load += new System.EventHandler(this.VozaciForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC btnPrikaziVozaca;
        private ePOSOne.btnProduct.Button_WOC btnObrisiVozaca;
        private ePOSOne.btnProduct.Button_WOC btnDodajVozaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader IdVozaca;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader BrojTelefona;
        private System.Windows.Forms.ColumnHeader Ulica;
        private System.Windows.Forms.ColumnHeader Jmbg;
        private System.Windows.Forms.ColumnHeader SrednjeSlovo;
        private System.Windows.Forms.ColumnHeader Broj;
        private System.Windows.Forms.ColumnHeader BrojDozvole;
        private System.Windows.Forms.ColumnHeader Kategorija;
        private System.Windows.Forms.ListView listVozaci;
    }
}