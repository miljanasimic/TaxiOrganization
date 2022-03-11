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
    public partial class VozacPrikaz : Form
    {
       
        int id;
        string ime, prezime, srSlovo, ulica, broj, dozvola, kategorija, telefon;
        public VozacPrikaz()
        {
            InitializeComponent();
        }


        public VozacPrikaz(int idVozaca)
        {
            id = idVozaca;
            InitializeComponent();
            popuniLabele(idVozaca);            
            ispuniListuLicnihVozila(idVozaca);
            ispuniListuSluzbenihVozila(idVozaca);
            ispuniListuAktivnihVoznji(idVozaca);
            ispuniListuZavrsenihVoznji(idVozaca);

        }
        private void popuniLabele(int idVozaca)
        {
            VozacPregled vozac = DTOManager.GetVozac(idVozaca);
            lblID.Text = vozac.IdVozac.ToString();
            ime=txtIme.Text = vozac.Ime;
            prezime=txtPrezime.Text = vozac.Prezime;
            srSlovo=txtSrSlovo.Text = vozac.SrednjeSlovo;
            txtJmbg.Text = vozac.Jmbg;
            broj=txtBroj.Text = vozac.Broj;
            ulica=txtUlica.Text = vozac.Ulica;
            dozvola=txtDozvola.Text = vozac.BrojDozvole;
            kategorija=txtKategorija.Text = vozac.Kategorija;
            telefon=txtTelefon.Text = vozac.BrojTelefona;
            if (vozac.SrednjeSlovo == null)
                srSlovo = "";
            if (vozac.Ulica == null)
                ulica = "";
            if (vozac.Broj == null)
                broj = "";

        }

        private void ispuniListuSluzbenihVozila(int idVozaca)
        {
            listSluzbenaVozila.Items.Clear();
            string korisceno;
            List<VozioSluzbenoPregled> listaSluzbenihVozila = DTOManager.GetSluzbenaVozilaVozaca(idVozaca);

            foreach (VozioSluzbenoPregled vozilo in listaSluzbenihVozila)
            {

                if (vozilo.VozioDo == null)
                    korisceno = "I dalje vozi";
                else
                    korisceno = vozilo.VozioDo.ToString();
                ListViewItem item = new ListViewItem(new string[] { vozilo.Vozilo.Id.ToString(),vozilo.Vozilo.RegOznaka,vozilo.Vozilo.Marka,vozilo.Vozilo.Tip,((DateTime)(vozilo.Vozilo.DatumIstekaRegistracije)).ToShortDateString(),vozilo.Vozilo.GodinaProizvodnje.ToString(),vozilo.VozioOd.ToString(),korisceno });
                
                listSluzbenaVozila.Items.Add(item);
            }
            listSluzbenaVozila.Refresh();
        }

        private void ispuniListuLicnihVozila(int idVozaca)
        {
            listLicnaVozila.Items.Clear();
            string korisceno;
            List<LicnoVoziloPregled> listaLicnihVozila = DTOManager.GetLicnaVozilaVozaca(idVozaca);

            foreach (LicnoVoziloPregled vozilo in listaLicnihVozila)
            {
                if (vozilo.KoriscenoDo == null)
                    korisceno = "I dalje koristi";
                else
                    korisceno = vozilo.KoriscenoDo.ToString();
                ListViewItem item = new ListViewItem(new string[] { vozilo.Id.ToString(), vozilo.RegOznaka, vozilo.Marka, vozilo.Tip, vozilo.Boja, vozilo.KoriscenoOd.ToString(),korisceno });
                listLicnaVozila.Items.Add(item);
            }
            listLicnaVozila.Refresh();
        }

        private void ispuniListuAktivnihVoznji(int idVozaca)
        {
            listAktivneVoznje.Items.Clear();
            List<VoznjaPregled> aktivneVoznje = DTOManager.GetAktivneVoznjeVozaca(idVozaca);

            foreach (VoznjaPregled v in aktivneVoznje)
            {
                ListViewItem item = new ListViewItem(new string[] { v.Id.ToString(), v.PocetnaStanica, v.KrajnjaStanica, v.VremePoziva.ToString(), v.VremePocetka.ToString(), v.IdAdministrativnogOsoblja.idAO.ToString(), v.IdMusterije.IdMusterije.ToString(), v.BrojTelefonaPoziva });
                listAktivneVoznje.Items.Add(item);
            }
            listAktivneVoznje.Refresh();
        }

        private void ispuniListuZavrsenihVoznji(int idVozaca)
        {
            listZavrseneVoznje.Items.Clear();
            List<VoznjaPregled> zavrseneVoznje = DTOManager.GetZavrseneVoznjeVozaca(idVozaca);

            foreach (VoznjaPregled v in zavrseneVoznje)
            {
                ListViewItem item = new ListViewItem(new string[] { v.Id.ToString(), v.PocetnaStanica, v.KrajnjaStanica, v.VremePoziva.ToString(), v.VremePocetka.ToString(), v.VremeKraja.ToString(),v.CenaVoznje.ToString(), v.IdAdministrativnogOsoblja.idAO.ToString(), v.IdMusterije.IdMusterije.ToString(), v.BrojTelefonaPoziva });
                listZavrseneVoznje.Items.Add(item);
            }
            listZavrseneVoznje.Refresh();
        }

        private void btnIzmeniVozaca_Click(object sender, EventArgs e)
        {
            if (txtIme.Text != ime||txtPrezime.Text!=prezime||txtSrSlovo.Text!=srSlovo||
                txtUlica.Text!=ulica||txtBroj.Text!=broj||txtTelefon.Text!=telefon||
                txtKategorija.Text!=kategorija||txtDozvola.Text!=dozvola)
            {
                ime = txtIme.Text;
                prezime = txtPrezime.Text;
                srSlovo = txtSrSlovo.Text;
                ulica = txtUlica.Text;
                broj = txtBroj.Text;
                telefon = txtTelefon.Text;
                kategorija = txtKategorija.Text;
                dozvola = txtDozvola.Text;
                DTOManager.izmeniVozaca(id, txtIme.Text, txtPrezime.Text, txtSrSlovo.Text, txtUlica.Text, txtBroj.Text, txtTelefon.Text, txtKategorija.Text, txtDozvola.Text);
                MessageBox.Show("Uspešno ste promenili podatke o vozaču.");
                return;
            }
             MessageBox.Show("Niste uneli nikakve promene o vozaču.");
              return;
        }

        private void VozacPrikaz_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtIme.Text != ime || txtPrezime.Text != prezime || txtSrSlovo.Text != srSlovo ||
                txtUlica.Text != ulica || txtBroj.Text != broj || txtTelefon.Text != telefon ||
                txtKategorija.Text != kategorija || txtDozvola.Text != dozvola)
            {
                string poruka = "Niste sačuvali promene o vozaču, ako kliknete OK promene neće biti sačuvane.";
                string title = "Promena podataka o vozaču";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);
                if (result == DialogResult.OK)
                    e.Cancel = false;
                else
                    e.Cancel = true;
            }
        }
    }
}
