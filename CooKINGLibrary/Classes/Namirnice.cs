using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooKINGLibrary.Classes {
    public class Namirnice {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public Enumeracije.ENazivMjere Mjera { get; set; }
        public bool Opca { get; set; } //ako je opca ne uzima se u obzir kod pretrage(ima je uvijek)
        public Enumeracije.EVrstaNamirnice Vrsta { get; set;}
    }
}
