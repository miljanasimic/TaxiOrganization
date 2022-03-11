using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaksiUdruzenje.Entiteti;
namespace TaksiUdruzenje.Mapiranja
{
    public class SluzbenoVoziloMaper:ClassMap<SluzbenoVozilo>
    {

        public SluzbenoVoziloMaper()
        {
            //Mapiranje tabele
            Table("SLUZBENO_VOZILO");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.RegOznaka, "REG_OZNAKA");
            Map(x => x.Marka, "MARKA");
            Map(x => x.Tip, "TIP");
            Map(x => x.DatumIstekaRegistracije, "DATUM_ISTEKA_REG");
            Map(x => x.GodinaProizvodnje, "GODINA_PROIZVODNJE");


            HasMany(x => x.VozilaVozioSluzbeno).KeyColumn("ID_SLUZBENOG_VOZILA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
