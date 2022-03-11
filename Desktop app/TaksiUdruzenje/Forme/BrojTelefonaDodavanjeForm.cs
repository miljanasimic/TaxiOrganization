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
    public partial class BrojTelefonaDodavanjeForm : Form
    {
        private int idMusterije;
        public BrojTelefonaDodavanjeForm()
        {
            InitializeComponent();
        }

        public BrojTelefonaDodavanjeForm(int idMusterije)
        {
            InitializeComponent();
            this.idMusterije = idMusterije;
        }

        private void btnDodajTelefon_Click(object sender, EventArgs e)
        {
            if (txtBroj.Text.Length < 8)
                MessageBox.Show("Uneli ste prekratak telefon.\nMolim vas unesite validan broj.");

            DTOManager.DodajTelefon(this.idMusterije, this.txtBroj.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
