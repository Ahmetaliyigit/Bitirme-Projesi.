using Microsoft.EntityFrameworkCore;
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
    public partial class VIPKullanici : Form
    {
        public VIPKullanici()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            dvg_KullaniciList.AutoGenerateColumns = true;

            using (var context = new DataContext())
            {
                var productList = context.Customers.ToList();

                dvg_KullaniciList.DataSource = productList;


            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            VIPLogin a = new VIPLogin();
            a.Show();
            this.Hide();
        }

        private void btn_Banla_Click(object sender, EventArgs e)
        {
            DataContext a = new DataContext();
            bool Donus = int.TryParse(txt_Id.Text, out int da);

            if (txt_Id.Text != "" && Donus != null)
            {
                var Custom = a.Customers.Where(k => k.Id == Convert.ToInt32(txt_Id.Text)).FirstOrDefault();

                for (int i = 1; i > 0; i++)
                {
                    var varmi = a.Shirts.Where(k => k.Type == Custom.Name).FirstOrDefault();
                    var varmi1 = a.Jackets.Where(k => k.Type == Custom.Name).FirstOrDefault();
                    var varmi2 = a.pants.Where(k => k.Type == Custom.Name).FirstOrDefault();
                    var varmi3 = a.Tshirts.Where(k => k.Type == Custom.Name).FirstOrDefault();

                    
                    if (varmi != null)
                    {
                        a.Shirts.Remove(varmi);
                        a.SaveChanges();
                        continue;
                    }
                    else if (varmi1 != null)
                    {
                        a.Jackets.Remove(varmi1);
                        a.SaveChanges();
                        continue;
                    }
                    else if (varmi2 != null)
                    {
                        a.pants.Remove(varmi2);
                        a.SaveChanges();
                        continue;
                    }
                    else if (varmi3 != null)
                    {
                        a.Tshirts.Remove(varmi3);
                        a.SaveChanges();
                        continue;
                    }
                    else
                    {
                        i = -432;
                    }
                    
                }

                a.Customers.Remove(Custom);
                a.SaveChanges();
                MessageBox.Show(" Kullanıcı Banlandı ");
                using (var context = new DataContext())
                {
                    var productList = context.Customers.ToList();

                    dvg_KullaniciList.DataSource = productList;
                }
            }
            else
            {
                MessageBox.Show(" Lütfen geçerli Id yi girin ");
            }
        }
    }
}
