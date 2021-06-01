using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageRestaurent1._1
{
    public partial class mainForm : Form
    {
        private string username;
        public mainForm()
        {
            InitializeComponent();
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            setUpTimer();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changePasswordForm_1 changePassword = new changePasswordForm_1();
            changePassword.Show();  
        }



        private void manageEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formManageEmployee_1 formManage = new formManageEmployee_1();
            formManage.Show();
        }

        private void phanCaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            phanCaForm phanCa = new phanCaForm();
            phanCa.Show();
        }

        private void checkInoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkInAndOutForm_1 checkInAndOut = new checkInAndOutForm_1();
            checkInAndOut.Show();
        }

        private void luongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageSalaryForm luong = new manageSalaryForm();
            luong.Show();
        }

        private void quanLyCaLamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageShiftForm quanLiCaLam = new manageShiftForm();
            quanLiCaLam.Show();
        }

        private void timerAnnounceSalaryList_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            if (d.Hour == 22 && d.Minute == 05)
            {
                timerAnnounceSalaryList.Enabled = false;
                salaryListForm salaryList = new salaryListForm();
                salaryList.Show();
            }
            setUpTimer();
        }

        public void setUpTimer()
        {
            DateTime nowTime = DateTime.Now;
            DateTime runTime = new DateTime(nowTime.Year, nowTime.Month, nowTime.Day, 22, 05, 00);
            
            if (DateTime.Compare(nowTime, runTime) > 0)
            {
                runTime = runTime.AddDays(1);
            }
            TimeSpan t = runTime.Subtract(nowTime);
            int tickTime;
            if (t.Hours <= 4)
            {
                tickTime = (int)t.TotalMilliseconds;
                timerAnnounceSalaryList.Interval = tickTime;
            }
            else
            {
                TimeSpan t1 = new TimeSpan(4, 0, 0);
                tickTime = (int)t1.TotalMilliseconds;
                timerAnnounceSalaryList.Interval = tickTime;
            }
            timerAnnounceSalaryList.Enabled = true;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginForm_1 login = new loginForm_1();
            login.Show();
        }
    }
}
