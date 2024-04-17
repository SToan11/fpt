using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Net1021_ASM
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }
        public bool checkAccount(string ac)
        {
            return Regex.IsMatch(ac, @"^[a-zA-Z0-9]{6,24}$");
        }

        public bool checkEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail\.com(\.vn)?$");
        }

        Modify modify = new Modify();
        private void btn_dangki_Click(object sender, EventArgs e)
        {
            string tentk = txt_taikhoan.Text;
            string matkhau = txt_matkhau.Text;
            string xacnhanmk = txt_xacnhanmk.Text;
            string email = txt_email.Text;
            if(!checkAccount(tentk)) { MessageBox.Show("Vui lòng nhập tên tài khoản 6-24 kí tự với các kí tự chữ và số, chữ hoa, chữ thường!"); return; }
            if (!checkAccount(matkhau)) { MessageBox.Show("Vui lòng nhập mật khẩu 6-24 kí tự với các kí tự chữ và số, chữ hoa, chữ thường!"); return; }
            if (xacnhanmk != matkhau) { MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác!"); return; }
            if (!checkEmail(email)) { MessageBox.Show("Vui lòng nhập đúng email!"); return; }
            if (modify.TaiKhoans("select * from TaiKhoan where Email = '"+ email +"'").Count != 0) { MessageBox.Show("Email này đã được đăng kí xin vui lòng đăng kí email khác!"); return; }
            try
            {
                string query = "Insert into TaiKhoan values ('" + tentk + "', '" + matkhau + "' , '" + email + "')";
                modify.command(query);
                if (MessageBox.Show("Đăng kí thành công! Ban có muốn đăng nhập luôn không?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==  DialogResult.Yes) ;
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Tên tài khoản đã được đăng kí, vui lòng đăng kí tên khác!");
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {

        }
    }
}
