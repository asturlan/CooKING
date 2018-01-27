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
    public partial class UCKuhajRezultatiPretrage : UserControl {
        UCKuhajPretPoNam partnerPPN; //partner je onaj prozor u kojem biramo namirnice za pretragu i filtere...treba nam da dohvatimo listu  SviRecepti 
        List<ReceptFilter> rf = new List<ReceptFilter>(); 
        List<PomocnaNamirnice> pn = new List<PomocnaNamirnice>(); //za popunjavanje LBNamuReceptu1
        Recepti recept; //odabrani recept za prikaz(detalji)

        //KONSTRUKTOR
        public UCKuhajRezultatiPretrage() {
            InitializeComponent();
        }
        //METODE-PARTNER
        public void LoadPartner(UCKuhajPretPoNam s) => partnerPPN = s; 
        public void GetRF(List<ReceptFilter> rfi) { rf = rfi; } //poziva se iz form1 kako bi se popunila lista<ReceptFilter> koji se prikazuju u rezultatima pretrage


        //METODE

        public void IspuniLVRezultata() {
            LWRezultatiPretrage.Items.Clear();
            string str="Nedostaju: ";
            foreach (ReceptFilter f in rf) {
                if (f.ImaSve == true) {
                    ListViewItem i = new ListViewItem("Ima sve");
                    i.BackColor = Color.YellowGreen;
                    i.SubItems.Add(f.Naziv);
                    string s="";
                    foreach (string j in f.ImaNamirnice) s = s + j + ", ";
                    i.SubItems.Add(s);
                    i.SubItems.Add("Ni jedna namirnica ne nedostaje");
                    LWRezultatiPretrage.Items.Add(i);
                } 
            }
            foreach(ReceptFilter f in rf) {
                str = "Nedostaju: ";
                if (f.ImaSve == false) {
                    ListViewItem j = new ListViewItem("Nema sve");
                    j.BackColor = Color.Gold;
                    j.SubItems.Add(f.Naziv);
                    string m = "";
                    foreach (string g in f.ImaNamirnice) m = m + g + ", ";
                    j.SubItems.Add(m);
                    foreach (Namirnice n in f.NedostajuNam) {
                        str = str + n.Naziv + ", ";
                    }
                    j.SubItems.Add(str);
                    LWRezultatiPretrage.Items.Add(j);
                }
            }
            LWRezultatiPretrage.Items[0].Selected = true;
            LWRezultatiPretrage.Select();                
        }

        private void PronadjiRecept() {
            string s = LWRezultatiPretrage.SelectedItems[0].SubItems[1].Text;
            foreach(Recepti r in partnerPPN.partner.SviRecepti) {
                if (r.Naziv == s) {
                    recept = r;
                    break;
                }
            }
        }
        private void IspuniPodatkeoReceptu() {
            PronadjiRecept();
            LWSviKoraci1.Items.Clear();
            foreach (Koraci k in recept.KoraciRecepta) {
                ListViewItem n = new ListViewItem((k.BrojKoraka).ToString());
                n.SubItems.Add(k.OpisKoraka);
                LWSviKoraci1.Items.Add(n);
            }
            pn.Clear();
            foreach (Namirnice n in recept.NamirniceRecepta) {
                foreach (Sastavnica s in partnerPPN.partner.SveSastavnice) {
                    if (s.ReceptId == recept.Id && s.NamirnicaId == n.Id) {
                        PomocnaNamirnice p = new PomocnaNamirnice(n.Naziv, s.Kolicina, n.Mjera);
                        pn.Add(p);
                        break;
                    }
                }
            }
            LBNamUReceptu1.DataSource = null;
            LBNamUReceptu1.DataSource = pn;
            LBNamUReceptu1.DisplayMember = "Display";
            
            label7.Text = recept.VrstaJela.ToString();
            int r = (int)recept.VrstaJela;
            if (r == 0) label2.Text = ((Enumeracije.EPredjelo)recept.PodvrstaJela).ToString();
            else if (r == 1) label2.Text = ((Enumeracije.EGlavnoJelo)recept.PodvrstaJela).ToString();
            else if (r == 2) label2.Text = ((Enumeracije.EDesert)recept.PodvrstaJela).ToString();
            label3.Text = recept.VrijemeKuhanja.ToString();
            label4.Text = recept.Tezina.ToString();
            label5.Text = recept.BrojServiranja.ToString();
            if (recept.PotrebnoKuhanje == true) label6.Text = "Da";
            else label6.Text = "Ne";
            label1.Text = recept.Naziv;
            try {
                PBSlikaRecepta.SizeMode = PictureBoxSizeMode.StretchImage;
                PBSlikaRecepta.ImageLocation = recept.FotografijeRecepta[0].Lokacija;
            }catch{
                PBSlikaRecepta.SizeMode = PictureBoxSizeMode.CenterImage;
                PBSlikaRecepta.Image = Properties.Resources.food;
            }
        }

        //EVENTI
        private void BNatrag_Click(object sender, EventArgs e) {
            partnerPPN.partner.caller.PostaviGoreUCKuhajPretPoNam();
        }

        private void LWSviKoraci1_SelectedIndexChanged(object sender, EventArgs e) {
            if (LWRezultatiPretrage.SelectedItems.Count > 0) {
                IspuniPodatkeoReceptu(); 
            }
        }

        private void BKuhaj_Click(object sender, EventArgs e) {
            Kuhanje f = new Kuhanje(recept, partnerPPN);
            f.ShowDialog();  
        }
    }
}
