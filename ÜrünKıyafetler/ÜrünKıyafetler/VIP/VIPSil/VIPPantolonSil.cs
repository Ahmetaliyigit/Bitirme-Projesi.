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
    public partial class VIPPantolonSil : Form
    {
        public VIPPantolonSil()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dvg_PantolonList.AutoGenerateColumns = true;

            using (var context = new DataContext())
            {
                var productList = context.pants.ToList();

                dvg_PantolonList.DataSource = productList;


            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            DataContext Db = new DataContext();
            bool Donus = int.TryParse(txt_Id.Text, out int a);

            

            if (Donus == true)
            {
                Pants Urun = Db.pants.Where(k => k.Id == Convert.ToInt32(txt_Id.Text)).FirstOrDefault();
                Db.pants.Remove(Urun);
                Db.SaveChanges();
                MessageBox.Show(" Ürün Silindi");
                using (var context = new DataContext())
                {
                    var productList = context.pants.ToList();

                    dvg_PantolonList.DataSource = productList;


                }
            }
            else
            {
                MessageBox.Show(" Lütfen geçerli bir Id girin ");
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
