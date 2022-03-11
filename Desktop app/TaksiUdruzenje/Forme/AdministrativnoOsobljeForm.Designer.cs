
namespace TaksiUdruzenje.Forme
{
    partial class AdministrativnoOsobljeForm
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
            this.listViewAO = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Jmbg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SrednjeSlovo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrojTelefona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ulica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Broj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StrucnaSprema = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrikaziAO = new ePOSOne.btnProduct.Button_WOC();
            this.obrisiAO = new ePOSOne.btnProduct.Button_WOC();
            this.dodajAO = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // listViewAO
            // 
            this.listViewAO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listViewAO.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Jmbg,
            this.Ime,
            this.SrednjeSlovo,
            this.Prezime,
            this.BrojTelefona,
            this.Ulica,
            this.Broj,
            this.StrucnaSprema});
            this.listViewAO.FullRowSelect = true;
            this.listViewAO.GridLines = true;
            this.listViewAO.HideSelection = false;
            this.listViewAO.Location = new System.Drawing.Point(89, 117);
            this.listViewAO.Name = "listViewAO";
            this.listViewAO.Size = new System.Drawing.Size(998, 227);
            this.listViewAO.TabIndex = 0;
            this.listViewAO.UseCompatibleStateImageBehavior = false;
            this.listViewAO.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 34;
            // 
            // Jmbg
            // 
            this.Jmbg.Text = "Jmbg";
            this.Jmbg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Jmbg.Width = 98;
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ime.Width = 54;
            // 
            // SrednjeSlovo
            // 
            this.SrednjeSlovo.Text = "Srednje slovo";
            this.SrednjeSlovo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SrednjeSlovo.Width = 102;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Prezime.Width = 88;
            // 
            // BrojTelefona
            // 
            this.BrojTelefona.Text = "Broj telefona";
            this.BrojTelefona.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BrojTelefona.Width = 106;
            // 
            // Ulica
            // 
            this.Ulica.Text = "Ulica";
            this.Ulica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ulica.Width = 116;
            // 
            // Broj
            // 
            this.Broj.Text = "Broj";
            this.Broj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Broj.Width = 38;
            // 
            // StrucnaSprema
            // 
            this.StrucnaSprema.Text = "Stručna sprema";
            this.StrucnaSprema.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StrucnaSprema.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(388, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista administrativnog osoblja";
            // 
            // btnPrikaziAO
            // 
            this.btnPrikaziAO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrikaziAO.BorderColor = System.Drawing.Color.Black;
            this.btnPrikaziAO.ButtonColor = System.Drawing.Color.Yellow;
            this.btnPrikaziAO.FlatAppearance.BorderSize = 0;
            this.btnPrikaziAO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrikaziAO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikaziAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziAO.Location = new System.Drawing.Point(814, 381);
            this.btnPrikaziAO.Name = "btnPrikaziAO";
            this.btnPrikaziAO.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrikaziAO.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.btnPrikaziAO.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnPrikaziAO.Size = new System.Drawing.Size(213, 57);
            this.btnPrikaziAO.TabIndex = 6;
            this.btnPrikaziAO.Text = "Prikaži/Izmeni";
            this.btnPrikaziAO.TextColor = System.Drawing.Color.Black;
            this.btnPrikaziAO.UseVisualStyleBackColor = false;
            this.btnPrikaziAO.Click += new System.EventHandler(this.btnPrikaziAO_Click);
            // 
            // obrisiAO
            // 
            this.obrisiAO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.obrisiAO.BorderColor = System.Drawing.Color.Black;
            this.obrisiAO.ButtonColor = System.Drawing.Color.Yellow;
            this.obrisiAO.FlatAppearance.BorderSize = 0;
            this.obrisiAO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.obrisiAO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.obrisiAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obrisiAO.Location = new System.Drawing.Point(479, 381);
            this.obrisiAO.Name = "obrisiAO";
            this.obrisiAO.OnHoverBorderColor = System.Drawing.Color.Black;
            this.obrisiAO.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.obrisiAO.OnHoverTextColor = System.Drawing.Color.Black;
            this.obrisiAO.Size = new System.Drawing.Size(213, 57);
            this.obrisiAO.TabIndex = 5;
            this.obrisiAO.Text = "Obriši osoblje";
            this.obrisiAO.TextColor = System.Drawing.Color.Black;
            this.obrisiAO.UseVisualStyleBackColor = false;
            this.obrisiAO.Click += new System.EventHandler(this.obrisiAO_Click);
            // 
            // dodajAO
            // 
            this.dodajAO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dodajAO.BorderColor = System.Drawing.Color.Black;
            this.dodajAO.ButtonColor = System.Drawing.Color.Yellow;
            this.dodajAO.FlatAppearance.BorderSize = 0;
            this.dodajAO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dodajAO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajAO.Location = new System.Drawing.Point(142, 381);
            this.dodajAO.Name = "dodajAO";
            this.dodajAO.OnHoverBorderColor = System.Drawing.Color.Black;
            this.dodajAO.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.dodajAO.OnHoverTextColor = System.Drawing.Color.Black;
            this.dodajAO.Size = new System.Drawing.Size(213, 57);
            this.dodajAO.TabIndex = 2;
            this.dodajAO.Text = "Dodaj osoblje";
            this.dodajAO.TextColor = System.Drawing.Color.Black;
            this.dodajAO.UseVisualStyleBackColor = false;
            this.dodajAO.Click += new System.EventHandler(this.dodajAO_Click);
            // 
            // AdministrativnoOsobljeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TaksiUdruzenje.Properties.Resources.taxi_background_city_landscape_many_houses_31606038;
            this.ClientSize = new System.Drawing.Size(1173, 536);
            this.Controls.Add(this.btnPrikaziAO);
            this.Controls.Add(this.obrisiAO);
            this.Controls.Add(this.dodajAO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewAO);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1191, 583);
            this.MinimumSize = new System.Drawing.Size(1191, 583);
            this.Name = "AdministrativnoOsobljeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrativno osoblje";
            this.Load += new System.EventHandler(this.AdministrativnoOsobljeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewAO;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Jmbg;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader SrednjeSlovo;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader BrojTelefona;
        private System.Windows.Forms.ColumnHeader Ulica;
        private System.Windows.Forms.ColumnHeader Broj;
        private System.Windows.Forms.ColumnHeader StrucnaSprema;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC dodajAO;
        private ePOSOne.btnProduct.Button_WOC obrisiAO;
        private ePOSOne.btnProduct.Button_WOC btnPrikaziAO;
    }
}