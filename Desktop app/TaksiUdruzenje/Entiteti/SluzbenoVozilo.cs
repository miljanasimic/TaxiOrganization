using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiUdruzenje.Entiteti
{
    public class SluzbenoVozilo
    {
        public virtual int Id { get; protected set; }
        public virtual string RegOznaka { get; set; }
        public virtual string Marka { get; set; }
        public virtual string Tip { get; set; }
        public virtual DateTime? DatumIstekaRegistracije { get; set; }
        public virtual int GodinaProizvodnje { get; set; }
        public virtual IList<VozioSluzbeno> VozilaVozioSluzbeno { get; set; }

        public SluzbenoVozilo()
        {
            VozilaVozioSluzbeno = new List<VozioSluzbeno>();
        }


    }
}
