
namespace TaksiUdruzenje.Forme
{
    partial class SluzbenaVozilaPrikaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SluzbenaVozilaPrikaz));
            this.btnSacuvaj = new ePOSOne.btnProduct.Button_WOC();
            this.listVozacaSluzbenog = new System.Windows.Forms.ListView();
            this.IDVoz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JMBG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PocetnaStanica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KrajnjaStanica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VremePoziva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VremePocetka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VremeKraja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CenaVoznje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrojTelefona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtIstekReg = new System.Windows.Forms.TextBox();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.numericGodProizvodnje = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericGodProizvodnje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSacuvaj.BorderColor = System.Drawing.Color.Black;
            this.btnSacuvaj.ButtonColor = System.Drawing.Color.SandyBrown;
            this.btnSacuvaj.FlatAppearance.BorderSize = 0;
            this.btnSacuvaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSacuvaj.Location = new System.Drawing.Point(478, 193);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSacuvaj.OnHoverButtonColor = System.Drawing.Color.Coral;
            this.btnSacuvaj.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSacuvaj.Size = new System.Drawing.Size(197, 66);
            this.btnSacuvaj.TabIndex = 13;
            this.btnSacuvaj.Text = "Sačuvaj promene";
            this.btnSacuvaj.TextColor = System.Drawing.Color.Black;
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            // 
            // listVozacaSluzbenog
            // 
            this.listVozacaSluzbenog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.listVozacaSluzbenog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDVoz,
            this.JMBG,
            this.PocetnaStanica,
            this.KrajnjaStanica,
            this.VremePoziva,
            this.VremePocetka,
            this.VremeKraja,
            this.CenaVoznje,
            this.BrojTelefona});
            this.listVozacaSluzbenog.FullRowSelect = true;
            this.listVozacaSluzbenog.GridLines = true;
            this.listVozacaSluzbenog.HideSelection = false;
            this.listVozacaSluzbenog.Location = new System.Drawing.Point(72, 293);
            this.listVozacaSluzbenog.Name = "listVozacaSluzbenog";
            this.listVozacaSluzbenog.Size = new System.Drawing.Size(1127, 291);
            this.listVozacaSluzbenog.TabIndex = 7;
            this.listVozacaSluzbenog.UseCompatibleStateImageBehavior = false;
            this.listVozacaSluzbenog.View = System.Windows.Forms.View.Details;
            // 
            // IDVoz
            // 
            this.IDVoz.Text = "ID Vozaca";
            this.IDVoz.Width = 82;
            // 
            // JMBG
            // 
            this.JMBG.Text = "Jmbg";
            this.JMBG.Width = 85;
            // 
            // PocetnaStanica
            // 
            this.PocetnaStanica.Text = "Ime";
            this.PocetnaStanica.Width = 76;
            // 
            // KrajnjaStanica
            // 
            this.KrajnjaStanica.Text = "Srednje slovo";
            this.KrajnjaStanica.Width = 160;
            // 
            // VremePoziva
            // 
            this.VremePoziva.Text = "Prezime";
            this.VremePoziva.Width = 105;
            // 
            // VremePocetka
            // 
            this.VremePocetka.Text = "Broj telefona";
            this.VremePocetka.Width = 146;
            // 
            // VremeKraja
            // 
            this.VremeKraja.Text = "Ulica";
            this.VremeKraja.Width = 107;
            // 
            // CenaVoznje
            // 
            this.CenaVoznje.Text = "Broj";
            this.CenaVoznje.Width = 133;
            // 
            // BrojTelefona
            // 
            this.BrojTelefona.Text = "Broj telefona";
            this.BrojTelefona.Width = 218;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(517, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(568, 9);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(64, 25);
            this.txtID.TabIndex = 15;
            this.txtID.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Registarska oznaka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(447, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Marka:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(447, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tip:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Datum isteka registracije:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(117, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Godina proizvodnje:";
            // 
            // txtReg
            // 
            this.txtReg.Location = new System.Drawing.Point(275, 96);
            this.txtReg.Name = "txtReg";
            this.txtReg.Size = new System.Drawing.Size(134, 22);
            this.txtReg.TabIndex = 21;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(519, 97);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(114, 22);
            this.txtMarka.TabIndex = 22;
            // 
            // txtIstekReg
            // 
            this.txtIstekReg.Enabled = false;
            this.txtIstekReg.Location = new System.Drawing.Point(278, 138);
            this.txtIstekReg.Name = "txtIstekReg";
            this.txtIstekReg.Size = new System.Drawing.Size(131, 22);
            this.txtIstekReg.TabIndex = 23;
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(519, 142);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(114, 22);
            this.txtTip.TabIndex = 24;
            // 
            // numericGodProizvodnje
            // 
            this.numericGodProizvodnje.Location = new System.Drawing.Point(278, 181);
            this.numericGodProizvodnje.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numericGodProizvodnje.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.numericGodProizvodnje.Name = "numericGodProizvodnje";
            this.numericGodProizvodnje.Size = new System.Drawing.Size(134, 22);
            this.numericGodProizvodnje.TabIndex = 26;
            this.numericGodProizvodnje.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.ButtonColor = System.Drawing.Color.SandyBrown;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(411, 591);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(173, 61);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Sačuvaj promene";
            this.btnSave.TextColor = System.Drawing.Color.Black;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button_WOC1
            // 
            this.button_WOC1.BorderColor = System.Drawing.Color.Black;
            this.button_WOC1.ButtonColor = System.Drawing.Color.SandyBrown;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_WOC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button_WOC1.Location = new System.Drawing.Point(653, 590);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC1.Size = new System.Drawing.Size(250, 62);
            this.button_WOC1.TabIndex = 29;
            this.button_WOC1.Text = "Dodeli na koriscenje";
            this.button_WOC1.TextColor = System.Drawing.Color.Black;
            this.button_WOC1.UseVisualStyleBackColor = true;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(883, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // SluzbenaVozilaPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1241, 679);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numericGodProizvodnje);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.txtIstekReg);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtReg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listVozacaSluzbenog);
            this.Name = "SluzbenaVozilaPrikaz";
            this.Text = "SluzbenaVozilaPrikaz";
            ((System.ComponentModel.ISupportInitialize)(this.numericGodProizvodnje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ePOSOne.btnProduct.Button_WOC btnSacuvaj;
        private System.Windows.Forms.ListView listVozacaSluzbenog;
        private System.Windows.Forms.ColumnHeader IDVoz;
        private System.Windows.Forms.ColumnHeader JMBG;
        private System.Windows.Forms.ColumnHeader PocetnaStanica;
        private System.Windows.Forms.ColumnHeader KrajnjaStanica;
        private System.Windows.Forms.ColumnHeader VremePoziva;
        private System.Windows.Forms.ColumnHeader VremePocetka;
        private System.Windows.Forms.ColumnHeader VremeKraja;
        private System.Windows.Forms.ColumnHeader CenaVoznje;
        private System.Windows.Forms.ColumnHeader BrojTelefona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtIstekReg;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.NumericUpDown numericGodProizvodnje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ePOSOne.btnProduct.Button_WOC btnSave;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
    }
}