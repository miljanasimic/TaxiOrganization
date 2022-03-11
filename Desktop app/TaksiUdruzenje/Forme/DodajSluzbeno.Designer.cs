
namespace TaksiUdruzenje.Forme
{
    partial class DodajSluzbeno
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
            this.tiptxt = new System.Windows.Forms.TextBox();
            this.regoznakatxt = new System.Windows.Forms.TextBox();
            this.markatxt = new System.Windows.Forms.TextBox();
            this.btnDodaj = new ePOSOne.btnProduct.Button_WOC();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.numGodina = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numGodina)).BeginInit();
            this.SuspendLayout();
            // 
            // tiptxt
            // 
            this.tiptxt.Location = new System.Drawing.Point(368, 145);
            this.tiptxt.Name = "tiptxt";
            this.tiptxt.Size = new System.Drawing.Size(175, 22);
            this.tiptxt.TabIndex = 31;
            // 
            // regoznakatxt
            // 
            this.regoznakatxt.Location = new System.Drawing.Point(368, 102);
            this.regoznakatxt.Name = "regoznakatxt";
            this.regoznakatxt.Size = new System.Drawing.Size(175, 22);
            this.regoznakatxt.TabIndex = 30;
            // 
            // markatxt
            // 
            this.markatxt.Location = new System.Drawing.Point(368, 58);
            this.markatxt.Name = "markatxt";
            this.markatxt.Size = new System.Drawing.Size(175, 22);
            this.markatxt.TabIndex = 29;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BorderColor = System.Drawing.Color.Black;
            this.btnDodaj.ButtonColor = System.Drawing.Color.Tan;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(201, 320);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.OnHoverBorderColor = System.Drawing.Color.Yellow;
            this.btnDodaj.OnHoverButtonColor = System.Drawing.Color.Black;
            this.btnDodaj.OnHoverTextColor = System.Drawing.Color.Yellow;
            this.btnDodaj.Size = new System.Drawing.Size(216, 68);
            this.btnDodaj.TabIndex = 28;
            this.btnDodaj.Text = "Dodaj vozilo";
            this.btnDodaj.TextColor = System.Drawing.Color.Black;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Registarska oznaka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "Datum isteka registracije";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 24);
            this.label5.TabIndex = 38;
            this.label5.Text = "Godina proizvodnje";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(368, 183);
            this.dtpDatum.MaxDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpDatum.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(175, 22);
            this.dtpDatum.TabIndex = 39;
            // 
            // numGodina
            // 
            this.numGodina.Location = new System.Drawing.Point(368, 227);
            this.numGodina.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numGodina.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.numGodina.Name = "numGodina";
            this.numGodina.Size = new System.Drawing.Size(175, 22);
            this.numGodina.TabIndex = 40;
            this.numGodina.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // DodajSluzbeno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(621, 400);
            this.Controls.Add(this.numGodina);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tiptxt);
            this.Controls.Add(this.regoznakatxt);
            this.Controls.Add(this.markatxt);
            this.Controls.Add(this.btnDodaj);
            this.Name = "DodajSluzbeno";
            this.Text = "DodajSluzbeno";
            ((System.ComponentModel.ISupportInitialize)(this.numGodina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tiptxt;
        private System.Windows.Forms.TextBox regoznakatxt;
        private System.Windows.Forms.TextBox markatxt;
        private ePOSOne.btnProduct.Button_WOC btnDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.NumericUpDown numGodina;
    }
}