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
    public partial class VIPMontEkle : Form
    {
        public VIPMontEkle()
        {
            InitializeComponent();
        }

        private void btn_Marka3_Click(object sender, EventArgs e)
        {
            lst_Markalar3.Visible = !lst_Markalar3.Visible;
        }

        private void btn_Beden3_Click(object sender, EventArgs e)
        {
            lst_Bedenler3.Visible = !lst_Bedenler3.Visible;
        }

        private void btn_Renk3_Click(object sender, EventArgs e)
        {
            lst_Renk3.Visible = !lst_Renk3.Visible;
        }

        private void btn_Cinsiyet3_Click(object sender, EventArgs e)
        {
            lst_Cins3.Visible = !lst_Cins3.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VIPLogin a = new VIPLogin();
            a.Show();
            this.Hide();
        }

        private void btn_Kapuson_Click(object sender, EventArgs e)
        {
            lst_Kapuson.Visible = !lst_Kapuson.Visible;
        }

        private void btn_Cep_Click(object sender, EventArgs e)
        {
            lst_Cep.Visible = !lst_Cep.Visible;
        }

        private void btn_Kumas_Click(object sender, EventArgs e)
        {
            lst_Kumas.Visible = !lst_Kumas.Visible;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            bool bos = string.IsNullOrEmpty(lst_Markalar3.Text) ||
                      string.IsNullOrEmpty(lst_Bedenler3.Text) ||
                      string.IsNullOrEmpty(lst_Renk3.Text) ||
                      string.IsNullOrEmpty(lst_Cins3.Text) ||
                      string.IsNullOrEmpty(lst_Kapuson.Text) ||
                      string.IsNullOrEmpty(lst_Kumas.Text) ||
                      string.IsNullOrEmpty(lst_Cep.Text) ||
                      string.IsNullOrEmpty(txt_Fiyat3.Text);

            if (bos == true)
            {
                MessageBox.Show(" Lütfen bütün seçenekleri doldurun ");
            }
            else
            {
                DataContext Db = new DataContext();

                var varmi = Db.Customers.Where(k => k.Id == Id.UserID).FirstOrDefault();
                var Renk = Db.Colors.Where(k => k.Name == lst_Renk3.Text).FirstOrDefault();
                var Marka = Db.Brands.Where(k => k.Name == lst_Markalar3.Text).FirstOrDefault();
                var Cins = Db.Genders.Where(k => k.Name == lst_Cins3.Text).FirstOrDefault();
                var Kumas = Db.Fabrics.Where(k => k.Name == lst_Kumas.Text).FirstOrDefault();

                Jacket a = new Jacket();
                a.BrandId = Marka.Id;
                a.Size = lst_Bedenler3.Text;
                a.ProductColorId = Renk.Id;
                a.Price = Convert.ToDouble(txt_Fiyat3.Text);
                a.GenderId = Cins.Id;
                a.Hood = lst_Kapuson.Text;
                a.Pocket = lst_Cep.Text;
                a.FabricId = Kumas.Id;
                a.Type = "Sifir";
                a.ConditionId = 1;
                Db.Jackets.Add(a);
                Db.SaveChanges();

                MessageBox.Show(" Pantolon başarıyla kaydedildi ");
            }
        }
    }
}
