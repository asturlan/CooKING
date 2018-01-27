using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CooKINGLibrary.Classes;

namespace CooKINGUI {
    public partial class UCNamirnice : UserControl, IDodNamContract {

        public List<Namirnice> SveNamirnice = new List<Namirnice>(); //potrebno za prikaz u listi->koje namirnice postoje i njihovi detalji
        public List<Sastavnica> SveSastavnice = new List<Sastavnica>();

        //KONSTRUKTOR
        public UCNamirnice() {
            InitializeComponent();
            SveSastavnice = SqlKonekcija.GetSveSastavnice();
        }


        //METODE

        public void PopuniListuNamirnica() { //popunjavanje gornjih lista iz baze
            SveNamirnice = SqlKonekcija.UcitajSveNamirnice();
            SveSastavnice = SqlKonekcija.GetSveSastavnice();
        }
        
        public void UcitajUListView() { //popunjavanje LVSveNamirnice iz liste SveNamirnice
            LWSveNamirnice.Items.Clear();
            foreach (Namirnice n in SveNamirnice) {
                ListViewItem i = new ListViewItem(n.Naziv);
                i.SubItems.Add((n.Mjera).ToString());
                i.SubItems.Add((n.Vrsta).ToString());
                if(n.Opca==true) i.SubItems.Add("Daaaaa");
                else i.SubItems.Add("Ne");
                LWSveNamirnice.Items.Add(i);
            }
        }

        //EVENTI

        private void BDodajNamirnicu_Click(object sender, EventArgs e) {
            DodajNamirniceForm dnf = new DodajNamirniceForm(this);
            dnf.ShowDialog();
        }

        private void BIzbrisiOdabrano_Click(object sender, EventArgs e) {
            if (SveNamirnice.Count != 0) {
                int i = FindId(LWSveNamirnice.SelectedItems[0].Text);
                if (NepostojiKaoSastavnica(i)) {
                    if (LWSveNamirnice.SelectedItems.Count > 0) {
                        string a = LWSveNamirnice.SelectedItems[0].Text;
                        SqlKonekcija.DeleteNamirnica(a);
                        PopuniListuNamirnica(); UcitajUListView();

                    }
                } else {
                    MessageBox.Show("Namirnica postoji kao sastavnica u receptu, Brisanje nije moguće.");
                }
            } else {
                MessageBox.Show("Ne postoji namirnica za brisanje"); 
            }  
        }
        //metode koje se koriste u eventu BIzbrisiOdabrano_Click
        public int FindId(string a) { //nađi id one namirnice koja je u tom trenutku oznacena
            int id=0;
            foreach(Namirnice n in SveNamirnice) { if (n.Naziv == a) { id = n.Id; } }
            return id;
        }
        public bool NepostojiKaoSastavnica(int i) {//nesmijemo obrisati namirnicu ako ona postoji kako sastavnica nekog recepta
            bool b = true;
            foreach(Sastavnica s in SveSastavnice) {
                if (s.NamirnicaId == i) b = false;
            }
            return b;
        }
    }
}
