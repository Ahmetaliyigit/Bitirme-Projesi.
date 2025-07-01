namespace ÜrünKıyafetler
{
    partial class VIPLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIPLogin));
            btn_Urunekle = new Button();
            btn_UrunGuncel = new Button();
            btn_UrunList = new Button();
            btn_KullaniciList = new Button();
            label1 = new Label();
            lst_Urunler = new ListBox();
            btn_Cıkıs = new Button();
            lst_Urunler2 = new ListBox();
            lst_list = new ListBox();
            SuspendLayout();
            // 
            // btn_Urunekle
            // 
            btn_Urunekle.BackColor = SystemColors.WindowText;
            btn_Urunekle.BackgroundImage = (Image)resources.GetObject("btn_Urunekle.BackgroundImage");
            btn_Urunekle.FlatStyle = FlatStyle.Flat;
            btn_Urunekle.Location = new Point(1054, 75);
            btn_Urunekle.Name = "btn_Urunekle";
            btn_Urunekle.Size = new Size(405, 127);
            btn_Urunekle.TabIndex = 0;
            btn_Urunekle.UseVisualStyleBackColor = false;
            btn_Urunekle.Click += button1_Click;
            // 
            // btn_UrunGuncel
            // 
            btn_UrunGuncel.BackColor = SystemColors.WindowText;
            btn_UrunGuncel.BackgroundImage = (Image)resources.GetObject("btn_UrunGuncel.BackgroundImage");
            btn_UrunGuncel.FlatStyle = FlatStyle.Flat;
            btn_UrunGuncel.Location = new Point(936, 266);
            btn_UrunGuncel.Name = "btn_UrunGuncel";
            btn_UrunGuncel.Size = new Size(523, 127);
            btn_UrunGuncel.TabIndex = 1;
            btn_UrunGuncel.UseVisualStyleBackColor = false;
            btn_UrunGuncel.Click += btn_UrunGuncel_Click;
            // 
            // btn_UrunList
            // 
            btn_UrunList.BackColor = SystemColors.WindowText;
            btn_UrunList.BackgroundImage = (Image)resources.GetObject("btn_UrunList.BackgroundImage");
            btn_UrunList.FlatStyle = FlatStyle.Flat;
            btn_UrunList.Location = new Point(1084, 461);
            btn_UrunList.Name = "btn_UrunList";
            btn_UrunList.Size = new Size(375, 121);
            btn_UrunList.TabIndex = 2;
            btn_UrunList.UseVisualStyleBackColor = false;
            btn_UrunList.Click += btn_UrunList_Click;
            // 
            // btn_KullaniciList
            // 
            btn_KullaniciList.BackColor = SystemColors.WindowText;
            btn_KullaniciList.BackgroundImage = (Image)resources.GetObject("btn_KullaniciList.BackgroundImage");
            btn_KullaniciList.FlatStyle = FlatStyle.Flat;
            btn_KullaniciList.Location = new Point(890, 652);
            btn_KullaniciList.Name = "btn_KullaniciList";
            btn_KullaniciList.Size = new Size(569, 127);
            btn_KullaniciList.TabIndex = 3;
            btn_KullaniciList.UseVisualStyleBackColor = false;
            btn_KullaniciList.Click += btn_KullaniciList_Click;
            // 
            // label1
            // 
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(244, 225);
            label1.Name = "label1";
            label1.Size = new Size(190, 106);
            label1.TabIndex = 4;
            // 
            // lst_Urunler
            // 
            lst_Urunler.BackColor = SystemColors.InactiveCaptionText;
            lst_Urunler.ForeColor = SystemColors.Info;
            lst_Urunler.FormattingEnabled = true;
            lst_Urunler.Items.AddRange(new object[] { "Gömlek", "Pantolon", "Mont", "TişöRt" });
            lst_Urunler.Location = new Point(898, 98);
            lst_Urunler.Name = "lst_Urunler";
            lst_Urunler.Size = new Size(150, 104);
            lst_Urunler.TabIndex = 5;
            lst_Urunler.Visible = false;
            lst_Urunler.SelectedIndexChanged += lst_Urunler_SelectedIndexChanged;
            // 
            // btn_Cıkıs
            // 
            btn_Cıkıs.BackgroundImage = (Image)resources.GetObject("btn_Cıkıs.BackgroundImage");
            btn_Cıkıs.Location = new Point(244, 652);
            btn_Cıkıs.Name = "btn_Cıkıs";
            btn_Cıkıs.Size = new Size(190, 74);
            btn_Cıkıs.TabIndex = 6;
            btn_Cıkıs.UseVisualStyleBackColor = true;
            btn_Cıkıs.Click += btn_Cıkıs_Click;
            // 
            // lst_Urunler2
            // 
            lst_Urunler2.BackColor = SystemColors.InactiveCaptionText;
            lst_Urunler2.ForeColor = SystemColors.Info;
            lst_Urunler2.FormattingEnabled = true;
            lst_Urunler2.Items.AddRange(new object[] { "Gömlek", "Pantolon", "Mont", "TişöRt" });
            lst_Urunler2.Location = new Point(780, 289);
            lst_Urunler2.Name = "lst_Urunler2";
            lst_Urunler2.Size = new Size(150, 104);
            lst_Urunler2.TabIndex = 7;
            lst_Urunler2.Visible = false;
            lst_Urunler2.SelectedIndexChanged += lst_Urunler2_SelectedIndexChanged;
            // 
            // lst_list
            // 
            lst_list.BackColor = SystemColors.InactiveCaptionText;
            lst_list.ForeColor = SystemColors.Info;
            lst_list.FormattingEnabled = true;
            lst_list.Items.AddRange(new object[] { "Gömlek", "Pantolon", "Mont", "TişöRt" });
            lst_list.Location = new Point(928, 478);
            lst_list.Name = "lst_list";
            lst_list.Size = new Size(150, 104);
            lst_list.TabIndex = 8;
            lst_list.Visible = false;
            lst_list.SelectedIndexChanged += lst_list_SelectedIndexChanged;
            // 
            // VIPLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1538, 844);
            Controls.Add(lst_list);
            Controls.Add(lst_Urunler2);
            Controls.Add(btn_Cıkıs);
            Controls.Add(lst_Urunler);
            Controls.Add(label1);
            Controls.Add(btn_KullaniciList);
            Controls.Add(btn_UrunList);
            Controls.Add(btn_UrunGuncel);
            Controls.Add(btn_Urunekle);
            Name = "VIPLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VIPLogin";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Urunekle;
        private Button btn_UrunGuncel;
        private Button btn_UrunList;
        private Button btn_KullaniciList;
        private Label label1;
        private ListBox lst_Urunler;
        private Button btn_Cıkıs;
        private ListBox lst_Urunler2;
        private ListBox lst_list;
    }
}