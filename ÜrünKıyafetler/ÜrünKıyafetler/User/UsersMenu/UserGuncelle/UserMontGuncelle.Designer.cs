namespace ÜrünKıyafetler.User.UsersMenu.UserGuncelle
{
    partial class UserMontGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMontGuncelle));
            button2 = new Button();
            txt_Id = new TextBox();
            button1 = new Button();
            btn_Ekle = new Button();
            txt_Fiyat = new TextBox();
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
            label1 = new Label();
            dvg_GomlekList = new DataGridView();
            ıdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hoodDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pocketDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fabricDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sizeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            colorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            jacketBindingSource = new BindingSource(components);
            lst_Cep = new ListBox();
            lst_Kapuson = new ListBox();
            btn_Kapison = new Button();
            btn_Cep = new Button();
            lst_Kumas = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dvg_GomlekList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jacketBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = SystemColors.WindowText;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(57, 527);
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
            txt_Id.Location = new Point(515, 522);
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
            button1.Location = new Point(1239, 609);
            button1.Name = "button1";
            button1.Size = new Size(225, 99);
            button1.TabIndex = 80;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_Ekle
            // 
            btn_Ekle.BackgroundImage = (Image)resources.GetObject("btn_Ekle.BackgroundImage");
            btn_Ekle.Location = new Point(1211, 474);
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
            txt_Fiyat.Location = new Point(421, 255);
            txt_Fiyat.MaxLength = 4;
            txt_Fiyat.Multiline = true;
            txt_Fiyat.Name = "txt_Fiyat";
            txt_Fiyat.ShortcutsEnabled = false;
            txt_Fiyat.Size = new Size(125, 64);
            txt_Fiyat.TabIndex = 78;
            // 
            // lst_Cins
            // 
            lst_Cins.BackColor = SystemColors.InactiveCaptionText;
            lst_Cins.ForeColor = SystemColors.Info;
            lst_Cins.FormattingEnabled = true;
            lst_Cins.Items.AddRange(new object[] { "Kadın", "ERKEK" });
            lst_Cins.Location = new Point(1031, 493);
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
            lst_Renk.Location = new Point(1029, 370);
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
            lst_Bedenler.Location = new Point(364, 713);
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
            lst_Markalar.Location = new Point(357, 613);
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
            btn_Kumas.Location = new Point(767, 240);
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
            button7.Location = new Point(229, 240);
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
            btn_Marka.Location = new Point(113, 613);
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
            btn_Beden.Location = new Point(122, 713);
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
            btn_Renk.Location = new Point(814, 370);
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
            btn_Cins.Location = new Point(763, 481);
            btn_Cins.Name = "btn_Cins";
            btn_Cins.Size = new Size(260, 97);
            btn_Cins.TabIndex = 66;
            btn_Cins.UseVisualStyleBackColor = false;
            btn_Cins.Click += btn_Cins_Click;
            // 
            // label1
            // 
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(48, 412);
            label1.Name = "label1";
            label1.Size = new Size(498, 112);
            label1.TabIndex = 63;
            // 
            // dvg_GomlekList
            // 
            dvg_GomlekList.AutoGenerateColumns = false;
            dvg_GomlekList.BackgroundColor = SystemColors.ActiveCaptionText;
            dvg_GomlekList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_GomlekList.Columns.AddRange(new DataGridViewColumn[] { ıdDataGridViewTextBoxColumn, hoodDataGridViewTextBoxColumn, pocketDataGridViewTextBoxColumn, fabricDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, brandDataGridViewTextBoxColumn, sizeDataGridViewTextBoxColumn, colorDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn });
            dvg_GomlekList.DataSource = jacketBindingSource;
            dvg_GomlekList.EnableHeadersVisualStyles = false;
            dvg_GomlekList.GridColor = SystemColors.InactiveCaptionText;
            dvg_GomlekList.ImeMode = ImeMode.NoControl;
            dvg_GomlekList.Location = new Point(33, 29);
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
            // hoodDataGridViewTextBoxColumn
            // 
            hoodDataGridViewTextBoxColumn.DataPropertyName = "Hood";
            hoodDataGridViewTextBoxColumn.HeaderText = "Kapişon";
            hoodDataGridViewTextBoxColumn.MinimumWidth = 6;
            hoodDataGridViewTextBoxColumn.Name = "hoodDataGridViewTextBoxColumn";
            hoodDataGridViewTextBoxColumn.ReadOnly = true;
            hoodDataGridViewTextBoxColumn.Width = 125;
            // 
            // pocketDataGridViewTextBoxColumn
            // 
            pocketDataGridViewTextBoxColumn.DataPropertyName = "Pocket";
            pocketDataGridViewTextBoxColumn.HeaderText = "Cep";
            pocketDataGridViewTextBoxColumn.MinimumWidth = 6;
            pocketDataGridViewTextBoxColumn.Name = "pocketDataGridViewTextBoxColumn";
            pocketDataGridViewTextBoxColumn.ReadOnly = true;
            pocketDataGridViewTextBoxColumn.Width = 125;
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
            // jacketBindingSource
            // 
            jacketBindingSource.DataSource = typeof(Jacket);
            // 
            // lst_Cep
            // 
            lst_Cep.BackColor = SystemColors.InactiveCaptionText;
            lst_Cep.ForeColor = SystemColors.Info;
            lst_Cep.FormattingEnabled = true;
            lst_Cep.Items.AddRange(new object[] { "Fermuarlı ", "Düğmeli ", "Gizli ", "Kanguru " });
            lst_Cep.Location = new Point(1037, 747);
            lst_Cep.Name = "lst_Cep";
            lst_Cep.Size = new Size(125, 64);
            lst_Cep.TabIndex = 87;
            lst_Cep.Visible = false;
            // 
            // lst_Kapuson
            // 
            lst_Kapuson.BackColor = SystemColors.InactiveCaptionText;
            lst_Kapuson.ForeColor = SystemColors.Info;
            lst_Kapuson.FormattingEnabled = true;
            lst_Kapuson.Items.AddRange(new object[] { "Çıkarılabilir ", "Sabit ", "Kürklü ", "Ayarlanabilir " });
            lst_Kapuson.Location = new Point(1037, 637);
            lst_Kapuson.Name = "lst_Kapuson";
            lst_Kapuson.Size = new Size(125, 64);
            lst_Kapuson.TabIndex = 86;
            lst_Kapuson.Visible = false;
            // 
            // btn_Kapison
            // 
            btn_Kapison.BackColor = SystemColors.WindowText;
            btn_Kapison.BackgroundImage = (Image)resources.GetObject("btn_Kapison.BackgroundImage");
            btn_Kapison.BackgroundImageLayout = ImageLayout.None;
            btn_Kapison.FlatStyle = FlatStyle.Flat;
            btn_Kapison.Location = new Point(749, 613);
            btn_Kapison.Name = "btn_Kapison";
            btn_Kapison.Size = new Size(287, 106);
            btn_Kapison.TabIndex = 85;
            btn_Kapison.UseVisualStyleBackColor = false;
            btn_Kapison.Click += btn_Kapison_Click;
            // 
            // btn_Cep
            // 
            btn_Cep.BackColor = SystemColors.WindowText;
            btn_Cep.BackgroundImage = (Image)resources.GetObject("btn_Cep.BackgroundImage");
            btn_Cep.BackgroundImageLayout = ImageLayout.None;
            btn_Cep.FlatStyle = FlatStyle.Flat;
            btn_Cep.Location = new Point(857, 737);
            btn_Cep.Name = "btn_Cep";
            btn_Cep.Size = new Size(174, 83);
            btn_Cep.TabIndex = 84;
            btn_Cep.UseVisualStyleBackColor = false;
            btn_Cep.Click += btn_Cep_Click;
            // 
            // lst_Kumas
            // 
            lst_Kumas.BackColor = SystemColors.InactiveCaptionText;
            lst_Kumas.ForeColor = SystemColors.Info;
            lst_Kumas.FormattingEnabled = true;
            lst_Kumas.Items.AddRange(new object[] { "Su Geçirmez ", "Rüzgar Geçirmez ", "Pamuklu ", "Sentetik Karışımlı " });
            lst_Kumas.Location = new Point(1029, 255);
            lst_Kumas.Name = "lst_Kumas";
            lst_Kumas.Size = new Size(125, 64);
            lst_Kumas.TabIndex = 88;
            lst_Kumas.Visible = false;
            // 
            // UserMontGuncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1521, 895);
            Controls.Add(lst_Kumas);
            Controls.Add(lst_Cep);
            Controls.Add(lst_Kapuson);
            Controls.Add(btn_Kapison);
            Controls.Add(btn_Cep);
            Controls.Add(button2);
            Controls.Add(txt_Id);
            Controls.Add(button1);
            Controls.Add(btn_Ekle);
            Controls.Add(txt_Fiyat);
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
            Controls.Add(label1);
            Controls.Add(dvg_GomlekList);
            Name = "UserMontGuncelle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserMontGuncelle";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dvg_GomlekList).EndInit();
            ((System.ComponentModel.ISupportInitialize)jacketBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private TextBox txt_Id;
        private Button button1;
        private Button btn_Ekle;
        private TextBox txt_Fiyat;
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
        private Label label1;
        private DataGridView dvg_GomlekList;
        private BindingSource jacketBindingSource;
        private ListBox lst_Cep;
        private ListBox lst_Kapuson;
        private Button btn_Kapison;
        private Button btn_Cep;
        private ListBox lst_Kumas;
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