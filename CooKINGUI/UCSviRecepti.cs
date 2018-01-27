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
    public partial class UCSviRecepti : UserControl {
        public Form1 caller; //povezan je sa Form1 kako bi mogao komunicirati s ostalim UC-ovima

        public List<Recepti> SviRecepti = new List<Recepti>(); //tu se nalaze svi recepti i oni se vuku iz baze
        List<Recepti> TempRecepti = new List<Recepti>(); //ta lista drži one recepte koji su određene vrste(kada kliknemo na predjela drži predjela)
        public List<Sastavnica> SveSastavnice = new List<Sastavnica>(); //sve sastavnice iz baze
        List<PomocnaNamirnice> pn = new List<PomocnaNamirnice>(); //za prikaz sastojaka recepta kada se klikne na njega
        Recepti novi; //recept na koji kliknemo

        int PratiPrikaz=0; //prati prikaz sličica recepata
        int BrojZaBrisanje = 0; //koji index iz TempRecepta zelimo obrisati


        //KONSTRUKTOR
        public UCSviRecepti() {
            InitializeComponent();
            RefreshUC(); 
        }


        public void GetCaller(Form1 c) {
            caller = c;
        }

        //METODE

        public void NastaviDodavanjeRecepta() { //kada u DodajReceptForm kliknemo na spremi mi moramo taj recept(osim što ga spremamo u bazu) spremiti i u SviRecepti listu. Od tamo pozivamo ovu funkciju sa caller.NastaviDodavanjeRecepta()
            SviRecepti.Add(novi);
            LoadSastavnice();
            TreeNode n = TWSviRecepti.Nodes[0];
            TWSviRecepti.SelectedNode = n;
            PopuniTempRecepti();
            LNazivRecepta.Text = "Naziv recepta";
            PBSlikaRecepta.Image = Properties.Resources.food;
            PanSviRecepti2.Hide();
        }
        
        private void PopuniTempRecepti() { //popunjava TempRecepti ovisno o tome na što kliknemo(predjelo, glavno jelo, juha, jelomeso...)
            LVrstaJela.Text = TWSviRecepti.SelectedNode.Text;
            string s = LVrstaJela.Text;
            TempRecepti.Clear();
            if (s == "Predjela" || s == "Glavna jela" || s == "Deserti") {
                foreach (Recepti r in SviRecepti) {
                    if (r.VrstaJela.ToString() == TWSviRecepti.SelectedNode.Name) {
                        TempRecepti.Add(r);
                    }
                }
            } else {
                foreach (Recepti r in SviRecepti) {
                    if (r.VrstaJela.ToString() == TWSviRecepti.SelectedNode.Parent.Name && r.PodvrstaJela.ToString() == TWSviRecepti.SelectedNode.Name) {
                        TempRecepti.Add(r);
                    }
                }
            }
            PratiPrikaz = 0; 
            IspuniFotografijeiNazive(); //nakon što popuniš TempRecepti ovisno o tome što je unutra ispuniti će se one 3 sličice gore
            PANOznacenaFotografija.Location = new Point(69, 25);
            PANOznacenaFotografija.Hide();
        }
        
        public void IspuniFotografijeiNazive() {
            PBSlika1.Image = null;
            PBSlika2.Image = null;
            PBSlika3.Image = null;
            LNazivRecepta1.Text = "";
            LNazivRecepta2.Text = "";
            LNazivRecepta3.Text = "";
            if (TempRecepti != null && TempRecepti.Count!=0) {
                if (PratiPrikaz <= TempRecepti.Count) {
                    try {
                        PBSlika1.ImageLocation = TempRecepti[PratiPrikaz].FotografijeRecepta[0].Lokacija;
                    } catch {
                        PBSlika1.Image = Properties.Resources.food;

                    }
                    LNazivRecepta1.Text = TempRecepti[PratiPrikaz].Naziv;
                }
                PratiPrikaz++;
                if (PratiPrikaz < TempRecepti.Count) {
                    try {
                        PBSlika2.ImageLocation = TempRecepti[PratiPrikaz].FotografijeRecepta[0].Lokacija;
                    } catch {
                        PBSlika2.Image = Properties.Resources.food;
                    }
                    LNazivRecepta2.Text = TempRecepti[PratiPrikaz].Naziv;
                }
                PratiPrikaz++;
                if (PratiPrikaz < TempRecepti.Count) {
                    try {
                        PBSlika3.ImageLocation = TempRecepti[PratiPrikaz].FotografijeRecepta[0].Lokacija;
                       
                    } catch {
                        PBSlika3.Image = Properties.Resources.food;
                    }
                    LNazivRecepta3.Text = TempRecepti[PratiPrikaz].Naziv;
                }
                PratiPrikaz++;
            } 
            if (PratiPrikaz >= TempRecepti.Count) BSljedeceSlike.Visible = false;
            else BSljedeceSlike.Visible = true;
            if (PratiPrikaz <= 3) BPrethodneslike.Visible = false;
            else BPrethodneslike.Visible = true;
        }
        private void IspuniPodatkeoReceptu(int i) {
            LWSviKoraci1.Items.Clear();
            foreach (Koraci k in TempRecepti[i].KoraciRecepta) {
                ListViewItem n = new ListViewItem((k.BrojKoraka).ToString());
                n.SubItems.Add(k.OpisKoraka);
                LWSviKoraci1.Items.Add(n);
            }
            pn.Clear();
            foreach (Namirnice n in TempRecepti[i].NamirniceRecepta) {
                foreach (Sastavnica s in SveSastavnice) {
                    if (s.ReceptId == TempRecepti[i].Id && s.NamirnicaId == n.Id) {
                        PomocnaNamirnice p = new PomocnaNamirnice(n.Naziv, s.Kolicina, n.Mjera);
                        pn.Add(p);
                        break;
                    }
                }
            }
            LBNamUReceptu1.DataSource = null;
            LBNamUReceptu1.DataSource = pn;
            LBNamUReceptu1.DisplayMember = "Display";

            label1.Text = TempRecepti[i].VrstaJela.ToString();
            int r = (int)TempRecepti[i].VrstaJela;
            if (r == 0) label2.Text = ((Enumeracije.EPredjelo)TempRecepti[i].PodvrstaJela).ToString();
            else if (r == 1) label2.Text = ((Enumeracije.EGlavnoJelo)TempRecepti[i].PodvrstaJela).ToString();
            else if (r == 2) label2.Text = ((Enumeracije.EDesert)TempRecepti[i].PodvrstaJela).ToString();
            label3.Text = TempRecepti[i].VrijemeKuhanja.ToString();
            label4.Text = TempRecepti[i].Tezina.ToString();
            label5.Text = TempRecepti[i].BrojServiranja.ToString();
            if (TempRecepti[i].PotrebnoKuhanje == true) label6.Text = "Da";
            else label6.Text = "Ne";
            PanSviRecepti2.Show();
        }
        private void RefreshUC() { //refreshaj cijeli form -> potrebno nakon dodavanja novog recepta da se osvježe liste
            LoadSviRecepti();
            LoadListeRecepta();
            LoadSastavnice();
            TreeNode n = TWSviRecepti.Nodes[0];
            TWSviRecepti.SelectedNode = n;
            PopuniTempRecepti();
            LNazivRecepta.Text = "Naziv recepta";
            PBSlikaRecepta.Image = Properties.Resources.food;
            PanSviRecepti2.Hide();
        }


        //EVENTI
        private void LoadSviRecepti() { //iz baze dohvača sve recepte
            SviRecepti = SqlKonekcija.GetAll_Recepti();
        }
        private void LoadListeRecepta() { //iz baze dohvaća sve namirnice od recepta, sve fotografije i sve korake
            SqlKonekcija.GetNamirniceZaRecept(SviRecepti);
            SqlKonekcija.GetFotografijeZaRecept(SviRecepti);
            SqlKonekcija.GetKoraciZaRecept(SviRecepti);
        }
        private void LoadSastavnice() { //dohvaća sve sastavnice
            SveSastavnice = SqlKonekcija.GetSveSastavnice();
        }
        private void TWSviRecepti_AfterSelect(object sender, TreeViewEventArgs e) { //objašnjeno gore
            PopuniTempRecepti();
        }
        private void BDodajRecept_Click(object sender, EventArgs e) { //otvara se novi form: DodajReceptForm u kojem se dodaje novi recept. Njemu se predaje njegov roditelj, odnosno ovaj prozor kako bi se moglo nastaviti dodavanje recepta sa NastaviDodavanjeRecepta()
            novi = new Recepti();
            DodajReceptForm drf = new DodajReceptForm(novi, this);
            drf.Show();

        }
        private void BSljedeceSlike_Click(object sender, EventArgs e) { //pomicanje slika kada se klikne na strelicu desno
            PANOznacenaFotografija.Hide();
            IspuniFotografijeiNazive();
        }

        private void BPrethodneslike_Click(object sender, EventArgs e) {//pomicanje slika kada se klikne na strelicu lijevo
            PANOznacenaFotografija.Hide();
            PratiPrikaz -= 6;
            IspuniFotografijeiNazive();
        }
        //sljedeće 3 metode: otvaraju određeni recept ovisno na koju se sličicu klikne
        private void PBSlika1_Click(object sender, EventArgs e) {
            if (PBSlika1.Image != null) {
                PANOznacenaFotografija.Show();
                PANOznacenaFotografija.Location = new Point(69, 25);
                LNazivRecepta.Text = TempRecepti[PratiPrikaz - 3].Naziv;
                BrojZaBrisanje = PratiPrikaz - 3;
                try {
                    PBSlikaRecepta.ImageLocation = TempRecepti[PratiPrikaz - 3].FotografijeRecepta[0].Lokacija;

                } catch {
                    PBSlikaRecepta.Image = Properties.Resources.food;
                }
                IspuniPodatkeoReceptu(PratiPrikaz-3);
            }
        }

        private void PBSlika2_Click(object sender, EventArgs e) {
            if (PBSlika2.Image != null) {
                PANOznacenaFotografija.Show();
                PANOznacenaFotografija.Location = new Point(280, 25);
                LNazivRecepta.Text = TempRecepti[PratiPrikaz - 2].Naziv;
                BrojZaBrisanje = PratiPrikaz - 2;
                try {
                    PBSlikaRecepta.ImageLocation = TempRecepti[PratiPrikaz - 2].FotografijeRecepta[0].Lokacija;

                } catch {
                    PBSlikaRecepta.Image = Properties.Resources.food;
                }
                IspuniPodatkeoReceptu(PratiPrikaz - 2);
            }
        }

        private void PBSlika3_Click(object sender, EventArgs e) {
            if (PBSlika3.Image != null) {
                PANOznacenaFotografija.Show();
                PANOznacenaFotografija.Location = new Point(496, 25);
                LNazivRecepta.Text = TempRecepti[PratiPrikaz - 1].Naziv;
                BrojZaBrisanje = PratiPrikaz - 1;
                try {
                    PBSlikaRecepta.ImageLocation = TempRecepti[PratiPrikaz-1].FotografijeRecepta[0].Lokacija;

                } catch {
                    PBSlikaRecepta.Image = Properties.Resources.food;
                }
                IspuniPodatkeoReceptu(PratiPrikaz - 1);
            }
        }

        private void BIzbrisiRecept_Click(object sender, EventArgs e) { //brisanje recepta
            if (MessageBox.Show("Obrisati recept?", "Potvrda", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                SviRecepti.Remove(TempRecepti[BrojZaBrisanje]);
                SqlKonekcija.DeleteRecept(TempRecepti[BrojZaBrisanje].Id);
                TempRecepti.Remove(TempRecepti[BrojZaBrisanje]);
                RefreshUC();
                MessageBox.Show("Recept obrisan.");
            }
        }
    }
}
