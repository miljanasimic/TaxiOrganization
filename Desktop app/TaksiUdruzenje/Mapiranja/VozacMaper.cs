using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaksiUdruzenje.Entiteti;
namespace TaksiUdruzenje.Mapiranja
{
    public class VozacMaper:ClassMap<Vozac>
    {

        public VozacMaper()
        {
            //Mapiranje tabele
            Table("VOZAC");

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
            Map(x => x.BrojDozvole, "BROJ_DOZVOLE");
            Map(x => x.Kategorija, "KATEGORIJA");

            HasMany(x => x.VozeneVoznje).KeyColumn("ID_VOZACA").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.LicnaVozila).KeyColumn("ID_VOZACA").LazyLoad().Cascade.All().Inverse();
            HasMany(x=>x.VozacVozioSluzbeno).KeyColumn("ID_VOZACA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
