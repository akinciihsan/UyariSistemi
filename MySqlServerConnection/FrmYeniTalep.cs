using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySqlServerConnection
{
    public partial class FrmYeniTalep : Form
    {
        public FrmYeniTalep()
        {
            InitializeComponent();
        }
        public static int TalepSayisi = 0, EksilenTalepSayisi = 0;
        public static Boolean AcikMi = false, MinimalMi = false;
        int gecen_sure;
        int Move;
        int Mouse_X;
        int Mouse_Y;
        int ClickCount = 0;
        string TalepSaati;

        public void CloseUyari()
        {
            if (Form1.AFK == true && ClickCount < 3)
            {
                DialogResult dialogResult = MessageBox.Show("Bu mesajı kapatmak için İhsan Bey'den izin aldın mı ??", "Yakaladım Seni", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Neden yalan söylüyorsun... Yakışıyor mu sana ?", "AYIP");
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("En azından dürüstsün... Saygı duydum.\nAma yine de yaptığın hoş değil.", "İzin Al Kardeşim");
                }
            }
            if (Form1.AFK == false || ClickCount >= 3)
            {
                AcikMi = false;
                MinimalMi = false;
                timerGecenSure.Enabled = false;
                timerKayanYazi.Enabled = false;
                gecen_sure = 0;
                TalepSayisi = 0;
                EksilenTalepSayisi = 0;
                lblGecenSure.Text = gecen_sure.ToString();
                lblTalepAdet.Text = TalepSayisi.ToString();
                lblEksilenTalepAdet.Text = EksilenTalepSayisi.ToString();
                lblEksi.Visible = false;
                lblEksilenTalepAdet.Visible = false;
                this.Close();
                ClickCount = 0;
            }
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            CloseUyari();
        }


        private void FrmYeniTalep_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            AcikMi = true;
            gecen_sure = 0;
            timerGecenSure.Enabled = true;
            timerKayanYazi.Enabled = true;
            if (Form1.GBmi == true)
            {
                lblTalepGeldi.Text = "YENİ GERİ BİLDİRİMİN VAR !!!";
            }
            else if (Form1.GBmi == false)
            {
                lblTalepGeldi.Text = "YENİ FORM TALEBİ GELDİ !";
            }
            TalepSaati = DateTime.Now.Hour + "." + DateTime.Now.Minute;
        }

        private void timerGecenSure_Tick(object sender, EventArgs e)
        {
            gecen_sure++;
            lblGecenSure.Text = gecen_sure.ToString() + "   /   " + TalepSaati;
            lblTalepAdet.Text = TalepSayisi.ToString();
            if (EksilenTalepSayisi > 0)
            {
                lblEksi.Visible = true;
                lblEksilenTalepAdet.Visible = true;
                lblEksilenTalepAdet.Text = EksilenTalepSayisi.ToString();
            }
        }

        private void timerKayanYazi_Tick(object sender, EventArgs e)
        {
            lblKayanYazi.Text = lblKayanYazi.Text.Substring(1) + lblKayanYazi.Text.Substring(0, 1);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void FrmYeniTalep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                ClickCount++;
            }
            if (e.KeyCode == Keys.Escape)
            {
                CloseUyari();
            }
        }

        private void btnHideClose_Click(object sender, EventArgs e)
        {
            ClickCount++;
        }

        private void lblTalepAdet_Click(object sender, EventArgs e)
        {

        }

        private void lblMinimal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            MinimalMi = true;
        }
    }
}
