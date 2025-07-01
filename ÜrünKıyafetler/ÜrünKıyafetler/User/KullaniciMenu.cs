using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ÜrünKıyafetler.User.UserBakiye;
using ÜrünKıyafetler.User.UsersMenu;

namespace ÜrünKıyafetler
{
    public partial class KullaniciMenu : Form
    {
        public KullaniciMenu()
        {
            InitializeComponent();
        }

        private void btn_Urunler_Click(object sender, EventArgs e)
        {
            lst_Urunler.Visible = !lst_Urunler.Visible;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Menu a = new Menu();
            this.Hide();
            a.Show();
        }

        private void btn_Bakiye_Click(object sender, EventArgs e)
        {
            UserBakiye a = new UserBakiye();
            this.Hide();
            a.Show();
        }

        private void lst_Urunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_Urunler.Text == "Gömlek")
            {
                GomlekAl a = new GomlekAl();
                this.Hide();
                a.Show();
            }
            else if (lst_Urunler.Text == "Pantolon")
            {
                PantolonAl a = new PantolonAl();
                this.Hide();
                a.Show();
            }
            else if (lst_Urunler.Text == "Mont")
            {
                MontAl a = new MontAl();
                this.Hide();
                a.Show();
            }
            else if (lst_Urunler.Text == "TişöRt")
            {
                TisortAl a = new TisortAl();
                this.Hide();
                a.Show();
            }
        }

        private void btn_Urunler2_Click(object sender, EventArgs e)
        {
            UsersMenu a = new UsersMenu();
            this.Hide();
            a.Show();
        }
    }
}
