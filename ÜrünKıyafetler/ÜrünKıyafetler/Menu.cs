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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            //this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch; Bunu yapmadım hpcam çünkü bununla beraber butonlar hareket etmiyor onlar içinde ayrı kod yazılması gerektiğinden uğraşmadım . Dersinizden 5 dakika çalığım için kusura bakmayın :.)
        }

        private void btn_Kayit_Click(object sender, EventArgs e)
        {
            Kayıt a = new Kayıt();
            a.Show();
            this.Hide();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            Giris a = new Giris();
            a.Show();
            this.Hide();
        }
    }
}
