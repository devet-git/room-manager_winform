namespace GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BtnStaffAdmin = new System.Windows.Forms.Button();
            this.BtnRoomAdmin = new System.Windows.Forms.Button();
            this.panelAccountMenu = new System.Windows.Forms.Panel();
            this.BtnSignOut = new System.Windows.Forms.Button();
            this.BtnChangePassword = new System.Windows.Forms.Button();
            this.BtnStatistics = new System.Windows.Forms.Button();
            this.BtnAccountMenu = new System.Windows.Forms.Button();
            this.BtnRoomBooking = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.LbAppName = new System.Windows.Forms.Label();
            this.panelShowScreens = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelAccountMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelShowScreens.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(194)))), ((int)(((byte)(155)))));
            this.panelMenu.Controls.Add(this.BtnStaffAdmin);
            this.panelMenu.Controls.Add(this.BtnRoomAdmin);
            this.panelMenu.Controls.Add(this.panelAccountMenu);
            this.panelMenu.Controls.Add(this.BtnStatistics);
            this.panelMenu.Controls.Add(this.BtnAccountMenu);
            this.panelMenu.Controls.Add(this.BtnRoomBooking);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panelMenu.Size = new System.Drawing.Size(301, 700);
            this.panelMenu.TabIndex = 0;
            // 
            // BtnStaffAdmin
            // 
            this.BtnStaffAdmin.BackColor = System.Drawing.Color.Transparent;
            this.BtnStaffAdmin.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnStaffAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnStaffAdmin.FlatAppearance.BorderSize = 0;
            this.BtnStaffAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStaffAdmin.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStaffAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnStaffAdmin.Image = ((System.Drawing.Image)(resources.GetObject("BtnStaffAdmin.Image")));
            this.BtnStaffAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStaffAdmin.Location = new System.Drawing.Point(0, 325);
            this.BtnStaffAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.BtnStaffAdmin.Name = "BtnStaffAdmin";
            this.BtnStaffAdmin.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnStaffAdmin.Size = new System.Drawing.Size(301, 70);
            this.BtnStaffAdmin.TabIndex = 4;
            this.BtnStaffAdmin.Text = " Nhân viên";
            this.BtnStaffAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnStaffAdmin.UseVisualStyleBackColor = false;
            this.BtnStaffAdmin.Click += new System.EventHandler(this.BtnStaffAdmin_Click);
            // 
            // BtnRoomAdmin
            // 
            this.BtnRoomAdmin.BackColor = System.Drawing.Color.Transparent;
            this.BtnRoomAdmin.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnRoomAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRoomAdmin.FlatAppearance.BorderSize = 0;
            this.BtnRoomAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRoomAdmin.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRoomAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnRoomAdmin.Image = ((System.Drawing.Image)(resources.GetObject("BtnRoomAdmin.Image")));
            this.BtnRoomAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRoomAdmin.Location = new System.Drawing.Point(0, 255);
            this.BtnRoomAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.BtnRoomAdmin.Name = "BtnRoomAdmin";
            this.BtnRoomAdmin.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnRoomAdmin.Size = new System.Drawing.Size(301, 70);
            this.BtnRoomAdmin.TabIndex = 3;
            this.BtnRoomAdmin.Text = " Phòng";
            this.BtnRoomAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRoomAdmin.UseVisualStyleBackColor = false;
            this.BtnRoomAdmin.Click += new System.EventHandler(this.BtnRoomAdmin_Click);
            // 
            // panelAccountMenu
            // 
            this.panelAccountMenu.AutoSize = true;
            this.panelAccountMenu.BackColor = System.Drawing.Color.Bisque;
            this.panelAccountMenu.Controls.Add(this.BtnSignOut);
            this.panelAccountMenu.Controls.Add(this.BtnChangePassword);
            this.panelAccountMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAccountMenu.Location = new System.Drawing.Point(0, 471);
            this.panelAccountMenu.Name = "panelAccountMenu";
            this.panelAccountMenu.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.panelAccountMenu.Size = new System.Drawing.Size(301, 142);
            this.panelAccountMenu.TabIndex = 3;
            this.panelAccountMenu.Visible = false;
            // 
            // BtnSignOut
            // 
            this.BtnSignOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSignOut.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignOut.Location = new System.Drawing.Point(22, 79);
            this.BtnSignOut.Name = "BtnSignOut";
            this.BtnSignOut.Size = new System.Drawing.Size(258, 50);
            this.BtnSignOut.TabIndex = 6;
            this.BtnSignOut.Text = "Đăng xuất";
            this.BtnSignOut.UseVisualStyleBackColor = false;
            this.BtnSignOut.Click += new System.EventHandler(this.BtnSignOut_Click);
            // 
            // BtnChangePassword
            // 
            this.BtnChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnChangePassword.BackColor = System.Drawing.Color.Linen;
            this.BtnChangePassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangePassword.Location = new System.Drawing.Point(22, 23);
            this.BtnChangePassword.Name = "BtnChangePassword";
            this.BtnChangePassword.Size = new System.Drawing.Size(258, 50);
            this.BtnChangePassword.TabIndex = 7;
            this.BtnChangePassword.Text = "Đổi mật khẩu";
            this.BtnChangePassword.UseVisualStyleBackColor = false;
            this.BtnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // BtnStatistics
            // 
            this.BtnStatistics.BackColor = System.Drawing.Color.Transparent;
            this.BtnStatistics.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnStatistics.FlatAppearance.BorderSize = 0;
            this.BtnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStatistics.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStatistics.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnStatistics.Image = ((System.Drawing.Image)(resources.GetObject("BtnStatistics.Image")));
            this.BtnStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStatistics.Location = new System.Drawing.Point(0, 185);
            this.BtnStatistics.Margin = new System.Windows.Forms.Padding(0);
            this.BtnStatistics.Name = "BtnStatistics";
            this.BtnStatistics.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnStatistics.Size = new System.Drawing.Size(301, 70);
            this.BtnStatistics.TabIndex = 2;
            this.BtnStatistics.Text = " Thống kê";
            this.BtnStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnStatistics.UseVisualStyleBackColor = false;
            this.BtnStatistics.Click += new System.EventHandler(this.BtnStatistics_Click);
            // 
            // BtnAccountMenu
            // 
            this.BtnAccountMenu.BackColor = System.Drawing.Color.Transparent;
            this.BtnAccountMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnAccountMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAccountMenu.FlatAppearance.BorderSize = 0;
            this.BtnAccountMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAccountMenu.Font = new System.Drawing.Font("Verdana", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAccountMenu.ForeColor = System.Drawing.Color.Black;
            this.BtnAccountMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnAccountMenu.Image")));
            this.BtnAccountMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAccountMenu.Location = new System.Drawing.Point(0, 613);
            this.BtnAccountMenu.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAccountMenu.Name = "BtnAccountMenu";
            this.BtnAccountMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnAccountMenu.Size = new System.Drawing.Size(301, 77);
            this.BtnAccountMenu.TabIndex = 5;
            this.BtnAccountMenu.Text = " Fullname";
            this.BtnAccountMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAccountMenu.UseVisualStyleBackColor = false;
            this.BtnAccountMenu.Click += new System.EventHandler(this.BtnAccountMenu_Click);
            // 
            // BtnRoomBooking
            // 
            this.BtnRoomBooking.BackColor = System.Drawing.Color.Transparent;
            this.BtnRoomBooking.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnRoomBooking.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRoomBooking.FlatAppearance.BorderSize = 0;
            this.BtnRoomBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRoomBooking.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRoomBooking.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnRoomBooking.Image = ((System.Drawing.Image)(resources.GetObject("BtnRoomBooking.Image")));
            this.BtnRoomBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRoomBooking.Location = new System.Drawing.Point(0, 115);
            this.BtnRoomBooking.Margin = new System.Windows.Forms.Padding(0);
            this.BtnRoomBooking.Name = "BtnRoomBooking";
            this.BtnRoomBooking.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnRoomBooking.Size = new System.Drawing.Size(301, 70);
            this.BtnRoomBooking.TabIndex = 1;
            this.BtnRoomBooking.Text = " Đặt phòng";
            this.BtnRoomBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRoomBooking.UseVisualStyleBackColor = false;
            this.BtnRoomBooking.Click += new System.EventHandler(this.BtnRoomBooking_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.LbAppName);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(301, 115);
            this.panelLogo.TabIndex = 0;
            // 
            // LbAppName
            // 
            this.LbAppName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbAppName.Font = new System.Drawing.Font("ROG Fonts", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAppName.ForeColor = System.Drawing.Color.Black;
            this.LbAppName.Location = new System.Drawing.Point(0, 0);
            this.LbAppName.Name = "LbAppName";
            this.LbAppName.Size = new System.Drawing.Size(301, 115);
            this.LbAppName.TabIndex = 1;
            this.LbAppName.Text = "Room Manager";
            this.LbAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelShowScreens
            // 
            this.panelShowScreens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(194)))), ((int)(((byte)(155)))));
            this.panelShowScreens.Controls.Add(this.label3);
            this.panelShowScreens.Controls.Add(this.label2);
            this.panelShowScreens.Controls.Add(this.label1);
            this.panelShowScreens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShowScreens.Location = new System.Drawing.Point(301, 0);
            this.panelShowScreens.Name = "panelShowScreens";
            this.panelShowScreens.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelShowScreens.Size = new System.Drawing.Size(1119, 700);
            this.panelShowScreens.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 653);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "25/09/2022";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(840, 653);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Created by Devet and Allies";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(812, 224);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phần mềm quản lý phòng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1420, 700);
            this.Controls.Add(this.panelShowScreens);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainForm";
            this.Text = "Hotel Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelAccountMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelShowScreens.ResumeLayout(false);
            this.panelShowScreens.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button BtnRoomBooking;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label LbAppName;
        private System.Windows.Forms.Panel panelShowScreens;
        private System.Windows.Forms.Button BtnStatistics;
        private System.Windows.Forms.Button BtnAccountMenu;
        private System.Windows.Forms.Panel panelAccountMenu;
        private System.Windows.Forms.Button BtnSignOut;
        private System.Windows.Forms.Button BtnChangePassword;
        private System.Windows.Forms.Button BtnRoomAdmin;
        private System.Windows.Forms.Button BtnStaffAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

