using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooKINGLibrary.Classes {
    public class PomocnaNamirnice {
        public string Naziv { get; set; }
        public decimal Kolicina { get; set; }
        public Enumeracije.ENazivMjere Mjera { get; set; }
        public string Display {
            get {
                return string.Format("{0}  {1}  {2}", Naziv, Kolicina, Mjera);
                //return $"{Naziv }{Kolicina }{Mjera}";
            }
        }

        public PomocnaNamirnice(string naz, decimal k, Enumeracije.ENazivMjere m) {
            Naziv = naz; Kolicina = k; Mjera = m;
        }
    }
}
