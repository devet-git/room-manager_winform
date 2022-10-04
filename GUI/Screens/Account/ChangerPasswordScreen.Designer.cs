namespace GUI.Screens.Account
{
    partial class ChangerPasswordScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConfirm = new ReaLTaiizor.Controls.MaterialButton();
            this.TxtNewPassword = new System.Windows.Forms.TextBox();
            this.TxtOldPassword = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtConfirmNewPassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnConfirm);
            this.panel1.Controls.Add(this.TxtNewPassword);
            this.panel1.Controls.Add(this.TxtOldPassword);
            this.panel1.Location = new System.Drawing.Point(473, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 399);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Xác nhận mật khẩu mới";
            // 
            // TxtConfirmNewPassword
            // 
            this.TxtConfirmNewPassword.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConfirmNewPassword.Location = new System.Drawing.Point(57, 235);
            this.TxtConfirmNewPassword.Name = "TxtConfirmNewPassword";
            this.TxtConfirmNewPassword.Size = new System.Drawing.Size(356, 35);
            this.TxtConfirmNewPassword.TabIndex = 2;
            this.TxtConfirmNewPassword.UseSystemPasswordChar = true;
            this.TxtConfirmNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtConfirmNewPassword_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.AutoSize = false;
            this.BtnConfirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnConfirm.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnConfirm.Depth = 0;
            this.BtnConfirm.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirm.HighEmphasis = true;
            this.BtnConfirm.Icon = null;
            this.BtnConfirm.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.BtnConfirm.Location = new System.Drawing.Point(57, 315);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnConfirm.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnConfirm.Size = new System.Drawing.Size(194, 51);
            this.BtnConfirm.TabIndex = 3;
            this.BtnConfirm.Text = "Đổi mật khẩu";
            this.BtnConfirm.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnConfirm.UseAccentColor = false;
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // TxtNewPassword
            // 
            this.TxtNewPassword.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNewPassword.Location = new System.Drawing.Point(57, 148);
            this.TxtNewPassword.Name = "TxtNewPassword";
            this.TxtNewPassword.Size = new System.Drawing.Size(356, 35);
            this.TxtNewPassword.TabIndex = 1;
            this.TxtNewPassword.UseSystemPasswordChar = true;
            this.TxtNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNewPassword_KeyPress);
            // 
            // TxtOldPassword
            // 
            this.TxtOldPassword.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOldPassword.Location = new System.Drawing.Point(57, 64);
            this.TxtOldPassword.Name = "TxtOldPassword";
            this.TxtOldPassword.Size = new System.Drawing.Size(356, 35);
            this.TxtOldPassword.TabIndex = 0;
            this.TxtOldPassword.UseSystemPasswordChar = true;
            this.TxtOldPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtOldPassword_KeyPress);
            // 
            // ChangerPasswordScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1378, 680);
            this.Controls.Add(this.panel1);
            this.Name = "ChangerPasswordScreen";
            this.Text = "ChangerPasswordScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtOldPassword;
        private System.Windows.Forms.TextBox TxtNewPassword;
        private ReaLTaiizor.Controls.MaterialButton BtnConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtConfirmNewPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}