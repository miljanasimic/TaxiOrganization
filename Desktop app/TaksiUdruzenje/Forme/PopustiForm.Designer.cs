namespace TaksiUdruzenje.Forme
{
    partial class PopustiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopustiForm));
            this.listPopusti = new System.Windows.Forms.ListView();
            this.idPopusta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idMusterije = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brVoznji = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vrednost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pocetak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kraj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnProduziPopust = new ePOSOne.btnProduct.Button_WOC();
            this.btnObrisiPopust = new ePOSOne.btnProduct.Button_WOC();
            this.btnDodajPopust = new ePOSOne.btnProduct.Button_WOC();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listPopusti
            // 
            this.listPopusti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listPopusti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idPopusta,
            this.idMusterije,
            this.ime,
            this.prezime,
            this.brVoznji,
            this.vrednost,
            this.pocetak,
            this.kraj});
            this.listPopusti.FullRowSelect = true;
            this.listPopusti.GridLines = true;
            this.listPopusti.HideSelection = false;
            this.listPopusti.Location = new System.Drawing.Point(42, 148);
            this.listPopusti.Name = "listPopusti";
            this.listPopusti.Size = new System.Drawing.Size(1174, 206);
            this.listPopusti.TabIndex = 0;
            this.listPopusti.UseCompatibleStateImageBehavior = false;
            this.listPopusti.View = System.Windows.Forms.View.Details;
            // 
            // idPopusta
            // 
            this.idPopusta.Text = "ID Popusta";
            this.idPopusta.Width = 91;
            // 
            // idMusterije
            // 
            this.idMusterije.Text = "ID Mušterije";
            this.idMusterije.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idMusterije.Width = 96;
            // 
            // ime
            // 
            this.ime.Text = "Ime";
            this.ime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ime.Width = 90;
            // 
            // prezime
            // 
            this.prezime.Text = "Prezime";
            this.prezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prezime.Width = 90;
            // 
            // brVoznji
            // 
            this.brVoznji.Text = "Broj vožnji";
            this.brVoznji.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.brVoznji.Width = 100;
            // 
            // vrednost
            // 
            this.vrednost.Text = "Vrednost popusta";
            this.vrednost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vrednost.Width = 133;
            // 
            // pocetak
            // 
            this.pocetak.Text = "Datum početka";
            this.pocetak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pocetak.Width = 118;
            // 
            // kraj
            // 
            this.kraj.Text = "Datum kraja";
            this.kraj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kraj.Width = 160;
            // 
            // btnProduziPopust
            // 
            this.btnProduziPopust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProduziPopust.BorderColor = System.Drawing.Color.Black;
            this.btnProduziPopust.ButtonColor = System.Drawing.Color.Yellow;
            this.btnProduziPopust.FlatAppearance.BorderSize = 0;
            this.btnProduziPopust.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(185)))), ((int)(((byte)(29)))));
            this.btnProduziPopust.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProduziPopust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduziPopust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduziPopust.Location = new System.Drawing.Point(874, 374);
            this.btnProduziPopust.Name = "btnProduziPopust";
            this.btnProduziPopust.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnProduziPopust.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.btnProduziPopust.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnProduziPopust.Size = new System.Drawing.Size(213, 57);
            this.btnProduziPopust.TabIndex = 8;
            this.btnProduziPopust.Text = "Produži trajanje";
            this.btnProduziPopust.TextColor = System.Drawing.Color.Black;
            this.btnProduziPopust.UseVisualStyleBackColor = false;
            this.btnProduziPopust.Click += new System.EventHandler(this.btnProduziPopust_Click);
            // 
            // btnObrisiPopust
            // 
            this.btnObrisiPopust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnObrisiPopust.BorderColor = System.Drawing.Color.Black;
            this.btnObrisiPopust.ButtonColor = System.Drawing.Color.Yellow;
            this.btnObrisiPopust.FlatAppearance.BorderSize = 0;
            this.btnObrisiPopust.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(29)))));
            this.btnObrisiPopust.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnObrisiPopust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiPopust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiPopust.Location = new System.Drawing.Point(521, 374);
            this.btnObrisiPopust.Name = "btnObrisiPopust";
            this.btnObrisiPopust.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnObrisiPopust.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.btnObrisiPopust.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnObrisiPopust.Size = new System.Drawing.Size(213, 57);
            this.btnObrisiPopust.TabIndex = 7;
            this.btnObrisiPopust.Text = "Obriši popust";
            this.btnObrisiPopust.TextColor = System.Drawing.Color.Black;
            this.btnObrisiPopust.UseVisualStyleBackColor = false;
            this.btnObrisiPopust.Click += new System.EventHandler(this.btnObrisiPopust_Click);
            // 
            // btnDodajPopust
            // 
            this.btnDodajPopust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDodajPopust.BorderColor = System.Drawing.Color.Black;
            this.btnDodajPopust.ButtonColor = System.Drawing.Color.Yellow;
            this.btnDodajPopust.FlatAppearance.BorderSize = 0;
            this.btnDodajPopust.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(29)))));
            this.btnDodajPopust.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDodajPopust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajPopust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPopust.Location = new System.Drawing.Point(148, 374);
            this.btnDodajPopust.Name = "btnDodajPopust";
            this.btnDodajPopust.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDodajPopust.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.btnDodajPopust.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnDodajPopust.Size = new System.Drawing.Size(213, 57);
            this.btnDodajPopust.TabIndex = 6;
            this.btnDodajPopust.Text = "Dodaj popust";
            this.btnDodajPopust.TextColor = System.Drawing.Color.Black;
            this.btnDodajPopust.UseVisualStyleBackColor = false;
            this.btnDodajPopust.Click += new System.EventHandler(this.btnDodajPopust_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lista svih dodeljenih popusta mušterijama";
            // 
            // PopustiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(29)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1267, 534);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProduziPopust);
            this.Controls.Add(this.btnObrisiPopust);
            this.Controls.Add(this.btnDodajPopust);
            this.Controls.Add(this.listPopusti);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1285, 581);
            this.MinimumSize = new System.Drawing.Size(1285, 581);
            this.Name = "PopustiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popusti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listPopusti;
        private System.Windows.Forms.ColumnHeader idPopusta;
        private System.Windows.Forms.ColumnHeader idMusterije;
        private System.Windows.Forms.ColumnHeader vrednost;
        private System.Windows.Forms.ColumnHeader pocetak;
        private System.Windows.Forms.ColumnHeader kraj;
        private ePOSOne.btnProduct.Button_WOC btnDodajPopust;
        private ePOSOne.btnProduct.Button_WOC btnObrisiPopust;
        private ePOSOne.btnProduct.Button_WOC btnProduziPopust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader ime;
        private System.Windows.Forms.ColumnHeader prezime;
        private System.Windows.Forms.ColumnHeader brVoznji;
    }
}