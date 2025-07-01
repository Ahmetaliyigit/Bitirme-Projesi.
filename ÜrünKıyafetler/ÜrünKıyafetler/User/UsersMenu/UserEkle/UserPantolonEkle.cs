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
    public partial class UserPantolonEkle : Form
    {
        public UserPantolonEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsersMenu a = new UsersMenu();
            a.Show();
            this.Hide();
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

        private void btn_Kapison_Click(object sender, EventArgs e)
        {
            lst_Bel.Visible = !lst_Bel.Visible;
        }

        private void btn_Cep_Click(object sender, EventArgs e)
        {
            lst_Pant.Visible = !lst_Pant.Visible;
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
                       string.IsNullOrEmpty(lst_Bel.Text) ||
                       string.IsNullOrEmpty(lst_Kumas2.Text) ||
                       string.IsNullOrEmpty(lst_Pant.Text) ||
                       string.IsNullOrEmpty(txt_Fiyat.Text);

            if (bos == true)
            {
                MessageBox.Show(" Lütfen bütün seçenekleri doldurun ");
            }
            else
            {
                DataContext Db = new DataContext();
                var varmi = Db.Customers.Where(k => k.Id == Id.UserID).FirstOrDefault();
                var Renk = Db.Colors.Where(k => k.Name == lst_Renk.Text).FirstOrDefault();
                var Marka = Db.Brands.Where(k => k.Name == lst_Markalar.Text).FirstOrDefault();
                var Cins = Db.Genders.Where(k => k.Name == lst_Cins.Text).FirstOrDefault();
                var Kumas = Db.Fabrics.Where(k => k.Name == lst_Kumas2.Text).FirstOrDefault();


                Pants a = new Pants();
                a.BrandId = Marka.Id;
                a.Size = lst_Bedenler1.Text;
                a.ProductColorId = Renk.Id;
                a.GenderId = Cins.Id;
                a.Waistsize = Convert.ToInt32(lst_Bel.Text);
                a.Length = Convert.ToInt32(lst_Pant.Text);
                a.FabricId = Kumas.Id;
                a.Price = Convert.ToDouble(txt_Fiyat.Text);
                a.Type = varmi.Name;
                a.ConditionId = 2;
                Db.pants.Add(a);
                Db.SaveChanges();

                MessageBox.Show(" Pantolon başarıyla kaydedildi ");
            }
        }
    }
}