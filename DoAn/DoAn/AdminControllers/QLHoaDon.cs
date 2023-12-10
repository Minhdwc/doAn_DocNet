using DoAn.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.AdminControllers
{
    public partial class QLHoaDon : UserControl
    {
        public QLHoaDon()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();
        DataTable dt;
        void hienthiDSHD()
        {
            string chuoiTruyVan = "Select MaHD, Tours.TenTour, NhanVien.TenNV, KhachHang.TenKH, NgayLap, ThanhTien from HoaDon join KhachHang on KhachHang.MaKH = HoaDon.MaKH join NhanVien on HoaDon.MaNV = NhanVien.MaNV join Tours on HoaDon.MaTour = Tours.MaTour";
            dt = db.getDataTable(chuoiTruyVan);
            DataColumn[] key = new DataColumn[1];
            dt.PrimaryKey = new DataColumn[] { dt.Columns["MaHD"]};
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["MaHD"].HeaderText = "Mã hóa đơn";
            dataGridView1.Columns["TenTour"].HeaderText = "Tên Tour";
            dataGridView1.Columns["TenNV"].HeaderText = "Tên nhân viên";
            dataGridView1.Columns["TenKH"].HeaderText = "TenKH";
            dataGridView1.Columns["NgayLap"].HeaderText = "Ngày lập";
            dataGridView1.Columns["ThanhTien"].HeaderText = "Thành tiền";
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        void load_CboTenTour()
        {
            DataSet ds = new DataSet();
            string chuoiTruyVan = "Select * from Tours";
            ds = db.GetDataSet(chuoiTruyVan);
            cboTenTour.DataSource = ds.Tables[0];
            cboTenTour.DisplayMember = "TenTour";
            cboTenTour.ValueMember = "MaTour";
        }
        void load_CboTenKhachHang()
        {
            DataSet ds = new DataSet();
            string chuoiTruyVan = "Select * from KhachHang";
            ds = db.GetDataSet(chuoiTruyVan);
            cboTenKH.DataSource = ds.Tables[0];
            cboTenKH.DisplayMember = "TenKH";
            cboTenKH.ValueMember = "MaKH";
        }
        void load_CboTenNV()
        {
            DataSet ds = new DataSet();
            string chuoiTruyVan = "Select * from NhanVien";
            ds = db.GetDataSet(chuoiTruyVan);
            cboTenNV.DataSource = ds.Tables[0];
            cboTenNV.DisplayMember = "TenNV";
            cboTenNV.ValueMember = "MaNV";
        }
        void databindding(DataTable dt)
        {
            NumThanhTien.Minimum = 0;
            NumThanhTien.Maximum = 1000000000000000;
            txtMaHD.DataBindings.Clear();
            cboTenTour.DataBindings.Clear();
            cboTenKH.DataBindings.Clear();
            cboTenNV.DataBindings.Clear();
            NumThanhTien.DataBindings.Clear();
            dtNgayLap.DataBindings.Clear();

            txtMaHD.DataBindings.Add("Text", dt, "MaHD");
            cboTenKH.DataBindings.Add("Text", dt, "TenKH");
            cboTenNV.DataBindings.Add("Text", dt, "TenNV");
            cboTenTour.DataBindings.Add("Text", dt, "TenTour");
            dtNgayLap.DataBindings.Add("Value", dt, "NgayLap");
            NumThanhTien.DataBindings.Add("Value", dt, "ThanhTien");
            dtNgayLap.Format = DateTimePickerFormat.Custom;
            dtNgayLap.CustomFormat = "dd/MM/yyyy";
        }
        private void QLHoaDon_Load(object sender, EventArgs e)
        {
            hienthiDSHD();
            load_CboTenKhachHang();
            load_CboTenTour();
            load_CboTenNV();
            databindding(dt);
            dtNgayLap.Format = DateTimePickerFormat.Custom;
            dtNgayLap.CustomFormat = "dd/MM/yyyy";
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            string mahd = dataGridView1.SelectedRows[0].Cells["MaHD"].Value.ToString();
            DataRow dr = dt.Rows.Find(mahd);
            if (dr != null)
            {
                dr.Delete();
            }
            string chuoiTruyVanXoa = "DELETE FROM HoaDon WHERE MaHD = @mahd";
            SqlConnection con = new SqlConnection(db.strConnect);
            con.Open();
            SqlCommand command = new SqlCommand(chuoiTruyVanXoa, con);
            command.Parameters.AddWithValue("@mahd", mahd);
            int ret = command.ExecuteNonQuery();
            con.Close();

            if (ret > 0)
            {
                MessageBox.Show("Xóa thành công!");
                hienthiDSHD();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            List<Tours> ls = db.getTours();
            List<KhachHang> lskh = db.getKhachHang();
            List<NhanVien> lsnv = db.getNhanVien();
            string manv = "";
            string matour = "";
            string makh = "";

            string tennv = cboTenNV.Text;
            foreach (var item in lsnv)
            {
                if (item.tennv == tennv)
                {
                    manv = item.manv;
                    break;
                }
            }

            string tentour = cboTenTour.Text;
            foreach(var item in ls)
            {
                if (item.tentour == tentour)
                {
                    matour = item.matour;
                    break;
                }
            }

            string tenkh = cboTenKH.Text;
            foreach (var item in lskh)
            {
                if (item.TenKH == tenkh)
                {
                    makh = item.MaKH;
                    break;
                }
            }

            SqlConnection con = new SqlConnection(db.strConnect);
            con.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO HoaDon (MaHD, MaTour, MaNV, MaKh, NgayLap) VALUES (@mahd, @matour, @manv, @makh, @ngaylap)";
            command.Connection = con;

            command.Parameters.Add("@mahd", SqlDbType.VarChar).Value = txtMaHD.Text;
            command.Parameters.Add("@matour",SqlDbType.VarChar).Value = matour.TrimEnd();
            command.Parameters.Add("@manv", SqlDbType.VarChar).Value = manv.TrimEnd();
            command.Parameters.Add("@makh", SqlDbType.VarChar).Value = makh.TrimEnd();
            command.Parameters.Add("@ngaylap", SqlDbType.NVarChar).Value = dtNgayLap.Value;

            int ret = command.ExecuteNonQuery();

            if (ret > 0)
            {
                MessageBox.Show("Thêm thành công!");
                hienthiDSHD();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
            con.Close();
        }


        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            List<Tours> ls = db.getTours();
            List<KhachHang> lskh = db.getKhachHang();
            List<NhanVien> lsnv = db.getNhanVien();
            string manv = "";
            string maloi = "";
            string makh = "";
            string tennv = cboTenNV.Text;
            foreach(var item in lsnv)
            {
                if(item.tennv == tennv)
                    manv = item.manv;
            }
            string tenkh = cboTenKH.Text;
            foreach(var item in lskh)
            {
                if(item.TenKH ==  tenkh)
                {
                    makh = item.MaKH;
                }
            }
            string tenloi = cboTenTour.Text;
            foreach (var item in ls)
            {
                if (item.tentour == tenloi)
                {
                    maloi = item.matour;
                }
            }

            SqlConnection con = new SqlConnection(db.strConnect);
            con.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Update HoaDon set MaTour = @ten, MaNV = @tenNV, MaKh = @tenkh, NgayLap = @ngaylap where MaHD = @ma";
            command.Connection = con;

            command.Parameters.Add("@ma", SqlDbType.VarChar).Value = txtMaHD.Text;
            command.Parameters.Add("@ten", SqlDbType.VarChar).Value = maloi.TrimEnd();
            command.Parameters.Add("@tenNV", SqlDbType.VarChar).Value = manv.TrimEnd();
            command.Parameters.Add("@tenkh", SqlDbType.VarChar).Value = makh.TrimEnd();
            command.Parameters.Add("@ngaylap", SqlDbType.NVarChar).Value = dtNgayLap.Value;



            int ret = command.ExecuteNonQuery();

            if (ret > 0)
            {
                MessageBox.Show("Sửa thành công!");
                hienthiDSHD();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            databindding(dt);
        }

        
    }
}
