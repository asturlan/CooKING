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
using System.Media;
using System.IO;

namespace CooKINGUI {
    public partial class Kuhanje : Form {
        struct Odbrojavanje {
            public CheckBox b;
            public int vr;
        }

        UCKuhajPretPoNam callerPartner; //za komunikaciju sa UC-om(prozorom) koji prethodi ovom -> UCKuhajPretPoNam
        Recepti recept; //partner nam pri pozivu ovog prozora predaje recept kojeg je korisnik odabrao da želi kuhati. Treba nam da se ispuni sve na ekranu o njemu
        List<PomocnaNamirnice> pn=new List<PomocnaNamirnice> (); //treba za ispunjavanje sastojaka recepta
        int brojKoraka = 1; //prati broj koraka
        public Timer t = new Timer();    //timer za veliko vrijeme
        Timer odbroj = new Timer();     //timer za bilo koje odbrojavanje
        int h = 0, m = 0, s = 0;   //sati minute i sekunde za veliko vrijeme
        int h1 = 0, m1 = 0, s1 = 0;  //sati sekunde i minute za odbrojavanje
        string imeCHB = "CB"; int brCHB = 0;

        SoundPlayer player = new SoundPlayer(Properties.Resources.alarm1);  //player za zvuk kada timer odbroji
        
        List<CheckBox> ListOfCheckBox = new List<CheckBox>();  //sve što je u toj listi se prikazuje u LBKoraci
        List<Odbrojavanje> ListOdbrojavanje = new List<Odbrojavanje>();  //treba nam da znamo koji tajmer pokrenuti(koje vrijeme upisati u textbox dolje)


        //KONSTRUKTOR
        public Kuhanje(Recepti r, UCKuhajPretPoNam cp) {
            InitializeComponent();
            recept = r;
            callerPartner = cp;
            IspuniListuNamirnica();
            PopuniKorake();
            PopuniSavijetiIme();
            IspuniLWNamirnica();
            NamjestiCPBar();
            FLKoraciRecepta.Focus();
            TBTimer.Hide(); LTimer.Hide(); BOk.Hide(); LMinuts.Hide(); LMinute.Hide();
            odbroj.Interval = 1000;
            odbroj.Tick += new EventHandler(Ti_Tick);
            
        }

        //METODE

        private void OcistiForm() {
            FLKoraciRecepta.Controls.Clear();
            recept = null;
        }
        private void NamjestiCPBar() {
            CPBar1.Value = 0;
            CPBar1.Minimum = 0; CPBar1.Maximum = ListOfCheckBox.Count;
        }
        private void PopuniKorake() {
            foreach(Koraci k in recept.KoraciRecepta) {
                CheckBox novi = new CheckBox();
                
                novi.AutoSize = true;
                novi.Text = brojKoraka.ToString()+". "+k.OpisKoraka;
                novi.BackColor = Color.Transparent;
                novi.ForeColor = Color.Gold;  
                novi.Font= new Font("Monotype Corsiva",16,FontStyle.Regular);
                
                
                FLKoraciRecepta.Controls.Add(novi);
                brojKoraka++;
                novi.Click += new EventHandler(CB_Clicked);
                novi.CheckedChanged += new EventHandler(CB_CheckedOrUnchecked);
                ListOfCheckBox.Add(novi);
                if(k.Naputak != "") {
                    Label noviNap = new Label();
                    noviNap.AutoSize = true;
                    noviNap.Text = "    "+k.Naputak;
                    noviNap.Font = new Font("Monotype Corsiva", 16, FontStyle.Italic);
                    noviNap.Click += new EventHandler(Label_Clicked);
                    noviNap.BackColor = Color.Transparent;
                    noviNap.ForeColor = Color.LightBlue;
                    FLKoraciRecepta.Controls.Add(noviNap);
                }
                if (k.VrijemeIzvodenja > 0) {

                    Odbrojavanje nov = new Odbrojavanje();
                    
                    CheckBox ncb = new CheckBox();
                    ncb.Text = "Uključi odbrojavanje(" + k.VrijemeIzvodenja + " min)";
                    ncb.AutoSize = true;
                    ncb.BackColor = Color.Transparent;
                    ncb.Font = new Font("Monotype Corsiva", 16, FontStyle.Italic);
                    ncb.ForeColor = Color.DeepSkyBlue;
                    ncb.RightToLeft=RightToLeft.Yes;
                    ncb.Name = imeCHB + brCHB.ToString();
                    FLKoraciRecepta.Controls.Add(ncb);
                    ncb.Click += new EventHandler(CB_Clicked);
                    ncb.CheckedChanged += new EventHandler(PopuniLabelVrijeme);
                    
                    nov.b = ncb;
                    nov.vr = k.VrijemeIzvodenja;
                    ListOdbrojavanje.Add(nov);
                    
                }
                Panel p = new Panel();
                p.Size = new System.Drawing.Size(500, 5);
                p.BackColor = Color.MediumSeaGreen; 
                FLKoraciRecepta.Controls.Add(p);
            }
            FLKoraciRecepta.Focus();
        }

        private void PopuniSavijetiIme() {
            if(recept.Savijet!="" || recept.Savijet != null) {
                LSavijet1.Text = recept.Savijet;
                LSavijet1.Show(); LSavijet.Show();
            } else {
                LSavijet.Hide(); LSavijet1.Hide();
            }
            LNazivRecepta.Text = recept.Naziv;
        }

