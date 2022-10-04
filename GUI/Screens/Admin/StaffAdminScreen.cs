using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Screens.Admin
{
    public partial class StaffAdminScreen : Form
    {
        private readonly HotelManagerDataContext DB = new HotelManagerDataContext();

        public StaffAdminScreen()
        {
            InitializeComponent();
        }

        private void StaffManagementAdminScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_managerDataSet.users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.hotel_managerDataSet.users);
            DgvStaffs.DataSource = DB.users.Where(u => u.role == "STA");
            BtnSaveChange.Enabled = false;
            ConfigDgvStaffs();
        }
        private void ConfigDgvStaffs()
        {
            Utils.SetStyleDgv(DgvStaffs);
            //TODO: change column name
            //DgvRooms.Columns[0].HeaderText = "Phòng số";
            DgvStaffs.Columns[0].Visible = false;

            DgvStaffs.Columns[1].HeaderText = "Họ tên";

            DgvStaffs.Columns[2].HeaderText = "Số điện thoại";

            DgvStaffs.Columns[3].HeaderText = "Mật khẩu";

            DgvStaffs.Columns[4].Visible = false;
            
            DgvStaffs.Columns[5].HeaderText = "Ngày vào làm";
            DgvStaffs.Columns[5].ReadOnly = true;
        }

        private void BtnSaveChange_Click(object sender, EventArgs e)
        {
            bool isSuccess = true;
            foreach (DataGridViewRow dRow in DgvStaffs.Rows)
            {
                if (dRow.IsNewRow)
                    continue;
                //var id = int.Parse(dRow.Cells[0].Value as string);
                string newFullName = dRow.Cells[1].Value as string;
                string newPhone = dRow.Cells[2].Value as string;
                string newPassword = dRow.Cells[3].Value as string;
                string role = dRow.Cells[4].Value as string;


                user hasStaff = DB.users.Where(r => r.phone == newPhone).FirstOrDefault();
                if (hasStaff != null) //Update data
                {
                    hasStaff.phone = newPhone;
                    hasStaff.fullname = newFullName;
                    hasStaff.password = newPassword;
                }
                else //TODO: insert data to DB
                {
                   
                    user newStaff = new user
                    {
                        fullname = newFullName,
                        phone = newPhone,
                        password = newPassword,
                        role = role,
                        date_created = DateTime.Now,
                    };
                    try
                    {
                        DB.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi rồi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isSuccess = false;
                    }
                    DB.users.InsertOnSubmit(newStaff);
                }
                DB.SubmitChanges();
            }
            if (isSuccess)
            {
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnSaveChange.Enabled = false;
            }
        }

        private void BtnDelRow_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow selectedRow in DgvStaffs.SelectedRows)
                {
                    //TODO: get id of room and delete in database
                    string phone = selectedRow.Cells[2].Value as string;
                    user delStaff = DB.users.Where(r => r.phone == phone).FirstOrDefault();
                    if (delStaff != null)
                    {
                        DB.users.DeleteOnSubmit(delStaff);
                        DB.SubmitChanges();
                    }
                    //TODO: delete row in DataGridview
                    DgvStaffs.Rows.RemoveAt(selectedRow.Index);
                }
                BtnDelRow.Enabled = false;
            }
        }
        //TODO: set default value for Column in DataGridView
        private void DgvStaffs_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["role"].Value = "STA";
            e.Row.Cells["date_created"].Value = DateTime.Now.Date;

        }

        private void DgvStaffs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            BtnSaveChange.Enabled = true;
        }

        private void DgvStaffs_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected)
                BtnDelRow.Enabled = false;
            else
                BtnDelRow.Enabled = true;
        }
    }
}
