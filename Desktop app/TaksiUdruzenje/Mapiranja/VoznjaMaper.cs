using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaksiUdruzenje.Entiteti;
namespace TaksiUdruzenje.Mapiranja
{
    public class VoznjaMaper:ClassMap<Voznja>
    {

        public VoznjaMaper()
        {
            //Mapiranje tabele
            Table("VOZNJA");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.PocetnaStanica, "POCETNA_STANICA");
            Map(x => x.KrajnjaStanica, "KRAJNJA_STANICA");
            Map(x => x.VremePoziva, "VREME_POZIVA");
            Map(x => x.VremePocetka, "VREME_POCETKA_VOZNJE");
            Map(x => x.VremeKraja, "VREME_KRAJA_VOZNJE");
            Map(x => x.CenaVoznje, "CENA_VOZNJE");
            Map(x => x.BrojTelefonaPoziva, "BROJ_TELEFONA_POZIVA");

            References(x => x.IdMusterije).Column("ID_MUSTERIJE").LazyLoad();
            References(x => x.IdVozaca).Column("ID_VOZACA").LazyLoad();
            References(x => x.IdAdministrativnogOsoblja).Column("ID_AD_OSOBLJA").LazyLoad();


        }
    }
}
