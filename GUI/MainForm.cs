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
using BLL;
using GUI.Screens.Account;

namespace GUI
{
    public partial class MainForm : Form
    {
        private Form CurrenScreen;
        private Button CurrentButton;
        private Button PreButton =  new Button();
        bool BtnAccountMenuStatus = false;
        public static Form MainFormInstance;
        public static Button SignOutInstance;
        public MainForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1300, 600);
            MainFormInstance = this;
            SignOutInstance = BtnSignOut;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //TODO: set menu backgr color same panel show screen
            panelShowScreens.BackColor = panelMenu.BackColor;
            Authorization();
        }
        private void Authorization()
        {
            
            if (AuthBLL.IsSignIn) //If user is logged in
            {
                BtnAccountMenu.Text = " " + AuthBLL.UserFullname;
                if (AuthBLL.UserRole == "STA")
                {
                    //BtnStatistics.Enabled = false;
                    BtnRoomAdmin.Enabled = false;
                    BtnStaffAdmin.Enabled = false;
                    BtnRoomBooking.PerformClick();
                }
                else
                {
                    BtnStatistics.PerformClick();
                }
            }
            else
            {
                //BtnRoomBooking.PerformClick();
                new SignInScreen().ShowDialog();
            }
        }
        private void SetBtnActive(object sender)
        {
            if (sender != null && CurrentButton != (Button)sender)
            {
                //TODO: Set style for current button
                CurrentButton = (Button)sender;
                CurrentButton.BackColor = CurrenScreen.BackColor;
                CurrentButton.Enabled = false;

                //TODO: Set style for previous button
                PreButton.BackColor = Color.Transparent;
                PreButton.Enabled = true;
                PreButton = (Button)sender;
            }
        }
        private void ShowScreen(Form screen, object sender)
        {
            if (CurrenScreen != null) CurrenScreen.Close();
            CurrenScreen = screen;

            SetBtnActive(sender);

            screen.TopLevel = false;
            screen.FormBorderStyle = FormBorderStyle.None;
            screen.Dock = DockStyle.Fill;

            // Add form to panel
            this.panelShowScreens.Controls.Add(CurrenScreen);
            this.panelShowScreens.Tag = CurrenScreen;

            screen.BringToFront();
            screen.Show();
        }
        private void BtnRoomBooking_Click(object sender, EventArgs e)
        {
            ShowScreen(new Screens.RoomBookingScreen(), sender);
        }
        private void BtnStatistics_Click(object sender, EventArgs e)
        {
            ShowScreen(new Screens.StatisticScreen(), sender);
        }
        private void BtnAccountMenu_Click(object sender, EventArgs e)
        {
            if (!BtnAccountMenuStatus)
            {
                panelAccountMenu.Show();
                BtnAccountMenu.BackColor = Color.OldLace;
            }
            else
            {
                panelAccountMenu.Hide();
                BtnAccountMenu.BackColor = Color.Transparent;
            }
            BtnAccountMenuStatus = !BtnAccountMenuStatus;
        }
        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            new SignInScreen().ShowDialog();
            AuthBLL.IsSignIn = false;
        }
        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            Utils.AddFormToPanel(new Screens.Account.ChangerPasswordScreen(), panelShowScreens);
            PreButton.Enabled = true;
            PreButton.BackColor = Color.Transparent;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (MessageBox.Show("Bạn chắc chắn muốn thoát phần mềm ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No);
        }
        private void BtnRoomAdmin_Click(object sender, EventArgs e)
        {
            ShowScreen(new Screens.Admin.RoomAdminScreen(), sender);
        }
        private void BtnStaffAdmin_Click(object sender, EventArgs e)
        {
            ShowScreen(new Screens.Admin.StaffAdminScreen(), sender);
        }

    }
}
