using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaksiUdruzenjeLibrary.Entiteti;
namespace TaksiUdruzenjeLibrary.Mapiranja
{
    public class PopustMaper:ClassMap<Popust>
    {

        public PopustMaper()
        {
            //Mapiranje tabele
            Table("POPUST");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID_POPUSTA").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            //Map(x => x.idMusterije, "ID_MUSTERIJE");
            Map(x => x.VrednostPopusta, "VREDNOST_POPUSTA");
            Map(x => x.DatumPocetka, "DATUM_POCETKA");
            Map(x => x.DatumKraja, "DATUM_KRAJA");

            References(x => x.IdMusterije)
               .Column("ID_MUSTERIJE")
               .Not.Nullable()
               .LazyLoad();



        }
    }
}
