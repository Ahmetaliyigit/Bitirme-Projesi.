namespace ÜrünKıyafetler.User.UsersMenu.UserGuncelle
{
    partial class UserTisortGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserTisortGuncelle));
            lst_KumasGun = new ListBox();
            button2 = new Button();
            txt_Id = new TextBox();
            button1 = new Button();
            btn_Ekle = new Button();
            txt_Fiyat = new TextBox();
            lst_Kol = new ListBox();
            lst_Cins = new ListBox();
            lst_Renk = new ListBox();
            lst_Bedenler = new ListBox();
            lst_Markalar = new ListBox();
            btn_Kumas = new Button();
            button7 = new Button();
            btn_Marka = new Button();
            btn_Beden = new Button();
            btn_Renk = new Button();
            btn_Cins = new Button();
            btn_Kol = new Button();
            btn_Yaka = new Button();
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
            tshirtBindingSource = new BindingSource(components);
            lst_Yaka2 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dvg_GomlekList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tshirtBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lst_KumasGun
            // 
            lst_KumasGun.BackColor = SystemColors.InactiveCaptionText;
            lst_KumasGun.ForeColor = SystemColors.Info;
            lst_KumasGun.FormattingEnabled = true;
            lst_KumasGun.Items.AddRange(new object[] { "Pamuk", "Polyester", "Keten", "İpek", "Yün", "Likralı" });
            lst_KumasGun.Location = new Point(1003, 238);
            lst_KumasGun.Name = "lst_KumasGun";
            lst_KumasGun.Size = new Size(108, 64);
            lst_KumasGun.TabIndex = 83;
            lst_KumasGun.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.WindowText;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(36, 510);
            button2.Name = "button2";
            button2.Size = new Size(452, 59);
            button2.TabIndex = 82;
            button2.UseVisualStyleBackColor = false;
            // 
            // txt_Id
            // 
            txt_Id.BackColor = SystemColors.InactiveCaptionText;
            txt_Id.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_Id.ForeColor = SystemColors.InactiveBorder;
            txt_Id.Location = new Point(494, 505);
            txt_Id.MaxLength = 4;
            txt_Id.Multiline = true;
            txt_Id.Name = "txt_Id";
            txt_Id.ShortcutsEnabled = false;
            txt_Id.Size = new Size(125, 64);
            txt_Id.TabIndex = 81;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowText;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1218, 592);
            button1.Name = "button1";
            button1.Size = new Size(225, 99);
            button1.TabIndex = 80;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_Ekle
            // 
            btn_Ekle.BackgroundImage = (Image)resources.GetObject("btn_Ekle.BackgroundImage");
            btn_Ekle.Location = new Point(1190, 457);
            btn_Ekle.Name = "btn_Ekle";
            btn_Ekle.Size = new Size(253, 83);
            btn_Ekle.TabIndex = 79;
            btn_Ekle.UseVisualStyleBackColor = true;
            btn_Ekle.Click += btn_Ekle_Click;
            // 
            // txt_Fiyat
            // 
            txt_Fiyat.BackColor = SystemColors.InactiveCaptionText;
            txt_Fiyat.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_Fiyat.ForeColor = SystemColors.InactiveBorder;
            txt_Fiyat.Location = new Point(400, 238);
            txt_Fiyat.MaxLength = 4;
            txt_Fiyat.Multiline = true;
            txt_Fiyat.Name = "txt_Fiyat";
            txt_Fiyat.ShortcutsEnabled = false;
            txt_Fiyat.Size = new Size(125, 64);
            txt_Fiyat.TabIndex = 78;
            // 
            // lst_Kol
            // 
            lst_Kol.BackColor = SystemColors.InactiveCaptionText;
            lst_Kol.ForeColor = SystemColors.Info;
            lst_Kol.FormattingEnabled = true;
            lst_Kol.Items.AddRange(new object[] { "Ksıa", "Uzun", "Kolsuz" });
            lst_Kol.Location = new Point(1003, 600);
            lst_Kol.Name = "lst_Kol";
            lst_Kol.Size = new Size(125, 64);
            lst_Kol.TabIndex = 76;
            lst_Kol.Visible = false;
            // 
            // lst_Cins
            // 
            lst_Cins.BackColor = SystemColors.InactiveCaptionText;
            lst_Cins.ForeColor = SystemColors.Info;
            lst_Cins.FormattingEnabled = true;
            lst_Cins.Items.AddRange(new object[] { "Kadın", "ERKEK" });
            lst_Cins.Location = new Point(1010, 476);
            lst_Cins.Name = "lst_Cins";
            lst_Cins.Size = new Size(125, 64);
            lst_Cins.TabIndex = 75;
            lst_Cins.Visible = false;
            // 
            // lst_Renk
            // 
            lst_Renk.BackColor = SystemColors.InactiveCaptionText;
            lst_Renk.ForeColor = SystemColors.Info;
            lst_Renk.FormattingEnabled = true;
            lst_Renk.Items.AddRange(new object[] { "Siyah", "Beyaz ", "Mavi", "Lacivert", "Kırmızı ", "Mavi", "Yeşik", "Gri", "Bordo", "Kahverengi" });
            lst_Renk.Location = new Point(1008, 353);
            lst_Renk.Name = "lst_Renk";
            lst_Renk.Size = new Size(125, 64);
            lst_Renk.TabIndex = 74;
            lst_Renk.Visible = false;
            // 
            // lst_Bedenler
            // 
            lst_Bedenler.BackColor = SystemColors.InactiveCaptionText;
            lst_Bedenler.ForeColor = SystemColors.Info;
            lst_Bedenler.FormattingEnabled = true;
            lst_Bedenler.Items.AddRange(new object[] { "S", "M ", "L", "XL", "XXL", "3XL" });
            lst_Bedenler.Location = new Point(343, 696);
            lst_Bedenler.Name = "lst_Bedenler";
            lst_Bedenler.Size = new Size(118, 64);
            lst_Bedenler.TabIndex = 73;
            lst_Bedenler.Visible = false;
            // 
            // lst_Markalar
            // 
            lst_Markalar.BackColor = SystemColors.InactiveCaptionText;
            lst_Markalar.ForeColor = SystemColors.Info;
            lst_Markalar.FormattingEnabled = true;
            lst_Markalar.Items.AddRange(new object[] { "Zara", "H&M", "Nike", "Adidas", "Levi’s", "Tommy Hilfiger", "Calvin Klein", "Mango", "Puma", "Lacoste" });
            lst_Markalar.Location = new Point(336, 596);
            lst_Markalar.Name = "lst_Markalar";
            lst_Markalar.Size = new Size(118, 64);
            lst_Markalar.TabIndex = 72;
            lst_Markalar.Visible = false;
            // 
            // btn_Kumas
            // 
            btn_Kumas.BackColor = SystemColors.WindowText;
            btn_Kumas.BackgroundImage = (Image)resources.GetObject("btn_Kumas.BackgroundImage");
            btn_Kumas.BackgroundImageLayout = ImageLayout.None;
            btn_Kumas.FlatStyle = FlatStyle.Flat;
            btn_Kumas.Location = new Point(746, 223);
            btn_Kumas.Name = "btn_Kumas";
            btn_Kumas.Size = new Size(246, 105);
            btn_Kumas.TabIndex = 71;
            btn_Kumas.UseVisualStyleBackColor = false;
            btn_Kumas.Click += btn_Kumas_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.WindowText;
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.None;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(208, 223);
            button7.Name = "button7";
            button7.Size = new Size(186, 79);
            button7.TabIndex = 70;
            button7.UseVisualStyleBackColor = false;
            // 
            // btn_Marka
            // 
            btn_Marka.BackColor = SystemColors.WindowText;
            btn_Marka.BackgroundImage = (Image)resources.GetObject("btn_Marka.BackgroundImage");
            btn_Marka.BackgroundImageLayout = ImageLayout.None;
            btn_Marka.FlatStyle = FlatStyle.Flat;
            btn_Marka.Location = new Point(92, 596);
            btn_Marka.Name = "btn_Marka";
            btn_Marka.Size = new Size(233, 74);
            btn_Marka.TabIndex = 69;
            btn_Marka.UseVisualStyleBackColor = false;
            btn_Marka.Click += btn_Marka_Click;
            // 
            // btn_Beden
            // 
            btn_Beden.BackColor = SystemColors.WindowText;
            btn_Beden.BackgroundImage = (Image)resources.GetObject("btn_Beden.BackgroundImage");
            btn_Beden.BackgroundImageLayout = ImageLayout.None;
            btn_Beden.FlatStyle = FlatStyle.Flat;
            btn_Beden.Location = new Point(101, 696);
            btn_Beden.Name = "btn_Beden";
            btn_Beden.Size = new Size(224, 89);
            btn_Beden.TabIndex = 68;
            btn_Beden.UseVisualStyleBackColor = false;
            btn_Beden.Click += btn_Beden_Click;
            // 
            // btn_Renk
            // 
            btn_Renk.BackColor = SystemColors.WindowText;
            btn_Renk.BackgroundImage = (Image)resources.GetObject("btn_Renk.BackgroundImage");
            btn_Renk.BackgroundImageLayout = ImageLayout.None;
            btn_Renk.FlatStyle = FlatStyle.Flat;
            btn_Renk.Location = new Point(793, 353);
            btn_Renk.Name = "btn_Renk";
            btn_Renk.Size = new Size(209, 80);
            btn_Renk.TabIndex = 67;
            btn_Renk.UseVisualStyleBackColor = false;
            btn_Renk.Click += btn_Renk_Click;
            // 
            // btn_Cins
            // 
            btn_Cins.BackColor = SystemColors.WindowText;
            btn_Cins.BackgroundImage = (Image)resources.GetObject("btn_Cins.BackgroundImage");
            btn_Cins.BackgroundImageLayout = ImageLayout.None;
            btn_Cins.FlatStyle = FlatStyle.Flat;
            btn_Cins.Location = new Point(742, 464);
            btn_Cins.Name = "btn_Cins";
            btn_Cins.Size = new Size(260, 97);
            btn_Cins.TabIndex = 66;
            btn_Cins.UseVisualStyleBackColor = false;
            btn_Cins.Click += btn_Cins_Click;
            // 
            // btn_Kol
            // 
            btn_Kol.BackColor = SystemColors.WindowText;
            btn_Kol.BackgroundImage = (Image)resources.GetObject("btn_Kol.BackgroundImage");
            btn_Kol.BackgroundImageLayout = ImageLayout.None;
            btn_Kol.FlatStyle = FlatStyle.Flat;
            btn_Kol.Location = new Point(808, 592);
            btn_Kol.Name = "btn_Kol";
            btn_Kol.Size = new Size(184, 83);
            btn_Kol.TabIndex = 65;
            btn_Kol.UseVisualStyleBackColor = false;
            btn_Kol.Click += btn_Kol_Click;
            // 
            // btn_Yaka
            // 
            btn_Yaka.BackColor = SystemColors.WindowText;
            btn_Yaka.BackgroundImage = (Image)resources.GetObject("btn_Yaka.BackgroundImage");
            btn_Yaka.BackgroundImageLayout = ImageLayout.None;
            btn_Yaka.FlatStyle = FlatStyle.Flat;
            btn_Yaka.Location = new Point(793, 707);
            btn_Yaka.Name = "btn_Yaka";
            btn_Yaka.Size = new Size(199, 83);
            btn_Yaka.TabIndex = 64;
            btn_Yaka.UseVisualStyleBackColor = false;
            btn_Yaka.Click += btn_Yaka_Click;
            // 
            // label1
            // 
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(27, 395);
            label1.Name = "label1";
            label1.Size = new Size(498, 112);
            label1.TabIndex = 63;
            // 
            // dvg_GomlekList
            // 
            dvg_GomlekList.AutoGenerateColumns = false;
            dvg_GomlekList.BackgroundColor = SystemColors.ActiveCaptionText;
            dvg_GomlekList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_GomlekList.Columns.AddRange(new DataGridViewColumn[] { ıdDataGridViewTextBoxColumn, sleveDataGridViewTextBoxColumn, collarDataGridViewTextBoxColumn, fabricDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, brandDataGridViewTextBoxColumn, sizeDataGridViewTextBoxColumn, colorDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn });
            dvg_GomlekList.DataSource = tshirtBindingSource;
            dvg_GomlekList.EnableHeadersVisualStyles = false;
            dvg_GomlekList.GridColor = SystemColors.InactiveCaptionText;
            dvg_GomlekList.ImeMode = ImeMode.NoControl;
            dvg_GomlekList.Location = new Point(12, 12);
            dvg_GomlekList.Name = "dvg_GomlekList";
            dvg_GomlekList.ReadOnly = true;
            dvg_GomlekList.RowHeadersWidth = 51;
            dvg_GomlekList.Size = new Size(1302, 188);
            dvg_GomlekList.TabIndex = 62;
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
            // tshirtBindingSource
            // 
            tshirtBindingSource.DataSource = typeof(Tshirt);
            // 
            // lst_Yaka2
            // 
            lst_Yaka2.BackColor = SystemColors.InactiveCaptionText;
            lst_Yaka2.ForeColor = SystemColors.Info;
            lst_Yaka2.FormattingEnabled = true;
            lst_Yaka2.Items.AddRange(new object[] { "Klasik Yuvarlak", "V ", "Derin ve Geniş" });
            lst_Yaka2.Location = new Point(998, 707);
            lst_Yaka2.Name = "lst_Yaka2";
            lst_Yaka2.Size = new Size(108, 64);
            lst_Yaka2.TabIndex = 89;
            lst_Yaka2.Visible = false;
            // 
            // UserTisortGuncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1521, 809);
            Controls.Add(lst_Yaka2);
            Controls.Add(lst_KumasGun);
            Controls.Add(button2);
            Controls.Add(txt_Id);
            Controls.Add(button1);
            Controls.Add(btn_Ekle);
            Controls.Add(txt_Fiyat);
            Controls.Add(lst_Kol);
            Controls.Add(lst_Cins);
            Controls.Add(lst_Renk);
            Controls.Add(lst_Bedenler);
            Controls.Add(lst_Markalar);
            Controls.Add(btn_Kumas);
            Controls.Add(button7);
            Controls.Add(btn_Marka);
            Controls.Add(btn_Beden);
            Controls.Add(btn_Renk);
            Controls.Add(btn_Cins);
            Controls.Add(btn_Kol);
            Controls.Add(btn_Yaka);
            Controls.Add(label1);
            Controls.Add(dvg_GomlekList);
            Name = "UserTisortGuncelle";
            Text = "UserTisortGuncelle";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dvg_GomlekList).EndInit();
            ((System.ComponentModel.ISupportInitialize)tshirtBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lst_KumasGun;
        private Button button2;
        private TextBox txt_Id;
        private Button button1;
        private Button btn_Ekle;
        private TextBox txt_Fiyat;
        private ListBox lst_Kol;
        private ListBox lst_Cins;
        private ListBox lst_Renk;
        private ListBox lst_Bedenler;
        private ListBox lst_Markalar;
        private Button btn_Kumas;
        private Button button7;
        private Button btn_Marka;
        private Button btn_Beden;
        private Button btn_Renk;
        private Button btn_Cins;
        private Button btn_Kol;
        private Button btn_Yaka;
        private Label label1;
        private DataGridView dvg_GomlekList;
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
        private BindingSource tshirtBindingSource;
        private ListBox lst_Yaka2;
    }
}