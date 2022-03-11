using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaksiUdruzenje.Entiteti;

namespace TaksiUdruzenje.Mapiranja
{
    public class AdministrativnoOsobljeMaper : ClassMap<AdministrativnoOsoblje>
    {
        public AdministrativnoOsobljeMaper()
        {
            //Mapiranje tabele
            Table("ADMINISTRATIVNO_OSOBLJE");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.Jmbg, "JMBG");
            Map(x => x.Ime, "IME");
            Map(x => x.SrednjeSlovo, "SREDNJE_SLOVO");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.BrojTelefona, "BROJ_TELEFONA");
            Map(x => x.Ulica, "ULICA");
            Map(x => x.Broj, "BROJ");
            Map(x => x.StrucnaSprema, "STRUCNA_SPREMA");

            //mapiranje veze  N : 1 (VOZNJA -> ADMINISTRATIVNO OSOBLJE)
            HasMany(x => x.DodeljeneVoznje).KeyColumn("ID_AD_OSOBLJA").LazyLoad().Cascade.All().Inverse();


        }
    }
}
