namespace ÜrünKıyafetler
{
    partial class VIPGomlekEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIPGomlekEkle));
            label1 = new Label();
            btn_Cinsiyet = new Button();
            btn_Renk = new Button();
            btn_UrunGuncel = new Button();
            btn_Urunekle = new Button();
            btn_Kol = new Button();
            lst_Markalar = new ListBox();
            lst_Bedenler = new ListBox();
            lst_Renk = new ListBox();
            lst_Cins = new ListBox();
            lst_Kol = new ListBox();
            btn_Yaka = new Button();
            lst_Yaka = new ListBox();
            btn_Kumas = new Button();
            lst_Kumas = new ListBox();
            btn_Ekle = new Button();
            button1 = new Button();
            txt_Fiyat = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(244, 225);
            label1.Name = "label1";
            label1.Size = new Size(190, 106);
            label1.TabIndex = 5;
            // 
            // btn_Cinsiyet
            // 
            btn_Cinsiyet.BackColor = SystemColors.WindowText;
            btn_Cinsiyet.BackgroundImage = (Image)resources.GetObject("btn_Cinsiyet.BackgroundImage");
            btn_Cinsiyet.FlatStyle = FlatStyle.Flat;
            btn_Cinsiyet.Location = new Point(902, 345);
            btn_Cinsiyet.Name = "btn_Cinsiyet";
            btn_Cinsiyet.Size = new Size(205, 76);
            btn_Cinsiyet.TabIndex = 9;
            btn_Cinsiyet.UseVisualStyleBackColor = false;
            btn_Cinsiyet.Click += btn_Cinsiyet_Click;
            // 
            // btn_Renk
            // 
            btn_Renk.BackColor = SystemColors.WindowText;
            btn_Renk.BackgroundImage = (Image)resources.GetObject("btn_Renk.BackgroundImage");
            btn_Renk.FlatStyle = FlatStyle.Flat;
            btn_Renk.Location = new Point(920, 233);
            btn_Renk.Name = "btn_Renk";
            btn_Renk.Size = new Size(180, 73);
            btn_Renk.TabIndex = 8;
            btn_Renk.UseVisualStyleBackColor = false;
            btn_Renk.Click += btn_Renk_Click;
            // 
            // btn_UrunGuncel
            // 
            btn_UrunGuncel.BackColor = SystemColors.WindowText;
            btn_UrunGuncel.BackgroundImage = (Image)resources.GetObject("btn_UrunGuncel.BackgroundImage");
            btn_UrunGuncel.FlatStyle = FlatStyle.Flat;
            btn_UrunGuncel.Location = new Point(902, 144);
            btn_UrunGuncel.Name = "btn_UrunGuncel";
            btn_UrunGuncel.Size = new Size(205, 64);
            btn_UrunGuncel.TabIndex = 7;
            btn_UrunGuncel.UseVisualStyleBackColor = false;
            btn_UrunGuncel.Click += btn_UrunGuncel_Click;
            // 
            // btn_Urunekle
            // 
            btn_Urunekle.BackColor = SystemColors.WindowText;
            btn_Urunekle.BackgroundImage = (Image)resources.GetObject("btn_Urunekle.BackgroundImage");
            btn_Urunekle.FlatStyle = FlatStyle.Flat;
            btn_Urunekle.Location = new Point(868, 50);
            btn_Urunekle.Name = "btn_Urunekle";
            btn_Urunekle.Size = new Size(239, 65);
            btn_Urunekle.TabIndex = 6;
            btn_Urunekle.UseVisualStyleBackColor = false;
            btn_Urunekle.Click += btn_Urunekle_Click;
            // 
            // btn_Kol
            // 
            btn_Kol.BackColor = SystemColors.WindowText;
            btn_Kol.BackgroundImage = (Image)resources.GetObject("btn_Kol.BackgroundImage");
            btn_Kol.FlatStyle = FlatStyle.Flat;
            btn_Kol.Location = new Point(951, 460);
            btn_Kol.Name = "btn_Kol";
            btn_Kol.Size = new Size(166, 76);
            btn_Kol.TabIndex = 10;
            btn_Kol.UseVisualStyleBackColor = false;
            btn_Kol.Click += btn_Kol_Click;
            // 
            // lst_Markalar
            // 
            lst_Markalar.BackColor = SystemColors.InactiveCaptionText;
            lst_Markalar.ForeColor = SystemColors.Info;
            lst_Markalar.FormattingEnabled = true;
            lst_Markalar.Items.AddRange(new object[] { "Zara", "H&M", "Nike", "Adidas", "Levi’s", "Tommy Hilfiger", "Calvin Klein", "Mango", "Puma", "Lacoste" });
            lst_Markalar.Location = new Point(1113, 50);
            lst_Markalar.Name = "lst_Markalar";
            lst_Markalar.Size = new Size(118, 64);
            lst_Markalar.TabIndex = 11;
            lst_Markalar.Visible = false;
            // 
            // lst_Bedenler
            // 
            lst_Bedenler.BackColor = SystemColors.InactiveCaptionText;
            lst_Bedenler.ForeColor = SystemColors.Info;
            lst_Bedenler.FormattingEnabled = true;
            lst_Bedenler.Items.AddRange(new object[] { "S", "M ", "L", "XL", "XXL", "3XL" });
            lst_Bedenler.Location = new Point(1113, 144);
            lst_Bedenler.Name = "lst_Bedenler";
            lst_Bedenler.Size = new Size(118, 64);
            lst_Bedenler.TabIndex = 12;
            lst_Bedenler.Visible = false;
            // 
            // lst_Renk
            // 
            lst_Renk.BackColor = SystemColors.InactiveCaptionText;
            lst_Renk.ForeColor = SystemColors.Info;
            lst_Renk.FormattingEnabled = true;
            lst_Renk.Items.AddRange(new object[] { "Siyah", "Beyaz ", "Mavi", "Lacivert", "Kırmızı ", "Yeşik", "Gri", "Bordo", "Kahverengi" });
            lst_Renk.Location = new Point(1106, 242);
            lst_Renk.Name = "lst_Renk";
            lst_Renk.Size = new Size(125, 64);
            lst_Renk.TabIndex = 13;
            lst_Renk.Visible = false;
            // 
            // lst_Cins
            // 
            lst_Cins.BackColor = SystemColors.InactiveCaptionText;
            lst_Cins.ForeColor = SystemColors.Info;
            lst_Cins.FormattingEnabled = true;
            lst_Cins.Items.AddRange(new object[] { "Kadın", "ERKEK" });
            lst_Cins.Location = new Point(1106, 357);
            lst_Cins.Name = "lst_Cins";
            lst_Cins.Size = new Size(125, 64);
            lst_Cins.TabIndex = 14;
            lst_Cins.Visible = false;
            // 
            // lst_Kol
            // 
            lst_Kol.BackColor = SystemColors.InactiveCaptionText;
            lst_Kol.ForeColor = SystemColors.Info;
            lst_Kol.FormattingEnabled = true;
            lst_Kol.Items.AddRange(new object[] { "Ksıa", "Uzun", "Kolsuz" });
            lst_Kol.Location = new Point(1106, 460);
            lst_Kol.Name = "lst_Kol";
            lst_Kol.Size = new Size(125, 64);
            lst_Kol.TabIndex = 15;
            lst_Kol.Visible = false;
            // 
            // btn_Yaka
            // 
            btn_Yaka.BackColor = SystemColors.WindowText;
            btn_Yaka.BackgroundImage = (Image)resources.GetObject("btn_Yaka.BackgroundImage");
            btn_Yaka.FlatStyle = FlatStyle.Flat;
            btn_Yaka.Location = new Point(941, 568);
            btn_Yaka.Name = "btn_Yaka";
            btn_Yaka.Size = new Size(166, 76);
            btn_Yaka.TabIndex = 16;
            btn_Yaka.UseVisualStyleBackColor = false;
            btn_Yaka.Click += btn_Yaka_Click;
            // 
            // lst_Yaka
            // 
            lst_Yaka.BackColor = SystemColors.InactiveCaptionText;
            lst_Yaka.ForeColor = SystemColors.Info;
            lst_Yaka.FormattingEnabled = true;
            lst_Yaka.Items.AddRange(new object[] { "Düz", "Hakim", "İtalyan", "Düğmeli" });
            lst_Yaka.Location = new Point(1123, 580);
            lst_Yaka.Name = "lst_Yaka";
            lst_Yaka.Size = new Size(108, 64);
            lst_Yaka.TabIndex = 17;
            lst_Yaka.Visible = false;
            // 
            // btn_Kumas
            // 
            btn_Kumas.BackColor = SystemColors.WindowText;
            btn_Kumas.BackgroundImage = (Image)resources.GetObject("btn_Kumas.BackgroundImage");
            btn_Kumas.FlatStyle = FlatStyle.Flat;
            btn_Kumas.Location = new Point(904, 685);
            btn_Kumas.Name = "btn_Kumas";
            btn_Kumas.Size = new Size(203, 76);
            btn_Kumas.TabIndex = 18;
            btn_Kumas.UseVisualStyleBackColor = false;
            btn_Kumas.Click += btn_Kumas_Click;
            // 
            // lst_Kumas
            // 
            lst_Kumas.BackColor = SystemColors.InactiveCaptionText;
            lst_Kumas.ForeColor = SystemColors.Info;
            lst_Kumas.FormattingEnabled = true;
            lst_Kumas.Items.AddRange(new object[] { "Pamuk", "Polyester", "Keten", "İpek", "Yün", "Likralı" });
            lst_Kumas.Location = new Point(1123, 697);
            lst_Kumas.Name = "lst_Kumas";
            lst_Kumas.Size = new Size(108, 64);
            lst_Kumas.TabIndex = 19;
            lst_Kumas.Visible = false;
            // 
            // btn_Ekle
            // 
            btn_Ekle.BackgroundImage = (Image)resources.GetObject("btn_Ekle.BackgroundImage");
            btn_Ekle.Location = new Point(1333, 357);
            btn_Ekle.Name = "btn_Ekle";
            btn_Ekle.Size = new Size(140, 76);
            btn_Ekle.TabIndex = 20;
            btn_Ekle.UseVisualStyleBackColor = true;
            btn_Ekle.Click += btn_Ekle_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowText;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(258, 49);
            button1.Name = "button1";
            button1.Size = new Size(176, 65);
            button1.TabIndex = 21;
            button1.UseVisualStyleBackColor = false;
            // 
            // txt_Fiyat
            // 
            txt_Fiyat.BackColor = SystemColors.InactiveCaptionText;
            txt_Fiyat.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_Fiyat.ForeColor = SystemColors.InactiveBorder;
            txt_Fiyat.Location = new Point(440, 50);
            txt_Fiyat.MaxLength = 4;
            txt_Fiyat.Multiline = true;
            txt_Fiyat.Name = "txt_Fiyat";
            txt_Fiyat.ShortcutsEnabled = false;
            txt_Fiyat.Size = new Size(125, 64);
            txt_Fiyat.TabIndex = 23;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Location = new Point(244, 568);
            button2.Name = "button2";
            button2.Size = new Size(255, 142);
            button2.TabIndex = 39;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // VIPGomlekEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1521, 809);
            Controls.Add(button2);
            Controls.Add(txt_Fiyat);
            Controls.Add(button1);
            Controls.Add(btn_Ekle);
            Controls.Add(lst_Kumas);
            Controls.Add(btn_Kumas);
            Controls.Add(lst_Yaka);
            Controls.Add(btn_Yaka);
            Controls.Add(lst_Kol);
            Controls.Add(lst_Cins);
            Controls.Add(lst_Renk);
            Controls.Add(lst_Bedenler);
            Controls.Add(lst_Markalar);
            Controls.Add(btn_Kol);
            Controls.Add(btn_Cinsiyet);
            Controls.Add(btn_Renk);
            Controls.Add(btn_UrunGuncel);
            Controls.Add(btn_Urunekle);
            Controls.Add(label1);
            Name = "VIPGomlekEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VIPUrunEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Cinsiyet;
        private Button btn_Renk;
        private Button btn_UrunGuncel;
        private Button btn_Urunekle;
        private Button btn_Kol;
        private ListBox lst_Markalar;
        private ListBox lst_Bedenler;
        private ListBox lst_Renk;
        private ListBox lst_Cins;
        private ListBox lst_Kol;
        private Button btn_Yaka;
        private ListBox lst_Yaka;
        private Button btn_Kumas;
        private ListBox lst_Kumas;
        private Button btn_Ekle;
        private Button button1;
        private TextBox txt_Fiyat;
        private Button button2;
    }
}