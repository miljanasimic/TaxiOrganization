using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate.Linq;
using TaksiUdruzenje.Properties;
using static TaksiUdruzenje.DTO;

namespace TaksiUdruzenje.Forme
{
    public partial class AdministrativnoOsobljeForm : Form
    {

        public int AoId { get; set; }
        public TaksiUdruzenje.Entiteti.AdministrativnoOsoblje ao { get; set; }
        public AdministrativnoOsobljeForm()
        {

            InitializeComponent();
            listViewAO.Refresh();
        }
        public AdministrativnoOsobljeForm(int AoId)
        {
           this.AoId = AoId;
            InitializeComponent();
            listViewAO.Refresh();
        }
        private void IspuniListu()
        {
            listViewAO.Items.Clear();
            List< AdministrativnoOsobljePregled > aopregled = DTOManager.GetAOAll();

            foreach (AdministrativnoOsobljePregled aoao in aopregled)
            {
                ListViewItem item = new ListViewItem(new string[] { aoao.idAO.ToString(),aoao.Jmbg, aoao.Ime,aoao.SrednjeSlovo,aoao.Prezime, aoao.BrojTelefona,aoao.Ulica,aoao.Broj,aoao.StrucnaSprema });
                listViewAO.Items.Add(item);
                listViewAO.View = View.Details;
            }
            listViewAO.Refresh();
        }

        private void AdministrativnoOsobljeForm_Load(object sender, EventArgs e)
        {
            IspuniListu();
        }

        private void dodajAO_Click(object sender, EventArgs e)
        {
            DodajAdministrativnoOsoblje dodajao = new DodajAdministrativnoOsoblje();
            dodajao.ShowDialog();
            IspuniListu();
        }

        private void obrisiAO_Click(object sender, EventArgs e)
        {
            if (listViewAO.SelectedItems.Count <1)
            {
                MessageBox.Show("Izaberite bar jednog zaposlenog iz administrativnog osoblja kako bi brisanje bilo moguće.");
                return;
            }
            string poruka = "Da li želite da obrišete selektovane zaposlene iz administrativnog osoblja?";
            string title = "Brisanje administrativnog osoblja";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                List<int> idAO = new List<int>();
                for (int i = 0; i < listViewAO.SelectedItems.Count; i++)
                    idAO.Add(Int32.Parse(listViewAO.SelectedItems[i].SubItems[0].Text));
                DTOManager.obrisiOsoblje(idAO);
                IspuniListu();
                MessageBox.Show("Brisanje administrativnog osoblja je uspešno.");
                IspuniListu();

                return;
            }
            
        }

        private void btnPrikaziAO_Click(object sender, EventArgs e)
        {
            if (listViewAO.SelectedItems.Count != 1)
            {
                if (listViewAO.SelectedItems.Count > 1)
                {
                    for (int i = 0; i < listViewAO.SelectedItems.Count; i++)
                    {
                        listViewAO.SelectedItems[i].Selected = false;
                        i--;
                    }
                }
                MessageBox.Show("Izaberite jednog zaposlenog iz administrativnog osoblja za prikaz.");
                return;
            }

            int idOsoblja = Int32.Parse(listViewAO.SelectedItems[0].SubItems[0].Text);
            AdministrativnoOsobljePrikaz aop = new AdministrativnoOsobljePrikaz(idOsoblja);
            aop.ShowDialog();
            IspuniListu();


        }
    }
}