        private void IspuniListuNamirnica() {
            foreach (Namirnice n in recept.NamirniceRecepta) {
                foreach (Sastavnica s in callerPartner.partner.SveSastavnice) {
                    if (s.ReceptId == recept.Id && s.NamirnicaId == n.Id) {
                        PomocnaNamirnice p = new PomocnaNamirnice(n.Naziv, s.Kolicina, n.Mjera);
                        pn.Add(p);
                        break;
                    }
                }
            }
        }

        private void IspuniLWNamirnica() {
            LBNamUReceptu1.DataSource = null;
            LBNamUReceptu1.DataSource = pn;
            LBNamUReceptu1.DisplayMember = "Display";
        }



        //EVENTI

        private void Kuhanje_Load(object sender, EventArgs e) {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.T_Tick);
            t.Start();
            FLKoraciRecepta.Focus();
        }
        private void T_Tick(object sender, EventArgs e) {//custom event
            string time="";
            if (s == 59) {
                if (m < 59) {
                    m++;
                } else {
                    h++;
                    m = 0;
                }
                s = 0;
            }else if (s < 59) {
                s++;
            }
            if (h < 10) time += "0" + h;
            else time += h; time += ":";
            if (m < 10) time += "0" + m;
            else time += m; time += ":";
            if (s < 10) time += "0" + s;
            else time += s;
            LProtekloVrijeme.Text = time;

        }
        private void CB_Clicked(object sender, EventArgs e) {
            FLKoraciRecepta.Focus();
        }

        private void BOk_Click(object sender, EventArgs e) {
            int i;
            bool b = int.TryParse(TBTimer.Text, out i);
            if (b==false || i<1) {
                MessageBox.Show("Krivo postavljeno vrijeme.");
            } else {
                TBTimer.Hide();
                LMinuts.Hide();
                BOk.Hide();
                LMinute.Location = new Point(178, 448);
                LMinute.Show();
                
                TimeSpan ts = TimeSpan.FromMinutes(i);
                h1 = ts.Hours; m1 = ts.Minutes; s1 = ts.Seconds;
                odbroj.Start();
            }
        }

        private void BKraj_Click(object sender, EventArgs e) {
            MessageBoxForm f = new MessageBoxForm(this);
            f.Show();
        }

        private void BMiniGame_Click(object sender, EventArgs e) {
            MiniGameForm mgf = new MiniGameForm();
            mgf.ShowDialog();
        }

        private void CB_CheckedOrUnchecked(object sender, EventArgs e) { //custom event
            CheckBox b = (CheckBox)sender;
            if (b.Checked == true) {
                b.Font = new Font("Monotype Corsiva", 16, FontStyle.Strikeout);
                CPBar1.Value++;
                if (CPBar1.Value == CPBar1.Maximum) CPBar1.Text = "100%";
                else CPBar1.Text = (100 / ListOfCheckBox.Count * CPBar1.Value).ToString()+"%";
                
            }else if (b.Checked == false) {
                CPBar1.Value--;
                b.Font = new Font("Monotype Corsiva", 16, FontStyle.Regular);
                CPBar1.Text = (100 / ListOfCheckBox.Count * CPBar1.Value).ToString() + "%";
            }
        }
        private void Label_Clicked(object sender, EventArgs e) {//custom event
            Label l = (Label)sender;
            if (l.Font.Style.Equals(FontStyle.Italic)) {
                l.Font = new Font("Monotype Corsiva", 16, FontStyle.Strikeout);
            } else {
                l.Font = new Font("Monotype Corsiva", 16, FontStyle.Italic);
            }
            FLKoraciRecepta.Focus();
        }
        private void Ti_Tick(object sender, EventArgs e) { //custom event
            string time1 = "";
            s1--;
            if (s1 == -1) {
                m1--; s1 = 59;
            }
            if (m1 == -1) {
                h1--; m1 = 59;
            }
            if(h1==0 && m1==0 && s1 == 0) {
                odbroj.Stop();
                player.Play();
            }
            if (h1 < 10) time1 += "0" + h1;
            else time1 += h1; time1 += ":";
            if (m1 < 10) time1 += "0" + m1;
            else time1 += m1; time1 += ":";
            if (s1 < 10) time1 += "0" + s1;
            else time1 += s1;
            LMinute.Text = time1;
        }
        private void PopuniLabelVrijeme(object sender, EventArgs e) {//custom event
            CheckBox temp = (CheckBox)sender;
            if (temp.Checked == true) {
                foreach(Odbrojavanje o in ListOdbrojavanje) {
                    if (o.b.Name == temp.Name) TBTimer.Text = o.vr.ToString();
                }
                LTimer.Show();
                TBTimer.Show();  
                LMinuts.Show();
                BOk.Show();
                LMinute.Hide(); odbroj.Stop(); LMinute.Text = "00:00:00";
                h1 = 0; m1 = 0; s1 = 0;
            } else {
                LTimer.Hide();
                TBTimer.Hide();
                LMinuts.Hide();
                BOk.Hide();
                odbroj.Stop();
                LMinute.Hide();
                player.Stop();
            }
        }
        private void BNatrag_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Ako izađete iz kuhanja izgubiti ćete trenutni progres. Nastaviti?", "", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                OcistiForm();
                this.Close();
            }
        }
    }
}
