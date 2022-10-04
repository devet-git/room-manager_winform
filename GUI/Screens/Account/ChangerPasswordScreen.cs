using BLL;
using GUI.Utilities;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Screens.Account
{
    public partial class ChangerPasswordScreen : Form
    {
        public ChangerPasswordScreen()
        {
            InitializeComponent();
        }
        
        private string HashPassword(string password, byte[] salt = null, bool needsOnlyHash = false)
        {
            if (salt == null || salt.Length != 16)
            {
                // generate a 128-bit salt using a secure PRNG
                salt = new byte[128 / 8];
                using (var rng = RandomNumberGenerator.Create())
                {
                    rng.GetBytes(salt);
                }
            }

            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            if (needsOnlyHash)
                return hashed;
            // password will be concatenated with salt using ':'
            return $"{hashed}:{Convert.ToBase64String(salt)}";
        }
        private bool VerifyPassword(string hashedPasswordWithSalt, string passwordToCheck)
        {
            // retrieve both salt and password from 'hashedPasswordWithSalt'
            var passwordAndHash = hashedPasswordWithSalt.Split(':');
            if (passwordAndHash == null || passwordAndHash.Length != 2)
                return false;
            var salt = Convert.FromBase64String(passwordAndHash[1]);
            if (salt == null)
                return false;
            // hash the given password
            var hashOfpasswordToCheck = HashPassword(passwordToCheck, salt, true);
            // compare both hashes
            if (String.Compare(passwordAndHash[0], hashOfpasswordToCheck) == 0)
            {
                return true;
            }
            return false;
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            string oldPw = TxtOldPassword.Text.Trim();
            string newPw = TxtNewPassword.Text.Trim();
            string repeatNewPw = TxtConfirmNewPassword.Text.Trim();

            if (oldPw == "" || newPw == "" || repeatNewPw == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Thất thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidationUtil.IsValidPassword(TxtNewPassword.Text))
            {
                MessageBox.Show("Mật khẩu phải bao gồm: chữ in hoa, số và ít nhất 8 ký tự", "Sai định dạng mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (TxtNewPassword.Text != TxtConfirmNewPassword.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không chính xác", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (AuthBLL.ChangePassword(TxtOldPassword.Text, TxtNewPassword.Text))
            {
                MessageBox.Show("Mật khẩu của bạn đã được đổi. Vui lòng đăng nhập lại", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm.SignOutInstance.PerformClick();
            }
            else
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtOldPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                e.Handled = true;
                TxtNewPassword.Focus();
            }
        }

        private void TxtNewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                e.Handled = true;
                TxtConfirmNewPassword.Focus();
            }
        }

        private void TxtConfirmNewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                e.Handled = true;
                BtnConfirm.PerformClick();
            }
        }
    }
}
