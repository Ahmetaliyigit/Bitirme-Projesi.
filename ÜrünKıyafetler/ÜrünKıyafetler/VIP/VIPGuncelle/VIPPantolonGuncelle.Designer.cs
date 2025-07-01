namespace ÜrünKıyafetler
{
    partial class VIPPantolonGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIPPantolonGuncelle));
            button3 = new Button();
            txt_FiyatGun = new TextBox();
            button2 = new Button();
            btn_Guncelle = new Button();
            lst_KumasGun = new ListBox();
            btn_KumasGun = new Button();
            lst_CinsGun = new ListBox();
            lst_RenkGun = new ListBox();
            lst_BedenGun = new ListBox();
            lst_MarkaGun = new ListBox();
            btn_CinsiyetGun = new Button();
            btn_RenkGun = new Button();
            btn_BedenGun = new Button();
            btn_MarkaGun = new Button();
            button1 = new Button();
            txt_Id = new TextBox();
            dvg_MontList = new DataGridView();
            ıdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            waistsizeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fabricDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lengthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sizeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            colorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pantsBindingSource = new BindingSource(components);
            label1 = new Label();
            lst_BelGun = new ListBox();
            btn_BelGun = new Button();
            lst_PantGun = new ListBox();
            btn_PantGun = new Button();
            ((System.ComponentModel.ISupportInitialize)dvg_MontList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pantsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Location = new Point(1219, 608);
            button3.Name = "button3";
            button3.Size = new Size(255, 142);
            button3.TabIndex = 87;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txt_FiyatGun
            // 
            txt_FiyatGun.BackColor = SystemColors.InactiveCaptionText;
            txt_FiyatGun.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_FiyatGun.ForeColor = SystemColors.InactiveBorder;
            txt_FiyatGun.Location = new Point(1350, 260);
            txt_FiyatGun.MaxLength = 4;
            txt_FiyatGun.Multiline = true;
            txt_FiyatGun.Name = "txt_FiyatGun";
            txt_FiyatGun.ShortcutsEnabled = false;
            txt_FiyatGun.Size = new Size(125, 64);
            txt_FiyatGun.TabIndex = 86;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.WindowText;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1168, 259);
            button2.Name = "button2";
            button2.Size = new Size(176, 65);
            button2.TabIndex = 85;
            button2.UseVisualStyleBackColor = false;
            // 
            // btn_Guncelle
            // 
            btn_Guncelle.BackgroundImage = (Image)resources.GetObject("btn_Guncelle.BackgroundImage");
            btn_Guncelle.Location = new Point(1219, 481);
            btn_Guncelle.Name = "btn_Guncelle";
            btn_Guncelle.Size = new Size(208, 64);
            btn_Guncelle.TabIndex = 84;
            btn_Guncelle.UseVisualStyleBackColor = true;
            btn_Guncelle.Click += btn_Guncelle_Click;
            // 
            // lst_KumasGun
            // 
            lst_KumasGun.BackColor = SystemColors.InactiveCaptionText;
            lst_KumasGun.ForeColor = SystemColors.Info;
            lst_KumasGun.FormattingEnabled = true;
            lst_KumasGun.Items.AddRange(new object[] { "Pamuk", "Polyester", "Keten", "İpek", "Yün", "Likralı" });
            lst_KumasGun.Location = new Point(991, 259);
            lst_KumasGun.Name = "lst_KumasGun";
            lst_KumasGun.Size = new Size(108, 64);
            lst_KumasGun.TabIndex = 83;
            lst_KumasGun.Visible = false;
            // 
            // btn_KumasGun
            // 
            btn_KumasGun.BackColor = SystemColors.WindowText;
            btn_KumasGun.BackgroundImage = (Image)resources.GetObject("btn_KumasGun.BackgroundImage");
            btn_KumasGun.FlatStyle = FlatStyle.Flat;
            btn_KumasGun.Location = new Point(772, 247);
            btn_KumasGun.Name = "btn_KumasGun";
            btn_KumasGun.Size = new Size(203, 76);
            btn_KumasGun.TabIndex = 82;
            btn_KumasGun.UseVisualStyleBackColor = false;
            btn_KumasGun.Click += btn_KumasGun_Click;
            // 
            // lst_CinsGun
            // 
            lst_CinsGun.BackColor = SystemColors.InactiveCaptionText;
            lst_CinsGun.ForeColor = SystemColors.Info;
            lst_CinsGun.FormattingEnabled = true;
            lst_CinsGun.Items.AddRange(new object[] { "Kadın", "ERKEK" });
            lst_CinsGun.Location = new Point(974, 475);
            lst_CinsGun.Name = "lst_CinsGun";
            lst_CinsGun.Size = new Size(125, 64);
            lst_CinsGun.TabIndex = 79;
            lst_CinsGun.Visible = false;
            // 
            // lst_RenkGun
            // 
            lst_RenkGun.BackColor = SystemColors.InactiveCaptionText;
            lst_RenkGun.ForeColor = SystemColors.Info;
            lst_RenkGun.FormattingEnabled = true;
            lst_RenkGun.Items.AddRange(new object[] { "Siyah", "Beyaz ", "Mavi", "Lacivert", "Kırmızı ", "Mavi", "Yeşik", "Gri", "Bordo", "Kahverengi" });
            lst_RenkGun.Location = new Point(991, 360);
            lst_RenkGun.Name = "lst_RenkGun";
            lst_RenkGun.Size = new Size(125, 64);
            lst_RenkGun.TabIndex = 78;
            lst_RenkGun.Visible = false;
            // 
            // lst_BedenGun
            // 
            lst_BedenGun.BackColor = SystemColors.InactiveCaptionText;
            lst_BedenGun.ForeColor = SystemColors.Info;
            lst_BedenGun.FormattingEnabled = true;
            lst_BedenGun.Items.AddRange(new object[] { "28", "30", "32", "34", "36", "38", "40", "42" });
            lst_BedenGun.Location = new Point(387, 702);
            lst_BedenGun.Name = "lst_BedenGun";
            lst_BedenGun.Size = new Size(118, 64);
            lst_BedenGun.TabIndex = 77;
            lst_BedenGun.Visible = false;
            // 
            // lst_MarkaGun
            // 
            lst_MarkaGun.BackColor = SystemColors.InactiveCaptionText;
            lst_MarkaGun.ForeColor = SystemColors.Info;
            lst_MarkaGun.FormattingEnabled = true;
            lst_MarkaGun.Items.AddRange(new object[] { "Zara", "H&M", "Nike", "Adidas", "Levi’s", "Tommy Hilfiger", "Calvin Klein", "Mango", "Puma", "Lacoste" });
            lst_MarkaGun.Location = new Point(387, 608);
            lst_MarkaGun.Name = "lst_MarkaGun";
            lst_MarkaGun.Size = new Size(118, 64);
            lst_MarkaGun.TabIndex = 76;
            lst_MarkaGun.Visible = false;
            // 
            // btn_CinsiyetGun
            // 
            btn_CinsiyetGun.BackColor = SystemColors.WindowText;
            btn_CinsiyetGun.BackgroundImage = (Image)resources.GetObject("btn_CinsiyetGun.BackgroundImage");
            btn_CinsiyetGun.FlatStyle = FlatStyle.Flat;
            btn_CinsiyetGun.Location = new Point(770, 463);
            btn_CinsiyetGun.Name = "btn_CinsiyetGun";
            btn_CinsiyetGun.Size = new Size(205, 76);
            btn_CinsiyetGun.TabIndex = 75;
            btn_CinsiyetGun.UseVisualStyleBackColor = false;
            btn_CinsiyetGun.Click += btn_CinsiyetGun_Click;
            // 
            // btn_RenkGun
            // 
            btn_RenkGun.BackColor = SystemColors.WindowText;
            btn_RenkGun.BackgroundImage = (Image)resources.GetObject("btn_RenkGun.BackgroundImage");
            btn_RenkGun.FlatStyle = FlatStyle.Flat;
            btn_RenkGun.Location = new Point(788, 351);
            btn_RenkGun.Name = "btn_RenkGun";
            btn_RenkGun.Size = new Size(180, 73);
            btn_RenkGun.TabIndex = 74;
            btn_RenkGun.UseVisualStyleBackColor = false;
            btn_RenkGun.Click += btn_RenkGun_Click;
            // 
            // btn_BedenGun
            // 
            btn_BedenGun.BackColor = SystemColors.WindowText;
            btn_BedenGun.BackgroundImage = (Image)resources.GetObject("btn_BedenGun.BackgroundImage");
            btn_BedenGun.FlatStyle = FlatStyle.Flat;
            btn_BedenGun.Location = new Point(176, 702);
            btn_BedenGun.Name = "btn_BedenGun";
            btn_BedenGun.Size = new Size(205, 64);
            btn_BedenGun.TabIndex = 73;
            btn_BedenGun.UseVisualStyleBackColor = false;
            btn_BedenGun.Click += btn_BedenGun_Click;
            // 
            // btn_MarkaGun
            // 
            btn_MarkaGun.BackColor = SystemColors.WindowText;
            btn_MarkaGun.BackgroundImage = (Image)resources.GetObject("btn_MarkaGun.BackgroundImage");
            btn_MarkaGun.FlatStyle = FlatStyle.Flat;
            btn_MarkaGun.Location = new Point(142, 608);
            btn_MarkaGun.Name = "btn_MarkaGun";
            btn_MarkaGun.Size = new Size(239, 65);
            btn_MarkaGun.TabIndex = 72;
            btn_MarkaGun.UseVisualStyleBackColor = false;
            btn_MarkaGun.Click += btn_MarkaGun_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowText;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(42, 486);
            button1.Name = "button1";
            button1.Size = new Size(480, 59);
            button1.TabIndex = 71;
            button1.UseVisualStyleBackColor = false;
            // 
            // txt_Id
            // 
            txt_Id.BackColor = SystemColors.InactiveCaptionText;
            txt_Id.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_Id.ForeColor = SystemColors.InactiveBorder;
            txt_Id.Location = new Point(528, 481);
            txt_Id.MaxLength = 4;
            txt_Id.Multiline = true;
            txt_Id.Name = "txt_Id";
            txt_Id.ShortcutsEnabled = false;
            txt_Id.Size = new Size(125, 64);
            txt_Id.TabIndex = 70;
            // 
            // dvg_MontList
            // 
            dvg_MontList.AutoGenerateColumns = false;
            dvg_MontList.BackgroundColor = SystemColors.ActiveCaptionText;
            dvg_MontList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_MontList.Columns.AddRange(new DataGridViewColumn[] { ıdDataGridViewTextBoxColumn, waistsizeDataGridViewTextBoxColumn, fabricDataGridViewTextBoxColumn, lengthDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, brandDataGridViewTextBoxColumn, sizeDataGridViewTextBoxColumn, colorDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn });
            dvg_MontList.DataSource = pantsBindingSource;
            dvg_MontList.EnableHeadersVisualStyles = false;
            dvg_MontList.GridColor = SystemColors.InactiveCaptionText;
            dvg_MontList.Location = new Point(42, 41);
            dvg_MontList.Name = "dvg_MontList";
            dvg_MontList.ReadOnly = true;
            dvg_MontList.RowHeadersWidth = 51;
            dvg_MontList.Size = new Size(1302, 188);
            dvg_MontList.TabIndex = 69;
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
            // waistsizeDataGridViewTextBoxColumn
            // 
            waistsizeDataGridViewTextBoxColumn.DataPropertyName = "Waistsize";
            waistsizeDataGridViewTextBoxColumn.HeaderText = "Bel Çevresi";
            waistsizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            waistsizeDataGridViewTextBoxColumn.Name = "waistsizeDataGridViewTextBoxColumn";
            waistsizeDataGridViewTextBoxColumn.ReadOnly = true;
            waistsizeDataGridViewTextBoxColumn.Width = 125;
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
            // lengthDataGridViewTextBoxColumn
            // 
            lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            lengthDataGridViewTextBoxColumn.HeaderText = "Pantolon Uzunluğu";
            lengthDataGridViewTextBoxColumn.MinimumWidth = 6;
            lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            lengthDataGridViewTextBoxColumn.ReadOnly = true;
            lengthDataGridViewTextBoxColumn.Width = 125;
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
            // pantsBindingSource
            // 
            pantsBindingSource.DataSource = typeof(Pants);
            // 
            // label1
            // 
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(258, 247);
            label1.Name = "label1";
            label1.Size = new Size(190, 106);
            label1.TabIndex = 68;
            // 
            // lst_BelGun
            // 
            lst_BelGun.BackColor = SystemColors.InactiveCaptionText;
            lst_BelGun.ForeColor = SystemColors.Info;
            lst_BelGun.FormattingEnabled = true;
            lst_BelGun.Items.AddRange(new object[] { "30", "32", "34", "36" });
            lst_BelGun.Location = new Point(981, 591);
            lst_BelGun.Name = "lst_BelGun";
            lst_BelGun.Size = new Size(125, 64);
            lst_BelGun.TabIndex = 91;
            lst_BelGun.Visible = false;
            // 
            // btn_BelGun
            // 
            btn_BelGun.BackColor = SystemColors.WindowText;
            btn_BelGun.BackgroundImage = (Image)resources.GetObject("btn_BelGun.BackgroundImage");
            btn_BelGun.FlatStyle = FlatStyle.Flat;
            btn_BelGun.Location = new Point(720, 579);
            btn_BelGun.Name = "btn_BelGun";
            btn_BelGun.Size = new Size(255, 76);
            btn_BelGun.TabIndex = 90;
            btn_BelGun.UseVisualStyleBackColor = false;
            btn_BelGun.Click += btn_BelGun_Click;
            // 
            // lst_PantGun
            // 
            lst_PantGun.BackColor = SystemColors.InactiveCaptionText;
            lst_PantGun.ForeColor = SystemColors.Info;
            lst_PantGun.FormattingEnabled = true;
            lst_PantGun.Items.AddRange(new object[] { "28", "30", "32", "34" });
            lst_PantGun.Location = new Point(991, 702);
            lst_PantGun.Name = "lst_PantGun";
            lst_PantGun.Size = new Size(108, 64);
            lst_PantGun.TabIndex = 93;
            lst_PantGun.Visible = false;
            // 
            // btn_PantGun
            // 
            btn_PantGun.BackColor = SystemColors.WindowText;
            btn_PantGun.BackgroundImage = (Image)resources.GetObject("btn_PantGun.BackgroundImage");
            btn_PantGun.FlatStyle = FlatStyle.Flat;
            btn_PantGun.Location = new Point(604, 690);
            btn_PantGun.Name = "btn_PantGun";
            btn_PantGun.Size = new Size(364, 76);
            btn_PantGun.TabIndex = 92;
            btn_PantGun.UseVisualStyleBackColor = false;
            btn_PantGun.Click += btn_PantGun_Click;
            // 
            // VIPPantolonGuncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1521, 895);
            Controls.Add(lst_PantGun);
            Controls.Add(btn_PantGun);
            Controls.Add(lst_BelGun);
            Controls.Add(btn_BelGun);
            Controls.Add(button3);
            Controls.Add(txt_FiyatGun);
            Controls.Add(button2);
            Controls.Add(btn_Guncelle);
            Controls.Add(lst_KumasGun);
            Controls.Add(btn_KumasGun);
            Controls.Add(lst_CinsGun);
            Controls.Add(lst_RenkGun);
            Controls.Add(lst_BedenGun);
            Controls.Add(lst_MarkaGun);
            Controls.Add(btn_CinsiyetGun);
            Controls.Add(btn_RenkGun);
            Controls.Add(btn_BedenGun);
            Controls.Add(btn_MarkaGun);
            Controls.Add(button1);
            Controls.Add(txt_Id);
            Controls.Add(dvg_MontList);
            Controls.Add(label1);
            Name = "VIPPantolonGuncelle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VIPPantolonGuncelle";
            Load += MainForm_Load1;
            ((System.ComponentModel.ISupportInitialize)dvg_MontList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pantsBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private TextBox txt_FiyatGun;
        private Button button2;
        private Button btn_Guncelle;
        private ListBox lst_KumasGun;
        private Button btn_KumasGun;
        private ListBox lst_CinsGun;
        private ListBox lst_RenkGun;
        private ListBox lst_BedenGun;
        private ListBox lst_MarkaGun;
        private Button btn_CinsiyetGun;
        private Button btn_RenkGun;
        private Button btn_BedenGun;
        private Button btn_MarkaGun;
        private Button button1;
        private TextBox txt_Id;
        private DataGridView dvg_MontList;
        private BindingSource pantsBindingSource;
        private Label label1;
        private ListBox lst_BelGun;
        private Button btn_BelGun;
        private ListBox lst_PantGun;
        private Button btn_PantGun;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn waistsizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fabricDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
    }
}