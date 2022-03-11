
namespace TaksiUdruzenje.Forme
{
    partial class MusterijeForm
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
            this.listMusterije = new System.Windows.Forms.ListView();
            this.IdMusterije = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrojVoznji = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrikaziMusteriju = new ePOSOne.btnProduct.Button_WOC();
            this.btnIzbrisi = new ePOSOne.btnProduct.Button_WOC();
            this.btnDodajMusteriju = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // listMusterije
            // 
            this.listMusterije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listMusterije.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdMusterije,
            this.Ime,
            this.Prezime,
            this.Adresa,
            this.BrojVoznji});
            this.listMusterije.FullRowSelect = true;
            this.listMusterije.GridLines = true;
            this.listMusterije.HideSelection = false;
            this.listMusterije.Location = new System.Drawing.Point(92, 120);
            this.listMusterije.Name = "listMusterije";
            this.listMusterije.Size = new System.Drawing.Size(822, 232);
            this.listMusterije.TabIndex = 0;
            this.listMusterije.UseCompatibleStateImageBehavior = false;
            this.listMusterije.View = System.Windows.Forms.View.Details;
            // 
            // IdMusterije
            // 
            this.IdMusterije.Text = "ID Mušterije";
            this.IdMusterije.Width = 90;
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ime.Width = 123;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Prezime.Width = 131;
            // 
            // Adresa
            // 
            this.Adresa.Text = "Adresa";
            this.Adresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Adresa.Width = 136;
            // 
            // BrojVoznji
            // 
            this.BrojVoznji.Text = "Broj vožnji";
            this.BrojVoznji.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BrojVoznji.Width = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label1.Location = new System.Drawing.Point(420, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista mušterija";
            // 
            // btnPrikaziMusteriju
            // 
            this.btnPrikaziMusteriju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrikaziMusteriju.BorderColor = System.Drawing.Color.Black;
            this.btnPrikaziMusteriju.ButtonColor = System.Drawing.Color.Yellow;
            this.btnPrikaziMusteriju.FlatAppearance.BorderSize = 0;
            this.btnPrikaziMusteriju.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrikaziMusteriju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikaziMusteriju.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrikaziMusteriju.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrikaziMusteriju.Location = new System.Drawing.Point(675, 382);
            this.btnPrikaziMusteriju.Name = "btnPrikaziMusteriju";
            this.btnPrikaziMusteriju.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrikaziMusteriju.OnHoverButtonColor = System.Drawing.Color.Black;
            this.btnPrikaziMusteriju.OnHoverTextColor = System.Drawing.Color.Gold;
            this.btnPrikaziMusteriju.Size = new System.Drawing.Size(188, 53);
            this.btnPrikaziMusteriju.TabIndex = 4;
            this.btnPrikaziMusteriju.Text = "Prikaži/Izmeni";
            this.btnPrikaziMusteriju.TextColor = System.Drawing.Color.Black;
            this.btnPrikaziMusteriju.UseVisualStyleBackColor = false;
            this.btnPrikaziMusteriju.Click += new System.EventHandler(this.btnPrikaziMusteriju_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIzbrisi.BorderColor = System.Drawing.Color.Black;
            this.btnIzbrisi.ButtonColor = System.Drawing.Color.Yellow;
            this.btnIzbrisi.FlatAppearance.BorderSize = 0;
            this.btnIzbrisi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnIzbrisi.ForeColor = System.Drawing.Color.Transparent;
            this.btnIzbrisi.Location = new System.Drawing.Point(399, 382);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnIzbrisi.OnHoverButtonColor = System.Drawing.Color.Black;
            this.btnIzbrisi.OnHoverTextColor = System.Drawing.Color.Gold;
            this.btnIzbrisi.Size = new System.Drawing.Size(188, 53);
            this.btnIzbrisi.TabIndex = 3;
            this.btnIzbrisi.Text = "Obriši mušteriju";
            this.btnIzbrisi.TextColor = System.Drawing.Color.Black;
            this.btnIzbrisi.UseVisualStyleBackColor = false;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnDodajMusteriju
            // 
            this.btnDodajMusteriju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDodajMusteriju.BorderColor = System.Drawing.Color.Black;
            this.btnDodajMusteriju.ButtonColor = System.Drawing.Color.Yellow;
            this.btnDodajMusteriju.FlatAppearance.BorderSize = 0;
            this.btnDodajMusteriju.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDodajMusteriju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajMusteriju.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodajMusteriju.ForeColor = System.Drawing.Color.Transparent;
            this.btnDodajMusteriju.Location = new System.Drawing.Point(111, 382);
            this.btnDodajMusteriju.Name = "btnDodajMusteriju";
            this.btnDodajMusteriju.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDodajMusteriju.OnHoverButtonColor = System.Drawing.Color.Black;
            this.btnDodajMusteriju.OnHoverTextColor = System.Drawing.Color.Gold;
            this.btnDodajMusteriju.Size = new System.Drawing.Size(188, 53);
            this.btnDodajMusteriju.TabIndex = 2;
            this.btnDodajMusteriju.Text = "Dodaj mušteriju";
            this.btnDodajMusteriju.TextColor = System.Drawing.Color.Black;
            this.btnDodajMusteriju.UseVisualStyleBackColor = false;
            this.btnDodajMusteriju.Click += new System.EventHandler(this.btnDodajMusteriju_Click);
            // 
            // MusterijeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TaksiUdruzenje.Properties.Resources.taxi_background_city_landscape_many_houses_31606038;
            this.ClientSize = new System.Drawing.Size(1011, 527);
            this.Controls.Add(this.btnPrikaziMusteriju);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnDodajMusteriju);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listMusterije);
            this.MaximumSize = new System.Drawing.Size(1029, 574);
            this.MinimumSize = new System.Drawing.Size(1029, 574);
            this.Name = "MusterijeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mušterije";
            this.Load += new System.EventHandler(this.MusterijeForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MusterijeForm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listMusterije;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC btnDodajMusteriju;
        private System.Windows.Forms.ColumnHeader IdMusterije;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader Adresa;
        private System.Windows.Forms.ColumnHeader BrojVoznji;
        private ePOSOne.btnProduct.Button_WOC btnIzbrisi;
        private ePOSOne.btnProduct.Button_WOC btnPrikaziMusteriju;
    }
}