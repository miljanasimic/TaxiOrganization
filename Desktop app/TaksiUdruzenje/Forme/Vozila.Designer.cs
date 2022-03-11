
namespace TaksiUdruzenje.Forme
{
    partial class Vozila
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
            this.label1 = new System.Windows.Forms.Label();
            this.listViewSluzbena = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegOznaka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumIstekaReg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GodinaProizvodnje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.listViewLicna = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPrikaziLicno = new ePOSOne.btnProduct.Button_WOC();
            this.btnObrisiLicno = new ePOSOne.btnProduct.Button_WOC();
            this.btnDodajLicno = new ePOSOne.btnProduct.Button_WOC();
            this.btnPrikaziSluzbeno = new ePOSOne.btnProduct.Button_WOC();
            this.btnObrisiSluzbeno = new ePOSOne.btnProduct.Button_WOC();
            this.btnDodajSluzbeno = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lista službenih vozila";
            // 
            // listViewSluzbena
            // 
            this.listViewSluzbena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listViewSluzbena.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.RegOznaka,
            this.Marka,
            this.Tip,
            this.DatumIstekaReg,
            this.GodinaProizvodnje});
            this.listViewSluzbena.FullRowSelect = true;
            this.listViewSluzbena.GridLines = true;
            this.listViewSluzbena.HideSelection = false;
            this.listViewSluzbena.Location = new System.Drawing.Point(41, 54);
            this.listViewSluzbena.Name = "listViewSluzbena";
            this.listViewSluzbena.Size = new System.Drawing.Size(900, 216);
            this.listViewSluzbena.TabIndex = 10;
            this.listViewSluzbena.UseCompatibleStateImageBehavior = false;
            this.listViewSluzbena.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "ID ";
            this.Id.Width = 114;
            // 
            // RegOznaka
            // 
            this.RegOznaka.Text = "Registarska oznaka";
            this.RegOznaka.Width = 164;
            // 
            // Marka
            // 
            this.Marka.Text = "Marka";
            this.Marka.Width = 92;
            // 
            // Tip
            // 
            this.Tip.Text = "Tip";
            this.Tip.Width = 102;
            // 
            // DatumIstekaReg
            // 
            this.DatumIstekaReg.Text = "Datum isteka registracije";
            this.DatumIstekaReg.Width = 175;
            // 
            // GodinaProizvodnje
            // 
            this.GodinaProizvodnje.Text = "Godina proizvodnje";
            this.GodinaProizvodnje.Width = 146;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label2.Location = new System.Drawing.Point(386, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lista privatnih vozila";
            // 
            // listViewLicna
            // 
            this.listViewLicna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listViewLicna.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewLicna.FullRowSelect = true;
            this.listViewLicna.GridLines = true;
            this.listViewLicna.HideSelection = false;
            this.listViewLicna.Location = new System.Drawing.Point(41, 373);
            this.listViewLicna.Name = "listViewLicna";
            this.listViewLicna.Size = new System.Drawing.Size(900, 216);
            this.listViewLicna.TabIndex = 20;
            this.listViewLicna.UseCompatibleStateImageBehavior = false;
            this.listViewLicna.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID ";
            this.columnHeader1.Width = 71;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Registarska oznaka";
            this.columnHeader2.Width = 164;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Marka";
            this.columnHeader3.Width = 92;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tip";
            this.columnHeader4.Width = 91;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Boja";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID Vozača";
            this.columnHeader8.Width = 103;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Korišćeno od";
            this.columnHeader5.Width = 175;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Korišćeno do";
            this.columnHeader6.Width = 146;
            // 
            // btnPrikaziLicno
            // 
            this.btnPrikaziLicno.BorderColor = System.Drawing.Color.Black;
            this.btnPrikaziLicno.ButtonColor = System.Drawing.Color.Yellow;
            this.btnPrikaziLicno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrikaziLicno.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrikaziLicno.Location = new System.Drawing.Point(753, 595);
            this.btnPrikaziLicno.Name = "btnPrikaziLicno";
            this.btnPrikaziLicno.OnHoverBorderColor = System.Drawing.Color.Yellow;
            this.btnPrikaziLicno.OnHoverButtonColor = System.Drawing.Color.Black;
            this.btnPrikaziLicno.OnHoverTextColor = System.Drawing.Color.Yellow;
            this.btnPrikaziLicno.Size = new System.Drawing.Size(188, 53);
            this.btnPrikaziLicno.TabIndex = 19;
            this.btnPrikaziLicno.Text = "Prikaži/Izmeni";
            this.btnPrikaziLicno.TextColor = System.Drawing.Color.Black;
            this.btnPrikaziLicno.UseVisualStyleBackColor = true;
            this.btnPrikaziLicno.Click += new System.EventHandler(this.btnPrikaziLicno_Click);
            // 
            // btnObrisiLicno
            // 
            this.btnObrisiLicno.BorderColor = System.Drawing.Color.Black;
            this.btnObrisiLicno.ButtonColor = System.Drawing.Color.Yellow;
            this.btnObrisiLicno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnObrisiLicno.ForeColor = System.Drawing.Color.Transparent;
            this.btnObrisiLicno.Location = new System.Drawing.Point(391, 595);
            this.btnObrisiLicno.Name = "btnObrisiLicno";
            this.btnObrisiLicno.OnHoverBorderColor = System.Drawing.Color.Yellow;
            this.btnObrisiLicno.OnHoverButtonColor = System.Drawing.Color.Black;
            this.btnObrisiLicno.OnHoverTextColor = System.Drawing.Color.Yellow;
            this.btnObrisiLicno.Size = new System.Drawing.Size(188, 53);
            this.btnObrisiLicno.TabIndex = 18;
            this.btnObrisiLicno.Text = "Obriši vozilo";
            this.btnObrisiLicno.TextColor = System.Drawing.Color.Black;
            this.btnObrisiLicno.UseVisualStyleBackColor = true;
            this.btnObrisiLicno.Click += new System.EventHandler(this.btnObrisiLicno_Click);
            // 
            // btnDodajLicno
            // 
            this.btnDodajLicno.BorderColor = System.Drawing.Color.Black;
            this.btnDodajLicno.ButtonColor = System.Drawing.Color.Yellow;
            this.btnDodajLicno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodajLicno.ForeColor = System.Drawing.Color.Transparent;
            this.btnDodajLicno.Location = new System.Drawing.Point(41, 595);
            this.btnDodajLicno.Name = "btnDodajLicno";
            this.btnDodajLicno.OnHoverBorderColor = System.Drawing.Color.Yellow;
            this.btnDodajLicno.OnHoverButtonColor = System.Drawing.Color.Black;
            this.btnDodajLicno.OnHoverTextColor = System.Drawing.Color.Yellow;
            this.btnDodajLicno.Size = new System.Drawing.Size(188, 53);
            this.btnDodajLicno.TabIndex = 17;
            this.btnDodajLicno.Text = "Dodaj vozilo";
            this.btnDodajLicno.TextColor = System.Drawing.Color.Black;
            this.btnDodajLicno.UseVisualStyleBackColor = true;
            this.btnDodajLicno.Click += new System.EventHandler(this.btnDodajLicno_Click);
            // 
            // btnPrikaziSluzbeno
            // 
            this.btnPrikaziSluzbeno.BorderColor = System.Drawing.Color.Black;
            this.btnPrikaziSluzbeno.ButtonColor = System.Drawing.Color.Yellow;
            this.btnPrikaziSluzbeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrikaziSluzbeno.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrikaziSluzbeno.Location = new System.Drawing.Point(753, 276);
            this.btnPrikaziSluzbeno.Name = "btnPrikaziSluzbeno";
            this.btnPrikaziSluzbeno.OnHoverBorderColor = System.Drawing.Color.Yellow;
            this.btnPrikaziSluzbeno.OnHoverButtonColor = System.Drawing.Color.Black;
            this.btnPrikaziSluzbeno.OnHoverTextColor = System.Drawing.Color.Yellow;
            this.btnPrikaziSluzbeno.Size = new System.Drawing.Size(188, 53);
            this.btnPrikaziSluzbeno.TabIndex = 14;
            this.btnPrikaziSluzbeno.Text = "Prikaži/Izmeni";
            this.btnPrikaziSluzbeno.TextColor = System.Drawing.Color.Black;
            this.btnPrikaziSluzbeno.UseVisualStyleBackColor = true;
            this.btnPrikaziSluzbeno.Click += new System.EventHandler(this.btnPrikaziSluzbeno_Click);
            // 
            // btnObrisiSluzbeno
            // 
            this.btnObrisiSluzbeno.BorderColor = System.Drawing.Color.Black;
            this.btnObrisiSluzbeno.ButtonColor = System.Drawing.Color.Yellow;
            this.btnObrisiSluzbeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnObrisiSluzbeno.ForeColor = System.Drawing.Color.Transparent;
            this.btnObrisiSluzbeno.Location = new System.Drawing.Point(391, 276);
            this.btnObrisiSluzbeno.Name = "btnObrisiSluzbeno";
            this.btnObrisiSluzbeno.OnHoverBorderColor = System.Drawing.Color.Yellow;
            this.btnObrisiSluzbeno.OnHoverButtonColor = System.Drawing.Color.Black;
            this.btnObrisiSluzbeno.OnHoverTextColor = System.Drawing.Color.Yellow;
            this.btnObrisiSluzbeno.Size = new System.Drawing.Size(188, 53);
            this.btnObrisiSluzbeno.TabIndex = 13;
            this.btnObrisiSluzbeno.Text = "Obriši vozilo";
            this.btnObrisiSluzbeno.TextColor = System.Drawing.Color.Black;
            this.btnObrisiSluzbeno.UseVisualStyleBackColor = true;
            this.btnObrisiSluzbeno.Click += new System.EventHandler(this.btnObrisiSluzbeno_Click);
            // 
            // btnDodajSluzbeno
            // 
            this.btnDodajSluzbeno.BorderColor = System.Drawing.Color.Black;
            this.btnDodajSluzbeno.ButtonColor = System.Drawing.Color.Yellow;
            this.btnDodajSluzbeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodajSluzbeno.ForeColor = System.Drawing.Color.Transparent;
            this.btnDodajSluzbeno.Location = new System.Drawing.Point(41, 276);
            this.btnDodajSluzbeno.Name = "btnDodajSluzbeno";
            this.btnDodajSluzbeno.OnHoverBorderColor = System.Drawing.Color.Yellow;
            this.btnDodajSluzbeno.OnHoverButtonColor = System.Drawing.Color.Black;
            this.btnDodajSluzbeno.OnHoverTextColor = System.Drawing.Color.Yellow;
            this.btnDodajSluzbeno.Size = new System.Drawing.Size(188, 53);
            this.btnDodajSluzbeno.TabIndex = 12;
            this.btnDodajSluzbeno.Text = "Dodaj vozilo";
            this.btnDodajSluzbeno.TextColor = System.Drawing.Color.Black;
            this.btnDodajSluzbeno.UseVisualStyleBackColor = true;
            this.btnDodajSluzbeno.Click += new System.EventHandler(this.btnDodajSluzbeno_Click);
            // 
            // Vozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TaksiUdruzenje.Properties.Resources.taxi_background_city_landscape_many_houses_31606038;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(981, 715);
            this.Controls.Add(this.listViewLicna);
            this.Controls.Add(this.btnPrikaziLicno);
            this.Controls.Add(this.btnObrisiLicno);
            this.Controls.Add(this.btnDodajLicno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrikaziSluzbeno);
            this.Controls.Add(this.btnObrisiSluzbeno);
            this.Controls.Add(this.btnDodajSluzbeno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewSluzbena);
            this.Name = "Vozila";
            this.Text = "Vozila";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC btnPrikaziSluzbeno;
        private ePOSOne.btnProduct.Button_WOC btnObrisiSluzbeno;
        private ePOSOne.btnProduct.Button_WOC btnDodajSluzbeno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewSluzbena;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader RegOznaka;
        private System.Windows.Forms.ColumnHeader Marka;
        private System.Windows.Forms.ColumnHeader Tip;
        private System.Windows.Forms.ColumnHeader DatumIstekaReg;
        private System.Windows.Forms.ColumnHeader GodinaProizvodnje;
        private ePOSOne.btnProduct.Button_WOC btnPrikaziLicno;
        private ePOSOne.btnProduct.Button_WOC btnObrisiLicno;
        private ePOSOne.btnProduct.Button_WOC btnDodajLicno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewLicna;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}