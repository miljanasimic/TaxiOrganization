using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiUdruzenje.Entiteti
{
    public class Popust
    {
        public virtual int Id { get; protected set; }
        public virtual Musterija IdMusterije { get; set; }
        public virtual int VrednostPopusta { get; set; }
        public virtual DateTime DatumPocetka { get; set; }
        public virtual DateTime? DatumKraja { get; set; }
    }
}
