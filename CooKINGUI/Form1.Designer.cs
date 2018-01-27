namespace CooKINGUI {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BExit = new System.Windows.Forms.Button();
            this.BMinimize = new System.Windows.Forms.Button();
            this.BRecepti = new System.Windows.Forms.Button();
            this.BKuhaj = new System.Windows.Forms.Button();
            this.BSviRecepti = new System.Windows.Forms.Button();
            this.BNamirnice = new System.Windows.Forms.Button();
            this.ucKuhajRezultatiPretrage1 = new CooKINGUI.UCKuhajRezultatiPretrage();
            this.ucKuhajPretPoNam1 = new CooKINGUI.UCKuhajPretPoNam();
            this.ucNamirnice1 = new CooKINGUI.UCNamirnice();
            this.ucSviRecepti1 = new CooKINGUI.UCSviRecepti();
            this.BProfil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BExit
            // 
            this.BExit.FlatAppearance.BorderSize = 0;
            this.BExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BExit.Image = ((System.Drawing.Image)(resources.GetObject("BExit.Image")));
            this.BExit.Location = new System.Drawing.Point(966, -1);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(29, 35);
            this.BExit.TabIndex = 0;
            this.BExit.UseVisualStyleBackColor = true;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // BMinimize
            // 
            this.BMinimize.FlatAppearance.BorderSize = 0;
            this.BMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMinimize.Image = ((System.Drawing.Image)(resources.GetObject("BMinimize.Image")));
            this.BMinimize.Location = new System.Drawing.Point(929, -1);
            this.BMinimize.Name = "BMinimize";
            this.BMinimize.Size = new System.Drawing.Size(31, 34);
            this.BMinimize.TabIndex = 1;
            this.BMinimize.UseVisualStyleBackColor = true;
            this.BMinimize.Click += new System.EventHandler(this.BMinimize_Click);
            // 
            // BRecepti
            // 
            this.BRecepti.BackColor = System.Drawing.Color.SeaGreen;
            this.BRecepti.FlatAppearance.BorderSize = 0;
            this.BRecepti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BRecepti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BRecepti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRecepti.Font = new System.Drawing.Font("Mass Effect Game 123", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRecepti.ForeColor = System.Drawing.Color.Gold;
            this.BRecepti.Image = ((System.Drawing.Image)(resources.GetObject("BRecepti.Image")));
            this.BRecepti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BRecepti.Location = new System.Drawing.Point(5, 40);
            this.BRecepti.Name = "BRecepti";
            this.BRecepti.Size = new System.Drawing.Size(325, 60);
            this.BRecepti.TabIndex = 4;
            this.BRecepti.Text = " Recepti";
            this.BRecepti.UseVisualStyleBackColor = false;
            this.BRecepti.Click += new System.EventHandler(this.BRecepti_Click);
            // 
            // BKuhaj
            // 
            this.BKuhaj.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BKuhaj.BackColor = System.Drawing.Color.SeaGreen;
            this.BKuhaj.FlatAppearance.BorderSize = 0;
            this.BKuhaj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BKuhaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BKuhaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BKuhaj.Font = new System.Drawing.Font("Mass Effect Game 123", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BKuhaj.ForeColor = System.Drawing.Color.Gold;
            this.BKuhaj.Image = ((System.Drawing.Image)(resources.GetObject("BKuhaj.Image")));
            this.BKuhaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BKuhaj.Location = new System.Drawing.Point(336, 40);
            this.BKuhaj.Name = "BKuhaj";
            this.BKuhaj.Size = new System.Drawing.Size(328, 60);
            this.BKuhaj.TabIndex = 5;
            this.BKuhaj.Text = "Kuhaj";
            this.BKuhaj.UseVisualStyleBackColor = false;
            this.BKuhaj.Click += new System.EventHandler(this.BKuhaj_Click);
            // 
            // BSviRecepti
            // 
            this.BSviRecepti.BackColor = System.Drawing.Color.SeaGreen;
            this.BSviRecepti.FlatAppearance.BorderSize = 0;
            this.BSviRecepti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BSviRecepti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BSviRecepti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSviRecepti.Font = new System.Drawing.Font("Mass Effect Game 123", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSviRecepti.ForeColor = System.Drawing.Color.Gold;
            this.BSviRecepti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSviRecepti.Location = new System.Drawing.Point(5, 110);
            this.BSviRecepti.Name = "BSviRecepti";
            this.BSviRecepti.Size = new System.Drawing.Size(493, 34);
            this.BSviRecepti.TabIndex = 7;
            this.BSviRecepti.Text = "Svi recepti";
            this.BSviRecepti.UseVisualStyleBackColor = false;
            this.BSviRecepti.Click += new System.EventHandler(this.BSviRecepti_Click);
            // 
            // BNamirnice
            // 
            this.BNamirnice.BackColor = System.Drawing.Color.SeaGreen;
            this.BNamirnice.FlatAppearance.BorderSize = 0;
            this.BNamirnice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BNamirnice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BNamirnice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNamirnice.Font = new System.Drawing.Font("Mass Effect Game 123", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNamirnice.ForeColor = System.Drawing.Color.Gold;
            this.BNamirnice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BNamirnice.Location = new System.Drawing.Point(504, 110);
            this.BNamirnice.Name = "BNamirnice";
            this.BNamirnice.Size = new System.Drawing.Size(491, 34);
            this.BNamirnice.TabIndex = 8;
            this.BNamirnice.Text = "Namirnice";
            this.BNamirnice.UseVisualStyleBackColor = false;
            this.BNamirnice.Click += new System.EventHandler(this.BNamirnice_Click);
            // 
            // ucKuhajRezultatiPretrage1
            // 
            this.ucKuhajRezultatiPretrage1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ucKuhajRezultatiPretrage1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ucKuhajRezultatiPretrage1.Location = new System.Drawing.Point(5, 160);
            this.ucKuhajRezultatiPretrage1.Margin = new System.Windows.Forms.Padding(4);
            this.ucKuhajRezultatiPretrage1.Name = "ucKuhajRezultatiPretrage1";
            this.ucKuhajRezultatiPretrage1.Size = new System.Drawing.Size(990, 488);
            this.ucKuhajRezultatiPretrage1.TabIndex = 12;
            // 
            // ucKuhajPretPoNam1
            // 
            this.ucKuhajPretPoNam1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ucKuhajPretPoNam1.Location = new System.Drawing.Point(5, 160);
            this.ucKuhajPretPoNam1.Name = "ucKuhajPretPoNam1";
            this.ucKuhajPretPoNam1.Size = new System.Drawing.Size(990, 488);
            this.ucKuhajPretPoNam1.TabIndex = 11;
            // 
            // ucNamirnice1
            // 
            this.ucNamirnice1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ucNamirnice1.Location = new System.Drawing.Point(5, 160);
            this.ucNamirnice1.Name = "ucNamirnice1";
            this.ucNamirnice1.Size = new System.Drawing.Size(990, 478);
            this.ucNamirnice1.TabIndex = 10;
            // 
            // ucSviRecepti1
            // 
            this.ucSviRecepti1.AutoScroll = true;
            this.ucSviRecepti1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ucSviRecepti1.Location = new System.Drawing.Point(5, 160);
            this.ucSviRecepti1.MaximumSize = new System.Drawing.Size(990, 488);
            this.ucSviRecepti1.Name = "ucSviRecepti1";
            this.ucSviRecepti1.Size = new System.Drawing.Size(990, 488);
            this.ucSviRecepti1.TabIndex = 9;
            // 
            // BProfil
            // 
            this.BProfil.BackColor = System.Drawing.Color.SeaGreen;
            this.BProfil.FlatAppearance.BorderSize = 0;
            this.BProfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BProfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BProfil.Font = new System.Drawing.Font("Mass Effect Game 123", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BProfil.ForeColor = System.Drawing.Color.Gold;
            this.BProfil.Image = ((System.Drawing.Image)(resources.GetObject("BProfil.Image")));
            this.BProfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BProfil.Location = new System.Drawing.Point(670, 40);
            this.BProfil.Name = "BProfil";
            this.BProfil.Size = new System.Drawing.Size(325, 60);
            this.BProfil.TabIndex = 6;
            this.BProfil.Text = "Mini Game";
            this.BProfil.UseVisualStyleBackColor = false;
            this.BProfil.Click += new System.EventHandler(this.BProfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.ucKuhajRezultatiPretrage1);
            this.Controls.Add(this.ucKuhajPretPoNam1);
            this.Controls.Add(this.ucNamirnice1);
            this.Controls.Add(this.ucSviRecepti1);
            this.Controls.Add(this.BNamirnice);
            this.Controls.Add(this.BSviRecepti);
            this.Controls.Add(this.BProfil);
            this.Controls.Add(this.BKuhaj);
            this.Controls.Add(this.BRecepti);
            this.Controls.Add(this.BMinimize);
            this.Controls.Add(this.BExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BExit;
        private System.Windows.Forms.Button BMinimize;
        private System.Windows.Forms.Button BRecepti;
        private System.Windows.Forms.Button BKuhaj;
        private System.Windows.Forms.Button BSviRecepti;
        private System.Windows.Forms.Button BNamirnice;
        private UCSviRecepti ucSviRecepti1;
        private UCNamirnice ucNamirnice1;
        private UCKuhajPretPoNam ucKuhajPretPoNam1;
        private UCKuhajRezultatiPretrage ucKuhajRezultatiPretrage1;
        private System.Windows.Forms.Button BProfil;
    }
}

