using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CooKINGUI {
    public partial class MessageBoxForm : Form {
        Kuhanje ku;
        public MessageBoxForm(Kuhanje k) {
            InitializeComponent();
            ku = k;
            ku.t.Stop();
        }

        private void BOk_Click(object sender, EventArgs e) {
            this.Close();
            ku.Close();

        }
    }
}
