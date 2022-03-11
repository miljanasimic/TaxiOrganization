using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TaksiUdruzenje.DTO;
namespace TaksiUdruzenje.Forme
{
    public partial class VoznjeForm : Form
    {
        public VoznjeForm()
        {
            InitializeComponent();
        }

        private void VoznjeForm_Load(object sender, EventArgs e)
        {
            this.IspuniListu();
        }
        private void IspuniListu()
        {
            listView1.Items.Clear();
            List<VoznjaPregled> vpregled = DTOManager.GetVoznjaAll();

            foreach (VoznjaPregled v in vpregled)
            {
                ListViewItem item = new ListViewItem(new string[] { v.Id.ToString(),v.PocetnaStanica,v.KrajnjaStanica,v.VremePoziva.ToString(),v.IdVozaca.IdVozac.ToString(),v.VremePocetka.ToString(),v.VremeKraja.ToString(),v.CenaVoznje.ToString(),v.IdAdministrativnogOsoblja.idAO.ToString(),v.IdMusterije.IdMusterije.ToString(),v.BrojTelefonaPoziva.ToString()});
                listView1.Items.Add(item);
                listView1.View = View.Details;
            }
            listView1.Refresh();
        }

    }
}
