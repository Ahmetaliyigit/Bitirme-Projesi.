namespace ÜrünKıyafetler
{
    partial class VIPKullanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIPKullanici));
            dvg_KullaniciList = new DataGridView();
            ıdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            balanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerBindingSource = new BindingSource(components);
            label1 = new Label();
            button1 = new Button();
            txt_Id = new TextBox();
            btn_Banla = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dvg_KullaniciList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dvg_KullaniciList
            // 
            dvg_KullaniciList.AutoGenerateColumns = false;
            dvg_KullaniciList.BackgroundColor = SystemColors.ActiveCaptionText;
            dvg_KullaniciList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_KullaniciList.Columns.AddRange(new DataGridViewColumn[] { ıdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, passDataGridViewTextBoxColumn, balanceDataGridViewTextBoxColumn });
            dvg_KullaniciList.DataSource = customerBindingSource;
            dvg_KullaniciList.EnableHeadersVisualStyles = false;
            dvg_KullaniciList.GridColor = SystemColors.InactiveCaptionText;
            dvg_KullaniciList.Location = new Point(56, 25);
            dvg_KullaniciList.Name = "dvg_KullaniciList";
            dvg_KullaniciList.ReadOnly = true;
            dvg_KullaniciList.RowHeadersWidth = 51;
            dvg_KullaniciList.Size = new Size(554, 188);
            dvg_KullaniciList.TabIndex = 9;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            ıdDataGridViewTextBoxColumn.HeaderText = "Kullanıcı adı";
            ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            ıdDataGridViewTextBoxColumn.ReadOnly = true;
            ıdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Ad";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passDataGridViewTextBoxColumn
            // 
            passDataGridViewTextBoxColumn.DataPropertyName = "Pass";
            passDataGridViewTextBoxColumn.HeaderText = "Şifre";
            passDataGridViewTextBoxColumn.MinimumWidth = 6;
            passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            passDataGridViewTextBoxColumn.ReadOnly = true;
            passDataGridViewTextBoxColumn.Width = 125;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            balanceDataGridViewTextBoxColumn.HeaderText = "Bakiye";
            balanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            balanceDataGridViewTextBoxColumn.ReadOnly = true;
            balanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Customer);
            // 
            // label1
            // 
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(272, 231);
            label1.Name = "label1";
            label1.Size = new Size(190, 106);
            label1.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowText;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(56, 515);
            button1.Name = "button1";
            button1.Size = new Size(450, 88);
            button1.TabIndex = 27;
            button1.UseVisualStyleBackColor = false;
            // 
            // txt_Id
            // 
            txt_Id.BackColor = SystemColors.InactiveCaptionText;
            txt_Id.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_Id.ForeColor = SystemColors.InactiveBorder;
            txt_Id.Location = new Point(525, 515);
            txt_Id.MaxLength = 4;
            txt_Id.Multiline = true;
            txt_Id.Name = "txt_Id";
            txt_Id.ShortcutsEnabled = false;
            txt_Id.Size = new Size(155, 88);
            txt_Id.TabIndex = 26;
            // 
            // btn_Banla
            // 
            btn_Banla.BackgroundImage = (Image)resources.GetObject("btn_Banla.BackgroundImage");
            btn_Banla.Location = new Point(679, 42);
            btn_Banla.Name = "btn_Banla";
            btn_Banla.Size = new Size(768, 128);
            btn_Banla.TabIndex = 41;
            btn_Banla.UseVisualStyleBackColor = true;
            btn_Banla.Click += btn_Banla_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Location = new Point(956, 231);
            button3.Name = "button3";
            button3.Size = new Size(255, 142);
            button3.TabIndex = 45;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // VIPKullanici
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1521, 895);
            Controls.Add(button3);
            Controls.Add(btn_Banla);
            Controls.Add(button1);
            Controls.Add(txt_Id);
            Controls.Add(dvg_KullaniciList);
            Controls.Add(label1);
            Name = "VIPKullanici";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VIPKullanici";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dvg_KullaniciList).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvg_KullaniciList;
        private BindingSource customerBindingSource;
        private Label label1;
        private Button button1;
        private TextBox txt_Id;
        private Button btn_Banla;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private Button button3;
    }
}