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
    public partial class PopustiForm : Form
    {
        public PopustiForm()
        {
            InitializeComponent();
            ispuniListu();
        }

        private void ispuniListu()
        {
            listPopusti.Items.Clear();
            List<PopustPregled> sviPopusti = DTOManager.GetPopustAll();
            String krajPopusta;

            foreach (PopustPregled p in sviPopusti)
            {
                if (p.DatumKraja == null)
                    krajPopusta = "Trajanje je neograničeno";
                else
                    krajPopusta = ((DateTime)(p.DatumKraja)).ToShortDateString();
                
                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(),p.IdMusterije.IdMusterije.ToString(),p.IdMusterije.Ime,p.IdMusterije.Prezime,p.IdMusterije.BrojVoznji.ToString(),p.Vrednost.ToString()+"%",p.DatumPocetka.ToShortDateString(),krajPopusta});
                listPopusti.Items.Add(item);
            }
            listPopusti.Refresh();
        }

        private void btnDodajPopust_Click(object sender, EventArgs e)
        {
            DodajPopust dodavanjePopustaForm = new DodajPopust();
            dodavanjePopustaForm.ShowDialog();
            ispuniListu();
        }

        private void btnObrisiPopust_Click(object sender, EventArgs e)
        {
            if (listPopusti.SelectedItems.Count < 1)
            {
                MessageBox.Show("Izaberite bar jedan popust kako bi brisanje bilo moguće.");
                return;
            }

            string poruka = "Da li želite da obrišete selektovane popuste?";
            string title = "Brisanje popusta";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                List<int> idPopusta = new List<int>();

                for (int i = 0; i < listPopusti.SelectedItems.Count; i++)
                    idPopusta.Add(Int32.Parse(listPopusti.SelectedItems[i].SubItems[0].Text));

                DTOManager.DeletePopusti(idPopusta);
                MessageBox.Show("Brisanje popusta je uspešno.");
                ispuniListu();
                return;
            }
            
        }

        private void btnProduziPopust_Click(object sender, EventArgs e)
        {
            if (listPopusti.SelectedItems.Count !=1)
            {
                MessageBox.Show("Izaberite jedan popust čije trajanje želite da produžite.");
                if (listPopusti.SelectedItems.Count > 1)
                {
                    for (int i = 0; i < listPopusti.SelectedItems.Count; i++)
                    {
                        listPopusti.SelectedItems[i].Selected = false;
                        i--;
                    }
                }
                return;
            }
            
            if(listPopusti.SelectedItems[0].SubItems[7].Text== "Trajanje je neograničeno")
            {
                MessageBox.Show("Trajanje ovog popusta je neograničeno, nije moguće produženje.");
                return;
            }
            int idPopusta = Int32.Parse(listPopusti.SelectedItems[0].SubItems[0].Text);
            ProduziPopust produziPopustForma = new ProduziPopust(idPopusta);
            produziPopustForma.ShowDialog();
            ispuniListu();
            
        }
    }
}
