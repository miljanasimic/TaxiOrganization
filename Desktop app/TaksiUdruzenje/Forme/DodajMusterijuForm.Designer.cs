
namespace TaksiUdruzenje.Forme
{
    partial class DodajMusterijuForm
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
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrez = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblTelefoni = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrez = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtTelefoni = new System.Windows.Forms.TextBox();
            this.btnDodaj = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(76, 32);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(52, 25);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime*";
            // 
            // lblPrez
            // 
            this.lblPrez.AutoSize = true;
            this.lblPrez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrez.Location = new System.Drawing.Point(76, 98);
            this.lblPrez.Name = "lblPrez";
            this.lblPrez.Size = new System.Drawing.Size(83, 25);
            this.lblPrez.TabIndex = 1;
            this.lblPrez.Text = "Prezime";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresa.Location = new System.Drawing.Point(76, 163);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(83, 25);
            this.lblAdresa.TabIndex = 2;
            this.lblAdresa.Text = "Adresa*";
            // 
            // lblTelefoni
            // 
            this.lblTelefoni.AutoSize = true;
            this.lblTelefoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoni.Location = new System.Drawing.Point(76, 222);
            this.lblTelefoni.Name = "lblTelefoni";
            this.lblTelefoni.Size = new System.Drawing.Size(90, 25);
            this.lblTelefoni.TabIndex = 3;
            this.lblTelefoni.Text = "Telefoni*";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(312, 32);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(125, 22);
            this.txtIme.TabIndex = 4;
            // 
            // txtPrez
            // 
            this.txtPrez.Location = new System.Drawing.Point(312, 98);
            this.txtPrez.Name = "txtPrez";
            this.txtPrez.Size = new System.Drawing.Size(125, 22);
            this.txtPrez.TabIndex = 5;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(312, 163);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(125, 22);
            this.txtAdresa.TabIndex = 6;
            // 
            // txtTelefoni
            // 
            this.txtTelefoni.Location = new System.Drawing.Point(312, 222);
            this.txtTelefoni.Multiline = true;
            this.txtTelefoni.Name = "txtTelefoni";
            this.txtTelefoni.Size = new System.Drawing.Size(125, 98);
            this.txtTelefoni.TabIndex = 7;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BorderColor = System.Drawing.Color.Transparent;
            this.btnDodaj.ButtonColor = System.Drawing.Color.Sienna;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(146, 381);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnDodaj.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnDodaj.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnDodaj.Size = new System.Drawing.Size(195, 57);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj musteriju";
            this.btnDodaj.TextColor = System.Drawing.Color.White;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // DodajMusterijuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TaksiUdruzenje.Properties.Resources.taxi_background_city_landscape_many_houses_31606038;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtTelefoni);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtPrez);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblTelefoni);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblPrez);
            this.Controls.Add(this.lblIme);
            this.Name = "DodajMusterijuForm";
            this.Text = "DodajMusterijuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrez;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblTelefoni;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrez;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtTelefoni;
        private ePOSOne.btnProduct.Button_WOC btnDodaj;
    }
}