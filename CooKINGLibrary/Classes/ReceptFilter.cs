using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooKINGLibrary.Classes {
    public class ReceptFilter {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public bool ImaSve { get; set; }
        public List<Namirnice> NedostajuNam { get; set; } 
        public List<string> ImaNamirnice = new List<string>();  
    }
}
