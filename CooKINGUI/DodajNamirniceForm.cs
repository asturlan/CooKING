using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CooKINGLibrary.Classes;

namespace CooKINGUI {
    public partial class DodajNamirniceForm : Form {
        IDodNamContract c; //kako bi ispunili listu svih namirnica u prozoru koji je roditelj ovom
        List<Namirnice> SveNamirnice = new List<Namirnice>(); //treba nam za provjeru da li ime namirnice več postoji

        public DodajNamirniceForm(IDodNamContract caller) {   //konstruktor
            InitializeComponent();
            c = caller;
            UcitajSveNamirnice();
        }

        //METODE

        public void UcitajSveNamirnice() {
            SveNamirnice = SqlKonekcija.UcitajSveNamirnice();
        }
        public void PopulateCB() {  //popunjava dropdownove
            CBMjeraNam.DataSource = Enum.GetValues(typeof(Enumeracije.ENazivMjere));
            CBVrstaNam.DataSource = Enum.GetValues(typeof(Enumeracije.EVrstaNamirnice));
        }
        public bool ValidirajUnose() {  //pregledava je li sve dobro upisano od strane korisnika
            bool uredu = true;
            if (TBImeNamirnice.Text.Length > 45 || TBImeNamirnice.Text.Length<1) {
                MessageBox.Show("Ime namirnice nije dobro uneseno.");
                uredu = false;
            }else if (CBMjeraNam.SelectedItem == null || CBVrstaNam.SelectedItem==null) {
                MessageBox.Show("Morate odabrati Mjeru i Vrstu namirnice");
                uredu = false;
            }
            foreach(Namirnice n in SveNamirnice) {
                if (n.Naziv == TBImeNamirnice.Text) {
                    uredu = false;
                    MessageBox.Show("Ime namirnice več postoji");
                }
            }
            return uredu;
        }

        //EVENTI

        private void BNamOdustani_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void DodajNamirniceForm_Load(object sender, EventArgs e) {
            PopulateCB(); //popunjava comboboxove kada se prozor ucita
        }

        private void BNamSave_Click(object sender, EventArgs e) {
            Namirnice n = new Namirnice();
            if (ValidirajUnose()) {
                n.Naziv = TBImeNamirnice.Text;
                int i=CBMjeraNam.SelectedIndex;
                n.Mjera = (Enumeracije.ENazivMjere)i;
                int j = CBVrstaNam.SelectedIndex;
                n.Vrsta = (Enumeracije.EVrstaNamirnice)j;
                if (CheckBoxDa.Checked == true) n.Opca = true;
                SqlKonekcija.InsertNamirnica(n);  //poziva se metoda iz statičke klase koja unosi namirnicu u bazu
                c.PopuniListuNamirnica();
                c.UcitajUListView();
                this.Close();
            }
        }
    }
}
