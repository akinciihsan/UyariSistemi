using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MySqlServerConnection
{
    public partial class FrmKayit : Form
    {
        public FrmKayit()
        {
            InitializeComponent();
        }

        ErrorProvider providerSifre = new ErrorProvider();
        ErrorProvider providerKullanici = new ErrorProvider();
        Boolean checkKullanici = false;
        Boolean checkSifre = false;
        int Move;
        int Mouse_X;
        int Mouse_Y;
        FrmLogin FrmLogin;

        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (tbSifre.Text != tbSifreTekrar.Text)
            {
                providerSifre.SetError(tbSifreTekrar, "Girdiğiniz şifreler aynı değil!");
                checkSifre = false;
            }
            else
            {
                providerSifre.Clear();
                checkSifre = true;
                for (int i = 0; i < FrmLogin.ids.Count; i++)
                {
                    if (tbKullanıcıAdi.Text == FrmLogin.ids[i].ToString())
                    {
                        checkKullanici = false;
                    }
                    else
                    {
                        checkKullanici = true;
                    }
                }
                if (checkKullanici == false)
                {
                    providerKullanici.SetError(tbKullanıcıAdi, "Girdiğiniz kullanıcı adı kullanılıyor.\nLütfen yeni bir kullanıcı adı seçin.");
                }
                else if (checkKullanici == true)
                {
                    providerKullanici.Clear();
                    if (tbKullanıcıAdi.Text == "" || tbSifre.Text == "" || tbSifreTekrar.Text == "")
                    {
                        MessageBox.Show("Lütfen bilgileri eksiksiz doldurun.","Hatalı Veri");
                    }
                    else
                    {
                        if (checkKullanici == true && checkSifre == true)
                        {
                            FrmLogin.ids.Add(tbKullanıcıAdi.Text);
                            FrmLogin.psw.Add(tbSifre.Text);
                            MessageBox.Show("Tek kullanımlık üyeliğiniz oluşturulmuştur. Programı kapatıp açtığında tekrar kayıt olmak zorundasın.\nKalıcı üyelik için sistem yöneticinizle irtibata geçin","Kayıt Başarılı");
                        }
                    }
                }
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            FrmLogin = new FrmLogin();
            FrmLogin.Show();
            this.Hide();
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
    }
}
