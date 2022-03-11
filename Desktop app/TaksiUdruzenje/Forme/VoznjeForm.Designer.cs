
namespace TaksiUdruzenje.Forme
{
    partial class VoznjeForm
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
            this.button_WOC3 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC2 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PocetnaStanica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KrajnjaStanica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VremePoziva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdVozaca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VremePocetka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VremeKraja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CenaVoznje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdAdOsoblja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdMusterije = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brojTelefona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button_WOC3
            // 
            this.button_WOC3.BorderColor = System.Drawing.Color.Black;
            this.button_WOC3.ButtonColor = System.Drawing.Color.Yellow;
            this.button_WOC3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC3.ForeColor = System.Drawing.Color.Transparent;
            this.button_WOC3.Location = new System.Drawing.Point(944, 457);
            this.button_WOC3.Name = "button_WOC3";
            this.button_WOC3.OnHoverBorderColor = System.Drawing.Color.Yellow;
            this.button_WOC3.OnHoverButtonColor = System.Drawing.Color.Black;
            this.button_WOC3.OnHoverTextColor = System.Drawing.Color.Yellow;
            this.button_WOC3.Size = new System.Drawing.Size(188, 53);
            this.button_WOC3.TabIndex = 19;
            this.button_WOC3.Text = "Prikazi trenutne";
            this.button_WOC3.TextColor = System.Drawing.Color.Black;
            this.button_WOC3.UseVisualStyleBackColor = true;
            // 
            // button_WOC2
            // 
            this.button_WOC2.BorderColor = System.Drawing.Color.Black;
            this.button_WOC2.ButtonColor = System.Drawing.Color.Yellow;
            this.button_WOC2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC2.ForeColor = System.Drawing.Color.Transparent;
            this.button_WOC2.Location = new System.Drawing.Point(493, 457);
            this.button_WOC2.Name = "button_WOC2";
            this.button_WOC2.OnHoverBorderColor = System.Drawing.Color.Yellow;
            this.button_WOC2.OnHoverButtonColor = System.Drawing.Color.Black;
            this.button_WOC2.OnHoverTextColor = System.Drawing.Color.Yellow;
            this.button_WOC2.Size = new System.Drawing.Size(188, 53);
            this.button_WOC2.TabIndex = 18;
            this.button_WOC2.Text = "Izbrisi voznju";
            this.button_WOC2.TextColor = System.Drawing.Color.Black;
            this.button_WOC2.UseVisualStyleBackColor = true;
            // 
            // button_WOC1
            // 
            this.button_WOC1.BorderColor = System.Drawing.Color.Black;
            this.button_WOC1.ButtonColor = System.Drawing.Color.Yellow;
            this.button_WOC1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.ForeColor = System.Drawing.Color.Transparent;
            this.button_WOC1.Location = new System.Drawing.Point(41, 457);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Yellow;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Black;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Yellow;
            this.button_WOC1.Size = new System.Drawing.Size(188, 53);
            this.button_WOC1.TabIndex = 17;
            this.button_WOC1.Text = "Dodaj voznju";
            this.button_WOC1.TextColor = System.Drawing.Color.Black;
            this.button_WOC1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(470, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 46);
            this.label1.TabIndex = 16;
            this.label1.Text = "Lista voznji";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.PocetnaStanica,
            this.KrajnjaStanica,
            this.VremePoziva,
            this.IdVozaca,
            this.VremePocetka,
            this.VremeKraja,
            this.CenaVoznje,
            this.IdAdOsoblja,
            this.IdMusterije,
            this.brojTelefona});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(20, 213);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1129, 216);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 53;
            // 
            // PocetnaStanica
            // 
            this.PocetnaStanica.Text = "Pocetna stanica";
            // 
            // KrajnjaStanica
            // 
            this.KrajnjaStanica.Text = "Krajnja stanica";
            this.KrajnjaStanica.Width = 92;
            // 
            // VremePoziva
            // 
            this.VremePoziva.Text = "Vreme poziva";
            // 
            // IdVozaca
            // 
            this.IdVozaca.Text = "ID vozaca";
            this.IdVozaca.Width = 87;
            // 
            // VremePocetka
            // 
            this.VremePocetka.Text = "Vreme pocetka voznje";
            this.VremePocetka.Width = 166;
            // 
            // VremeKraja
            // 
            this.VremeKraja.Text = "Vreme kraja voznje";
            this.VremeKraja.Width = 151;
            // 
            // CenaVoznje
            // 
            this.CenaVoznje.Text = "Cena voznje";
            this.CenaVoznje.Width = 114;
            // 
            // IdAdOsoblja
            // 
            this.IdAdOsoblja.Text = "ID AO";
            // 
            // IdMusterije
            // 
            this.IdMusterije.Text = "ID musterije";
            this.IdMusterije.Width = 110;
            // 
            // brojTelefona
            // 
            this.brojTelefona.Text = "Broj telefona poziva";
            this.brojTelefona.Width = 130;
            // 
            // VoznjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TaksiUdruzenje.Properties.Resources.taxi_background_city_landscape_many_houses_31606038;
            this.ClientSize = new System.Drawing.Size(1161, 584);
            this.Controls.Add(this.button_WOC3);
            this.Controls.Add(this.button_WOC2);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "VoznjeForm";
            this.Text = "VoznjeForm";
            this.Load += new System.EventHandler(this.VoznjeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC button_WOC3;
        private ePOSOne.btnProduct.Button_WOC button_WOC2;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader PocetnaStanica;
        private System.Windows.Forms.ColumnHeader KrajnjaStanica;
        private System.Windows.Forms.ColumnHeader VremePoziva;
        private System.Windows.Forms.ColumnHeader IdVozaca;
        private System.Windows.Forms.ColumnHeader VremePocetka;
        private System.Windows.Forms.ColumnHeader VremeKraja;
        private System.Windows.Forms.ColumnHeader CenaVoznje;
        private System.Windows.Forms.ColumnHeader IdAdOsoblja;
        private System.Windows.Forms.ColumnHeader IdMusterije;
        private System.Windows.Forms.ColumnHeader brojTelefona;
    }
}