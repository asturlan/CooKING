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
    public partial class Form1 : Form {

        
        //Mouse Drag
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        //End: Mouse Drag


        //Konstruktor
        public Form1() {
            InitializeComponent();
            ucSviRecepti1.BringToFront();
            ucSviRecepti1.GetCaller(this);
            ucKuhajRezultatiPretrage1.LoadPartner(ucKuhajPretPoNam1);
        }

        
        //Eventi -> Buttons
    
        private void BRecepti_Click(object sender, EventArgs e) {
            ucSviRecepti1.BringToFront();
            
        }

        private void BNamirnice_Click(object sender, EventArgs e) {
            ucNamirnice1.BringToFront();
            ucNamirnice1.PopuniListuNamirnica();
            ucNamirnice1.UcitajUListView();
        }

        private void BSviRecepti_Click(object sender, EventArgs e) {
            ucSviRecepti1.BringToFront();
        }

        private void BKuhaj_Click(object sender, EventArgs e) {
            ucKuhajPretPoNam1.LoadPartner(ucSviRecepti1);
            ucNamirnice1.PopuniListuNamirnica();
            ucKuhajPretPoNam1.LoadPartner2(ucNamirnice1);
            ucKuhajPretPoNam1.PopuniLBNamirnica(); 
            ucKuhajPretPoNam1.BringToFront();
            
        }

        private void BProfil_Click(object sender, EventArgs e) {
            MiniGameForm mgf = new MiniGameForm();
            mgf.ShowDialog();
        }

        //Metode za postavljanje redosljeda UC-ova
        public void PostaviGoreUCKuhajRezultatiPretrage() {
            ucKuhajRezultatiPretrage1.BringToFront();
        }
        public void PostaviGoreUCKuhajPretPoNam() {
            ucKuhajPretPoNam1.BringToFront();
        }

        //metode za ispunjavanje liste u UCKuhajRezultatiPretrage. Mora biti tu jer jedino Form1 vidi sve UC-ove. Pomoću njega UC-ovi međusobno komuniciraju
        public void PredajRF(List<ReceptFilter>r) {
            ucKuhajRezultatiPretrage1.GetRF(r);
        }
        public void IspuniRFRez() {
            ucKuhajRezultatiPretrage1.IspuniLVRezultata();
        }

        // Eventi za buttone -> exit, smanji prozor...
        private void BExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        private void BMinimize_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //metode koje rjesavaju poziv za namirnice
        public void M1() {
            ucNamirnice1.PopuniListuNamirnica();
        }
        public void M2() {
            ucNamirnice1.UcitajUListView();
        }
    }
}
