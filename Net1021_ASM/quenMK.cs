using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Net1021_ASM
{
    public partial class quenMK : Form
    {
        public quenMK()
        {
            InitializeComponent();
            lbl_mk.Text = "";
        }
        Modify modify = new Modify();
        private void btn_laylaimk_Click(object sender, EventArgs e)
        {
            string taikhoan = txt_emaildk.Text;

            if (!string.IsNullOrWhiteSpace(taikhoan))
            {
                try
                {
                    string connectionString = "Data Source=DESKTOP-CNGEDRR\\MSSQLSERVER01;Initial Catalog=QuanLyThuVien;UID=sa;Password=12345"; 
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "SELECT MatKhau FROM TaiKhoan WHERE TaiKhoan = @taikhoan";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@taikhoan", taikhoan);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            lbl_mk.ForeColor = Color.Blue;
                            lbl_mk.Text = "Mật khẩu: " + reader["MatKhau"].ToString();
                        }
                        else
                        {
                            lbl_mk.ForeColor = Color.Red;
                            lbl_mk.Text = "Tài khoản này chưa được đăng kí!";
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên đăng kí!");
            }
        }



        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
