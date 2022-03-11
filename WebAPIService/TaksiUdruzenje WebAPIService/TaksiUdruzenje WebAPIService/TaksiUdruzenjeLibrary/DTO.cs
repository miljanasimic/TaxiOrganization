using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaksiUdruzenjeLibrary.Entiteti;

namespace TaksiUdruzenjeLibrary
{
    public class DTO
    {
        #region AdministrativnoOsoblje
        public class AdministrativnoOsobljePregled
        {

            public int idAO { get; set; }
            public string Jmbg { get; set; }
            public string Ime { get; set; }
            public string SrednjeSlovo { get; set; }
            public string Prezime { get; set; }
            public string BrojTelefona { get; set; }

            public string Ulica { get; set; }

            public string Broj { get; set; }
            public string StrucnaSprema { get; set; }

            public virtual IList<VoznjaPregled> DodeljeneVoznje { get; set; }

            public AdministrativnoOsobljePregled()
            {
                DodeljeneVoznje = new List<VoznjaPregled>();
            }

            public AdministrativnoOsobljePregled(AdministrativnoOsoblje ao)
            {
                idAO = ao.Id;
                Jmbg = ao.Jmbg;
                Ime = ao.Ime;
                SrednjeSlovo = ao.SrednjeSlovo;
                Prezime = ao.Prezime;
                BrojTelefona = ao.BrojTelefona;
                Ulica = ao.Ulica;
                Broj = ao.Broj;
                StrucnaSprema = ao.StrucnaSprema;
            }
        }
        #endregion

        #region Vozac
        public class VozacPregled
        {
            public virtual int IdVozac { get; set; }
            public virtual string Jmbg { get; set; }
            public virtual string Ime { get; set; }
            public virtual string SrednjeSlovo { get; set; }
            public virtual string Prezime { get; set; }
            public virtual string BrojTelefona { get; set; }
            public virtual string Ulica { get; set; }
            public virtual string Broj { get; set; }

            public virtual string BrojDozvole { get; set; }

            public virtual string Kategorija { get; set; }

            public virtual IList<VoznjaPregled> VozeneVoznje { get; set; }
            public virtual IList<LicnoVoziloPregled> LicnaVozila { get; set; }
            public virtual IList<VozioSluzbenoPregled> VozioSluzbeno { get; set; }
           
            public VozacPregled() 
            {
                VozeneVoznje = new List<VoznjaPregled>();
                LicnaVozila = new List<LicnoVoziloPregled>();
                VozioSluzbeno = new List<VozioSluzbenoPregled>();
            }

            public VozacPregled(Vozac v)
            {
                IdVozac = v.Id;
                Jmbg = v.Jmbg;
                Ime = v.Ime;
                SrednjeSlovo = v.SrednjeSlovo;
                Prezime = v.Prezime;
                BrojTelefona = v.BrojTelefona;
                Ulica = v.Ulica;
                Broj = v.Broj;
                BrojDozvole = v.BrojDozvole;
                Kategorija = v.Kategorija;
            }
        }
        #endregion

        #region LicnoVozilo
        public class LicnoVoziloPregled
        {
            public virtual int Id { get;set; }
            public virtual string RegOznaka { get; set; }
            public virtual string Marka { get; set; }
            public virtual string Tip { get; set; }
            public virtual string Boja { get; set; }
            public virtual VozacPregled IdVozaca { get; set; }
            public virtual DateTime KoriscenoOd { get; set; }
            public virtual DateTime? KoriscenoDo { get; set; }

            public LicnoVoziloPregled(LicnoVozilo v)
            {
                Id = v.Id;
                RegOznaka = v.RegOznaka;
                Marka = v.Marka;
                Tip = v.Tip;
                Boja = v.Boja;
                IdVozaca = new VozacPregled(v.IdVozaca);
                KoriscenoOd = v.KoriscenoOd;
                KoriscenoDo = v.KoriscenoDo;
            }
        }
        #endregion

        #region SluzbenoVozilo
        public class SluzbenoVoziloPregled
        {
            public virtual int Id { get;set; }
            public virtual string RegOznaka { get; set; }
            public virtual string Marka { get; set; }
            public virtual string Tip { get; set; }
            public virtual DateTime? DatumIstekaRegistracije { get; set; }
            public virtual int GodinaProizvodnje { get; set; }
            public SluzbenoVoziloPregled(int id, string regoznaka, string marka, string tip, DateTime? datumisteka, int godprod)
            {
                Id = id;
                RegOznaka = regoznaka;
                Marka = marka;
                Tip = tip;
                DatumIstekaRegistracije = datumisteka;
                GodinaProizvodnje = godprod;
            }

        }
        #endregion

