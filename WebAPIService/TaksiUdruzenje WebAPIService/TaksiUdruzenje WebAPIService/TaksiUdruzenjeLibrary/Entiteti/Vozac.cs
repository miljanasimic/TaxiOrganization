using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiUdruzenjeLibrary.Entiteti
{
    public class Vozac
    {
        public virtual int Id { get; protected set; }
        public virtual string Jmbg { get; set; }
        public virtual string Ime { get; set; }
        public virtual string SrednjeSlovo { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string BrojTelefona { get; set; }
        public virtual string Ulica { get; set; }
        public virtual string Broj { get; set; }

        public virtual string BrojDozvole { get; set; }

        public virtual string Kategorija { get; set; }

        public virtual IList<Voznja> VozeneVoznje { get; set; }

        public virtual IList<LicnoVozilo> LicnaVozila { get; set; }

        public virtual IList<VozioSluzbeno> VozacVozioSluzbeno { get; set; }

        public Vozac()
        {
            VozeneVoznje = new List<Voznja>();
            LicnaVozila = new List<LicnoVozilo>();
            VozacVozioSluzbeno = new List<VozioSluzbeno>();
        }
    }
}
