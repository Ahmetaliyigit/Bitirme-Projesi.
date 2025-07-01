namespace ÜrünKıyafetler
{
    partial class VIPGomlekSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIPGomlekSil));
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
            shirtBindingSource = new BindingSource(components);
            button1 = new Button();
            txt_Id = new TextBox();
            btn_Sil = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dvg_GomlekList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shirtBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(250, 225);
            label1.Name = "label1";
            label1.Size = new Size(190, 106);
            label1.TabIndex = 7;
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
            dvg_GomlekList.Location = new Point(30, 24);
            dvg_GomlekList.Name = "dvg_GomlekList";
            dvg_GomlekList.ReadOnly = true;
            dvg_GomlekList.RowHeadersWidth = 51;
            dvg_GomlekList.Size = new Size(1302, 188);
            dvg_GomlekList.TabIndex = 8;
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
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(47, 571);
            button1.Name = "button1";
            button1.Size = new Size(463, 59);
            button1.TabIndex = 26;
            button1.UseVisualStyleBackColor = false;
            // 
            // txt_Id
            // 
            txt_Id.BackColor = SystemColors.InactiveCaptionText;
            txt_Id.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_Id.ForeColor = SystemColors.InactiveBorder;
            txt_Id.Location = new Point(516, 566);
            txt_Id.MaxLength = 4;
            txt_Id.Multiline = true;
            txt_Id.Name = "txt_Id";
            txt_Id.ShortcutsEnabled = false;
            txt_Id.Size = new Size(125, 64);
            txt_Id.TabIndex = 27;
            // 
            // btn_Sil
            // 
            btn_Sil.BackgroundImage = (Image)resources.GetObject("btn_Sil.BackgroundImage");
            btn_Sil.Location = new Point(901, 305);
            btn_Sil.Name = "btn_Sil";
            btn_Sil.Size = new Size(256, 192);
            btn_Sil.TabIndex = 41;
            btn_Sil.UseVisualStyleBackColor = true;
            btn_Sil.Click += btn_Sil_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Location = new Point(1184, 330);
            button3.Name = "button3";
            button3.Size = new Size(255, 142);
            button3.TabIndex = 44;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // VIPGomlekSil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1521, 895);
            Controls.Add(button3);
            Controls.Add(btn_Sil);
            Controls.Add(txt_Id);
            Controls.Add(button1);
            Controls.Add(dvg_GomlekList);
            Controls.Add(label1);
            Name = "VIPGomlekSil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VIPGomlekSil";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dvg_GomlekList).EndInit();
            ((System.ComponentModel.ISupportInitialize)shirtBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dvg_GomlekList;
        private BindingSource shirtBindingSource;
        private Button button1;
        private TextBox txt_Id;
        private Button btn_Sil;
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
    }
}