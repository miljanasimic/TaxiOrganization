using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiUdruzenjeLibrary.Entiteti
{
    public class VozioSluzbeno
    {
        public virtual int Id { get; set; }
        public virtual Vozac IdVozaca { get; set; }
        public virtual SluzbenoVozilo IdSluzbenogVozila { get; set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime? DatumDo { get; set; }

        public VozioSluzbeno()
        {
            
        }
    }
}
