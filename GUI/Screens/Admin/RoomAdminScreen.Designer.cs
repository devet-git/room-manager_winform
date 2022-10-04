namespace GUI.Screens.Admin
{
    partial class RoomAdminScreen
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
            this.components = new System.ComponentModel.Container();
            this.DgvRooms = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surchargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.codesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_managerDataSet1 = new GUI.hotel_managerDataSet1();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_managerDataSet = new GUI.hotel_managerDataSet();
            this.BtnSaveChange = new System.Windows.Forms.Button();
            this.BtnDelRow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roomsTableAdapter = new GUI.hotel_managerDataSetTableAdapters.roomsTableAdapter();
            this.codesTableAdapter = new GUI.hotel_managerDataSet1TableAdapters.codesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_managerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_managerDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvRooms
            // 
            this.DgvRooms.AllowUserToOrderColumns = true;
            this.DgvRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvRooms.AutoGenerateColumns = false;
            this.DgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvRooms.BackgroundColor = System.Drawing.Color.White;
            this.DgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.surchargeDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.DgvRooms.DataSource = this.roomsBindingSource;
            this.DgvRooms.Location = new System.Drawing.Point(10, 10);
            this.DgvRooms.Name = "DgvRooms";
            this.DgvRooms.RowHeadersWidth = 51;
            this.DgvRooms.RowTemplate.Height = 24;
            this.DgvRooms.Size = new System.Drawing.Size(1209, 520);
            this.DgvRooms.TabIndex = 0;
            this.DgvRooms.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRooms_CellValueChanged);
            this.DgvRooms.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.DgvRooms_RowStateChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Phòng Số";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.Width = 95;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Giá Phòng";
            this.rateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.Width = 99;
            // 
            // surchargeDataGridViewTextBoxColumn
            // 
            this.surchargeDataGridViewTextBoxColumn.DataPropertyName = "surcharge";
            this.surchargeDataGridViewTextBoxColumn.HeaderText = "Phụ Thu";
            this.surchargeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surchargeDataGridViewTextBoxColumn.Name = "surchargeDataGridViewTextBoxColumn";
            this.surchargeDataGridViewTextBoxColumn.Width = 85;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.DataSource = this.codesBindingSource;
            this.typeDataGridViewTextBoxColumn.DisplayMember = "description";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Loại Phòng";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.typeDataGridViewTextBoxColumn.ValueMember = "code";
            this.typeDataGridViewTextBoxColumn.Width = 104;
            // 
            // codesBindingSource
            // 
            this.codesBindingSource.DataMember = "codes";
            this.codesBindingSource.DataSource = this.hotel_managerDataSet1;
            // 
            // hotel_managerDataSet1
            // 
            this.hotel_managerDataSet1.DataSetName = "hotel_managerDataSet1";
            this.hotel_managerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Mô Tả";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 75;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "rooms";
            this.roomsBindingSource.DataSource = this.hotel_managerDataSet;
            // 
            // hotel_managerDataSet
            // 
            this.hotel_managerDataSet.DataSetName = "hotel_managerDataSet";
            this.hotel_managerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnSaveChange
            // 
            this.BtnSaveChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSaveChange.AutoSize = true;
            this.BtnSaveChange.Enabled = false;
            this.BtnSaveChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveChange.Location = new System.Drawing.Point(944, 27);
            this.BtnSaveChange.Name = "BtnSaveChange";
            this.BtnSaveChange.Size = new System.Drawing.Size(232, 52);
            this.BtnSaveChange.TabIndex = 1;
            this.BtnSaveChange.Text = "Lưu thay đổi";
            this.BtnSaveChange.UseVisualStyleBackColor = true;
            this.BtnSaveChange.Click += new System.EventHandler(this.BtnSaveChange_Click);
            // 
            // BtnDelRow
            // 
            this.BtnDelRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelRow.AutoSize = true;
            this.BtnDelRow.Enabled = false;
            this.BtnDelRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelRow.Location = new System.Drawing.Point(680, 27);
            this.BtnDelRow.Name = "BtnDelRow";
            this.BtnDelRow.Size = new System.Drawing.Size(232, 52);
            this.BtnDelRow.TabIndex = 2;
            this.BtnDelRow.Text = "Xóa dòng";
            this.BtnDelRow.UseVisualStyleBackColor = true;
            this.BtnDelRow.Click += new System.EventHandler(this.BtnDelRow_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnDelRow);
            this.panel1.Controls.Add(this.BtnSaveChange);
            this.panel1.Location = new System.Drawing.Point(10, 527);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 100);
            this.panel1.TabIndex = 3;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // codesTableAdapter
            // 
            this.codesTableAdapter.ClearBeforeFill = true;
            // 
            // RoomAdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1229, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvRooms);
            this.Name = "RoomAdminScreen";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "RoomAdminScreen";
            this.Load += new System.EventHandler(this.RoomAdminScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_managerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_managerDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvRooms;
        private System.Windows.Forms.Button BtnSaveChange;
        private System.Windows.Forms.Button BtnDelRow;
        private System.Windows.Forms.Panel panel1;
        private hotel_managerDataSet hotel_managerDataSet;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private hotel_managerDataSetTableAdapters.roomsTableAdapter roomsTableAdapter;
        private hotel_managerDataSet1 hotel_managerDataSet1;
        private System.Windows.Forms.BindingSource codesBindingSource;
        private hotel_managerDataSet1TableAdapters.codesTableAdapter codesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surchargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}