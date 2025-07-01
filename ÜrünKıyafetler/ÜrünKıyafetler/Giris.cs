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
    public partial class Giris : Form
    {
        DataContext Db = new DataContext();
        public Giris()
        {
            InitializeComponent();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            Menu a = new Menu();
            a.Show();
            this.Hide();
        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            string Name = txt_Name.Text;
            string Password = txt_Pass.Text;

            if (Password == "" && Name == "") 
            {
                VIPLogin a = new VIPLogin();    
                this.Hide();
                a.Show();
            }
            else
            {

                var User = Db.Customers.Where(k => k.Name == Name && k.Pass == Password).FirstOrDefault();

                if (User != null)
                {
                    
                    Id.UserID = User.Id;
                    KullaniciMenu a = new KullaniciMenu();
                    this.Hide();
                    a.Show();                   
                }
                else
                {
                    MessageBox.Show(" Giriş Başarısız ");
                }
            }


           
        }
    }
}
