
namespace TaksiUdruzenje.Forme
{
    partial class BrojTelefonaDodavanjeForm
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
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajTelefon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(16, 67);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(174, 22);
            this.txtBroj.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Broj telefona : ";
            // 
            // btnDodajTelefon
            // 
            this.btnDodajTelefon.BackColor = System.Drawing.Color.Tan;
            this.btnDodajTelefon.Location = new System.Drawing.Point(52, 113);
            this.btnDodajTelefon.Name = "btnDodajTelefon";
            this.btnDodajTelefon.Size = new System.Drawing.Size(117, 32);
            this.btnDodajTelefon.TabIndex = 2;
            this.btnDodajTelefon.Text = "Dodaj telefon";
            this.btnDodajTelefon.UseVisualStyleBackColor = false;
            this.btnDodajTelefon.Click += new System.EventHandler(this.btnDodajTelefon_Click);
            // 
            // BrojTelefonaDodavanjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(224, 157);
            this.Controls.Add(this.btnDodajTelefon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBroj);
            this.Name = "BrojTelefonaDodavanjeForm";
            this.Text = "Telefon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajTelefon;
    }
}