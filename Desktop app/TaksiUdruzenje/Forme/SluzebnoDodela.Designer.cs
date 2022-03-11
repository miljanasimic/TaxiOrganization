
namespace TaksiUdruzenje.Forme
{
    partial class SluzebnoDodela
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
            this.listViewVozaci = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePickerOD = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDO = new System.Windows.Forms.DateTimePicker();
            this.btnDodeli = new ePOSOne.btnProduct.Button_WOC();
            this.checkBoxNeograniceno = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewVozaci
            // 
            this.listViewVozaci.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewVozaci.FullRowSelect = true;
            this.listViewVozaci.GridLines = true;
            this.listViewVozaci.HideSelection = false;
            this.listViewVozaci.Location = new System.Drawing.Point(68, 84);
            this.listViewVozaci.MultiSelect = false;
            this.listViewVozaci.Name = "listViewVozaci";
            this.listViewVozaci.Size = new System.Drawing.Size(697, 283);
            this.listViewVozaci.TabIndex = 0;
            this.listViewVozaci.UseCompatibleStateImageBehavior = false;
            this.listViewVozaci.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID Vozača";
            this.ID.Width = 129;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.Width = 136;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Srednje slovo";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prezime";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Broj dozvole";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kategorija";
            // 
            // dateTimePickerOD
            // 
            this.dateTimePickerOD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOD.Location = new System.Drawing.Point(203, 386);
            this.dateTimePickerOD.Name = "dateTimePickerOD";
            this.dateTimePickerOD.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerOD.TabIndex = 1;
            this.dateTimePickerOD.ValueChanged += new System.EventHandler(this.dateTimePickerOD_ValueChanged);
            // 
            // dateTimePickerDO
            // 
            this.dateTimePickerDO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDO.Location = new System.Drawing.Point(203, 421);
            this.dateTimePickerDO.Name = "dateTimePickerDO";
            this.dateTimePickerDO.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDO.TabIndex = 2;
            this.dateTimePickerDO.Value = new System.DateTime(2021, 6, 9, 0, 8, 0, 0);
            // 
            // btnDodeli
            // 
            this.btnDodeli.BorderColor = System.Drawing.Color.Black;
            this.btnDodeli.ButtonColor = System.Drawing.Color.LightCoral;
            this.btnDodeli.FlatAppearance.BorderSize = 0;
            this.btnDodeli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDodeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodeli.Location = new System.Drawing.Point(349, 465);
            this.btnDodeli.Name = "btnDodeli";
            this.btnDodeli.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDodeli.OnHoverButtonColor = System.Drawing.Color.Coral;
            this.btnDodeli.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnDodeli.Size = new System.Drawing.Size(150, 43);
            this.btnDodeli.TabIndex = 3;
            this.btnDodeli.Text = "Dodeli vozilo";
            this.btnDodeli.TextColor = System.Drawing.Color.Black;
            this.btnDodeli.UseVisualStyleBackColor = true;
            this.btnDodeli.Click += new System.EventHandler(this.btnDodeli_Click);
            // 
            // checkBoxNeograniceno
            // 
            this.checkBoxNeograniceno.AutoSize = true;
            this.checkBoxNeograniceno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNeograniceno.Location = new System.Drawing.Point(460, 422);
            this.checkBoxNeograniceno.Name = "checkBoxNeograniceno";
            this.checkBoxNeograniceno.Size = new System.Drawing.Size(198, 24);
            this.checkBoxNeograniceno.TabIndex = 4;
            this.checkBoxNeograniceno.Text = "Koristi na neodredjeno";
            this.checkBoxNeograniceno.UseVisualStyleBackColor = true;
            this.checkBoxNeograniceno.CheckedChanged += new System.EventHandler(this.checkBoxNeograniceno_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Koristi od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Koristi do:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID Sluzbenog vozila";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(434, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // SluzebnoDodela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(861, 564);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxNeograniceno);
            this.Controls.Add(this.btnDodeli);
            this.Controls.Add(this.dateTimePickerDO);
            this.Controls.Add(this.dateTimePickerOD);
            this.Controls.Add(this.listViewVozaci);
            this.Name = "SluzebnoDodela";
            this.Text = "SluzebnoDodela";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewVozaci;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.DateTimePicker dateTimePickerOD;
        private System.Windows.Forms.DateTimePicker dateTimePickerDO;
        private ePOSOne.btnProduct.Button_WOC btnDodeli;
        private System.Windows.Forms.CheckBox checkBoxNeograniceno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}