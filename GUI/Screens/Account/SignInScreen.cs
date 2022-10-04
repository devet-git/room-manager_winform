using System;
using System.Drawing;
using System.Windows.Forms;
using BLL;

namespace GUI.Screens.Account
{
    public partial class SignInScreen : Form
    {
        public SignInScreen()
        {
            InitializeComponent();
            //this.MinimumSize = new Size(430, 440);
           // this.MaximumSize = new Size(430, 440);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void SignInScreen_Load(object sender, EventArgs e)
        {
            this.ActiveControl = TxtPhone;
            TxtPhone.Focus();
        }
        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            string phoneNumber = TxtPhone.Text.Trim();
            string pw = TxtPassword.Text.Trim();

            if (phoneNumber == "" || pw == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AuthBLL.CheckSignIn(phoneNumber, TxtPassword.Text))
            {
                //new MainForm().Show();
                MainForm.MainFormInstance.Hide();
                new MainForm().Show();
                this.Hide();
            }
            else
                MessageBox.Show("Thông tin đăng nhập không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void SignInScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            /* if (!AuthBLL.IsSignIn)
                 MainForm.MainFormInstance.Hide();*/
            e.Cancel = true;
        }

        private void TxtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.TextboxOnlyNumber(sender, 10, e);
            if (e.KeyChar.Equals((char)13))
            {
                e.Handled = true;
                TxtPassword.Focus();
            }
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            MainForm.MainFormInstance.Close();
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                e.Handled = true;
                BtnSignIn.PerformClick();
            }
        }
    }
}
