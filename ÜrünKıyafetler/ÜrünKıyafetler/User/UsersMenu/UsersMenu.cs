using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ÜrünKıyafetler.User.UsersMenu.UserEkle;
using ÜrünKıyafetler.User.UsersMenu.UserGuncelle;
using ÜrünKıyafetler.User.UsersMenu.UserSil;

namespace ÜrünKıyafetler.User.UsersMenu
{
    public partial class UsersMenu : Form
    {
        public UsersMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciMenu a = new KullaniciMenu();
            this.Hide();
            a.Show();
        }

        private void btn_Urunekle_Click(object sender, EventArgs e)
        {
            lst_Urunekle.Visible = !lst_Urunekle.Visible;
        }

        private void lst_Urunekle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_Urunekle.Text == "Gömlek")
            {
                UserGomlekEkle a = new UserGomlekEkle();
                this.Hide();
                a.Show();
            }
            else if (lst_Urunekle.Text == "Pantolon")
            {
                UserPantolonEkle a = new UserPantolonEkle();
                this.Hide();
                a.Show();
            }
            else if (lst_Urunekle.Text == "TişöRt")
            {
                UserTisortEkle a = new UserTisortEkle();
                this.Hide();
                a.Show();
            }
            else if (lst_Urunekle.Text == "Mont")
            {
                UserMontEkle a = new UserMontEkle();
                this.Hide();
                a.Show();
            }
        }

        private void btn_UrunGuncel_Click(object sender, EventArgs e)
        {
            lst_UrunGuncelle.Visible = !lst_UrunGuncelle.Visible;
        }

        private void lst_UrunGuncelle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_UrunGuncelle.Text == "Gömlek")
            {
                UserGomlekGuncelle a = new UserGomlekGuncelle();
                this.Hide();
                a.Show();
            }
            if (lst_UrunGuncelle.Text == "Pantolon")
            {
                UserPantolonGuncelle a = new UserPantolonGuncelle();
                this.Hide();
                a.Show();
            }
            if (lst_UrunGuncelle.Text == "TişöRt")
            {
                UserTisortGuncelle a = new UserTisortGuncelle();
                this.Hide();
                a.Show();
            }
            if (lst_UrunGuncelle.Text == "Mont")
            {
                UserMontGuncelle a = new UserMontGuncelle();
                this.Hide();
                a.Show();
            }
        }

        private void btn_UrunList_Click(object sender, EventArgs e)
        {
            lst_Urunler.Visible = !lst_Urunler.Visible;
        }

        private void lst_Urunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_Urunler.Text == "Gömlek")
            {
                UserGomlekSil a = new UserGomlekSil();
                this.Hide();
                a.Show();
            }
            if (lst_Urunler.Text == "Pantolon")
            {
                UserPantolonSil a = new UserPantolonSil();
                this.Hide();
                a.Show();
            }
            if (lst_Urunler.Text == "TişöRt")
            {
                UserTisortSil a = new UserTisortSil();
                this.Hide();
                a.Show();
            }
            if (lst_Urunler.Text == "Mont")
            {
                UserMontSil a = new UserMontSil();
                this.Hide();
                a.Show();
            }
        }
    }
}
