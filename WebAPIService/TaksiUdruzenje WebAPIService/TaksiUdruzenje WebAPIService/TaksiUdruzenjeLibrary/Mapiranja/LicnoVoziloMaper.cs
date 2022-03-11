using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaksiUdruzenjeLibrary.Entiteti;
namespace TaksiUdruzenjeLibrary.Mapiranja
{
    public class LicnoVoziloMaper : ClassMap<LicnoVozilo>
    {

        public LicnoVoziloMaper()
        {
            //Mapiranje tabele
            Table("LICNO_VOZILO");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.RegOznaka, "REG_OZNAKA");
            Map(x => x.Marka, "MARKA");
            Map(x => x.Tip, "TIP");
            Map(x => x.Boja, "BOJA");
            Map(x => x.KoriscenoOd, "KORISCENO_OD");
            Map(x => x.KoriscenoDo, "KORISCENO_DO");

            //mapiranje veze  N : 1 (VOZAC -> LICNO VOZILO)
            References(x => x.IdVozaca)
               .Column("ID_VOZACA")
               .Not.Nullable()
               .LazyLoad();





        }
    }
}
