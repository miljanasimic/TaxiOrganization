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
    public partial class DodajAdministrativnoOsoblje : Form
    {
        public DodajAdministrativnoOsoblje()
        {
            InitializeComponent();
        }

        private void btnDodajAdOsoblje_Click(object sender, EventArgs e)
        {
            if (imetxt.Text == "" || prezimetxt.Text== "" || jmbgtxt.Text.Length != 13 ||
                brteltxt.Text == "" || strucnasprematxt.Text == "")
            {
                MessageBox.Show("Molimo Vas da popunite sva obavezna polja.");
                return;
            }
            CreateAdministrativno(jmbgtxt.Text, imetxt.Text, sstxt.Text, prezimetxt.Text, brteltxt.Text, ulicatxt.Text, brojtxt.Text, strucnasprematxt.Text);
            MessageBox.Show("Administrativno osoblje je uspešno dodato.");
            return;
        }

        
    }
}
