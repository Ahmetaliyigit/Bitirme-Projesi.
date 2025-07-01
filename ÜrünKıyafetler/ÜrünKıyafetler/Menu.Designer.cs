namespace ÜrünKıyafetler
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btn_Kayit = new Button();
            btn_Giris = new Button();
            SuspendLayout();
            // 
            // btn_Kayit
            // 
            btn_Kayit.BackColor = SystemColors.ActiveCaption;
            btn_Kayit.BackgroundImage = (Image)resources.GetObject("btn_Kayit.BackgroundImage");
            btn_Kayit.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btn_Kayit.Location = new Point(547, 479);
            btn_Kayit.Name = "btn_Kayit";
            btn_Kayit.Size = new Size(134, 73);
            btn_Kayit.TabIndex = 0;
            btn_Kayit.UseVisualStyleBackColor = false;
            btn_Kayit.Click += btn_Kayit_Click;
            // 
            // btn_Giris
            // 
            btn_Giris.BackColor = Color.Yellow;
            btn_Giris.BackgroundImage = (Image)resources.GetObject("btn_Giris.BackgroundImage");
            btn_Giris.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btn_Giris.Location = new Point(753, 479);
            btn_Giris.Name = "btn_Giris";
            btn_Giris.Size = new Size(175, 73);
            btn_Giris.TabIndex = 1;
            btn_Giris.UseVisualStyleBackColor = false;
            btn_Giris.Click += btn_Giris_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1468, 826);
            Controls.Add(btn_Giris);
            Controls.Add(btn_Kayit);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Kayit;
        private Button btn_Giris;
    }
}