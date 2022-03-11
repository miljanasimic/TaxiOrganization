using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;

namespace TaksiUdruzenje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenje.Entiteti.Musterija m = s.Load<TaksiUdruzenje.Entiteti.Musterija>(5);

                MessageBox.Show("Ime : " + m.Ime + "Adresa poziva: " + m.Adresa + ", broj vožnji: " + m.BrojVoznji);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void addMusterija_Click(object sender, EventArgs e)
        {
            //OVA FUNKCIJA DODAJE MUSTERIJU ZAJEDNO SA TELEFONIMA !

            try
            {
                ISession s = DataLayer.GetSession();
                TaksiUdruzenje.Entiteti.Musterija musterija = new TaksiUdruzenje.Entiteti.Musterija();

                musterija.Ime = "Pera";
                musterija.Prezime = "Peric";
                musterija.Adresa = "Dusanova bb";
                musterija.BrojVoznji = 4;

                TaksiUdruzenje.Entiteti.MusterijaMobile tel1 = new TaksiUdruzenje.Entiteti.MusterijaMobile();
                tel1.BrojTelefona = "0611111111";
                TaksiUdruzenje.Entiteti.MusterijaMobile tel2 = new TaksiUdruzenje.Entiteti.MusterijaMobile();
                tel2.BrojTelefona = "0633333333";

                tel1.IdMusterije = musterija;
                tel2.IdMusterije = musterija;

                musterija.MobilniTelefoni.Add(tel1);
                musterija.MobilniTelefoni.Add(tel2);

                s.Save(musterija);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void aoLoad_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenje.Entiteti.AdministrativnoOsoblje ao = s.Load<TaksiUdruzenje.Entiteti.AdministrativnoOsoblje>(414);

                MessageBox.Show("Ime: " + ao.Ime + ", prezime: " + ao.Prezime + ", strucna sprema: " + ao.StrucnaSprema);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void vozacLoad_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenje.Entiteti.Vozac v = s.Load<TaksiUdruzenje.Entiteti.Vozac>(313);

                MessageBox.Show("Ime: " + v.Ime + ", prezime: " + v.Prezime + ", strucna sprema: " + v.Kategorija + ", br. dozvole:" + v.BrojDozvole);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void voznjaLoad_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenje.Entiteti.Voznja voznja = s.Get<TaksiUdruzenje.Entiteti.Voznja>(803);

                MessageBox.Show("Pocetna stanica: " + voznja.PocetnaStanica + " krajnja stanica: " + voznja.KrajnjaStanica +
                " vreme poziva: " + voznja.VremePoziva + " vreme pocetka voznje: " + voznja.VremePocetka +
                " vreme zavrsetka voznje: " + voznja.VremeKraja + "cena voznje: " + voznja.CenaVoznje + "Broj telefona musterije: " + voznja.BrojTelefonaPoziva);
                
                //musterija koja je pozvala
                TaksiUdruzenje.Entiteti.Musterija musterija = s.Get<TaksiUdruzenje.Entiteti.Musterija>(voznja.IdMusterije.Id);
                MessageBox.Show("\n Broj voznji musterije: " + musterija.BrojVoznji.ToString());

                //administrator koji je primio poziv
                TaksiUdruzenje.Entiteti.AdministrativnoOsoblje administrativnoOsoblje = s.Load<TaksiUdruzenje.Entiteti.AdministrativnoOsoblje>(voznja.IdAdministrativnogOsoblja.Id);
                MessageBox.Show("Primio poziv: " + administrativnoOsoblje.Ime + " " + administrativnoOsoblje.Prezime);

                //vozac koji je vozio
                TaksiUdruzenje.Entiteti.Vozac vozac = s.Load<TaksiUdruzenje.Entiteti.Vozac>(voznja.IdVozaca.Id);
                MessageBox.Show("Vozio: " + vozac.Ime + " " + vozac.Prezime + " sa brojem vozacke dozvole: " + vozac.BrojDozvole);
                
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void svLoad_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                TaksiUdruzenje.Entiteti.SluzbenoVozilo sluzbenoVozilo = session.Load<TaksiUdruzenje.Entiteti.SluzbenoVozilo>(603);
                MessageBox.Show(sluzbenoVozilo.Marka + " " + sluzbenoVozilo.Tip + " " + sluzbenoVozilo.GodinaProizvodnje);

                foreach (Entiteti.VozioSluzbeno vozilo in sluzbenoVozilo.VozilaVozioSluzbeno)
                {
                    MessageBox.Show("Vozac : " + vozilo.IdVozaca.Ime);
                }

                session.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void popustLoad_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                TaksiUdruzenje.Entiteti.Popust popust= session.Load<TaksiUdruzenje.Entiteti.Popust>(119);
                MessageBox.Show(popust.VrednostPopusta + " " + popust.DatumPocetka);

                //musterija koja ima pravo na popust
                TaksiUdruzenje.Entiteti.Musterija musterija = session.Load<TaksiUdruzenje.Entiteti.Musterija>(popust.IdMusterije.Id);
                MessageBox.Show(musterija.Ime + " " + musterija.Prezime);

                session.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvVoad_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                TaksiUdruzenje.Entiteti.LicnoVozilo licnoVozilo = session.Load<TaksiUdruzenje.Entiteti.LicnoVozilo>(513);
                MessageBox.Show(licnoVozilo.Marka + " " + licnoVozilo.Tip + " " + licnoVozilo.RegOznaka);

                //vozac koji je vozio (ili) vozi to vozilo
                TaksiUdruzenje.Entiteti.Vozac vozac = session.Load<TaksiUdruzenje.Entiteti.Vozac>(licnoVozilo.IdVozaca.Id);
                MessageBox.Show(vozac.Ime + " " + vozac.Prezime + " " + vozac.BrojDozvole);

                session.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void manytooneload_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenje.Entiteti.MusterijaMobile mm = s.Load<TaksiUdruzenje.Entiteti.MusterijaMobile>(212);

                MessageBox.Show("Ime korisnika: " + mm.IdMusterije.Ime + " Broj telefona: " + mm.BrojTelefona);
                // MessageBox.Show();

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void onetomanyload_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenje.Entiteti.Musterija mm = s.Load<TaksiUdruzenje.Entiteti.Musterija>(10);

                foreach (TaksiUdruzenje.Entiteti.MusterijaMobile m in mm.MobilniTelefoni)
                {
                    MessageBox.Show("Ime musterije: " + mm.Ime + ", broj telefona:  " + m.BrojTelefona);
                }

                //MessageBox.Show("Ime korisnika: " + mm.Ime + " Broj telefona: " + mm.mobilniTelefoni);
                // MessageBox.Show();

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenje.Entiteti.Musterija mm = s.Load<TaksiUdruzenje.Entiteti.Musterija>(3);

                foreach (TaksiUdruzenje.Entiteti.Voznja v in mm.Voznje)
                {
                    MessageBox.Show("Ime musterije: " + mm.Ime + ", pozvano sa broja: " + v.BrojTelefonaPoziva);
                }

                //MessageBox.Show("Ime korisnika: " + mm.Ime + " Broj telefona: " + mm.mobilniTelefoni);
                // MessageBox.Show();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void motVoznja_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenje.Entiteti.Voznja v = s.Load<TaksiUdruzenje.Entiteti.Voznja>(805);

                MessageBox.Show("Ime korisnika: " + v.IdMusterije.Ime + " Broj telefona: " + v.BrojTelefonaPoziva);
                // MessageBox.Show();

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenje.Entiteti.Voznja v = s.Load<TaksiUdruzenje.Entiteti.Voznja>(805);

                MessageBox.Show("Pocetna stanica: " + v.PocetnaStanica + " Krajnja Stanica " + v.KrajnjaStanica + " Dodelio voznju: " + v.IdAdministrativnogOsoblja.Ime);
                // MessageBox.Show();

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void otmaoLoad_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenje.Entiteti.AdministrativnoOsoblje ao = s.Load<TaksiUdruzenje.Entiteti.AdministrativnoOsoblje>(412);

                foreach (TaksiUdruzenje.Entiteti.Voznja v in ao.DodeljeneVoznje)
                {
                    MessageBox.Show("Dodelio voznju: " + ao.Ime + ", Broj voznje:  " + v.Id + "Pocetna stanica:" + v.PocetnaStanica);
                }

                //MessageBox.Show("Ime korisnika: " + mm.Ime + " Broj telefona: " + mm.mobilniTelefoni);
                // MessageBox.Show();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void otmVozVoz_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenje.Entiteti.Vozac vozac = s.Load<TaksiUdruzenje.Entiteti.Vozac>(313);

                foreach (TaksiUdruzenje.Entiteti.LicnoVozilo v in vozac.LicnaVozila)
                {
                    MessageBox.Show("Vozac: " + vozac.Ime + ", vozio je kola:  " + v.Marka + " " + v.Tip);
                }

                //MessageBox.Show("Ime korisnika: " + mm.Ime + " Broj telefona: " + mm.mobilniTelefoni);
                // MessageBox.Show();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void motVozVoz_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenje.Entiteti.LicnoVozilo lv = s.Load<TaksiUdruzenje.Entiteti.LicnoVozilo>(514);

                MessageBox.Show("Vozac: " + lv.IdVozaca.Ime + ", vozio je kola:  " + lv.Marka + " " + lv.Tip);
                // MessageBox.Show();

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void muspopOTM_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenje.Entiteti.Musterija m = s.Load<TaksiUdruzenje.Entiteti.Musterija>(4);

                foreach (TaksiUdruzenje.Entiteti.Popust p in m.Popusti)
                {
                    MessageBox.Show("Musterija: " + m.Ime + ", ostvarila je popust u vrednosti od:  " + p.VrednostPopusta);
                }

                //MessageBox.Show("Ime korisnika: " + mm.Ime + " Broj telefona: " + mm.mobilniTelefoni);
                // MessageBox.Show();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void mtomuspop_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenje.Entiteti.Popust popust = s.Load<TaksiUdruzenje.Entiteti.Popust>(120);

                MessageBox.Show("Musterija: " + popust.IdMusterije.Ime + ", ostvarila je popust u vrednosti od:  " + popust.VrednostPopusta);
                // MessageBox.Show();

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void manytomany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenje.Entiteti.Vozac v1 = s.Load<TaksiUdruzenje.Entiteti.Vozac>(316);

                foreach (TaksiUdruzenje.Entiteti.VozioSluzbeno sv in v1.VozacVozioSluzbeno)
                {
                    MessageBox.Show(sv.IdVozaca.Ime + " " + sv.IdVozaca.Prezime);
                }

                TaksiUdruzenje.Entiteti.SluzbenoVozilo s1 = s.Load<TaksiUdruzenje.Entiteti.SluzbenoVozilo>(603);

                foreach (TaksiUdruzenje.Entiteti.VozioSluzbeno v in s1.VozilaVozioSluzbeno)
                {
                    MessageBox.Show(v.IdSluzbenogVozila.RegOznaka + " " + v.IdSluzbenogVozila.Marka);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenje.Entiteti.Vozac v = s.Load<TaksiUdruzenje.Entiteti.Vozac>(320);
                TaksiUdruzenje.Entiteti.SluzbenoVozilo sv = s.Load<TaksiUdruzenje.Entiteti.SluzbenoVozilo>(604);

                TaksiUdruzenje.Entiteti.VozioSluzbeno vs = new TaksiUdruzenje.Entiteti.VozioSluzbeno();
                //vs.Id.VozacUpravljao = v;
                //vs.Id.UpravljaoSluzbenim = sv;
                vs.DatumOd = new DateTime(2021, 06, 06);
                vs.DatumDo = new DateTime(2021, 07, 07);
                MessageBox.Show("DODAT!");
                s.Save(vs);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mobtelLoad_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                //musterija cije brojeve zelimo
                TaksiUdruzenje.Entiteti.Musterija m = session.Load<TaksiUdruzenje.Entiteti.Musterija>(10);
                MessageBox.Show(m.Ime + " " + m.Prezime);

                //telefon
                foreach (TaksiUdruzenje.Entiteti.MusterijaMobile mob in m.MobilniTelefoni)
                {
                    TaksiUdruzenje.Entiteti.MusterijaMobile tel = session.Load<TaksiUdruzenje.Entiteti.MusterijaMobile>(mob.Id);
                    MessageBox.Show(tel.BrojTelefona);
                }

                session.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mobtelAdd_Click(object sender, EventArgs e)
        {

        }

        private void aoAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                TaksiUdruzenje.Entiteti.AdministrativnoOsoblje ao = new TaksiUdruzenje.Entiteti.AdministrativnoOsoblje();
                ao.Ime = "Nova";
                ao.Prezime = "Osoba";
                ao.Jmbg = "1234555678901";
                ao.StrucnaSprema = "IV";
                ao.Ulica = "Test Ulica";
                ao.BrojTelefona = "1231231233";

                session.Save(ao);
                session.Flush();
                session.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addVozac_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                TaksiUdruzenje.Entiteti.Vozac vozac = new TaksiUdruzenje.Entiteti.Vozac();
                vozac.Ime = "Novi";
                vozac.Prezime = "Vozac";
                vozac.Jmbg = "1234555678901";
                vozac.BrojDozvole = "1111111111";
                vozac.Ulica = "Test Ulica";
                vozac.BrojTelefona = "3333333333";
                vozac.Kategorija = "B";

                Entiteti.SluzbenoVozilo sluzbeno = new Entiteti.SluzbenoVozilo();
                sluzbeno.DatumIstekaRegistracije = new DateTime(2022, 7, 15);
                sluzbeno.GodinaProizvodnje = 2015;
                sluzbeno.RegOznaka = "FF-222-DD";
                sluzbeno.Marka = "BMW e46";
                sluzbeno.Tip = "Coupe";

                session.Save(vozac);
                session.Save(sluzbeno);
                //session.Flush();

                Entiteti.VozioSluzbeno vozio = new Entiteti.VozioSluzbeno();
                vozio.DatumOd = DateTime.Now;
                vozio.IdVozaca = vozac;
                vozio.IdSluzbenogVozila = sluzbeno;

                session.Save(vozio);
                session.Flush();

                session.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addVoznja_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Entiteti.AdministrativnoOsoblje ao = session.Load<Entiteti.AdministrativnoOsoblje>(418);
                Entiteti.Vozac vozac = session.Load<Entiteti.Vozac>(352);
                Entiteti.Musterija musterija = session.Load<Entiteti.Musterija>(6);

                Entiteti.Voznja v = new Entiteti.Voznja();
                v.BrojTelefonaPoziva = "1231231233";
                v.CenaVoznje = 400;

                v.IdAdministrativnogOsoblja = ao;
                v.IdVozaca = vozac;
                v.IdMusterije = musterija;
                v.PocetnaStanica = "POCETNA";
                v.KrajnjaStanica = "KRAJNJA";

                ao.DodeljeneVoznje.Add(v);
                vozac.VozeneVoznje.Add(v);
                musterija.Voznje.Add(v);

                session.Save(ao);
                session.Save(vozac);
                session.Save(musterija);

                session.Flush();
                session.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            TaksiUdruzenje.TaxiHome formica = new TaksiUdruzenje.TaxiHome();
            formica.ShowDialog();
        }
    }
}
