using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÜrünKıyafetler.User.UsersMenu.UserSil
{
    public partial class UserPantolonSil : Form
    {
        public UserPantolonSil()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dvg_GomlekList.AutoGenerateColumns = true;

            DataContext context = new DataContext();

            var varmi = context.Customers.Where(k => k.Id == Id.UserID).FirstOrDefault();
            var productList = context.pants.Where(k => k.Type == varmi.Name).ToList();

            dvg_GomlekList.DataSource = productList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataContext Db = new DataContext();

            bool Donus = int.TryParse(txt_Id.Text, out int a);

            if (Donus == true)
            {
                Pants Urun = Db.pants.Where(k => k.Id == Convert.ToInt32(txt_Id.Text)).FirstOrDefault();
                Db.pants.Remove(Urun);
                Db.SaveChanges();
                MessageBox.Show(" Ürün Silindi");


                dvg_GomlekList.AutoGenerateColumns = true;

                DataContext context = new DataContext();

                var varmi = context.Customers.Where(k => k.Id == Id.UserID).FirstOrDefault();
                var productList = context.pants.Where(k => k.Type == varmi.Name).ToList();

                dvg_GomlekList.DataSource = productList;
            }
            else
            {
                MessageBox.Show(" Lütfen geçerli bir Id girin ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UsersMenu a = new UsersMenu();
            a.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
