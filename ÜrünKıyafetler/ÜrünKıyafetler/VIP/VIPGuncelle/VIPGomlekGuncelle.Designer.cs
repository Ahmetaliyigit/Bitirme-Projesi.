namespace ÜrünKıyafetler
{
    partial class VIPGomlekGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIPGomlekGuncelle));
            label1 = new Label();
            dvg_GomlekList = new DataGridView();
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
            shirtBindingSource1 = new BindingSource(components);
            shirtBindingSource = new BindingSource(components);
            txt_Id = new TextBox();
            button1 = new Button();
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
            btn_Ekle = new Button();
            txt_FiyatGun = new TextBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dvg_GomlekList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shirtBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shirtBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(243, 247);
            label1.Name = "label1";
            label1.Size = new Size(190, 106);
            label1.TabIndex = 6;
            // 
            // dvg_GomlekList
            // 
            dvg_GomlekList.AutoGenerateColumns = false;
            dvg_GomlekList.BackgroundColor = SystemColors.ActiveCaptionText;
            dvg_GomlekList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_GomlekList.Columns.AddRange(new DataGridViewColumn[] { ıdDataGridViewTextBoxColumn, sleveDataGridViewTextBoxColumn, collarDataGridViewTextBoxColumn, fabricDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, brandDataGridViewTextBoxColumn, sizeDataGridViewTextBoxColumn, colorDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn });
            dvg_GomlekList.DataSource = shirtBindingSource1;
            dvg_GomlekList.EnableHeadersVisualStyles = false;
            dvg_GomlekList.GridColor = SystemColors.InactiveCaptionText;
            dvg_GomlekList.Location = new Point(27, 41);
            dvg_GomlekList.Name = "dvg_GomlekList";
            dvg_GomlekList.ReadOnly = true;
            dvg_GomlekList.RowHeadersWidth = 51;
            dvg_GomlekList.Size = new Size(1302, 188);
            dvg_GomlekList.TabIndex = 7;
            dvg_GomlekList.CellContentClick += dvg_GomlekList_CellContentClick;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            ıdDataGridViewTextBoxColumn.HeaderText = "ID";
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
            sizeDataGridViewTextBoxColumn.HeaderText = "Beden";
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
            // shirtBindingSource1
            // 
            shirtBindingSource1.DataSource = typeof(Shirt);
            // 
            // shirtBindingSource
            // 
            shirtBindingSource.DataSource = typeof(Shirt);
            // 
            // txt_Id
            // 
            txt_Id.BackColor = SystemColors.InactiveCaptionText;
            txt_Id.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_Id.ForeColor = SystemColors.InactiveBorder;
            txt_Id.Location = new Point(513, 481);
            txt_Id.MaxLength = 4;
            txt_Id.Multiline = true;
            txt_Id.Name = "txt_Id";
            txt_Id.ShortcutsEnabled = false;
            txt_Id.Size = new Size(125, 64);
            txt_Id.TabIndex = 24;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowText;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(27, 486);
            button1.Name = "button1";
            button1.Size = new Size(480, 59);
            button1.TabIndex = 25;
            button1.UseVisualStyleBackColor = false;
            // 
            // lst_KumasGun
            // 
            lst_KumasGun.BackColor = SystemColors.InactiveCaptionText;
            lst_KumasGun.ForeColor = SystemColors.Info;
            lst_KumasGun.FormattingEnabled = true;
            lst_KumasGun.Items.AddRange(new object[] { "Pamuk", "Polyester", "Keten", "İpek", "Yün", "Likralı" });
            lst_KumasGun.Location = new Point(976, 259);
            lst_KumasGun.Name = "lst_KumasGun";
            lst_KumasGun.Size = new Size(108, 64);
            lst_KumasGun.TabIndex = 39;
            lst_KumasGun.Visible = false;
            // 
            // btn_KumasGun
            // 
            btn_KumasGun.BackColor = SystemColors.WindowText;
            btn_KumasGun.BackgroundImage = (Image)resources.GetObject("btn_KumasGun.BackgroundImage");
            btn_KumasGun.FlatStyle = FlatStyle.Flat;
            btn_KumasGun.Location = new Point(757, 247);
            btn_KumasGun.Name = "btn_KumasGun";
            btn_KumasGun.Size = new Size(203, 76);
            btn_KumasGun.TabIndex = 38;
            btn_KumasGun.UseVisualStyleBackColor = false;
            btn_KumasGun.Click += btn_KumasGun_Click;
            // 
            // lst_YakaGun
            // 
            lst_YakaGun.BackColor = SystemColors.InactiveCaptionText;
            lst_YakaGun.ForeColor = SystemColors.Info;
            lst_YakaGun.FormattingEnabled = true;
            lst_YakaGun.Items.AddRange(new object[] { "Düz", "Hakim", "İtalyan", "Düğmeli" });
            lst_YakaGun.Location = new Point(976, 698);
            lst_YakaGun.Name = "lst_YakaGun";
            lst_YakaGun.Size = new Size(108, 64);
            lst_YakaGun.TabIndex = 37;
            lst_YakaGun.Visible = false;
            // 
            // btn_YakaGun
            // 
            btn_YakaGun.BackColor = SystemColors.WindowText;
            btn_YakaGun.BackgroundImage = (Image)resources.GetObject("btn_YakaGun.BackgroundImage");
            btn_YakaGun.FlatStyle = FlatStyle.Flat;
            btn_YakaGun.Location = new Point(794, 686);
            btn_YakaGun.Name = "btn_YakaGun";
            btn_YakaGun.Size = new Size(166, 76);
            btn_YakaGun.TabIndex = 36;
            btn_YakaGun.UseVisualStyleBackColor = false;
            btn_YakaGun.Click += btn_YakaGun_Click;
            // 
            // lst_KolGun
            // 
            lst_KolGun.BackColor = SystemColors.InactiveCaptionText;
            lst_KolGun.ForeColor = SystemColors.Info;
            lst_KolGun.FormattingEnabled = true;
            lst_KolGun.Items.AddRange(new object[] { "Ksıa", "Uzun", "Kolsuz" });
            lst_KolGun.Location = new Point(976, 578);
            lst_KolGun.Name = "lst_KolGun";
            lst_KolGun.Size = new Size(125, 64);
            lst_KolGun.TabIndex = 35;
            lst_KolGun.Visible = false;
            // 
            // lst_CinsGun
            // 
            lst_CinsGun.BackColor = SystemColors.InactiveCaptionText;
            lst_CinsGun.ForeColor = SystemColors.Info;
            lst_CinsGun.FormattingEnabled = true;
            lst_CinsGun.Items.AddRange(new object[] { "Kadın", "ERKEK" });
            lst_CinsGun.Location = new Point(959, 475);
            lst_CinsGun.Name = "lst_CinsGun";
            lst_CinsGun.Size = new Size(125, 64);
            lst_CinsGun.TabIndex = 34;
            lst_CinsGun.Visible = false;
            // 
            // lst_RenkGun
            // 
            lst_RenkGun.BackColor = SystemColors.InactiveCaptionText;
            lst_RenkGun.ForeColor = SystemColors.Info;
            lst_RenkGun.FormattingEnabled = true;
            lst_RenkGun.Items.AddRange(new object[] { "Siyah", "Beyaz ", "Mavi", "Lacivert", "Kırmızı ", "Mavi", "Yeşik", "Gri", "Bordo", "Kahverengi" });
            lst_RenkGun.Location = new Point(959, 360);
            lst_RenkGun.Name = "lst_RenkGun";
            lst_RenkGun.Size = new Size(125, 64);
            lst_RenkGun.TabIndex = 33;
            lst_RenkGun.Visible = false;
            // 
            // lst_BedenGun
            // 
            lst_BedenGun.BackColor = SystemColors.InactiveCaptionText;
            lst_BedenGun.ForeColor = SystemColors.Info;
            lst_BedenGun.FormattingEnabled = true;
            lst_BedenGun.Items.AddRange(new object[] { "S", "M ", "L", "XL", "XXL", "3XL" });
            lst_BedenGun.Location = new Point(372, 702);
            lst_BedenGun.Name = "lst_BedenGun";
            lst_BedenGun.Size = new Size(118, 64);
            lst_BedenGun.TabIndex = 32;
            lst_BedenGun.Visible = false;
            // 
            // lst_MarkaGun
            // 
            lst_MarkaGun.BackColor = SystemColors.InactiveCaptionText;
            lst_MarkaGun.ForeColor = SystemColors.Info;
            lst_MarkaGun.FormattingEnabled = true;
            lst_MarkaGun.Items.AddRange(new object[] { "Zara", "H&M", "Nike", "Adidas", "Levi’s", "Tommy Hilfiger", "Calvin Klein", "Mango", "Puma", "Lacoste" });
            lst_MarkaGun.Location = new Point(372, 608);
            lst_MarkaGun.Name = "lst_MarkaGun";
            lst_MarkaGun.Size = new Size(118, 64);
            lst_MarkaGun.TabIndex = 31;
            lst_MarkaGun.Visible = false;
            // 
            // btn_KolGun
            // 
            btn_KolGun.BackColor = SystemColors.WindowText;
            btn_KolGun.BackgroundImage = (Image)resources.GetObject("btn_KolGun.BackgroundImage");
            btn_KolGun.FlatStyle = FlatStyle.Flat;
            btn_KolGun.Location = new Point(804, 578);
            btn_KolGun.Name = "btn_KolGun";
            btn_KolGun.Size = new Size(166, 76);
            btn_KolGun.TabIndex = 30;
            btn_KolGun.UseVisualStyleBackColor = false;
            btn_KolGun.Click += btn_KolGun_Click;
            // 
            // btn_CinsiyetGun
            // 
            btn_CinsiyetGun.BackColor = SystemColors.WindowText;
            btn_CinsiyetGun.BackgroundImage = (Image)resources.GetObject("btn_CinsiyetGun.BackgroundImage");
            btn_CinsiyetGun.FlatStyle = FlatStyle.Flat;
            btn_CinsiyetGun.Location = new Point(755, 463);
            btn_CinsiyetGun.Name = "btn_CinsiyetGun";
            btn_CinsiyetGun.Size = new Size(205, 76);
            btn_CinsiyetGun.TabIndex = 29;
            btn_CinsiyetGun.UseVisualStyleBackColor = false;
            btn_CinsiyetGun.Click += btn_CinsiyetGun_Click;
            // 
            // btn_RenkGun
            // 
            btn_RenkGun.BackColor = SystemColors.WindowText;
            btn_RenkGun.BackgroundImage = (Image)resources.GetObject("btn_RenkGun.BackgroundImage");
            btn_RenkGun.FlatStyle = FlatStyle.Flat;
            btn_RenkGun.Location = new Point(773, 351);
            btn_RenkGun.Name = "btn_RenkGun";
            btn_RenkGun.Size = new Size(180, 73);
            btn_RenkGun.TabIndex = 28;
            btn_RenkGun.UseVisualStyleBackColor = false;
            btn_RenkGun.Click += btn_RenkGun_Click;
            // 
            // btn_BedenGun
            // 
            btn_BedenGun.BackColor = SystemColors.WindowText;
            btn_BedenGun.BackgroundImage = (Image)resources.GetObject("btn_BedenGun.BackgroundImage");
            btn_BedenGun.FlatStyle = FlatStyle.Flat;
            btn_BedenGun.Location = new Point(161, 702);
            btn_BedenGun.Name = "btn_BedenGun";
            btn_BedenGun.Size = new Size(205, 64);
            btn_BedenGun.TabIndex = 27;
            btn_BedenGun.UseVisualStyleBackColor = false;
            btn_BedenGun.Click += btn_BedenGun_Click;
            // 
            // btn_MarkaGun
            // 
            btn_MarkaGun.BackColor = SystemColors.WindowText;
            btn_MarkaGun.BackgroundImage = (Image)resources.GetObject("btn_MarkaGun.BackgroundImage");
            btn_MarkaGun.FlatStyle = FlatStyle.Flat;
            btn_MarkaGun.Location = new Point(127, 608);
            btn_MarkaGun.Name = "btn_MarkaGun";
            btn_MarkaGun.Size = new Size(239, 65);
            btn_MarkaGun.TabIndex = 26;
            btn_MarkaGun.UseVisualStyleBackColor = false;
            btn_MarkaGun.Click += btn_MarkaGun_Click;
            // 
            // btn_Ekle
            // 
            btn_Ekle.BackgroundImage = (Image)resources.GetObject("btn_Ekle.BackgroundImage");
            btn_Ekle.Location = new Point(1204, 481);
            btn_Ekle.Name = "btn_Ekle";
            btn_Ekle.Size = new Size(208, 64);
            btn_Ekle.TabIndex = 40;
            btn_Ekle.UseVisualStyleBackColor = true;
            btn_Ekle.Click += btn_Ekle_Click;
            // 
            // txt_FiyatGun
            // 
            txt_FiyatGun.BackColor = SystemColors.InactiveCaptionText;
            txt_FiyatGun.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_FiyatGun.ForeColor = SystemColors.InactiveBorder;
            txt_FiyatGun.Location = new Point(1335, 260);
            txt_FiyatGun.MaxLength = 4;
            txt_FiyatGun.Multiline = true;
            txt_FiyatGun.Name = "txt_FiyatGun";
            txt_FiyatGun.ShortcutsEnabled = false;
            txt_FiyatGun.Size = new Size(125, 64);
            txt_FiyatGun.TabIndex = 42;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.WindowText;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1153, 259);
            button2.Name = "button2";
            button2.Size = new Size(176, 65);
            button2.TabIndex = 41;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Location = new Point(1204, 608);
            button3.Name = "button3";
            button3.Size = new Size(255, 142);
            button3.TabIndex = 43;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // VIPGomlekGuncelle
            // 
            AllowDrop = true;
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
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
            Controls.Add(dvg_GomlekList);
            Controls.Add(label1);
            Name = "VIPGomlekGuncelle";
            Text = "VIPGomlekGuncelle";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dvg_GomlekList).EndInit();
            ((System.ComponentModel.ISupportInitialize)shirtBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)shirtBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridViewTextBoxColumn ıd;
        private DataGridViewTextBoxColumn sleve;
        private DataGridViewTextBoxColumn Collar;
        private DataGridViewTextBoxColumn Fabric;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn Size;
        private DataGridViewTextBoxColumn Color;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Gender;
        private DataGridView dvg_GomlekList;
        private BindingSource shirtBindingSource;
        private BindingSource shirtBindingSource1;
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
        private TextBox txt_Id;
        private Button button1;
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
        private Button btn_Ekle;
        private TextBox txt_FiyatGun;
        private Button button2;
        private Button button3;
    }
}