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
    public partial class VIPTisortSil : Form
    {
        public VIPTisortSil()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dvg_TisortList.AutoGenerateColumns = true;

            using (var context = new DataContext())
            {
                var productList = context.Tshirts.ToList();

                dvg_TisortList.DataSource = productList;


            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            DataContext Db = new DataContext();

            bool donus = int.TryParse(txt_Id.Text, out int a);
            

            if (donus == true && txt_Id.Text != "")
            {
                Tshirt Urun = Db.Tshirts.Where(k => k.Id == Convert.ToInt32(txt_Id.Text)).FirstOrDefault();
                Db.Tshirts.Remove(Urun);
                Db.SaveChanges();
                MessageBox.Show(" Ürün Silindi");
                using (var context = new DataContext())
                {
                    var productList = context.Tshirts.ToList();

                    dvg_TisortList.DataSource = productList;


                }
            }
            else
            {
                MessageBox.Show(" Lütfen Geçerli Id yi girin");
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
