using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiUdruzenje.Entiteti
{
    public class Musterija
    {
        public virtual int Id { get; protected set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Adresa { get; set; }
        public virtual int BrojVoznji { get; set; }
        
        public virtual IList<MusterijaMobile> MobilniTelefoni { get; set; }
        
        public virtual IList<Voznja> Voznje { get; set; }

        public virtual IList<Popust> Popusti { get; set; }

        public Musterija()
        {
            MobilniTelefoni = new List<MusterijaMobile>();
            Voznje = new List<Voznja>();
            Popusti = new List<Popust>();
        }
    }
}
