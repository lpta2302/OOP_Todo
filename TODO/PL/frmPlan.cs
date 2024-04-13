using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static TODO.PL.frmPlan;

namespace TODO.PL
{
    public partial class frmPlan : Form
    {
        #region Properties
        private List<List<Button>> daybox;
        public List<List<Button>> Daybox
        {
            get { return daybox; }
            set { daybox = value; }
        }
        private List<string> dateOfWeek = new List<string>() { "Mon", "Tue", "Wed", "Thu", "Fri", "Sar", "Sun" };
        #endregion

        public frmPlan()
        {
            InitializeComponent();
            LoadDayBox();
        }

        public class Conss
        {
            public static int DayOfRows = 7;
            public static int DayOfColumn = 5;
            public static int DayButtonWidth = 118;
            public static int DayButtonHeight = 64;
            public static int margin = 6;
        }

        void LoadDayBox()
        {
            daybox = new List<List<Button>>();
            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Conss.margin, 0) };
            for (int i = 0; i < Conss.DayOfColumn; i++)
            {
                daybox.Add(new List<Button>());
                for (int j = 0; j < Conss.DayOfRows; j++)
                {
                    Button btn = new Button() { Width = Conss.DayButtonWidth, Height = Conss.DayButtonHeight };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Conss.margin, oldBtn.Location.Y);
                    pnlDayBox.Controls.Add(btn);
                    daybox[i].Add(btn);
                    oldBtn = btn;
                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Conss.margin, oldBtn.Location.Y + Conss.DayButtonHeight) };
            }
            SetDefaultDate();
        }

        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30; ;
            }
        }

        void AddNumberIntoDayBox(DateTime date)
        {
            ClearDayBox();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            int line = 0;

            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = Daybox[line][column];
                btn.Text = i.ToString();

                if (isEqualDate(useDate, DateTime.Now))
                {
                    btn.BackColor = Color.GreenYellow;
                }

                if (isEqualDate(useDate, date))
                {
                    btn.BackColor = Color.Aqua;
                }

                if (column >= 6)
                    line++;

                useDate = useDate.AddDays(1);
            }
        }

        void SetDefaultDate()
        {
            dtpkDate.Value = DateTime.Now;
        }

        bool isEqualDate(DateTime date1, DateTime date2)
        {
            return date1.Year == date2.Year && date1.Month == date2.Month && date1.Day == date2.Day;
        }

        void ClearDayBox()
        {
            for (int i = 0; i < Daybox.Count; i++)
            {
                for (int j = 0; j < Daybox[i].Count; j++)
                {
                    Button btn = Daybox[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.White;
                }
            }
        }
        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoDayBox((sender as DateTimePicker).Value);
        }
        private void frmPlan_Load(object sender, EventArgs e)
        {
            LoadDayBox();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(-1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(1);
        }
    }
}
