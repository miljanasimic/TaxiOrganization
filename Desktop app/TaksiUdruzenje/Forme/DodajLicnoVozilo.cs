using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TaksiUdruzenje.DTOManager;
namespace TaksiUdruzenje.Forme
{
    public partial class DodajLicnoVozilo : Form
    {
        public DodajLicnoVozilo()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkKoristiSe.Checked == true)
                this.dtpDo.Enabled = false;
            else
                this.dtpDo.Enabled = true;
        }

        private void DodajLicnoVozilo_Load(object sender, EventArgs e)
        {
            this.IspuniListu();
        }

        public void IspuniListu()
        {
            lstVozaci.Items.Clear();
            List<DTO.VozacPregled> vozaci = DTOManager.GetVozacAll();
            foreach (DTO.VozacPregled vozac in vozaci)
            {
                ListViewItem item = new ListViewItem(new string[] { vozac.IdVozac.ToString(), vozac.Ime,
                    vozac.Prezime, vozac.BrojDozvole, vozac.Kategorija});
                lstVozaci.Items.Add(item);
                lstVozaci.View = View.Details;
            }
            lstVozaci.Refresh();
        }

        private void DodajLicnoVozilo_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < lstVozaci.SelectedItems.Count; i++)
                lstVozaci.SelectedItems[i].Selected = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(lstVozaci.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste izabrali vozaca!");
                return;
            }
            if(markatxt.Text.Length == 0 || regoznakatxt.Text.Length == 0)
            {
                MessageBox.Show("Niste uneli sve potrebne informacije!");
                return;
            }

            DateTime? datumDo;
            if (chkKoristiSe.Checked)
                datumDo = null;
            else
                datumDo = dtpDo.Value;

            int idVozaca = Int32.Parse(lstVozaci.SelectedItems[0].SubItems[0].Text);

            DTOManager.createLicno(idVozaca, markatxt.Text, regoznakatxt.Text, tiptxt.Text, bojatxt.Text,
                dtpOd.Value, datumDo);

            MessageBox.Show("Dodavanje uspesno!");
            this.Close();
        }
    }
}
