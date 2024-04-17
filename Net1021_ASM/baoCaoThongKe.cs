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
    public partial class baoCaoThongKe : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "Data Source=DESKTOP-CNGEDRR\\MSSQLSERVER01;Initial Catalog=QuanLyThuVien;UID=sa;Password=12345";
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public baoCaoThongKe()
        {
            InitializeComponent();
        }

        private void baoCaoThongKe_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            
        }

        //private void loadBaoCao()
        //{
        //    try
        //    {
        //        conn.Open();
        //        cmd = conn.CreateCommand();
        //        cmd.CommandText = "select * from ChiTietPhieuMuon";
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        dt.Clear();
        //        da.Fill(dt);
        //        dgv_baocao.DataSource = dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}

        private void btn_tim_Click(object sender, EventArgs e)
        {
            dt.Clear();
            if (cbo_timkiem.Text == "Số lượng sách")
            {
                soluongsach();
            } else if (cbo_timkiem.Text == "Số lượng mượn")
            {
                soluotmuon();
            } else if ( cbo_timkiem.Text == "Thể loại")
            {
                theloai();
            } else if (cbo_timkiem.Text == "Sách")
            {
                sach();
            }
        }
        private void soluongsach()
        {
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select count(Tensach) as SoLuongSach from sach";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_baocao.DataSource = dt;
            conn.Close();
        }
        private void soluotmuon()
        {
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select count(TrangThaiTra) as SoluotMuon from PhieuMuon";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_baocao.DataSource = dt;
            conn.Close();
        }

        private void theloai()
        {
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select TenTheLoai from TheLoai";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_baocao.DataSource = dt;
            conn.Close();
        }

        private void sach()
        {
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select TenSach from Sach";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_baocao.DataSource = dt;
            conn.Close();
        }

        private void lammoi()
        {
            //loadBaoCao();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            dt.Clear();
        }
    }
}
