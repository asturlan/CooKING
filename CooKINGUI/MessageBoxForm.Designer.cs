namespace CooKINGUI {
    partial class MessageBoxForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxForm));
            this.BOk = new System.Windows.Forms.Button();
            this.LPoruka = new System.Windows.Forms.Label();
            this.P1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BOk
            // 
            this.BOk.BackColor = System.Drawing.Color.SeaGreen;
            this.BOk.FlatAppearance.BorderSize = 0;
            this.BOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BOk.Font = new System.Drawing.Font("Mass Effect Game 123", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOk.ForeColor = System.Drawing.Color.Gold;
            this.BOk.Location = new System.Drawing.Point(329, 264);
            this.BOk.Name = "BOk";
            this.BOk.Size = new System.Drawing.Size(101, 33);
            this.BOk.TabIndex = 1;
            this.BOk.Text = "OK";
            this.BOk.UseVisualStyleBackColor = false;
            this.BOk.Click += new System.EventHandler(this.BOk_Click);
            // 
            // LPoruka
            // 
            this.LPoruka.AutoSize = true;
            this.LPoruka.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LPoruka.ForeColor = System.Drawing.Color.Khaki;
            this.LPoruka.Location = new System.Drawing.Point(128, 258);
            this.LPoruka.Name = "LPoruka";
            this.LPoruka.Size = new System.Drawing.Size(179, 39);
            this.LPoruka.TabIndex = 2;
            this.LPoruka.Text = "Jelo je gotovo!";
            this.LPoruka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P1
            // 
            this.P1.BackColor = System.Drawing.Color.SeaGreen;
            this.P1.Location = new System.Drawing.Point(0, 0);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(10, 313);
            this.P1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Location = new System.Drawing.Point(436, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 313);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Location = new System.Drawing.Point(9, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 10);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.Location = new System.Drawing.Point(7, 303);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 10);
            this.panel3.TabIndex = 6;
            // 
            // MessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(446, 313);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.LPoruka);
            this.Controls.Add(this.BOk);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBoxForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBoxForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BOk;
        private System.Windows.Forms.Label LPoruka;
        private System.Windows.Forms.Panel P1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}