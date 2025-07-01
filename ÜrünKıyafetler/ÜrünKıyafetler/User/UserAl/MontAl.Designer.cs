namespace ÜrünKıyafetler
{
    partial class MontAl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MontAl));
            txt_Bakiye = new TextBox();
            button3 = new Button();
            button2 = new Button();
            btn_Ekle = new Button();
            button1 = new Button();
            txt_Id = new TextBox();
            dvg_MontList = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dvg_MontList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jacketBindingSource).BeginInit();
            SuspendLayout();
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
            txt_Bakiye.TabIndex = 51;
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
            button3.TabIndex = 50;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Location = new Point(909, 568);
            button2.Name = "button2";
            button2.Size = new Size(336, 169);
            button2.TabIndex = 49;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btn_Ekle
            // 
            btn_Ekle.BackgroundImage = (Image)resources.GetObject("btn_Ekle.BackgroundImage");
            btn_Ekle.Location = new Point(754, 366);
            btn_Ekle.Name = "btn_Ekle";
            btn_Ekle.Size = new Size(630, 169);
            btn_Ekle.TabIndex = 48;
            btn_Ekle.UseVisualStyleBackColor = true;
            btn_Ekle.Click += btn_Ekle_Click;
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
            button1.TabIndex = 47;
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
            txt_Id.TabIndex = 46;
            // 
            // dvg_MontList
            // 
            dvg_MontList.AutoGenerateColumns = false;
            dvg_MontList.BackgroundColor = SystemColors.ActiveCaptionText;
            dvg_MontList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_MontList.Columns.AddRange(new DataGridViewColumn[] { ıdDataGridViewTextBoxColumn, hoodDataGridViewTextBoxColumn, pocketDataGridViewTextBoxColumn, fabricDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, brandDataGridViewTextBoxColumn, sizeDataGridViewTextBoxColumn, colorDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn });
            dvg_MontList.DataSource = jacketBindingSource;
            dvg_MontList.EnableHeadersVisualStyles = false;
            dvg_MontList.GridColor = SystemColors.InactiveCaptionText;
            dvg_MontList.Location = new Point(12, 12);
            dvg_MontList.Name = "dvg_MontList";
            dvg_MontList.ReadOnly = true;
            dvg_MontList.RowHeadersWidth = 51;
            dvg_MontList.Size = new Size(1302, 188);
            dvg_MontList.TabIndex = 45;
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
            hoodDataGridViewTextBoxColumn.HeaderText = "Kapşon";
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
            // MontAl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1521, 809);
            Controls.Add(txt_Bakiye);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btn_Ekle);
            Controls.Add(button1);
            Controls.Add(txt_Id);
            Controls.Add(dvg_MontList);
            Name = "MontAl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MontAl";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dvg_MontList).EndInit();
            ((System.ComponentModel.ISupportInitialize)jacketBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Bakiye;
        private Button button3;
        private Button button2;
        private Button btn_Ekle;
        private Button button1;
        private TextBox txt_Id;
        private DataGridView dvg_MontList;
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
        private BindingSource jacketBindingSource;
    }
}