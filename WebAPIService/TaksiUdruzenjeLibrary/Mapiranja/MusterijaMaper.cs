using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaksiUdruzenjeLibrary.Entiteti;
namespace TaksiUdruzenjeLibrary.Mapiranja
{
    public class MusterijaMaper : ClassMap<Musterija>
    {

        public MusterijaMaper()
        {
            //Mapiranje tabele
            Table("MUSTERIJA");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID_MUSTERIJE").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            
            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.BrojVoznji, "BROJ_VOZNJI");

            HasMany(x => x.MobilniTelefoni).KeyColumn("ID_MUSTERIJE").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Voznje).KeyColumn("ID_MUSTERIJE").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Popusti).KeyColumn("ID_MUSTERIJE").LazyLoad().Cascade.All().Inverse();

        }
    }
}
