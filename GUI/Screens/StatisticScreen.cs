using DAL;
using GUI.Utilities;
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

namespace GUI.Screens
{
    public partial class StatisticScreen : Form
    {
        private readonly HotelManagerDataContext DB = new HotelManagerDataContext();
        
        public StatisticScreen()
        {
            InitializeComponent();
        }

        private void StatisticScreen_Load(object sender, EventArgs e)
        {
            ConfigTurnoverChart();
            ConfigBookingChart();
            NumboxMonth.Minimum = 1;
            NumboxMonth.Maximum = 12;
            NumboxMonth.Value = 1;
            FillBookingChart((int)NumboxMonth.Value, (int)NumboxMonth.Value);
            FillTurnoverChart((int)NumboxMonth.Value);

        }

        private void ConfigTurnoverChart()
        {
            ChartTurnover.Titles.Add("Doanh thu các tháng");
            ChartTurnover.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            ChartTurnover.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            ChartTurnover.ChartAreas[0].AxisY.Title = "Đơn vị: VNĐ";
            ChartTurnover.ChartAreas[0].AxisX.Title = "Thời gian";
            ChartTurnover.Series["a"].IsVisibleInLegend = false;
            ChartTurnover.Series["a"].IsValueShownAsLabel = true;
        }

        private void ConfigBookingChart()
        {
            ChartBooking.Titles.Add(new Title
            {
                Font = new Font("Verdana", 17),
                Text = "Thống kê đặt phòng",
            });
            ChartBooking.Series["Canceled"].IsValueShownAsLabel = true;
            ChartBooking.Series["All"].IsValueShownAsLabel = true;
            ChartBooking.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
        }
        private void FillBookingChart(int numofMonthAgo, int numofNextMonth)
        {
            ChartBooking.Series["All"].Points.Clear();
            ChartBooking.Series["Canceled"].Points.Clear();

            for (int i = -numofMonthAgo; i <= numofNextMonth; i++)
            {
                var allBookings = DB.bookings.Where(bk => bk.checkin.Month == DateTime.Now.AddMonths(i).Month).Count();
                var canceledBookings = DB.bookings.Where(bk => bk.checkin.Month == DateTime.Now.AddMonths(i).Month && bk.status == "canceled").Count();

                ChartBooking.Series["All"].Points.AddXY(DateTime.Now.AddMonths(i).ToString("MM/yyyy"), allBookings);
                ChartBooking.Series["Canceled"].Points.AddXY(DateTime.Now.AddMonths(i).ToString("MM/yyyy"), canceledBookings);
            }
        }
        private void FillTurnoverChart(int numofMonthAgo)
        {
            ChartTurnover.Series["a"].Points.Clear();

            for (int i = -numofMonthAgo; i <= 0; i++)
            {
                var payments = DB.payments.Where(pm => pm.date.Month == DateTime.Now.AddMonths(i).Month).ToList();
                int totalInMonth = payments != null ? payments.Sum(x => x.amount) : 0;
                ChartTurnover.Series["a"].Points.AddXY(DateTime.Now.AddMonths(i).ToString("MM/yyyy"), totalInMonth);
            }
        }
        private void ChartTurnover_MouseMove(object sender, MouseEventArgs e)
        {
            var point = ChartTurnover.HitTest(e.X, e.Y);
            if (point.ChartElementType == ChartElementType.DataPoint)
                ChartTurnover.Series["a"].ToolTip = ChartTurnover.Series["a"].Points[point.PointIndex].AxisLabel.ToString();
        }

        private void BtnMonthAgo_Click(object sender, EventArgs e)
        {
            FillTurnoverChart((int)NumboxMonth.Value);
            FillBookingChart((int)NumboxMonth.Value, 0);

        }

        private void BtnNextMonth_Click(object sender, EventArgs e)
        {
            FillBookingChart(0, (int)NumboxMonth.Value);
        }

        private void BtnInMonth_Click(object sender, EventArgs e)
        {
            FillBookingChart((int)NumboxMonth.Value, (int)NumboxMonth.Value);
        }

        private void NumboxMonth_ValueChanged(object sender, EventArgs e)
        {
            BtnNextMonth.Text = $"{NumboxMonth.Value} tháng tới";
            BtnMonthAgo.Text = $"{NumboxMonth.Value} tháng trước";
            BtnInMonth.Text = $"Trong {NumboxMonth.Value} tháng";
        }
    }
}
