using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace MySqlServerConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FrmYeniTalep FrmYeniTalep = new FrmYeniTalep();
        FrmLogin FrmLogin;

        int Total = 0, TotalNew = 0, ListeSayisi = 0, Saniye = 0;
        int Move;
        int Mouse_X;
        int Mouse_Y;

        string komut;
        
        NotifyIcon notify = new NotifyIcon();

        Boolean Degistir = false;
        public static Boolean GBmi = false, AFK = false, kimlik;

        //MySqlConnection baglanti = new MySqlConnection("Server=94.73.150.188;Port=3306;Database=u6420676_follow;Uid=u6420676_guru;Pwd=guruadm33344445;");
        MySqlConnection baglanti = new MySqlConnection("Server=192.168.2.100;Port=3306;Database=follow;Uid=guru;Pwd=guruadm33344445;");

        private void btnBagla_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    pbTrue.Visible = true;
                    pbFalse.Visible = false;
                    btnBagla.BackColor = Color.Lime;
                    btnDoldur.Enabled = true;
                    btnUyari.Enabled = true;
                    btnBagla.Text = "Server İle Bağlantıyı Kesmek İçin Tıkla";
                }
                else if (baglanti.State == ConnectionState.Open)
                {

                    baglanti.Close();
                    pbFalse.Visible = true;
                    pbTrue.Visible = false;
                    btnBagla.BackColor = Color.Red;
                    btnDoldur.Enabled = false;
                    btnUyari.Enabled = false;
                    btnBagla.Text = "Servere Bağlanmak İçin Tıkla";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GBmi = false;
            komut = "SELECT destek_talep.id,destek_talep.talep_tarihi,proje.adi,destek_talep.konu,destek_talep_ana_modul.adi,destek_talep_alt_modul.adi,destek_talep.sonlandirma_tarihi,personel.adi,personel.soyadi,destek_talep_geri_bildirim.zaman,destek_talep_geri_bildirim.aciklama,kullanici.kullanici_adi,kullanici.kullanici_soyadi FROM destek_talep LEFT JOIN destek_talep_ana_modul ON destek_talep_ana_modul.id = destek_talep.ana_modul_id LEFT JOIN destek_talep_alt_modul ON destek_talep_alt_modul.id = destek_talep.alt_modul_id LEFT JOIN proje ON proje.id=destek_talep.proje_id LEFT JOIN personel AS talep_guru ON talep_guru.id=destek_talep.talep_eden_personel_id LEFT JOIN proje_kullanici ON proje_kullanici.id=destek_talep.talep_eden_kullanici_id LEFT JOIN personel ON personel.id=destek_talep.ilgili_id LEFT JOIN personel AS t_personel_guru ON t_personel_guru.id = proje.personel_id LEFT JOIN personel AS t_yonetici_guru ON t_yonetici_guru.id = proje.proje_yonetici_id LEFT JOIN ( SELECT destek_talep_id, MAX(id) AS max_id FROM destek_talep_geri_bildirim GROUP BY destek_talep_id) AS X ON X.destek_talep_id=destek_talep.id LEFT JOIN destek_talep_geri_bildirim ON destek_talep_geri_bildirim.id=X.max_id LEFT JOIN kullanici ON kullanici.id=destek_personel_kullanici_id LEFT JOIN ( SELECT proje_id,anlasma_baslangic_tarihi,anlasma_bitis_tarihi, MIN(id) AS  min_id  FROM proje_anlasma WHERE anlasma_bitis_tarihi >= '2021-03-08' AND anlasma_baslangic_tarihi <= '  2021-03-08' GROUP BY proje_id) AS Y ON Y.proje_id = proje.id LEFT JOIN proje_anlasma AS pa ON pa.id = Y.min_id   WHERE (destek_talep.turu = '03') AND (destek_talep.durumu = '01' OR destek_talep.durumu = '02' OR destek_talep.durumu = '03') AND (proje.durumu = '10' OR proje.durumu = '20' OR proje.durumu = '30' OR proje.durumu = '35' OR proje.durumu = '40' OR proje.durumu = '45' OR proje.durumu = '50' OR proje.durumu = '55' OR proje.durumu = '15') ORDER BY destek_talep.id DESC;";
            lblListe.Text = "Form Talepleri Listeleniyor";
            btnIslemDegistir.Text = "Geri Bildirimleri Listele";

            if (baglanti.State == ConnectionState.Closed)
            {
                pbTrue.Visible = false;
                pbFalse.Visible = true;
                btnBagla.BackColor = Color.Red;
            }
            else if (baglanti.State == ConnectionState.Open)
            {
                pbTrue.Visible = true;
                pbFalse.Visible = false;
                btnBagla.BackColor = Color.Lime;
            }

            if (TimerBas.Enabled == false)
            {
                btnUyari.BackColor = Color.Red;
            }
            else if (TimerBas.Enabled == true)
            {
                btnUyari.BackColor = Color.Lime;
            }
            notify.Visible = true;
            notify.Icon = System.Drawing.SystemIcons.Information;
        }

        private void TimerBas_Tick(object sender, EventArgs e)
        {
            btnDoldur_Click(btnDoldur, new EventArgs());
        }

        private void btnUyari_Click(object sender, EventArgs e)
        {
            try
            {
                if (FrmLogin.premium == true)
                {
                    if (TimerBas.Enabled == false)
                    {
                        if (tbSaniye.Text == "")
                        {
                            MessageBox.Show("Lütfen saniye girin");
                        }
                        else
                        {
                            TimerBas.Interval = Convert.ToInt32(tbSaniye.Text) * 1000;
                            Saniye = Convert.ToInt32(tbSaniye.Text) - 1;
                            TimerSaniye.Start();
                            TimerBas.Start();
                            btnUyari.Text = "UYARI SİSTEMİNİ KAPAT";
                            btnUyari.BackColor = Color.Lime;
                            tbSaniye.Enabled = false;
                            btnBagla.Enabled = false;
                            btnDoldur.Enabled = false;
                            btnIslemDegistir.Enabled = false;
                            notify.BalloonTipTitle = "Uyarı Sistemi Aktif";
                            notify.BalloonTipText = "Form talepleri her " + tbSaniye.Text + " saniyede listelenecektir.\nYeni bir Form talebi geldiğinde bildirim alacaksınız.";
                            if (notify.Visible == false)
                            {
                                notify.Visible = true;
                            }
                            notify.ShowBalloonTip(30000);
                        }
                    }
                    else if (TimerBas.Enabled == true)
                    {
                        TimerBas.Stop();
                        TimerSaniye.Stop();
                        lblSaniye.Visible = false;
                        btnUyari.Text = "UYARI SİSTEMİNİ BAŞLAT";
                        btnUyari.BackColor = Color.Red;
                        btnBagla.Enabled = true;
                        btnDoldur.Enabled = true;
                        btnIslemDegistir.Enabled = true;
                        notify.BalloonTipTitle = "Uyarı Sistemi Devre Dışı";
                        notify.BalloonTipText = "Uyarı sistemi devre dışı bırakıldı.";
                        if (notify.Visible == false)
                        {
                            notify.Visible = true;
                        }
                        notify.ShowBalloonTip(30000);
                        tbSaniye.Enabled = true;
                    }
                }
                else if (FrmLogin.premium == false)
                {
                    MessageBox.Show("Bu özellik sadece Premium kullanıcıların kullanımına açılmıştır.\nPremium kullanıcı olmak için lütfen sistem yöneticiniz ile irtibata geçin","Premium Değilsiniz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void lblBack_Click(object sender, EventArgs e)
        {
            if (TimerBas.Enabled == true)
            {
                MessageBox.Show("Uyarı Sistemi Aktif! Lütfen Uyarı Sistemini kapatıp tekrar deneyin.","Uyarı Sistemi Aktif");
            }
            else
            {
                this.Hide();
                FrmLogin = new FrmLogin();
                FrmLogin.Show();
            }
        }

        private void lblMinimal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            notify.BalloonTipTitle = "Simge Durumuna Küçültüldü";
            notify.BalloonTipText = "Program hala çalışıyor. Uyarı sistemi aktif ise bildirim almaya devam edeceksiniz.";
            if (notify.Visible == false)
            {
                notify.Visible = true;
            }
            notify.ShowBalloonTip(30000);
        }

        private void btnIslemDegistir_Click(object sender, EventArgs e)
        {
            if (GBmi == true)
            {
                GBmi = false;
                komut = "SELECT destek_talep.id,destek_talep.talep_tarihi,proje.adi,destek_talep.konu,destek_talep_ana_modul.adi,destek_talep_alt_modul.adi,destek_talep.sonlandirma_tarihi,personel.adi,personel.soyadi,destek_talep_geri_bildirim.zaman,destek_talep_geri_bildirim.aciklama,kullanici.kullanici_adi,kullanici.kullanici_soyadi FROM destek_talep LEFT JOIN destek_talep_ana_modul ON destek_talep_ana_modul.id = destek_talep.ana_modul_id LEFT JOIN destek_talep_alt_modul ON destek_talep_alt_modul.id = destek_talep.alt_modul_id LEFT JOIN proje ON proje.id=destek_talep.proje_id LEFT JOIN personel AS talep_guru ON talep_guru.id=destek_talep.talep_eden_personel_id LEFT JOIN proje_kullanici ON proje_kullanici.id=destek_talep.talep_eden_kullanici_id LEFT JOIN personel ON personel.id=destek_talep.ilgili_id LEFT JOIN personel AS t_personel_guru ON t_personel_guru.id = proje.personel_id LEFT JOIN personel AS t_yonetici_guru ON t_yonetici_guru.id = proje.proje_yonetici_id LEFT JOIN ( SELECT destek_talep_id, MAX(id) AS max_id FROM destek_talep_geri_bildirim GROUP BY destek_talep_id) AS X ON X.destek_talep_id=destek_talep.id LEFT JOIN destek_talep_geri_bildirim ON destek_talep_geri_bildirim.id=X.max_id LEFT JOIN kullanici ON kullanici.id=destek_personel_kullanici_id LEFT JOIN ( SELECT proje_id,anlasma_baslangic_tarihi,anlasma_bitis_tarihi, MIN(id) AS  min_id  FROM proje_anlasma WHERE anlasma_bitis_tarihi >= '2021-03-08' AND anlasma_baslangic_tarihi <= '  2021-03-08' GROUP BY proje_id) AS Y ON Y.proje_id = proje.id LEFT JOIN proje_anlasma AS pa ON pa.id = Y.min_id   WHERE (destek_talep.turu = '03') AND (destek_talep.durumu = '01' OR destek_talep.durumu = '02' OR destek_talep.durumu = '03') AND (proje.durumu = '10' OR proje.durumu = '20' OR proje.durumu = '30' OR proje.durumu = '35' OR proje.durumu = '40' OR proje.durumu = '45' OR proje.durumu = '50' OR proje.durumu = '55' OR proje.durumu = '15') ORDER BY destek_talep.id DESC;";
                lblListe.Text = "Form Talepleri Listeleniyor";
                btnIslemDegistir.Text = "Geri Bildirimleri Listele";
                Degistir = true;
            }
            else if (GBmi == false)
            {
                GBmi = true;
                komut = "SELECT destek_talep.id,destek_talep.talep_tarihi,destek_talep.turu,destek_talep.konu,destek_talep.uygulama,destek_talep_ana_modul.adi,destek_talep_alt_modul.adi,destek_talep.durumu,destek_talep.proje_id,destek_talep.talep_eden_kullanici_id,destek_talep.talep_eden_personel_id,destek_talep.ilgili_id,destek_talep.yazilim_talep_id,destek_talep.sonlandirma_tarihi,destek_talep.tipi,destek_talep.talep_eden_kullanici_aciklama,proje.hizmet_sekli,proje.adi,proje.durumu,personel.adi,personel.soyadi,talep_guru.adi,talep_guru.soyadi,proje_kullanici.adi,proje_kullanici.soyadi,destek_talep_geri_bildirim.zaman,destek_talep_geri_bildirim.aciklama,kullanici.kullanici_adi,kullanici.kullanici_soyadi,pa.anlasma_turu,pa.fatura_tipi,pa.anlasma_baslangic_tarihi,pa.anlasma_bitis_tarihi,proje.kodu,destek_talep.ucret_durumu, yazilim_talep.durumu, destek_talep_oncelik.adi, destek_talep_sinifi.adi ,destek_talep_geri_bildirim.talep_eden_kullanici_aciklama  FROM destek_talep LEFT JOIN destek_talep_ana_modul ON destek_talep_ana_modul.id = destek_talep.ana_modul_id LEFT JOIN destek_talep_alt_modul ON destek_talep_alt_modul.id = destek_talep.alt_modul_id LEFT JOIN yazilim_talep ON yazilim_talep.id = destek_talep.yazilim_talep_id LEFT JOIN destek_talep_oncelik ON destek_talep_oncelik.id = destek_talep.destek_talep_oncelik_id LEFT JOIN destek_talep_sinifi ON destek_talep_sinifi.id = destek_talep.destek_talep_sinifi_id LEFT JOIN proje ON proje.id=destek_talep.proje_id LEFT JOIN personel AS talep_guru ON talep_guru.id=destek_talep.talep_eden_personel_id LEFT JOIN proje_kullanici ON proje_kullanici.id=destek_talep.talep_eden_kullanici_id LEFT JOIN personel ON personel.id=destek_talep.ilgili_id LEFT JOIN personel AS t_personel_guru ON t_personel_guru.id = proje.personel_id LEFT JOIN personel AS t_yonetici_guru ON t_yonetici_guru.id = proje.proje_yonetici_id LEFT JOIN ( SELECT destek_talep_id, MAX(id) AS max_id FROM destek_talep_geri_bildirim GROUP BY destek_talep_id) AS X ON X.destek_talep_id=destek_talep.id LEFT JOIN destek_talep_geri_bildirim ON destek_talep_geri_bildirim.id=X.max_id LEFT JOIN kullanici ON kullanici.id=destek_personel_kullanici_id LEFT JOIN ( SELECT proje_id,anlasma_baslangic_tarihi,anlasma_bitis_tarihi, MIN(id) AS  min_id  FROM proje_anlasma WHERE anlasma_bitis_tarihi >= '2022-02-11' AND anlasma_baslangic_tarihi <= '  2022-02-11' GROUP BY proje_id) AS Y ON Y.proje_id = proje.id LEFT JOIN proje_anlasma AS pa ON pa.id = Y.min_id   WHERE personel.kodu >= 'DST2009017' AND personel.kodu <= 'DST2009017zz' AND (destek_talep.turu = '01' OR destek_talep.turu = '02' OR destek_talep.turu = '03' OR destek_talep.turu = '04' OR destek_talep.turu = '05' OR destek_talep.turu = '06' OR destek_talep.turu = '07') AND (destek_talep.durumu = '01' OR destek_talep.durumu = '02' OR destek_talep.durumu = '03') AND (proje.durumu = '10' OR proje.durumu = '20' OR proje.durumu = '30' OR proje.durumu = '35' OR proje.durumu = '40' OR proje.durumu = '45' OR proje.durumu = '50' OR proje.durumu = '55' OR proje.durumu = '15') ORDER BY destek_talep.id DESC";
                lblListe.Text = "Geri Bildirimler Listeleniyor";
                btnIslemDegistir.Text = "Form Taleplerini Listele";
                Degistir = true;
            }
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hatalar düzeltilirken bir sorun oldu. Hata aşağıdadır:\n"+ex.Message,"Hata");
            }
            if (FrmYeniTalep.AcikMi == true)
            {
                FrmYeniTalep.CloseUyari();
            }

            MessageBox.Show("Programdaki olası hatalar düzeltildi.\nHala hata var ise programı resetleyip tekrar dene.","Hatalar düzeltildi.");
        }

        private void tbAfkSifre_TextChanged(object sender, EventArgs e)
        {
            if (tbAfkSifre.Text.Length == 4)
            {
                if (tbAfkSifre.Text == "0002")
                {
                    kimlik = true;
                    cbAFK.Checked = false;
                    AFK = false;
                    kimlik = false;
                    tbAfkSifre.Visible = false;
                    tbAfkSifre.Text = "";
                }
                else
                {
                    MessageBox.Show("Şifre yanlış !!!");
                    tbAfkSifre.Text = "";
                    kimlik = false;
                    tbAfkSifre.Select();
                }
            }
        }

        private void cbAFK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAFK.Checked == false && kimlik == false)
            {
                tbAfkSifre.Visible = true;
                cbAFK.Checked = true;
                MessageBox.Show("Kimlik doğrulaması için lütfen şifre girin.");
                tbAfkSifre.Select();
            }
            if (cbAFK.Checked == true)
            {
                AFK = true;
            }
        }

        private void TimerSaniye_Tick(object sender, EventArgs e)
        {
            lblSaniye.Visible = true;
            lblSaniye.Text = Saniye.ToString();
            if (Saniye == 0)
            {
                Saniye = Convert.ToInt32(tbSaniye.Text) - 1;
                lblSaniye.Text = "Listelendi";
            }
            else if (Saniye != 0)
            {
                Saniye--;
            }
        }

        private void tbSaniye_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnDoldur_Click(object sender, EventArgs e)
        {
            try
            {
                ListeSayisi++;
                if (ListeSayisi == 1)
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(komut, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    Total = dataGridView1.Rows.Count;
                    label1.Text = "Toplam Form Sayısı = " + Total.ToString();
                    label1.Visible = true;
                }
                else
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(komut, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    TotalNew = dataGridView1.Rows.Count;
                    label1.Text = "Toplam Form Sayısı = " + TotalNew.ToString();
                    if (TotalNew > Total)
                    {
                        if (Degistir == false)
                        {
                            FrmYeniTalep.TalepSayisi++;
                            notify.BalloonTipTitle = "Form Talebi Geldi";
                            notify.BalloonTipText = "1 Form Talebi Geldi.\nGüncel Form Talebi sayısı = " + TotalNew.ToString();
                            if (notify.Visible == false)
                            {
                                notify.Visible = true;
                            }
                            notify.ShowBalloonTip(30000);

                            Total = TotalNew;

                            if (FrmYeniTalep.AcikMi == false)
                            {
                                FrmYeniTalep.ShowDialog();
                            }
                            else if (FrmYeniTalep.MinimalMi == true)
                            {
                                FrmYeniTalep.WindowState = FormWindowState.Normal;
                            }
                            //MessageBox.Show("Yeni Form Talebi !", "Talep Geldi", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                            
                        }
                        else if (Degistir == true)
                        {
                            Degistir = false;
                        }
                        
                    }
                    else if (TotalNew < Total)
                    {
                        if (Degistir == false)
                        {
                            if (FrmYeniTalep.AcikMi == true)
                            {
                                FrmYeniTalep.EksilenTalepSayisi++;
                            }
                            Total = TotalNew;
                            notify.BalloonTipTitle = "Form Talebi Eksildi";
                            notify.BalloonTipText = "1 Form Talebi eksildi.\nGüncel Form Talebi sayısı = " + TotalNew.ToString();
                            if (notify.Visible == false)
                            {
                                notify.Visible = true;
                            }
                            notify.ShowBalloonTip(30000);
                        }
                        else if (Degistir == true)
                        {
                            Degistir = false;
                        }
                        
                    }
                    label1.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
