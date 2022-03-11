
namespace TaksiUdruzenje.Forme
{
    partial class DodajPopustMusteriji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajPopustMusteriji));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxNeograniceno = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerVaziDo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerVaziOd = new System.Windows.Forms.DateTimePicker();
            this.numericVrednostPopusta = new System.Windows.Forms.NumericUpDown();
            this.btnDodajPopust = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericVrednostPopusta)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(455, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxNeograniceno
            // 
            this.checkBoxNeograniceno.AutoSize = true;
            this.checkBoxNeograniceno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNeograniceno.Location = new System.Drawing.Point(154, 188);
            this.checkBoxNeograniceno.Name = "checkBoxNeograniceno";
            this.checkBoxNeograniceno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxNeograniceno.Size = new System.Drawing.Size(248, 22);
            this.checkBoxNeograniceno.TabIndex = 22;
            this.checkBoxNeograniceno.Text = "Trajanje popusta je neograničeno";
            this.checkBoxNeograniceno.UseVisualStyleBackColor = true;
            this.checkBoxNeograniceno.CheckedChanged += new System.EventHandler(this.checkBoxNeograniceno_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Važi do:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Početak trajanja popusta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Vrednost popusta u procentima:";
            // 
            // dateTimePickerVaziDo
            // 
            this.dateTimePickerVaziDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVaziDo.Location = new System.Drawing.Point(257, 144);
            this.dateTimePickerVaziDo.Name = "dateTimePickerVaziDo";
            this.dateTimePickerVaziDo.RightToLeftLayout = true;
            this.dateTimePickerVaziDo.Size = new System.Drawing.Size(145, 22);
            this.dateTimePickerVaziDo.TabIndex = 17;
            // 
            // dateTimePickerVaziOd
            // 
            this.dateTimePickerVaziOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVaziOd.Location = new System.Drawing.Point(257, 109);
            this.dateTimePickerVaziOd.MinDate = new System.DateTime(2021, 6, 6, 14, 24, 42, 0);
            this.dateTimePickerVaziOd.Name = "dateTimePickerVaziOd";
            this.dateTimePickerVaziOd.Size = new System.Drawing.Size(145, 22);
            this.dateTimePickerVaziOd.TabIndex = 16;
            this.dateTimePickerVaziOd.Value = new System.DateTime(2021, 6, 6, 14, 24, 42, 0);
            this.dateTimePickerVaziOd.ValueChanged += new System.EventHandler(this.dateTimePickerVaziOd_ValueChanged);
            // 
            // numericVrednostPopusta
            // 
            this.numericVrednostPopusta.Location = new System.Drawing.Point(257, 75);
            this.numericVrednostPopusta.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericVrednostPopusta.Name = "numericVrednostPopusta";
            this.numericVrednostPopusta.Size = new System.Drawing.Size(145, 22);
            this.numericVrednostPopusta.TabIndex = 15;
            this.numericVrednostPopusta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericVrednostPopusta.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
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
            this.btnDodajPopust.Location = new System.Drawing.Point(125, 257);
            this.btnDodajPopust.Name = "btnDodajPopust";
            this.btnDodajPopust.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDodajPopust.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDodajPopust.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnDodajPopust.Size = new System.Drawing.Size(189, 52);
            this.btnDodajPopust.TabIndex = 18;
            this.btnDodajPopust.Text = "Dodaj";
            this.btnDodajPopust.TextColor = System.Drawing.Color.Black;
            this.btnDodajPopust.UseVisualStyleBackColor = false;
            this.btnDodajPopust.Click += new System.EventHandler(this.btnDodajPopust_Click);
            // 
            // DodajPopustMusteriji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(812, 402);
            this.Controls.Add(this.checkBoxNeograniceno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodajPopust);
            this.Controls.Add(this.dateTimePickerVaziDo);
            this.Controls.Add(this.dateTimePickerVaziOd);
            this.Controls.Add(this.numericVrednostPopusta);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DodajPopustMusteriji";
            this.Text = "Dodavanje popusta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericVrednostPopusta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxNeograniceno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ePOSOne.btnProduct.Button_WOC btnDodajPopust;
        private System.Windows.Forms.DateTimePicker dateTimePickerVaziDo;
        private System.Windows.Forms.DateTimePicker dateTimePickerVaziOd;
        private System.Windows.Forms.NumericUpDown numericVrednostPopusta;
    }
}