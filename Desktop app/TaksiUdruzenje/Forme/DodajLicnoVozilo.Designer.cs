
namespace TaksiUdruzenje.Forme
{
    partial class DodajLicnoVozilo
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
            this.bojatxt = new System.Windows.Forms.TextBox();
            this.tiptxt = new System.Windows.Forms.TextBox();
            this.regoznakatxt = new System.Windows.Forms.TextBox();
            this.markatxt = new System.Windows.Forms.TextBox();
            this.btnDodaj = new ePOSOne.btnProduct.Button_WOC();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkKoristiSe = new System.Windows.Forms.CheckBox();
            this.lstVozaci = new System.Windows.Forms.ListView();
            this.IDVozaca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brDozvole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kategorija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bojatxt
            // 
            this.bojatxt.Location = new System.Drawing.Point(703, 44);
            this.bojatxt.Name = "bojatxt";
            this.bojatxt.Size = new System.Drawing.Size(161, 22);
            this.bojatxt.TabIndex = 44;
            // 
            // tiptxt
            // 
            this.tiptxt.Location = new System.Drawing.Point(247, 133);
            this.tiptxt.Name = "tiptxt";
            this.tiptxt.Size = new System.Drawing.Size(161, 22);
            this.tiptxt.TabIndex = 43;
            // 
            // regoznakatxt
            // 
            this.regoznakatxt.Location = new System.Drawing.Point(247, 90);
            this.regoznakatxt.Name = "regoznakatxt";
            this.regoznakatxt.Size = new System.Drawing.Size(161, 22);
            this.regoznakatxt.TabIndex = 42;
            // 
            // markatxt
            // 
            this.markatxt.Location = new System.Drawing.Point(247, 44);
            this.markatxt.Name = "markatxt";
            this.markatxt.Size = new System.Drawing.Size(161, 22);
            this.markatxt.TabIndex = 41;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BorderColor = System.Drawing.Color.Black;
            this.btnDodaj.ButtonColor = System.Drawing.Color.Tan;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(368, 490);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.OnHoverBorderColor = System.Drawing.Color.Yellow;
            this.btnDodaj.OnHoverButtonColor = System.Drawing.Color.Black;
            this.btnDodaj.OnHoverTextColor = System.Drawing.Color.Yellow;
            this.btnDodaj.Size = new System.Drawing.Size(191, 64);
            this.btnDodaj.TabIndex = 40;
            this.btnDodaj.Text = "Dodaj vozilo";
            this.btnDodaj.TextColor = System.Drawing.Color.Black;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dtpOd
            // 
            this.dtpOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOd.Location = new System.Drawing.Point(703, 88);
            this.dtpOd.MaxDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpOd.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(161, 22);
            this.dtpOd.TabIndex = 48;
            this.dtpOd.Value = new System.DateTime(2021, 6, 7, 0, 0, 0, 0);
            // 
            // dtpDo
            // 
            this.dtpDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDo.Location = new System.Drawing.Point(703, 131);
            this.dtpDo.MaxDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpDo.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(161, 22);
            this.dtpDo.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 52;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 53;
            this.label2.Text = "Registarska oznaka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 24);
            this.label3.TabIndex = 54;
            this.label3.Text = "Tip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(552, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 55;
            this.label4.Text = "Boja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(552, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 24);
            this.label6.TabIndex = 57;
            this.label6.Text = "Korisceno od";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(552, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 24);
            this.label7.TabIndex = 58;
            this.label7.Text = "Korisceno do";
            // 
            // chkKoristiSe
            // 
            this.chkKoristiSe.AutoSize = true;
            this.chkKoristiSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKoristiSe.Location = new System.Drawing.Point(706, 178);
            this.chkKoristiSe.Name = "chkKoristiSe";
            this.chkKoristiSe.Size = new System.Drawing.Size(158, 28);
            this.chkKoristiSe.TabIndex = 59;
            this.chkKoristiSe.Text = "I dalje se koristi";
            this.chkKoristiSe.UseVisualStyleBackColor = true;
            this.chkKoristiSe.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lstVozaci
            // 
            this.lstVozaci.BackColor = System.Drawing.Color.Tan;
            this.lstVozaci.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDVozaca,
            this.Ime,
            this.prezime,
            this.brDozvole,
            this.kategorija});
            this.lstVozaci.FullRowSelect = true;
            this.lstVozaci.GridLines = true;
            this.lstVozaci.HideSelection = false;
            this.lstVozaci.Location = new System.Drawing.Point(50, 273);
            this.lstVozaci.Name = "lstVozaci";
            this.lstVozaci.Size = new System.Drawing.Size(814, 159);
            this.lstVozaci.TabIndex = 60;
            this.lstVozaci.UseCompatibleStateImageBehavior = false;
            this.lstVozaci.View = System.Windows.Forms.View.Details;
            // 
            // IDVozaca
            // 
            this.IDVozaca.Text = "ID Vozaca";
            this.IDVozaca.Width = 95;
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.Width = 142;
            // 
            // prezime
            // 
            this.prezime.Text = "Prezime";
            this.prezime.Width = 157;
            // 
            // brDozvole
            // 
            this.brDozvole.Text = "Broj dozvole";
            this.brDozvole.Width = 204;
            // 
            // kategorija
            // 
            this.kategorija.Text = "Kategorija";
            this.kategorija.Width = 122;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 24);
            this.label5.TabIndex = 61;
            this.label5.Text = "Izaberite vozaca koji vozi vozilo";
            // 
            // DodajLicnoVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(922, 566);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstVozaci);
            this.Controls.Add(this.chkKoristiSe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDo);
            this.Controls.Add(this.dtpOd);
            this.Controls.Add(this.bojatxt);
            this.Controls.Add(this.tiptxt);
            this.Controls.Add(this.regoznakatxt);
            this.Controls.Add(this.markatxt);
            this.Controls.Add(this.btnDodaj);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "DodajLicnoVozilo";
            this.Text = "DodajLicnoVozilo";
            this.Load += new System.EventHandler(this.DodajLicnoVozilo_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DodajLicnoVozilo_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bojatxt;
        private System.Windows.Forms.TextBox tiptxt;
        private System.Windows.Forms.TextBox regoznakatxt;
        private System.Windows.Forms.TextBox markatxt;
        private ePOSOne.btnProduct.Button_WOC btnDodaj;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkKoristiSe;
        private System.Windows.Forms.ListView lstVozaci;
        private System.Windows.Forms.ColumnHeader IDVozaca;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader prezime;
        private System.Windows.Forms.ColumnHeader brDozvole;
        private System.Windows.Forms.ColumnHeader kategorija;
        private System.Windows.Forms.Label label5;
    }
}