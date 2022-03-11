using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiUdruzenjeLibrary.Entiteti
{
    public class MusterijaMobile
    {
        public virtual int Id { get; protected set; }
        public virtual Musterija IdMusterije { get; set; }

        public virtual string BrojTelefona { get; set; }



    }
}
