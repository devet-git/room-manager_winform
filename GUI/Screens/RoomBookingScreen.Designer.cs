namespace GUI.Screens
{
    partial class RoomBookingScreen
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
            this.TLPanelTwoColumn = new System.Windows.Forms.TableLayoutPanel();
            this.TLPanelShowRooms = new System.Windows.Forms.TableLayoutPanel();
            this.GRBoxQuadRooms = new System.Windows.Forms.GroupBox();
            this.FLPanelQuadRooms = new System.Windows.Forms.FlowLayoutPanel();
            this.GRBoxTrplRooms = new System.Windows.Forms.GroupBox();
            this.FLPanelTrplRooms = new System.Windows.Forms.FlowLayoutPanel();
            this.GRBoxDblRooms = new System.Windows.Forms.GroupBox();
            this.FLPanelDblRooms = new System.Windows.Forms.FlowLayoutPanel();
            this.GRBoxTwnRooms = new System.Windows.Forms.GroupBox();
            this.FLPanelTwnRooms = new System.Windows.Forms.FlowLayoutPanel();
            this.GRBoxSglRooms = new System.Windows.Forms.GroupBox();
            this.FLPanelSglRooms = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelRoomInfo = new System.Windows.Forms.Panel();
            this.PanelPaymentInfo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelSpace = new System.Windows.Forms.Panel();
            this.LbTotalCost = new System.Windows.Forms.Label();
            this.LbDayStay = new System.Windows.Forms.Label();
            this.LbRoomRate = new System.Windows.Forms.Label();
            this.LbSurcharge = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCancelBooking = new System.Windows.Forms.Button();
            this.BtnCheckout = new System.Windows.Forms.Button();
            this.LbQuantity = new System.Windows.Forms.Label();
            this.BtnBookRoom = new System.Windows.Forms.Button();
            this.BtnUpdateBookingInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LbCheckinDate = new System.Windows.Forms.Label();
            this.txtCustomerInfo = new System.Windows.Forms.RichTextBox();
            this.DPickerCheckin = new System.Windows.Forms.DateTimePicker();
            this.DPickerCheckout = new System.Windows.Forms.DateTimePicker();
            this.LbCheckoutDate = new System.Windows.Forms.Label();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.LbRoomDescription = new System.Windows.Forms.Label();
            this.LbRoomName = new System.Windows.Forms.Label();
            this.DPickerSelect = new System.Windows.Forms.DateTimePicker();
            this.TLPanelTwoColumn.SuspendLayout();
            this.TLPanelShowRooms.SuspendLayout();
            this.GRBoxQuadRooms.SuspendLayout();
            this.GRBoxTrplRooms.SuspendLayout();
            this.GRBoxDblRooms.SuspendLayout();
            this.GRBoxTwnRooms.SuspendLayout();
            this.GRBoxSglRooms.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.PanelRoomInfo.SuspendLayout();
            this.PanelPaymentInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPanelTwoColumn
            // 
            this.TLPanelTwoColumn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TLPanelTwoColumn.ColumnCount = 2;
            this.TLPanelTwoColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPanelTwoColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPanelTwoColumn.Controls.Add(this.TLPanelShowRooms, 1, 0);
            this.TLPanelTwoColumn.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.TLPanelTwoColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPanelTwoColumn.Location = new System.Drawing.Point(0, 0);
            this.TLPanelTwoColumn.Name = "TLPanelTwoColumn";
            this.TLPanelTwoColumn.RowCount = 1;
            this.TLPanelTwoColumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPanelTwoColumn.Size = new System.Drawing.Size(1420, 686);
            this.TLPanelTwoColumn.TabIndex = 0;
            // 
            // TLPanelShowRooms
            // 
            this.TLPanelShowRooms.ColumnCount = 1;
            this.TLPanelShowRooms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPanelShowRooms.Controls.Add(this.GRBoxQuadRooms, 0, 4);
            this.TLPanelShowRooms.Controls.Add(this.GRBoxTrplRooms, 0, 3);
            this.TLPanelShowRooms.Controls.Add(this.GRBoxDblRooms, 0, 2);
            this.TLPanelShowRooms.Controls.Add(this.GRBoxTwnRooms, 0, 1);
            this.TLPanelShowRooms.Controls.Add(this.GRBoxSglRooms, 0, 0);
            this.TLPanelShowRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPanelShowRooms.Location = new System.Drawing.Point(713, 3);
            this.TLPanelShowRooms.Name = "TLPanelShowRooms";
            this.TLPanelShowRooms.RowCount = 5;
            this.TLPanelShowRooms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLPanelShowRooms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLPanelShowRooms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLPanelShowRooms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLPanelShowRooms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLPanelShowRooms.Size = new System.Drawing.Size(704, 680);
            this.TLPanelShowRooms.TabIndex = 0;
            // 
            // GRBoxQuadRooms
            // 
            this.GRBoxQuadRooms.Controls.Add(this.FLPanelQuadRooms);
            this.GRBoxQuadRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRBoxQuadRooms.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRBoxQuadRooms.Location = new System.Drawing.Point(0, 544);
            this.GRBoxQuadRooms.Margin = new System.Windows.Forms.Padding(0);
            this.GRBoxQuadRooms.Name = "GRBoxQuadRooms";
            this.GRBoxQuadRooms.Padding = new System.Windows.Forms.Padding(0);
            this.GRBoxQuadRooms.Size = new System.Drawing.Size(704, 136);
            this.GRBoxQuadRooms.TabIndex = 5;
            this.GRBoxQuadRooms.TabStop = false;
            this.GRBoxQuadRooms.Text = "Phòng bốn";
            // 
            // FLPanelQuadRooms
            // 
            this.FLPanelQuadRooms.BackColor = System.Drawing.Color.Transparent;
            this.FLPanelQuadRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPanelQuadRooms.Location = new System.Drawing.Point(0, 25);
            this.FLPanelQuadRooms.Margin = new System.Windows.Forms.Padding(0);
            this.FLPanelQuadRooms.Name = "FLPanelQuadRooms";
            this.FLPanelQuadRooms.Size = new System.Drawing.Size(704, 111);
            this.FLPanelQuadRooms.TabIndex = 0;
            // 
            // GRBoxTrplRooms
            // 
            this.GRBoxTrplRooms.Controls.Add(this.FLPanelTrplRooms);
            this.GRBoxTrplRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRBoxTrplRooms.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRBoxTrplRooms.Location = new System.Drawing.Point(0, 408);
            this.GRBoxTrplRooms.Margin = new System.Windows.Forms.Padding(0);
            this.GRBoxTrplRooms.Name = "GRBoxTrplRooms";
            this.GRBoxTrplRooms.Padding = new System.Windows.Forms.Padding(0);
            this.GRBoxTrplRooms.Size = new System.Drawing.Size(704, 136);
            this.GRBoxTrplRooms.TabIndex = 4;
            this.GRBoxTrplRooms.TabStop = false;
            this.GRBoxTrplRooms.Text = "Phòng ba";
            // 
            // FLPanelTrplRooms
            // 
            this.FLPanelTrplRooms.BackColor = System.Drawing.Color.Transparent;
            this.FLPanelTrplRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPanelTrplRooms.Location = new System.Drawing.Point(0, 25);
            this.FLPanelTrplRooms.Margin = new System.Windows.Forms.Padding(0);
            this.FLPanelTrplRooms.Name = "FLPanelTrplRooms";
            this.FLPanelTrplRooms.Size = new System.Drawing.Size(704, 111);
            this.FLPanelTrplRooms.TabIndex = 0;
            // 
            // GRBoxDblRooms
            // 
            this.GRBoxDblRooms.Controls.Add(this.FLPanelDblRooms);
            this.GRBoxDblRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRBoxDblRooms.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRBoxDblRooms.Location = new System.Drawing.Point(0, 272);
            this.GRBoxDblRooms.Margin = new System.Windows.Forms.Padding(0);
            this.GRBoxDblRooms.Name = "GRBoxDblRooms";
            this.GRBoxDblRooms.Padding = new System.Windows.Forms.Padding(0);
            this.GRBoxDblRooms.Size = new System.Drawing.Size(704, 136);
            this.GRBoxDblRooms.TabIndex = 3;
            this.GRBoxDblRooms.TabStop = false;
            this.GRBoxDblRooms.Text = "Phòng đôi";
            // 
            // FLPanelDblRooms
            // 
            this.FLPanelDblRooms.BackColor = System.Drawing.Color.Transparent;
            this.FLPanelDblRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPanelDblRooms.Location = new System.Drawing.Point(0, 25);
            this.FLPanelDblRooms.Margin = new System.Windows.Forms.Padding(0);
            this.FLPanelDblRooms.Name = "FLPanelDblRooms";
            this.FLPanelDblRooms.Size = new System.Drawing.Size(704, 111);
            this.FLPanelDblRooms.TabIndex = 0;
            // 
            // GRBoxTwnRooms
            // 
            this.GRBoxTwnRooms.Controls.Add(this.FLPanelTwnRooms);
            this.GRBoxTwnRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRBoxTwnRooms.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRBoxTwnRooms.Location = new System.Drawing.Point(0, 136);
            this.GRBoxTwnRooms.Margin = new System.Windows.Forms.Padding(0);
            this.GRBoxTwnRooms.Name = "GRBoxTwnRooms";
            this.GRBoxTwnRooms.Padding = new System.Windows.Forms.Padding(0);
            this.GRBoxTwnRooms.Size = new System.Drawing.Size(704, 136);
            this.GRBoxTwnRooms.TabIndex = 2;
            this.GRBoxTwnRooms.TabStop = false;
            this.GRBoxTwnRooms.Text = "Phòng cặp đôi";
            // 
            // FLPanelTwnRooms
            // 
            this.FLPanelTwnRooms.AutoScroll = true;
            this.FLPanelTwnRooms.BackColor = System.Drawing.Color.Transparent;
            this.FLPanelTwnRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPanelTwnRooms.Location = new System.Drawing.Point(0, 25);
            this.FLPanelTwnRooms.Margin = new System.Windows.Forms.Padding(0);
            this.FLPanelTwnRooms.Name = "FLPanelTwnRooms";
            this.FLPanelTwnRooms.Size = new System.Drawing.Size(704, 111);
            this.FLPanelTwnRooms.TabIndex = 0;
            // 
            // GRBoxSglRooms
            // 
            this.GRBoxSglRooms.Controls.Add(this.FLPanelSglRooms);
            this.GRBoxSglRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRBoxSglRooms.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRBoxSglRooms.Location = new System.Drawing.Point(0, 0);
            this.GRBoxSglRooms.Margin = new System.Windows.Forms.Padding(0);
            this.GRBoxSglRooms.Name = "GRBoxSglRooms";
            this.GRBoxSglRooms.Padding = new System.Windows.Forms.Padding(0);
            this.GRBoxSglRooms.Size = new System.Drawing.Size(704, 136);
            this.GRBoxSglRooms.TabIndex = 1;
            this.GRBoxSglRooms.TabStop = false;
            this.GRBoxSglRooms.Text = "Phòng đơn";
            // 
            // FLPanelSglRooms
            // 
            this.FLPanelSglRooms.AutoScroll = true;
            this.FLPanelSglRooms.BackColor = System.Drawing.Color.Transparent;
            this.FLPanelSglRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPanelSglRooms.Location = new System.Drawing.Point(0, 25);
            this.FLPanelSglRooms.Margin = new System.Windows.Forms.Padding(0);
            this.FLPanelSglRooms.Name = "FLPanelSglRooms";
            this.FLPanelSglRooms.Size = new System.Drawing.Size(704, 111);
            this.FLPanelSglRooms.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.PanelRoomInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DPickerSelect, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(704, 680);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PanelRoomInfo
            // 
            this.PanelRoomInfo.AutoScroll = true;
            this.PanelRoomInfo.BackColor = System.Drawing.Color.Transparent;
            this.PanelRoomInfo.Controls.Add(this.PanelPaymentInfo);
            this.PanelRoomInfo.Controls.Add(this.panel1);
            this.PanelRoomInfo.Controls.Add(this.LbRoomDescription);
            this.PanelRoomInfo.Controls.Add(this.LbRoomName);
            this.PanelRoomInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRoomInfo.Location = new System.Drawing.Point(0, 54);
            this.PanelRoomInfo.Margin = new System.Windows.Forms.Padding(0);
            this.PanelRoomInfo.Name = "PanelRoomInfo";
            this.PanelRoomInfo.Padding = new System.Windows.Forms.Padding(10);
            this.PanelRoomInfo.Size = new System.Drawing.Size(704, 626);
            this.PanelRoomInfo.TabIndex = 1;
            this.PanelRoomInfo.Visible = false;
            // 
            // PanelPaymentInfo
            // 
            this.PanelPaymentInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(208)))));
            this.PanelPaymentInfo.Controls.Add(this.label2);
            this.PanelPaymentInfo.Controls.Add(this.PanelSpace);
            this.PanelPaymentInfo.Controls.Add(this.LbTotalCost);
            this.PanelPaymentInfo.Controls.Add(this.LbDayStay);
            this.PanelPaymentInfo.Controls.Add(this.LbRoomRate);
            this.PanelPaymentInfo.Controls.Add(this.LbSurcharge);
            this.PanelPaymentInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelPaymentInfo.Location = new System.Drawing.Point(10, 573);
            this.PanelPaymentInfo.Name = "PanelPaymentInfo";
            this.PanelPaymentInfo.Size = new System.Drawing.Size(663, 301);
            this.PanelPaymentInfo.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Verdana", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 14);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(7, 10, 0, 0);
            this.label2.Size = new System.Drawing.Size(201, 44);
            this.label2.TabIndex = 21;
            this.label2.Text = "Thanh toán";
            // 
            // PanelSpace
            // 
            this.PanelSpace.BackColor = System.Drawing.Color.OldLace;
            this.PanelSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSpace.Location = new System.Drawing.Point(0, 0);
            this.PanelSpace.Name = "PanelSpace";
            this.PanelSpace.Size = new System.Drawing.Size(663, 14);
            this.PanelSpace.TabIndex = 20;
            // 
            // LbTotalCost
            // 
            this.LbTotalCost.AllowDrop = true;
            this.LbTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbTotalCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(218)))));
            this.LbTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbTotalCost.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotalCost.Location = new System.Drawing.Point(21, 185);
            this.LbTotalCost.Name = "LbTotalCost";
            this.LbTotalCost.Size = new System.Drawing.Size(624, 86);
            this.LbTotalCost.TabIndex = 14;
            this.LbTotalCost.Text = "Tổng tiền";
            this.LbTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbDayStay
            // 
            this.LbDayStay.AutoSize = true;
            this.LbDayStay.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDayStay.Location = new System.Drawing.Point(21, 137);
            this.LbDayStay.Name = "LbDayStay";
            this.LbDayStay.Size = new System.Drawing.Size(113, 25);
            this.LbDayStay.TabIndex = 17;
            this.LbDayStay.Text = "Số ngày ở";
            // 
            // LbRoomRate
            // 
            this.LbRoomRate.AutoSize = true;
            this.LbRoomRate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRoomRate.Location = new System.Drawing.Point(21, 82);
            this.LbRoomRate.Name = "LbRoomRate";
            this.LbRoomRate.Size = new System.Drawing.Size(115, 25);
            this.LbRoomRate.TabIndex = 15;
            this.LbRoomRate.Text = "Giá phòng";
            // 
            // LbSurcharge
            // 
            this.LbSurcharge.AutoSize = true;
            this.LbSurcharge.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSurcharge.Location = new System.Drawing.Point(328, 82);
            this.LbSurcharge.Name = "LbSurcharge";
            this.LbSurcharge.Size = new System.Drawing.Size(91, 25);
            this.LbSurcharge.TabIndex = 16;
            this.LbSurcharge.Text = "Phụ thu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(209)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.BtnCancelBooking);
            this.panel1.Controls.Add(this.BtnCheckout);
            this.panel1.Controls.Add(this.LbQuantity);
            this.panel1.Controls.Add(this.BtnBookRoom);
            this.panel1.Controls.Add(this.BtnUpdateBookingInfo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LbCheckinDate);
            this.panel1.Controls.Add(this.txtCustomerInfo);
            this.panel1.Controls.Add(this.DPickerCheckin);
            this.panel1.Controls.Add(this.DPickerCheckout);
            this.panel1.Controls.Add(this.LbCheckoutDate);
            this.panel1.Controls.Add(this.TxtQuantity);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 417);
            this.panel1.TabIndex = 20;
            // 
            // BtnCancelBooking
            // 
            this.BtnCancelBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelBooking.AutoSize = true;
            this.BtnCancelBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.BtnCancelBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelBooking.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelBooking.ForeColor = System.Drawing.Color.White;
            this.BtnCancelBooking.Location = new System.Drawing.Point(440, 308);
            this.BtnCancelBooking.Name = "BtnCancelBooking";
            this.BtnCancelBooking.Size = new System.Drawing.Size(205, 67);
            this.BtnCancelBooking.TabIndex = 18;
            this.BtnCancelBooking.Text = "Hủy đặt";
            this.BtnCancelBooking.UseVisualStyleBackColor = false;
            this.BtnCancelBooking.Visible = false;
            this.BtnCancelBooking.Click += new System.EventHandler(this.BtnCancelBooking_Click);
            // 
            // BtnCheckout
            // 
            this.BtnCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCheckout.AutoSize = true;
            this.BtnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.BtnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCheckout.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheckout.ForeColor = System.Drawing.Color.White;
            this.BtnCheckout.Location = new System.Drawing.Point(440, 308);
            this.BtnCheckout.Name = "BtnCheckout";
            this.BtnCheckout.Size = new System.Drawing.Size(205, 67);
            this.BtnCheckout.TabIndex = 4;
            this.BtnCheckout.Text = "Trả phòng";
            this.BtnCheckout.UseVisualStyleBackColor = false;
            this.BtnCheckout.Visible = false;
            this.BtnCheckout.Click += new System.EventHandler(this.BtnCheckout_Click);
            // 
            // LbQuantity
            // 
            this.LbQuantity.AutoSize = true;
            this.LbQuantity.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbQuantity.Location = new System.Drawing.Point(172, 192);
            this.LbQuantity.Name = "LbQuantity";
            this.LbQuantity.Size = new System.Drawing.Size(85, 20);
            this.LbQuantity.TabIndex = 14;
            this.LbQuantity.Text = "Số lượng";
            // 
            // BtnBookRoom
            // 
            this.BtnBookRoom.AutoSize = true;
            this.BtnBookRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(184)))), ((int)(((byte)(147)))));
            this.BtnBookRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBookRoom.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBookRoom.ForeColor = System.Drawing.Color.White;
            this.BtnBookRoom.Location = new System.Drawing.Point(26, 308);
            this.BtnBookRoom.Name = "BtnBookRoom";
            this.BtnBookRoom.Size = new System.Drawing.Size(274, 67);
            this.BtnBookRoom.TabIndex = 3;
            this.BtnBookRoom.Text = "Đặt phòng";
            this.BtnBookRoom.UseVisualStyleBackColor = false;
            this.BtnBookRoom.Click += new System.EventHandler(this.BtnBookRoom_Click);
            // 
            // BtnUpdateBookingInfo
            // 
            this.BtnUpdateBookingInfo.AutoSize = true;
            this.BtnUpdateBookingInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(184)))), ((int)(((byte)(147)))));
            this.BtnUpdateBookingInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateBookingInfo.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateBookingInfo.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateBookingInfo.Location = new System.Drawing.Point(26, 308);
            this.BtnUpdateBookingInfo.Name = "BtnUpdateBookingInfo";
            this.BtnUpdateBookingInfo.Size = new System.Drawing.Size(274, 67);
            this.BtnUpdateBookingInfo.TabIndex = 5;
            this.BtnUpdateBookingInfo.Text = "Cập nhật";
            this.BtnUpdateBookingInfo.UseVisualStyleBackColor = false;
            this.BtnUpdateBookingInfo.Click += new System.EventHandler(this.BtnUpdateBookingInfo_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Thông tin khách hàng";
            // 
            // LbCheckinDate
            // 
            this.LbCheckinDate.AutoSize = true;
            this.LbCheckinDate.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCheckinDate.Location = new System.Drawing.Point(166, 41);
            this.LbCheckinDate.Name = "LbCheckinDate";
            this.LbCheckinDate.Size = new System.Drawing.Size(91, 20);
            this.LbCheckinDate.TabIndex = 17;
            this.LbCheckinDate.Text = "Ngày đến";
            // 
            // txtCustomerInfo
            // 
            this.txtCustomerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerInfo.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerInfo.Location = new System.Drawing.Point(283, 72);
            this.txtCustomerInfo.Name = "txtCustomerInfo";
            this.txtCustomerInfo.Size = new System.Drawing.Size(362, 175);
            this.txtCustomerInfo.TabIndex = 3;
            this.txtCustomerInfo.Text = "";
            // 
            // DPickerCheckin
            // 
            this.DPickerCheckin.CalendarFont = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPickerCheckin.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPickerCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPickerCheckin.Location = new System.Drawing.Point(26, 72);
            this.DPickerCheckin.Name = "DPickerCheckin";
            this.DPickerCheckin.Size = new System.Drawing.Size(231, 34);
            this.DPickerCheckin.TabIndex = 2;
            this.DPickerCheckin.ValueChanged += new System.EventHandler(this.DPickerCheckin_ValueChanged);
            // 
            // DPickerCheckout
            // 
            this.DPickerCheckout.CalendarFont = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPickerCheckout.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPickerCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPickerCheckout.Location = new System.Drawing.Point(26, 138);
            this.DPickerCheckout.Name = "DPickerCheckout";
            this.DPickerCheckout.Size = new System.Drawing.Size(231, 34);
            this.DPickerCheckout.TabIndex = 2;
            // 
            // LbCheckoutDate
            // 
            this.LbCheckoutDate.AutoSize = true;
            this.LbCheckoutDate.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCheckoutDate.Location = new System.Drawing.Point(182, 115);
            this.LbCheckoutDate.Name = "LbCheckoutDate";
            this.LbCheckoutDate.Size = new System.Drawing.Size(75, 20);
            this.LbCheckoutDate.TabIndex = 9;
            this.LbCheckoutDate.Text = "Ngày đi";
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuantity.Location = new System.Drawing.Point(26, 215);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(231, 32);
            this.TxtQuantity.TabIndex = 4;
            this.TxtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQuantity_KeyPress);
            // 
            // LbRoomDescription
            // 
            this.LbRoomDescription.AllowDrop = true;
            this.LbRoomDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbRoomDescription.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRoomDescription.Location = new System.Drawing.Point(10, 74);
            this.LbRoomDescription.Name = "LbRoomDescription";
            this.LbRoomDescription.Padding = new System.Windows.Forms.Padding(5);
            this.LbRoomDescription.Size = new System.Drawing.Size(663, 82);
            this.LbRoomDescription.TabIndex = 5;
            this.LbRoomDescription.Text = "anh cho em mùa xuân nụ hoa vàng mới nở chiều dông nào nhung nhớ";
            // 
            // LbRoomName
            // 
            this.LbRoomName.AllowDrop = true;
            this.LbRoomName.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbRoomName.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRoomName.Location = new System.Drawing.Point(10, 10);
            this.LbRoomName.Name = "LbRoomName";
            this.LbRoomName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LbRoomName.Size = new System.Drawing.Size(663, 64);
            this.LbRoomName.TabIndex = 0;
            this.LbRoomName.Text = "Phòng ";
            // 
            // DPickerSelect
            // 
            this.DPickerSelect.CalendarFont = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPickerSelect.CalendarMonthBackground = System.Drawing.SystemColors.Highlight;
            this.DPickerSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.DPickerSelect.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DPickerSelect.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPickerSelect.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPickerSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DPickerSelect.Location = new System.Drawing.Point(3, 3);
            this.DPickerSelect.Name = "DPickerSelect";
            this.DPickerSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DPickerSelect.Size = new System.Drawing.Size(698, 35);
            this.DPickerSelect.TabIndex = 1;
            this.DPickerSelect.Value = new System.DateTime(2022, 8, 28, 16, 30, 3, 0);
            this.DPickerSelect.ValueChanged += new System.EventHandler(this.DPickerSelect_ValueChanged);
            // 
            // RoomBookingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1420, 686);
            this.Controls.Add(this.TLPanelTwoColumn);
            this.Name = "RoomBookingScreen";
            this.Text = "RoomScreen";
            this.Load += new System.EventHandler(this.RoomScreen_Load);
            this.Shown += new System.EventHandler(this.RoomBookingScreen_Shown);
            this.TLPanelTwoColumn.ResumeLayout(false);
            this.TLPanelShowRooms.ResumeLayout(false);
            this.GRBoxQuadRooms.ResumeLayout(false);
            this.GRBoxTrplRooms.ResumeLayout(false);
            this.GRBoxDblRooms.ResumeLayout(false);
            this.GRBoxTwnRooms.ResumeLayout(false);
            this.GRBoxSglRooms.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PanelRoomInfo.ResumeLayout(false);
            this.PanelPaymentInfo.ResumeLayout(false);
            this.PanelPaymentInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPanelTwoColumn;
        private System.Windows.Forms.FlowLayoutPanel FLPanelSglRooms;
        private System.Windows.Forms.Panel PanelRoomInfo;
        private System.Windows.Forms.Label LbRoomName;
        private System.Windows.Forms.Label LbRoomDescription;
        private System.Windows.Forms.Button BtnCheckout;
        private System.Windows.Forms.Button BtnBookRoom;
        private System.Windows.Forms.DateTimePicker DPickerSelect;
        private System.Windows.Forms.Label LbCheckoutDate;
        private System.Windows.Forms.DateTimePicker DPickerCheckout;
        private System.Windows.Forms.TableLayoutPanel TLPanelShowRooms;
        private System.Windows.Forms.GroupBox GRBoxSglRooms;
        private System.Windows.Forms.GroupBox GRBoxTrplRooms;
        private System.Windows.Forms.FlowLayoutPanel FLPanelTrplRooms;
        private System.Windows.Forms.GroupBox GRBoxDblRooms;
        private System.Windows.Forms.FlowLayoutPanel FLPanelDblRooms;
        private System.Windows.Forms.GroupBox GRBoxTwnRooms;
        private System.Windows.Forms.FlowLayoutPanel FLPanelTwnRooms;
        private System.Windows.Forms.GroupBox GRBoxQuadRooms;
        private System.Windows.Forms.FlowLayoutPanel FLPanelQuadRooms;
        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.RichTextBox txtCustomerInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbQuantity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnUpdateBookingInfo;
        private System.Windows.Forms.Label LbCheckinDate;
        private System.Windows.Forms.DateTimePicker DPickerCheckin;
        private System.Windows.Forms.Label LbTotalCost;
        private System.Windows.Forms.Label LbDayStay;
        private System.Windows.Forms.Label LbSurcharge;
        private System.Windows.Forms.Label LbRoomRate;
        private System.Windows.Forms.Panel PanelPaymentInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelSpace;
        private System.Windows.Forms.Button BtnCancelBooking;
        private System.Windows.Forms.Panel panel1;
    }
}