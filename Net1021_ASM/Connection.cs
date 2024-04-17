using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Net1021_ASM
{
    internal class Connection
    {
        private static string stringConnection = @"Data Source=DESKTOP-CNGEDRR\MSSQLSERVER01;Initial Catalog=QuanLyThuVien;UID=sa;Password=12345";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
