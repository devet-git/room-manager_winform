namespace GUI.Screens.Admin
{
    partial class StaffAdminScreen
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
            this.DgvStaffs = new System.Windows.Forms.DataGridView();
            this.BtnSaveChange = new System.Windows.Forms.Button();
            this.BtnDelRow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStaffs)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvStaffs
            // 
            this.DgvStaffs.AllowUserToOrderColumns = true;
            this.DgvStaffs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvStaffs.BackgroundColor = System.Drawing.Color.White;
            this.DgvStaffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStaffs.Location = new System.Drawing.Point(13, 13);
            this.DgvStaffs.Name = "DgvStaffs";
            this.DgvStaffs.RowHeadersWidth = 51;
            this.DgvStaffs.RowTemplate.Height = 24;
            this.DgvStaffs.Size = new System.Drawing.Size(1187, 473);
            this.DgvStaffs.TabIndex = 0;
            this.DgvStaffs.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStaffs_CellValueChanged);
            this.DgvStaffs.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.DgvStaffs_DefaultValuesNeeded);
            this.DgvStaffs.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.DgvStaffs_RowStateChanged);
            // 
            // BtnSaveChange
            // 
            this.BtnSaveChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSaveChange.AutoSize = true;
            this.BtnSaveChange.Enabled = false;
            this.BtnSaveChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveChange.Location = new System.Drawing.Point(922, 24);
            this.BtnSaveChange.Name = "BtnSaveChange";
            this.BtnSaveChange.Size = new System.Drawing.Size(232, 52);
            this.BtnSaveChange.TabIndex = 2;
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
            this.BtnDelRow.Location = new System.Drawing.Point(658, 24);
            this.BtnDelRow.Name = "BtnDelRow";
            this.BtnDelRow.Size = new System.Drawing.Size(232, 52);
            this.BtnDelRow.TabIndex = 3;
            this.BtnDelRow.Text = "Xóa dòng";
            this.BtnDelRow.UseVisualStyleBackColor = true;
            this.BtnDelRow.Click += new System.EventHandler(this.BtnDelRow_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnDelRow);
            this.panel1.Controls.Add(this.BtnSaveChange);
            this.panel1.Location = new System.Drawing.Point(13, 480);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1187, 100);
            this.panel1.TabIndex = 4;
            // 
            // StaffAdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1213, 590);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvStaffs);
            this.Name = "StaffAdminScreen";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "StaffManagerAdminScreen";
            this.Load += new System.EventHandler(this.StaffManagementAdminScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvStaffs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvStaffs;
        private System.Windows.Forms.Button BtnSaveChange;
        private System.Windows.Forms.Button BtnDelRow;
        private System.Windows.Forms.Panel panel1;
    }
}