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
    class luongForm : Form
    {
        private DataGridView dataGridViewLuongList;

        public luongForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dataGridViewLuongList = new System.Windows.Forms.DataGridView();
            this.buttonTinhLuong = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLuong = new System.Windows.Forms.TextBox();
            this.textBoxTinhTrang = new System.Windows.Forms.TextBox();
            this.buttonThanhToan = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLuongList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLuongList
            // 
            this.dataGridViewLuongList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLuongList.Location = new System.Drawing.Point(383, 24);
            this.dataGridViewLuongList.Name = "dataGridViewLuongList";
            this.dataGridViewLuongList.RowHeadersWidth = 51;
            this.dataGridViewLuongList.RowTemplate.Height = 24;
            this.dataGridViewLuongList.Size = new System.Drawing.Size(456, 341);
            this.dataGridViewLuongList.TabIndex = 0;
            this.dataGridViewLuongList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLuongList_CellContentClick);
            // 
            // buttonTinhLuong
            // 
            this.buttonTinhLuong.Location = new System.Drawing.Point(540, 371);
            this.buttonTinhLuong.Name = "buttonTinhLuong";
            this.buttonTinhLuong.Size = new System.Drawing.Size(100, 33);
            this.buttonTinhLuong.TabIndex = 1;
            this.buttonTinhLuong.Text = "Tinh Luong";
            this.buttonTinhLuong.UseVisualStyleBackColor = true;
            this.buttonTinhLuong.Click += new System.EventHandler(this.buttonTinhLuong_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 20);
            this.label11.TabIndex = 78;
            this.label11.Text = "ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(291, 32);
            this.label9.TabIndex = 77;
            this.label9.Text = "Employee Information";
            // 
            // textBoxLName
            // 
            this.textBoxLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLName.Location = new System.Drawing.Point(142, 200);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(234, 27);
            this.textBoxLName.TabIndex = 76;
            // 
            // textBoxFname
            // 
            this.textBoxFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFname.Location = new System.Drawing.Point(142, 149);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(234, 27);
            this.textBoxFname.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 80;
            this.label1.Text = "Luong:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 82;
            this.label4.Text = "Tinh trang:";
            // 
            // textBoxLuong
            // 
            this.textBoxLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLuong.Location = new System.Drawing.Point(142, 248);
            this.textBoxLuong.Name = "textBoxLuong";
            this.textBoxLuong.Size = new System.Drawing.Size(146, 27);
            this.textBoxLuong.TabIndex = 83;
            // 
            // textBoxTinhTrang
            // 
            this.textBoxTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTinhTrang.Location = new System.Drawing.Point(142, 298);
            this.textBoxTinhTrang.Name = "textBoxTinhTrang";
            this.textBoxTinhTrang.Size = new System.Drawing.Size(146, 27);
            this.textBoxTinhTrang.TabIndex = 84;
            // 
            // buttonThanhToan
            // 
            this.buttonThanhToan.Location = new System.Drawing.Point(116, 366);
            this.buttonThanhToan.Name = "buttonThanhToan";
            this.buttonThanhToan.Size = new System.Drawing.Size(100, 33);
            this.buttonThanhToan.TabIndex = 85;
            this.buttonThanhToan.Text = "Thanh toan";
            this.buttonThanhToan.UseVisualStyleBackColor = true;
            this.buttonThanhToan.Click += new System.EventHandler(this.buttonThanhToan_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(142, 99);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(118, 27);
            this.textBoxID.TabIndex = 86;
            // 
            // luongForm
            // 
            this.ClientSize = new System.Drawing.Size(847, 418);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonThanhToan);
            this.Controls.Add(this.textBoxTinhTrang);
            this.Controls.Add(this.textBoxLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxFname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonTinhLuong);
            this.Controls.Add(this.dataGridViewLuongList);
            this.Name = "luongForm";
            this.Text = "Luong";
            this.Load += new System.EventHandler(this.luongForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLuongList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        DiemDanh diemDanh = new DiemDanh();
        Employee employee = new Employee();
        PhanCa phanCa = new PhanCa();
        private Button buttonTinhLuong;
        private Label label11;
        private Label label9;
        private TextBox textBoxLName;
        private TextBox textBoxFname;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox textBoxLuong;
        private TextBox textBoxTinhTrang;
        private Button buttonThanhToan;
        private TextBox textBoxID;
        Luong luong = new Luong();

        private void luongForm_Load(object sender, EventArgs e)
        {
            formLoad();
        }

        public void formLoad()
        {
            dataGridViewLuongList.ReadOnly = true;
            dataGridViewLuongList.DataSource = luong.getAllLuong();
            dataGridViewLuongList.AllowUserToAddRows = false;
        }

        public void tinhLuong()
        {
            SqlCommand command = new SqlCommand("SELECT D.msnv, D.checkin, D.checkout, C.thoigianbatdau, C.thoigianketthuc " +
                "FROM Diemdanh AS D, Phanca AS P, Ca AS C WHERE D.msnv = P.msnv AND P.maca = C.maca AND D.checkout IS NOT NULL ");
            DataTable table = diemDanh.getDiemDanh(command);
            SqlCommand command1 = new SqlCommand("SELECT msnv, noidungcv, luongcoso, hesoluong FROM Nhanvien, Congviec WHERE congviec = macv");
            DataTable table1 = employee.getEmployees(command1);
            table1.Columns.Add("tongtg", typeof(TimeSpan));
            table1.Columns.Add("luong", typeof(float));
            TimeSpan t = new TimeSpan(0, 0, 0);
            for (int i = 0; i < table1.Rows.Count; i++)
            {
                table1.Rows[i]["tongtg"] = t;
                table1.Rows[i]["luong"] = 0;
            }    
            if (table.Rows.Count > 0)
            {
                TimeSpan tStart, tEnd;
                DateTime checkIn, checkOut, startTime, endTime;
                int msnv;
                for (int i = 0; i < table1.Rows.Count; i++)
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
                    
                }
                /*for (int i = 0; i < table1.Rows.Count; i++)
                {
                    MessageBox.Show(table1.Rows[i]["tongtg"].ToString());
                }*/
                DateTime d;
                double hesoluong;
                double luongcoso;
                double x;
                SqlCommand command2 = new SqlCommand("SELECT * FROM Phanca WHERE nvlamthay is not null");
                DataTable table2 = phanCa.getPhanCa(command2);
                SqlCommand command3 = new SqlCommand("SELECT P.msnv, Count(P.maca) AS tongca FROM Phanca AS P, Nhanvien AS N, Congviec AS C WHERE P.msnv = N.msnv AND N.congviec = C.macv " +
                    " AND noidungcv = 'Quan ly' GROUP BY P.msnv");
                DataTable table3 = phanCa.getPhanCa(command3);
                
                
                for (int i = 0; i < table1.Rows.Count; i++)
                {
                    d = Convert.ToDateTime(table1.Rows[i]["tongtg"].ToString());
                    hesoluong = Convert.ToDouble(table1.Rows[i]["hesoluong"].ToString());
                    luongcoso = Convert.ToDouble(table1.Rows[i]["luongcoso"].ToString());
                    
                    if (table1.Rows[i]["Noidungcv"].ToString().Contains("Nhan vien"))
                    {
                        if (d.Hour >= 8)
                        {
                            table1.Rows[i]["luong"] = Convert.ToDouble(table1.Rows[i]["luong"].ToString()) + (d.Hour + (double)d.Minute / 60) * hesoluong * luongcoso;
                        }
                        else
                        {
                            x = (8 - d.Hour - (double)d.Minute / 60) * 100000 * hesoluong; 
                            table1.Rows[i]["luong"] = Convert.ToDouble(table1.Rows[i]["luong"].ToString()) + (d.Hour + (double)d.Minute/60) * hesoluong * luongcoso - x;
                            
                            for (int j = 0; j < table2.Rows.Count; j++)
                            {
                                if (Convert.ToInt32(table1.Rows[i]["msnv"].ToString()) == Convert.ToInt32(table2.Rows[j]["msnv"]))
                                {
                                    for (int k = 0; k < table1.Rows.Count; k++)
                                    {
                                        if (Convert.ToInt32(table1.Rows[k]["msnv"]) == Convert.ToInt32(table2.Rows[j]["nvlamthay"].ToString()))
                                        {
                                            table1.Rows[k]["luong"] = Convert.ToDouble(table1.Rows[k]["luong"]) + x;
                                        }    
                                    }    
                                }
                            }    
                        }    
                    }   
                    else
                    { 
                        for (int j = 0; j < table3.Rows.Count; j++)
                        {
                            if (Convert.ToInt32(table1.Rows[i]["msnv"]) == Convert.ToInt32(table1.Rows[j]["msnv"]))
                            { 
                                if (Convert.ToInt32(table3.Rows[j]["tongca"].ToString()) == 2)
                                {
                                    if (d.Hour >= 8)
                                    {
                                        table1.Rows[i]["luong"] = Convert.ToDouble(table1.Rows[i]["luong"].ToString()) + (d.Hour + (double)d.Minute / 60) * hesoluong * luongcoso;
                                    }
                                    else
                                    {
                                        x = (8 - d.Hour - (double)d.Minute / 60) * 100000 * hesoluong;
                                        table1.Rows[i]["luong"] = Convert.ToDouble(table1.Rows[i]["luong"].ToString()) + (d.Hour + (double)d.Minute / 60) * hesoluong * luongcoso - x;
                                       
                                        for (int m = 0; m < table2.Rows.Count; m++)
                                        {
                                            if (Convert.ToInt32(table1.Rows[i]["msnv"].ToString()) == Convert.ToInt32(table2.Rows[m]["msnv"]))
                                            { 
                                                for (int k = 0; k < table1.Rows.Count; k++)
                                                {
                                                    if (Convert.ToInt32(table1.Rows[k]["msnv"]) == Convert.ToInt32(table2.Rows[m]["nvlamthay"].ToString()))
                                                    {
                                                        table1.Rows[k]["luong"] = Convert.ToDouble(table1.Rows[k]["luong"]) + x;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (d.Hour >= 4)
                                    {
                                        table1.Rows[i]["luong"] = Convert.ToDouble(table1.Rows[i]["luong"]) + (d.Hour + (double)d.Minute / 60) * hesoluong * luongcoso;
                                        
                                    }
                                    else
                                    {
                                        x = (4 - d.Hour - (double)d.Minute / 60) * 100000 * hesoluong;
                                        table1.Rows[i]["luong"] = Convert.ToDouble(table1.Rows[i]["luong"]) + (d.Hour + (double)d.Minute / 60) * hesoluong * luongcoso - x;
                                        
                                        for (int m = 0; m < table2.Rows.Count; m++)
                                        {
                                            if (Convert.ToInt32(table1.Rows[i]["msnv"].ToString()) == Convert.ToInt32(table2.Rows[m]["msnv"]))
                                            {
                                                for (int k = 0; k < table1.Rows.Count; k++)
                                                {
                                                    if (Convert.ToInt32(table1.Rows[k]["msnv"]) == Convert.ToInt32(table2.Rows[m]["nvlamthay"].ToString()))
                                                    {
                                                        table1.Rows[k]["luong"] = Convert.ToDouble(table1.Rows[k]["luong"]) + x;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                
                                }    
                            }    
                        }    
                    }                        
                }    
            }

            int msnv1;
            double tluong;
            for (int i = 0; i < table1.Rows.Count; i++)
            {
                msnv1 = Convert.ToInt32(table1.Rows[i]["msnv"].ToString());
                tluong = Convert.ToDouble(table1.Rows[i]["luong"].ToString());
                luong.insertSalary(msnv1, DateTime.Now, tluong, "Chua Nhan");
            }    
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

            int msnv1;
            double tluong;
            for (int i = 0; i < table1.Rows.Count; i++)
            {
                msnv1 = Convert.ToInt32(table1.Rows[i]["msnv"].ToString());
                tluong = Convert.ToDouble(table1.Rows[i]["luong"].ToString());
                luong.insertSalary(msnv1, DateTime.Now, tluong, "Chua Nhan");
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
                if (Convert.ToInt32(table.Rows[i]["maca"].ToString()) == ca)
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
                                }
                            }
                        }
                    }
                    table1.Rows[i]["tongtg"] = new TimeSpan(0, 0, 0);
                }
            }  
        }

        private void buttonTinhLuong_Click(object sender, EventArgs e)
        {
            newTinhLuong();
            formLoad();
        }

        private void dataGridViewLuongList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int msnv = Convert.ToInt32(dataGridViewLuongList.CurrentRow.Cells[0].Value.ToString());
                DataTable table = employee.getEmployeeByMsnv(msnv);
                textBoxID.Text = table.Rows[0]["msnv"].ToString();
                textBoxFname.Text = table.Rows[0]["fname"].ToString();
                textBoxLName.Text = table.Rows[0]["lname"].ToString();
                textBoxLuong.Text = dataGridViewLuongList.CurrentRow.Cells["salary"].Value.ToString();
                textBoxTinhTrang.Text = dataGridViewLuongList.CurrentRow.Cells["tinhtrang"].Value.ToString();
            }
            catch
            {

            }
        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                int msnv = Convert.ToInt32(textBoxID.Text);
                if (textBoxTinhTrang.Text == "Chua Nhan")
                {
                    if (luong.updateLuong(msnv, "Da Nhan"))
                    {
                        MessageBox.Show("Updated", "Thanh toan luong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxTinhTrang.Text = "Da Nhan";
                        formLoad();
                    }
                    else
                    {
                        MessageBox.Show("Not Updated", "Thanh toan luong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Nhan vien da nhan luong", "Thanh toan luong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }    
            }
            catch
            {
                MessageBox.Show("Vui long chon nhan vien", "Thanh toan luong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
