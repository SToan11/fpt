using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net1021_ASM
{
    public class TaiKhoan
    {
        private string taiKhoan;
        private string matKhau;

        public TaiKhoan()
        {
        }

        public TaiKhoan(string taiKhoan, string matKhau)
        {
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
        }

        public string TenTaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
    }
}
