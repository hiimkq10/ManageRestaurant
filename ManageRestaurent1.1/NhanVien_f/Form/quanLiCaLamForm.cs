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
    class quanLiCaLamForm : Form
    {
        private ComboBox comboBoxMsnv;
        private Label label11;
        private Label label9;
        private TextBox textBoxLName;
        private TextBox textBoxFname;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxCa;
        private Label label1;
        private Label label4;
        private GroupBox groupBox1;
        private Button buttonCheck;
        private GroupBox groupBox3;
        private RadioButton radioButtonVang;
        private RadioButton radioButtonWorking;
        private RadioButton radioButtonAll;
        private GroupBox groupBox2;
        private RadioButton radioButtonCa3;
        private RadioButton radioButtonCa2;
        private RadioButton radioButtonCa1;
        private RadioButton radioButtonAllNV;
        private TextBox textBoxNVLamThay;
        private Button buttonCancle;
        private Button buttonEdit;
        private Label labelTotalEmployee;
        private DataGridView dataGridViewEmployeeList;

        public quanLiCaLamForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dataGridViewEmployeeList = new System.Windows.Forms.DataGridView();
            this.comboBoxMsnv = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonVang = new System.Windows.Forms.RadioButton();
            this.radioButtonWorking = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonCa3 = new System.Windows.Forms.RadioButton();
            this.radioButtonCa2 = new System.Windows.Forms.RadioButton();
            this.radioButtonCa1 = new System.Windows.Forms.RadioButton();
            this.radioButtonAllNV = new System.Windows.Forms.RadioButton();
            this.textBoxNVLamThay = new System.Windows.Forms.TextBox();
            this.buttonCancle = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelTotalEmployee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewEmployeeList
            // 
            this.dataGridViewEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeList.Location = new System.Drawing.Point(415, 82);
            this.dataGridViewEmployeeList.Name = "dataGridViewEmployeeList";
            this.dataGridViewEmployeeList.RowHeadersWidth = 51;
            this.dataGridViewEmployeeList.RowTemplate.Height = 24;
            this.dataGridViewEmployeeList.Size = new System.Drawing.Size(579, 397);
            this.dataGridViewEmployeeList.TabIndex = 0;
            // 
            // comboBoxMsnv
            // 
            this.comboBoxMsnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMsnv.FormattingEnabled = true;
            this.comboBoxMsnv.Location = new System.Drawing.Point(177, 114);
            this.comboBoxMsnv.Name = "comboBoxMsnv";
            this.comboBoxMsnv.Size = new System.Drawing.Size(133, 28);
            this.comboBoxMsnv.TabIndex = 79;
            this.comboBoxMsnv.SelectedIndexChanged += new System.EventHandler(this.comboBoxMsnv_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 20);
            this.label11.TabIndex = 78;
            this.label11.Text = "ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(291, 32);
            this.label9.TabIndex = 77;
            this.label9.Text = "Employee Information";
            // 
            // textBoxLName
            // 
            this.textBoxLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLName.Location = new System.Drawing.Point(177, 215);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(234, 27);
            this.textBoxLName.TabIndex = 76;
            // 
            // textBoxFname
            // 
            this.textBoxFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFname.Location = new System.Drawing.Point(177, 164);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(234, 27);
            this.textBoxFname.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "First Name:";
            // 
            // comboBoxCa
            // 
            this.comboBoxCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCa.FormattingEnabled = true;
            this.comboBoxCa.Location = new System.Drawing.Point(177, 265);
            this.comboBoxCa.Name = "comboBoxCa";
            this.comboBoxCa.Size = new System.Drawing.Size(133, 28);
            this.comboBoxCa.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 80;
            this.label1.Text = "Ca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 82;
            this.label4.Text = "ID NV Lam Thay:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCheck);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(415, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 74);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(496, 10);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 58);
            this.buttonCheck.TabIndex = 3;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonVang);
            this.groupBox3.Controls.Add(this.radioButtonWorking);
            this.groupBox3.Controls.Add(this.radioButtonAll);
            this.groupBox3.Location = new System.Drawing.Point(271, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 47);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // radioButtonVang
            // 
            this.radioButtonVang.AutoSize = true;
            this.radioButtonVang.Location = new System.Drawing.Point(153, 13);
            this.radioButtonVang.Name = "radioButtonVang";
            this.radioButtonVang.Size = new System.Drawing.Size(62, 21);
            this.radioButtonVang.TabIndex = 2;
            this.radioButtonVang.TabStop = true;
            this.radioButtonVang.Text = "Vang";
            this.radioButtonVang.UseVisualStyleBackColor = true;
            // 
            // radioButtonWorking
            // 
            this.radioButtonWorking.AutoSize = true;
            this.radioButtonWorking.Location = new System.Drawing.Point(66, 13);
            this.radioButtonWorking.Name = "radioButtonWorking";
            this.radioButtonWorking.Size = new System.Drawing.Size(81, 21);
            this.radioButtonWorking.TabIndex = 1;
            this.radioButtonWorking.TabStop = true;
            this.radioButtonWorking.Text = "Working";
            this.radioButtonWorking.UseVisualStyleBackColor = true;
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Checked = true;
            this.radioButtonAll.Location = new System.Drawing.Point(6, 13);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(54, 21);
            this.radioButtonAll.TabIndex = 0;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "ALL";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonCa3);
            this.groupBox2.Controls.Add(this.radioButtonCa2);
            this.groupBox2.Controls.Add(this.radioButtonCa1);
            this.groupBox2.Controls.Add(this.radioButtonAllNV);
            this.groupBox2.Location = new System.Drawing.Point(6, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 47);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // radioButtonCa3
            // 
            this.radioButtonCa3.AutoSize = true;
            this.radioButtonCa3.Location = new System.Drawing.Point(196, 13);
            this.radioButtonCa3.Name = "radioButtonCa3";
            this.radioButtonCa3.Size = new System.Drawing.Size(59, 21);
            this.radioButtonCa3.TabIndex = 3;
            this.radioButtonCa3.TabStop = true;
            this.radioButtonCa3.Text = "CA 3";
            this.radioButtonCa3.UseVisualStyleBackColor = true;
            // 
            // radioButtonCa2
            // 
            this.radioButtonCa2.AutoSize = true;
            this.radioButtonCa2.Location = new System.Drawing.Point(131, 13);
            this.radioButtonCa2.Name = "radioButtonCa2";
            this.radioButtonCa2.Size = new System.Drawing.Size(59, 21);
            this.radioButtonCa2.TabIndex = 2;
            this.radioButtonCa2.TabStop = true;
            this.radioButtonCa2.Text = "CA 2";
            this.radioButtonCa2.UseVisualStyleBackColor = true;
            // 
            // radioButtonCa1
            // 
            this.radioButtonCa1.AutoSize = true;
            this.radioButtonCa1.Location = new System.Drawing.Point(66, 13);
            this.radioButtonCa1.Name = "radioButtonCa1";
            this.radioButtonCa1.Size = new System.Drawing.Size(59, 21);
            this.radioButtonCa1.TabIndex = 1;
            this.radioButtonCa1.TabStop = true;
            this.radioButtonCa1.Text = "CA 1";
            this.radioButtonCa1.UseVisualStyleBackColor = true;
            // 
            // radioButtonAllNV
            // 
            this.radioButtonAllNV.AutoSize = true;
            this.radioButtonAllNV.Checked = true;
            this.radioButtonAllNV.Location = new System.Drawing.Point(6, 13);
            this.radioButtonAllNV.Name = "radioButtonAllNV";
            this.radioButtonAllNV.Size = new System.Drawing.Size(54, 21);
            this.radioButtonAllNV.TabIndex = 0;
            this.radioButtonAllNV.TabStop = true;
            this.radioButtonAllNV.Text = "ALL";
            this.radioButtonAllNV.UseVisualStyleBackColor = true;
            // 
            // textBoxNVLamThay
            // 
            this.textBoxNVLamThay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNVLamThay.Location = new System.Drawing.Point(177, 323);
            this.textBoxNVLamThay.Name = "textBoxNVLamThay";
            this.textBoxNVLamThay.Size = new System.Drawing.Size(133, 27);
            this.textBoxNVLamThay.TabIndex = 85;
            // 
            // buttonCancle
            // 
            this.buttonCancle.Location = new System.Drawing.Point(27, 401);
            this.buttonCancle.Name = "buttonCancle";
            this.buttonCancle.Size = new System.Drawing.Size(137, 50);
            this.buttonCancle.TabIndex = 86;
            this.buttonCancle.Text = "Cancle";
            this.buttonCancle.UseVisualStyleBackColor = true;
            this.buttonCancle.Click += new System.EventHandler(this.buttonCancle_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(219, 401);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(137, 50);
            this.buttonEdit.TabIndex = 87;
            this.buttonEdit.Text = "Edit NV Lam Thay";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelTotalEmployee
            // 
            this.labelTotalEmployee.AutoSize = true;
            this.labelTotalEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalEmployee.Location = new System.Drawing.Point(811, 487);
            this.labelTotalEmployee.Name = "labelTotalEmployee";
            this.labelTotalEmployee.Size = new System.Drawing.Size(115, 18);
            this.labelTotalEmployee.TabIndex = 88;
            this.labelTotalEmployee.Text = "Total Employee:";
            // 
            // quanLiCaLamForm
            // 
            this.ClientSize = new System.Drawing.Size(997, 513);
            this.Controls.Add(this.labelTotalEmployee);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonCancle);
            this.Controls.Add(this.textBoxNVLamThay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxCa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMsnv);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxFname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewEmployeeList);
            this.Name = "quanLiCaLamForm";
            this.Text = "Quan Li Ca Lam";
            this.Load += new System.EventHandler(this.quanLiCaLamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        Employee employee = new Employee();
        Ca ca = new Ca();
        PhanCa phanCa = new PhanCa();

        private void quanLiCaLamForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Nhanvien");
            comboBoxMsnv.DataSource = employee.getEmployees(command);
            comboBoxMsnv.ValueMember = "msnv";
            comboBoxMsnv.DisplayMember = "msnv";
            SqlCommand command1 = new SqlCommand("SELECT * FROM Nhanvien");
            fillGrid(command1);
            SqlCommand command3 = new SqlCommand("SELECT * FROM Ca");
            comboBoxCa.DataSource = ca.getCa(command3);
            comboBoxCa.ValueMember = "maca";
            comboBoxCa.DisplayMember = "description";
        }

        public void fillGrid(SqlCommand command)
        {
            dataGridViewEmployeeList.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewEmployeeList.RowTemplate.Height = 80;
            dataGridViewEmployeeList.DataSource = employee.getEmployees(command);
            picCol = (DataGridViewImageColumn)dataGridViewEmployeeList.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewEmployeeList.AllowUserToAddRows = false;
            dataGridViewEmployeeList.Show();
            labelTotalEmployee.Text = ("Total Employee: " + dataGridViewEmployeeList.Rows.Count);
        }

        private void comboBoxMsnv_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int msnv = (int)comboBoxMsnv.SelectedValue;
                DataTable table = employee.getEmployeeByMsnv(msnv);
                textBoxFname.Text = table.Rows[0]["fname"].ToString();
                textBoxLName.Text = table.Rows[0]["lname"].ToString();
                SqlCommand command = new SqlCommand("SELECT P.maca, C.description, P.nvlamthay FROM Phanca AS P, ca AS C" +
                    " WHERE P.maca = C.maca AND P.msnv = @msnv");
                command.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
                DataTable table1 = phanCa.getPhanCa(command);
                comboBoxCa.DataSource = table1;
                comboBoxCa.ValueMember = "maca";
                comboBoxCa.DisplayMember = "description";
                textBoxNVLamThay.Text = table1.Rows[0]["nvlamthay"].ToString();
            }
            catch
            {

            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            if (radioButtonAll.Checked)
            {
                if (radioButtonAllNV.Checked)
                {
                    command = new SqlCommand("SELECT * FROM Nhanvien WHERE msnv IN (SELECT DISTINCT msnv FROM Phanca)");
                }
                else if (radioButtonCa1.Checked)
                {
                    command = new SqlCommand("SELECT N.msnv, fname, lname, birthdate, gender, phone, address, picture" +
                        " FROM Nhanvien AS N, Phanca AS P, Ca AS C WHERE N.msnv = P.msnv AND P.maca = C.maca AND C.description = @ca");
                    command.Parameters.Add("@ca", SqlDbType.VarChar).Value = "Ca 1";
                }
                else if (radioButtonCa2.Checked)
                {
                    command = new SqlCommand("SELECT N.msnv, fname, lname, birthdate, gender, phone, address, picture" +
                        " FROM Nhanvien AS N, Phanca AS P, Ca AS C WHERE N.msnv = P.msnv AND P.maca = C.maca AND C.description = @ca");
                    command.Parameters.Add("@ca", SqlDbType.VarChar).Value = "Ca 2";
                }
                else if (radioButtonCa3.Checked)
                {
                    command = new SqlCommand("SELECT N.msnv, fname, lname, birthdate, gender, phone, address, picture" +
                        " FROM Nhanvien AS N, Phanca AS P, Ca AS C WHERE N.msnv = P.msnv AND P.maca = C.maca AND C.description = @ca");
                    command.Parameters.Add("@ca", SqlDbType.VarChar).Value = "Ca 3";
                }
            }
            else
            {
                if (radioButtonWorking.Checked)
                {
                    if (radioButtonAllNV.Checked)
                    {
                        command = new SqlCommand("SELECT * FROM Nhanvien AS N WHERE msnv IN (SELECT msnv FROM DiemDanh AS D WHERE stt = (SELECT MAX(stt) FROM Diemdanh AS D1 WHERE D.msnv = D1.msnv) AND D.checkout IS NULL)");
                    }
                    else if (radioButtonCa1.Checked)
                    {
                        command = new SqlCommand("SELECT * FROM Nhanvien AS N WHERE msnv IN (SELECT msnv FROM DiemDanh AS D" +
                            " WHERE stt = (SELECT MAX(stt) FROM DiemDanh AS D1 WHERE D.msnv = D1.msnv) AND checkout IS null) " +
                            " AND msnv in (SELECT msnv FROM Phanca AS P, Ca AS C WHERE P.maca = C.maca AND C.description = @ca)");
                        command.Parameters.Add("@ca", SqlDbType.VarChar).Value = "Ca 1";
                    }
                    else if (radioButtonCa2.Checked)
                    {
                        command = new SqlCommand("SELECT * FROM Nhanvien AS N WHERE msnv IN (SELECT msnv FROM DiemDanh AS D" +
                            " WHERE stt = (SELECT MAX(stt) FROM DiemDanh AS D1 WHERE D.msnv = D1.msnv) AND checkout IS null) " +
                            " AND msnv in (SELECT msnv FROM Phanca AS P, Ca AS C WHERE P.maca = C.maca AND C.description = @ca)");
                        command.Parameters.Add("@ca", SqlDbType.VarChar).Value = "Ca 2";
                    }
                    else if (radioButtonCa3.Checked)
                    {
                        command = new SqlCommand("SELECT * FROM Nhanvien AS N WHERE msnv IN (SELECT msnv FROM DiemDanh AS D" +
                            " WHERE stt = (SELECT MAX(stt) FROM DiemDanh AS D1 WHERE D.msnv = D1.msnv) AND checkout IS null) " +
                            " AND msnv in (SELECT msnv FROM Phanca AS P, Ca AS C WHERE P.maca = C.maca AND C.description = @ca)");
                        command.Parameters.Add("@ca", SqlDbType.VarChar).Value = "Ca 3";
                    }
                }   
                else
                {
                    if (radioButtonAllNV.Checked)
                    {
                        command = new SqlCommand("SELECT * FROM Nhanvien AS N WHERE msnv NOT IN (SELECT msnv FROM DiemDanh AS D" +
                            " WHERE stt = (SELECT MAX(stt) FROM DiemDanh AS D1 WHERE D.msnv = D1.msnv) AND checkout IS null)");
                    }
                    else if (radioButtonCa1.Checked)
                    {
                        command = new SqlCommand("SELECT * FROM Nhanvien AS N WHERE msnv NOT IN (SELECT msnv FROM DiemDanh AS D" +
                            " WHERE stt = (SELECT MAX(stt) FROM DiemDanh AS D1 WHERE D.msnv = D1.msnv) AND checkout IS null) " +
                            " AND msnv in (SELECT msnv FROM Phanca AS P, Ca AS C WHERE P.maca = C.maca AND C.description = @ca)");
                        command.Parameters.Add("@ca", SqlDbType.VarChar).Value = "Ca 1";
                    }
                    else if (radioButtonCa2.Checked)
                    {
                        command = new SqlCommand("SELECT * FROM Nhanvien AS N WHERE msnv NOT IN (SELECT msnv FROM DiemDanh AS D" +
                            " WHERE stt = (SELECT MAX(stt) FROM DiemDanh AS D1 WHERE D.msnv = D1.msnv) AND checkout IS null) " +
                            " AND msnv in (SELECT msnv FROM Phanca AS P, Ca AS C WHERE P.maca = C.maca AND C.description = @ca)");
                        command.Parameters.Add("@ca", SqlDbType.VarChar).Value = "Ca 2";
                    }
                    else if (radioButtonCa3.Checked)
                    {
                        command = new SqlCommand("SELECT * FROM Nhanvien AS N WHERE msnv NOT IN (SELECT msnv FROM DiemDanh AS D" +
                            " WHERE stt = (SELECT MAX(stt) FROM DiemDanh AS D1 WHERE D.msnv = D1.msnv) AND checkout IS null) " +
                            " AND msnv in (SELECT msnv FROM Phanca AS P, Ca AS C WHERE P.maca = C.maca AND C.description = @ca)");
                        command.Parameters.Add("@ca", SqlDbType.VarChar).Value = "Ca 3";
                    }
                }    
            }
            fillGrid(command);
        }

        private void buttonCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int msnv = (int)comboBoxMsnv.SelectedValue;
            int maca = (int)comboBoxCa.SelectedValue;
            string msnvlt = textBoxNVLamThay.Text;
            if (Convert.ToInt32(msnvlt) == msnv)
            {
                MessageBox.Show("Invalid nvlamthay id", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (msnvlt.Trim() == "")
            {
                if (MessageBox.Show("Are you sure you want to edit this employee info", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (phanCa.updatePhanCa(msnv, msnvlt, maca))
                    {
                        MessageBox.Show("Edited", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Not edited", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to edit this employee info", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (employee.checkMsnvlt(msnv, Convert.ToInt32(msnvlt), maca))
                    {
                        if (phanCa.updatePhanCa(msnv, msnvlt, maca))
                        {
                            MessageBox.Show("Edited", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Not edited", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhan vien lam thay khong ton tai hoac khong phu hop", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
