using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooKINGLibrary.Classes {
    public class Enumeracije {
        public enum EVrstaJela { Predjelo, GlavnoJelo, Desert};
        public enum EPredjelo { Juha, HladnoPredjelo, ToploPredjelo};
        public enum EGlavnoJelo { JeloMeso, JeloRiba, JeloProvrće, Salata};
        public enum EDesert { PečeniKolač, NepečeniKolač, KruhIPeciva};
        public enum EBrTezine { Jedan, Dva, Tri, Četiri, Pet};
        public enum ENazivMjere { kg, dkg, g, mg, dl, ml, l, kom, žlica, čaša, prstohvat, žličica};
        public enum EVrstaNamirnice { Meso, Riba, Voće, Povrće, Začin, MliječniProizvod, Žitarica, OrašastoVoće, Ostalo, Masnoća};

    }
}
