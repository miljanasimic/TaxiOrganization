using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiUdruzenje.Entiteti
{
    public class AdministrativnoOsoblje
    {
        public virtual int Id { get; protected set; }
        public virtual string Jmbg { get; set; }
        public virtual string Ime { get; set; }
        public virtual string SrednjeSlovo { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string BrojTelefona { get; set; }
        public virtual string Ulica { get; set; }
        public virtual string Broj { get; set; }
        public virtual string StrucnaSprema { get; set; }
        public virtual IList<Voznja> DodeljeneVoznje { get; set; }

        public AdministrativnoOsoblje()
        {
            DodeljeneVoznje = new List<Voznja>();
        }
    }
}
