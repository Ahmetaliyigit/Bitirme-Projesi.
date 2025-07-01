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
    public partial class VIPTisort : Form
    {
        public VIPTisort()
        {
            InitializeComponent();
        }

        private void btn_Marka4_Click(object sender, EventArgs e)
        {
            lst_Markalar4.Visible = !lst_Markalar4.Visible;
        }

        private void btn_Beden4_Click(object sender, EventArgs e)
        {
            lst_Bedenler4.Visible = !lst_Bedenler4.Visible;
        }

        private void btn_Renk4_Click(object sender, EventArgs e)
        {
            lst_Renk4.Visible = !lst_Renk4.Visible;
        }

        private void btn_Cinsiyet4_Click(object sender, EventArgs e)
        {
            lst_Cins4.Visible = !lst_Cins4.Visible;
        }

        private void btn_Kol2_Click(object sender, EventArgs e)
        {
            lst_Kol2.Visible = !lst_Kol2.Visible;
        }

        private void btn_Yaka2_Click(object sender, EventArgs e)
        {
            lst_Yaka2.Visible = !lst_Yaka2.Visible;
        }

        private void btn_Kumas2_Click(object sender, EventArgs e)
        {
            lst_Kumas2.Visible = !lst_Kumas2.Visible;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            bool bos = string.IsNullOrEmpty(lst_Markalar4.Text) ||
                     string.IsNullOrEmpty(lst_Bedenler4.Text) ||
                     string.IsNullOrEmpty(lst_Renk4.Text) ||
                     string.IsNullOrEmpty(lst_Cins4.Text) ||
                     string.IsNullOrEmpty(lst_Kol2.Text) ||
                     string.IsNullOrEmpty(lst_Kumas2.Text) ||
                     string.IsNullOrEmpty(lst_Yaka2.Text) ||
                     string.IsNullOrEmpty(txt_Fiyat4.Text);

            if (bos == true)
            {
                MessageBox.Show(" Lütfen bütün seçenekleri doldurun ");
            }
            else
            {
                DataContext Db = new DataContext();

                var varmi = Db.Customers.Where(k => k.Id == Id.UserID).FirstOrDefault();
                var Renk = Db.Colors.Where(k => k.Name == lst_Renk4.Text).FirstOrDefault();
                var Marka = Db.Brands.Where(k => k.Name == lst_Markalar4.Text).FirstOrDefault();
                var Cins = Db.Genders.Where(k => k.Name == lst_Cins4.Text).FirstOrDefault();
                var Kumas = Db.Fabrics.Where(k => k.Name == lst_Kumas2.Text).FirstOrDefault();

                Tshirt a = new Tshirt();
                a.BrandId = Marka.Id;
                a.Size = lst_Bedenler4.Text;
                a.ProductColorId = Renk.Id;
                a.Price = 0;
                a.GenderId = Cins.Id;
                a.Collar = lst_Yaka2.Text;
                a.FabricId = Kumas.Id;
                a.Type = "Sifir";
                a.ConditionId = 1;
                a.sleve = lst_Kol2.Text;
                a.Price = Convert.ToDouble(txt_Fiyat4.Text);
                Db.Tshirts.Add(a);
                Db.SaveChanges();

                MessageBox.Show(" Gömlek başarıyla kaydedildi ");


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VIPLogin a = new VIPLogin();
            a.Show();
            this.Hide();
        }
    }
}
