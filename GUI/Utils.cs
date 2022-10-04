using BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    static class Utils
    {
        static public void AddFormToPanel(Form FormName, Panel panelName)
        {
            FormName.TopLevel = false;
            FormName.FormBorderStyle = FormBorderStyle.None;
            FormName.Dock = DockStyle.Fill;

            // Add form to panel
            panelName.Controls.Add(FormName);
            panelName.Tag = FormName;

            FormName.BringToFront();
            FormName.Show();
        }
        static public void TextboxOnlyNumber(object sender,int maxLength, KeyPressEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            txtBox.MaxLength = maxLength;
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        static public void TextboxOnlyAlphabet(object sender, KeyPressEventArgs e)
        {
            //TextBox txtBox = sender as TextBox;
            e.Handled = char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        static public void SetStyleDgv(DataGridView dgvName)
        {
            //TODO: set font for all text
            dgvName.Font = new Font("Verdana", 12, GraphicsUnit.Point);
            //TODO: auto wrap text
            dgvName.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //TODO: auto resize row heigth follow text
            //dgvName.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            foreach (DataGridViewColumn col in dgvName.Columns)
            {
                //TODO: set each column to fit the width of the DataGridView
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //TODO: set font for all data row
                col.DefaultCellStyle.Font = new Font("Verdana", 10, GraphicsUnit.Point);
                
            }
            foreach (DataGridViewRow row in dgvName.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.Red;
            }
        }
        static public int CountDayFromDateRange(string fromDateString, string toDateString)
        {
            DateTime inDate = Convert.ToDateTime(fromDateString);
            DateTime outDate = Convert.ToDateTime(toDateString);
            int res = outDate.Subtract(inDate).Days;
            return res;
        }
            
    }
}
