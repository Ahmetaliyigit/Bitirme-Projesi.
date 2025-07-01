using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÜrünKıyafetler.User.UsersMenu.UserGuncelle
{
    public partial class UserMontGuncelle : Form
    {
        public UserMontGuncelle()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dvg_GomlekList.AutoGenerateColumns = true;

            DataContext context = new DataContext();

            var varmi = context.Customers.Where(k => k.Id == Id.UserID).FirstOrDefault();
            var productList = context.Jackets.Where(k => k.Type == varmi.Name).ToList();

            dvg_GomlekList.DataSource = productList;
        }

        private void btn_Marka_Click(object sender, EventArgs e)
        {
            lst_Markalar.Visible = !lst_Markalar.Visible;
        }

        private void btn_Beden_Click(object sender, EventArgs e)
        {
            lst_Bedenler.Visible = !lst_Bedenler.Visible;
        }

        private void btn_Kumas_Click(object sender, EventArgs e)
        {
            lst_Kumas.Visible = !lst_Kumas.Visible;
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
            lst_Kapuson.Visible = !lst_Kapuson.Visible;
        }

        private void btn_Cep_Click(object sender, EventArgs e)
        {
            lst_Cep.Visible = !lst_Cep.Visible;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            DataContext Guncel = new DataContext();
            bool donus = int.TryParse(txt_Id.Text, out int a);
            var Renk = Guncel.Colors.Where(k => k.Name == lst_Renk.Text).FirstOrDefault();
            var Marka = Guncel.Brands.Where(k => k.Name == lst_Markalar.Text).FirstOrDefault();
            var Cins = Guncel.Brands.Where(k => k.Name == lst_Cins.Text).FirstOrDefault();
            var Kumas = Guncel.Fabrics.Where(k => k.Name == lst_Kumas.Text).FirstOrDefault();


            if (donus == true && Guncel != null)
            {
                var varmi = Guncel.Jackets.Where(k => k.Id == Convert.ToInt32(txt_Id.Text)).FirstOrDefault();

                varmi.Hood = string.IsNullOrEmpty(lst_Kapuson.Text) ? varmi.Hood : lst_Kapuson.Text;
                varmi.Pocket = string.IsNullOrEmpty(lst_Cep.Text) ? varmi.Pocket : lst_Cep.Text;
                varmi.FabricId = string.IsNullOrEmpty(lst_Kumas.Text) ? varmi.FabricId : Kumas.Id;
                varmi.BrandId = string.IsNullOrEmpty(lst_Markalar.Text) ? varmi.BrandId : Marka.Id;
                varmi.Size = string.IsNullOrEmpty(lst_Bedenler.Text) ? varmi.Size : lst_Bedenler.Text;
                varmi.ProductColorId = string.IsNullOrEmpty(lst_Renk.Text) ? varmi.ProductColorId : Renk.Id;
                varmi.Price = string.IsNullOrEmpty(txt_Fiyat.Text) ? varmi.Price : Convert.ToDouble(txt_Fiyat.Text); ;
                varmi.GenderId = string.IsNullOrEmpty(lst_Cins.Text) ? varmi.GenderId : Cins.Id;

                Guncel.SaveChanges();
                MessageBox.Show(" Ürün başarıyla güncellendi ");

                dvg_GomlekList.AutoGenerateColumns = true;

                DataContext context = new DataContext();

                var varmi2 = context.Customers.Where(k => k.Id == Id.UserID).FirstOrDefault();
                var productList = context.Jackets.Where(k => k.Type == varmi2.Name).ToList();

                dvg_GomlekList.DataSource = productList;
            }
            else
            {
                MessageBox.Show(" Lütfen Geçerli bir Id Girin ");
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
