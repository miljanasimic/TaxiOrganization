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

namespace TaksiUdruzenje
{
    public partial class TaxiHome : Form
    {
        public TaxiHome()
        {
            InitializeComponent();
        }

        private void btnAdOsoblje_Click(object sender, EventArgs e)
        {
            TaksiUdruzenje.Forme.AdministrativnoOsobljeForm forma = new TaksiUdruzenje.Forme.AdministrativnoOsobljeForm();
            forma.ShowDialog();
        }

        private void btnMusterije_Click(object sender, EventArgs e)
        {
            TaksiUdruzenje.Forme.MusterijeForm forma = new TaksiUdruzenje.Forme.MusterijeForm();
            forma.ShowDialog();
        }

        private void btnVozaci_Click(object sender, EventArgs e)
        {
            TaksiUdruzenje.Forme.VozaciForm forma = new TaksiUdruzenje.Forme.VozaciForm();
            forma.ShowDialog();

        }

        private void btnVozila_Click(object sender, EventArgs e)
        {
            TaksiUdruzenje.Forme.Vozila forma = new TaksiUdruzenje.Forme.Vozila();
            forma.ShowDialog();
        }

        private void btnVoznje_Click(object sender, EventArgs e)
        {
            TaksiUdruzenje.Forme.VoznjaForm forma = new TaksiUdruzenje.Forme.VoznjaForm();
            forma.ShowDialog();
        }

        private void btnPopusti_Click(object sender, EventArgs e)
        {
            TaksiUdruzenje.Forme.PopustiForm forma = new TaksiUdruzenje.Forme.PopustiForm();
            forma.ShowDialog();
        }

        private void TaxiHome_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
