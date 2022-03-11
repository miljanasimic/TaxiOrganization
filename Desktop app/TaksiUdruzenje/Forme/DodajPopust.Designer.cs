namespace TaksiUdruzenje.Forme
{
    partial class DodajPopust
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajPopust));
            this.listMusterije = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numericVrednostPopusta = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerVaziOd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerVaziDo = new System.Windows.Forms.DateTimePicker();
            this.btnDodajPopust = new ePOSOne.btnProduct.Button_WOC();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxNeograniceno = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericVrednostPopusta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listMusterije
            // 
            this.listMusterije.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listMusterije.FullRowSelect = true;
            this.listMusterije.GridLines = true;
            this.listMusterije.HideSelection = false;
            this.listMusterije.Location = new System.Drawing.Point(102, 93);
            this.listMusterije.Name = "listMusterije";
            this.listMusterije.Size = new System.Drawing.Size(722, 180);
            this.listMusterije.TabIndex = 0;
            this.listMusterije.UseCompatibleStateImageBehavior = false;
            this.listMusterije.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Mušterije";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Broj vožnji";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ime";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prezime";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adresa";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 150;
            // 
            // numericVrednostPopusta
            // 
            this.numericVrednostPopusta.Location = new System.Drawing.Point(345, 299);
            this.numericVrednostPopusta.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericVrednostPopusta.Name = "numericVrednostPopusta";
            this.numericVrednostPopusta.Size = new System.Drawing.Size(145, 22);
            this.numericVrednostPopusta.TabIndex = 1;
            this.numericVrednostPopusta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericVrednostPopusta.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // dateTimePickerVaziOd
            // 
            this.dateTimePickerVaziOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVaziOd.Location = new System.Drawing.Point(345, 337);
            this.dateTimePickerVaziOd.MinDate = new System.DateTime(2021, 6, 6, 14, 24, 42, 0);
            this.dateTimePickerVaziOd.Name = "dateTimePickerVaziOd";
            this.dateTimePickerVaziOd.Size = new System.Drawing.Size(145, 22);
            this.dateTimePickerVaziOd.TabIndex = 2;
            this.dateTimePickerVaziOd.Value = new System.DateTime(2021, 6, 6, 14, 24, 42, 0);
            this.dateTimePickerVaziOd.ValueChanged += new System.EventHandler(this.dateTimePickerVaziOd_ValueChanged);
            // 
            // dateTimePickerVaziDo
            // 
            this.dateTimePickerVaziDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVaziDo.Location = new System.Drawing.Point(345, 375);
            this.dateTimePickerVaziDo.Name = "dateTimePickerVaziDo";
            this.dateTimePickerVaziDo.RightToLeftLayout = true;
            this.dateTimePickerVaziDo.Size = new System.Drawing.Size(145, 22);
            this.dateTimePickerVaziDo.TabIndex = 3;
            // 
            // btnDodajPopust
            // 
            this.btnDodajPopust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDodajPopust.BorderColor = System.Drawing.Color.Black;
            this.btnDodajPopust.ButtonColor = System.Drawing.Color.Orange;
            this.btnDodajPopust.FlatAppearance.BorderSize = 0;
            this.btnDodajPopust.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDodajPopust.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDodajPopust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajPopust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPopust.Location = new System.Drawing.Point(301, 466);
            this.btnDodajPopust.Name = "btnDodajPopust";
            this.btnDodajPopust.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDodajPopust.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDodajPopust.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnDodajPopust.Size = new System.Drawing.Size(189, 52);
            this.btnDodajPopust.TabIndex = 7;
            this.btnDodajPopust.Text = "Dodaj";
            this.btnDodajPopust.TextColor = System.Drawing.Color.Black;
            this.btnDodajPopust.UseVisualStyleBackColor = false;
            this.btnDodajPopust.Click += new System.EventHandler(this.btnDodajPopust_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Selektujte bar jednu mušteriju iz liste kojoj želite da dodate popust.\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Vrednost popusta u procentima:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Početak trajanja popusta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Važi do:";
            // 
            // checkBoxNeograniceno
            // 
            this.checkBoxNeograniceno.AutoSize = true;
            this.checkBoxNeograniceno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNeograniceno.Location = new System.Drawing.Point(214, 417);
            this.checkBoxNeograniceno.Name = "checkBoxNeograniceno";
            this.checkBoxNeograniceno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxNeograniceno.Size = new System.Drawing.Size(248, 22);
            this.checkBoxNeograniceno.TabIndex = 12;
            this.checkBoxNeograniceno.Text = "Trajanje popusta je neograničeno";
            this.checkBoxNeograniceno.UseVisualStyleBackColor = true;
            this.checkBoxNeograniceno.CheckedChanged += new System.EventHandler(this.checkBoxNeograniceno_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(533, 279);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // DodajPopust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(894, 618);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBoxNeograniceno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajPopust);
            this.Controls.Add(this.dateTimePickerVaziDo);
            this.Controls.Add(this.dateTimePickerVaziOd);
            this.Controls.Add(this.numericVrednostPopusta);
            this.Controls.Add(this.listMusterije);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(912, 665);
            this.MinimumSize = new System.Drawing.Size(912, 665);
            this.Name = "DodajPopust";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje popusta";
            ((System.ComponentModel.ISupportInitialize)(this.numericVrednostPopusta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listMusterije;
        private System.Windows.Forms.NumericUpDown numericVrednostPopusta;
        private System.Windows.Forms.DateTimePicker dateTimePickerVaziOd;
        private System.Windows.Forms.DateTimePicker dateTimePickerVaziDo;
        private ePOSOne.btnProduct.Button_WOC btnDodajPopust;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxNeograniceno;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}