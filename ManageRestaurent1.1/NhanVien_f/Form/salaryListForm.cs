using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageRestaurent1._1
{
    class salaryListForm : Form
    {
        private Guna.UI2.WinForms.Guna2HtmlLabel labelSalary;
        private Guna.UI2.WinForms.Guna2CircleButton buttonClose;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.ComponentModel.IContainer components;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewSalaryList;

        public salaryListForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewSalaryList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.labelSalary = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.buttonClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalaryList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSalaryList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSalaryList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSalaryList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSalaryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSalaryList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSalaryList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSalaryList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewSalaryList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSalaryList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSalaryList.ColumnHeadersHeight = 40;
            this.dataGridViewSalaryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSalaryList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSalaryList.EnableHeadersVisualStyles = false;
            this.dataGridViewSalaryList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(177)))), ((int)(((byte)(176)))));
            this.dataGridViewSalaryList.Location = new System.Drawing.Point(9, 83);
            this.dataGridViewSalaryList.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewSalaryList.Name = "dataGridViewSalaryList";
            this.dataGridViewSalaryList.ReadOnly = true;
            this.dataGridViewSalaryList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSalaryList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSalaryList.RowHeadersVisible = false;
            this.dataGridViewSalaryList.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSalaryList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSalaryList.RowTemplate.DividerHeight = 1;
            this.dataGridViewSalaryList.RowTemplate.Height = 40;
            this.dataGridViewSalaryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSalaryList.Size = new System.Drawing.Size(764, 361);
            this.dataGridViewSalaryList.TabIndex = 2;
            this.dataGridViewSalaryList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridViewSalaryList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewSalaryList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewSalaryList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewSalaryList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewSalaryList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewSalaryList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewSalaryList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(177)))), ((int)(((byte)(176)))));
            this.dataGridViewSalaryList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dataGridViewSalaryList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewSalaryList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewSalaryList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewSalaryList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSalaryList.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGridViewSalaryList.ThemeStyle.ReadOnly = true;
            this.dataGridViewSalaryList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewSalaryList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewSalaryList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewSalaryList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewSalaryList.ThemeStyle.RowsStyle.Height = 40;
            this.dataGridViewSalaryList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.dataGridViewSalaryList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // labelSalary
            // 
            this.labelSalary.BackColor = System.Drawing.Color.Transparent;
            this.labelSalary.Font = new System.Drawing.Font("Microsoft New Tai Lue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.Location = new System.Drawing.Point(12, 37);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(84, 37);
            this.labelSalary.TabIndex = 4;
            this.labelSalary.Text = "Payroll";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BorderColor = System.Drawing.Color.Transparent;
            this.buttonClose.CheckedState.Parent = this.buttonClose;
            this.buttonClose.CustomImages.Parent = this.buttonClose;
            this.buttonClose.FillColor = System.Drawing.Color.Transparent;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.HoverState.Parent = this.buttonClose;
            this.buttonClose.Image = global::ManageRestaurent1._1.Properties.Resources.left_arrow;
            this.buttonClose.Location = new System.Drawing.Point(3, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonClose.ShadowDecoration.Parent = this.buttonClose;
            this.buttonClose.Size = new System.Drawing.Size(32, 32);
            this.buttonClose.TabIndex = 13;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(782, 453);
            this.guna2Panel1.TabIndex = 14;
            // 
            // salaryListForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.dataGridViewSalaryList);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "salaryListForm";
            this.Load += new System.EventHandler(this.salaryListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalaryList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        Employee employee = new Employee();
        Luong luong = new Luong();
        DiemDanh diemDanh = new DiemDanh();

        private void salaryListForm_Load(object sender, EventArgs e)
        {
            newTinhLuong();
            formLoad();
        }

        public void formLoad()
        {
            DateTime nowTime = DateTime.Now.Date;
            DateTime endTime = nowTime.AddDays(1);
            DateTime startTime = nowTime;
            SqlCommand command = new SqlCommand("SELECT Picture, N.Msnv, Fname, Lname, Cast(Date as Date) AS Date, Cast(Salary AS Decimal(10,0)) AS Salary, tinhtrang as 'Status' FROM Nhanvien as N, Luong as L" +
                " WHERE N.msnv = L.msnv AND Date >= @startTime AND Date <= @endTime");
            command.Parameters.Add("@startTime", SqlDbType.Date).Value = startTime;
            command.Parameters.Add("@endTime", SqlDbType.Date).Value = endTime;
            fillGrid(command);
        }

        public void fillGrid(SqlCommand command)
        {
            DataTable table = employee.getEmployees(command);
            dataGridViewSalaryList.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewSalaryList.DataSource = table;
            picCol = (DataGridViewImageColumn)dataGridViewSalaryList.Columns[0];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewSalaryList.AllowUserToAddRows = false;
            dataGridViewSalaryList.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void newTinhLuong()
        {
            SqlCommand command1 = new SqlCommand("SELECT NHANVIEN.msnv, noidungcv, luongcoso, hesoluong, maca, nvlamthay FROM Nhanvien, Congviec, PhanCa WHERE congviec = macv AND NHANVIEN.msnv = PhanCa.msnv");
            DataTable table1 = employee.getEmployees(command1);
            table1.Columns.Add("tongtg", typeof(TimeSpan));
            table1.Columns.Add("luong", typeof(float));
            TimeSpan t = new TimeSpan(0, 0, 0);
            for (int i = 0; i < table1.Rows.Count; i++)
            {
                table1.Rows[i]["tongtg"] = t;
                table1.Rows[i]["luong"] = 0;
            }

            tinhLuongTheoCa(table1, 1);
            tinhLuongTheoCa(table1, 2);
            tinhLuongTheoCa(table1, 3);

            SqlCommand command = new SqlCommand("SELECT msnv FROM Nhanvien");
            DataTable table = employee.getEmployees(command);
            table.Columns.Add("luong", typeof(float));

            for (int i = 0; i < table.Rows.Count; i++)
            {
                table.Rows[i]["luong"] = 0;
            }

            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 0; j < table1.Rows.Count; j++)
                {
                    if (Convert.ToInt32(table.Rows[i]["msnv"].ToString()) == Convert.ToInt32(table1.Rows[j]["msnv"].ToString()))
                    {
                        table.Rows[i]["luong"] = Convert.ToDouble(table.Rows[i]["luong"]) + Convert.ToDouble(table1.Rows[j]["luong"]);
                    }
                }
            }

            saveLuong(table);
            diemDanh.deleteAllDiemDanh();
        }

        public void saveLuong(DataTable table)
        {
            int msnv1;
            double tluong;

            DateTime time = DateTime.Now;
            SqlCommand command2 = new SqlCommand("SELECT * FROM luong WHERE date >= '" + time.Date + "'");
            DataTable table2 = luong.getLuong(command2);

            for (int i = 0; i < table2.Rows.Count; i++)
            {
                msnv1 = Convert.ToInt32(table2.Rows[i]["msnv"].ToString());
                time = Convert.ToDateTime(table2.Rows[i]["date"].ToString());
                luong.deleteLuong(msnv1, time);
            }

            for (int i = 0; i < table.Rows.Count; i++)
            {
                msnv1 = Convert.ToInt32(table.Rows[i]["msnv"].ToString());
                tluong = Convert.ToDouble(table.Rows[i]["luong"].ToString());
                if (tluong < 0)
                {
                    luong.insertSalary(msnv1, DateTime.Now, 0, "Chua Nhan");
                }
                else
                {
                    luong.insertSalary(msnv1, DateTime.Now, tluong, "Chua Nhan");
                }
            }
        }

        public void tinhLuongTheoCa(DataTable table1, int ca)
        {
            DateTime d;
            double hesoluong;
            double luongcoso;
            double x;

            SqlCommand command = new SqlCommand("SELECT D.msnv, D.checkin, D.checkout, C.thoigianbatdau, C.thoigianketthuc " +
                "FROM Diemdanh AS D, Phanca AS P, Ca AS C WHERE D.msnv = P.msnv AND P.maca = C.maca AND D.checkout IS NOT NULL AND C.maca = @Ca");
            command.Parameters.Add("@Ca", SqlDbType.Int).Value = ca;
            DataTable table = diemDanh.getDiemDanh(command);

            TimeSpan tStart, tEnd;
            DateTime checkIn, checkOut, startTime, endTime;
            int msnv;
            for (int i = 0; i < table1.Rows.Count; i++)
            {
                if (Convert.ToInt32(table1.Rows[i]["maca"].ToString()) == ca)
                {
                    msnv = Convert.ToInt32(table1.Rows[i]["msnv"].ToString());
                    for (int j = 0; j < table.Rows.Count; j++)
                    {
                        if (msnv == Convert.ToInt32(table.Rows[j]["msnv"].ToString()))
                        {
                            checkIn = Convert.ToDateTime(table.Rows[j]["checkin"].ToString());
                            checkOut = Convert.ToDateTime(table.Rows[j]["checkout"].ToString());
                            startTime = Convert.ToDateTime(table.Rows[j]["thoigianbatdau"].ToString());
                            endTime = Convert.ToDateTime(table.Rows[j]["thoigianketthuc"].ToString());
                            if ((DateTime.Compare(checkIn, endTime) < 0) && (DateTime.Compare(checkOut, startTime) > 0))
                            {
                                if (DateTime.Compare(checkIn, startTime) <= 0)
                                {
                                    tStart = new TimeSpan(startTime.Hour, startTime.Minute, startTime.Second);
                                }
                                else
                                {
                                    tStart = new TimeSpan(checkIn.Hour, checkIn.Minute, checkIn.Second);
                                }

                                if (DateTime.Compare(checkOut, endTime) <= 0)
                                {
                                    tEnd = new TimeSpan(checkOut.Hour, checkOut.Minute, checkOut.Second);
                                }
                                else
                                {
                                    tEnd = new TimeSpan(endTime.Hour, endTime.Minute, checkOut.Second);
                                }
                                table1.Rows[i]["tongtg"] = Convert.ToDateTime(table1.Rows[i]["tongtg"].ToString()).Add(tEnd.Subtract(tStart)).TimeOfDay;
                            }
                        }
                    }
                    d = Convert.ToDateTime(table1.Rows[i]["tongtg"].ToString());
                    hesoluong = Convert.ToDouble(table1.Rows[i]["hesoluong"].ToString());
                    luongcoso = Convert.ToDouble(table1.Rows[i]["luongcoso"].ToString());

                    if (d.Hour >= 4)
                    {
                        table1.Rows[i]["luong"] = Convert.ToDouble(table1.Rows[i]["luong"].ToString()) + (d.Hour + (double)d.Minute / 60) * hesoluong * luongcoso;
                    }
                    else
                    {
                        x = (4 - d.Hour - (double)d.Minute / 60) * 100000 * hesoluong;
                        table1.Rows[i]["luong"] = Convert.ToDouble(table1.Rows[i]["luong"].ToString()) + (d.Hour + (double)d.Minute / 60) * hesoluong * luongcoso - x;
                        if (table1.Rows[i]["nvlamthay"].ToString().Trim() != "")
                        {
                            for (int j = 0; j < table1.Rows.Count; j++)
                            {
                                if (Convert.ToInt32(table1.Rows[i]["nvlamthay"].ToString()) == Convert.ToInt32(table1.Rows[j]["msnv"].ToString()))
                                {
                                    table1.Rows[j]["luong"] = Convert.ToDouble(table1.Rows[j]["luong"]) + x;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

    }
}
