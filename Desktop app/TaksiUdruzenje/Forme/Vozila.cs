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
    public partial class Vozila : Form
    {
        public Vozila()
        {
            InitializeComponent();
            IspuniListuSluzbena();
            IspuniListuLicna();
        }

        private void IspuniListuSluzbena()
        {
            listViewSluzbena.Items.Clear();
            List<SluzbenoVoziloPregled> svozilopregled = DTOManager.GetSluzbenaVozilaAll();

            foreach (SluzbenoVoziloPregled svozilo in svozilopregled)
            {
                ListViewItem item = new ListViewItem(new string[] { svozilo.Id.ToString(), svozilo.RegOznaka, svozilo.Marka, svozilo.Tip, ((DateTime)(svozilo.DatumIstekaRegistracije)).ToShortDateString(), svozilo.GodinaProizvodnje.ToString() }) ;
                listViewSluzbena.Items.Add(item);
            }
            listViewSluzbena.Refresh();
        }
        private void IspuniListuLicna()
        {
            listViewLicna.Items.Clear();
            string tekst;
            List<LicnoVoziloPregled> lvozilopregled = DTOManager.GetLicnaVozilaAll();
            foreach (LicnoVoziloPregled lvozilo in lvozilopregled)
            {
                if (lvozilo.KoriscenoDo == null)
                    tekst = "I dalje se koristi";
                else
                    tekst = lvozilo.KoriscenoDo.ToString();
                ListViewItem item = new ListViewItem(new string[] { lvozilo.Id.ToString(), 
                    lvozilo.RegOznaka,lvozilo.Marka, lvozilo.Tip, lvozilo.Boja, lvozilo.IdVozaca.IdVozac.ToString(),lvozilo.KoriscenoOd.ToString(),tekst });
                listViewLicna.Items.Add(item);
            }
            listViewLicna.Refresh();

        }

        private void btnDodajSluzbeno_Click(object sender, EventArgs e)
        {
            DodajSluzbeno forma = new DodajSluzbeno();
            forma.ShowDialog();
            this.IspuniListuSluzbena();
        }

        private void btnObrisiSluzbeno_Click(object sender, EventArgs e)
        {
            if (listViewSluzbena.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozilo koje zelite da obrisete!");
                return;
            }

            string poruka = "Da li zelite da obrisete vozila?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                int[] delArray = new int[listViewSluzbena.SelectedItems.Count];
                for (int i = 0; i < listViewSluzbena.SelectedItems.Count; i++)
                {
                    delArray[i] = Int32.Parse(listViewSluzbena.SelectedItems[i].SubItems[0].Text);
                }
                DTOManager.obrisiSluzbenaVozila(delArray);
                MessageBox.Show("Brisanje uspesno!");
                this.IspuniListuSluzbena();
            }
        }

        private void btnPrikaziSluzbeno_Click(object sender, EventArgs e)
        {
            if (listViewSluzbena.SelectedItems.Count !=1)
            {
                MessageBox.Show("Izaberite vozilo cije vozace zelite da prikazete!");
                return;
            }
            int id = Int32.Parse(listViewSluzbena.SelectedItems[0].SubItems[0].Text);
         
            SluzbenaVozilaPrikaz aop = new SluzbenaVozilaPrikaz(id);
            aop.ShowDialog();
            IspuniListuSluzbena();
        }

        private void btnDodajLicno_Click(object sender, EventArgs e)
        {
            DodajLicnoVozilo forma = new DodajLicnoVozilo();
            forma.ShowDialog();
            this.IspuniListuLicna();
        }

        private void btnObrisiLicno_Click(object sender, EventArgs e)
        {
            if (listViewLicna.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozilo koje zelite da obrisete!");
                return;
            }

            string poruka = "Da li zelite da obrisete vozila?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                int[] delArray = new int[listViewLicna.SelectedItems.Count];
                for (int i = 0; i < listViewLicna.SelectedItems.Count; i++)
                {
                    delArray[i] = Int32.Parse(listViewLicna.SelectedItems[i].SubItems[0].Text);
                }
                DTOManager.obrisiLicnaVozila(delArray);
                MessageBox.Show("Brisanje uspesno!");
                this.IspuniListuLicna();
            }
        }

        private void btnPrikaziLicno_Click(object sender, EventArgs e)
        {
            if (listViewLicna.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozilo koje zelite da prikazete!");
                return;
            }
            if (listViewLicna.SelectedItems.Count > 1)
            {
                MessageBox.Show("Mozete izabrati samo jedno vozilo za prikaz!");
                return;
            }
            int id = Int32.Parse(listViewLicna.SelectedItems[0].SubItems[0].Text);
            DTO.LicnoVoziloPregled v = DTOManager.GetLicnoVozilo(id);
            LicnoVoziloPrikaz forma = new LicnoVoziloPrikaz(v);
            forma.ShowDialog();
            this.IspuniListuLicna();
        }
    }
}
