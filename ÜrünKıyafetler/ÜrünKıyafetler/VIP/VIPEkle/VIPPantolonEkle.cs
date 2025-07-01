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
    public partial class VIPPantolonEkle : Form
    {

        public VIPPantolonEkle()
        {
            InitializeComponent();
        }





        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            bool bos = string.IsNullOrEmpty(lst_Markalar1.Text) ||
                       string.IsNullOrEmpty(lst_Bedenler1.Text) ||
                       string.IsNullOrEmpty(lst_Renk1.Text) ||
                       string.IsNullOrEmpty(lst_Cins1.Text) ||
                       string.IsNullOrEmpty(lst_Bel.Text) ||
                       string.IsNullOrEmpty(lst_Kumas2.Text) ||
                       string.IsNullOrEmpty(lst_Pant.Text) ||
                       string.IsNullOrEmpty(txt_Fiyat2.Text);

            if (bos == true)
            {
                MessageBox.Show(" Lütfen bütün seçenekleri doldurun ");
            }
            else
            {
                DataContext Db = new DataContext();

                var varmi = Db.Customers.Where(k => k.Id == Id.UserID).FirstOrDefault();
                var Renk = Db.Colors.Where(k => k.Name == lst_Renk1.Text).FirstOrDefault();
                var Marka = Db.Brands.Where(k => k.Name == lst_Markalar1.Text).FirstOrDefault();
                var Cins = Db.Genders.Where(k => k.Name == lst_Cins1.Text).FirstOrDefault();
                var Kumas = Db.Fabrics.Where(k => k.Name == lst_Kumas2.Text).FirstOrDefault();

                Pants a = new Pants();
                a.BrandId = Marka.Id;
                a.Size = lst_Bedenler1.Text;
                a.ProductColorId = Renk.Id;
                a.Price = 0;
                a.GenderId = Cins.Id;
                a.Waistsize = Convert.ToInt32(lst_Bel.Text);
                a.Length = Convert.ToInt32(lst_Pant.Text);
                a.FabricId = Cins.Id;
                a.Type = "Sifir";
                a.ConditionId = 1;
                a.Price = Convert.ToDouble(txt_Fiyat2.Text);
                Db.pants.Add(a);
                Db.SaveChanges();

                MessageBox.Show(" Pantolon başarıyla kaydedildi ");


            }
        }

        private void btn_Urunekle1_Click(object sender, EventArgs e)
        {
            lst_Markalar1.Visible = !lst_Markalar1.Visible;
        }

        private void btn_Beden_Click(object sender, EventArgs e)
        {
            lst_Bedenler1.Visible = !lst_Bedenler1.Visible;
        }

        private void btn_Renk1_Click(object sender, EventArgs e)
        {
            lst_Renk1.Visible = !lst_Renk1.Visible;
        }

        private void btn_Cinsiyet1_Click(object sender, EventArgs e)
        {
            lst_Cins1.Visible = !lst_Cins1.Visible;
        }

        private void btn_Bel_Click(object sender, EventArgs e)
        {
            lst_Bel.Visible = !lst_Bel.Visible;
        }

        private void btn_Pant_Click(object sender, EventArgs e)
        {
            lst_Pant.Visible = !lst_Pant.Visible;
        }

        private void btn_Kumas2_Click(object sender, EventArgs e)
        {
            lst_Kumas2.Visible = !lst_Kumas2.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VIPLogin a = new VIPLogin();
            a.Show();
            this.Hide();
        }
    }
}
