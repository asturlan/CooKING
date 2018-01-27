using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooKINGLibrary.Classes {
    public class Koraci {
        public int Id { get; set; }
        public int BrojKoraka { get; set; }
        public string OpisKoraka { get; set; }
        public string Naputak { get; set; }
        public int VrijemeIzvodenja { get; set; }
        public int ReceptId { get; set; }

        public Koraci() { }
        public Koraci(int b, string o, string n, int v) {
            BrojKoraka = b; OpisKoraka = o; Naputak = n; VrijemeIzvodenja = v;
        }
    }
}
