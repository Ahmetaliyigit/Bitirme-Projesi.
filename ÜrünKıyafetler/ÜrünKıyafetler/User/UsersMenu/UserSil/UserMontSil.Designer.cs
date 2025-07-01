namespace ÜrünKıyafetler.User.UsersMenu.UserSil
{
    partial class UserMontSil
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMontSil));
            button3 = new Button();
            button2 = new Button();
            txt_Id = new TextBox();
            button1 = new Button();
            dvg_GomlekList = new DataGridView();
            jacketBindingSource = new BindingSource(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dvg_GomlekList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jacketBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = SystemColors.WindowText;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(1023, 491);
            button3.Name = "button3";
            button3.Size = new Size(168, 78);
            button3.TabIndex = 36;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.WindowText;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(852, 485);
            button2.Name = "button2";
            button2.Size = new Size(119, 91);
            button2.TabIndex = 35;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txt_Id
            // 
            txt_Id.BackColor = SystemColors.InactiveCaptionText;
            txt_Id.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_Id.ForeColor = SystemColors.InactiveBorder;
            txt_Id.Location = new Point(683, 505);
            txt_Id.MaxLength = 4;
            txt_Id.Multiline = true;
            txt_Id.Name = "txt_Id";
            txt_Id.ShortcutsEnabled = false;
            txt_Id.Size = new Size(125, 64);
            txt_Id.TabIndex = 34;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowText;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(47, 491);
            button1.Name = "button1";
            button1.Size = new Size(630, 93);
            button1.TabIndex = 33;
            button1.UseVisualStyleBackColor = false;
            // 
            // dvg_GomlekList
            // 
            dvg_GomlekList.AutoGenerateColumns = false;
            dvg_GomlekList.BackgroundColor = SystemColors.ActiveCaptionText;
            dvg_GomlekList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_GomlekList.DataSource = jacketBindingSource;
            dvg_GomlekList.EnableHeadersVisualStyles = false;
            dvg_GomlekList.GridColor = SystemColors.InactiveCaptionText;
            dvg_GomlekList.Location = new Point(12, 12);
            dvg_GomlekList.Name = "dvg_GomlekList";
            dvg_GomlekList.ReadOnly = true;
            dvg_GomlekList.RowHeadersWidth = 51;
            dvg_GomlekList.Size = new Size(1302, 188);
            dvg_GomlekList.TabIndex = 32;
            dvg_GomlekList.CellContentClick += dvg_GomlekList_CellContentClick;
            // 
            // label1
            // 
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(47, 336);
            label1.Name = "label1";
            label1.Size = new Size(498, 112);
            label1.TabIndex = 31;
            // 
            // UserMontSil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1521, 895);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txt_Id);
            Controls.Add(button1);
            Controls.Add(dvg_GomlekList);
            Controls.Add(label1);
            Name = "UserMontSil";
            Text = "UserMontSil";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dvg_GomlekList).EndInit();
            ((System.ComponentModel.ISupportInitialize)jacketBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private TextBox txt_Id;
        private Button button1;
        private DataGridView dvg_GomlekList;
        private Label label1;
        private BindingSource jacketBindingSource;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hoodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pocketDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fabricDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
    }
}