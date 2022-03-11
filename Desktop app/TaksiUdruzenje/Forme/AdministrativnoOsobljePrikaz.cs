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
    public partial class AdministrativnoOsobljePrikaz : Form
    {
        int id;
        string ime, prezime, srSlovo, ulica, broj, strucnaSprema, telefon;

        public AdministrativnoOsobljePrikaz(int idOsoblja)
        {
            InitializeComponent();
            id = idOsoblja;
            popuniLabele(id);
            IspuniListu();
        }
        private void popuniLabele(int idOsoblja)
        {
            AdministrativnoOsobljePregled osoblje = DTOManager.GetAOInfo(idOsoblja);
            lblID.Text = osoblje.idAO.ToString();
            ime = txtIme.Text = osoblje.Ime;
            prezime = txtPrezime.Text = osoblje.Prezime;
            srSlovo = txtSrSlovo.Text = osoblje.SrednjeSlovo;
            txtJmbg.Text = osoblje.Jmbg;
            broj = txtBroj.Text = osoblje.Broj;
            ulica = txtUlica.Text = osoblje.Ulica;
            strucnaSprema = txtStrucnaSprema.Text = osoblje.StrucnaSprema;
            telefon = txtTelefon.Text = osoblje.BrojTelefona;
            if (osoblje.SrednjeSlovo == null)
                srSlovo = "";
            if (osoblje.Ulica == null)
                ulica = "";
            if (osoblje.Broj == null)
                broj = "";

        }
    
        private void IspuniListu()
        {
            listPreuzeteVoznje.Items.Clear();
            List<VoznjaPregled> voznjapregled = DTOManager.GetVoznja(id);
            String cena, vremeKraja;

            foreach (VoznjaPregled voznja in voznjapregled)
            {
                if (voznja.CenaVoznje == null)
                    cena = "Vožnja je i dalje aktivna";
                else
                    cena = voznja.CenaVoznje.ToString();
                if (voznja.VremeKraja == null)
                    vremeKraja = "Vožnja je i dalje aktivna";
                else
                    vremeKraja = voznja.VremeKraja.ToString();

                ListViewItem item = new ListViewItem(new string[] { voznja.Id.ToString(),voznja.IdVozaca.IdVozac.ToString(),voznja.IdMusterije.IdMusterije.ToString(), voznja.PocetnaStanica, voznja.KrajnjaStanica,voznja.VremePoziva.ToString(),voznja.VremePocetka.ToString(),vremeKraja,cena,voznja.BrojTelefonaPoziva.ToString()});
                listPreuzeteVoznje.Items.Add(item);
            }
            listPreuzeteVoznje.Refresh();
        }

        private void btnIzmeniAO_Click(object sender, EventArgs e)
        {
            if (txtIme.Text != ime || txtPrezime.Text != prezime || txtSrSlovo.Text != srSlovo ||
                txtUlica.Text != ulica || txtBroj.Text != broj || txtTelefon.Text != telefon ||
                txtStrucnaSprema.Text!=strucnaSprema)
            {
                ime = txtIme.Text;
                prezime = txtPrezime.Text;
                srSlovo = txtSrSlovo.Text;
                ulica = txtUlica.Text;
                broj = txtBroj.Text;
                telefon = txtTelefon.Text;
                strucnaSprema = txtStrucnaSprema.Text;
                DTOManager.EditAdministrativno(id, txtIme.Text, txtPrezime.Text, txtSrSlovo.Text, txtUlica.Text, txtBroj.Text, txtTelefon.Text, txtStrucnaSprema.Text);
                MessageBox.Show("Uspešno ste promenili podatke o administrativnom osoblju.");
                return;
            }
            MessageBox.Show("Niste uneli nikakve promene o administrativnom osoblju.");
            return;
        }

        private void AdministrativnoOsobljePrikaz_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtIme.Text != ime || txtPrezime.Text != prezime || txtSrSlovo.Text != srSlovo ||
                txtUlica.Text != ulica || txtBroj.Text != broj || txtTelefon.Text != telefon ||
                txtStrucnaSprema.Text != strucnaSprema)
            {
                string poruka = "Niste sačuvali promene o administrativnom osoblju, ako kliknete OK promene neće biti sačuvane.";
                string title = "Promena podataka o administrativnom osoblju";
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
