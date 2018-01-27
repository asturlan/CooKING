namespace CooKINGUI {
    partial class UCNamirnice {
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
            this.BDodajNamirnicu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BIzbrisiOdabrano = new System.Windows.Forms.Button();
            this.LWSveNamirnice = new System.Windows.Forms.ListView();
            this.Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mjera = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vrsta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // BDodajNamirnicu
            // 
            this.BDodajNamirnicu.BackColor = System.Drawing.Color.SeaGreen;
            this.BDodajNamirnicu.FlatAppearance.BorderSize = 0;
            this.BDodajNamirnicu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BDodajNamirnicu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDodajNamirnicu.Font = new System.Drawing.Font("Mass Effect Game 123", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDodajNamirnicu.ForeColor = System.Drawing.Color.Gold;
            this.BDodajNamirnicu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BDodajNamirnicu.Location = new System.Drawing.Point(14, 15);
            this.BDodajNamirnicu.Name = "BDodajNamirnicu";
            this.BDodajNamirnicu.Size = new System.Drawing.Size(223, 44);
            this.BDodajNamirnicu.TabIndex = 9;
            this.BDodajNamirnicu.Text = "Dodaj Namirnicu";
            this.BDodajNamirnicu.UseVisualStyleBackColor = false;
            this.BDodajNamirnicu.Click += new System.EventHandler(this.BDodajNamirnicu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(149, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sve Namirnice";
            // 
            // BIzbrisiOdabrano
            // 
            this.BIzbrisiOdabrano.BackColor = System.Drawing.Color.SeaGreen;
            this.BIzbrisiOdabrano.FlatAppearance.BorderSize = 0;
            this.BIzbrisiOdabrano.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BIzbrisiOdabrano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BIzbrisiOdabrano.Font = new System.Drawing.Font("Mass Effect Game 123", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIzbrisiOdabrano.ForeColor = System.Drawing.Color.Gold;
            this.BIzbrisiOdabrano.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BIzbrisiOdabrano.Location = new System.Drawing.Point(386, 391);
            this.BIzbrisiOdabrano.Name = "BIzbrisiOdabrano";
            this.BIzbrisiOdabrano.Size = new System.Drawing.Size(223, 44);
            this.BIzbrisiOdabrano.TabIndex = 16;
            this.BIzbrisiOdabrano.Text = "Izbrisi odabranu namirnicu";
            this.BIzbrisiOdabrano.UseVisualStyleBackColor = false;
            this.BIzbrisiOdabrano.Click += new System.EventHandler(this.BIzbrisiOdabrano_Click);
            // 
            // LWSveNamirnice
            // 
            this.LWSveNamirnice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LWSveNamirnice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LWSveNamirnice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naziv,
            this.Mjera,
            this.Vrsta,
            this.columnHeader1});
            this.LWSveNamirnice.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LWSveNamirnice.ForeColor = System.Drawing.Color.YellowGreen;
            this.LWSveNamirnice.FullRowSelect = true;
            this.LWSveNamirnice.Location = new System.Drawing.Point(153, 113);
            this.LWSveNamirnice.MultiSelect = false;
            this.LWSveNamirnice.Name = "LWSveNamirnice";
            this.LWSveNamirnice.Size = new System.Drawing.Size(687, 254);
            this.LWSveNamirnice.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.LWSveNamirnice.TabIndex = 17;
            this.LWSveNamirnice.UseCompatibleStateImageBehavior = false;
            this.LWSveNamirnice.View = System.Windows.Forms.View.Details;
            // 
            // Naziv
            // 
            this.Naziv.Text = "Naziv";
            this.Naziv.Width = 289;
            // 
            // Mjera
            // 
            this.Mjera.Text = "Mjera";
            this.Mjera.Width = 128;
            // 
            // Vrsta
            // 
            this.Vrsta.Text = "Vrsta";
            this.Vrsta.Width = 169;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Must-Have";
            this.columnHeader1.Width = 217;
            // 
            // UCNamirnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.LWSveNamirnice);
            this.Controls.Add(this.BIzbrisiOdabrano);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BDodajNamirnicu);
            this.Name = "UCNamirnice";
            this.Size = new System.Drawing.Size(990, 488);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BDodajNamirnicu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BIzbrisiOdabrano;
        private System.Windows.Forms.ColumnHeader Naziv;
        private System.Windows.Forms.ColumnHeader Mjera;
        private System.Windows.Forms.ColumnHeader Vrsta;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView LWSveNamirnice;
    }
}
