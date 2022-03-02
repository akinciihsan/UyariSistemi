using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace MySqlServerConnection
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public static ArrayList ids = new ArrayList();
        public static ArrayList psw = new ArrayList();
        public static Boolean premium, KullaniciVarMi = false;
        int Move;
        int Mouse_X;
        int Mouse_Y;

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            ids.Add("ihsan");
            psw.Add("1234");
            ids.Add("esra");
            psw.Add("1234");
            if (tbKullanıcıAdi.Text != "")
            {
                tbKullanıcıAdi.Select();
                tbSifre.Select();
            }
        }
        Form1 Form1 = new Form1();
        FrmKayit FrmKayit = new FrmKayit();
        private void btnGec_Click(object sender, EventArgs e)
        {
            premium = false;
            this.Hide();
            Form1.Show();
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ids.Count; i++)
            {
                if (tbSifre.Text == psw[i].ToString())
                {
                    premium = true;
                    this.Hide();
                    Form1.Show();
                }
                else
                {
                    MessageBox.Show("Şifre yanlış. Lütfen tekrar deneyin.","Hatalı Şifre");
                    tbSifre.Select();
                    tbSifre.SelectionStart = 0;
                    tbSifre.SelectionLength = tbSifre.Text.Length;
                }
            }
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmKayit.Show();
        }
        List<string> User_ids_list = new List<string>();
        List<string> User_pas_list = new List<string>();

        private void FrmLogin_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void lblMinimal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tbSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSifre_Leave(object sender, EventArgs e)
        {
            
        }

        private void tbKullanıcıAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbKullanıcıAdi_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < ids.Count; i++)
            {
                if (tbKullanıcıAdi.Text == ids[i].ToString())
                {
                    KullaniciVarMi = true;
                    break;
                }
                else
                {
                    KullaniciVarMi = false;
                }
            }
            if (KullaniciVarMi == false)
            {
                MessageBox.Show("Kullanıcı Adı bulunamadı, lütfen tekrar deneyin.","Kullanıcı Bulunamadı");
                tbKullanıcıAdi.Select();
                tbKullanıcıAdi.SelectionStart = 0;
                tbKullanıcıAdi.SelectionLength = tbKullanıcıAdi.Text.Length;
            }
        }
    }
}
