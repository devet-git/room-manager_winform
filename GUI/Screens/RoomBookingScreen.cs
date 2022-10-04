using BLL;
using DAL;
using GUI.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Screens
{
    public partial class RoomBookingScreen : Form
    {
        private int BookingAmount = 0;
        private DateTime CurrentDate = DateTime.Now.Date;
        public RoomBookingScreen()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void RoomScreen_Load(object sender, EventArgs e)
        {
            PanelRoomInfo.Hide();
            //DPickerSelect.Value = CurrentDate;
            DPickerSelect.MinDate = CurrentDate;
            DPickerSelect.MaxDate = CurrentDate.AddMonths(6);
            DPickerCheckin.MinDate = CurrentDate;
            // DPickerCheckout.MinDate = DateTime.Now.AddDays(1);

            /*Thread newThread = new Thread(LoadRooms);
            newThread.IsBackground = true;
            newThread.Start();*/
        }
        private void RoomBookingScreen_Shown(object sender, EventArgs e)
        {
            LoadRooms();
        }
        private void LoadPaymentInfo()
        {
            PanelPaymentInfo.Visible = true;

            var chargeRoom = new RoomBLL().Get(RoomBLL.SelectingRoomId);

            string dayIn = RoomBLL.SelectingRoomStatus == 1 ? DPickerCheckin.Text : DPickerSelect.Text;
            string dayOut = DPickerCheckout.Text;
            string numofDayIn = GeneralUtil.CountDays(dayIn, dayOut).ToString();

            int quantity = int.Parse(TxtQuantity.Text);
            int surcharge = PaymentUtil.CalcSurcharge(chargeRoom.code, quantity);
            int total = PaymentUtil.CalcTotal(RoomBLL.SelectingRoomId, RoomBLL.SelectingRoomStatus == 1 ? DPickerCheckin.Value.Date : DPickerSelect.Value.Date, DPickerCheckout.Value.Date, quantity);
            this.BookingAmount = total;

            //TODO: show data to screen
            LbRoomRate.Text = "Giá phòng: " + GeneralUtil.DevisionUnit(chargeRoom.rate, ".");
            LbSurcharge.Text = "Phụ thu: " + GeneralUtil.DevisionUnit(surcharge, ".");
            LbDayStay.Text = "Số ngày ở: " + numofDayIn;
            LbTotalCost.Text = $"Tổng: ({chargeRoom.rate} + {surcharge}) x {numofDayIn} = " + GeneralUtil.DevisionUnit(total, ".");
        }
        private Color GenRoomStatusColor(int roomstatus)
        {
            var result = new Color();
            switch (roomstatus)
            {
                case 0:
                    result = Color.White;
                    break;
                case 1 :
                    result = Color.FromArgb(247, 207, 175);
                    break;
                default:
                    break;
            }
            return result;
        }
        private void ClearRoomsInScreen()
        {
            FLPanelSglRooms.Controls.Clear();
            FLPanelDblRooms.Controls.Clear();
            FLPanelTwnRooms.Controls.Clear();
            FLPanelTrplRooms.Controls.Clear();
            FLPanelQuadRooms.Controls.Clear();
        }
        private void RefreshForm()
        {
            this.Refresh();
            this.Invalidate();
            Application.DoEvents();
        }
        private void LoadRooms()
        {
            ClearRoomsInScreen();
           
            //TODO: save all room into list which purpose refresh room backColor
            List<Button> listRooms = new List<Button>();
            var allRooms = new RoomBLL().GetAll();
            foreach (var room in allRooms)
            {
                string roomCode = room.code;
                string roomType = room.type;
                string roomDescription = room.description;
                int roomRate = room.rate;
                int roomStatus = 0;

                // get  room booked information that in range of date
                booking bookingInfo = new BookingBLL().Get(roomCode, DPickerSelect);

                //If room is booked then room's status is 1
                if (bookingInfo != null)
                {
                    roomStatus = 1;
                }

                //TODO: Init new button for each room
                Button newRoomBtn = new Button
                {
                    Text = roomCode,
                    BackColor = GenRoomStatusColor(roomStatus),
                    Padding = new Padding(0, 3, 0, 3),
                    AutoSize = true,
                    Tag = roomStatus
                };
                
                listRooms.Add(newRoomBtn);
                
                //TODO: Add click event
                newRoomBtn.Click += (s, ev) => 
                {
                    //TODO: refresh all rooms backColor when click a specific room
                    foreach (var roomBtn in listRooms)
                    {
                        roomBtn.BackColor = GenRoomStatusColor((int)roomBtn.Tag);
                        roomBtn.ForeColor = Color.Black;
                    }
                    //TODO: get room info from room id
                    //string[] idInfo = roomCode.Split(new char[] { '.' }, StringSplitOptions.None); //ex: room id is 1.2 => return string array: [1, 2]
                    //string roomIntro = $"Phòng số {idInfo[1]}, lầu {idInfo[0]}";

                    LbRoomName.Text = $"Phòng {roomCode}";
                    LbRoomDescription.Text = roomDescription ?? "Đây là đoạn giới thiệu về phòng";
                    txtCustomerInfo.Text = "";
                    TxtQuantity.Text = RoomUtil.DefaultQuantity(roomType).ToString();
                    //TODO: save room state
                    RoomBLL.SelectingRoomId = roomCode;
                    RoomBLL.SelectingRoomStatus = roomStatus;
                    
                    newRoomBtn.BackColor = Color.FromArgb(239, 152, 76);
                    newRoomBtn.ForeColor = Color.White;

                    DPickerCheckout.MinDate = DateTime.Now.Date;//reset range date
                    //TODO: set what thing will show depend room's status
                    if (roomStatus == 0)
                    {
                        BtnBookRoom.Tag = roomStatus;
                        PanelPaymentInfo.Visible = false;
                       
                        BtnCancelBooking.Visible = false;
                        BtnCheckout.Visible = false;
                        BtnBookRoom.Visible = true;
                        BtnUpdateBookingInfo.Visible = false;

                        DPickerCheckin.Enabled = false;
                        DPickerCheckin.Value = DPickerSelect.Value;
                        DPickerCheckout.MinDate = DPickerSelect.Value.Date.AddDays(1);
                        PanelRoomInfo.Show();
                    }
                    else
                    {
                        RoomBLL.BookingId = bookingInfo.id;
                        DPickerCheckin.Enabled = true;
                        DateTime currentDate = DateTime.Now.Date;
                        if (DateTime.Now.Date > bookingInfo.checkin)
                            DPickerCheckin.Enabled = false;

                        BtnBookRoom.Visible = false;
                        if ( currentDate == bookingInfo.checkout)
                        {
                            BtnCheckout.Visible = true;
                        }
                        if (currentDate <= bookingInfo.checkin)
                        {
                            BtnCancelBooking.Visible = true;
                        }
                        BtnUpdateBookingInfo.Visible = true;

                        //TODO: show info about room booked
                        txtCustomerInfo.Text = bookingInfo.customer;

                        DPickerCheckin.MinDate = bookingInfo.checkin < DateTime.Now.Date ? bookingInfo.checkin : DateTime.Now.Date;
                        DPickerCheckin.Value = bookingInfo.checkin;

                        DPickerCheckout.Value = bookingInfo.checkout;
                        DPickerCheckout.MinDate = bookingInfo.checkin.AddDays(1);
                        TxtQuantity.Text = bookingInfo.quantity.ToString();
                        //ENDTODO: show info about room booked
                        PanelRoomInfo.Show();
                        LoadPaymentInfo();
                    }
                };

                if (roomCode == RoomBLL.SelectingRoomId)
                {
                    //newRoomBtn.BackColor = Color.LightPink;
                    newRoomBtn.PerformClick();
                }
                AddRoomToFlowLayout(roomType, newRoomBtn);
            }
        }
        private void AddRoomToFlowLayout(string type, Button room)
        {
            switch (type)
            {
                case "SGL":
                    FLPanelSglRooms.Controls.Add(room);
                    break;
                case "TWN":
                    FLPanelTwnRooms.Controls.Add(room);
                    break;
                case "DBL":
                    FLPanelDblRooms.Controls.Add(room);
                    break;
                case "TRPL":
                    FLPanelTrplRooms.Controls.Add(room);
                    break;
                case "QUAD":
                    FLPanelQuadRooms.Controls.Add(room);
                    break;
            }
        }
        private void BtnBookRoom_Click(object sender, EventArgs e)
        {
            if (!ValidationUtil.TxtNotEmpty(TxtQuantity, "Hãy nhập số lượng"))
                return;
            if (!ValidationUtil.TxtNumRanger(TxtQuantity, 1, 9, "Số phải khác 0"))
                return;
            if (!ValidationUtil.TxtNotEmpty(txtCustomerInfo, "Hãy nhập thông tin khách hàng"))
                return;
           
            bool IsSuccess = new BookingBLL().Insert(txtCustomerInfo, DPickerSelect, DPickerCheckout, TxtQuantity);
          
            if (IsSuccess)
            {
                MessageBox.Show("Đặt phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRooms();
                RefreshForm();
                //LoadPaymentInfo();
            }
            else
            {
                MessageBox.Show("Đặt phòng thất bại", "Lỗi của chúng tôi. Báo cho người quản trị để khắc phục", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            if (PaymentBLL.Insert(this.BookingAmount, RoomBLL.BookingId) && new BookingBLL().Checkout(RoomBLL.BookingId, DateTime.Now.Date))
            {
                MessageBox.Show("Trả phòng thành công", "Hoành thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshForm();
                LoadRooms();
            }
            else
            {
                MessageBox.Show("Lỗi của chúng tôi. Báo cho người quản trị để khắc phục", "Lỗi",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnUpdateBookingInfo_Click(object sender, EventArgs e)
        {
            
            bool isUpdateSuccess = new BookingBLL().Update(
               RoomBLL.BookingId,
               txtCustomerInfo,
               DPickerCheckin,
               DPickerCheckout,
               TxtQuantity
            );

            if (isUpdateSuccess)
            {
                MessageBox.Show("Cập nhật thông tin đặt phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRooms();
                LoadPaymentInfo();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại", "Lỗi của chúng tôi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCancelBooking_Click(object sender, EventArgs e)
        {
            bool acceptCancel = MessageBox.Show("Xác nhận hủy đặt phòng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
            if (!acceptCancel)
                return;
            if (new BookingBLL().Cancel(RoomBLL.BookingId))
            {
                MessageBox.Show("Hoàn tất hủy đặt phòng", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRooms();
                RefreshForm();
                return;
            }
            MessageBox.Show("Hủy đặt phòng thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void DPickerSelect_ValueChanged(object sender, EventArgs e)
        {
            txtCustomerInfo.Text = "";
            TxtQuantity.Text = "";
            LoadRooms();
            RefreshForm();
        }
        private void TxtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.TextboxOnlyNumber(sender, 1, e);
        }

        private void DPickerCheckin_ValueChanged(object sender, EventArgs e)
        {
            DPickerCheckout.MinDate = DPickerCheckin.Value.AddDays(1);
        }
    }
}
