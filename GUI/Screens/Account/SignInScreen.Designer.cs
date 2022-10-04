namespace GUI.Screens.Account
{
    partial class SignInScreen
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
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LbPassword = new System.Windows.Forms.Label();
            this.LbPhoneNum = new System.Windows.Forms.Label();
            this.BtnSignIn = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtPhone
            // 
            this.TxtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPhone.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhone.Location = new System.Drawing.Point(32, 79);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(364, 35);
            this.TxtPhone.TabIndex = 0;
            this.TxtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPhone_KeyPress);
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogin.Controls.Add(this.TxtPassword);
            this.panelLogin.Controls.Add(this.LbPassword);
            this.panelLogin.Controls.Add(this.TxtPhone);
            this.panelLogin.Controls.Add(this.LbPhoneNum);
            this.panelLogin.Controls.Add(this.BtnSignIn);
            this.panelLogin.Location = new System.Drawing.Point(373, 96);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(432, 398);
            this.panelLogin.TabIndex = 4;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassword.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(32, 182);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(364, 35);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress);
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LbPassword.Location = new System.Drawing.Point(28, 157);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(93, 22);
            this.LbPassword.TabIndex = 0;
            this.LbPassword.Text = "Mật khẩu";
            this.LbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbPhoneNum
            // 
            this.LbPhoneNum.AutoSize = true;
            this.LbPhoneNum.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPhoneNum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LbPhoneNum.Location = new System.Drawing.Point(28, 54);
            this.LbPhoneNum.Name = "LbPhoneNum";
            this.LbPhoneNum.Size = new System.Drawing.Size(128, 22);
            this.LbPhoneNum.TabIndex = 0;
            this.LbPhoneNum.Text = "Số điện thoại";
            this.LbPhoneNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.AutoSize = true;
            this.BtnSignIn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.BtnSignIn.FlatAppearance.BorderSize = 2;
            this.BtnSignIn.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignIn.Location = new System.Drawing.Point(32, 287);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Padding = new System.Windows.Forms.Padding(10);
            this.BtnSignIn.Size = new System.Drawing.Size(179, 58);
            this.BtnSignIn.TabIndex = 2;
            this.BtnSignIn.Text = "Đăng nhập";
            this.BtnSignIn.UseVisualStyleBackColor = false;
            this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.AutoSize = true;
            this.BtnClose.BackColor = System.Drawing.Color.Red;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(1098, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnClose.Size = new System.Drawing.Size(60, 43);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.TabStop = false;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // SignInScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1158, 583);
            this.ControlBox = false;
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignInScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignInScreen_FormClosing);
            this.Load += new System.EventHandler(this.SignInScreen_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label LbPhoneNum;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnSignIn;
        private System.Windows.Forms.Button BtnClose;
    }
}