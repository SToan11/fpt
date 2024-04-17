using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Net1021_ASM
{
    internal class Modify
    {
        public Modify() { }
        SqlCommand sqlCommand; //dung de truy van cac cau lenh insert, update, dele,....
        SqlDataReader dataReader; //dung de doc du lieu trong bang

        public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    if (!dataReader.IsDBNull(0))
                    {
                        int id;
                        // Thử chuyển đổi giá trị từ cột thành kiểu int
                        if (int.TryParse(dataReader.GetValue(0).ToString(), out id))
                        {
                            // Chuyển đổi thành công, thêm vào danh sách
                            string matKhau = dataReader.GetString(1); // Lấy giá trị từ cột MatKhau
                            taiKhoans.Add(new TaiKhoan(id.ToString(), matKhau));
                        }
                    }
                }
                sqlConnection.Close();
            }

            return taiKhoans; // Trả về danh sách tài khoản
        }

        public void command (string query) // dung de dang ki tai khoan
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand (query, sqlConnection);
                sqlCommand.ExecuteNonQuery(); // thuc thi cau truy van


                sqlConnection.Close();
            }
        }
        public string LayVaiTro(string query)
        {
            string vaiTro = null;

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);

                // Sử dụng ExecuteScalar để lấy giá trị của cột VaiTro từ kết quả truy vấn
                object result = sqlCommand.ExecuteScalar();

                // Kiểm tra nếu kết quả trả về là null thì không làm gì cả
                if (result != null)
                {
                    vaiTro = result.ToString();
                }

                sqlConnection.Close();
            }

            return vaiTro; // Trả về vai trò
        }

    }
}
