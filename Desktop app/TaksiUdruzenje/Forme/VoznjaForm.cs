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
    public partial class VoznjaForm : Form
    {
        public VoznjaForm()
        {
            InitializeComponent();
        }

        public void IspuniListe()
        {
            this.lstVoznje.Items.Clear();
            this.lstNeaktivne.Items.Clear();
            List<DTO.VoznjaPregled> lista = DTOManager.GetVoznjaAll();
            foreach (DTO.VoznjaPregled voznja in lista)
            {
                ListViewItem item = new ListViewItem(new string[] { voznja.Id.ToString(), voznja.PocetnaStanica,
                    voznja.KrajnjaStanica, voznja.CenaVoznje.ToString(), voznja.VremePocetka.ToString(), voznja.VremeKraja.ToString()});

                if (voznja.CenaVoznje == null && voznja.VremeKraja==null)
                {
                    this.lstVoznje.Items.Add(item);
                    lstVoznje.View = View.Details;
                }
                else
                {
                    lstNeaktivne.Items.Add(item);
                    lstNeaktivne.View = View.Details;
                }
            }
            lstVoznje.Refresh();
            lstNeaktivne.Refresh();
        }

        private void btnIzbrisiVoznju_Click(object sender, EventArgs e)
        {
            if (lstVoznje.SelectedItems.Count == 0 && lstNeaktivne.SelectedItems.Count == 0)
                MessageBox.Show("Niste izabrali voznje za brisanje!");
            else
            {
                string poruka = "Da li zelite da obrisete izabrane voznje?";
                string title = "Brisanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);

                if (result == DialogResult.OK)
                {
                    int pos = 0;
                    int[] delArray = new int[lstVoznje.SelectedItems.Count + lstNeaktivne.SelectedItems.Count];
                    for (int i = 0; i < lstVoznje.SelectedItems.Count; i++)
                    {
                        delArray[pos] = Int32.Parse(lstVoznje.SelectedItems[i].SubItems[0].Text);
                        pos++;
                    }
                    for(int i = 0; i < lstNeaktivne.SelectedItems.Count; i++)
                    {
                        delArray[pos] = Int32.Parse(lstNeaktivne.SelectedItems[i].SubItems[0].Text);
                        pos++;
                    }

                    DTOManager.obrisiVoznje(delArray);
                    MessageBox.Show("Brisanje uspesno!");
                    this.IspuniListe();
                }

            }
        }

        private void btnPrikaziVoznju_Click(object sender, EventArgs e)
        {
            if (lstVoznje.SelectedItems.Count == 0 && lstNeaktivne.SelectedItems.Count == 0)
                MessageBox.Show("Niste izabrali voznju!");
            else if ((lstVoznje.SelectedItems.Count + lstNeaktivne.SelectedItems.Count) > 1)
            {
                MessageBox.Show("Morate izabrati samo jednu voznju!");
                for (int i = 0; i < lstVoznje.SelectedItems.Count; i++)
                    lstVoznje.SelectedItems[i].Selected = false;
                for (int i = 0; i < lstNeaktivne.SelectedItems.Count; i++)
                    lstNeaktivne.SelectedItems[i].Selected = false;
            }
            else
            {
                int id;
                if (lstVoznje.SelectedItems.Count != 0)
                    id = Int32.Parse(lstVoznje.SelectedItems[0].SubItems[0].Text);
                else
                    id = Int32.Parse(lstNeaktivne.SelectedItems[0].SubItems[0].Text);

                DTO.VoznjaPregled v = DTOManager.GetJednaVoznja(id);
                VoznjaPrikazForm forma = new VoznjaPrikazForm(v);
                forma.ShowDialog();
                this.IspuniListe();
            }
        }

        private void VoznjaForm_Load(object sender, EventArgs e)
        {
            this.IspuniListe();
        }

        private void btnZavrsiVoznju_Click(object sender, EventArgs e)
        {
            if (lstNeaktivne.SelectedItems.Count > 0 && lstVoznje.SelectedItems.Count == 0)
                MessageBox.Show("Ne mozete zavrsiti vec aktivnu voznju!");
            else if (lstVoznje.SelectedItems.Count == 0)
                MessageBox.Show("Niste izabrali aktivnu voznju!");
            else if(lstVoznje.SelectedItems.Count > 1)
                MessageBox.Show("Morate izabrati jednu  aktivnu voznju!");
            else
            {
                int id = Int32.Parse(lstVoznje.SelectedItems[0].SubItems[0].Text);
                DTO.VoznjaPregled v = DTOManager.GetJednaVoznja(id);
                ZavrsiVoznjuForm forma = new ZavrsiVoznjuForm(v);
                forma.ShowDialog();
                this.IspuniListe();
            }
        }

        private void btnDodajVoznju_Click(object sender, EventArgs e)
        {
            VoznjaDodavanjeForm forma = new VoznjaDodavanjeForm();
            forma.ShowDialog();
            this.IspuniListe();
        }

        private void VoznjaForm_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < lstVoznje.SelectedItems.Count; i++)
                lstVoznje.SelectedItems[i].Selected = false;
            for (int i = 0; i < lstNeaktivne.SelectedItems.Count; i++)
                lstNeaktivne.SelectedItems[i].Selected = false;
        }
    }
}
