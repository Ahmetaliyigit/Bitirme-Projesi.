namespace ÜrünKıyafetler.User.UsersMenu
{
    partial class UsersMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersMenu));
            btn_UrunList = new Button();
            btn_UrunGuncel = new Button();
            btn_Urunekle = new Button();
            lst_Urunler = new ListBox();
            lst_Urunekle = new ListBox();
            lst_UrunGuncelle = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn_UrunList
            // 
            btn_UrunList.BackColor = SystemColors.WindowText;
            btn_UrunList.BackgroundImage = (Image)resources.GetObject("btn_UrunList.BackgroundImage");
            btn_UrunList.FlatStyle = FlatStyle.Flat;
            btn_UrunList.Location = new Point(1126, 551);
            btn_UrunList.Name = "btn_UrunList";
            btn_UrunList.Size = new Size(308, 105);
            btn_UrunList.TabIndex = 5;
            btn_UrunList.UseVisualStyleBackColor = false;
            btn_UrunList.Click += btn_UrunList_Click;
            // 
            // btn_UrunGuncel
            // 
            btn_UrunGuncel.BackColor = SystemColors.WindowText;
            btn_UrunGuncel.BackgroundImage = (Image)resources.GetObject("btn_UrunGuncel.BackgroundImage");
            btn_UrunGuncel.FlatStyle = FlatStyle.Flat;
            btn_UrunGuncel.Location = new Point(934, 357);
            btn_UrunGuncel.Name = "btn_UrunGuncel";
            btn_UrunGuncel.Size = new Size(500, 113);
            btn_UrunGuncel.TabIndex = 4;
            btn_UrunGuncel.UseVisualStyleBackColor = false;
            btn_UrunGuncel.Click += btn_UrunGuncel_Click;
            // 
            // btn_Urunekle
            // 
            btn_Urunekle.BackColor = SystemColors.WindowText;
            btn_Urunekle.BackgroundImage = (Image)resources.GetObject("btn_Urunekle.BackgroundImage");
            btn_Urunekle.FlatStyle = FlatStyle.Flat;
            btn_Urunekle.Location = new Point(1052, 159);
            btn_Urunekle.Name = "btn_Urunekle";
            btn_Urunekle.Size = new Size(382, 127);
            btn_Urunekle.TabIndex = 3;
            btn_Urunekle.UseVisualStyleBackColor = false;
            btn_Urunekle.Click += btn_Urunekle_Click;
            // 
            // lst_Urunler
            // 
            lst_Urunler.BackColor = SystemColors.InactiveCaptionText;
            lst_Urunler.ForeColor = SystemColors.Info;
            lst_Urunler.FormattingEnabled = true;
            lst_Urunler.Items.AddRange(new object[] { "Gömlek", "Pantolon", "Mont", "TişöRt" });
            lst_Urunler.Location = new Point(970, 551);
            lst_Urunler.Name = "lst_Urunler";
            lst_Urunler.Size = new Size(150, 104);
            lst_Urunler.TabIndex = 7;
            lst_Urunler.Visible = false;
            lst_Urunler.SelectedIndexChanged += lst_Urunler_SelectedIndexChanged;
            // 
            // lst_Urunekle
            // 
            lst_Urunekle.BackColor = SystemColors.InactiveCaptionText;
            lst_Urunekle.ForeColor = SystemColors.Info;
            lst_Urunekle.FormattingEnabled = true;
            lst_Urunekle.Items.AddRange(new object[] { "Gömlek", "Pantolon", "Mont", "TişöRt" });
            lst_Urunekle.Location = new Point(896, 159);
            lst_Urunekle.Name = "lst_Urunekle";
            lst_Urunekle.Size = new Size(150, 104);
            lst_Urunekle.TabIndex = 8;
            lst_Urunekle.Visible = false;
            lst_Urunekle.SelectedIndexChanged += lst_Urunekle_SelectedIndexChanged;
            // 
            // lst_UrunGuncelle
            // 
            lst_UrunGuncelle.BackColor = SystemColors.InactiveCaptionText;
            lst_UrunGuncelle.ForeColor = SystemColors.Info;
            lst_UrunGuncelle.FormattingEnabled = true;
            lst_UrunGuncelle.Items.AddRange(new object[] { "Gömlek", "Pantolon", "Mont", "TişöRt" });
            lst_UrunGuncelle.Location = new Point(778, 357);
            lst_UrunGuncelle.Name = "lst_UrunGuncelle";
            lst_UrunGuncelle.Size = new Size(150, 104);
            lst_UrunGuncelle.TabIndex = 9;
            lst_UrunGuncelle.Visible = false;
            lst_UrunGuncelle.SelectedIndexChanged += lst_UrunGuncelle_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowText;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(282, 517);
            button1.Name = "button1";
            button1.Size = new Size(225, 99);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UsersMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1521, 809);
            Controls.Add(button1);
            Controls.Add(lst_UrunGuncelle);
            Controls.Add(lst_Urunekle);
            Controls.Add(lst_Urunler);
            Controls.Add(btn_UrunList);
            Controls.Add(btn_UrunGuncel);
            Controls.Add(btn_Urunekle);
            Name = "UsersMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UsersMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_UrunList;
        private Button btn_UrunGuncel;
        private Button btn_Urunekle;
        private ListBox lst_Urunler;
        private ListBox lst_Urunekle;
        private ListBox lst_UrunGuncelle;
        private Button button1;
    }
}