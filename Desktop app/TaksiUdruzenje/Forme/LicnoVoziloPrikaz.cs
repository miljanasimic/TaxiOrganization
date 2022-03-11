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
    public partial class LicnoVoziloPrikaz : Form
    {
        private DTO.LicnoVoziloPregled vozilo;
        private string reg;
        private string tip;
        private string marka;
        private string boja;
        public LicnoVoziloPrikaz()
        {
            InitializeComponent();
        }
        public LicnoVoziloPrikaz(DTO.LicnoVoziloPregled v)
        {
            InitializeComponent();
            this.vozilo = v;
        }

        private void LicnoVoziloPrikaz_Load(object sender, EventArgs e)
        {
            this.lblIdValue.Text = vozilo.Id.ToString();
            this.IspuniFormu();
            this.IspuniVozaca();
            if (txtDo.Text.Length == 0)
                btnZavrsi.Enabled = true;
            else btnZavrsi.Enabled = false;

            reg = txtReg.Text;
            marka = txtMarka.Text;
            tip = txtTip.Text;
            boja = txtBoja.Text;

        }

        public void IspuniFormu()
        {
            DTOManager.GetLicnoVozilo(vozilo.Id);
            txtReg.Text = vozilo.RegOznaka;
            txtMarka.Text = vozilo.Marka;
            txtBoja.Text = vozilo.Boja;
            txtTip.Text = vozilo.Tip;
            txtOd.Text = vozilo.KoriscenoOd.ToShortDateString();
            if (vozilo.KoriscenoDo != null)
                txtDo.Text = ((DateTime)vozilo.KoriscenoDo).ToShortDateString();
            else
                txtDo.Text = "";
        }

        public void IspuniVozaca()
        {
            lstVozac.Items.Clear();
            DTO.VozacPregled v = DTOManager.GetVozac(vozilo.IdVozaca.IdVozac);
            ListViewItem item = new ListViewItem(new string[] { v.IdVozac.ToString(), v.Ime,
                v.Prezime, v.BrojDozvole, v.Kategorija});
            lstVozac.Items.Add(item);
            lstVozac.View = View.Details;
            lstVozac.Refresh();
        }

        private void btnZavrsi_Click(object sender, EventArgs e)
        {
            DTOManager.ZavrsiLicno(vozilo.Id);
            this.IspuniFormu();
        }

        private void LicnoVoziloPrikaz_MouseClick(object sender, MouseEventArgs e)
        {
            if (lstVozac.SelectedItems.Count == 1)
                lstVozac.SelectedItems[0].Selected = false;
        }

        private void lstVozac_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstVozac.SelectedItems.Count == 1)
            {
                int id = Int32.Parse(lstVozac.SelectedItems[0].SubItems[0].Text);
                VozacPrikaz forma = new VozacPrikaz(id);
                forma.ShowDialog();
                this.IspuniVozaca();
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (txtReg.Text != reg || txtBoja.Text != boja || txtMarka.Text != marka || txtTip.Text != tip)
            {
                reg = txtReg.Text;
                boja = txtBoja.Text;
                marka = txtMarka.Text;
                tip = txtTip.Text;

                int idVozila = this.vozilo.Id;
                DTOManager.IzmeniLicnoVozilo(idVozila, reg, boja, marka, tip);
                MessageBox.Show("Vozilo je uspesno promenjeno!");
            }
            else
            {
                MessageBox.Show("Nema unetih izmena!");
                return;
            }
        }
    }
}
