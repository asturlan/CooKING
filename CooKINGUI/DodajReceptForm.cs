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
    public partial class DodajReceptForm : Form, IDodNamContract {
        Recepti r;
        UCSviRecepti caller;
        List<Namirnice> DostupneNamirnice = new List<Namirnice>();//tu su sve namirnice iz baze 
        List<Namirnice> NamZaRecept = new List<Namirnice>();//potrebno za miksanje kolicine i naziva
        List<Sastavnica> Spremno = new List<Sastavnica>(); //popuni ih iz namzarecept na kraju kad klikne spremi - ovo popunjava sastavnicu u bazi
        List<PomocnaNamirnice> PomocneNam = new List<PomocnaNamirnice>();//potrebno za prikaz u LB
        List<Namirnice> TempPretraga = new List<Namirnice>(); //potrebno za search - generira se iz DostupneNamirnice ovisno o tome što je upisano searchbox
        bool ProvjeraTeksta=false; //provjerava da li je nešto napisano u searchbox

        List<Fotografija> UcitaneFotografije = new List<Fotografija>(); //lista fotografija uz recept
        string lokacija; //svaka fotografija ima svoju lokaciju

        List<Koraci> KoraciSpremno = new List<Koraci>();  //lista koraka uz recept
        int RedniBrojKoraka = 1; //koraci kreću od 1 pa na dalje




        //konstruktor
        public DodajReceptForm(Recepti novi,UCSviRecepti ucsr) {
            InitializeComponent();
            caller = ucsr;
            r=novi;
            PopuniSe();
        }


        //Metoda za popunjavanje koja poziva ostale metode za popunjavanje
        public void PopuniSe() {
            PopuniListuDostupnihNamirnica();
            PopuniLBDostupnihNamirnica();
            PopuniDropDownVrstaJelaiTezine();
            PopuniDropDownPodvrstaJela();
        }

        //Metode za Popunjavanje dostupnih namirnica i nam dodanih u recept
        public void PopuniListuDostupnihNamirnica() {
            DostupneNamirnice = SqlKonekcija.UcitajSveNamirnice();
        }
        public void PopuniLBDostupnihNamirnica() {
            LBRezultatipretragenam.DataSource = null;
            if (ProvjeraTeksta) { 
                LBRezultatipretragenam.DataSource = TempPretraga;
            }
            else LBRezultatipretragenam.DataSource = DostupneNamirnice;  
            LBRezultatipretragenam.DisplayMember = "Naziv";

            LBNamUReceptu.DataSource = null;
            LBNamUReceptu.DataSource = PomocneNam;
            LBNamUReceptu.DisplayMember = "Display";
        }
        
        
        //Metode za popunjavanje ListViewa koraka
        public void PopuniListViewKoraka() {
            LWSviKoraci.Items.Clear();
            foreach (Koraci k in KoraciSpremno) {
                ListViewItem i = new ListViewItem((k.BrojKoraka).ToString());
                i.SubItems.Add(k.OpisKoraka);
                i.SubItems.Add(k.Naputak);
                i.SubItems.Add((k.VrijemeIzvodenja).ToString());
                LWSviKoraci.Items.Add(i);
            }
        }
       
        //Metoda za popunjavanje dropDownova za VrstuJela i tezinu
        public void PopuniDropDownVrstaJelaiTezine() {
            CBVrstaJela.DataSource = Enum.GetValues(typeof(Enumeracije.EVrstaJela));
            CBTezina.DataSource = Enum.GetValues(typeof(Enumeracije.EBrTezine));
        }

        //Metoda za popunjavanje Dropdowna za podvrstu jela
        public void PopuniDropDownPodvrstaJela() {
            switch (CBVrstaJela.SelectedIndex) {
                case 0: {
                    CBPodvrstaJela.DataSource = Enum.GetValues(typeof(Enumeracije.EPredjelo));
                       
                    break;
                }
                case 1: {
                    CBPodvrstaJela.DataSource = Enum.GetValues(typeof(Enumeracije.EGlavnoJelo));
                       
                    break;
                }
                case 2: {
                    CBPodvrstaJela.DataSource = Enum.GetValues(typeof(Enumeracije.EDesert));
                     
                    break;
                }
            }
        }

        //Metoda za validaciju podataka o receptu
        private bool ValidirajPodatkeOReceptu() {
            bool b = true;
            int pom=0; int pom1 = 0;
            bool pomo = int.TryParse(TBVrijemePripreme.Text, out pom1);
            bool po = int.TryParse(TBBrojServiranja.Text, out pom);
            foreach(Recepti re in caller.SviRecepti) { if (re.Naziv == TBImeRecepta.Text) { b = false; MessageBox.Show("Ime recepta več postoji."); } }
            if (TBImeRecepta.Text.Length < 1) { MessageBox.Show("Ime recepta je pre kratko."); b = false; }
            else if(TBImeRecepta.Text.Length > 100) { MessageBox.Show("Ime recepta je pre dugačko."); b = false; }
            else if(pomo==false || pom1<1) { MessageBox.Show("Vrijeme pripreme je pogrešno uneseno."); b = false; }
            else if (po == false || pom<1) { MessageBox.Show("Broj serviranja je pogrešno unesen."); b = false; }
            else if (TBSavjet.Text.Length > 3000) { MessageBox.Show("Savjet je pre dugačak"); b = false; }
            else if (NamZaRecept.Count < 1) { MessageBox.Show("Morate unijeti barem jednu namirnicu"); b = false; } 
            else if (KoraciSpremno.Count < 1) { MessageBox.Show("Morate unijeti barem jedan korak"); b = false; }
            return b;
        }

    //EVENTI

        //eventi za spremanje recepta i odustajanje

        private void BSave_Click(object sender, EventArgs e) {
            if (ValidirajPodatkeOReceptu()) {
                r.Naziv = TBImeRecepta.Text;
                int i = CBVrstaJela.SelectedIndex;  r.VrstaJela = (Enumeracije.EVrstaJela)i;
                r.PodvrstaJela = CBPodvrstaJela.SelectedIndex;
                int j = int.Parse(TBBrojServiranja.Text);   r.BrojServiranja = j;
                int k = int.Parse(TBVrijemePripreme.Text);  r.VrijemeKuhanja = k;
                int l = CBTezina.SelectedIndex; r.Tezina = (Enumeracije.EBrTezine)l;
                r.PotrebnoKuhanje = CHBPotrebnoKuhanje.Checked;
                r.Savijet = TBSavjet.Text;

                SqlKonekcija.InsertRecept(r);
                
                foreach(Sastavnica s in Spremno) {
                    s.ReceptId = r.Id;
                    SqlKonekcija.InsertSastavnica(s);
                }
                r.NamirniceRecepta = NamZaRecept.ToList();
                
                foreach(Koraci ko in KoraciSpremno) {
                    ko.ReceptId = r.Id;
                    SqlKonekcija.InsertKorak(ko);
                }
                r.KoraciRecepta = KoraciSpremno.ToList();

                foreach (Fotografija f in UcitaneFotografije) {
                    f.ReceptId = r.Id;
                    SqlKonekcija.InsertFotografija(f);
                }
                r.FotografijeRecepta = UcitaneFotografije.ToList();
                caller.NastaviDodavanjeRecepta();
                this.Close();
                
            }
        }

        private void BOdustani_Click(object sender, EventArgs e) {
            this.Close();
        }

        
        //EVENTI za dodavanje namirnice


        //event kada se promjeni index u LBNamirnica da se promjeni i mjera u labelu ispod
        private void LBRezultatipretragenam_SelectedIndexChanged(object sender, EventArgs e) {
            Namirnice pom = (Namirnice)LBRezultatipretragenam.SelectedItem;
            if (pom != null) {
                LKojajeMjera.Text = (pom.Mjera).ToString();
            } 
        }
        
        //event kada se klikne na strelicu-desno
        private void BDodajNam_Click(object sender, EventArgs e) {
            Namirnice n = (Namirnice)LBRezultatipretragenam.SelectedItem;

            if (KolicinaValidna() && n!=null) {
                Sastavnica p = new Sastavnica();
     
                DostupneNamirnice.Remove(n);
                NamZaRecept.Add(n);
                p.NamirnicaId = n.Id;
                decimal d = decimal.Parse(TBKolicina.Text);
                p.Kolicina = d;
                Spremno.Add(p);
                PomocneNam.Add(new PomocnaNamirnice(n.Naziv, p.Kolicina, n.Mjera));
                PopuniLBDostupnihNamirnica();
            } else {
                MessageBox.Show("Krivo unesena količina.");
            }
            TBKolicina.Text = "";
        }
        private bool KolicinaValidna() {
            decimal d=0;
            bool b = decimal.TryParse(TBKolicina.Text, out d);
            if (d < 0) b = false;
            return b;
        }

        //event kada kliknemo na strelicu-lijevo
        private void BSkiniNam_Click(object sender, EventArgs e) {
            PomocnaNamirnice n = (PomocnaNamirnice)LBNamUReceptu.SelectedItem;
            if (n != null) {
                PomocneNam.Remove(n);
                Namirnice pom = new Namirnice();
                foreach (Namirnice nam in NamZaRecept) {
                    if (nam.Naziv == n.Naziv) {
                        pom = nam;
                        DostupneNamirnice.Add(nam);
                        NamZaRecept.Remove(nam);
                        break;
                    }
                }
                foreach (Sastavnica sas in Spremno) {
                    if (sas.NamirnicaId == pom.Id) {
                        Spremno.Remove(sas);
                        break;
                    }
                }
                PopuniLBDostupnihNamirnica();
            }
        }
        //kada kliknemo na search
        private void BSearch_Click(object sender, EventArgs e) {  
            TempPretraga.Clear();
            ProvjeraTeksta = false;
            if (TBPojam.Text != "") {
                ProvjeraTeksta = true;
                foreach (Namirnice n in DostupneNamirnice) {
                    if (n.Naziv.IndexOf(TBPojam.Text, StringComparison.OrdinalIgnoreCase) >= 0) {
                        Namirnice nova = new Namirnice();
                        nova = n;
                        TempPretraga.Add(nova);
                    }
                }
            }
            PopuniLBDostupnihNamirnica();
            TBPojam.Text = "";
        }
        //kada kliknemo na refresh
        private void BRefresh_Click(object sender, EventArgs e) {
            ProvjeraTeksta = false;
            PopuniListuDostupnihNamirnica();
            PopuniLBDostupnihNamirnica();
            TBPojam.Text = "";
        }


        //EVENTI za korake



        //event i valdacija za dodaj korak
        private void BDodajKorak_Click(object sender, EventArgs e) {
            if (ValidirajKorak()) {
                int vp = int.Parse(TBVrijemeIzvodenja.Text);
                Koraci novi = new Koraci(RedniBrojKoraka,TBUpisiKorak.Text,TBNaputak.Text,vp);
                KoraciSpremno.Add(novi);
                RedniBrojKoraka++;
                PopuniListViewKoraka();
                TBUpisiKorak.Text = ""; TBNaputak.Text = "";
            }
        }
        private bool ValidirajKorak() {
            bool b = true;
#pragma warning disable IDE0018 // Inline variable declaration
            int pom;
#pragma warning restore IDE0018 // Inline variable declaration
            bool jeliint = int.TryParse(TBVrijemeIzvodenja.Text, out pom);
            if (TBUpisiKorak.Text.Length > 3000) {
                MessageBox.Show("Opis koraka je pre dugačak.");
                b = false;
            }else if (TBUpisiKorak.Text.Length < 1) {
                MessageBox.Show("Opis koraka je pre kratak.");
                b = false;
            }else if (TBNaputak.Text.Length > 200) {
                MessageBox.Show("Tekst naputka je pre dugačak.");
                b = false;
            }else if (jeliint == false) {
                MessageBox.Show("Vrijeme izvođenja je pogrešno uneseno.");
                b = false;
            }
            return b;
        }


        //event za brisanje koraka
        private void BObrisiOdabrano_Click(object sender, EventArgs e) {
            if (KoraciSpremno.Count != 0) {
                int brojk = 0;
                string a;
                if (LWSviKoraci.SelectedItems.Count > 0) {
                    a = LWSviKoraci.SelectedItems[0].Text;
                    foreach (Koraci k in KoraciSpremno) {
                        if ((k.BrojKoraka).ToString() == a) {
                            brojk = k.BrojKoraka - 1;
                            KoraciSpremno.Remove(k);
                            break;
                        }
                    }
                    foreach (Koraci kor in KoraciSpremno) {
                        if (kor.BrojKoraka > brojk) {
                            kor.BrojKoraka--;
                        }
                    }
                    RedniBrojKoraka--;
                    PopuniListViewKoraka();
                }
            }
        }


        private void CBVrstaJela_SelectedIndexChanged(object sender, EventArgs e) {
            PopuniDropDownPodvrstaJela();
        }

        
        //eventi za dodavanje fotografija
        private void BDodajFotografiju_Click(object sender, EventArgs e) {
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter="JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif";
            ofd.Title = "Odaberi fotografiju";
            if (ofd.ShowDialog() == DialogResult.OK) {
                lokacija = ofd.FileName.ToString();
            }
            PBDodajFotografiju.ImageLocation = lokacija;
        }

        private void BSpremiFotografiju_Click(object sender, EventArgs e) {
            Fotografija nova = new Fotografija();
            nova.Lokacija = lokacija;
            UcitaneFotografije.Add(nova);
            MessageBox.Show("Fotografija dodana.");
            PBDodajFotografiju.ImageLocation = null;
        }
        



        //metode potrebne jer nasljeđuje IDodNamContract 

        
        public void PopuniListuNamirnica() {
            caller.caller.M1();
        }
        public void UcitajUListView() { caller.caller.M1(); }

        private void BKreirajNovuNam_Click(object sender, EventArgs e) {
            DodajNamirniceForm dnf = new DodajNamirniceForm(this);
            dnf.Show();
        }

        
    }
}
