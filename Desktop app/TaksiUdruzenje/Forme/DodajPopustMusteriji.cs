using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaksiUdruzenje.Forme
{
    public partial class DodajPopustMusteriji : Form
    {
        private int iDmusterije;
        public DodajPopustMusteriji()
        {
            InitializeComponent();
        }

        public DodajPopustMusteriji(int id)
        {
            InitializeComponent();
            dateTimePickerVaziOd.MinDate = DateTime.Today;
            dateTimePickerVaziDo.MinDate = DateTime.Today.AddDays(1);
            this.iDmusterije = id;
        }

        private void btnDodajPopust_Click(object sender, EventArgs e)
        {
            DateTime? trajanjeDo = null;
            if (checkBoxNeograniceno.Checked == false)
                trajanjeDo = dateTimePickerVaziDo.Value;

            List<int> ids = new List<int>();
            ids.Add(iDmusterije);

            DTOManager.CreatePopust(ids, (int)numericVrednostPopusta.Value, dateTimePickerVaziOd.Value, trajanjeDo);
            MessageBox.Show("Popust je uspešno dodat.");
            this.Close();
            return;

        }

        private void checkBoxNeograniceno_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNeograniceno.Checked == true)
                dateTimePickerVaziDo.Enabled = false;
            else
                dateTimePickerVaziDo.Enabled = true;
        }

        private void dateTimePickerVaziOd_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerVaziDo.MinDate = dateTimePickerVaziOd.Value.AddDays(1);
        }
    }
}
