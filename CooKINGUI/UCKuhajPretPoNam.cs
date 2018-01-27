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
    public partial class UCKuhajPretPoNam : UserControl {
        public UCSviRecepti partner; 
        public UCNamirnice partnerNam;

        DataTable dt = new DataTable(); //treba nam datatable jer inace ne mogu koristiti search i u isto vrijeme updeatati listview
        List<PomocnaNamirnice> pomocnaNam = new List<PomocnaNamirnice>();  //namirnice koje smo dodali u pretragu
        public List<Recepti> MoguciRecepti = new List<Recepti>(); //tu se stavljaju oni recepti koji odgovaraju sql upitu
        List<ReceptFilter> RF=new List<ReceptFilter> (); //dodatno filtirirani recepti po namirnicama(ili po namirnicama i kolicinama)->ovisi da li je kvacica na "zanemari mjere i kolicine"
        List<int> IdFiltriranihRecepta=new List<int> ();//dohvacamo id-eve recepata iz baze koji odgovaraju filterima
        List<int> OdabraneTezine = new List<int>(); //tu idu brojevi na koje je kliknuo korisnik(tezine)
        int ct1 = 0, ct2 = 0, ct3 = 0, ct4 = 0, ct5 = 0; //za tezine. 0 ako nije kliknuto, 1 ako je kliknuto


        //KONSTRUKTOR
        public UCKuhajPretPoNam() {
            InitializeComponent();
            PopuniComboBoxeve();
        }
        //METODE ZA POPUNJAVANJE PARTNERA
        public void LoadPartner(UCSviRecepti s) => partner = s;
        public void LoadPartner2(UCNamirnice n) => partnerNam = n;



        //METODE


        public void PopuniLBNamirnica() { //ispunjava LBNamirnicaZaPRetragu
            LBNamirnicezapretragu.DataSource = null;
            LBNamirnicezapretragu.DataSource = GetData();
            LBNamirnicezapretragu.DisplayMember = "Naziv";
        }

        private DataTable GetData() { //ispunjava datatable sa nazivima namirnica(sve koje postoje)
            dt = new DataTable();
            dt.Columns.Add("Naziv", typeof(string));
            foreach(Namirnice n in partnerNam.SveNamirnice) {
                dt.Rows.Add(n.Naziv);
            }
            return dt;
        }
        public void PopuniLBDodanihNam() {//namirnice koje smo dodali u pretragu prikazuje u LBDodanihNamirnica
            LBDodaneNamirnice.DataSource = null;
            LBDodaneNamirnice.DataSource = pomocnaNam;
            LBDodaneNamirnice.DisplayMember = "Display";
        }


        
        private void PopuniComboBoxeve() {//popunjavanje comboboxeva
            CBVrstaJela.DataSource = Enum.GetValues(typeof(Enumeracije.EVrstaJela));
            PopuniDropDownPodvrstaJela();

        }
        public void PopuniDropDownPodvrstaJela() { //ovisno o tome koja je vrsta jela odabrana popunjava podvrstu jela u dropdownu
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
        
        private void ChangeMjera() { //tekst od LMjera2 se mijenja ovisno o kliknutoj namirnici
            string s;
            foreach(Namirnice n in partnerNam.SveNamirnice) {
                s = LBNamirnicezapretragu.GetItemText(LBNamirnicezapretragu.SelectedItem);
                if (s == n.Naziv) {
                    LMjera2.Text = n.Mjera.ToString();
                }
            }
        }
        private void BKreirajNovuNam_Click(object sender, EventArgs e) { //krivo se zove to je dodaj namirnicu iz LBNamZaPretragu u pomocnaNam -> kako bi se u LBDodaneNamirnice moglo prikazati ime kolicina i mjera.
            if (ProvjeriDaLiPostojiUListi(LBNamirnicezapretragu.GetItemText(LBNamirnicezapretragu.SelectedItem))) {
                if (Validiraj()) {
                    decimal d = decimal.Parse(TBKolicina1.Text);
                    Enumeracije.ENazivMjere a = (Enumeracije.ENazivMjere)Enum.Parse(typeof(Enumeracije.ENazivMjere), LMjera2.Text.ToString());
                    PomocnaNamirnice pn = new PomocnaNamirnice(LBNamirnicezapretragu.GetItemText(LBNamirnicezapretragu.SelectedItem), d, a);
                    pomocnaNam.Add(pn);
                    PopuniLBDodanihNam();
                }
            }
        }
        private bool ProvjeriDaLiPostojiUListi(string s) { //provjerava da li odabrana namirnica več postoji u LBDodaneNamirnice
            bool b=true;
            foreach(PomocnaNamirnice p in pomocnaNam) {
                if (p.Naziv == s) b = false;
            }
            return b;
        }
        

        private bool Validiraj() { //provjerava točnost korisnikovog unosa namirnica(da li je dobro unesena količina i da li je odabrana barem jedna namirnica)
            bool b = true;
            decimal d = 0;
            bool bo = decimal.TryParse(TBKolicina1.Text, out d);
            if (LBNamirnicezapretragu.SelectedItem == null) {
                b = false;
                MessageBox.Show("Morate izabrati namirnicu prije dodavanja");
            }else if(TBKolicina1.Text.Length<1 || TBKolicina1.Text.Length > 6 || bo==false) {
                b = false;
                MessageBox.Show("Krivo unesena količina");
            }
            return b;
        }

        private bool ValidirajFiltere() { //provjerava da li su filteri dobro ispunjeni 
            bool b = true;
            int d = 0;
            bool bo = int.TryParse(TBVrijemePripreme.Text, out d);
            if (pomocnaNam == null || pomocnaNam.Count<1) {
                b = false;
                MessageBox.Show("Barem jedna namirnica mora postojati za pretraživanje");
            }else if (bo==false) {
                b = false;
                MessageBox.Show("Krivi unos u polju: Vrijeme Pripreme");
            }else if (OdabraneTezine.Count == 0) {
                b = false;
                MessageBox.Show("Odaberite barem jednu težinu recepta za pretragu");
            }
            return b;
        }


        //EVENTI

        private void BObrisiodabrnamir_Click(object sender, EventArgs e) {
            PomocnaNamirnice s = (PomocnaNamirnice)LBDodaneNamirnice.SelectedItem;
            pomocnaNam.Remove(s);
            PopuniLBDodanihNam();
        }

        private void LBNamirnicezapretragu_SelectedIndexChanged(object sender, EventArgs e) {
            ChangeMjera();
        }

        private void TBPretraga_TextChanged(object sender, EventArgs e) { 
            DataView dw = dt.DefaultView;
            dw.RowFilter = "Naziv LIKE '%" + TBPretraga.Text + "%'";
            ChangeMjera();
        }

        private void CBVrstaJela_SelectedIndexChanged(object sender, EventArgs e) {
            PopuniDropDownPodvrstaJela();
        }

        private void Btezina1_Click(object sender, EventArgs e) { //ovaj i sljedećih 5 rješavaju što se dešava kada korisnik klikne na broj težine
            if (ct1 == 0) {
                Btezina1.BackgroundImage = Properties.Resources.check;
                OdabraneTezine.Add(0); ct1++;
            } else {
                ct1--;
                Btezina1.BackgroundImage = null;
                OdabraneTezine.Remove(0); 
            }
        }

        private void Btezina2_Click(object sender, EventArgs e) {
            if (ct2 == 0) {
                Btezina2.BackgroundImage = Properties.Resources.check;
                OdabraneTezine.Add(1); ct2++;
            } else {
                ct2--;
                Btezina2.BackgroundImage = null;
                OdabraneTezine.Remove(1);
            }
        }
        private void Btezina3_Click(object sender, EventArgs e) {
            if (ct3 == 0) {
                Btezina3.BackgroundImage = Properties.Resources.check;
                OdabraneTezine.Add(2); ct3++;
            } else {
                ct3--;
                Btezina3.BackgroundImage = null;
                OdabraneTezine.Remove(2);
            }
        }
        private void Btezina4_Click(object sender, EventArgs e) {
            if (ct4 == 0) {
                Btezina4.BackgroundImage = Properties.Resources.check;
                OdabraneTezine.Add(3); ct4++;
            } else {
                ct4--;
                Btezina4.BackgroundImage = null;
                OdabraneTezine.Remove(3);
            }
        }
        private void Btezina5_Click(object sender, EventArgs e) {
            if (ct5 == 0) {
                Btezina5.BackgroundImage = Properties.Resources.check;
                OdabraneTezine.Add(4); ct5++;
            } else {
                ct5--;
                Btezina5.BackgroundImage = null;
                OdabraneTezine.Remove(4);
            }
        }


        /*
         * Sljeedeca metoda radi:
         *      nakon sto validira da li su filteri dobro uneseni, po njima iz baze izvlaci id-eve recepata koji odgovaraju filterima
         *      zatim se poziva metoda StaviUMoguciRecepti koja za svaki Id u IdFiltriranihRecepta pronalazi recept i stavlja ga u listu MoguciRecepti
         *      nakon toga se recepti iz MoguciRecepti filtriraju ovisno o tome da li je kvacica na "zanemari mjere i kolicine" ili ne.
         *      zatim se poziva form1 (partner.caller..) koji podiže na površinu UCKuhajRezultatiPretrage i predaje mu listu Mogucih recepta(oni ce se prikazati zuto i zeleno tamo)
         */
        private void BPretraziRecepte_Click(object sender, EventArgs e) {
            RF.Clear();
            MoguciRecepti.Clear();
            IdFiltriranihRecepta.Clear();
            if (ValidirajFiltere()) {
                OdabraneTezine.Sort();
                if (CHBPrikazujBiloSta.Checked == true) { 
                    IdFiltriranihRecepta = SqlKonekcija.DohvatiIdReceptaFalse(OdabraneTezine[0], OdabraneTezine[OdabraneTezine.Count - 1], int.Parse(TBVrijemePripreme.Text));
                } else {
                    IdFiltriranihRecepta = SqlKonekcija.DohvatiIdReceptaTrue(OdabraneTezine[0], OdabraneTezine[OdabraneTezine.Count - 1], int.Parse(TBVrijemePripreme.Text), CBVrstaJela.SelectedIndex, CBPodvrstaJela.SelectedIndex);
                }
                if (IdFiltriranihRecepta.Count == 0) { 
                    MessageBox.Show("Ne postoji ni jedan recept koji odgovara pretrazi");
                } else {
                    
                    StaviuMoguciRecepti();

                    
                    if (CBZanemariMjereiKol.Checked == true) IspuniRF();
                    else IspuniRFsaKolicinom();
                    
                    if (RF.Count > 0) {
                        partner.caller.PredajRF(RF);
                        partner.caller.IspuniRFRez();
                        partner.caller.PostaviGoreUCKuhajRezultatiPretrage();
                    } else {
                        MessageBox.Show("Ne postoji ni jedan recept koji odgovara pretrazi");
                    }
                }
                
            }
            
        }


        public void StaviuMoguciRecepti() {
            foreach(int i in IdFiltriranihRecepta) {
                Recepti novi;
                foreach(Recepti  r in partner.SviRecepti) {
                    if (r.Id == i) {
                        novi = new Recepti(r.Id, r.Naziv, r.VrstaJela, r.PodvrstaJela, r.BrojServiranja, r.VrijemeKuhanja, r.Tezina, r.PotrebnoKuhanje, r.Biljeska, r.Savijet, r.KoraciRecepta, r.NamirniceRecepta, r.FotografijeRecepta);
                        MoguciRecepti.Add(novi);
                    }
                }
            }
        }
        public void IspuniRFsaKolicinom() {
            int brojiPojave; int brojUnesenihNamirnica = pomocnaNam.Count();
            ReceptFilter novi;
            foreach (Recepti r in MoguciRecepti) {
                novi = new ReceptFilter();
                brojiPojave = 0;
                foreach (PomocnaNamirnice n in pomocnaNam) {
                    var remove = r.NamirniceRecepta.SingleOrDefault(na => na.Naziv == n.Naziv);
                    if (remove != null) {
                        foreach(Sastavnica s in partner.SveSastavnice) {
                            if(remove.Id==s.NamirnicaId && s.ReceptId==r.Id  && s.Kolicina <= n.Kolicina) {
                                brojiPojave++;
                                novi.ImaNamirnice.Add(remove.Naziv);
                                r.NamirniceRecepta.Remove(remove);
                            }
                        }  
                    }
                }
                if (brojiPojave > 0) {
                    novi.Naziv = r.Naziv; novi.Id = r.Id;
                    if (r.NamirniceRecepta.Count == 0) {
                        novi.ImaSve = true;
                    } else novi.ImaSve = false;
                    if (r.NamirniceRecepta == null) novi.NedostajuNam = null;
                    else novi.NedostajuNam = r.NamirniceRecepta.ToList();
                    RF.Add(novi);
                }
            }
        }
        public void IspuniRF() {
            int brojiPojave; int brojUnesenihNamirnica = pomocnaNam.Count();
            ReceptFilter novi;
            foreach(Recepti r in MoguciRecepti) {
                novi = new ReceptFilter();
                brojiPojave = 0;
                foreach(PomocnaNamirnice n in pomocnaNam) {
                    var remove = r.NamirniceRecepta.SingleOrDefault(na => na.Naziv == n.Naziv);
                    if (remove != null) {
                        brojiPojave++;
                        novi.ImaNamirnice.Add(remove.Naziv);
                        r.NamirniceRecepta.Remove(remove);
                    }
                 }
                if (brojiPojave > 0) {
                    novi.Naziv = r.Naziv; novi.Id = r.Id;
                    if (r.NamirniceRecepta.Count==0) {
                        novi.ImaSve = true; 
                    } else novi.ImaSve = false;
                    if (r.NamirniceRecepta == null) novi.NedostajuNam = null;
                    else novi.NedostajuNam = r.NamirniceRecepta.ToList();
                    RF.Add(novi);
                }
            }
        }
    }
}
