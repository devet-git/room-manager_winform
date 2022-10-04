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
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI.Screens.Admin
{
    public partial class RoomAdminScreen : Form
    {
        private readonly HotelManagerDataContext DB = new HotelManagerDataContext();

        public RoomAdminScreen()
        {
            InitializeComponent();
        }
        private void RoomAdminScreen_Load(object sender, EventArgs e)
        {
            this.codesTableAdapter.Fill(this.hotel_managerDataSet1.codes);
            //this.roomsTableAdapter.Fill(this.hotel_managerDataSet.rooms);
            DgvRooms.DataSource = DB.rooms;
            Utils.SetStyleDgv(DgvRooms);
        }
       
        private void BtnSaveChange_Click(object sender, EventArgs e)
        {  
            string newCode = "";
            int newRate = 0;
            int newSurcharge = 0;
            string newType = "";
            string newDes = "";
            room hasRoom;
            foreach (DataGridViewRow dRow in DgvRooms.Rows)
            {
                if (dRow.IsNewRow)
                    continue;
                newCode = dRow.Cells[1].Value as string;
                newRate = (int)dRow.Cells[2].Value;
                newSurcharge = (int)dRow.Cells[3].Value;
                newType = dRow.Cells[4].Value as string;
                newDes = dRow.Cells[5].Value as string;
                hasRoom = DB.rooms.Where(r => r.code == newCode).FirstOrDefault();

                if (hasRoom != null) //Update data
                {
                    hasRoom.code = newCode;
                    hasRoom.rate = newRate;
                    hasRoom.surcharge = newSurcharge;
                    hasRoom.type = newType;
                    hasRoom.description = newDes;
                }
                else //TODO: insert data to DB
                {
                    room newRoom = new room
                    {
                        code = newCode,
                        rate = newRate,
                        surcharge = newSurcharge,
                        type = newType,
                        description = newDes
                    };
                    DB.rooms.InsertOnSubmit(newRoom);
                }
                try
                {
                    DB.SubmitChanges();
                }
                catch
                {
                    MessageBox.Show("Hãy kiểm tra lại thông tin vừa nhập","Lỗi rồi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    BtnSaveChange.Enabled = false;
                    return;
                }
            }
            //TODO: do code below if all process was success
            MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BtnSaveChange.Enabled = false;
        }
        private void BtnDelRow_Click(object sender, EventArgs e)
        {
            bool isAcceptDel = MessageBox.Show("Xác nhận xóa các dòng??", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;

            if(!isAcceptDel)
                return;
         
            foreach (DataGridViewRow selectedRow in DgvRooms.SelectedRows)
            {
                //TODO: get id of room and delete in database
                string code = selectedRow.Cells[1].Value as string;
                room delRoom = DB.rooms.Where(r => r.code == code).FirstOrDefault();
                if (delRoom != null)
                {
                    DB.rooms.DeleteOnSubmit(delRoom);
                    DB.SubmitChanges();
                    DgvRooms.Rows.RemoveAt(selectedRow.Index);
                }
            }
            BtnDelRow.Enabled = false;
        }
        private void DgvRooms_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected)
                BtnDelRow.Enabled = false;
            else
                BtnDelRow.Enabled = true;
        }
        private void DgvRooms_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            BtnSaveChange.Enabled = true;
        }
    }
}
