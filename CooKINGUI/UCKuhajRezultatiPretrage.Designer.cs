namespace CooKINGUI {
    partial class UCKuhajRezultatiPretrage {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCKuhajRezultatiPretrage));
            this.BNatrag = new System.Windows.Forms.Button();
            this.LWRezultatiPretrage = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PBSlikaRecepta = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LPotrebnoKuhanje1 = new System.Windows.Forms.Label();
            this.LBrojServiranja1 = new System.Windows.Forms.Label();
            this.LTezina1 = new System.Windows.Forms.Label();
            this.LVrijemePripreme1 = new System.Windows.Forms.Label();
            this.LPodvrstaJela1 = new System.Windows.Forms.Label();
            this.LVrstaJela1 = new System.Windows.Forms.Label();
            this.LBNamUReceptu1 = new System.Windows.Forms.ListBox();
            this.LWSviKoraci1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LRezultatiPretrage = new System.Windows.Forms.Label();
            this.BKuhaj = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.PBSlikaRecepta)).BeginInit();
            this.SuspendLayout();
            // 
            // BNatrag
            // 
            this.BNatrag.BackColor = System.Drawing.Color.SeaGreen;
            this.BNatrag.FlatAppearance.BorderSize = 0;
            this.BNatrag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BNatrag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNatrag.Font = new System.Drawing.Font("Mass Effect Game 123", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNatrag.ForeColor = System.Drawing.Color.Gold;
            this.BNatrag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BNatrag.Location = new System.Drawing.Point(12, 14);
            this.BNatrag.Name = "BNatrag";
            this.BNatrag.Size = new System.Drawing.Size(155, 35);
            this.BNatrag.TabIndex = 21;
            this.BNatrag.Text = "Natrag";
            this.BNatrag.UseVisualStyleBackColor = false;
            this.BNatrag.Click += new System.EventHandler(this.BNatrag_Click);
            // 
            // LWRezultatiPretrage
            // 
            this.LWRezultatiPretrage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LWRezultatiPretrage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader6,
            this.columnHeader3});
            this.LWRezultatiPretrage.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic);
            this.LWRezultatiPretrage.ForeColor = System.Drawing.Color.Black;
            this.LWRezultatiPretrage.FullRowSelect = true;
            this.LWRezultatiPretrage.GridLines = true;
            this.LWRezultatiPretrage.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LWRezultatiPretrage.Location = new System.Drawing.Point(12, 75);
            this.LWRezultatiPretrage.MultiSelect = false;
            this.LWRezultatiPretrage.Name = "LWRezultatiPretrage";
            this.LWRezultatiPretrage.Size = new System.Drawing.Size(960, 144);
            this.LWRezultatiPretrage.TabIndex = 22;
            this.LWRezultatiPretrage.UseCompatibleStateImageBehavior = false;
            this.LWRezultatiPretrage.View = System.Windows.Forms.View.Details;
            this.LWRezultatiPretrage.SelectedIndexChanged += new System.EventHandler(this.LWSviKoraci1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Status";
            this.columnHeader1.Width = 201;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv recepta";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Namirnice koje nedostaju";
            this.columnHeader3.Width = 209;
            // 
            // PBSlikaRecepta
            // 
            this.PBSlikaRecepta.Image = global::CooKINGUI.Properties.Resources.food;
            this.PBSlikaRecepta.Location = new System.Drawing.Point(366, 250);
            this.PBSlikaRecepta.Name = "PBSlikaRecepta";
            this.PBSlikaRecepta.Size = new System.Drawing.Size(265, 233);
            this.PBSlikaRecepta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBSlikaRecepta.TabIndex = 23;
            this.PBSlikaRecepta.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(12, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(926, 341);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(926, 323);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(926, 305);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(926, 287);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(926, 269);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(926, 251);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "1";
            // 
            // LPotrebnoKuhanje1
            // 
            this.LPotrebnoKuhanje1.AutoSize = true;
            this.LPotrebnoKuhanje1.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LPotrebnoKuhanje1.ForeColor = System.Drawing.Color.Gold;
            this.LPotrebnoKuhanje1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LPotrebnoKuhanje1.Location = new System.Drawing.Point(807, 341);
            this.LPotrebnoKuhanje1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LPotrebnoKuhanje1.Name = "LPotrebnoKuhanje1";
            this.LPotrebnoKuhanje1.Size = new System.Drawing.Size(121, 20);
            this.LPotrebnoKuhanje1.TabIndex = 49;
            this.LPotrebnoKuhanje1.Text = "Potrebno kuhanje:";
            // 
            // LBrojServiranja1
            // 
            this.LBrojServiranja1.AutoSize = true;
            this.LBrojServiranja1.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBrojServiranja1.ForeColor = System.Drawing.Color.Gold;
            this.LBrojServiranja1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LBrojServiranja1.Location = new System.Drawing.Point(807, 323);
            this.LBrojServiranja1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBrojServiranja1.Name = "LBrojServiranja1";
            this.LBrojServiranja1.Size = new System.Drawing.Size(102, 20);
            this.LBrojServiranja1.TabIndex = 48;
            this.LBrojServiranja1.Text = "Broj serviranja:";
            // 
            // LTezina1
            // 
            this.LTezina1.AutoSize = true;
            this.LTezina1.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LTezina1.ForeColor = System.Drawing.Color.Gold;
            this.LTezina1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LTezina1.Location = new System.Drawing.Point(807, 305);
            this.LTezina1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTezina1.Name = "LTezina1";
            this.LTezina1.Size = new System.Drawing.Size(111, 20);
            this.LTezina1.TabIndex = 47;
            this.LTezina1.Text = "Tezina pripreme:";
            // 
            // LVrijemePripreme1
            // 
            this.LVrijemePripreme1.AutoSize = true;
            this.LVrijemePripreme1.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LVrijemePripreme1.ForeColor = System.Drawing.Color.Gold;
            this.LVrijemePripreme1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LVrijemePripreme1.Location = new System.Drawing.Point(807, 287);
            this.LVrijemePripreme1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LVrijemePripreme1.Name = "LVrijemePripreme1";
            this.LVrijemePripreme1.Size = new System.Drawing.Size(117, 20);
            this.LVrijemePripreme1.TabIndex = 46;
            this.LVrijemePripreme1.Text = "Vrijeme pripreme:";
            // 
            // LPodvrstaJela1
            // 
            this.LPodvrstaJela1.AutoSize = true;
            this.LPodvrstaJela1.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LPodvrstaJela1.ForeColor = System.Drawing.Color.Gold;
            this.LPodvrstaJela1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LPodvrstaJela1.Location = new System.Drawing.Point(807, 269);
            this.LPodvrstaJela1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LPodvrstaJela1.Name = "LPodvrstaJela1";
            this.LPodvrstaJela1.Size = new System.Drawing.Size(91, 20);
            this.LPodvrstaJela1.TabIndex = 45;
            this.LPodvrstaJela1.Text = "Podvrsta jela:";
            // 
            // LVrstaJela1
            // 
            this.LVrstaJela1.AutoSize = true;
            this.LVrstaJela1.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LVrstaJela1.ForeColor = System.Drawing.Color.Gold;
            this.LVrstaJela1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LVrstaJela1.Location = new System.Drawing.Point(807, 251);
            this.LVrstaJela1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LVrstaJela1.Name = "LVrstaJela1";
            this.LVrstaJela1.Size = new System.Drawing.Size(71, 20);
            this.LVrstaJela1.TabIndex = 44;
            this.LVrstaJela1.Text = "Vrsta jela:";
            // 
            // LBNamUReceptu1
            // 
            this.LBNamUReceptu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LBNamUReceptu1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LBNamUReceptu1.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBNamUReceptu1.ForeColor = System.Drawing.Color.YellowGreen;
            this.LBNamUReceptu1.FormattingEnabled = true;
            this.LBNamUReceptu1.ItemHeight = 20;
            this.LBNamUReceptu1.Location = new System.Drawing.Point(646, 250);
            this.LBNamUReceptu1.Name = "LBNamUReceptu1";
            this.LBNamUReceptu1.Size = new System.Drawing.Size(154, 140);
            this.LBNamUReceptu1.Sorted = true;
            this.LBNamUReceptu1.TabIndex = 43;
            // 
            // LWSviKoraci1
            // 
            this.LWSviKoraci1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LWSviKoraci1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.LWSviKoraci1.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic);
            this.LWSviKoraci1.ForeColor = System.Drawing.Color.YellowGreen;
            this.LWSviKoraci1.FullRowSelect = true;
            this.LWSviKoraci1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LWSviKoraci1.Location = new System.Drawing.Point(12, 252);
            this.LWSviKoraci1.MultiSelect = false;
            this.LWSviKoraci1.Name = "LWSviKoraci1";
            this.LWSviKoraci1.Size = new System.Drawing.Size(337, 229);
            this.LWSviKoraci1.TabIndex = 42;
            this.LWSviKoraci1.UseCompatibleStateImageBehavior = false;
            this.LWSviKoraci1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Redni broj";
            this.columnHeader4.Width = 76;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Opis";
            this.columnHeader5.Width = 257;
            // 
            // LRezultatiPretrage
            // 
            this.LRezultatiPretrage.AutoSize = true;
            this.LRezultatiPretrage.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LRezultatiPretrage.ForeColor = System.Drawing.Color.Gold;
            this.LRezultatiPretrage.Location = new System.Drawing.Point(412, 47);
            this.LRezultatiPretrage.Name = "LRezultatiPretrage";
            this.LRezultatiPretrage.Size = new System.Drawing.Size(169, 25);
            this.LRezultatiPretrage.TabIndex = 56;
            this.LRezultatiPretrage.Text = "Rezultati Pretrage";
            // 
            // BKuhaj
            // 
            this.BKuhaj.BackColor = System.Drawing.Color.SeaGreen;
            this.BKuhaj.FlatAppearance.BorderSize = 0;
            this.BKuhaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BKuhaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BKuhaj.Font = new System.Drawing.Font("Mass Effect Game 123", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BKuhaj.ForeColor = System.Drawing.Color.Gold;
            this.BKuhaj.Image = ((System.Drawing.Image)(resources.GetObject("BKuhaj.Image")));
            this.BKuhaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BKuhaj.Location = new System.Drawing.Point(646, 408);
            this.BKuhaj.Name = "BKuhaj";
            this.BKuhaj.Size = new System.Drawing.Size(326, 73);
            this.BKuhaj.TabIndex = 59;
            this.BKuhaj.Text = "Kuhaj";
            this.BKuhaj.UseVisualStyleBackColor = false;
            this.BKuhaj.Click += new System.EventHandler(this.BKuhaj_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Location = new System.Drawing.Point(366, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 5);
            this.panel1.TabIndex = 60;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Location = new System.Drawing.Point(366, 478);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 5);
            this.panel2.TabIndex = 61;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.Location = new System.Drawing.Point(362, 250);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 233);
            this.panel3.TabIndex = 62;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaGreen;
            this.panel4.Location = new System.Drawing.Point(626, 250);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 233);
            this.panel4.TabIndex = 63;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Koristi";
            this.columnHeader6.Width = 463;
            // 
            // UCKuhajRezultatiPretrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BKuhaj);
            this.Controls.Add(this.PBSlikaRecepta);
            this.Controls.Add(this.LRezultatiPretrage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LPotrebnoKuhanje1);
            this.Controls.Add(this.LBrojServiranja1);
            this.Controls.Add(this.LTezina1);
            this.Controls.Add(this.LVrijemePripreme1);
            this.Controls.Add(this.LPodvrstaJela1);
            this.Controls.Add(this.LVrstaJela1);
            this.Controls.Add(this.LBNamUReceptu1);
            this.Controls.Add(this.LWSviKoraci1);
            this.Controls.Add(this.LWRezultatiPretrage);
            this.Controls.Add(this.BNatrag);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCKuhajRezultatiPretrage";
            this.Size = new System.Drawing.Size(990, 488);
            ((System.ComponentModel.ISupportInitialize)(this.PBSlikaRecepta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BNatrag;
        private System.Windows.Forms.ListView LWRezultatiPretrage;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox PBSlikaRecepta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LPotrebnoKuhanje1;
        private System.Windows.Forms.Label LBrojServiranja1;
        private System.Windows.Forms.Label LTezina1;
        private System.Windows.Forms.Label LVrijemePripreme1;
        private System.Windows.Forms.Label LPodvrstaJela1;
        private System.Windows.Forms.Label LVrstaJela1;
        private System.Windows.Forms.ListBox LBNamUReceptu1;
        private System.Windows.Forms.ListView LWSviKoraci1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label LRezultatiPretrage;
        private System.Windows.Forms.Button BKuhaj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}
