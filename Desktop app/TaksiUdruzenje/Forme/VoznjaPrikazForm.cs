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
    public partial class VoznjaPrikazForm : Form
    {
        private DTO.VoznjaPregled voznja;
        private bool pocetnaChanged = false;
        private bool krajnjaChanged = false;
        private bool cenaChanged = false;
        private bool flag = false;
        public VoznjaPrikazForm()
        {
            InitializeComponent();
        }

        public VoznjaPrikazForm(DTO.VoznjaPregled v)
        {
            InitializeComponent();
            this.voznja = v;
        }

        private void VoznjaPrikazForm_Load(object sender, EventArgs e)
        {
            this.PopuniFormu();
            this.lblIdValue.Text = voznja.Id.ToString();
            this.btnIzmeni.Enabled = false;
            if (txtCena.Text.Length == 0)
                txtCena.Enabled = false;
            else txtCena.Enabled = true;
        }

        public void PopuniFormu()
        {

            this.txtPocetna.Text = voznja.PocetnaStanica;
            this.txtKrajnja.Text = voznja.KrajnjaStanica;
            this.dtpVremePoziva.Value = voznja.VremePoziva;
            this.dtpVremePocetka.Value = voznja.VremePocetka;
            if (voznja.VremeKraja != null)
                this.dtpVremeKraja.Text = ((DateTime)voznja.VremeKraja).ToLongDateString();
            else
                this.dtpVremeKraja.Text = "";

            if (voznja.CenaVoznje != null)
                this.txtCena.Text = voznja.CenaVoznje.ToString();
            this.txtTelefon.Text = voznja.BrojTelefonaPoziva;

            this.IspuniVozaca();
            this.IspuniMusteriju();
            this.IspuniOsoblje();
        }

        public void IspuniVozaca()
        {

            this.lstVozac.Items.Clear();
            if(flag)
                voznja.IdVozaca = DTOManager.GetVozac(voznja.IdVozaca.IdVozac);

            ListViewItem item = new ListViewItem(new string[] { voznja.IdVozaca.IdVozac.ToString(),
                voznja.IdVozaca.Ime, voznja.IdVozaca.Prezime, voznja.IdVozaca.BrojDozvole});

            lstVozac.Items.Add(item);
            lstVozac.View = View.Details;
            flag = false;
            lstVozac.Refresh();
        }


        public void IspuniMusteriju()
        {
            this.lstMusterija.Items.Clear();
            if(flag)
                voznja.IdMusterije = DTOManager.GetMusterija(voznja.IdMusterije.IdMusterije);

            ListViewItem item = new ListViewItem(new string[] { voznja.IdMusterije.IdMusterije.ToString(),
                voznja.IdMusterije.Ime, voznja.IdMusterije.Prezime, voznja.IdMusterije.Adresa,
                voznja.IdMusterije.BrojVoznji.ToString()});

            lstMusterija.Items.Add(item);
            lstMusterija.View = View.Details;
            flag = false;
            lstMusterija.Refresh();
        }


        public void IspuniOsoblje()
        {
            this.lstAdministrativno.Items.Clear();
            if(flag)
                voznja.IdAdministrativnogOsoblja = DTOManager.GetAOInfo(voznja.IdAdministrativnogOsoblja.idAO);

            ListViewItem item = new ListViewItem(new string[] { voznja.IdAdministrativnogOsoblja.idAO.ToString(),
                voznja.IdAdministrativnogOsoblja.Ime, voznja.IdAdministrativnogOsoblja.Prezime, voznja.IdAdministrativnogOsoblja.StrucnaSprema});

            lstAdministrativno.Items.Add(item);
            lstAdministrativno.View = View.Details;
            flag = false;
            lstAdministrativno.Refresh();
        }

        private void txtPocetna_TextChanged(object sender, EventArgs e)
        {
            this.btnIzmeni.Enabled = true;
            this.pocetnaChanged = true;
        }

        private void txtKrajnja_TextChanged(object sender, EventArgs e)
        {
            this.btnIzmeni.Enabled = true;
            this.krajnjaChanged = true;
        }

        private void txtCena_TextChanged(object sender, EventArgs e)
        {
            this.btnIzmeni.Enabled = true;
            this.cenaChanged = true;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (this.pocetnaChanged || this.krajnjaChanged || this.cenaChanged)
            {
                string poruka = "Da li zelite da sacuvate izmene?";
                string title = "Izmene";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);

                if (result == DialogResult.OK)
                {
                    string pocetna = txtPocetna.Text;
                    string krajnja = txtKrajnja.Text;
                    int? cena;
                    if (txtCena.Text.Length == 0)
                        cena = null;
                    else
                        cena = Int32.Parse(txtCena.Text);

                    DTOManager.IzmeniVoznju(this.voznja.Id, pocetna, krajnja, cena);
                    MessageBox.Show("Izmene uspesno sacuvane!");
                }
            }
            this.Close();
        }

        private void lstVozac_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(lstVozac.SelectedItems.Count == 1)
            {
                int id = Int32.Parse(lstVozac.SelectedItems[0].SubItems[0].Text);
                VozacPrikaz forma = new VozacPrikaz(id);
                forma.ShowDialog();
                flag = true;
                this.IspuniVozaca();
            }
        }

        private void lstAdministrativno_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(lstAdministrativno.SelectedItems.Count == 1)
            {
                int id = Int32.Parse(lstAdministrativno.SelectedItems[0].SubItems[0].Text);
                AdministrativnoOsobljePrikaz forma = new AdministrativnoOsobljePrikaz(id);
                forma.ShowDialog();
                flag = true;
                this.IspuniOsoblje();
            }
        }

        private void lstMusterija_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstMusterija.SelectedItems.Count == 1)
            {
                int id = Int32.Parse(lstMusterija.SelectedItems[0].SubItems[0].Text);
                DTO.MusterijaPregled m = DTOManager.GetMusterija(id);
                MusterijaPrikaz forma = new MusterijaPrikaz(m);
                forma.ShowDialog();
                flag = true;
                this.IspuniMusteriju();
            }
        }

        private void VoznjaPrikazForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (lstVozac.SelectedItems.Count == 1)
                lstVozac.SelectedItems[0].Selected = false;
            if (lstAdministrativno.SelectedItems.Count == 1)
                lstAdministrativno.SelectedItems[0].Selected = false;
            if (lstMusterija.SelectedItems.Count == 1)
                lstMusterija.SelectedItems[0].Selected = false;
        }
    }
}
