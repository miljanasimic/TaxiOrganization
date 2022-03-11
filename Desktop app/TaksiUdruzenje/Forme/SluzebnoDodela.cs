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
    public partial class SluzebnoDodela : Form
    {
        private int idVozila;
        public SluzebnoDodela(int id)
        {
            InitializeComponent();
            idVozila = id;
            ispuniListuVozaca();
            label4.Text = idVozila.ToString();

        }

        private void dateTimePickerOD_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerDO.MinDate = dateTimePickerOD.Value.AddDays(1);
        }
        public void ispuniListuVozaca()
        {
            listViewVozaci.Items.Clear();
            List<DTO.VozacPregled> vpregled = DTOManager.GetVozacAll();

            foreach (DTO.VozacPregled v in vpregled)
            {
                ListViewItem item = new ListViewItem(new string[] { v.IdVozac.ToString(), v.Ime, v.SrednjeSlovo, v.Prezime, v.BrojDozvole, v.Kategorija });
                listViewVozaci.Items.Add(item);
                listViewVozaci.View = View.Details;
            }
            listViewVozaci.Refresh();
        }

        private void btnDodeli_Click(object sender, EventArgs e)
        {
            int idVozaca = Int32.Parse(listViewVozaci.SelectedItems[0].SubItems[0].Text);
            DateTime od = dateTimePickerOD.Value;
            DateTime? doo;
            if(checkBoxNeograniceno.Checked)
            {
                doo = null;
            }
            else
                doo = dateTimePickerDO.Value;
            DTOManager.dodeliVoziloVozacu(idVozila, idVozaca, od, doo);
            MessageBox.Show("Vozilo je uspesno dodeljeno vozacu.");
        }

        private void checkBoxNeograniceno_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNeograniceno.Checked)
                dateTimePickerDO.Enabled = false;
            else
                dateTimePickerDO.Enabled = true;
        }
    }
}
