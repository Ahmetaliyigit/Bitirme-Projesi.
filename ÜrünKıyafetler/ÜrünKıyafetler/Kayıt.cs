
using System.Data.SqlClient;

namespace ÜrünKıyafetler
{
    public partial class Kayıt : Form
    {
        DataContext Dt = new DataContext();

        public Kayıt()
        {
            InitializeComponent();
        }

        private void btn_Kaydol_Click(object sender, EventArgs e)
        {
            string Name = txt_Name.Text;
            string Password = txt_Pass.Text;
            string Password2 = txt_Pass2.Text;
            bool varmi = true;

            if (Password == Password2)
            {

                varmi = Dt.Customers.Any(k => k.Name == Name && k.Pass == Password);

                if (varmi != true)
                {
                    Customer kullanici = new Customer();
                    kullanici.Name = Name;
                    kullanici.Pass = Password;
                    kullanici.Balance = 0;

                    Dt.Customers.Add(kullanici);
                    Dt.SaveChanges();
                    MessageBox.Show(" Kayıt Başarılı");


                }
                else if (varmi == true)
                {
                    MessageBox.Show(" Bu kullanıcı adı kullanılıyor ");
                }
            }
            else
            {
                MessageBox.Show(" Şifreler uyuşmuyor ");
            }
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            Menu a = new Menu();
            a.Show();
            this.Hide();
        }




    }
}


  
