using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiUdruzenje.Entiteti
{
    public class LicnoVozilo
    {
        public virtual int Id { get; protected set; }
        public virtual string RegOznaka { get; set; }
        public virtual string Marka { get; set; }
        public virtual string Tip { get; set; }
        public virtual string Boja { get; set; }
        public virtual Vozac IdVozaca { get; set; }
        public virtual DateTime KoriscenoOd { get; set; }
        public virtual DateTime? KoriscenoDo { get; set; }

    }
}
