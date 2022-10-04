using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Utilities
{
    static class ValidationUtil
    {
        public static bool TxtNotEmpty(TextBox sender, string message)
        {
            if (sender.Text == "" || sender.Text.Trim() == "")
            {
                MessageBox.Show(message, "Chú ý", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public static bool TxtNotEmpty(RichTextBox sender, string message)
        {
            if (sender.Text == "" || sender.Text.Trim() == "")
            {
                MessageBox.Show(message, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public static bool TxtNumRanger(TextBox sender, int minVal, int maxVal, string message = "")
        {
            if (message == "")
                message = $"Number must be between {minVal} and {maxVal}";
            if (int.Parse(sender.Text) >= minVal && int.Parse(sender.Text) <= maxVal)
            {
                return true;
            }
            MessageBox.Show(message, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        public static bool IsValidPassword(string password)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            bool isValidated = hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && hasMinimum8Chars.IsMatch(password);
            return isValidated;
        }
    }
}
