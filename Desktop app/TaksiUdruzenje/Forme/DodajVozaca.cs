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
    public partial class DodajVozaca : Form
    {
        public DodajVozaca()
        {
            InitializeComponent();
        }

        private void btnDodajVozaca_Click(object sender, EventArgs e)
        {
            if (txtIme.Text == "" || txtPrezime.Text == "" || txtJmbg.Text.Length != 13||
                txtBrTelefona.Text==""||txtBrDozvole.Text==""||txtKategorija.Text=="")
            {
                MessageBox.Show("Molimo Vas da popunite sva obavezna polja.");
                return;
            }
            CreateVozac(txtIme.Text, txtSrednjeSlovo.Text,
                txtPrezime.Text, txtJmbg.Text, txtBrTelefona.Text, txtUlica.Text ,
                txtBroj.Text, txtBrDozvole.Text,txtKategorija.Text);
            MessageBox.Show("Vozac je uspesno dodat.");
            return;
        }
    }
}
