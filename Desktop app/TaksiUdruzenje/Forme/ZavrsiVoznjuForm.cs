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
    public partial class ZavrsiVoznjuForm : Form
    {
        private DTO.VoznjaPregled voznja;
        public ZavrsiVoznjuForm()
        {
            InitializeComponent();
        }

        public ZavrsiVoznjuForm(DTO.VoznjaPregled v)
        {
            InitializeComponent();
            this.voznja = v;
        }

        private void ZavrsiVoznjuForm_Load(object sender, EventArgs e)
        {
            this.IspuniPopuste();
            this.lblMusterija.Text = voznja.IdMusterije.Ime + " " + voznja.IdMusterije.Prezime;
        }

        public void IspuniPopuste()
        {
            lstPopusti.Items.Clear();

            List<DTO.PopustPregled> popusti = DTOManager.GetPopustMusterije(voznja.IdMusterije.IdMusterije);
            foreach (DTO.PopustPregled popust in popusti)
            {
                ListViewItem item = new ListViewItem(new string[] { popust.Id.ToString(), popust.IdMusterije.IdMusterije.ToString(),
                    popust.Vrednost.ToString(), popust.DatumPocetka.ToString(), popust.DatumKraja.ToString()});
                lstPopusti.Items.Add(item);
                lstPopusti.View = View.Details;
            }

            lstPopusti.Refresh();
        }

        private void btnIskoristiPopust_Click(object sender, EventArgs e)
        {
            if (lstPopusti.SelectedItems.Count == 0)
                MessageBox.Show("Niste izabrali zeljeni popust!");
            else if (lstPopusti.SelectedItems.Count > 1)
                MessageBox.Show("Morate izabrati jedan popust!");
            else
            {
                if(txtCena.Value == 0)
                {
                    MessageBox.Show("Unesite cenu voznje!");
                    return;
                }
                if (txtCena.Value < 100)
                {
                    MessageBox.Show("Voznja mora biti minimum 100 dinara!");
                    return;
                }

                int idPopusta = Int32.Parse(lstPopusti.SelectedItems[0].SubItems[0].Text);
                DTO.PopustPregled p = DTOManager.GetPopust(idPopusta);
                txtCena.Value = (decimal)((double)txtCena.Value * ( 1 - ((double)p.Vrednost / 100)));
                DTOManager.obrisiPopust(idPopusta);
                MessageBox.Show("Popust iskoricen!");
                this.IspuniPopuste();
            }
        }

        private void btnZavrsiVoznju_Click(object sender, EventArgs e)
        {
            int cena = (int)txtCena.Value;
            DTOManager.ZavrsiVoznju(voznja.Id, cena);
            MessageBox.Show("Voznja uspesno zavrsena.");
            this.Close();
        }
    }
}
