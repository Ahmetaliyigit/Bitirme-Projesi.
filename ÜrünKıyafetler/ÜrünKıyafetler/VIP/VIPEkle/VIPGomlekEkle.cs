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
    public partial class VIPGomlekEkle : Form
    {

        DataContext Db = new DataContext();

        public VIPGomlekEkle()
        {
            InitializeComponent();
        }

        private void btn_Urunekle_Click(object sender, EventArgs e)
        {
            lst_Markalar.Visible = !lst_Markalar.Visible;
        }

        private void btn_UrunGuncel_Click(object sender, EventArgs e)
        {
            lst_Bedenler.Visible = !lst_Bedenler.Visible;
        }

        private void btn_Renk_Click(object sender, EventArgs e)
        {
            lst_Renk.Visible = !lst_Renk.Visible;
        }

        private void btn_Cinsiyet_Click(object sender, EventArgs e)
        {
            lst_Cins.Visible = !lst_Cins.Visible;
        }

        private void btn_Kol_Click(object sender, EventArgs e)
        {
            lst_Kol.Visible = !lst_Kol.Visible;
        }

        private void btn_Yaka_Click(object sender, EventArgs e)
        {
            lst_Yaka.Visible = !lst_Yaka.Visible;
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
                     string.IsNullOrEmpty(lst_Yaka.Text) ||
                     string.IsNullOrEmpty(lst_Kumas.Text) ||
                     string.IsNullOrEmpty(lst_Kol.Text) ||
                     string.IsNullOrEmpty(txt_Fiyat.Text);

            if (bos == true)
            {
                MessageBox.Show(" Lütfen bütün seçenekleri doldurun ");
            }
            else
            {

                Shirt a = new Shirt();

                var Renk = Db.Colors.Where(k => k.Name == lst_Renk.Text).FirstOrDefault();
                var varmi = Db.Customers.Where(k => k.Id == Id.UserID).FirstOrDefault();
                var Marka = Db.Brands.Where(k => k.Name == lst_Markalar.Text).FirstOrDefault();
                var Cins = Db.Genders.Where(k => k.Name == lst_Cins.Text).FirstOrDefault();
                var Kumas = Db.Fabrics.Where(k => k.Name == lst_Kumas.Text).FirstOrDefault();

                a.BrandId = Marka.Id;
                a.Size = lst_Bedenler.Text;
                a.ProductColorId = Renk.Id;
                a.Price = 0;
                a.Collar = lst_Yaka.Text;
                a.FabricId = Kumas.Id;
                a.sleve = lst_Kol.Text;
                a.ConditionId = 1;
                a.Price = Convert.ToDouble(txt_Fiyat.Text);
                a.ConditionId = 1;
                a.Type = "Sifir";
                a.GenderId = Cins.Id;
                Db.Shirts.Add(a);
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
