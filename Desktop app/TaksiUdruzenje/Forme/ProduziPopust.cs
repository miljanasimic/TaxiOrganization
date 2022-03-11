using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaksiUdruzenje.Entiteti;
using static TaksiUdruzenje.DTO;


namespace TaksiUdruzenje.Forme
{
    public partial class ProduziPopust : Form
    {
        private int idPopusta;
        bool produzen;
        public ProduziPopust(int idPopusta)
        {
            InitializeComponent();
            produzen = false;
            this.idPopusta = idPopusta;
            PopustPregled popust=DTOManager.GetPopust(idPopusta);
            lblInfomacije.Text = "Izabrani popust važi od " + popust.DatumPocetka.ToShortDateString()+" do "+((DateTime)(popust.DatumKraja)).ToShortDateString();
            dateTimePickerTrajanje.Value = popust.DatumKraja.Value.AddDays(1);
            dateTimePickerTrajanje.MinDate = popust.DatumKraja.Value.AddDays(1);
        }

        
        private void checkBoxNeograniceno_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNeograniceno.Checked == true)
                dateTimePickerTrajanje.Enabled = false;
            else
                dateTimePickerTrajanje.Enabled = true;
        }

        private void btnProduziPopust_Click(object sender, EventArgs e)
        {
            DateTime? trajanjeDo = null;
            if (checkBoxNeograniceno.Checked == false)
                trajanjeDo = dateTimePickerTrajanje.Value;
            DTOManager.ProduziPopust(this.idPopusta, trajanjeDo);
            MessageBox.Show("Popust je uspešno produžen.");
            produzen = true;
            this.Close();
        }

        private void ProduziPopust_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!produzen)
            {
                string poruka = "Niste produžili trajanje ovog popusta, ako kliknete OK popust neće biti produžen.";
                string title = "Produženje važenja popusta";
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
