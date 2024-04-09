using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Xml.Linq;
namespace ASM2.database
{
    public partial class Admin : Form
    {
        SqlConnection conn;
        public Admin()
        {
            InitializeComponent();
            createConnection();
        }
        private void createConnection()
        {
            try
            {
                String stringConnection = "Server=DESKTOP-BTIGREQ\\SQLEXPRESS;Database=ASM2; Integrated Security = true";
                conn = new SqlConnection(stringConnection);
                MessageBox.Show(" ket noi csdl thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" co loi xay ra ow createconnection " + ex.Message);
            }

        }
        private void DisplayDataAttendance()
        {

            try
            {
                conn.Open();
                // khia bao lenh
                SqlCommand cmd = conn.CreateCommand();
                // khai bao kieu cau lenh
                cmd.CommandType = System.Data.CommandType.Text;
                // khai noi dung cau lenh
                string sql = "select * from Attendances";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                DataTable data = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(data);
                dgv.DataSource = data;
                MessageBox.Show(" lay du lieu thanh cong!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" co loi xay ra DisplayDataAttendance " + ex.Message);
            }

        }

        private void Attendances_Click(object sender, EventArgs e)
        {
            DisplayDataAttendance();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            SaveAttendance();
        }
        private void SaveAttendance()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                // Lấy dữ liệu từ dòng được chọn
                DataGridViewRow selectedRow = dgv.SelectedRows[0];
                string AccountID = selectedRow.Cells["AccountID"].Value.ToString();
                string ClassID = selectedRow.Cells["ClassID"].Value.ToString();
                DateTime Time = DateTime.Parse(selectedRow.Cells["Time"].Value.ToString());

                // Lấy trạng thái điểm danh từ ComboBox
                string AttendanceStatus = selectedRow.Cells["AttendanceStatus"].Value.ToString();

                // Cập nhật dữ liệu điểm danh vào cơ sở dữ liệu
                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    string sql = "UPDATE Attendances SET AttendanceStatus = @AttendanceStatus WHERE AccountID = @AccountID AND ClassID = @ClassID AND Time = @Time";
                    cmd.CommandText = sql;
                    cmd.Parameters.Add("@AttendanceStatus", SqlDbType.VarChar);
                    cmd.Parameters["@AttendanceStatus"].Value = cbbAttendance.SelectedItem.ToString();

                    cmd.Parameters.Add("@AccountID", SqlDbType.VarChar);
                    cmd.Parameters["@AccountID"].Value = AccountID;

                    cmd.Parameters.Add("@ClassID", SqlDbType.VarChar);
                    cmd.Parameters["@ClassID"].Value = ClassID;

                    cmd.Parameters.Add("@Time", SqlDbType.Date);
                    cmd.Parameters["@Time"].Value = Time;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Điểm danh thành công!");
                    conn.Close();

                    // Sau khi cập nhật dữ liệu, cần hiển thị lại dữ liệu mới trong DataGridView
                    DisplayDataAttendance();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để điểm danh!");
            }

        }
        private void CreateAttendance()
        {
            try
            {
                conn.Open();
                // khai bao lenh
                SqlCommand cmd = conn.CreateCommand();
                // khai bao kieu cau lenh
                cmd.CommandType = System.Data.CommandType.Text;
                // khai noi dung cau lenh
                String sql = " INSERT INTO Attendances( AccountID, ClassID, Time) VALUES ( @AccountID, @ClassID, @Time)";
                // khai bao bien trong sql va gan gia tri cho bien
                cmd.Parameters.Add("@AccountID", SqlDbType.VarChar);
                cmd.Parameters["@AccountID"].Value = tbAccountID.Text.ToString();

                cmd.Parameters.Add("@ClassID", SqlDbType.VarChar);
                cmd.Parameters["@ClassID"].Value = cbbClassID.SelectedItem.ToString();

                cmd.Parameters.Add("@Time", SqlDbType.Date);
                cmd.Parameters["@Time"].Value = DateTime.Now;

                cmd.CommandText = sql;
                // thuc thi cau lenh
                cmd.ExecuteNonQuery();

                MessageBox.Show(" them moi thanh cong");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" co loi xay ra CreateAttendance " + ex.Message);
            }
        }

