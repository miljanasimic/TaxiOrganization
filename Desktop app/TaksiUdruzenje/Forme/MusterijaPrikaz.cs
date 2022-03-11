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
    public partial class MusterijaPrikaz : Form
    {
        private DTO.MusterijaPregled musterija;
        private bool imeChanged = false;
        private bool adresaChanged = false;
        private bool prezimeChanged = false;

        public MusterijaPrikaz()
        {
            InitializeComponent();
        }
        public MusterijaPrikaz(DTO.MusterijaPregled m)
        {
            InitializeComponent();
            this.musterija = m;
        }
        private void MusterijaPrikaz_Load(object sender, EventArgs e)
        {
            this.popuniPodacima();
            this.btnIzmeniMusteriju.Enabled = false;
            this.lblIdValue.Text = this.musterija.IdMusterije.ToString();
        }

        public void popuniPodacima()
        {
            this.txtPrezime.Text = musterija.IdMusterije.ToString();
            this.txtIme.Text = musterija.Ime;
            if (musterija.Prezime != null)
                this.txtPrezime.Text = musterija.Prezime;
            this.txtAdresa.Text = musterija.Adresa;
            this.PopuniListuTelefona();
            this.PopuniListuVoznji();
            this.PopuniListuPopusta();
        }

        public void PopuniListuTelefona()
        {
            this.lstTelefoni.Items.Clear();
            List<string> telefoni = new List<string>();
            telefoni = DTOManager.GetTelefoni(musterija.IdMusterije);

            foreach (string tel in telefoni)
            {
                ListViewItem item = new ListViewItem(new string[] { tel });
                lstTelefoni.Items.Add(item);
                lstTelefoni.View = View.Details;
            }
            lstTelefoni.Refresh();
        }

        public void PopuniListuVoznji()
        {
            this.lstVoznje.Items.Clear();
            List<DTO.VoznjaMusterijaPregled> voznje = DTOManager.GetVoznjeMusterije(this.musterija.IdMusterije);

            foreach (DTO.VoznjaMusterijaPregled voznja in voznje)
            {
                ListViewItem item = new ListViewItem(new string[] {voznja.Id.ToString(), voznja.PocetnaStanica,
                voznja.KrajnjaStanica, voznja.Cena.ToString(), voznja.BrojTelefonaPoziva});
                this.lstVoznje.Items.Add(item);
                lstVoznje.View = View.Details;
            }
            lstVoznje.Refresh();
        }

        public void PopuniListuPopusta()
        {
            this.lstPopusti.Items.Clear();
            List<DTO.PopustPregled> popusti = DTOManager.GetPopustMusterije(this.musterija.IdMusterije);

            foreach (DTO.PopustPregled popust in popusti)
            {
                string krajPopusta;
                if (popust.DatumKraja == null)
                    krajPopusta = "Trajanje je neograničeno";
                else
                    krajPopusta = ((DateTime)(popust.DatumKraja)).ToShortDateString();

                ListViewItem item = new ListViewItem(new string[] {popust.Id.ToString(), popust.Vrednost.ToString(),
                        popust.DatumPocetka.ToString(), krajPopusta});
                this.lstPopusti.Items.Add(item);
                lstPopusti.View = View.Details;
            }

            lstPopusti.Refresh();
        }

        private void btnDodajTelefon_Click(object sender, EventArgs e)
        {
            BrojTelefonaDodavanjeForm forma = new BrojTelefonaDodavanjeForm(this.musterija.IdMusterije);
            forma.ShowDialog();
            if (forma.DialogResult == DialogResult.OK)
            {
                this.PopuniListuTelefona();
                this.btnIzmeniMusteriju.Enabled = true;
            }
        }

        private void btnObrisiTelefone_Click(object sender, EventArgs e)
        {
            if (this.lstTelefoni.SelectedItems.Count == 0)
                MessageBox.Show("Niste izabrali telefon!");

            else
            {

                string poruka = "Da li zelite da obrisete izabrane telefone?";
                string title = "Brisanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);

                if (result == DialogResult.OK)
                {
                    string[] delArray = new string[lstTelefoni.SelectedItems.Count];

                    for (int i = 0; i < lstTelefoni.SelectedItems.Count; i++)
                    {
                        delArray[i] = lstTelefoni.SelectedItems[i].SubItems[0].Text;
                    }

                    DTOManager.ObrisiTelefone(delArray);
                    MessageBox.Show("Brisanje uspesno!");
                    this.PopuniListuTelefona();
                    this.btnIzmeniMusteriju.Enabled = true;
                }
            }
        }

        private void btnIzmeniMusteriju_Click(object sender, EventArgs e)
        {
            if (this.adresaChanged || this.imeChanged || this.prezimeChanged)
            {
                string poruka = "Da li zelite da sacuvate izmene?";
                string title = "Izmene";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);

                if (result == DialogResult.OK)
                {
                    string ime = txtIme.Text;
                    string prezime = txtPrezime.Text;
                    string adresa = txtAdresa.Text;

                    DTOManager.IzmeniMusteriju(this.musterija.IdMusterije, ime, prezime, adresa);
                    MessageBox.Show("Izmene uspesno sacuvane!");
                }
            }
            this.Close();
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            this.btnIzmeniMusteriju.Enabled = true;
            this.imeChanged = true;
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            this.btnIzmeniMusteriju.Enabled = true;
            this.prezimeChanged = true;
        }

        private void txtAdresa_TextChanged(object sender, EventArgs e)
        {
            this.btnIzmeniMusteriju.Enabled = true;
            this.adresaChanged = true;
        }

        private void btnPrikaziVoznju_Click(object sender, EventArgs e)
        {
            if (lstVoznje.SelectedItems.Count == 0)
                MessageBox.Show("Niste izabrali voznju!");
            else if (lstVoznje.SelectedItems.Count > 1)
                MessageBox.Show("Izaberite jednu voznju!");
            else
            {
                int id = Int32.Parse(lstVoznje.SelectedItems[0].SubItems[0].Text);
                DTO.VoznjaPregled vp = DTOManager.GetJednaVoznja(id);
                VoznjaPrikazForm forma = new VoznjaPrikazForm(vp);
                forma.ShowDialog();
            }
        }

        private void btnDodajPopust_Click(object sender, EventArgs e)
        {
            DodajPopustMusteriji forma = new DodajPopustMusteriji(this.musterija.IdMusterije);
            forma.ShowDialog();
            this.PopuniListuPopusta();
        }

        private void btnObrisiPopust_Click(object sender, EventArgs e)
        {
            if (lstPopusti.SelectedItems.Count < 1)
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

                for (int i = 0; i < lstPopusti.SelectedItems.Count; i++)
                    idPopusta.Add(Int32.Parse(lstPopusti.SelectedItems[i].SubItems[0].Text));

                DTOManager.DeletePopusti(idPopusta);
                MessageBox.Show("Brisanje popusta je uspešno.");
                this.PopuniListuPopusta();
                return;
            }
        }

        private void btnIzmeniPopust_Click(object sender, EventArgs e)
        {
            if (lstPopusti.SelectedItems.Count != 1)
            {
                MessageBox.Show("Izaberite jedan popust čije trajanje želite da produžite.");
                return;
            }

            if (lstPopusti.SelectedItems[0].SubItems[3].Text == "Trajanje je neograničeno")
            {
                MessageBox.Show("Trajanje ovog popusta je neograničeno, nije moguće produženje.");
                return;
            }
            int idPopusta = Int32.Parse(lstPopusti.SelectedItems[0].SubItems[0].Text);
            ProduziPopust produziPopustForma = new ProduziPopust(idPopusta);
            produziPopustForma.ShowDialog();
            this.PopuniListuPopusta();
        }

        private void MusterijaPrikaz_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < lstVoznje.SelectedItems.Count; i++)
                lstVoznje.SelectedItems[i].Selected = false;
            for (int i = 0; i < lstTelefoni.SelectedItems.Count; i++)
                lstTelefoni.SelectedItems[i].Selected = false;
            for (int i = 0; i < lstPopusti.SelectedItems.Count; i++)
                lstPopusti.SelectedItems[i].Selected = false;
        }
    }
}
