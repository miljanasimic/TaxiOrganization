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
    public partial class MusterijeForm : Form
    {
        public MusterijeForm()
        {
            InitializeComponent();
        }

        private void MusterijeForm_Load(object sender, EventArgs e)
        {
            this.IspuniListu();
        }
        private void IspuniListu()
        {
            listMusterije.Items.Clear();
            List<MusterijaPregled> musterijapregled = DTOManager.GetMusterijaAll();

            foreach (MusterijaPregled musterija in musterijapregled)
            {
                ListViewItem item = new ListViewItem(new string[] { musterija.IdMusterije.ToString(),musterija.Ime,musterija.Prezime,musterija.Adresa,musterija.BrojVoznji.ToString() });
                listMusterije.Items.Add(item);
                listMusterije.View = View.Details;
            }
            listMusterije.Refresh();
        }

        private void btnDodajMusteriju_Click(object sender, EventArgs e)
        {
            DodajMusterijuForm forma = new DodajMusterijuForm();
            forma.ShowDialog();
            this.IspuniListu();
        }

        private void btnPrikaziMusteriju_Click(object sender, EventArgs e)
        {
            if (listMusterije.SelectedItems.Count == 0)
                MessageBox.Show("Niste izabrali musteriju!");
            else if (listMusterije.SelectedItems.Count > 1)
                MessageBox.Show("Izaberite jednu musteriju!");

            else 
            {
                int idMusterije = Int32.Parse(listMusterije.SelectedItems[0].SubItems[0].Text);
                DTO.MusterijaPregled m = DTOManager.GetMusterija(idMusterije);

                MusterijaPrikaz forma = new MusterijaPrikaz(m);
                forma.ShowDialog();
                this.IspuniListu();
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (listMusterije.SelectedItems.Count == 0)
                MessageBox.Show("Niste izabrali musteriju!");

            else
            {

                string poruka = "Da li zelite da obrisete izabrane musterije?";
                string title = "Brisanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);

                if (result == DialogResult.OK)
                {
                    int[] delArray = new int[listMusterije.SelectedItems.Count];

                    for (int i = 0; i < listMusterije.SelectedItems.Count; i++)
                    {
                        delArray[i] = Int32.Parse(listMusterije.SelectedItems[i].SubItems[0].Text);
                    }

                    DTOManager.obrisiMusterije(delArray);
                    MessageBox.Show("Brisanje uspesno!");
                    this.IspuniListu();
                }
            }
        }

        private void MusterijeForm_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < listMusterije.SelectedItems.Count; i++)
                listMusterije.SelectedItems[i].Selected = false;
        }
    }
}
