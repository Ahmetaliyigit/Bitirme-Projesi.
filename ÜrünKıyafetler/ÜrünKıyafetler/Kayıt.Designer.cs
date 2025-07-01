namespace ÜrünKıyafetler
{
    partial class Kayıt
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayıt));
            txt_Name = new TextBox();
            txt_Pass = new TextBox();
            btn_Kaydol = new Button();
            btn_Menu = new Button();
            txt_Pass2 = new TextBox();
            SuspendLayout();
            // 
            // txt_Name
            // 
            txt_Name.BackColor = SystemColors.InactiveCaptionText;
            txt_Name.Font = new Font("Segoe UI", 18F);
            txt_Name.ForeColor = SystemColors.Info;
            txt_Name.Location = new Point(1117, 113);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(340, 47);
            txt_Name.TabIndex = 1;
            // 
            // txt_Pass
            // 
            txt_Pass.BackColor = SystemColors.InactiveCaptionText;
            txt_Pass.Font = new Font("Segoe UI", 18F);
            txt_Pass.ForeColor = SystemColors.Info;
            txt_Pass.Location = new Point(1132, 196);
            txt_Pass.Name = "txt_Pass";
            txt_Pass.Size = new Size(325, 47);
            txt_Pass.TabIndex = 3;
            // 
            // btn_Kaydol
            // 
            btn_Kaydol.BackColor = SystemColors.ActiveCaption;
            btn_Kaydol.BackgroundImage = (Image)resources.GetObject("btn_Kaydol.BackgroundImage");
            btn_Kaydol.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btn_Kaydol.Location = new Point(1151, 397);
            btn_Kaydol.Name = "btn_Kaydol";
            btn_Kaydol.Size = new Size(290, 105);
            btn_Kaydol.TabIndex = 4;
            btn_Kaydol.TabStop = false;
            btn_Kaydol.UseVisualStyleBackColor = false;
            btn_Kaydol.Click += btn_Kaydol_Click;
            // 
            // btn_Menu
            // 
            btn_Menu.BackColor = Color.White;
            btn_Menu.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btn_Menu.Location = new Point(1194, 530);
            btn_Menu.Name = "btn_Menu";
            btn_Menu.Size = new Size(219, 130);
            btn_Menu.TabIndex = 8;
            btn_Menu.Text = "Menü";
            btn_Menu.UseVisualStyleBackColor = false;
            btn_Menu.Click += btn_Menu_Click;
            // 
            // txt_Pass2
            // 
            txt_Pass2.BackColor = SystemColors.InactiveCaptionText;
            txt_Pass2.Font = new Font("Segoe UI", 18F);
            txt_Pass2.ForeColor = SystemColors.Info;
            txt_Pass2.Location = new Point(1130, 316);
            txt_Pass2.Name = "txt_Pass2";
            txt_Pass2.Size = new Size(327, 47);
            txt_Pass2.TabIndex = 7;
            // 
            // Kayıt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1471, 754);
            Controls.Add(btn_Menu);
            Controls.Add(txt_Pass2);
            Controls.Add(btn_Kaydol);
            Controls.Add(txt_Pass);
            Controls.Add(txt_Name);
            Name = "Kayıt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_Name;
        private TextBox txt_Pass;
        private Button btn_Kaydol;
        private Button btn_Menu;
        private TextBox txt_Pass2;
    }
}
