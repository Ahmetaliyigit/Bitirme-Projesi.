namespace ÜrünKıyafetler.User.UserBakiye
{
    partial class UserBakiye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserBakiye));
            txt_Bakiye = new TextBox();
            button3 = new Button();
            button1 = new Button();
            txt_BakiyeYukle = new TextBox();
            btn_Ekle = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // txt_Bakiye
            // 
            txt_Bakiye.BackColor = SystemColors.InactiveCaptionText;
            txt_Bakiye.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_Bakiye.ForeColor = SystemColors.InactiveBorder;
            txt_Bakiye.Location = new Point(1191, 48);
            txt_Bakiye.MaxLength = 4;
            txt_Bakiye.Multiline = true;
            txt_Bakiye.Name = "txt_Bakiye";
            txt_Bakiye.ReadOnly = true;
            txt_Bakiye.ShortcutsEnabled = false;
            txt_Bakiye.Size = new Size(168, 103);
            txt_Bakiye.TabIndex = 46;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.WindowText;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(792, 48);
            button3.Name = "button3";
            button3.Size = new Size(388, 103);
            button3.TabIndex = 45;
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowText;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(512, 171);
            button1.Name = "button1";
            button1.Size = new Size(668, 97);
            button1.TabIndex = 48;
            button1.UseVisualStyleBackColor = false;
            // 
            // txt_BakiyeYukle
            // 
            txt_BakiyeYukle.BackColor = SystemColors.InactiveCaptionText;
            txt_BakiyeYukle.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_BakiyeYukle.ForeColor = SystemColors.InactiveBorder;
            txt_BakiyeYukle.Location = new Point(1191, 171);
            txt_BakiyeYukle.MaxLength = 6;
            txt_BakiyeYukle.Multiline = true;
            txt_BakiyeYukle.Name = "txt_BakiyeYukle";
            txt_BakiyeYukle.ShortcutsEnabled = false;
            txt_BakiyeYukle.Size = new Size(168, 97);
            txt_BakiyeYukle.TabIndex = 47;
            // 
            // btn_Ekle
            // 
            btn_Ekle.BackgroundImage = (Image)resources.GetObject("btn_Ekle.BackgroundImage");
            btn_Ekle.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Ekle.Location = new Point(826, 314);
            btn_Ekle.Name = "btn_Ekle";
            btn_Ekle.Size = new Size(421, 169);
            btn_Ekle.TabIndex = 49;
            btn_Ekle.UseVisualStyleBackColor = true;
            btn_Ekle.Click += btn_Ekle_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Location = new Point(865, 526);
            button2.Name = "button2";
            button2.Size = new Size(336, 169);
            button2.TabIndex = 50;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // UserBakiye
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1521, 809);
            Controls.Add(button2);
            Controls.Add(btn_Ekle);
            Controls.Add(button1);
            Controls.Add(txt_BakiyeYukle);
            Controls.Add(txt_Bakiye);
            Controls.Add(button3);
            Name = "UserBakiye";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserBakiye";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Bakiye;
        private Button button3;
        private Button button1;
        private TextBox txt_BakiyeYukle;
        private Button btn_Ekle;
        private Button button2;
    }
}