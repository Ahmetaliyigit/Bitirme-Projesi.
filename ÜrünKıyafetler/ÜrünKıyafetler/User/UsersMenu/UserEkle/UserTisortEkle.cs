using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÜrünKıyafetler.User.UsersMenu.UserEkle
{
    public partial class UserTisortEkle : Form
    {
        public UserTisortEkle()
        {
            InitializeComponent();
        }

        private void btn_Marka_Click(object sender, EventArgs e)
        {
            lst_Markalar.Visible = !lst_Markalar.Visible;
        }

        private void btn_Beden_Click(object sender, EventArgs e)
        {
            lst_Bedenler1.Visible = !lst_Bedenler1.Visible;
        }

        private void btn_Renk_Click(object sender, EventArgs e)
        {
            lst_Renk.Visible = !lst_Renk.Visible;
        }

        private void btn_Cins_Click(object sender, EventArgs e)
        {
            lst_Cins.Visible = !lst_Cins.Visible;
        }

        private void btn_Kol_Click(object sender, EventArgs e)
        {
            lst_Kol2.Visible = !lst_Kol2.Visible;
        }

        private void btn_Yaka_Click(object sender, EventArgs e)
        {
            lst_Yaka2.Visible = !lst_Yaka2.Visible;

        }

        private void btn_Kumas_Click(object sender, EventArgs e)
        {
            lst_Kumas2.Visible = !lst_Kumas2.Visible;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            bool bos = string.IsNullOrEmpty(lst_Markalar.Text) ||
                     string.IsNullOrEmpty(lst_Bedenler1.Text) ||
                     string.IsNullOrEmpty(lst_Renk.Text) ||
                     string.IsNullOrEmpty(lst_Cins.Text) ||
                     string.IsNullOrEmpty(lst_Kol2.Text) ||
                     string.IsNullOrEmpty(lst_Kumas2.Text) ||
                     string.IsNullOrEmpty(lst_Yaka2.Text) ||
                     string.IsNullOrEmpty(txt_Fiyat.Text);

            if (bos == true)
            {
                MessageBox.Show(" Lütfen bütün seçenekleri doldurun ");
            }
            else
            {
                DataContext Db = new DataContext();
                Tshirt a = new Tshirt();
                var varmi = Db.Customers.Where(k => k.Id == Id.UserID).FirstOrDefault();
                var Renk = Db.Colors.Where(k => k.Name == lst_Renk.Text).FirstOrDefault();
                var Marka = Db.Brands.Where(k => k.Name == lst_Markalar.Text).FirstOrDefault();
                var Cins = Db.Genders.Where(k => k.Name == lst_Cins.Text).FirstOrDefault();
                var Kumas = Db.Fabrics.Where(k => k.Name == lst_Kumas2.Text).FirstOrDefault();


                a.BrandId = Marka.Id;
                a.Size = lst_Bedenler1.Text;
                a.ProductColorId = Renk.Id;
                a.GenderId = Cins.Id;
                a.Collar = lst_Yaka2.Text;
                a.FabricId = Kumas.Id;
                a.sleve = lst_Kol2.Text;
                a.Type = varmi.Name;
                a.ConditionId = 2;
                a.Price = Convert.ToDouble(txt_Fiyat.Text);
                Db.Tshirts.Add(a);
                Db.SaveChanges();

                MessageBox.Show(" Tişört başarıyla kaydedildi ");


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsersMenu a = new UsersMenu();
            a.Show();
            this.Hide();

        }
    }
}
