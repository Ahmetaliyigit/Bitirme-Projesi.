using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÜrünKıyafetler
{
    public partial class VIPLogin : Form
    {
        public VIPLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Buton özellikleri 
            btn_Urunekle.FlatStyle = FlatStyle.Flat;
            btn_Urunekle.BackColor = Color.Transparent;
            btn_Urunekle.FlatAppearance.BorderSize = 0;
            #endregion
            lst_Urunler.Visible = !lst_Urunler.Visible;
        }


        private void lst_Urunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_Urunler.Text == "Gömlek")
            {
                VIPGomlekEkle ekle = new VIPGomlekEkle();
                ekle.Show();
                this.Hide();
            }
            else if (lst_Urunler.Text == "Pantolon")
            {
                VIPPantolonEkle ekle = new VIPPantolonEkle();
                ekle.Show();
                this.Hide();
            }
            else if (lst_Urunler.Text == "Mont")
            {
                VIPMontEkle ekle = new VIPMontEkle();
                ekle.Show();
                this.Hide();
            }
            else if (lst_Urunler.Text == "TişöRt")
            {
                VIPTisort ekle = new VIPTisort();
                ekle.Show();
                this.Hide();
            }
        }

        private void btn_Cıkıs_Click(object sender, EventArgs e)
        {
            Menu a = new Menu();
            a.Show();
            this.Hide();
        }

        private void btn_UrunGuncel_Click(object sender, EventArgs e)
        {
            lst_Urunler2.Visible = !lst_Urunler2.Visible;
        }

        private void lst_Urunler2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_Urunler2.Text == "Gömlek")
            {
                VIPGomlekGuncelle a = new VIPGomlekGuncelle();
                a.Show();
                this.Hide();
            }
            else if (lst_Urunler2.Text == "Mont")
            {
                VIPMontGuncelle b = new VIPMontGuncelle();
                b.Show();
                this.Hide();
            }
            else if (lst_Urunler2.Text == "Pantolon")
            {
                VIPPantolonGuncelle b = new VIPPantolonGuncelle();
                b.Show();
                this.Hide();
            }
            else if (lst_Urunler2.Text == "TişöRt")
            {
                VIPTisortGuncelle b = new VIPTisortGuncelle();
                b.Show();
                this.Hide();
            }

        }


        private void lst_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_list.Text == "Gömlek")
            {
                VIPGomlekSil a = new VIPGomlekSil();
                a.Show();
                this.Hide();
            }
            else if (lst_list.Text == "Mont")
            {
                VIPMontSil b = new VIPMontSil();
                b.Show();
                this.Hide();
            }
            else if (lst_list.Text == "Pantolon")
            {
                VIPPantolonSil b = new VIPPantolonSil();
                b.Show();
                this.Hide();
            }
            else if (lst_list.Text == "TişöRt")
            {
                VIPTisortSil b = new VIPTisortSil();
                b.Show();
                this.Hide();
            }
        }

        private void btn_UrunList_Click(object sender, EventArgs e)
        {
            lst_list.Visible = !lst_list.Visible;
        }

        private void btn_KullaniciList_Click(object sender, EventArgs e)
        {
            VIPKullanici a = new VIPKullanici();
            a.Show();
            this.Hide();
        }
    }
}
