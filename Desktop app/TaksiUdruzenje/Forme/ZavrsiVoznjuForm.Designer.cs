
namespace TaksiUdruzenje.Forme
{
    partial class ZavrsiVoznjuForm
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
            this.lstPopusti = new System.Windows.Forms.ListView();
            this.idPopusta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idMusterije = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vrednost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pocetak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kraj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblMusterija = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIskoristiPopust = new ePOSOne.btnProduct.Button_WOC();
            this.btnZavrsiVoznju = new ePOSOne.btnProduct.Button_WOC();
            this.txtCena = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtCena)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPopusti
            // 
            this.lstPopusti.BackColor = System.Drawing.Color.Tan;
            this.lstPopusti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idPopusta,
            this.idMusterije,
            this.Vrednost,
            this.pocetak,
            this.kraj});
            this.lstPopusti.FullRowSelect = true;
            this.lstPopusti.GridLines = true;
            this.lstPopusti.HideSelection = false;
            this.lstPopusti.Location = new System.Drawing.Point(12, 144);
            this.lstPopusti.Name = "lstPopusti";
            this.lstPopusti.Size = new System.Drawing.Size(776, 128);
            this.lstPopusti.TabIndex = 0;
            this.lstPopusti.UseCompatibleStateImageBehavior = false;
            this.lstPopusti.View = System.Windows.Forms.View.Details;
            // 
            // idPopusta
            // 
            this.idPopusta.Text = "ID Popusta";
            this.idPopusta.Width = 95;
            // 
            // idMusterije
            // 
            this.idMusterije.Text = "ID Musterije";
            this.idMusterije.Width = 106;
            // 
            // Vrednost
            // 
            this.Vrednost.Text = "Vrednost popusta";
            this.Vrednost.Width = 129;
            // 
            // pocetak
            // 
            this.pocetak.Text = "Datum pocetka";
            this.pocetak.Width = 169;
            // 
            // kraj
            // 
            this.kraj.Text = "Datum kraja";
            this.kraj.Width = 183;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dostupni popusti musterije : ";
            // 
            // lblMusterija
            // 
            this.lblMusterija.AutoSize = true;
            this.lblMusterija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusterija.Location = new System.Drawing.Point(264, 106);
            this.lblMusterija.Name = "lblMusterija";
            this.lblMusterija.Size = new System.Drawing.Size(66, 24);
            this.lblMusterija.TabIndex = 2;
            this.lblMusterija.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Unesite cenu voznje : ";
            // 
            // btnIskoristiPopust
            // 
            this.btnIskoristiPopust.BorderColor = System.Drawing.Color.Silver;
            this.btnIskoristiPopust.ButtonColor = System.Drawing.Color.Tan;
            this.btnIskoristiPopust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIskoristiPopust.Location = new System.Drawing.Point(318, 278);
            this.btnIskoristiPopust.Name = "btnIskoristiPopust";
            this.btnIskoristiPopust.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnIskoristiPopust.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnIskoristiPopust.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnIskoristiPopust.Size = new System.Drawing.Size(147, 50);
            this.btnIskoristiPopust.TabIndex = 5;
            this.btnIskoristiPopust.Text = "Iskoristi popust";
            this.btnIskoristiPopust.TextColor = System.Drawing.Color.White;
            this.btnIskoristiPopust.UseVisualStyleBackColor = true;
            this.btnIskoristiPopust.Click += new System.EventHandler(this.btnIskoristiPopust_Click);
            // 
            // btnZavrsiVoznju
            // 
            this.btnZavrsiVoznju.BorderColor = System.Drawing.Color.Silver;
            this.btnZavrsiVoznju.ButtonColor = System.Drawing.Color.Tan;
            this.btnZavrsiVoznju.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZavrsiVoznju.Location = new System.Drawing.Point(280, 371);
            this.btnZavrsiVoznju.Name = "btnZavrsiVoznju";
            this.btnZavrsiVoznju.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnZavrsiVoznju.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnZavrsiVoznju.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnZavrsiVoznju.Size = new System.Drawing.Size(233, 54);
            this.btnZavrsiVoznju.TabIndex = 6;
            this.btnZavrsiVoznju.Text = "Zavrsi voznju";
            this.btnZavrsiVoznju.TextColor = System.Drawing.Color.White;
            this.btnZavrsiVoznju.UseVisualStyleBackColor = true;
            this.btnZavrsiVoznju.Click += new System.EventHandler(this.btnZavrsiVoznju_Click);
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(393, 43);
            this.txtCena.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(169, 22);
            this.txtCena.TabIndex = 7;
            // 
            // ZavrsiVoznjuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.btnZavrsiVoznju);
            this.Controls.Add(this.btnIskoristiPopust);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMusterija);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPopusti);
            this.Name = "ZavrsiVoznjuForm";
            this.Text = "ZavrsiVoznjuForm";
            this.Load += new System.EventHandler(this.ZavrsiVoznjuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstPopusti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMusterija;
        private System.Windows.Forms.ColumnHeader idPopusta;
        private System.Windows.Forms.ColumnHeader idMusterije;
        private System.Windows.Forms.ColumnHeader Vrednost;
        private System.Windows.Forms.ColumnHeader pocetak;
        private System.Windows.Forms.ColumnHeader kraj;
        private System.Windows.Forms.Label label3;
        private ePOSOne.btnProduct.Button_WOC btnIskoristiPopust;
        private ePOSOne.btnProduct.Button_WOC btnZavrsiVoznju;
        private System.Windows.Forms.NumericUpDown txtCena;
    }
}