using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaksiUdruzenjeLibrary.Entiteti;
using static TaksiUdruzenjeLibrary.DTO;

namespace TaksiUdruzenjeLibrary
{
    public class DataProvider
    {
        
        #region AdministrativnoOsoblje

        public static AdministrativnoOsobljePregled GetAOInfo(int id)
        {
            AdministrativnoOsobljePregled ao = null;
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("select ao from AdministrativnoOsoblje ao where ao.Id=" + id);
                AdministrativnoOsoblje a = q.UniqueResult<AdministrativnoOsoblje>();

                if (a != null)
                {
                    ao = new AdministrativnoOsobljePregled(a);
                    ao.DodeljeneVoznje= a.DodeljeneVoznje.Select(dv => new VoznjaPregled(dv)).ToList();
                }
                s.Close();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!" + ex);
            }
            return ao;
        }

        public static List<AdministrativnoOsobljePregled> GetAOAll()
        {
            List<AdministrativnoOsobljePregled> aoinfo = new List<AdministrativnoOsobljePregled>();
            try
            {
                ISession session = DataLayer.GetSession();

                IEnumerable<AdministrativnoOsoblje> ao = from a in session.Query<AdministrativnoOsoblje>()
                                                         select a;

                foreach (AdministrativnoOsoblje aaoo in ao)
                {
                    var a = new AdministrativnoOsobljePregled(aaoo);
                    a.DodeljeneVoznje= aaoo.DodeljeneVoznje.Select(dv => new VoznjaPregled(dv)).ToList();
                    aoinfo.Add(a);
                }
                session.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!" + ex);
            }
            return aoinfo;
        }

        public static bool EditAdministrativno(int id, string ime, string prezime, string srednjeslovo, string ulica, string broj, string brojtelefona, string strucnasprema)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                AdministrativnoOsoblje ao = session.Get<AdministrativnoOsoblje>(id);
                if (ao == null)
                    return false;
                ao.Ime = ime;
                ao.Prezime = prezime;
                ao.SrednjeSlovo = srednjeslovo;
                ao.BrojTelefona = brojtelefona;
                ao.Ulica = ulica;
                ao.Broj = broj;
                ao.StrucnaSprema = strucnasprema;

