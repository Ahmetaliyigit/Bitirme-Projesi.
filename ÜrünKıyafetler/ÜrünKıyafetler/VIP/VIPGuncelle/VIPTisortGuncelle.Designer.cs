namespace ÜrünKıyafetler
{
    partial class VIPTisortGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIPTisortGuncelle));
            dvg_TshirtList = new DataGridView();
            ıdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sleveDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            collarDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fabricDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sizeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            colorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tshirtBindingSource = new BindingSource(components);
            shirtBindingSource = new BindingSource(components);
            button3 = new Button();
            txt_FiyatGun = new TextBox();
            button2 = new Button();
            btn_Ekle = new Button();
            lst_KumasGun = new ListBox();
            btn_KumasGun = new Button();
            lst_YakaGun = new ListBox();
            btn_YakaGun = new Button();
            lst_KolGun = new ListBox();
            lst_CinsGun = new ListBox();
            lst_RenkGun = new ListBox();
            lst_BedenGun = new ListBox();
            lst_MarkaGun = new ListBox();
            btn_KolGun = new Button();
            btn_CinsiyetGun = new Button();
            btn_RenkGun = new Button();
            btn_BedenGun = new Button();
            btn_MarkaGun = new Button();
            button1 = new Button();
            txt_Id = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dvg_TshirtList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tshirtBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shirtBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dvg_TshirtList
            // 
            dvg_TshirtList.AutoGenerateColumns = false;
            dvg_TshirtList.BackgroundColor = SystemColors.ActiveCaptionText;
            dvg_TshirtList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_TshirtList.Columns.AddRange(new DataGridViewColumn[] { ıdDataGridViewTextBoxColumn, sleveDataGridViewTextBoxColumn, collarDataGridViewTextBoxColumn, fabricDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, brandDataGridViewTextBoxColumn, sizeDataGridViewTextBoxColumn, colorDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn });
            dvg_TshirtList.DataSource = tshirtBindingSource;
            dvg_TshirtList.EnableHeadersVisualStyles = false;
            dvg_TshirtList.GridColor = SystemColors.InactiveCaptionText;
            dvg_TshirtList.Location = new Point(36, 34);
            dvg_TshirtList.Name = "dvg_TshirtList";
            dvg_TshirtList.ReadOnly = true;
            dvg_TshirtList.RowHeadersWidth = 51;
            dvg_TshirtList.Size = new Size(1302, 188);
            dvg_TshirtList.TabIndex = 95;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            ıdDataGridViewTextBoxColumn.ReadOnly = true;
            ıdDataGridViewTextBoxColumn.Width = 125;
            // 
            // sleveDataGridViewTextBoxColumn
            // 
            sleveDataGridViewTextBoxColumn.DataPropertyName = "sleve";
            sleveDataGridViewTextBoxColumn.HeaderText = "Kol";
            sleveDataGridViewTextBoxColumn.MinimumWidth = 6;
            sleveDataGridViewTextBoxColumn.Name = "sleveDataGridViewTextBoxColumn";
            sleveDataGridViewTextBoxColumn.ReadOnly = true;
            sleveDataGridViewTextBoxColumn.Width = 125;
            // 
            // collarDataGridViewTextBoxColumn
            // 
            collarDataGridViewTextBoxColumn.DataPropertyName = "Collar";
            collarDataGridViewTextBoxColumn.HeaderText = "Yaka";
            collarDataGridViewTextBoxColumn.MinimumWidth = 6;
            collarDataGridViewTextBoxColumn.Name = "collarDataGridViewTextBoxColumn";
            collarDataGridViewTextBoxColumn.ReadOnly = true;
            collarDataGridViewTextBoxColumn.Width = 125;
            // 
            // fabricDataGridViewTextBoxColumn
            // 
            fabricDataGridViewTextBoxColumn.DataPropertyName = "Fabric";
            fabricDataGridViewTextBoxColumn.HeaderText = "Kumaş";
            fabricDataGridViewTextBoxColumn.MinimumWidth = 6;
            fabricDataGridViewTextBoxColumn.Name = "fabricDataGridViewTextBoxColumn";
            fabricDataGridViewTextBoxColumn.ReadOnly = true;
            fabricDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Tür";
            typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.ReadOnly = true;
            typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            brandDataGridViewTextBoxColumn.HeaderText = "Marka";
            brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            brandDataGridViewTextBoxColumn.ReadOnly = true;
            brandDataGridViewTextBoxColumn.Width = 125;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            sizeDataGridViewTextBoxColumn.HeaderText = "Marka";
            sizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            sizeDataGridViewTextBoxColumn.ReadOnly = true;
            sizeDataGridViewTextBoxColumn.Width = 125;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            colorDataGridViewTextBoxColumn.HeaderText = "Renk";
            colorDataGridViewTextBoxColumn.MinimumWidth = 6;
            colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            colorDataGridViewTextBoxColumn.ReadOnly = true;
            colorDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.ReadOnly = true;
            genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // tshirtBindingSource
            // 
            tshirtBindingSource.DataSource = typeof(Tshirt);
            // 
            // shirtBindingSource
            // 
            shirtBindingSource.DataSource = typeof(Shirt);
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Location = new Point(1198, 604);
            button3.Name = "button3";
            button3.Size = new Size(255, 142);
            button3.TabIndex = 116;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // txt_FiyatGun
            // 
            txt_FiyatGun.BackColor = SystemColors.InactiveCaptionText;
            txt_FiyatGun.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_FiyatGun.ForeColor = SystemColors.InactiveBorder;
            txt_FiyatGun.Location = new Point(1329, 256);
            txt_FiyatGun.MaxLength = 4;
            txt_FiyatGun.Multiline = true;
            txt_FiyatGun.Name = "txt_FiyatGun";
            txt_FiyatGun.ShortcutsEnabled = false;
            txt_FiyatGun.Size = new Size(125, 64);
            txt_FiyatGun.TabIndex = 115;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.WindowText;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1147, 255);
            button2.Name = "button2";
            button2.Size = new Size(176, 65);
            button2.TabIndex = 114;
            button2.UseVisualStyleBackColor = false;
            // 
            // btn_Ekle
            // 
            btn_Ekle.BackgroundImage = (Image)resources.GetObject("btn_Ekle.BackgroundImage");
            btn_Ekle.Location = new Point(1198, 477);
            btn_Ekle.Name = "btn_Ekle";
            btn_Ekle.Size = new Size(208, 64);
            btn_Ekle.TabIndex = 113;
            btn_Ekle.UseVisualStyleBackColor = true;
            btn_Ekle.Click += btn_Ekle_Click;
            // 
            // lst_KumasGun
            // 
            lst_KumasGun.BackColor = SystemColors.InactiveCaptionText;
            lst_KumasGun.ForeColor = SystemColors.Info;
            lst_KumasGun.FormattingEnabled = true;
            lst_KumasGun.Items.AddRange(new object[] { "Pamuk", "Polyester", "Keten", "İpek", "Yün", "Likralı" });
            lst_KumasGun.Location = new Point(970, 255);
            lst_KumasGun.Name = "lst_KumasGun";
            lst_KumasGun.Size = new Size(108, 64);
            lst_KumasGun.TabIndex = 112;
            lst_KumasGun.Visible = false;
            // 
            // btn_KumasGun
            // 
            btn_KumasGun.BackColor = SystemColors.WindowText;
            btn_KumasGun.BackgroundImage = (Image)resources.GetObject("btn_KumasGun.BackgroundImage");
            btn_KumasGun.FlatStyle = FlatStyle.Flat;
            btn_KumasGun.Location = new Point(751, 243);
            btn_KumasGun.Name = "btn_KumasGun";
            btn_KumasGun.Size = new Size(203, 76);
            btn_KumasGun.TabIndex = 111;
            btn_KumasGun.UseVisualStyleBackColor = false;
            btn_KumasGun.Click += btn_KumasGun_Click;
            // 
            // lst_YakaGun
            // 
            lst_YakaGun.BackColor = SystemColors.InactiveCaptionText;
            lst_YakaGun.ForeColor = SystemColors.Info;
            lst_YakaGun.FormattingEnabled = true;
            lst_YakaGun.Items.AddRange(new object[] { "Klasik Yuvarlak", "V ", "Derin ve Geniş" });
            lst_YakaGun.Location = new Point(970, 694);
            lst_YakaGun.Name = "lst_YakaGun";
            lst_YakaGun.Size = new Size(108, 64);
            lst_YakaGun.TabIndex = 110;
            lst_YakaGun.Visible = false;
            // 
            // btn_YakaGun
            // 
            btn_YakaGun.BackColor = SystemColors.WindowText;
            btn_YakaGun.BackgroundImage = (Image)resources.GetObject("btn_YakaGun.BackgroundImage");
            btn_YakaGun.FlatStyle = FlatStyle.Flat;
            btn_YakaGun.Location = new Point(788, 682);
            btn_YakaGun.Name = "btn_YakaGun";
            btn_YakaGun.Size = new Size(166, 76);
            btn_YakaGun.TabIndex = 109;
            btn_YakaGun.UseVisualStyleBackColor = false;
            btn_YakaGun.Click += btn_YakaGun_Click;
            // 
            // lst_KolGun
            // 
            lst_KolGun.BackColor = SystemColors.InactiveCaptionText;
            lst_KolGun.ForeColor = SystemColors.Info;
            lst_KolGun.FormattingEnabled = true;
            lst_KolGun.Items.AddRange(new object[] { "Ksıa", "Uzun", "Kolsuz" });
            lst_KolGun.Location = new Point(970, 574);
            lst_KolGun.Name = "lst_KolGun";
            lst_KolGun.Size = new Size(125, 64);
            lst_KolGun.TabIndex = 108;
            lst_KolGun.Visible = false;
            // 
            // lst_CinsGun
            // 
            lst_CinsGun.BackColor = SystemColors.InactiveCaptionText;
            lst_CinsGun.ForeColor = SystemColors.Info;
            lst_CinsGun.FormattingEnabled = true;
            lst_CinsGun.Items.AddRange(new object[] { "Kadın", "ERKEK" });
            lst_CinsGun.Location = new Point(953, 471);
            lst_CinsGun.Name = "lst_CinsGun";
            lst_CinsGun.Size = new Size(125, 64);
            lst_CinsGun.TabIndex = 107;
            lst_CinsGun.Visible = false;
            // 
            // lst_RenkGun
            // 
            lst_RenkGun.BackColor = SystemColors.InactiveCaptionText;
            lst_RenkGun.ForeColor = SystemColors.Info;
            lst_RenkGun.FormattingEnabled = true;
            lst_RenkGun.Items.AddRange(new object[] { "Siyah", "Beyaz ", "Mavi", "Lacivert", "Kırmızı ", "Mavi", "Yeşik", "Gri", "Bordo", "Kahverengi" });
            lst_RenkGun.Location = new Point(953, 356);
            lst_RenkGun.Name = "lst_RenkGun";
            lst_RenkGun.Size = new Size(125, 64);
            lst_RenkGun.TabIndex = 106;
            lst_RenkGun.Visible = false;
            // 
            // lst_BedenGun
            // 
            lst_BedenGun.BackColor = SystemColors.InactiveCaptionText;
            lst_BedenGun.ForeColor = SystemColors.Info;
            lst_BedenGun.FormattingEnabled = true;
            lst_BedenGun.Items.AddRange(new object[] { "S", "M ", "L", "XL", "XXL", "3XL" });
            lst_BedenGun.Location = new Point(366, 698);
            lst_BedenGun.Name = "lst_BedenGun";
            lst_BedenGun.Size = new Size(118, 64);
            lst_BedenGun.TabIndex = 105;
            lst_BedenGun.Visible = false;
            // 
            // lst_MarkaGun
            // 
            lst_MarkaGun.BackColor = SystemColors.InactiveCaptionText;
            lst_MarkaGun.ForeColor = SystemColors.Info;
            lst_MarkaGun.FormattingEnabled = true;
            lst_MarkaGun.Items.AddRange(new object[] { "Zara", "H&M", "Nike", "Adidas", "Levi’s", "Tommy Hilfiger", "Calvin Klein", "Mango", "Puma", "Lacoste" });
            lst_MarkaGun.Location = new Point(366, 604);
            lst_MarkaGun.Name = "lst_MarkaGun";
            lst_MarkaGun.Size = new Size(118, 64);
            lst_MarkaGun.TabIndex = 104;
            lst_MarkaGun.Visible = false;
            // 
            // btn_KolGun
            // 
            btn_KolGun.BackColor = SystemColors.WindowText;
            btn_KolGun.BackgroundImage = (Image)resources.GetObject("btn_KolGun.BackgroundImage");
            btn_KolGun.FlatStyle = FlatStyle.Flat;
            btn_KolGun.Location = new Point(798, 574);
            btn_KolGun.Name = "btn_KolGun";
            btn_KolGun.Size = new Size(166, 76);
            btn_KolGun.TabIndex = 103;
            btn_KolGun.UseVisualStyleBackColor = false;
            btn_KolGun.Click += btn_KolGun_Click;
            // 
            // btn_CinsiyetGun
            // 
            btn_CinsiyetGun.BackColor = SystemColors.WindowText;
            btn_CinsiyetGun.BackgroundImage = (Image)resources.GetObject("btn_CinsiyetGun.BackgroundImage");
            btn_CinsiyetGun.FlatStyle = FlatStyle.Flat;
            btn_CinsiyetGun.Location = new Point(749, 459);
            btn_CinsiyetGun.Name = "btn_CinsiyetGun";
            btn_CinsiyetGun.Size = new Size(205, 76);
            btn_CinsiyetGun.TabIndex = 102;
            btn_CinsiyetGun.UseVisualStyleBackColor = false;
            btn_CinsiyetGun.Click += btn_CinsiyetGun_Click;
            // 
            // btn_RenkGun
            // 
            btn_RenkGun.BackColor = SystemColors.WindowText;
            btn_RenkGun.BackgroundImage = (Image)resources.GetObject("btn_RenkGun.BackgroundImage");
            btn_RenkGun.FlatStyle = FlatStyle.Flat;
            btn_RenkGun.Location = new Point(767, 347);
            btn_RenkGun.Name = "btn_RenkGun";
            btn_RenkGun.Size = new Size(180, 73);
            btn_RenkGun.TabIndex = 101;
            btn_RenkGun.UseVisualStyleBackColor = false;
            btn_RenkGun.Click += btn_RenkGun_Click;
            // 
            // btn_BedenGun
            // 
            btn_BedenGun.BackColor = SystemColors.WindowText;
            btn_BedenGun.BackgroundImage = (Image)resources.GetObject("btn_BedenGun.BackgroundImage");
            btn_BedenGun.FlatStyle = FlatStyle.Flat;
            btn_BedenGun.Location = new Point(155, 698);
            btn_BedenGun.Name = "btn_BedenGun";
            btn_BedenGun.Size = new Size(205, 64);
            btn_BedenGun.TabIndex = 100;
            btn_BedenGun.UseVisualStyleBackColor = false;
            btn_BedenGun.Click += btn_BedenGun_Click;
            // 
            // btn_MarkaGun
            // 
            btn_MarkaGun.BackColor = SystemColors.WindowText;
            btn_MarkaGun.BackgroundImage = (Image)resources.GetObject("btn_MarkaGun.BackgroundImage");
            btn_MarkaGun.FlatStyle = FlatStyle.Flat;
            btn_MarkaGun.Location = new Point(121, 604);
            btn_MarkaGun.Name = "btn_MarkaGun";
            btn_MarkaGun.Size = new Size(239, 65);
            btn_MarkaGun.TabIndex = 99;
            btn_MarkaGun.UseVisualStyleBackColor = false;
            btn_MarkaGun.Click += btn_MarkaGun_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowText;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(21, 482);
            button1.Name = "button1";
            button1.Size = new Size(480, 59);
            button1.TabIndex = 98;
            button1.UseVisualStyleBackColor = false;
            // 
            // txt_Id
            // 
            txt_Id.BackColor = SystemColors.InactiveCaptionText;
            txt_Id.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_Id.ForeColor = SystemColors.InactiveBorder;
            txt_Id.Location = new Point(507, 477);
            txt_Id.MaxLength = 4;
            txt_Id.Multiline = true;
            txt_Id.Name = "txt_Id";
            txt_Id.ShortcutsEnabled = false;
            txt_Id.Size = new Size(125, 64);
            txt_Id.TabIndex = 97;
            // 
            // label1
            // 
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(237, 243);
            label1.Name = "label1";
            label1.Size = new Size(190, 106);
            label1.TabIndex = 96;
            // 
            // VIPTisortGuncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1521, 895);
            Controls.Add(button3);
            Controls.Add(txt_FiyatGun);
            Controls.Add(button2);
            Controls.Add(btn_Ekle);
            Controls.Add(lst_KumasGun);
            Controls.Add(btn_KumasGun);
            Controls.Add(lst_YakaGun);
            Controls.Add(btn_YakaGun);
            Controls.Add(lst_KolGun);
            Controls.Add(lst_CinsGun);
            Controls.Add(lst_RenkGun);
            Controls.Add(lst_BedenGun);
            Controls.Add(lst_MarkaGun);
            Controls.Add(btn_KolGun);
            Controls.Add(btn_CinsiyetGun);
            Controls.Add(btn_RenkGun);
            Controls.Add(btn_BedenGun);
            Controls.Add(btn_MarkaGun);
            Controls.Add(button1);
            Controls.Add(txt_Id);
            Controls.Add(label1);
            Controls.Add(dvg_TshirtList);
            Name = "VIPTisortGuncelle";
            Text = "VIPTisortGuncelle";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dvg_TshirtList).EndInit();
            ((System.ComponentModel.ISupportInitialize)tshirtBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)shirtBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dvg_TshirtList;
        private BindingSource shirtBindingSource;
        private BindingSource tshirtBindingSource;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sleveDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn collarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fabricDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private Button button3;
        private TextBox txt_FiyatGun;
        private Button button2;
        private Button btn_Ekle;
        private ListBox lst_KumasGun;
        private Button btn_KumasGun;
        private ListBox lst_YakaGun;
        private Button btn_YakaGun;
        private ListBox lst_KolGun;
        private ListBox lst_CinsGun;
        private ListBox lst_RenkGun;
        private ListBox lst_BedenGun;
        private ListBox lst_MarkaGun;
        private Button btn_KolGun;
        private Button btn_CinsiyetGun;
        private Button btn_RenkGun;
        private Button btn_BedenGun;
        private Button btn_MarkaGun;
        private Button button1;
        private TextBox txt_Id;
        private Label label1;
    }
}