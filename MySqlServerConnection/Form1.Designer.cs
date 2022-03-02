
namespace MySqlServerConnection
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBagla = new System.Windows.Forms.Button();
            this.btnDoldur = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TimerBas = new System.Windows.Forms.Timer(this.components);
            this.btnUyari = new System.Windows.Forms.Button();
            this.tbSaniye = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbTrue = new System.Windows.Forms.PictureBox();
            this.pbFalse = new System.Windows.Forms.PictureBox();
            this.TimerSaniye = new System.Windows.Forms.Timer(this.components);
            this.lblSaniye = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMinimal = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblListe = new System.Windows.Forms.Label();
            this.btnIslemDegistir = new System.Windows.Forms.Button();
            this.cbAFK = new System.Windows.Forms.CheckBox();
            this.tbAfkSifre = new System.Windows.Forms.TextBox();
            this.btnError = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFalse)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBagla
            // 
            this.btnBagla.BackColor = System.Drawing.Color.White;
            this.btnBagla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBagla.Location = new System.Drawing.Point(12, 35);
            this.btnBagla.Name = "btnBagla";
            this.btnBagla.Size = new System.Drawing.Size(123, 57);
            this.btnBagla.TabIndex = 0;
            this.btnBagla.Text = "Servere Bağlanmak İçin Tıkla";
            this.btnBagla.UseVisualStyleBackColor = false;
            this.btnBagla.Click += new System.EventHandler(this.btnBagla_Click);
            // 
            // btnDoldur
            // 
            this.btnDoldur.BackColor = System.Drawing.Color.Orange;
            this.btnDoldur.Enabled = false;
            this.btnDoldur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDoldur.Location = new System.Drawing.Point(12, 98);
            this.btnDoldur.Name = "btnDoldur";
            this.btnDoldur.Size = new System.Drawing.Size(123, 57);
            this.btnDoldur.TabIndex = 1;
            this.btnDoldur.Text = "Aktif Form Taleplerini Listele";
            this.btnDoldur.UseVisualStyleBackColor = false;
            this.btnDoldur.Click += new System.EventHandler(this.btnDoldur_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(155, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(920, 463);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Form Sayısı =";
            this.label1.Visible = false;
            // 
            // TimerBas
            // 
            this.TimerBas.Interval = 1000;
            this.TimerBas.Tick += new System.EventHandler(this.TimerBas_Tick);
            // 
            // btnUyari
            // 
            this.btnUyari.BackColor = System.Drawing.Color.White;
            this.btnUyari.Enabled = false;
            this.btnUyari.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUyari.Location = new System.Drawing.Point(12, 196);
            this.btnUyari.Name = "btnUyari";
            this.btnUyari.Size = new System.Drawing.Size(123, 57);
            this.btnUyari.TabIndex = 3;
            this.btnUyari.Text = "UYARI SİSTEMİNİ BAŞLAT";
            this.btnUyari.UseVisualStyleBackColor = false;
            this.btnUyari.Click += new System.EventHandler(this.btnUyari_Click);
            // 
            // tbSaniye
            // 
            this.tbSaniye.Location = new System.Drawing.Point(22, 272);
            this.tbSaniye.Name = "tbSaniye";
            this.tbSaniye.Size = new System.Drawing.Size(100, 20);
            this.tbSaniye.TabIndex = 2;
            this.tbSaniye.Text = "10";
            this.tbSaniye.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSaniye.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSaniye_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ne sıklıkla listelensin ? (sn)";
            // 
            // pbTrue
            // 
            this.pbTrue.Image = ((System.Drawing.Image)(resources.GetObject("pbTrue.Image")));
            this.pbTrue.Location = new System.Drawing.Point(18, 455);
            this.pbTrue.Name = "pbTrue";
            this.pbTrue.Size = new System.Drawing.Size(30, 30);
            this.pbTrue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTrue.TabIndex = 9;
            this.pbTrue.TabStop = false;
            this.pbTrue.Visible = false;
            // 
            // pbFalse
            // 
            this.pbFalse.Image = ((System.Drawing.Image)(resources.GetObject("pbFalse.Image")));
            this.pbFalse.Location = new System.Drawing.Point(18, 455);
            this.pbFalse.Name = "pbFalse";
            this.pbFalse.Size = new System.Drawing.Size(30, 30);
            this.pbFalse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFalse.TabIndex = 10;
            this.pbFalse.TabStop = false;
            this.pbFalse.Visible = false;
            // 
            // TimerSaniye
            // 
            this.TimerSaniye.Interval = 1000;
            this.TimerSaniye.Tick += new System.EventHandler(this.TimerSaniye_Tick);
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Location = new System.Drawing.Point(61, 295);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(13, 13);
            this.lblSaniye.TabIndex = 11;
            this.lblSaniye.Text = "0";
            this.lblSaniye.Visible = false;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblX.Location = new System.Drawing.Point(1064, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(20, 20);
            this.lblX.TabIndex = 12;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lblMinimal);
            this.panel1.Controls.Add(this.lblBack);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblX);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 22);
            this.panel1.TabIndex = 21;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // lblMinimal
            // 
            this.lblMinimal.AutoSize = true;
            this.lblMinimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMinimal.Location = new System.Drawing.Point(1041, -3);
            this.lblMinimal.Name = "lblMinimal";
            this.lblMinimal.Size = new System.Drawing.Size(19, 25);
            this.lblMinimal.TabIndex = 24;
            this.lblMinimal.Text = "-";
            this.lblMinimal.Click += new System.EventHandler(this.lblMinimal_Click);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBack.Location = new System.Drawing.Point(0, 0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(18, 20);
            this.lblBack.TabIndex = 23;
            this.lblBack.Text = "<";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fake Follow v1.0 - Coded by İhsan";
            // 
            // lblListe
            // 
            this.lblListe.AutoSize = true;
            this.lblListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblListe.Location = new System.Drawing.Point(9, 317);
            this.lblListe.Name = "lblListe";
            this.lblListe.Size = new System.Drawing.Size(74, 13);
            this.lblListe.TabIndex = 22;
            this.lblListe.Text = "--- Listeleniyor.";
            // 
            // btnIslemDegistir
            // 
            this.btnIslemDegistir.BackColor = System.Drawing.Color.White;
            this.btnIslemDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIslemDegistir.Location = new System.Drawing.Point(12, 333);
            this.btnIslemDegistir.Name = "btnIslemDegistir";
            this.btnIslemDegistir.Size = new System.Drawing.Size(123, 57);
            this.btnIslemDegistir.TabIndex = 23;
            this.btnIslemDegistir.Text = "Değiştirmek İçin Tıkla";
            this.btnIslemDegistir.UseVisualStyleBackColor = false;
            this.btnIslemDegistir.Click += new System.EventHandler(this.btnIslemDegistir_Click);
            // 
            // cbAFK
            // 
            this.cbAFK.AutoSize = true;
            this.cbAFK.Location = new System.Drawing.Point(80, 455);
            this.cbAFK.Name = "cbAFK";
            this.cbAFK.Size = new System.Drawing.Size(46, 17);
            this.cbAFK.TabIndex = 24;
            this.cbAFK.Text = "AFK";
            this.cbAFK.UseVisualStyleBackColor = true;
            this.cbAFK.CheckedChanged += new System.EventHandler(this.cbAFK_CheckedChanged);
            // 
            // tbAfkSifre
            // 
            this.tbAfkSifre.Location = new System.Drawing.Point(80, 478);
            this.tbAfkSifre.Name = "tbAfkSifre";
            this.tbAfkSifre.PasswordChar = '*';
            this.tbAfkSifre.Size = new System.Drawing.Size(40, 20);
            this.tbAfkSifre.TabIndex = 25;
            this.tbAfkSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAfkSifre.Visible = false;
            this.tbAfkSifre.TextChanged += new System.EventHandler(this.tbAfkSifre_TextChanged);
            // 
            // btnError
            // 
            this.btnError.BackColor = System.Drawing.Color.Red;
            this.btnError.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnError.ForeColor = System.Drawing.Color.White;
            this.btnError.Location = new System.Drawing.Point(12, 396);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(123, 30);
            this.btnError.TabIndex = 26;
            this.btnError.Text = "Programda Hata Var !";
            this.btnError.UseVisualStyleBackColor = false;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnUyari;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1087, 510);
            this.Controls.Add(this.btnError);
            this.Controls.Add(this.tbAfkSifre);
            this.Controls.Add(this.cbAFK);
            this.Controls.Add(this.btnIslemDegistir);
            this.Controls.Add(this.lblListe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.pbFalse);
            this.Controls.Add(this.pbTrue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSaniye);
            this.Controls.Add(this.btnUyari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDoldur);
            this.Controls.Add(this.btnBagla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fake Follow";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFalse)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBagla;
        private System.Windows.Forms.Button btnDoldur;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TimerBas;
        private System.Windows.Forms.Button btnUyari;
        private System.Windows.Forms.TextBox tbSaniye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbTrue;
        private System.Windows.Forms.PictureBox pbFalse;
        private System.Windows.Forms.Timer TimerSaniye;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblMinimal;
        private System.Windows.Forms.Label lblListe;
        private System.Windows.Forms.Button btnIslemDegistir;
        private System.Windows.Forms.CheckBox cbAFK;
        private System.Windows.Forms.TextBox tbAfkSifre;
        private System.Windows.Forms.Button btnError;
    }
}

