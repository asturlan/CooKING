using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooKINGLibrary.Classes {
    public class Korisnik {
        public int Id { get; set; }
        public string KorIme { get; set; }
        public string Lozinka { get; set; }
        public int CookingCombo { get; set; }
        public int BrojXP { get; set; }
        public int[] XPuTjednu { get; set; }
    }
}
