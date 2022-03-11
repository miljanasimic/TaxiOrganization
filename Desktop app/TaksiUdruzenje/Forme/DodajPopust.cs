using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TaksiUdruzenje.DTO;

namespace TaksiUdruzenje.Forme
{
    public partial class DodajPopust : Form
    {
        public DodajPopust()
        {
            InitializeComponent();
            dateTimePickerVaziOd.MinDate = DateTime.Today;
            dateTimePickerVaziDo.MinDate = DateTime.Today.AddDays(1);
            ispuniListu();
        }
        private void ispuniListu()
        {
            listMusterije.Items.Clear();
            List<MusterijaPregled> musterijapregled = DTOManager.GetMusterijaAll();

            foreach (MusterijaPregled musterija in musterijapregled)
            {
                ListViewItem item = new ListViewItem(new string[] { musterija.IdMusterije.ToString(), musterija.BrojVoznji.ToString(), musterija.Ime, musterija.Prezime, musterija.Adresa });
                listMusterije.Items.Add(item);
                listMusterije.View = View.Details;
            }
            listMusterije.Refresh();
        }

        private void checkBoxNeograniceno_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNeograniceno.Checked == true)
                dateTimePickerVaziDo.Enabled = false;
            else
                dateTimePickerVaziDo.Enabled = true;
        }

        private void btnDodajPopust_Click(object sender, EventArgs e)
        {
            DateTime? trajanjeDo=null;
            List<int> idMusterija=new List<int>();
            if (listMusterije.SelectedItems.Count < 1)
            {
                MessageBox.Show("Izaberite bar jednu mušteriju kojoj želite da dodate popust.");
                return;
            }
            if (checkBoxNeograniceno.Checked == false)
                trajanjeDo = dateTimePickerVaziDo.Value;
             

            for (int i = 0; i < listMusterije.SelectedItems.Count; i++)
                idMusterija.Add(Int32.Parse(listMusterije.SelectedItems[i].SubItems[0].Text));
                
            DTOManager.CreatePopust(idMusterija, (int)numericVrednostPopusta.Value, dateTimePickerVaziOd.Value, trajanjeDo);
            MessageBox.Show("Popust je uspešno dodat.");
            this.Close();
            return;


        }

        private void dateTimePickerVaziOd_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerVaziDo.MinDate = dateTimePickerVaziOd.Value.AddDays(1);
        }
    }
}
