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
namespace ASM2.database
{
    public partial class User : Form
    {
        SqlConnection conn;
        public User()
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
        private void User_Load(object sender, EventArgs e)
        {
            DisplayDataAttendance();
        }
        private void SearchStudentAttendance(string accountID)
        {

         try
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "SELECT ClassID, AccountID, Time, AttendanceStatus FROM Attendances WHERE AccountID = @AccountID";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@AccountID", SqlDbType.VarChar);
                cmd.Parameters["@AccountID"].Value = accountID;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Đọc thông tin điểm danh của sinh viên từ dữ liệu đọc được
                    string accountIDResult = reader["AccountID"].ToString();
                    string classID = reader["ClassID"].ToString();
                    DateTime time = Convert.ToDateTime(reader["Time"]);
                    string attendanceStatus = reader["AttendanceStatus"].ToString();

                    MessageBox.Show("AccountID: " + accountIDResult + "\nClassID: " + classID + "\nTime: " + time.ToString() + "\nAttendance Status: " + attendanceStatus);
                }

                    conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy thông tin điểm danh của sinh viên theo AccountID: " + ex.Message);
            }
        }  
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string accountID = tbAccountID.Text;
            SearchStudentAttendance(accountID);
            DisplayDataAttendance();
        }
    
    }
}
