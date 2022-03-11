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

                    driver.VozioSluzbeno = v.VozacVozioSluzbeno.Select(vs => new VozioSluzbenoPregled(vs)).ToList();
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
                    driver.VozioSluzbeno = v.VozacVozioSluzbeno.Select(vs => new VozioSluzbenoPregled(vs)).ToList();
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
                LicnoVoziloPregled vp = null;

                if (v != null)
                {
                    vp = new LicnoVoziloPregled(v);

                }

                s.Close();

                return vp;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static bool createLicno(int idVozaca, string regoznaka, string marka, string tip, string boja,
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
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
                return false;
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
       
        public static bool IzmeniLicnoVozilo(int idVozila, string reg, string marka, string tip, string boja, DateTime koriscenoOd, DateTime? koriscenoDo,VozacPregled vozacc)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                LicnoVozilo v = s.Get<LicnoVozilo>(idVozila);

                v.RegOznaka = reg;
                v.Boja = boja;
                v.Marka = marka;
                v.Tip = tip;
                v.KoriscenoOd = koriscenoOd;
                v.KoriscenoDo = koriscenoDo;

                Vozac vp = s.Get<Vozac>(vozacc.IdVozac);
                if (vp == null)
                    return false;
                v.IdVozaca = vp;

                s.SaveOrUpdate(v);
                s.Flush();
                s.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }



        public static bool obrisiLicnaVozila(int idLicnogVozila)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                LicnoVozilo lv = s.Get<LicnoVozilo>(idLicnogVozila);
                if (lv != null)
                {
                    s.Delete(lv);
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
            List<SluzbenoVoziloPregled> sluzbenovoziloList = new List<SluzbenoVoziloPregled>();
            try
            {
                ISession session = DataLayer.GetSession();
                IEnumerable<SluzbenoVozilo> sluzbenaVozila = from sv in session.Query<SluzbenoVozilo>()
                                                             select sv;

                foreach (SluzbenoVozilo sluzbenoVozilo in sluzbenaVozila)
                {
                    var vozaci = sluzbenoVozilo.VozilaVozioSluzbeno;
                    var vozilo = new SluzbenoVoziloPregled(sluzbenoVozilo);
                    vozilo.VozaciVozila = vozaci.Select(v => new VozioSluzbenoPregled(v)).ToList();
                    sluzbenovoziloList.Add(vozilo);
                }
                session.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
            return sluzbenovoziloList;

        }

        public static SluzbenoVoziloPregled vratiSluzbenoVozilo(int id)
        {
            SluzbenoVoziloPregled sv = null;
            try
            {
                ISession s = DataLayer.GetSession();

                SluzbenoVozilo v = s.Get<SluzbenoVozilo>(id);
                if (v==null)
                    return null;

                sv = new SluzbenoVoziloPregled(v);
                sv.VozaciVozila = v.VozilaVozioSluzbeno.Select(vozio => new VozioSluzbenoPregled(vozio)).ToList();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }

            return sv;
        }

        public static bool createSluzbeno(string regoznaka, string marka, string tip,
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

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
                return false;
            }
        }
        
        public static bool obrisiSluzbenoVozilo(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SluzbenoVozilo v = s.Get<SluzbenoVozilo>(id);
                if (v == null)
                    return false;

                s.Delete(v);
                s.Flush();
                s.Close();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }


        public static bool EditSluzbenoVozilo(SluzbenoVoziloPregled vp)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                SluzbenoVozilo vozilo = session.Get<SluzbenoVozilo>(vp.Id);

                if(vozilo == null)
                    return false;

                vozilo.Tip = vp.Tip;
                vozilo.RegOznaka = vp.RegOznaka;
                vozilo.Marka = vp.Marka;
                vozilo.DatumIstekaRegistracije = vp.DatumIstekaRegistracije;
                vozilo.GodinaProizvodnje = vp.GodinaProizvodnje;

                session.SaveOrUpdate(vozilo);
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

        #endregion

        #region VozioSluzbeno

        public static List<VozioSluzbenoPregled> GetVozioSluzbenoAll()
        {
            List<VozioSluzbenoPregled> vozila = new List<VozioSluzbenoPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<VozioSluzbeno> vozenaSluzbena = from sv in s.Query<VozioSluzbeno>()
                                                            select sv;

                foreach (VozioSluzbeno vozenoSluzbeno in vozenaSluzbena)
                {
                    vozila.Add(new VozioSluzbenoPregled(vozenoSluzbeno));
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }

            return vozila;
        }

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

        public static VozioSluzbenoPregled GetVozioSluzbeno(int idVeze)
        {
            VozioSluzbenoPregled vsp = null;
            try
            {
                ISession s = DataLayer.GetSession();

                VozioSluzbeno vs = s.Get<VozioSluzbeno>(idVeze);
                if (vs == null)
                    return null;


                vsp = new VozioSluzbenoPregled(vs);
                s.Close();
                return vsp;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
                return null;
            }
        }

        public static bool dodeliVoziloVozacu(int idVozila, int idVozaca, DateTime od, DateTime? doo)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozac vozac = s.Get<Vozac>(idVozaca);
                SluzbenoVozilo vozilo = s.Get<SluzbenoVozilo>(idVozila);
                if (vozac == null || vozilo == null)
                    return false;

                VozioSluzbeno vs = new VozioSluzbeno();
                vs.DatumDo = doo;
                vs.DatumOd = od;
                vs.IdSluzbenogVozila = vozilo;
                vs.IdVozaca = vozac;

                s.Save(vs);
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

        public static bool UpdateVozioDo(int idVeze, DateTime? newVozioDo)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                VozioSluzbeno vozioSluzbeno = session.Get<VozioSluzbeno>(idVeze);
                if (vozioSluzbeno == null)
                    return false;

                vozioSluzbeno.DatumDo = newVozioDo;
                session.SaveOrUpdate(vozioSluzbeno);
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

        public static bool IzmeniVozioSluzbeno(DTO.VozioSluzbenoPregled vsp)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                VozioSluzbeno vozioSluzbeno = session.Get<VozioSluzbeno>(vsp.Id);
                if (vozioSluzbeno == null)
                    return false;

                if (vsp.VozioOd > vsp.VozioDo)
                    return false;

                vozioSluzbeno.DatumOd = vsp.VozioOd;
                vozioSluzbeno.DatumDo = vsp.VozioDo;
                Vozac vozac = session.Get<Vozac>(vsp.Vozac.IdVozac);
                SluzbenoVozilo vozilo = session.Get<SluzbenoVozilo>(vsp.Vozilo.Id);
                if (vozac == null || vozilo == null)
                    return false;

                vozioSluzbeno.IdSluzbenogVozila = vozilo;
                vozioSluzbeno.IdVozaca = vozac;

                session.SaveOrUpdate(vozioSluzbeno);
                session.Flush();
                session.Close();

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool DeleteVozioOd(int idVeze)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                VozioSluzbeno vozioSluzbeno = s.Get<VozioSluzbeno>(idVeze);
                if (vozioSluzbeno == null)
                    return false;

                s.Delete(vozioSluzbeno);
                s.Flush();
                s.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
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

        public static List<VoznjaPregled> GetVoznjaAdministrativnog(int id)
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

        public static List<VoznjaPregled> GetVoznjeMusterije(int idMusterije)
        {
            try
            {
                List<VoznjaPregled> voznjeInfo = new List<VoznjaPregled>();

                ISession s = DataLayer.GetSession();

                IEnumerable<Voznja> voznje = from v in s.Query<Voznja>()
                                             where v.IdMusterije.Id == idMusterije
                                             select v;

                if(voznje == null)
                    return null;

                foreach (Voznja voznja in voznje)
                {
                    voznjeInfo.Add(new VoznjaPregled(voznja));
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

                if (v == null)
                    return null;

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
        public static bool DodajVoznju(VoznjaPregled vp)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Voznja v = new Voznja();
                v.PocetnaStanica = vp.PocetnaStanica;
                v.KrajnjaStanica = vp.KrajnjaStanica;
                v.VremePoziva = vp.VremePoziva;
                v.VremePocetka = vp.VremePocetka;
                v.IdVozaca = s.Get<Vozac>(vp.Vozac.IdVozac);
                v.VremeKraja = null;
                v.CenaVoznje = null;
                Musterija m = s.Get<Musterija>(vp.Musterija.IdMusterije);
                m.BrojVoznji++;
                v.IdMusterije = m;
                v.IdAdministrativnogOsoblja = s.Get<AdministrativnoOsoblje>(vp.AdministrativnoOsoblje.idAO);
                v.BrojTelefonaPoziva = vp.BrojTelefonaPoziva;

                s.Save(m);
                s.Save(v);
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

        public static bool IzmeniVoznju(DTO.VoznjaPregled vp)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Voznja v = s.Get<Voznja>(vp.Id);

                if (v == null)
                    return false;
                if (vp.VremePocetka > vp.VremeKraja)
                    return false;

                v.PocetnaStanica = vp.PocetnaStanica;
                v.KrajnjaStanica = vp.KrajnjaStanica;
                v.CenaVoznje = vp.CenaVoznje;
                v.VremePoziva = vp.VremePoziva;
                v.VremePocetka = vp.VremePocetka;
                v.VremeKraja = vp.VremeKraja;
                v.BrojTelefonaPoziva = vp.BrojTelefonaPoziva;
                AdministrativnoOsoblje ao = s.Get<AdministrativnoOsoblje>(vp.AdministrativnoOsoblje.idAO);
                Vozac vozac = s.Get<Vozac>(vp.Vozac.IdVozac);
                Musterija m = s.Get<Musterija>(vp.Musterija.IdMusterije);
                if (ao == null || vozac == null || m == null)
                {
                    return false;
                }
                v.IdAdministrativnogOsoblja = ao;
                v.IdVozaca = vozac;
                v.IdMusterije = m;

                s.SaveOrUpdate(v);
                s.Flush();
                s.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool obrisiVoznju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Voznja v = s.Get<Entiteti.Voznja>(id);
                if (v == null)
                    return false;

                s.Delete(v);
                s.Flush();
                s.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }


        public static bool ZavrsiVoznju(int id, int cena)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Voznja v = s.Get<Voznja>(id);
                if (v == null)
                    return false;

                v.CenaVoznje = cena;
                v.VremeKraja = DateTime.Now;

                s.SaveOrUpdate(v);
                s.Flush();
                s.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
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
                IEnumerable<Musterija> musterije = from m in session.Query<Musterija>()
                                                   select m;

                foreach (Musterija m in musterije)
                {
                    var musterija = new MusterijaPregled(m);
                    musterija.DodeljeniPopusti = m.Popusti.Select(popust => new PopustPregled(popust)).ToList();
                    musterija.ListaVoznji = m.Voznje.Select(voznja => new VoznjaPregled(voznja)).ToList();
                    musterija.ListaTelefona = m.MobilniTelefoni.Select(telefon => new TelefoniPregled(telefon)).ToList();
                    musterijalist.Add(musterija);
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
                MusterijaPregled musterija = null;
                if (m != null)
                {
                    musterija = new MusterijaPregled(m);
                    musterija.DodeljeniPopusti = m.Popusti.Select(popust => new PopustPregled(popust)).ToList();
                    musterija.ListaVoznji = m.Voznje.Select(voznja => new VoznjaPregled(voznja)).ToList();
                    musterija.ListaTelefona = m.MobilniTelefoni.Select(telefon => new TelefoniPregled(telefon)).ToList();
                }
                s.Close();

                return musterija;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }


        

        public static bool DodajMusteriju(MusterijaPregled musterija)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Musterija m = new Musterija();
                m.Ime = musterija.Ime;
                m.Prezime = musterija.Prezime;
                m.Adresa = musterija.Adresa;
                if (musterija.BrojVoznji == 0) //ako se broj voznji ne unese postavlja se na 1, kao da se musterija dodaje pri svojoj prvoj voznji
                    m.BrojVoznji = 1;
                else
                    m.BrojVoznji = musterija.BrojVoznji;

                s.Save(m);
                s.Flush();
                s.Close();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static bool IzmeniMusteriju(int id, string ime, string prezime, string adresa, int brVoznji)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Musterija m = s.Get<Musterija>(id);
                if (m == null)
                    return false;

                m.Ime = ime;
                m.Prezime = prezime;
                m.Adresa = adresa;
                if (brVoznji == 0)//ako se broj voznji ne unese postavlja se na 1
                    m.BrojVoznji = 1;
                else
                    m.BrojVoznji = brVoznji;

                s.SaveOrUpdate(m);
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

        public static bool obrisiMusteriju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Musterija m = s.Get<Musterija>(id);
                if (m == null)
                    return false;
                s.Delete(m);
                s.Flush();
                s.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
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

        public static bool addPopust(int idMusterija, int vrPopusta, DateTime vazenjeOd, DateTime? vazenjeDo)
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
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
                return false;
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
                PopustPregled pp = null;

                if (p != null)
                {
                    pp = new PopustPregled(p);
                }               

                s.Close();

                return pp;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static bool IzmeniPopust(PopustPregled p)
        {
            try
            {
                
                ISession s = DataLayer.GetSession();

                Popust popustt = s.Get<Popust>(p.Id);
                popustt.DatumPocetka = p.DatumPocetka;
                popustt.DatumKraja = p.DatumKraja;
                popustt.VrednostPopusta = p.Vrednost;

                Musterija m = s.Get<Musterija>(p.Musterija.IdMusterije);
                if (m == null)
                    return false;
                popustt.IdMusterije = m;
                
                s.SaveOrUpdate(popustt);
                s.Flush();
                s.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
        public static bool obrisiPopust(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Popust p = s.Get<Popust>(id);

                if (p == null)
                    return false;

                s.Delete(p);
                s.Flush();
                s.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
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

        public static TelefoniPregled GetTelefon(int id)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                MusterijaMobile mob = session.Get<MusterijaMobile>(id);
                TelefoniPregled t = null;
                if (mob != null)
                {
                    t = new TelefoniPregled(mob);
                }
                    
                session.Close();

                return t;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
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

        public static bool DodajTelefon(TelefoniPregled tel)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Musterija m = s.Get<Musterija>(tel.Musterija.IdMusterije);
                if (m == null)
                    return false;

                MusterijaMobile mob = new MusterijaMobile();
                mob.BrojTelefona = tel.BrojTelefona;
                mob.IdMusterije = m;

                s.Save(mob);
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

        public static bool IzmeniTelefon(TelefoniPregled tel)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MusterijaMobile mob = s.Get<MusterijaMobile>(tel.Id);
                Musterija m = s.Get<Musterija>(tel.Musterija.IdMusterije);
                if (m == null || mob == null)
                    return false;

                mob.BrojTelefona = tel.BrojTelefona;
                mob.IdMusterije = m;

                s.SaveOrUpdate(mob);
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


        public static bool ObrisiTelefon(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MusterijaMobile mob = s.Get<MusterijaMobile>(id);
                if (mob == null)
                    return false;

                s.Delete(mob);
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


        public static bool ObrisiTelefonPoBroju(string brTelefona)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("select m from MusterijaMobile m where m.BrojTelefona = '" + brTelefona + "'");
                MusterijaMobile mob = q.UniqueResult<MusterijaMobile>();
                if (mob == null)
                    return false;

                s.Delete(mob);
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

        #endregion

    }
}
