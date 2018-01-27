using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CooKINGLibrary.Classes {
    public class Recepti {

        public int Id { get; set; }
        public string Naziv { get; set; }
        public Enumeracije.EVrstaJela VrstaJela { get; set; }
        public int PodvrstaJela { get; set; }
        public int BrojServiranja { get; set; }
        public int VrijemeKuhanja { get; set; }
        public Enumeracije.EBrTezine Tezina { get; set; }
        public bool PotrebnoKuhanje { get; set; }
        public string Biljeska { get; set; }
        public string Savijet { get; set; }

        public List<Koraci> KoraciRecepta { get; set; } = new List<Koraci>();
        public List<Namirnice> NamirniceRecepta { get; set; } = new List<Namirnice>();
        public List<Fotografija> FotografijeRecepta { get; set; } = new List<Fotografija>();

        public Recepti() { }
        public Recepti(int id, string naziv, Enumeracije.EVrstaJela vj, int pvj, int bs, int vk, Enumeracije.EBrTezine bt, bool pk, string bilj, string savijet, List<Koraci> k, List<Namirnice> n, List<Fotografija> f) {
            Id = id; Naziv = naziv; VrstaJela = vj; PodvrstaJela = pvj;
            BrojServiranja = bs; VrijemeKuhanja = vk; Tezina = bt; PotrebnoKuhanje = pk; Biljeska = bilj; Savijet = savijet; KoraciRecepta = k.ToList(); NamirniceRecepta = n.ToList(); FotografijeRecepta = f.ToList();
        }
    }
}
