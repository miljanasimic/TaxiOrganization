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
    public partial class DodajSluzbeno : Form
    {
        public DodajSluzbeno()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (markatxt.Text.Length == 0 || regoznakatxt.Text.Length == 0)
            {
                MessageBox.Show("Unesite sve podatke!");
                return;
            }    
            DTOManager.createSluzbeno(markatxt.Text, regoznakatxt.Text, 
                tiptxt.Text, dtpDatum.Value, (int)numGodina.Value);
            MessageBox.Show("Dodavanje uspesno!");
            this.Close();
        }
    }
}
