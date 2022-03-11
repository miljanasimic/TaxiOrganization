using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaksiUdruzenjeLibrary.Entiteti;
namespace TaksiUdruzenjeLibrary.Mapiranja
{
    public class VozioSluzbenoMaper:ClassMap<VozioSluzbeno>
    {
        public VozioSluzbenoMaper()
        {
            //Mapiranje tabele
            Table("VOZIO_SLUZBENO");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID_VEZE").GeneratedBy.TriggerIdentity();

            References(x => x.IdSluzbenogVozila).Column("ID_SLUZBENOG_VOZILA").LazyLoad();
            References(x => x.IdVozaca).Column("ID_VOZACA").LazyLoad();

            //mapiranje svojstava
            Map(x => x.DatumOd, "VOZIO_OD");
            Map(x => x.DatumDo, "VOZIO_DO");

        }


    }
}