                session.SaveOrUpdate(ao);
                session.Flush();
                session.Close();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
                return false;
            }
        }
        public static bool CreateAdministrativno(string jmbg, string ime, string srednjeslovo, string prezime, string brojtelefona, string ulica, string broj, string strucnasprema)
        {

            try
            {
                ISession session = DataLayer.GetSession();
                AdministrativnoOsoblje ao = new AdministrativnoOsoblje();
                ao.Jmbg = jmbg;
                ao.Ime = ime;
                ao.Prezime = prezime;
                ao.SrednjeSlovo = srednjeslovo;
                ao.BrojTelefona = brojtelefona;
                ao.Ulica = ulica;
                ao.Broj = broj;
                ao.StrucnaSprema = strucnasprema;

                session.Save(ao);
                session.Flush();
                session.Close();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
                return false;
            }
        }

        public static bool obrisiOsoblje(int idAO)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                AdministrativnoOsoblje a = s.Get<AdministrativnoOsoblje>(idAO);
                if (a != null)
                {
                    s.Delete(a);
                    s.Flush();

                    return true;
                }
                s.Close();
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }


        }

        #endregion

        #region Vozac

        public static List<VozacPregled> GetVozacAll()
        {
            List<VozacPregled> vozacilist = new List<VozacPregled>();
            try
            {
                ISession session = DataLayer.GetSession();
                IEnumerable<Vozac> vozac = from v in session.Query<Vozac>()
                                           select v;

                foreach (Vozac v in vozac)
                {
                    var driver = new VozacPregled(v);
                    driver.LicnaVozila = v.LicnaVozila.Select(lv => new LicnoVoziloPregled(lv)).ToList();
                    driver.VozeneVoznje = v.VozeneVoznje.Select(vv => new VoznjaPregled(vv)).ToList();
                    driver.VozioSluzbeno = v.VozacVozioSluzbeno.Select(vs => new VozioSluzbenoPregled(new SluzbenoVoziloPregled(vs.IdSluzbenogVozila.Id,vs.IdSluzbenogVozila.RegOznaka,vs.IdSluzbenogVozila.Marka,vs.IdSluzbenogVozila.Tip,vs.IdSluzbenogVozila.DatumIstekaRegistracije,vs.IdSluzbenogVozila.GodinaProizvodnje),vs.DatumOd,vs.DatumDo)).ToList();
                    vozacilist.Add(driver);
                }
                session.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
            return vozacilist;

        }
        public static VozacPregled GetVozac(int idVozaca)
        {
            VozacPregled driver = null;
            try
            {
                ISession s = DataLayer.GetSession();
                Vozac v = s.Get<Vozac>(idVozaca);
                if (v != null)
                {
                    driver= new VozacPregled(v);
                    driver.LicnaVozila = v.LicnaVozila.Select(lv => new LicnoVoziloPregled(lv)).ToList();
                    driver.VozeneVoznje = v.VozeneVoznje.Select(vv => new VoznjaPregled(vv)).ToList();
                    driver.VozioSluzbeno = v.VozacVozioSluzbeno.Select(vs => new VozioSluzbenoPregled(new SluzbenoVoziloPregled(vs.IdSluzbenogVozila.Id, vs.IdSluzbenogVozila.RegOznaka, vs.IdSluzbenogVozila.Marka, vs.IdSluzbenogVozila.Tip, vs.IdSluzbenogVozila.DatumIstekaRegistracije, vs.IdSluzbenogVozila.GodinaProizvodnje), vs.DatumOd, vs.DatumDo)).ToList();
                }
                    
                s.Close();
                return driver;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }

            return driver;
        }

        public static List<VozacPregled> GetVozacaSluzbenog(int id)
        {
            List<VozacPregled> vozaci = new List<VozacPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<VozioSluzbeno> taksisti = from sv in s.Query<VozioSluzbeno>()
                                                      where sv.IdSluzbenogVozila.Id == id
                                                      select sv;

                foreach (VozioSluzbeno sluzbenoVozilo in taksisti)
                {

                    VozacPregled sv = DataProvider.GetVozac(sluzbenoVozilo.IdVozaca.Id);
                    vozaci.Add(sv);
                }
                s.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
            return vozaci;
        }

        public static bool izmeniVozaca(int id, string ime, string prezime, string srednjeSlovo, string ulica, string broj, string telefon, string kategorija, string dozvola)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Vozac v = s.Get<Vozac>(id);
                if (v == null)
                    return false;
                v.Ime = ime;
                v.Prezime = prezime;
                v.SrednjeSlovo = srednjeSlovo;
                v.Ulica = ulica;
                v.Broj = broj;
                v.Kategorija = kategorija;
                v.BrojDozvole = dozvola;
                v.BrojTelefona = telefon;

                s.SaveOrUpdate(v);
                s.Flush();
                s.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
                return false;
            }
        }


        public static bool CreateVozac(string ime, string srednjeslovo, string prezime, string jmbg, string brojtelefona, string ulica, string broj, string brDozvole, string kategorija)
        {

            try
            {
                ISession session = DataLayer.GetSession();
                Vozac v = new Vozac();
                v.Ime = ime;
                v.SrednjeSlovo = srednjeslovo;
                v.Prezime = prezime;
                v.Jmbg = jmbg;
                v.BrojTelefona = brojtelefona;
                v.Ulica = ulica;
                v.Broj = broj;
                v.BrojDozvole = brDozvole;
                v.Kategorija = kategorija;


                session.Save(v);
                session.Flush();
                session.Close();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
                return false;
            }
        }
        public static bool deleteVozac(int idVozaca)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Vozac v = s.Get<Vozac>(idVozaca);
                if (v != null)
                {
                    s.Delete(v);
                    s.Flush();
                    
                    return true;
                }
                s.Close();
                return false;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
                return false;
                
            }
        }

        #endregion

        #region LicnoVozilo

        public static List<LicnoVoziloPregled> GetLicnaVozilaAll()
        {
            List<LicnoVoziloPregled> licnovozilolist = new List<LicnoVoziloPregled>();
            try
            {
                ISession session = DataLayer.GetSession();
                IEnumerable<LicnoVozilo> licnovozilo = from lv in session.Query<LicnoVozilo>()
                                                       select lv;

                foreach (LicnoVozilo licnavozila in licnovozilo)
                {
                    licnovozilolist.Add(new LicnoVoziloPregled(licnavozila));
                }
                session.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
            return licnovozilolist;

        }

        public static LicnoVoziloPregled GetLicnoVozilo(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                LicnoVozilo v = s.Get<LicnoVozilo>(id);

                LicnoVoziloPregled vp = new LicnoVoziloPregled(v);

                s.Close();

                return vp;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static void createLicno(int idVozaca, string regoznaka, string marka, string tip, string boja,
                DateTime od, DateTime? Do)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                LicnoVozilo vozilo = new LicnoVozilo();
                Vozac v = session.Get<Vozac>(idVozaca);

                vozilo.RegOznaka = regoznaka;
                vozilo.Marka = marka;
                vozilo.Tip = tip;
                vozilo.Boja = boja;
                vozilo.KoriscenoOd = od;
                vozilo.KoriscenoDo = Do;
                vozilo.IdVozaca = v;

                session.Save(vozilo);
                session.Flush();
                session.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
        }

        public static void ZavrsiLicno(int idVozila)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                LicnoVozilo v = s.Get<LicnoVozilo>(idVozila);

                v.KoriscenoDo = DateTime.Now;

                s.SaveOrUpdate(v);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void IzmeniLicnoVozilo(int idVozila, string reg, string boja, string marka, string tip)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                LicnoVozilo v = s.Get<LicnoVozilo>(idVozila);

                v.RegOznaka = reg;
                v.Boja = boja;
                v.Marka = marka;
                v.Tip = tip;

                s.SaveOrUpdate(v);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public static void obrisiLicnaVozila(int[] ids)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                foreach (int id in ids)
                {
                    LicnoVozilo v = s.Get<LicnoVozilo>(id);

                    s.Delete(v);
                    s.Flush();
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static List<LicnoVoziloPregled> GetLicnaVozilaVozaca(int idVozaca)
        {
            List<LicnoVoziloPregled> vozila = new List<LicnoVoziloPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<LicnoVozilo> licnaVozila = from lv in s.Query<LicnoVozilo>()
                                                       where lv.IdVozaca.Id == idVozaca
                                                       select lv;

                foreach (LicnoVozilo licnoV in licnaVozila)
                {
                    LicnoVoziloPregled lv = new LicnoVoziloPregled(licnoV);
                    vozila.Add(lv);
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }

            return vozila;
        }

        #endregion

        #region SluzbenoVozilo

        public static List<SluzbenoVoziloPregled> GetSluzbenaVozilaAll()
        {
            List<SluzbenoVoziloPregled> sluzbenovozilolist = new List<SluzbenoVoziloPregled>();
            try
            {
                ISession session = DataLayer.GetSession();
                IEnumerable<SluzbenoVozilo> sluzbenovozilo = from sv in session.Query<SluzbenoVozilo>()
                                                             select sv;

                foreach (SluzbenoVozilo sluzbenavozila in sluzbenovozilo)
                {
                    sluzbenovozilolist.Add(new SluzbenoVoziloPregled(sluzbenavozila.Id, sluzbenavozila.RegOznaka, sluzbenavozila.Marka, sluzbenavozila.Tip, sluzbenavozila.DatumIstekaRegistracije, sluzbenavozila.GodinaProizvodnje));
                }
                session.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
            return sluzbenovozilolist;

        }

        public static SluzbenoVoziloPregled vratiSluzbenoVozilo(int id)
        {
            SluzbenoVoziloPregled sv = null;
            try
            {
                ISession s = DataLayer.GetSession();

                SluzbenoVozilo v = s.Get<SluzbenoVozilo>(id);
                sv = new SluzbenoVoziloPregled(v.Id, v.RegOznaka, v.Marka, v.Tip, v.DatumIstekaRegistracije, v.GodinaProizvodnje);

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }

            return sv;
        }

        public static void createSluzbeno(string regoznaka, string marka, string tip,
                DateTime? datumistekareg, int godproiz)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                SluzbenoVozilo vozilo = new SluzbenoVozilo();

                vozilo.RegOznaka = regoznaka;
                vozilo.Marka = marka;
                vozilo.Tip = tip;
                vozilo.DatumIstekaRegistracije = datumistekareg;
                vozilo.GodinaProizvodnje = godproiz;


                session.Save(vozilo);
                session.Flush();
                session.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
        }
        
        public static void obrisiSluzbenaVozila(int[] ids)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                foreach (int id in ids)
                {
                    SluzbenoVozilo v = s.Get<SluzbenoVozilo>(id);

                    s.Delete(v);
                    s.Flush();
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public static void EditSluzbenoVozilo(int id, string tip, string reg, string marka, int datpro)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                SluzbenoVozilo vozilo = session.Get<SluzbenoVozilo>(id);
                vozilo.Tip = tip;
                vozilo.RegOznaka = reg;
                vozilo.Marka = marka;
                vozilo.GodinaProizvodnje = datpro;
                session.SaveOrUpdate(vozilo);
                session.Flush();
                session.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
        }

        #endregion

        #region VozioSluzbeno

        public static List<VozioSluzbenoPregled> GetSluzbenaVozilaVozaca(int idVozaca)
        {
            List<VozioSluzbenoPregled> vozila = new List<VozioSluzbenoPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<VozioSluzbeno> sluzbenaVozila = from sv in s.Query<VozioSluzbeno>()
                                                            where sv.IdVozaca.Id == idVozaca
                                                            select sv;

                foreach (VozioSluzbeno sluzbenoVozilo in sluzbenaVozila)
                {

                    SluzbenoVoziloPregled sv = DataProvider.vratiSluzbenoVozilo(sluzbenoVozilo.IdSluzbenogVozila.Id);
                    VozioSluzbenoPregled vs = new VozioSluzbenoPregled(sv, sluzbenoVozilo.DatumOd, sluzbenoVozilo.DatumDo);
                    vozila.Add(vs);
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }

            return vozila;
        }

        public static void dodeliVoziloVozacu(int idVozila, int idVozaca, DateTime od, DateTime? doo)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozac vozac = s.Get<Vozac>(idVozaca);
                SluzbenoVozilo vozilo = s.Get<SluzbenoVozilo>(idVozila);

                VozioSluzbeno vs = new VozioSluzbeno();
                vs.DatumDo = doo;
                vs.DatumOd = od;
                vs.IdSluzbenogVozila = vozilo;
                vs.IdVozaca = vozac;

                s.Save(vs);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
        }

        public static void UpdateVozioDo(int idVeze, DateTime? newVozioDo)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                VozioSluzbeno vozioSluzbeno = session.Get<VozioSluzbeno>(idVeze);
                vozioSluzbeno.DatumDo = newVozioDo;
                session.SaveOrUpdate(vozioSluzbeno);
                session.Flush();
                session.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
        }

        public static void DeleteVozioOd(List<int> idVeza)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                foreach (int id in idVeza)
                {
                    IQuery q = s.CreateQuery("select vs from VozioSluzbeno vs where vs.Id = " + id);
                    VozioSluzbeno vozio = q.UniqueResult<VozioSluzbeno>();
                    s.Delete(vozio);
                    s.Flush();
                }

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion

        #region Voznja

        public static List<VoznjaPregled> GetVoznjaAll()
        {
            List<VoznjaPregled> voznjelist = new List<VoznjaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Voznja> voznja = from v in s.Query<Voznja>()
                                             select v;


                foreach (Voznja voznje in voznja)
                {
                    voznjelist.Add(new VoznjaPregled(voznje));
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
            return voznjelist;
        }

        public static List<VoznjaPregled> GetVoznja(int id)
        {
            List<VoznjaPregled> voznjelist = new List<VoznjaPregled>();
            try
            {
                ISession session = DataLayer.GetSession();
                IEnumerable<Voznja> voznje = from v in session.Query<Voznja>()
                                             where v.IdAdministrativnogOsoblja.Id == id
                                             select v;

                foreach (Voznja voznja in voznje)
                {
                    voznjelist.Add(new VoznjaPregled(voznja));
                }
                session.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
            return voznjelist;
        }

        public static List<VoznjaPregled> GetAktivneVoznjeVozaca(int idVozaca)
        {
            List<VoznjaPregled> aktivneVoznje = new List<VoznjaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Voznja> aVoznje = from v in s.Query<Voznja>()
                                              where v.IdVozaca.Id == idVozaca && v.VremeKraja == null
                                              select v;

                foreach (Voznja voznja in aVoznje)
                {
                    VoznjaPregled vp = new VoznjaPregled(voznja);
                    aktivneVoznje.Add(vp);
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }

            return aktivneVoznje;
        }
        public static List<VoznjaPregled> GetZavrseneVoznjeVozaca(int idVozaca)
        {
            List<VoznjaPregled> zavrseneVoznje = new List<VoznjaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Voznja> zVoznje = from v in s.Query<Voznja>()
                                              where v.IdVozaca.Id == idVozaca && v.VremeKraja != null
                                              select v;

                foreach (Voznja voznja in zVoznje)
                {
                    VoznjaPregled vp = new VoznjaPregled(voznja);
                    zavrseneVoznje.Add(vp);

                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }

            return zavrseneVoznje;
        }

        public static List<VoznjaMusterijaPregled> GetVoznjeMusterije(int idMusterije)
        {
            try
            {
                List<VoznjaMusterijaPregled> voznjeInfo = new List<VoznjaMusterijaPregled>();

                ISession s = DataLayer.GetSession();

                IEnumerable<Voznja> voznje = from v in s.Query<Voznja>()
                                             where v.IdMusterije.Id == idMusterije
                                             select v;

                foreach (Voznja voznja in voznje)
                {
                    voznjeInfo.Add(new VoznjaMusterijaPregled(voznja.Id, voznja.PocetnaStanica,
                        voznja.KrajnjaStanica, voznja.CenaVoznje, voznja.BrojTelefonaPoziva));
                }

                return voznjeInfo;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static VoznjaPregled GetJednaVoznja(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("select v from Voznja v where v.Id=" + id.ToString());
                Voznja v = q.UniqueResult<Voznja>();

                VoznjaPregled vp = new VoznjaPregled(v);

                s.Close();

                return vp;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
                return null;
            }
        }
        public static void DodajVoznju(string pocetna, string krajnja, DateTime vremePoziva,
                DateTime vremePocetka, int idVozaca, int idMusterije, int idAo, string telefon)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Voznja v = new Voznja();
                v.PocetnaStanica = pocetna;
                v.KrajnjaStanica = krajnja;
                v.VremePoziva = vremePoziva;
                v.VremePocetka = vremePocetka;
                v.IdVozaca = s.Get<Vozac>(idVozaca);
                v.VremeKraja = null;
                v.CenaVoznje = null;
                Musterija m = s.Get<Musterija>(idMusterije);
                m.BrojVoznji++;
                v.IdMusterije = m;
                v.IdAdministrativnogOsoblja = s.Get<AdministrativnoOsoblje>(idAo);
                v.BrojTelefonaPoziva = telefon;

                s.Save(m);
                s.Save(v);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
        }

        public static void IzmeniVoznju(int idVoznje, string pocetna, string krajnja, int? cena)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Voznja v = s.Get<Voznja>(idVoznje);

                v.PocetnaStanica = pocetna;
                v.KrajnjaStanica = krajnja;
                v.CenaVoznje = cena;

                s.SaveOrUpdate(v);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void obrisiVoznje(int[] ids)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                foreach (int id in ids)
                {
                    Voznja v = s.Get<Entiteti.Voznja>(id);
                    s.Delete(v);
                    s.Flush();
                }

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public static void ZavrsiVoznju(int id, int cena)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Voznja v = s.Get<Voznja>(id);

                v.CenaVoznje = cena;
                v.VremeKraja = DateTime.Now;

                s.SaveOrUpdate(v);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        #endregion

        #region Musterija

        public static List<MusterijaPregled> GetMusterijaAll()
        {
            List<MusterijaPregled> musterijalist = new List<MusterijaPregled>();
            try
            {
                ISession session = DataLayer.GetSession();
                IEnumerable<Musterija> musterija = from m in session.Query<Musterija>()
                                                   select m;

                foreach (Musterija musterije in musterija)
                {
                    musterijalist.Add(new MusterijaPregled(musterije));
                }
                session.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }


            return musterijalist;
        }

        public static MusterijaPregled GetMusterija(int idMusterije)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Musterija m = s.Get<Musterija>(idMusterije);

                MusterijaPregled mp = new MusterijaPregled(m);

                s.Close();

                return mp;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
      
        public static void DodajMusteriju(MusterijaPregled must)
        {
            Entiteti.Musterija m = new Entiteti.Musterija();
            m.Ime = must.Ime;
            m.Prezime = must.Prezime;
            m.Adresa = must.Adresa;
            m.BrojVoznji = 1;
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(m);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void DodajMusteriju(string ime, string prez, string adresa, string[] telefoni)
        {
            Entiteti.Musterija m = new Entiteti.Musterija();
            m.Ime = ime;
            m.Prezime = prez;
            m.Adresa = adresa;
            m.BrojVoznji = 1;

            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(m);
                s.Flush();

                foreach (string tel in telefoni)
                {
                    Entiteti.MusterijaMobile mob = new Entiteti.MusterijaMobile();
                    mob.BrojTelefona = tel;
                    mob.IdMusterije = m;
                    s.Save(mob);
                }

                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
       /* public static void DodajMusteriju(string ime, string prez, string adresa, List<MusterijaMobile> mobilniTelefoni)
        {
            Entiteti.Musterija m = new Entiteti.Musterija();
            m.Ime = ime;
            m.Prezime = prez;
            m.Adresa = adresa;
            m.MobilniTelefoni = mobilniTelefoni;
        }*/
        public static void IzmeniMusteriju(int id, string ime, string prezime, string adresa)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Musterija m = s.Get<Musterija>(id);

                m.Ime = ime;
                m.Prezime = prezime;
                m.Adresa = adresa;

                s.SaveOrUpdate(m);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
        }

        public static void obrisiMusterije(int[] ids)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                foreach (int id in ids)
                {
                    Musterija m = s.Load<Entiteti.Musterija>(id);
                    s.Delete(m);
                    s.Flush();
                }

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void obrisiMusteriju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Musterija m = s.Load<Entiteti.Musterija>(id);
                s.Delete(m);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion

        #region Popust

        public static List<PopustPregled> GetPopustAll()
        {
            List<PopustPregled> popusti = new List<PopustPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Popust> popust = from p in s.Query<Popust>()
                                             select p;

                foreach (Popust p in popust)
                {
                    popusti.Add(new PopustPregled(p));
                }
                s.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);

            }
            return popusti;
        }

        public static List<PopustPregled> GetPopustMusterije(int idMusterije)
        {
            try
            {
                List<PopustPregled> popustInfo = new List<PopustPregled>();

                ISession s = DataLayer.GetSession();

                IEnumerable<Popust> popusti = from p in s.Query<Popust>()
                                              where p.IdMusterije.Id == idMusterije
                                              select p;

                foreach (Popust popust in popusti)
                {
                    popustInfo.Add(new PopustPregled(popust));
                }

                return popustInfo;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static void addPopust(int idMusterija, int vrPopusta, DateTime vazenjeOd, DateTime? vazenjeDo)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("select m from Musterija m where m.Id = " + idMusterija);
                Musterija m = q.UniqueResult<Musterija>();
                    Popust p = new Popust();
                    p.IdMusterije = m;
                    p.VrednostPopusta = vrPopusta;
                    p.DatumPocetka = vazenjeOd;
                    p.DatumKraja = vazenjeDo;
                    s.Save(p);
                    s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
        }
        public static void CreatePopust(List<int> idMusterija, int vrPopusta, DateTime vazenjeOd, DateTime? vazenjeDo)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                foreach (int id in idMusterija)
                {
                    IQuery q = s.CreateQuery("select m from Musterija m where m.Id = " + id);
                    Musterija m = q.UniqueResult<Musterija>();

                    Popust p = new Popust();
                    p.IdMusterije = m;
                    p.VrednostPopusta = vrPopusta;
                    p.DatumPocetka = vazenjeOd;
                    p.DatumKraja = vazenjeDo;
                    s.Save(p);
                    s.Flush();
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
        }
        public static void DeletePopusti(List<int> idPopusta)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                foreach (int id in idPopusta)
                {
                    IQuery q = s.CreateQuery("select p from Popust p where p.Id = " + id);
                    Popust popust = q.UniqueResult<Popust>();
                    s.Delete(popust);
                    s.Flush();
                }

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static PopustPregled GetPopust(int idPopusta)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("select p from Popust p where p.Id = " + idPopusta);

                Popust p = q.UniqueResult<Popust>();

                PopustPregled pp = new PopustPregled(p);

                s.Close();

                return pp;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static void ProduziPopust(int idPopusta, DateTime? novoVazenje)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("select p from Popust p where p.Id = " + idPopusta);

                Popust p = q.UniqueResult<Popust>();
                p.DatumKraja = novoVazenje;
                s.SaveOrUpdate(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void obrisiPopust(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Popust p = s.Get<Popust>(id);

                s.Delete(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion

        #region MusterijaTelefoni

        public static List<TelefoniPregled> GetTelefoniAll()
        {
            List<TelefoniPregled> telefoni = new List<TelefoniPregled>();
            try
            {
                ISession session = DataLayer.GetSession();
                IEnumerable<MusterijaMobile> mobTelefoni = from m in session.Query<MusterijaMobile>()
                                                           select m;

                foreach (MusterijaMobile mob in mobTelefoni)
                {
                    telefoni.Add(new TelefoniPregled(mob));
                }
                session.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
            return telefoni;
        }

        public static List<string> GetTelefoni(int idMusterije)
        {
            try
            {
                List<string> ret = new List<string>();

                ISession s = DataLayer.GetSession();

                IEnumerable<MusterijaMobile> telefoni = from m in s.Query<MusterijaMobile>()
                                                        where m.IdMusterije.Id == idMusterije
                                                        select m;

                foreach (MusterijaMobile tel in telefoni)
                {
                    ret.Add(tel.BrojTelefona);
                }

                return ret;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static List<TelefoniPregled> GetTelefoniMusterije(int idMusterije)
        {
            List<TelefoniPregled> telefoni = new List<TelefoniPregled>();
            try
            {
                ISession session = DataLayer.GetSession();
                IEnumerable<MusterijaMobile> mobTelefoni = from m in session.Query<MusterijaMobile>()
                                                           where m.IdMusterije.Id == idMusterije
                                                           select m;

                foreach (MusterijaMobile mob in mobTelefoni)
                {
                    telefoni.Add(new TelefoniPregled(mob));
                }
                session.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }


            return telefoni;
        }
        public static void dodajTelefon(TelefoniPregled musterijaTelefon)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                Entiteti.MusterijaMobile mt = new Entiteti.MusterijaMobile
                {
                    BrojTelefona = musterijaTelefon.BrojTelefona,
                    IdMusterije = session.Load<Musterija>(musterijaTelefon.IdMusterije.IdMusterije)
                };

                session.Save(mt);
                session.Flush();
                session.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void DodajTelefon(int idMusterije, string broj)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Musterija m = s.Get<Musterija>(idMusterije);
                MusterijaMobile mob = new MusterijaMobile();
                mob.BrojTelefona = broj;
                mob.IdMusterije = m;

                s.Save(mob);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
        }


        public static void ObrisiTelefone(string[] brojevi)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                foreach (string broj in brojevi)
                {
                    IQuery q = s.CreateQuery("select m from MusterijaMobile m where m.BrojTelefona = '" + broj + "'");
                    MusterijaMobile mob = q.UniqueResult<MusterijaMobile>();
                    s.Delete(mob);
                    s.Flush();
                }

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
        }
        public static void ObrisiTelefon(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                    IQuery q = s.CreateQuery("select m from MusterijaMobile m where m.Id = '" + id + "'");
                    MusterijaMobile mob = q.UniqueResult<MusterijaMobile>();
                    s.Delete(mob);
                    s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
        }

        #endregion

    }
}
