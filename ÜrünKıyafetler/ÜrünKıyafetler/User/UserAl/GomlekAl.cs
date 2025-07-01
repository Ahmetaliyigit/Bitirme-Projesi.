using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class GomlekAl : Form
    {
        DataContext Db = new DataContext();

        public GomlekAl()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dvg_GomlekList.AutoGenerateColumns = true;
            var user = Db.Customers.Where(k => k.Id == Id.UserID).FirstOrDefault();
            txt_Bakiye.Text = Convert.ToString(user.Balance);
            using (var context = new DataContext())
            {
                var productList = context.Shirts.ToList();

                dvg_GomlekList.DataSource = productList;

            }
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {

            
            bool Donus = int.TryParse(txt_Id.Text, out int adana);

            var user = Db.Customers.Where(k => k.Id == Id.UserID).FirstOrDefault();

            if (Donus == true)
            {
                if (user != null)
                {
                    var urun = Db.Shirts.Where(k => k.Id == Convert.ToInt32(txt_Id.Text)).FirstOrDefault();

                    var Sifirmi = Db.Shirts.Where(k => k.ConditionId == urun.ConditionId).FirstOrDefault();

                    if (urun != null)
                    {
                        if (urun.Price > user.Balance)
                        {
                            MessageBox.Show(" Bakiyeniz bu ürün için yetersiz ");
                        }
                        else
                        {
                            MessageBox.Show(" Ürün satın alındı ");
                            if (Sifirmi != null)
                            {
                                var Kisi = Db.Customers.Where(k => k.Name == urun.Type).FirstOrDefault();
                                Kisi.Balance += urun.Price;  
                            }
                            user.Balance -= urun.Price;
                            txt_Bakiye.Text = Convert.ToString(user.Balance);
                            Db.Shirts.Remove(urun);                           
                            Db.SaveChanges();
                            using (var context = new DataContext())
                            {
                                var productList = context.Shirts.ToList();

                                dvg_GomlekList.DataSource = productList;

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Lütfen geçerli Id girin ");
                    }
                }
                else
                {
                    MessageBox.Show(" Kullanıcı Bulunamadı ");
                }
            }
            else
            {
                MessageBox.Show(" Lütfen geçerli Id Giriniz ");
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
