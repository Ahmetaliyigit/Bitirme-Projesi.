namespace ÜrünKıyafetler
{
    partial class GomlekAl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GomlekAl));
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
            shirtBindingSource = new BindingSource(components);
            button1 = new Button();
            txt_Id = new TextBox();
            btn_Ekle = new Button();
            button2 = new Button();
            button3 = new Button();
            txt_Bakiye = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dvg_GomlekList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shirtBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dvg_GomlekList
            // 
            dvg_GomlekList.AutoGenerateColumns = false;
            dvg_GomlekList.BackgroundColor = SystemColors.ActiveCaptionText;
            dvg_GomlekList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_GomlekList.Columns.AddRange(new DataGridViewColumn[] { ıdDataGridViewTextBoxColumn, sleveDataGridViewTextBoxColumn, collarDataGridViewTextBoxColumn, fabricDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, brandDataGridViewTextBoxColumn, sizeDataGridViewTextBoxColumn, colorDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn });
            dvg_GomlekList.DataSource = shirtBindingSource;
            dvg_GomlekList.EnableHeadersVisualStyles = false;
            dvg_GomlekList.GridColor = SystemColors.InactiveCaptionText;
            dvg_GomlekList.Location = new Point(12, 12);
            dvg_GomlekList.Name = "dvg_GomlekList";
            dvg_GomlekList.ReadOnly = true;
            dvg_GomlekList.RowHeadersWidth = 51;
            dvg_GomlekList.Size = new Size(1302, 188);
            dvg_GomlekList.TabIndex = 8;
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
            // shirtBindingSource
            // 
            shirtBindingSource.DataSource = typeof(Shirt);
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowText;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(44, 471);
            button1.Name = "button1";
            button1.Size = new Size(480, 64);
            button1.TabIndex = 27;
            button1.UseVisualStyleBackColor = false;
            // 
            // txt_Id
            // 
            txt_Id.BackColor = SystemColors.InactiveCaptionText;
            txt_Id.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_Id.ForeColor = SystemColors.InactiveBorder;
            txt_Id.Location = new Point(530, 471);
            txt_Id.MaxLength = 4;
            txt_Id.Multiline = true;
            txt_Id.Name = "txt_Id";
            txt_Id.ShortcutsEnabled = false;
            txt_Id.Size = new Size(125, 64);
            txt_Id.TabIndex = 26;
            // 
            // btn_Ekle
            // 
            btn_Ekle.BackgroundImage = (Image)resources.GetObject("btn_Ekle.BackgroundImage");
            btn_Ekle.Location = new Point(754, 366);
            btn_Ekle.Name = "btn_Ekle";
            btn_Ekle.Size = new Size(630, 169);
            btn_Ekle.TabIndex = 41;
            btn_Ekle.UseVisualStyleBackColor = true;
            btn_Ekle.Click += btn_Ekle_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Location = new Point(909, 568);
            button2.Name = "button2";
            button2.Size = new Size(336, 169);
            button2.TabIndex = 42;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.WindowText;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(77, 568);
            button3.Name = "button3";
            button3.Size = new Size(388, 103);
            button3.TabIndex = 43;
            button3.UseVisualStyleBackColor = false;
            // 
            // txt_Bakiye
            // 
            txt_Bakiye.BackColor = SystemColors.InactiveCaptionText;
            txt_Bakiye.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_Bakiye.ForeColor = SystemColors.InactiveBorder;
            txt_Bakiye.Location = new Point(484, 568);
            txt_Bakiye.MaxLength = 4;
            txt_Bakiye.Multiline = true;
            txt_Bakiye.Name = "txt_Bakiye";
            txt_Bakiye.ReadOnly = true;
            txt_Bakiye.ShortcutsEnabled = false;
            txt_Bakiye.Size = new Size(146, 103);
            txt_Bakiye.TabIndex = 44;
            // 
            // GomlekAl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1521, 809);
            Controls.Add(txt_Bakiye);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btn_Ekle);
            Controls.Add(button1);
            Controls.Add(txt_Id);
            Controls.Add(dvg_GomlekList);
            DoubleBuffered = true;
            Name = "GomlekAl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GomlekAl";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dvg_GomlekList).EndInit();
            ((System.ComponentModel.ISupportInitialize)shirtBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvg_GomlekList;
        private BindingSource shirtBindingSource;
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
        private Button button1;
        private TextBox txt_Id;
        private Button btn_Ekle;
        private Button button2;
        private Button button3;
        private TextBox txt_Bakiye;
    }
}