using NHibernate;
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
    public partial class DodajMusterijuForm : Form
    {
        public DodajMusterijuForm()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtIme.Text.Length == 0 || txtAdresa.Text.Length == 0 || txtTelefoni.Text.Length == 0)
            {
                MessageBox.Show("Niste uneli sve potrebne informacije");
                return;
            }

            string ime = txtIme.Text;
            string prezime = txtPrez.Text;
            string adresa = txtPrez.Text;
            //niz unetih telefona
            string[] telefoni = txtTelefoni.Text.Replace("\r", "").Split('\n');

            DTOManager.DodajMusteriju(ime, prezime, adresa, telefoni);
            this.Close();
        }
    }
}