        private void btnCreateAttendance_Click(object sender, EventArgs e)
        {
            DisplayDataAttendance();
            CreateAttendance();
        }
        private void DeleteAttendance()
        {
            try
            {
                conn.Open();
                // khai bao lenh
                SqlCommand cmd = conn.CreateCommand();
                // khai bao kieu cau lenh
                cmd.CommandType = System.Data.CommandType.Text;
                // khai noi dung cau lenh
                String sql = " DELETE FROM Attendances WHERE AccountID = @AccountID";
                // khai bao bien trong sql va gan gia tri cho bien
                cmd.Parameters.Add("@AccountID", SqlDbType.VarChar);
                cmd.Parameters["@AccountID"].Value = tbDeleteUpdate.Text.ToString();

                cmd.CommandText = sql;
                // thuc thi cau lenh
                cmd.ExecuteNonQuery();
                MessageBox.Show(" xoa thanh cong");
                // thuc thi cau lenh
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" co loi xay ra DeleteAttendance " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String AccountID = tbDeleteUpdate.Text.ToString();
            DialogResult re = MessageBox.Show(" ban co chac muon xoa ban ghi " + AccountID, "Xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                DeleteAttendance();
                DisplayDataAttendance();
            }
        }
        private void UpdateAttendance()
        {
            try
            {
                conn.Open();
                // khai bao lenh
                SqlCommand cmd = conn.CreateCommand();
                // khai bao kieu cau lenh
                cmd.CommandType = System.Data.CommandType.Text;
                string sql = "UPDATE Attendances SET ClassID = @ClassID, Time = @Time WHERE AccountID = @AccountID";
                // khai bao bien trong sql va gan gia tri cho bien

                cmd.Parameters.Add("@AccountID", SqlDbType.VarChar);
                cmd.Parameters["@AccountID"].Value = tbDeleteUpdate.Text.ToString();

                cmd.Parameters.Add("@ClassID", SqlDbType.VarChar);
                cmd.Parameters["@ClassID"].Value = cbbClassID.SelectedItem.ToString();

                cmd.Parameters.Add("@Time", SqlDbType.Date);
                cmd.Parameters["@Time"].Value = DateTime.Now;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                MessageBox.Show("du lieu da duoc cap nhat thanh cong ");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cap nhat du lieu chua thanh cong");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DisplayDataAttendance();
            UpdateAttendance();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void DisplayDataClass()
        {

            try
            {
                conn.Open();
                // khia bao lenh
                SqlCommand cmd = conn.CreateCommand();
                // khai bao kieu cau lenh
                cmd.CommandType = System.Data.CommandType.Text;
                // khai noi dung cau lenh
                string sql = "select * from Classes";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                DataTable data = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(data);
                dgv1.DataSource = data;
                MessageBox.Show(" lay du lieu thanh cong!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" co loi xay ra DisplayDataClass " + ex.Message);
            }

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            DisplayDataClass();
        }
        private void CreateClass()
        {
            try
            {
                conn.Open();
                // khai bao lenh
                SqlCommand cmd = conn.CreateCommand();
                // khai bao kieu cau lenh
                cmd.CommandType = System.Data.CommandType.Text;
                // khai noi dung cau lenh
                String sql = " INSERT INTO Classes( ClassID, ClassName, SubjectID) VALUES ( @ClassID, @ClassName, @SubjectID)";
                // khai bao bien trong sql va gan gia tri cho bien
                cmd.Parameters.Add("@ClassID", SqlDbType.VarChar);
                cmd.Parameters["@ClassID"].Value = tbClassID.Text.ToString();

                cmd.Parameters.Add("@ClassName", SqlDbType.VarChar);
                cmd.Parameters["@ClassName"].Value = tbClassName.Text.ToString();

                cmd.Parameters.Add("@SubjectID", SqlDbType.VarChar);
                cmd.Parameters["@SubjectID"].Value = tbSubjectID.Text.ToString();

                cmd.CommandText = sql;
                // thuc thi cau lenh
                cmd.ExecuteNonQuery();

                MessageBox.Show(" them moi thanh cong");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" co loi xay ra CreateClass " + ex.Message);
            }
        }

        private void btnCreateClass_Click(object sender, EventArgs e)
        {
            DisplayDataClass();
            CreateClass();
        }
        private void DeleteClass()
        {
            try
            {
                conn.Open();
                // khai bao lenh
                SqlCommand cmd = conn.CreateCommand();
                // khai bao kieu cau lenh
                cmd.CommandType = System.Data.CommandType.Text;
                // khai noi dung cau lenh
                String sql = " DELETE FROM Classes WHERE ClassID = @ClassID";
                // khai bao bien trong sql va gan gia tri cho bien
                cmd.Parameters.Add("@ClassID", SqlDbType.VarChar);
                cmd.Parameters["@ClassID"].Value = tbDeleteUpdateClassID.Text.ToString();

                cmd.CommandText = sql;
                // thuc thi cau lenh
                cmd.ExecuteNonQuery();
                MessageBox.Show(" xoa thanh cong");
                // thuc thi cau lenh
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" co loi xay ra DeleteClass " + ex.Message);
            }
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            String ClassID = tbDeleteUpdateClassID.Text.ToString();
            DialogResult re = MessageBox.Show(" ban co chac muon xoa ban ghi " + ClassID, "Xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                DeleteClass();
                DisplayDataClass();
            }
        }
        private void UpdateClass()
        {
            try
            {
                conn.Open();
                // khai bao lenh
                SqlCommand cmd = conn.CreateCommand();
                // khai bao kieu cau lenh
                cmd.CommandType = System.Data.CommandType.Text;
                string sql = "UPDATE Classes SET ClassName = @ClassName, SubjectID = @SubjectID WHERE ClassID = @ClassID";
                // khai bao bien trong sql va gan gia tri cho bien

                cmd.Parameters.Add("@ClassID", SqlDbType.VarChar);
                cmd.Parameters["@ClassID"].Value = tbDeleteUpdateClassID.Text.ToString();

                cmd.Parameters.Add("@ClassName", SqlDbType.VarChar);
                cmd.Parameters["@ClassName"].Value = tbClassName.Text.ToString();

                cmd.Parameters.Add("@SubjectID", SqlDbType.VarChar);
                cmd.Parameters["@SubjectID"].Value = tbSubjectID.Text.ToString();

                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                MessageBox.Show("du lieu da duoc cap nhat thanh cong ");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cap nhat du lieu chua thanh cong");
            }
        }

        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            DisplayDataClass() ;
            UpdateClass();
        }
    }
}
