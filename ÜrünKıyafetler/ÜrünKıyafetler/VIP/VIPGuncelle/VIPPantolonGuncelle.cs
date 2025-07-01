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
    public partial class VIPPantolonGuncelle : Form
    {
        public VIPPantolonGuncelle()
        {
            InitializeComponent();
        }

        private void MainForm_Load1(object sender, EventArgs e)
        {
            dvg_MontList.AutoGenerateColumns = true;

            using (var context = new DataContext())
            {
                var productList = context.pants.ToList();

                dvg_MontList.DataSource = productList;


            }
        }

        private void btn_MarkaGun_Click(object sender, EventArgs e)
        {
            lst_MarkaGun.Visible = !lst_MarkaGun.Visible;
        }

        private void btn_BedenGun_Click(object sender, EventArgs e)
        {
            lst_BedenGun.Visible = !lst_BedenGun.Visible;
        }

        private void btn_KumasGun_Click(object sender, EventArgs e)
        {
            lst_KumasGun.Visible = !lst_KumasGun.Visible;
        }

        private void btn_RenkGun_Click(object sender, EventArgs e)
        {
            lst_RenkGun.Visible = !lst_RenkGun.Visible;
        }

        private void btn_CinsiyetGun_Click(object sender, EventArgs e)
        {
            lst_CinsGun.Visible = !lst_CinsGun.Visible;
        }

        private void btn_BelGun_Click(object sender, EventArgs e)
        {
            lst_BelGun.Visible = !lst_BelGun.Visible;
        }

        private void btn_PantGun_Click(object sender, EventArgs e)
        {
            lst_PantGun.Visible = !lst_PantGun.Visible;
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            DataContext Guncel = new DataContext();
            bool donus = int.TryParse(txt_Id.Text, out int a);
            

            if (donus == true && Guncel != null)
            {
                var varmi = Guncel.pants.Where(k => k.Id == Convert.ToInt32(txt_Id.Text)).FirstOrDefault();
                var Renk = Guncel.Colors.Where(k => k.Name == lst_RenkGun.Text).FirstOrDefault();
                var Marka = Guncel.Brands.Where(k => k.Name == lst_MarkaGun.Text).FirstOrDefault();
                var Cins = Guncel.Brands.Where(k => k.Name == lst_CinsGun.Text).FirstOrDefault();
                var Kumas = Guncel.Fabrics.Where(k => k.Name == lst_KumasGun.Text).FirstOrDefault();

                varmi.Waistsize = string.IsNullOrEmpty(lst_BelGun.Text) ? varmi.Waistsize : Convert.ToInt32(lst_BelGun.Text);
                varmi.Length = string.IsNullOrEmpty(lst_PantGun.Text) ? varmi.Length : Convert.ToInt32(lst_PantGun.Text);
                varmi.FabricId = string.IsNullOrEmpty(lst_KumasGun.Text) ? varmi.FabricId : Kumas.Id;
                varmi.BrandId = string.IsNullOrEmpty(lst_MarkaGun.Text) ? varmi.BrandId : Marka.Id;
                varmi.Size = string.IsNullOrEmpty(lst_BedenGun.Text) ? varmi.Size : lst_BedenGun.Text;
                varmi.ProductColorId = string.IsNullOrEmpty(lst_RenkGun.Text) ? varmi.ProductColorId : Renk.Id;
                varmi.Price = string.IsNullOrEmpty(txt_FiyatGun.Text) ? varmi.Price : Convert.ToDouble(txt_FiyatGun.Text); ;
                varmi.GenderId = string.IsNullOrEmpty(lst_CinsGun.Text) ? varmi.GenderId : Cins.Id;

                Guncel.SaveChanges();
                MessageBox.Show(" Ürün başarıyla güncellendi ");
                using (var context = new DataContext())
                {
                    var productList = context.pants.ToList();

                    dvg_MontList.DataSource = productList;


                }
            }
            else
            {
                MessageBox.Show(" Lütfen Geçerli bir Id Girin ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VIPLogin a = new VIPLogin();
            a.Show();
            this.Hide();
        }
    }
}
