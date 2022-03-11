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
    public partial class SluzbenaVozilaPrikaz : Form
    {
        int id, datproi;
        private string tip, marka, regoznaka, istekReg;

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            SluzebnoDodela dodela = new SluzebnoDodela(id);
            dodela.ShowDialog();
            this.IspuniListu();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTip.Text != tip || txtReg.Text != regoznaka || txtMarka.Text != marka || numericGodProizvodnje.Value != datproi)
            {
                tip = txtTip.Text;
                regoznaka = txtReg.Text;
                marka = txtMarka.Text;
                datproi = (int)numericGodProizvodnje.Value;
                DTOManager.EditSluzbenoVozilo(id, tip, regoznaka, marka, datproi);

                MessageBox.Show("Uspešno ste promenili podatke o službenom vozilu.");
                return;
            }
            MessageBox.Show("Niste uneli nikakve promene o službenom vozilu.");
            return;
        }
       

        private SluzbenoVoziloPregled vozilo;
        public SluzbenaVozilaPrikaz(int id)
        {
            InitializeComponent();
            this.id = id;
            this.IspuniListu();
            listVozacaSluzbenog.Refresh();
            ispuniPodatke(id);

        }

        public void ispuniPodatke(int id)
        {
            this.vozilo = DTOManager.vratiSluzbenoVozilo(id);
            regoznaka=txtReg.Text = vozilo.RegOznaka;
            tip=txtTip.Text = vozilo.Tip;
            marka=txtMarka.Text = vozilo.Marka;
            if (vozilo.DatumIstekaRegistracije == null)
                txtIstekReg.Text = "";
            else
                txtIstekReg.Text = ((DateTime)(vozilo.DatumIstekaRegistracije)).ToShortDateString();
            istekReg = txtIstekReg.Text;
            numericGodProizvodnje.Value = vozilo.GodinaProizvodnje;
            datproi = vozilo.GodinaProizvodnje;
            txtID.Text = id.ToString();
             
            
        }
        private void IspuniListu()
        {
            listVozacaSluzbenog.Items.Clear();
            List<VozacPregled> listaVozaca = DTOManager.GetVozacaSluzbenog(id);

            foreach (VozacPregled vozac in listaVozaca)
            {
                ListViewItem item = new ListViewItem(new string[] { vozac.IdVozac.ToString(), vozac.Ime, vozac.SrednjeSlovo, vozac.Prezime, vozac.BrojTelefona, vozac.Ulica, vozac.Broj,vozac.Kategorija});
                listVozacaSluzbenog.Items.Add(item);
                listVozacaSluzbenog.View = View.Details;
            }
            listVozacaSluzbenog.Refresh();
        }

    }
}
