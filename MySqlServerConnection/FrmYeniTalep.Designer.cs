namespace MySqlServerConnection
{
    partial class FrmYeniTalep
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblX = new System.Windows.Forms.Label();
            this.lblTalepGeldi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTalepAdet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGecenSure = new System.Windows.Forms.Label();
            this.timerGecenSure = new System.Windows.Forms.Timer(this.components);
            this.lblKayanYazi = new System.Windows.Forms.Label();
            this.timerKayanYazi = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMinimal = new System.Windows.Forms.Label();
            this.lblEksi = new System.Windows.Forms.Label();
            this.lblEksilenTalepAdet = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblX.ForeColor = System.Drawing.Color.Black;
            this.lblX.Location = new System.Drawing.Point(467, 1);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(20, 20);
            this.lblX.TabIndex = 11;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // lblTalepGeldi
            // 
            this.lblTalepGeldi.AutoSize = true;
            this.lblTalepGeldi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTalepGeldi.Location = new System.Drawing.Point(40, 25);
            this.lblTalepGeldi.Name = "lblTalepGeldi";
            this.lblTalepGeldi.Size = new System.Drawing.Size(394, 31);
            this.lblTalepGeldi.TabIndex = 12;
            this.lblTalepGeldi.Text = "YENİ FORM TALEBİ GELDİ !";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Gelen Form Talebi Adedi";
            // 
            // lblTalepAdet
            // 
            this.lblTalepAdet.AutoSize = true;
            this.lblTalepAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTalepAdet.Location = new System.Drawing.Point(302, 76);
            this.lblTalepAdet.Name = "lblTalepAdet";
            this.lblTalepAdet.Size = new System.Drawing.Size(23, 25);
            this.lblTalepAdet.TabIndex = 14;
            this.lblTalepAdet.Text = "0";
            this.lblTalepAdet.Click += new System.EventHandler(this.lblTalepAdet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(40, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Geç. Süre(sn) / Geld. Saat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(278, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(278, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = ":";
            // 
            // lblGecenSure
            // 
            this.lblGecenSure.AutoSize = true;
            this.lblGecenSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGecenSure.Location = new System.Drawing.Point(302, 101);
            this.lblGecenSure.Name = "lblGecenSure";
            this.lblGecenSure.Size = new System.Drawing.Size(23, 25);
            this.lblGecenSure.TabIndex = 18;
            this.lblGecenSure.Text = "0";
            // 
            // timerGecenSure
            // 
            this.timerGecenSure.Interval = 1000;
            this.timerGecenSure.Tick += new System.EventHandler(this.timerGecenSure_Tick);
            // 
            // lblKayanYazi
            // 
            this.lblKayanYazi.AutoSize = true;
            this.lblKayanYazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayanYazi.Location = new System.Drawing.Point(2, 126);
            this.lblKayanYazi.Name = "lblKayanYazi";
            this.lblKayanYazi.Size = new System.Drawing.Size(472, 24);
            this.lblKayanYazi.TabIndex = 19;
            this.lblKayanYazi.Text = "Coded by İhsan                                                                  ";
            // 
            // timerKayanYazi
            // 
            this.timerKayanYazi.Tick += new System.EventHandler(this.timerKayanYazi_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lblMinimal);
            this.panel1.Controls.Add(this.lblX);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 22);
            this.panel1.TabIndex = 20;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // lblMinimal
            // 
            this.lblMinimal.AutoSize = true;
            this.lblMinimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMinimal.Location = new System.Drawing.Point(442, -3);
            this.lblMinimal.Name = "lblMinimal";
            this.lblMinimal.Size = new System.Drawing.Size(19, 25);
            this.lblMinimal.TabIndex = 25;
            this.lblMinimal.Text = "-";
            this.lblMinimal.Click += new System.EventHandler(this.lblMinimal_Click);
            // 
            // lblEksi
            // 
            this.lblEksi.AutoSize = true;
            this.lblEksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEksi.Location = new System.Drawing.Point(348, 76);
            this.lblEksi.Name = "lblEksi";
            this.lblEksi.Size = new System.Drawing.Size(19, 25);
            this.lblEksi.TabIndex = 21;
            this.lblEksi.Text = "-";
            this.lblEksi.Visible = false;
            // 
            // lblEksilenTalepAdet
            // 
            this.lblEksilenTalepAdet.AutoSize = true;
            this.lblEksilenTalepAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEksilenTalepAdet.Location = new System.Drawing.Point(363, 76);
            this.lblEksilenTalepAdet.Name = "lblEksilenTalepAdet";
            this.lblEksilenTalepAdet.Size = new System.Drawing.Size(23, 25);
            this.lblEksilenTalepAdet.TabIndex = 22;
            this.lblEksilenTalepAdet.Text = "0";
            this.lblEksilenTalepAdet.Visible = false;
            // 
            // FrmYeniTalep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(489, 159);
            this.Controls.Add(this.lblEksilenTalepAdet);
            this.Controls.Add(this.lblEksi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblKayanYazi);
            this.Controls.Add(this.lblGecenSure);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTalepAdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTalepGeldi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmYeniTalep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmYeniTalep";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmYeniTalep_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmYeniTalep_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblTalepGeldi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTalepAdet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGecenSure;
        private System.Windows.Forms.Timer timerGecenSure;
        private System.Windows.Forms.Label lblKayanYazi;
        private System.Windows.Forms.Timer timerKayanYazi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMinimal;
        private System.Windows.Forms.Label lblEksi;
        private System.Windows.Forms.Label lblEksilenTalepAdet;
    }
}