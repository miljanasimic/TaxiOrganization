using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiUdruzenjeLibrary.Entiteti
{
    public class Voznja
    {
        public virtual int Id { get; protected set; }
        public virtual string PocetnaStanica { get; set; }
        public virtual string KrajnjaStanica { get; set; }
        public virtual DateTime VremePoziva { get; set; }
        public virtual Vozac IdVozaca { get; set; }
        
        public virtual DateTime VremePocetka { get; set; }

        public virtual DateTime? VremeKraja { get; set; }

        public virtual int? CenaVoznje { get; set; }

        public virtual AdministrativnoOsoblje IdAdministrativnogOsoblja { get; set; }
        public virtual Musterija IdMusterije { get; set; }
        public virtual string BrojTelefonaPoziva { get; set; }
       
     
    }
}
