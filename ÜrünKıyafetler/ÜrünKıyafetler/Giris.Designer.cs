namespace ÜrünKıyafetler
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            btn_Menu = new Button();
            btn_GirisYap = new Button();
            txt_Pass = new TextBox();
            txt_Name = new TextBox();
            SuspendLayout();
            // 
            // btn_Menu
            // 
            btn_Menu.BackColor = Color.White;
            btn_Menu.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btn_Menu.Location = new Point(1123, 473);
            btn_Menu.Name = "btn_Menu";
            btn_Menu.Size = new Size(219, 157);
            btn_Menu.TabIndex = 17;
            btn_Menu.Text = "Menü";
            btn_Menu.UseVisualStyleBackColor = false;
            btn_Menu.Click += btn_Menu_Click;
            // 
            // btn_GirisYap
            // 
            btn_GirisYap.BackColor = Color.Yellow;
            btn_GirisYap.BackgroundImage = (Image)resources.GetObject("btn_GirisYap.BackgroundImage");
            btn_GirisYap.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btn_GirisYap.Location = new Point(1044, 309);
            btn_GirisYap.Name = "btn_GirisYap";
            btn_GirisYap.Size = new Size(371, 127);
            btn_GirisYap.TabIndex = 13;
            btn_GirisYap.TabStop = false;
            btn_GirisYap.UseVisualStyleBackColor = false;
            btn_GirisYap.Click += btn_GirisYap_Click;
            // 
            // txt_Pass
            // 
            txt_Pass.BackColor = SystemColors.InactiveCaptionText;
            txt_Pass.Font = new Font("Segoe UI", 18F);
            txt_Pass.ForeColor = SystemColors.Info;
            txt_Pass.Location = new Point(1114, 200);
            txt_Pass.Name = "txt_Pass";
            txt_Pass.Size = new Size(301, 47);
            txt_Pass.TabIndex = 12;
            // 
            // txt_Name
            // 
            txt_Name.BackColor = SystemColors.InactiveCaptionText;
            txt_Name.Font = new Font("Segoe UI", 18F);
            txt_Name.ForeColor = SystemColors.Info;
            txt_Name.Location = new Point(1096, 107);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(319, 47);
            txt_Name.TabIndex = 10;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1467, 754);
            Controls.Add(btn_Menu);
            Controls.Add(btn_GirisYap);
            Controls.Add(txt_Pass);
            Controls.Add(txt_Name);
            Name = "Giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Menu;
        private Button btn_GirisYap;
        private TextBox txt_Pass;
        private TextBox txt_Name;
    }
}