namespace ÜrünKıyafetler
{
    partial class KullaniciMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciMenu));
            btn_Bakiye = new Button();
            btn_Urunler2 = new Button();
            btn_Urunler = new Button();
            lst_Urunler = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn_Bakiye
            // 
            btn_Bakiye.BackColor = SystemColors.WindowText;
            btn_Bakiye.BackgroundImage = (Image)resources.GetObject("btn_Bakiye.BackgroundImage");
            btn_Bakiye.FlatStyle = FlatStyle.Flat;
            btn_Bakiye.Location = new Point(1149, 566);
            btn_Bakiye.Name = "btn_Bakiye";
            btn_Bakiye.Size = new Size(294, 106);
            btn_Bakiye.TabIndex = 5;
            btn_Bakiye.UseVisualStyleBackColor = false;
            btn_Bakiye.Click += btn_Bakiye_Click;
            // 
            // btn_Urunler2
            // 
            btn_Urunler2.BackColor = SystemColors.WindowText;
            btn_Urunler2.BackgroundImage = (Image)resources.GetObject("btn_Urunler2.BackgroundImage");
            btn_Urunler2.FlatStyle = FlatStyle.Flat;
            btn_Urunler2.Location = new Point(988, 352);
            btn_Urunler2.Name = "btn_Urunler2";
            btn_Urunler2.Size = new Size(455, 127);
            btn_Urunler2.TabIndex = 4;
            btn_Urunler2.UseVisualStyleBackColor = false;
            btn_Urunler2.Click += btn_Urunler2_Click;
            // 
            // btn_Urunler
            // 
            btn_Urunler.BackColor = SystemColors.WindowText;
            btn_Urunler.BackgroundImage = (Image)resources.GetObject("btn_Urunler.BackgroundImage");
            btn_Urunler.BackgroundImageLayout = ImageLayout.None;
            btn_Urunler.FlatStyle = FlatStyle.Flat;
            btn_Urunler.Location = new Point(1086, 148);
            btn_Urunler.Name = "btn_Urunler";
            btn_Urunler.Size = new Size(357, 120);
            btn_Urunler.TabIndex = 3;
            btn_Urunler.UseVisualStyleBackColor = false;
            btn_Urunler.Click += btn_Urunler_Click;
            // 
            // lst_Urunler
            // 
            lst_Urunler.BackColor = SystemColors.InactiveCaptionText;
            lst_Urunler.ForeColor = SystemColors.Info;
            lst_Urunler.FormattingEnabled = true;
            lst_Urunler.Items.AddRange(new object[] { "Gömlek", "Pantolon", "Mont", "TişöRt" });
            lst_Urunler.Location = new Point(930, 148);
            lst_Urunler.Name = "lst_Urunler";
            lst_Urunler.Size = new Size(150, 104);
            lst_Urunler.TabIndex = 6;
            lst_Urunler.Visible = false;
            lst_Urunler.SelectedIndexChanged += lst_Urunler_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowText;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(299, 507);
            button1.Name = "button1";
            button1.Size = new Size(225, 127);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // KullaniciMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1521, 809);
            Controls.Add(button1);
            Controls.Add(lst_Urunler);
            Controls.Add(btn_Bakiye);
            Controls.Add(btn_Urunler2);
            Controls.Add(btn_Urunler);
            Name = "KullaniciMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KullaniciMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Bakiye;
        private Button btn_Urunler2;
        private Button btn_Urunler;
        private ListBox lst_Urunler;
        private Button button1;
    }
}