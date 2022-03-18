using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_SwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void approve_btn_Click(object sender, EventArgs e)
        {
            switch (txtGirisAlani.Text)
            {
                case "Kış":
                    MessageBox.Show("Aralık-Ocak-Şubat");
                    break;

                case "İlkbahar":
                    MessageBox.Show("Mart-Nisan-Mayıs");
                    break;

                case "Yaz":
                    MessageBox.Show("Haziran-Temmuz-Ağustos");
                    break;

                case "Sonbahar":
                    MessageBox.Show("Eylül-Ekim-Kasım");
                    break;

                default:
                    MessageBox.Show("Böyle bir mevsim hiç duymadım!");
                    break;
            }
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string girilenDeger = txtGirisAlani.Text.ToLower();
            switch (girilenDeger)
            {
                case "admin":
                case "moderator":
                case "yonetici":
                case "ceo":
                case "baskan":
                    MessageBox.Show("Yönetim Paneline Yönlendiriliyorsunuz...");
                    break;

                case "uye":
                    MessageBox.Show("Ana Sayfaya Yönlendiriliyorsunuz...");
                    break;

                default:
                    MessageBox.Show("Bu Sayfayı Görme Yetkiniz Yok!");
                    break;
            }
        }

        private void Switch_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = txtGirisAlani.Text;
            string Sifre = txtIkinciGirisAlani.Text;

            switch (KullaniciAdi)
            {
                case "bilgeselin":
                    switch (Sifre)
                    {
                        case "1234":
                            MessageBox.Show("Tebrikler, hem kullanıcı adı hem de şifreniz doğru!");
                            break;
                        default:
                            MessageBox.Show("Kullanıcı adınız doğru ancak şifreniz yanlış!");
                            break;
                    }
                    break;
                default:
                    MessageBox.Show("Kullanıcı adınızı yanlış girdiniz, şifreye bakmadım bile!");
                    break;
            }
        }
    }
}
