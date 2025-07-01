namespace ÜrünKıyafetler
{
    partial class VIPMontEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIPMontEkle));
            txt_Fiyat3 = new TextBox();
            button1 = new Button();
            btn_Ekle = new Button();
            lst_Cins3 = new ListBox();
            lst_Renk3 = new ListBox();
            lst_Bedenler3 = new ListBox();
            lst_Markalar3 = new ListBox();
            btn_Cinsiyet3 = new Button();
            btn_Renk3 = new Button();
            btn_Beden3 = new Button();
            btn_Marka3 = new Button();
            label1 = new Label();
            button2 = new Button();
            btn_Kapuson = new Button();
            lst_Kapuson = new ListBox();
            btn_Cep = new Button();
            lst_Cep = new ListBox();
            btn_Kumas = new Button();
            lst_Kumas = new ListBox();
            SuspendLayout();
            // 
            // txt_Fiyat3
            // 
            txt_Fiyat3.BackColor = SystemColors.InactiveCaptionText;
            txt_Fiyat3.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_Fiyat3.ForeColor = SystemColors.InactiveBorder;
            txt_Fiyat3.Location = new Point(419, 47);
            txt_Fiyat3.MaxLength = 4;
            txt_Fiyat3.Multiline = true;
            txt_Fiyat3.Name = "txt_Fiyat3";
            txt_Fiyat3.ShortcutsEnabled = false;
            txt_Fiyat3.Size = new Size(125, 64);
            txt_Fiyat3.TabIndex = 43;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowText;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(237, 46);
            button1.Name = "button1";
            button1.Size = new Size(176, 65);
            button1.TabIndex = 42;
            button1.UseVisualStyleBackColor = false;
            // 
            // btn_Ekle
            // 
            btn_Ekle.BackgroundImage = (Image)resources.GetObject("btn_Ekle.BackgroundImage");
            btn_Ekle.Location = new Point(1326, 352);
            btn_Ekle.Name = "btn_Ekle";
            btn_Ekle.Size = new Size(140, 76);
            btn_Ekle.TabIndex = 41;
            btn_Ekle.UseVisualStyleBackColor = true;
            btn_Ekle.Click += btn_Ekle_Click;
            // 
            // lst_Cins3
            // 
            lst_Cins3.BackColor = SystemColors.InactiveCaptionText;
            lst_Cins3.ForeColor = SystemColors.Info;
            lst_Cins3.FormattingEnabled = true;
            lst_Cins3.Items.AddRange(new object[] { "Kadın", "ERKEK" });
            lst_Cins3.Location = new Point(1099, 352);
            lst_Cins3.Name = "lst_Cins3";
            lst_Cins3.Size = new Size(125, 64);
            lst_Cins3.TabIndex = 40;
            lst_Cins3.Visible = false;
            // 
            // lst_Renk3
            // 
            lst_Renk3.BackColor = SystemColors.InactiveCaptionText;
            lst_Renk3.ForeColor = SystemColors.Info;
            lst_Renk3.FormattingEnabled = true;
            lst_Renk3.Items.AddRange(new object[] { "Siyah", "Beyaz ", "Mavi", "Lacivert", "Kırmızı ", "Mavi", "Yeşik", "Gri", "Bordo", "Kahverengi" });
            lst_Renk3.Location = new Point(1099, 244);
            lst_Renk3.Name = "lst_Renk3";
            lst_Renk3.Size = new Size(125, 64);
            lst_Renk3.TabIndex = 39;
            lst_Renk3.Visible = false;
            // 
            // lst_Bedenler3
            // 
            lst_Bedenler3.BackColor = SystemColors.InactiveCaptionText;
            lst_Bedenler3.ForeColor = SystemColors.Info;
            lst_Bedenler3.FormattingEnabled = true;
            lst_Bedenler3.Items.AddRange(new object[] { "S", "M", "L", "XL", "XXL", "3XL" });
            lst_Bedenler3.Location = new Point(1106, 143);
            lst_Bedenler3.Name = "lst_Bedenler3";
            lst_Bedenler3.Size = new Size(118, 64);
            lst_Bedenler3.TabIndex = 38;
            lst_Bedenler3.Visible = false;
            // 
            // lst_Markalar3
            // 
            lst_Markalar3.BackColor = SystemColors.InactiveCaptionText;
            lst_Markalar3.ForeColor = SystemColors.Info;
            lst_Markalar3.FormattingEnabled = true;
            lst_Markalar3.Items.AddRange(new object[] { "Zara", "H&M", "Nike", "Adidas", "Levi’s", "Tommy Hilfiger", "Calvin Klein", "Mango", "Puma", "Lacoste" });
            lst_Markalar3.Location = new Point(1106, 46);
            lst_Markalar3.Name = "lst_Markalar3";
            lst_Markalar3.Size = new Size(118, 64);
            lst_Markalar3.TabIndex = 37;
            lst_Markalar3.Visible = false;
            // 
            // btn_Cinsiyet3
            // 
            btn_Cinsiyet3.BackColor = SystemColors.WindowText;
            btn_Cinsiyet3.BackgroundImage = (Image)resources.GetObject("btn_Cinsiyet3.BackgroundImage");
            btn_Cinsiyet3.FlatStyle = FlatStyle.Flat;
            btn_Cinsiyet3.Location = new Point(888, 340);
            btn_Cinsiyet3.Name = "btn_Cinsiyet3";
            btn_Cinsiyet3.Size = new Size(205, 76);
            btn_Cinsiyet3.TabIndex = 36;
            btn_Cinsiyet3.UseVisualStyleBackColor = false;
            btn_Cinsiyet3.Click += btn_Cinsiyet3_Click;
            // 
            // btn_Renk3
            // 
            btn_Renk3.BackColor = SystemColors.WindowText;
            btn_Renk3.BackgroundImage = (Image)resources.GetObject("btn_Renk3.BackgroundImage");
            btn_Renk3.FlatStyle = FlatStyle.Flat;
            btn_Renk3.Location = new Point(913, 244);
            btn_Renk3.Name = "btn_Renk3";
            btn_Renk3.Size = new Size(180, 73);
            btn_Renk3.TabIndex = 35;
            btn_Renk3.UseVisualStyleBackColor = false;
            btn_Renk3.Click += btn_Renk3_Click;
            // 
            // btn_Beden3
            // 
            btn_Beden3.BackColor = SystemColors.WindowText;
            btn_Beden3.BackgroundImage = (Image)resources.GetObject("btn_Beden3.BackgroundImage");
            btn_Beden3.FlatStyle = FlatStyle.Flat;
            btn_Beden3.Location = new Point(888, 143);
            btn_Beden3.Name = "btn_Beden3";
            btn_Beden3.Size = new Size(205, 64);
            btn_Beden3.TabIndex = 34;
            btn_Beden3.UseVisualStyleBackColor = false;
            btn_Beden3.Click += btn_Beden3_Click;
            // 
            // btn_Marka3
            // 
            btn_Marka3.BackColor = SystemColors.WindowText;
            btn_Marka3.BackgroundImage = (Image)resources.GetObject("btn_Marka3.BackgroundImage");
            btn_Marka3.FlatStyle = FlatStyle.Flat;
            btn_Marka3.Location = new Point(854, 46);
            btn_Marka3.Name = "btn_Marka3";
            btn_Marka3.Size = new Size(239, 65);
            btn_Marka3.TabIndex = 33;
            btn_Marka3.UseVisualStyleBackColor = false;
            btn_Marka3.Click += btn_Marka3_Click;
            // 
            // label1
            // 
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(237, 220);
            label1.Name = "label1";
            label1.Size = new Size(190, 106);
            label1.TabIndex = 32;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Location = new Point(205, 563);
            button2.Name = "button2";
            button2.Size = new Size(255, 142);
            button2.TabIndex = 44;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btn_Kapuson
            // 
            btn_Kapuson.BackColor = SystemColors.WindowText;
            btn_Kapuson.BackgroundImage = (Image)resources.GetObject("btn_Kapuson.BackgroundImage");
            btn_Kapuson.FlatStyle = FlatStyle.Flat;
            btn_Kapuson.Location = new Point(831, 440);
            btn_Kapuson.Name = "btn_Kapuson";
            btn_Kapuson.Size = new Size(262, 83);
            btn_Kapuson.TabIndex = 45;
            btn_Kapuson.UseVisualStyleBackColor = false;
            btn_Kapuson.Click += btn_Kapuson_Click;
            // 
            // lst_Kapuson
            // 
            lst_Kapuson.BackColor = SystemColors.InactiveCaptionText;
            lst_Kapuson.ForeColor = SystemColors.Info;
            lst_Kapuson.FormattingEnabled = true;
            lst_Kapuson.Items.AddRange(new object[] { "Çıkarılabilir ", "Sabit ", "Kürklü ", "Ayarlanabilir " });
            lst_Kapuson.Location = new Point(1099, 440);
            lst_Kapuson.Name = "lst_Kapuson";
            lst_Kapuson.Size = new Size(125, 64);
            lst_Kapuson.TabIndex = 46;
            lst_Kapuson.Visible = false;
            // 
            // btn_Cep
            // 
            btn_Cep.BackColor = SystemColors.WindowText;
            btn_Cep.BackgroundImage = (Image)resources.GetObject("btn_Cep.BackgroundImage");
            btn_Cep.FlatStyle = FlatStyle.Flat;
            btn_Cep.Location = new Point(928, 563);
            btn_Cep.Name = "btn_Cep";
            btn_Cep.Size = new Size(165, 83);
            btn_Cep.TabIndex = 47;
            btn_Cep.UseVisualStyleBackColor = false;
            btn_Cep.Click += btn_Cep_Click;
            // 
            // lst_Cep
            // 
            lst_Cep.BackColor = SystemColors.InactiveCaptionText;
            lst_Cep.ForeColor = SystemColors.Info;
            lst_Cep.FormattingEnabled = true;
            lst_Cep.Items.AddRange(new object[] { "Fermuarlı ", "Düğmeli ", "Gizli ", "Kanguru " });
            lst_Cep.Location = new Point(1099, 563);
            lst_Cep.Name = "lst_Cep";
            lst_Cep.Size = new Size(125, 64);
            lst_Cep.TabIndex = 48;
            lst_Cep.Visible = false;
            // 
            // btn_Kumas
            // 
            btn_Kumas.BackColor = SystemColors.WindowText;
            btn_Kumas.BackgroundImage = (Image)resources.GetObject("btn_Kumas.BackgroundImage");
            btn_Kumas.FlatStyle = FlatStyle.Flat;
            btn_Kumas.Location = new Point(860, 679);
            btn_Kumas.Name = "btn_Kumas";
            btn_Kumas.Size = new Size(233, 69);
            btn_Kumas.TabIndex = 49;
            btn_Kumas.UseVisualStyleBackColor = false;
            btn_Kumas.Click += btn_Kumas_Click;
            // 
            // lst_Kumas
            // 
            lst_Kumas.BackColor = SystemColors.InactiveCaptionText;
            lst_Kumas.ForeColor = SystemColors.Info;
            lst_Kumas.FormattingEnabled = true;
            lst_Kumas.Items.AddRange(new object[] { "Su Geçirmez ", "Rüzgar Geçirmez ", "Pamuklu ", "Sentetik Karışımlı " });
            lst_Kumas.Location = new Point(1099, 684);
            lst_Kumas.Name = "lst_Kumas";
            lst_Kumas.Size = new Size(125, 64);
            lst_Kumas.TabIndex = 50;
            lst_Kumas.Visible = false;
            // 
            // VIPMontEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1521, 809);
            Controls.Add(lst_Kumas);
            Controls.Add(btn_Kumas);
            Controls.Add(lst_Cep);
            Controls.Add(btn_Cep);
            Controls.Add(lst_Kapuson);
            Controls.Add(btn_Kapuson);
            Controls.Add(button2);
            Controls.Add(txt_Fiyat3);
            Controls.Add(button1);
            Controls.Add(btn_Ekle);
            Controls.Add(lst_Cins3);
            Controls.Add(lst_Renk3);
            Controls.Add(lst_Bedenler3);
            Controls.Add(lst_Markalar3);
            Controls.Add(btn_Cinsiyet3);
            Controls.Add(btn_Renk3);
            Controls.Add(btn_Beden3);
            Controls.Add(btn_Marka3);
            Controls.Add(label1);
            Name = "VIPMontEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VIPMontEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Fiyat3;
        private Button button1;
        private Button btn_Ekle;
        private ListBox lst_Cins3;
        private ListBox lst_Renk3;
        private ListBox lst_Bedenler3;
        private ListBox lst_Markalar3;
        private Button btn_Cinsiyet3;
        private Button btn_Renk3;
        private Button btn_Beden3;
        private Button btn_Marka3;
        private Label label1;
        private Button button2;
        private Button btn_Kapuson;
        private ListBox lst_Kapuson;
        private Button btn_Cep;
        private ListBox lst_Cep;
        private Button btn_Kumas;
        private ListBox lst_Kumas;
    }
}