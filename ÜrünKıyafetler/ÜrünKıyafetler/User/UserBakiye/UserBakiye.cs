using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÜrünKıyafetler.User.UserBakiye
{
    public partial class UserBakiye : Form
    {
        DataContext Db = new DataContext();
        public UserBakiye()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var user = Db.Customers.Where(k => k.Id == Id.UserID).FirstOrDefault();
            txt_Bakiye.Text = Convert.ToString(user.Balance);
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            var user = Db.Customers.Where(k => k.Id == Id.UserID).FirstOrDefault();
            bool Donus = int.TryParse(txt_BakiyeYukle.Text, out int a);

            if (Donus == true)
            {
                user.Balance += Convert.ToDouble(txt_BakiyeYukle.Text);
                MessageBox.Show(" Bakiyeniz güncellendi ");
                Db.SaveChanges();
                txt_Bakiye.Text = Convert.ToString(user.Balance);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullaniciMenu a = new KullaniciMenu();
            this.Hide();
            a.Show();
        }
    }
}
