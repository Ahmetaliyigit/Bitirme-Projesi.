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
    public partial class UserMontEkle : Form
    {
        public UserMontEkle()
        {
            InitializeComponent();
        }

        private void btn_Marka_Click(object sender, EventArgs e)
        {
            lst_Markalar.Visible = !lst_Markalar.Visible;
        }

        private void btn_Beden_Click(object sender, EventArgs e)
        {
            lst_Bedenler.Visible = !lst_Bedenler.Visible;
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
            lst_Kapuson.Visible = !lst_Kapuson.Visible;
        }

        private void btn_Yaka_Click(object sender, EventArgs e)
        {
            lst_Cep.Visible = !lst_Cep.Visible;
        }

        private void btn_Kumas_Click(object sender, EventArgs e)
        {
            lst_Kumas.Visible = !lst_Kumas.Visible;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            bool bos = string.IsNullOrEmpty(lst_Markalar.Text) ||
                     string.IsNullOrEmpty(lst_Bedenler.Text) ||
                     string.IsNullOrEmpty(lst_Renk.Text) ||
                     string.IsNullOrEmpty(lst_Cins.Text) ||
                     string.IsNullOrEmpty(lst_Cep.Text) ||
                     string.IsNullOrEmpty(lst_Kumas.Text) ||
                     string.IsNullOrEmpty(lst_Kapuson.Text) ||
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
                var Kumas = Db.Fabrics.Where(k => k.Name == lst_Kumas.Text).FirstOrDefault();


                Jacket a = new Jacket();
                a.BrandId = Marka.Id;
                a.Size = lst_Bedenler.Text;
                a.ProductColorId = Renk.Id;
                a.Price = Convert.ToDouble(txt_Fiyat.Text);
                a.GenderId = Cins.Id;
                a.Hood = lst_Kapuson.Text;
                a.Pocket = lst_Cep.Text;
                a.FabricId = Kumas.Id;
                a.Type = varmi.Name;
                a.ConditionId = 2;
                Db.Jackets.Add(a);
                Db.SaveChanges();

                MessageBox.Show(" Mont başarıyla kaydedildi ");
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
