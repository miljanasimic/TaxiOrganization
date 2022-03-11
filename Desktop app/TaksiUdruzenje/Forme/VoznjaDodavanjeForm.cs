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
    public partial class VoznjaDodavanjeForm : Form
    {
        public VoznjaDodavanjeForm()
        {
            InitializeComponent();
        }

        private void VoznjaDodavanjeForm_Load(object sender, EventArgs e)
        {
            this.IspuniVozace();
            this.IspuniOsoblje();
            this.IspuniMusterije();
        }

        public void IspuniVozace()
        {
            lstVozaci.Items.Clear();
            List<DTO.VozacPregled> vozaci = DTOManager.GetVozacAll();
            foreach (DTO.VozacPregled vozac in vozaci)
            {
                ListViewItem item = new ListViewItem(new string[] { vozac.IdVozac.ToString(),
                    vozac.Ime, vozac.Prezime, vozac.BrojDozvole, vozac.Kategorija});

                lstVozaci.Items.Add(item);
                lstVozaci.View = View.Details;
            }
            lstVozaci.Refresh();
        }

        public void IspuniOsoblje()
        {
            lstOsoblje.Items.Clear();
            List<DTO.AdministrativnoOsobljePregled> osoblje = DTOManager.GetAOAll();
            foreach (DTO.AdministrativnoOsobljePregled osoba in osoblje)
            {
                ListViewItem item = new ListViewItem(new string[] { osoba.idAO.ToString(), osoba.Ime,
                    osoba.Prezime, osoba.StrucnaSprema});

                lstOsoblje.Items.Add(item);
                lstOsoblje.View = View.Details;
            }
            lstOsoblje.Refresh();
        }

        public void IspuniMusterije()
        {
            lstMusterije.Items.Clear();
            List<DTO.MusterijaPregled> musterije = DTOManager.GetMusterijaAll();
            foreach (DTO.MusterijaPregled m in musterije)
            {
                ListViewItem item = new ListViewItem(new string[] { m.IdMusterije.ToString(), m.Ime, m.Prezime,
                    m.BrojVoznji.ToString(), m.Adresa});

                lstMusterije.Items.Add(item);
                lstMusterije.View = View.Details;
            }
            lstMusterije.Refresh();
        }

        public void IspuniTelefone(int idMusterije)
        {
            lstTelefoni.Items.Clear();
            List<DTO.TelefoniPregled> telefoni = DTOManager.GetTelefoniMusterije(idMusterije);
            foreach (DTO.TelefoniPregled tel in telefoni)
            {
                ListViewItem item = new ListViewItem(new string[] { tel.Id.ToString(), tel.BrojTelefona});

                lstTelefoni.Items.Add(item);
                lstTelefoni.View = View.Details;
            }
            lstTelefoni.Refresh();
        }

        private void lstMusterije_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idMusterije;
            if (lstMusterije.SelectedItems.Count > 0)
            {
                idMusterije = Int32.Parse(lstMusterije.SelectedItems[0].SubItems[0].Text);
            }
            else
            {
                this.txtNoviTelefon.Enabled = false;
                return;
            }

            this.IspuniTelefone(idMusterije);
            this.txtNoviTelefon.Enabled = true;
        }

        private void btnDodajVoznju_Click(object sender, EventArgs e)
        {
            if (txtKrajnja.Text.Length == 0 || txtPocetna.Text.Length == 0)
            {
                MessageBox.Show("Morate da uneste početnu i krajnju stanicu!");
                return;
            }
            if(lstVozaci.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate da izaberete vozača koji će voziti!");
                return;
            }
            if (lstOsoblje.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate da izaberete administratora koji je zadužen za vožnju!");
                return;
            }
            if (lstMusterije.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate da izaberete musteriju!");
                return;
            }
            if (lstTelefoni.SelectedItems.Count == 0 && txtNoviTelefon.Text.Length == 0)
            {
                MessageBox.Show("Morate da izaberete broj telefona poziva!");
                return;
            }

            DateTime vremePoziva = DateTime.Now;
            Random rnd = new Random();
            double min = rnd.Next(15);
            DateTime vremePocetka = DateTime.Now.AddMinutes(min);
            int idVozaca = Int32.Parse(lstVozaci.SelectedItems[0].SubItems[0].Text);
            int idMusterije = Int32.Parse(lstMusterije.SelectedItems[0].SubItems[0].Text);
            int idAo = Int32.Parse(lstOsoblje.SelectedItems[0].SubItems[0].Text);
            string telefon;
            if (txtNoviTelefon.Text.Length == 0)
                telefon = lstTelefoni.SelectedItems[0].SubItems[1].Text;
            else
            {
                telefon = txtNoviTelefon.Text;
                DTOManager.DodajTelefon(idMusterije, telefon);
            }

            DTOManager.DodajVoznju(txtPocetna.Text, txtKrajnja.Text, vremePoziva, vremePocetka, idVozaca,
                idMusterije, idAo, telefon);

            MessageBox.Show("Dodavanje vožnje uspešno!");
            this.Close();
        }

        private void VoznjaDodavanjeForm_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.lstVozaci.SelectedItems.Count; i++)
                lstVozaci.SelectedItems[i].Selected = false;
            for (int i = 0; i < this.lstOsoblje.SelectedItems.Count; i++)
                lstOsoblje.SelectedItems[i].Selected = false;
            for (int i = 0; i < this.lstMusterije.SelectedItems.Count; i++)
                lstMusterije.SelectedItems[i].Selected = false;
            for (int i = 0; i < this.lstTelefoni.SelectedItems.Count; i++)
                lstTelefoni.SelectedItems[i].Selected = false;
        }

        private void txtNoviTelefon_Enter(object sender, EventArgs e)
        {
            for (int i = 0; i < lstTelefoni.SelectedItems.Count; i++)
                lstTelefoni.SelectedItems[i].Selected = false;
        }
    }
}
