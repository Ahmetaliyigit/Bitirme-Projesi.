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
    public partial class VIPGomlekSil : Form
    {
        public VIPGomlekSil()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dvg_GomlekList.AutoGenerateColumns = true;

            using (var context = new DataContext())
            {
                var productList = context.Shirts.ToList();

                dvg_GomlekList.DataSource = productList;


            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            DataContext Db = new DataContext();
            
            bool Donus = int.TryParse(txt_Id.Text, out int a);

            if (txt_Id.Text != "" && Donus == true)
            {
                Shirt Urun = Db.Shirts.Where(k => k.Id == Convert.ToInt32(txt_Id.Text)).FirstOrDefault();
                Db.Shirts.Remove(Urun);
                Db.SaveChanges();
                MessageBox.Show(" Ürün Silindi");
                using (var context = new DataContext())
                {
                    var productList = context.Shirts.ToList();

                    dvg_GomlekList.DataSource = productList;


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
