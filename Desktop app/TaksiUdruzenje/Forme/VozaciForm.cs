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
    public partial class VozaciForm : Form
    {
        public VozaciForm()
        {
            InitializeComponent();
        }

        private void VozaciForm_Load(object sender, EventArgs e)
        {
            this.IspuniListu();
        }
        private void IspuniListu()
        { 
            listVozaci.Items.Clear();
            List<VozacPregled> vpregled = DTOManager.GetVozacAll();

            foreach (VozacPregled v in vpregled)
            {
                ListViewItem item = new ListViewItem(new string[] { v.IdVozac.ToString(),v.Jmbg,v.Ime,v.SrednjeSlovo,v.Prezime,v.BrojTelefona,v.Ulica,v.Broj,v.BrojDozvole,v.Kategorija});
                listVozaci.Items.Add(item);
                listVozaci.View = View.Details;
            }
            listVozaci.Refresh();
        }

        private void btnDodajVozaca_Click(object sender, EventArgs e)
        {
            DodajVozaca dovanjeVozacaForma = new DodajVozaca();
            dovanjeVozacaForma.ShowDialog();
            IspuniListu();
        }

        private void btnObrisiVozaca_Click(object sender, EventArgs e)
        {
            if (listVozaci.SelectedItems.Count <1)
            {
                MessageBox.Show("Izaberite bar jednog vozača kog želite da obrišete.");
                return;
            }

            string poruka = "Da li želite da obrišete selektovane vozače?";
            string title = "Brisanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                for (int i = 0; i < listVozaci.SelectedItems.Count; i++) {
                    DTOManager.deleteVozac(Int32.Parse(listVozaci.SelectedItems[i].SubItems[0].Text));
                    
                }
                MessageBox.Show("Brisanje vozača je uspešno.");
                IspuniListu();
            }
            
        }

        private void btnPrikaziVozaca_Click(object sender, EventArgs e)
        {
            if (listVozaci.SelectedItems.Count !=1)
            {
                MessageBox.Show("Izaberite jednog vozača čije informacije želite da prikažete.");
                if (listVozaci.SelectedItems.Count > 1)
                {
                    for (int i = 0; i < listVozaci.SelectedItems.Count; i++)
                    {
                        listVozaci.SelectedItems[i].Selected = false;
                        i--;
                    }
                }
                return;
            }
            int idVozaca = Int32.Parse(listVozaci.SelectedItems[0].SubItems[0].Text);
            VozacPrikaz formaPrikazVozaca = new VozacPrikaz(idVozaca);
            formaPrikazVozaca.ShowDialog();
            IspuniListu();
        }


    }
}