        #region VozioSluzbeno
        public class VozioSluzbenoPregled
        {
            public virtual DateTime VozioOd { get; set; }
            public virtual DateTime? VozioDo { get; set; }
            public virtual SluzbenoVoziloPregled Vozilo { get; set; }

            public VozioSluzbenoPregled(SluzbenoVoziloPregled v,DateTime od,DateTime? vozioDo)
            {
                Vozilo= v;
                VozioOd = od;
                VozioDo=vozioDo;
            }

        }

        public class SluzbenoVozioPregled
        {
            public virtual DateTime VozioOd { get; set; }
            public virtual DateTime VozioDo { get; set; }
            public virtual Vozac Vozac { get; set; }
            public SluzbenoVozioPregled(Vozac v, DateTime od, DateTime Do)
            {
                Vozac = v;
                VozioOd = od;
                VozioDo = Do;
            }
        }
        #endregion

        #region Voznja
        public class VoznjaPregled
        {
            public virtual int Id { get;set; }
            public virtual string PocetnaStanica { get; set; }
            public virtual string KrajnjaStanica { get; set; }
            public virtual DateTime VremePoziva { get; set; }
            public virtual VozacPregled IdVozaca { get; set; }

            public virtual DateTime VremePocetka { get; set; }

            public virtual DateTime? VremeKraja { get; set; }

            public virtual int? CenaVoznje { get; set; }

            public virtual AdministrativnoOsobljePregled IdAdministrativnogOsoblja { get; set; }
            public virtual MusterijaPregled IdMusterije { get; set; }
            public virtual string BrojTelefonaPoziva { get; set; }

            public VoznjaPregled(Voznja v)
            {
                Id = v.Id;
                PocetnaStanica = v.PocetnaStanica;
                KrajnjaStanica = v.KrajnjaStanica;
                VremePoziva = v.VremePoziva;
                IdVozaca = new DTO.VozacPregled(v.IdVozaca);
                VremePocetka = v.VremePocetka;
                VremeKraja = v.VremeKraja;
                CenaVoznje = v.CenaVoznje;
                IdAdministrativnogOsoblja = new AdministrativnoOsobljePregled(v.IdAdministrativnogOsoblja);
                IdMusterije = new MusterijaPregled(v.IdMusterije);
                BrojTelefonaPoziva = v.BrojTelefonaPoziva;
            }
        }



        public class VoznjaMusterijaPregled
        {
            public virtual int Id { get; protected set; }
            public virtual string PocetnaStanica { get; set; }
            public virtual string KrajnjaStanica { get; set; }
            public virtual int? Cena { get; set; }
            public virtual string BrojTelefonaPoziva { get; set; }

            public VoznjaMusterijaPregled(int id, string pocetna, string krajnja, int? cena, string broj)
            {
                this.Id = id;
                this.PocetnaStanica = pocetna;
                this.KrajnjaStanica = krajnja;
                if (cena == null)
                    this.Cena = 0;
                else
                    this.Cena = cena;
                this.BrojTelefonaPoziva = broj;
            }
        }

        #endregion Voznja

        #region Musterija
        public class MusterijaPregled
        {
            public int IdMusterije { get; set; }
            public string Ime { get; set; }
            public string Prezime { get; set; }

            public string Adresa { get; set; }

            public int BrojVoznji { get; set; }
            public MusterijaPregled()
            {

            }
            public MusterijaPregled(Musterija m)
            {
                IdMusterije = m.Id;
                Ime = m.Ime;
                Prezime = m.Prezime;
                Adresa = m.Adresa;
                BrojVoznji = m.BrojVoznji;
              
            }

        }
        #endregion

        #region Popusti

        public class PopustPregled
        {
            public virtual int Id { get;set; }
            public virtual int Vrednost { get; set; }

            public virtual MusterijaPregled IdMusterije { get; set; }
            public virtual DateTime DatumPocetka { get; set; }
            public virtual DateTime? DatumKraja { get; set; }

            public PopustPregled(Popust p)
            {
                this.Id = p.Id;
                this.Vrednost = p.VrednostPopusta;
                this.DatumPocetka = p.DatumPocetka;
                this.DatumKraja = p.DatumKraja;
                this.IdMusterije = new MusterijaPregled(p.IdMusterije);
            }
        }

        #endregion

        #region MusterijaTelefoni

        public class TelefoniPregled
        {
            public virtual int Id { get;set; }
            public virtual string BrojTelefona { get; set; }
            public virtual MusterijaPregled IdMusterije { get; set; }

            TelefoniPregled()
            {

            }
            public TelefoniPregled(MusterijaMobile mob)
            {
                Id = mob.Id;
                BrojTelefona = mob.BrojTelefona;
                IdMusterije = new MusterijaPregled(mob.IdMusterije);
            }
        }

        #endregion
    }
}
