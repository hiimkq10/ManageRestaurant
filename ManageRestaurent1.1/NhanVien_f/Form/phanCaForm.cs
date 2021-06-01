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
    class phanCaForm : Form
    {
        private Button buttonPhanCa;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxSoNVCa1;
        private TextBox textBoxSoNVCa2;
        private TextBox textBoxSoNVCa3;
        private Label labelTotalEmployee;
        private DataGridView dataGridViewPhanCa;

        private void InitializeComponent()
        {
            this.dataGridViewPhanCa = new System.Windows.Forms.DataGridView();
            this.buttonPhanCa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSoNVCa1 = new System.Windows.Forms.TextBox();
            this.textBoxSoNVCa2 = new System.Windows.Forms.TextBox();
            this.textBoxSoNVCa3 = new System.Windows.Forms.TextBox();
            this.labelTotalEmployee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhanCa)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPhanCa
            // 
            this.dataGridViewPhanCa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhanCa.Location = new System.Drawing.Point(12, 154);
            this.dataGridViewPhanCa.Name = "dataGridViewPhanCa";
            this.dataGridViewPhanCa.RowHeadersWidth = 51;
            this.dataGridViewPhanCa.RowTemplate.Height = 24;
            this.dataGridViewPhanCa.Size = new System.Drawing.Size(619, 281);
            this.dataGridViewPhanCa.TabIndex = 0;
            // 
            // buttonPhanCa
            // 
            this.buttonPhanCa.Location = new System.Drawing.Point(237, 441);
            this.buttonPhanCa.Name = "buttonPhanCa";
            this.buttonPhanCa.Size = new System.Drawing.Size(147, 35);
            this.buttonPhanCa.TabIndex = 1;
            this.buttonPhanCa.Text = "Phan ca";
            this.buttonPhanCa.UseVisualStyleBackColor = true;
            this.buttonPhanCa.Click += new System.EventHandler(this.buttonPhanCa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số nhân viên ca 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số nhân viên ca 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số nhân viên ca 3:";
            // 
            // textBoxSoNVCa1
            // 
            this.textBoxSoNVCa1.Location = new System.Drawing.Point(160, 54);
            this.textBoxSoNVCa1.Name = "textBoxSoNVCa1";
            this.textBoxSoNVCa1.Size = new System.Drawing.Size(100, 22);
            this.textBoxSoNVCa1.TabIndex = 5;
            // 
            // textBoxSoNVCa2
            // 
            this.textBoxSoNVCa2.Location = new System.Drawing.Point(160, 84);
            this.textBoxSoNVCa2.Name = "textBoxSoNVCa2";
            this.textBoxSoNVCa2.Size = new System.Drawing.Size(100, 22);
            this.textBoxSoNVCa2.TabIndex = 6;
            // 
            // textBoxSoNVCa3
            // 
            this.textBoxSoNVCa3.Location = new System.Drawing.Point(160, 114);
            this.textBoxSoNVCa3.Name = "textBoxSoNVCa3";
            this.textBoxSoNVCa3.Size = new System.Drawing.Size(100, 22);
            this.textBoxSoNVCa3.TabIndex = 7;
            // 
            // labelTotalEmployee
            // 
            this.labelTotalEmployee.AutoSize = true;
            this.labelTotalEmployee.Location = new System.Drawing.Point(9, 25);
            this.labelTotalEmployee.Name = "labelTotalEmployee";
            this.labelTotalEmployee.Size = new System.Drawing.Size(130, 17);
            this.labelTotalEmployee.TabIndex = 8;
            this.labelTotalEmployee.Text = "Tổng số nhân viên:";
            // 
            // phanCaForm
            // 
            this.ClientSize = new System.Drawing.Size(637, 488);
            this.Controls.Add(this.labelTotalEmployee);
            this.Controls.Add(this.textBoxSoNVCa3);
            this.Controls.Add(this.textBoxSoNVCa2);
            this.Controls.Add(this.textBoxSoNVCa1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPhanCa);
            this.Controls.Add(this.dataGridViewPhanCa);
            this.Name = "phanCaForm";
            this.Text = "Phan ca";
            this.Load += new System.EventHandler(this.phanCaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhanCa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public phanCaForm()
        {
            InitializeComponent();
        }

        Employee employee = new Employee();
        PhanCa phanCa = new PhanCa();

        private void buttonPhanCa_Click(object sender, EventArgs e)
        {
            try
            {
                int totalEmployee = employee.getTotalNV();
                int count1 = Convert.ToInt32(textBoxSoNVCa1.Text);
                int count2 = Convert.ToInt32(textBoxSoNVCa2.Text);
                int count3 = Convert.ToInt32(textBoxSoNVCa3.Text);
                if (totalEmployee == (count1 + count2 + count3) / 2)
                {
                    if ((count3 > count1 + count2 + 1) || (count2 > count1 + count3 + 1) || (count1 > count2 + count3 + 1))
                    {
                        MessageBox.Show("So ca khong dung", "Phan ca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int slnvc12 = count1 + count2 - totalEmployee;
                        int slnvc13 = count1 + count3 - totalEmployee;
                        int slnvc23 = count2 + count3 - totalEmployee;
                        SqlCommand command = new SqlCommand("SELECT * FROM Phanca AS P, Nhanvien AS N, Congviec WHERE P.msnv = N.msnv AND congviec = macv AND noidungcv = 'Nhan vien'");
                        DataTable table = phanCa.getPhanCa(command);
                    
                        List<int> Listc12 = new List<int>();
                        List<int> Listc13 = new List<int>();
                        List<int> Listc23 = new List<int>();

                        if (table.Rows.Count == 0)
                        {
                            SqlCommand command1 = new SqlCommand("SELECT msnv FROM Nhanvien, Congviec WHERE congviec = macv AND noidungcv = 'Nhan vien'");
                            DataTable table1 = employee.getEmployees(command1);
                        
                            for (int i = 0; i < totalEmployee; i++)
                            {
                                if (i < slnvc12)
                                {
                                    Listc12.Add(Convert.ToInt32(table1.Rows[i]["msnv"].ToString()));
                                }    
                                else if (i < slnvc12 + slnvc13)
                                {
                                    Listc13.Add(Convert.ToInt32(table1.Rows[i]["msnv"].ToString()));
                                }
                                else
                                {
                                    Listc23.Add(Convert.ToInt32(table1.Rows[i]["msnv"].ToString()));
                                }    
                            }    
                        }
                        else
                        {
                            SqlCommand command1 = new SqlCommand("SELECT msnv FROM Nhanvien WHERE msnv not in (SELECT DISTINCT msnv FROM Phanca)" +
                                " AND msnv in (SELECT msnv FROM Nhanvien, Congviec WHERE congviec = macv AND noidungcv = 'Nhan vien')");
                        
                            DataTable dsnvm = employee.getEmployees(command1);
                           
                            DataTable dsnvCa12 = employee.getEmployeeByPhancong(1, 2);
                            Listc12 = convertDataTableToList(dsnvCa12);
                            DataTable dsnvCa13 = employee.getEmployeeByPhancong(1, 3);
                            Listc13 = convertDataTableToList(dsnvCa13);
                            DataTable dsnvCa23 = employee.getEmployeeByPhancong(2, 3);
                            Listc23 = convertDataTableToList(dsnvCa23);
                        
                            int length12 = Listc12.Count;
                            int length13 = Listc13.Count;
                            int length23 = Listc23.Count;
                            if (length13 > slnvc13)
                            {
                                if (length23 < slnvc23)
                                {
                                    chuanHoaPhai(ref length13, slnvc13, ref length23, slnvc23, Listc13, Listc23);
                                }
                                if (length12 < slnvc12)
                                {
                                    chuanHoaTrai(ref length13, slnvc13, ref length12, slnvc12, Listc13, Listc12);
                                }
                            }

                            if (length12 > slnvc12)
                            {
                                if (length13 < slnvc13)
                                {
                                    chuanHoaPhai(ref length12, slnvc12, ref length13, slnvc13, Listc12, Listc13);
                                }
                                if (length23 < slnvc23)
                                {
                                    chuanHoaTrai(ref length12, slnvc12, ref length23, slnvc23, Listc12, Listc23);
                                }
                            }

                            if (length23 > slnvc23)
                            {
                                if (length12 < slnvc12)
                                {
                                    chuanHoaPhai(ref length23, slnvc23, ref length12, slnvc12, Listc23, Listc12);
                                }
                                if (length13 < slnvc13)
                                {
                                    chuanHoaTrai(ref length23, slnvc23, ref length13, slnvc13, Listc23, Listc13);
                                }
                            }

                            int heSoSwap = Min(length12, length13, length23);

                            if (heSoSwap != 0)
                            {
                                if (check0(slnvc12))
                                {
                                    if (check0(slnvc13))
                                    {
                                        if (check0(slnvc23))
                                        {
                                            for (int i = 0; i < heSoSwap; i++)
                                            {
                                                Listc13.Add(Listc12[0]);
                                                Listc12.RemoveAt(0);
                                                Listc23.Add(Listc13[0]);
                                                Listc13.RemoveAt(0);
                                                Listc12.Add(Listc23[0]);
                                                Listc23.RemoveAt(0);
                                            }
                                        }
                                        else
                                        {
                                            for (int i = 0; i < heSoSwap; i++)
                                            {
                                                Listc13.Add(Listc12[0]);
                                                Listc12.RemoveAt(0);
                                                Listc12.Add(Listc13[0]);
                                                Listc13.RemoveAt(0);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (check0(slnvc23))
                                        {
                                            for (int i = 0; i < heSoSwap; i++)
                                            {
                                                Listc23.Add(Listc12[0]);
                                                Listc12.RemoveAt(0);
                                                Listc12.Add(Listc23[0]);
                                                Listc23.RemoveAt(0);
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (check0(slnvc13))
                                    {
                                        if (check0(slnvc23))
                                        {
                                            for (int i = 0; i < heSoSwap; i++)
                                            {
                                                Listc23.Add(Listc13[0]);
                                                Listc13.RemoveAt(0);
                                                Listc13.Add(Listc23[0]);
                                                Listc23.RemoveAt(0);
                                            }
                                        }
                                    }
                                }
                            }

                            for (int i = 0; i < dsnvm.Rows.Count; i++)
                            {
                                if (length12 < slnvc12)
                                {
                                    Listc12.Add(Convert.ToInt32(dsnvm.Rows[i]["msnv"]));
                                    length12++;
                                }
                                else 
                                {
                                    if (length13 < slnvc13)
                                    {
                                        Listc13.Add(Convert.ToInt32(dsnvm.Rows[i]["msnv"]));
                                        length13++;
                                    }
                                    else if (length23 < slnvc23)
                                    {
                                        Listc23.Add(Convert.ToInt32(dsnvm.Rows[i]["msnv"]));
                                        length23++;
                                    }
                                }
                            }
                        }

                        int[] A = this.phanCaQuanLy();

                        phanCa.deleteAllPhanCa();

                        if (A != null)
                        {
                            for (int i = 1; i < 4; i++)
                            {
                                phanCa.insertPhanCa(A[i], i, i);
                            }
                        }    

                        for (int i = 0; i < slnvc12; i++)
                        {
                            phanCa.insertPhanCa(Listc12[i], 1, slnvc12 - i);
                            phanCa.insertPhanCa(Listc12[i], 2, slnvc12 - i);
                        }

                        for (int i = 0; i < slnvc13; i++)
                        {
                            phanCa.insertPhanCa(Listc13[i], 1, slnvc13 - i);
                            phanCa.insertPhanCa(Listc13[i], 3, slnvc13 - i);
                        }

                        for (int i = 0; i < slnvc23; i++)
                        {
                            phanCa.insertPhanCa(Listc23[i], 2, slnvc23 - i);
                            phanCa.insertPhanCa(Listc23[i], 3, slnvc23 - i);
                        }
                        formLoad();
                    }
                }
                else
                {
                    MessageBox.Show("So ca khong dung", "Phan ca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }    
            }
            catch
            {
                MessageBox.Show("Vui long nhap chinh xac", "Phan ca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void formLoad()
        {
            dataGridViewPhanCa.ReadOnly = true;
            dataGridViewPhanCa.DataSource = phanCa.getAllPhanCa();
            dataGridViewPhanCa.AllowUserToAddRows = false;
        }

        public bool check0(int a)
        {
            if (a != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Min(int a, int b, int c)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    return c;
                }
                else
                {
                    if (b > c && c != 0)
                    {
                        b = c;
                    }
                    return b;
                }
            }
            else
            {
                if (a > b && b != 0)
                {
                    a = b;
                }
                if (a > c && c != 0)
                {
                    a = c;
                }
            }
            return a;
        }

        public void chuanHoaTrai(ref int length1, int slnv1, ref int length2, int slnv2, List<int> l1, List<int> l2)
        {
            while (length1 > slnv1)
            {
                if (length2 < slnv2)
                {
                    l2.Insert(0,(l1[length1 - 1]));
                    l1.RemoveAt(length1 - 1);
                    length1--;
                    length2++;
                }
                else
                {
                    break;
                }
            }
        }

        public void chuanHoaPhai(ref int length1, int slnv1, ref int length2, int slnv2, List<int> l1, List<int> l2)
        {
            while (length1 > slnv1)
            {
                if (length2 < slnv2)
                {
                    l2.Add(l1[0]);
                    l1.RemoveAt(0);
                    length1--;
                    length2++;
                }
                else
                {
                    break;
                }
            }
        }

        public List<int> convertDataTableToList(DataTable table)
        {
            List<int> l = new List<int>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                l.Add(Convert.ToInt32(table.Rows[i]["msnv"].ToString()));
            }
            return l;
        }

        public int max(int a, int b, int c)
        {
            int kq = 1;
            if (a < b)
            {
                a = b;
                kq = 2;
            }
            if (a < c)
            {
                a = c;
                kq = 3;
            }
            return kq;
        }

        private void phanCaForm_Load(object sender, EventArgs e)
        {
            labelTotalEmployee.Text = ("Total Employee: " + employee.getTotalNV());
            formLoad();
        }

        public int[] phanCaQuanLy()
        {
            int[] A = new int[4];

            SqlCommand com = new SqlCommand("SELECT * FROM Nhanvien, Congviec WHERE congviec = macv AND noidungcv = 'Quan ly'");
            DataTable tab = employee.getEmployees(com);
            if (tab.Rows.Count == 0)
            {
                return null;
            }    
            if (tab.Rows.Count == 1)
            {
                int msnv = Convert.ToInt32(tab.Rows[0]["msnv"].ToString());
                for (int i = 1; i < 4; i++)
                {
                    A[i] = msnv;
                }
                return A;
            }    

            SqlCommand command = new SqlCommand("SELECT msnv FROM Nhanvien, Congviec WHERE congviec = macv AND noidungcv = 'Quan ly' " +
                " AND msnv in (SELECT msnv FROM Phanca)");
            DataTable table = employee.getEmployees(command);

            if (table.Rows.Count == 0)
            {
                SqlCommand command1 = new SqlCommand("SELECT msnv FROM Nhanvien, Congviec WHERE congviec = macv AND noidungcv = 'Quan ly'");
                DataTable table1 = employee.getEmployees(command1);
                A[1] = Convert.ToInt32(table1.Rows[0]["msnv"].ToString());
                A[2] = Convert.ToInt32(table1.Rows[0]["msnv"].ToString());
                A[3] = Convert.ToInt32(table1.Rows[1]["msnv"].ToString());
                return A;
            }
            else if (table.Rows.Count == 2)
            {
                SqlCommand command1 = new SqlCommand("SELECT N.msnv, P.maca FROM Nhanvien AS N, Phanca AS P, Congviec AS C " +
                    "WHERE N.msnv = P.msnv AND congviec = C.macv AND noidungcv = 'Quan ly'");
                DataTable table1 = employee.getEmployees(command1);

                for (int i = 0; i < table1.Rows.Count; i++)
                {
                    A[Convert.ToInt32(table1.Rows[i]["maca"].ToString())] = Convert.ToInt32(table1.Rows[i]["msnv"].ToString());
                } 
            }
            else
            {
                SqlCommand command1 = new SqlCommand("SELECT N.msnv, P.maca FROM Nhanvien AS N, Phanca AS P, Congviec AS C " +
                    "WHERE N.msnv = P.msnv AND congviec = C.macv AND noidungcv = 'Quan ly'");
                DataTable table1 = employee.getEmployees(command1);
                SqlCommand command2 = new SqlCommand("SELECT N.msnv, P.maca FROM Nhanvien AS N, Congviec AS C " +
                    "WHERE congviec = C.macv AND noidungcv = 'Quan ly' AND N.msnv not in (SELECT msnv FROM Phanca)");
                DataTable table2 = employee.getEmployees(command2);
                for (int i = 0; i < table1.Rows.Count; i++)
                {
                    A[Convert.ToInt32(table1.Rows[i]["maca"].ToString())] = Convert.ToInt32(table1.Rows[i]["msnv"].ToString());
                }    
                for (int i = 1; i < 4; i++)
                {
                    if (A[i] == 0)
                    {
                        A[i] = Convert.ToInt32(table2.Rows[0]["msnv"].ToString());
                    }    
                }    
            }

            int temp = A[1];
            for (int i = 1; i < 3; i++)
            {
                A[i] = A[i + 1];
            }
            A[3] = temp;

            if (A[1] == A[2])
            {
                temp = A[1];
                A[1] = A[3];
                A[2] = A[3];
                A[3] = temp;
            }
            else if (A[1] == A[3])
            {
                temp = A[1];
                A[1] = A[2];
                A[3] = A[2];
                A[2] = temp;
            }
            else if (A[2] == A[3])
            {
                temp = A[2];
                A[2] = A[1];
                A[3] = A[1];
                A[1] = temp;
            }
            return A;
        }    
    }
}
