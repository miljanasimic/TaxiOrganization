using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaksiUdruzenjeLibrary.Entiteti;
namespace TaksiUdruzenjeLibrary.Mapiranja
{
    public class MusterijaMobileMaper:ClassMap<MusterijaMobile>
    {

        public MusterijaMobileMaper()
        {
            //Mapiranje tabele
            Table("BROJ_TELEFONA_MUSTERIJE");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID_TELEFONA").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.BrojTelefona, "BROJ_TELEFONA");

            References(x => x.IdMusterije)
               .Column("ID_MUSTERIJE")
               .Not.Nullable()
               .LazyLoad();

        }
    }
}
