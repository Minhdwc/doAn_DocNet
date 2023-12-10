using DoAn.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.AdminControllers
{
    public partial class QLNV : UserControl
    {
        public QLNV()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();
        DataTable dt;
        void load_Cbo()
        {
            DataSet ds = new DataSet();
            string chuoiTruyVan = "Select * from ChucVu";
            ds = db.GetDataSet(chuoiTruyVan);
            cboCV.DataSource = ds.Tables[0];
            cboCV.DisplayMember = "TenCV";
            cboCV.ValueMember = "MaCV";
        }
        bool ktTrungNV(string ma)
        {
            string chuoiTruyVan = "SELECT COUNT(*) FROM NhanVien WHERE MaNV = '"+ma+"'";


            int k = (int)db.getScalar(chuoiTruyVan);

            if (k != 0)
                return true;

            return false;
        }
        bool ktTrungTK(string ma)
        {
            string chuoiTruyVan = "Select count(*) from TaiKhoan where MaNV = '" + ma + "'";
            int k = (int)db.getScalar(chuoiTruyVan);
            if (k != 0)
                return true;
            return false;
        }
        void hienThi_DSNV()
        {
            string chuoiTruyVan = "Select NV.MaNV, NV.TenNV, NV.NgaySinh, NV.SDT, TK.MaTK, TK.TenTK, Tk.MatKhau, cv.TenCV from NhanVien NV join TaiKhoan TK on NV.MaNV = TK.MaNV join ChucVu cv on cv.MaCV = NV.MaCV";
            dt = db.getDataTable(chuoiTruyVan);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dataGridView1.Columns["TenNV"].HeaderText = "Tên nhân viên";
            dataGridView1.Columns["NgaySinh"].HeaderText = "NgaySinh";
            dataGridView1.Columns["SDT"].HeaderText = "Số điện thoại";
            dataGridView1.Columns["MaTK"].HeaderText = "Mã tài khoản";
            dataGridView1.Columns["TenTK"].HeaderText = "Tên tài khoản";
            dataGridView1.Columns["MatKhau"].HeaderText = "Mật khẩu";
            dataGridView1.Columns["TenCV"].HeaderText = "Chức vụ";
            foreach(DataRow row in dt.Rows)
            {
                string pass = row["MatKhau"].ToString();
                string hexPass = ChuyenSangHEX(pass);
                row["MatKhau"] = hexPass;
            }
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        private string ChuyenSangHEX(string input)
        {
            StringBuilder hexBuilder = new StringBuilder(input.Length * 2);
            foreach (char c in input)
            {
                hexBuilder.AppendFormat("{0:X2}", (int)c);
            }
            return hexBuilder.ToString();
        }
        private void QLNV_Load(object sender, EventArgs e)
        {
            hienThi_DSNV();
            load_Cbo();
            dtNgaySinhNV.Format = DateTimePickerFormat.Custom;
            dtNgaySinhNV.CustomFormat = "dd/MM/yyyy";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaNV.DataBindings.Clear();
            txtmaNV.DataBindings.Add("Text", dt, "MaNV");
            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", dt, "TenNV");
            txtSDTNV.DataBindings.Clear();
            txtSDTNV.DataBindings.Add("Text", dt, "SDT");
            dtNgaySinhNV.DataBindings.Clear();
            dtNgaySinhNV.DataBindings.Add("Value", dt, "NgaySinh");
            dtNgaySinhNV.Format = DateTimePickerFormat.Custom;
            dtNgaySinhNV.CustomFormat = "dd/MM/yyyy";
            txtMaTK.DataBindings.Clear();
            txtMaTK.DataBindings.Add("Text", dt, "MaTK");
            txtTenTK.DataBindings.Clear();
            txtTenTK.DataBindings.Add("Text", dt, "TenTK");
            txtMK.DataBindings.Clear();
            txtMK.DataBindings.Add("Text", dt, "MatKhau");
            cboCV.DataBindings.Clear();
            cboCV.DataBindings.Add("Text", dt, "TenCV");
        }

        private void bntThemKS_Click(object sender, EventArgs e)
        {
            if(ktTrungNV(txtmaNV.Text))
            {
                MessageBox.Show("Mã nhân viên bị trùng");
            }
            else if(ktTrungTK(txtMaTK.Text))
            {
                MessageBox.Show("Mã tài khoản bị trùng");
            }    
            else if (!ktTrungNV(txtmaNV.Text) && !ktTrungTK(txtMaTK.Text))
            {
                string queryNhanVien = "INSERT INTO NhanVien (MaNV, TenNV, SDT, NgaySinh, MaCV) VALUES (@MaNV, @TenNV, @SDT, @NgaySinh, @MaCV)";
                SqlCommand cmdNhanVien = new SqlCommand(queryNhanVien, db.conn);
                cmdNhanVien.Parameters.AddWithValue("@MaNV", txtmaNV.Text);
                cmdNhanVien.Parameters.AddWithValue("@TenNV", txtTenNV.Text);
                cmdNhanVien.Parameters.AddWithValue("@SDT", txtSDTNV.Text);
                cmdNhanVien.Parameters.AddWithValue("@NgaySinh", dtNgaySinhNV.Value);
                cmdNhanVien.Parameters.AddWithValue("@MaCV", cboCV.SelectedValue);

                string queryTaiKhoan = "INSERT INTO TaiKhoan (MaTK, TenTK, MatKhau, MaNV) VALUES (@MaTK, @TenTK, @MatKhau, @MaNV)";
                SqlCommand cmdTaiKhoan = new SqlCommand(queryTaiKhoan, db.conn);
                cmdTaiKhoan.Parameters.AddWithValue("@MaTK", txtMaTK.Text);
                cmdTaiKhoan.Parameters.AddWithValue("@TenTK", txtTenTK.Text);
                cmdTaiKhoan.Parameters.AddWithValue("@MatKhau", txtMK.Text);
                cmdTaiKhoan.Parameters.AddWithValue("@MaNV", txtmaNV.Text);

                db.Open();

                SqlTransaction transaction = db.conn.BeginTransaction();

                cmdNhanVien.Transaction = transaction;
                cmdTaiKhoan.Transaction = transaction;

                cmdNhanVien.ExecuteNonQuery();
                cmdTaiKhoan.ExecuteNonQuery();

                transaction.Commit();

                MessageBox.Show("Thêm thành công");
                dataGridView1.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
                db.Close();
            }
        }
        bool ktkhoanngoai(string MaNV)
        {
            SqlConnection conn = new SqlConnection(db.strConnect);
            SqlCommand cmd = new SqlCommand("select count(*) from HoaDon where MaNV = @ma", conn);
            cmd.Parameters.AddWithValue("@ma", MaNV);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count > 0;
        }

        private void btnXoaKS_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows.Find(txtmaNV.Text);
            if (ktkhoanngoai(txtmaNV.Text))
            {
                MessageBox.Show("Nhân viên đang có lịch nhận tour.\nKhông thể xóa!!!");
                return;
            }
            string chuoiTruyVanTK = "Select * from TaiKhoan where MaNV = '" + txtmaNV.Text + "'";
            if (dr != null)
                dr.Delete();
            int n = db.updateDataTable(dt, chuoiTruyVanTK);
            if (dr != null)
                dr.Delete();
            string chuoiTruyVanNV = "Select * from NhanVien";
            int k = db.updateDataTable(dt, chuoiTruyVanNV);
                MessageBox.Show("Xóa thành công");

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maNVToEdit = txtmaNV.Text;
            string tenNV = txtTenNV.Text;
            string sdt = txtSDTNV.Text;
            DateTime ngaySinh = dtNgaySinhNV.Value;
            string maTK = txtMaTK.Text;
            string tenTK = txtTenTK.Text;
            string matKhau = txtMK.Text;

            string updateNhanVienQuery = "UPDATE NhanVien SET TenNV = @TenNV, SDT = @SDT, NgaySinh = @NgaySinh WHERE MaNV = @MaNV";
            string updateTaiKhoanQuery = "UPDATE TaiKhoan SET TenTK = @TenTK, MatKhau = @MatKhau WHERE MaNV = @MaNV";

            SqlConnection connection = db.conn;
            SqlCommand cmdUpdateNhanVien = new SqlCommand(updateNhanVienQuery, connection);
            SqlCommand cmdUpdateTaiKhoan = new SqlCommand(updateTaiKhoanQuery, connection);

            cmdUpdateNhanVien.Parameters.AddWithValue("@TenNV", tenNV);
            cmdUpdateNhanVien.Parameters.AddWithValue("@SDT", sdt);
            cmdUpdateNhanVien.Parameters.AddWithValue("@NgaySinh", ngaySinh);
            cmdUpdateNhanVien.Parameters.AddWithValue("@MaNV", maNVToEdit);

            cmdUpdateTaiKhoan.Parameters.AddWithValue("@TenTK", tenTK);
            cmdUpdateTaiKhoan.Parameters.AddWithValue("@MatKhau", matKhau);
            cmdUpdateTaiKhoan.Parameters.AddWithValue("@MaNV", maNVToEdit);

            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();

            cmdUpdateNhanVien.Transaction = transaction;
            cmdUpdateTaiKhoan.Transaction = transaction;

            cmdUpdateNhanVien.ExecuteNonQuery();
            cmdUpdateTaiKhoan.ExecuteNonQuery();

            transaction.Commit();

            MessageBox.Show("Sửa thành công");
            dataGridView1.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";

            connection.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string chuoiTruyVan = "Select NV.MaNV, NV.TenNV, NV.NgaySinh, NV.SDT, TK.MaTK, TK.TenTK, Tk.MatKhau, cv.TenCV from NhanVien NV join TaiKhoan TK on NV.MaNV = TK.MaNV join ChucVu cv on cv.MaCV = NV.MaCV where NV.TenNV Like '%" + txtTimKiem.Text + "%'";
            dt = db.getDataTable(chuoiTruyVan);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dataGridView1.Columns["TenNV"].HeaderText = "Tên nhân viên";
            dataGridView1.Columns["NgaySinh"].HeaderText = "NgaySinh";
            dataGridView1.Columns["SDT"].HeaderText = "Số điện thoại";
            dataGridView1.Columns["MaTK"].HeaderText = "Mã tài khoản";
            dataGridView1.Columns["TenTK"].HeaderText = "Tên tài khoản";
            dataGridView1.Columns["MatKhau"].HeaderText = "Mật khẩu";
            dataGridView1.Columns["TenCV"].HeaderText = "Chức vụ";
            foreach (DataRow row in dt.Rows)
            {
                string pass = row["MatKhau"].ToString();
                string hexPass = ChuyenSangHEX(pass);
                row["MatKhau"] = hexPass;
            }
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }


        private void btnIn_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exported from gridview";
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            int lastColumnIndex = dataGridView1.Columns.Count;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < lastColumnIndex; j++)
                {
                    if (j == lastColumnIndex - 5)
                    {
                        worksheet.Cells[i + 2, j + 1].NumberFormat = "@";
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value?.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value?.ToString();
                    }
                }
            }
            workbook.Close();
            app.Quit();
        }

        bool isDigit(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void txtSDTNV_Leave(object sender, EventArgs e)
        {
            if (!isDigit(txtSDTNV.Text))
            {
                errorProvider1.SetError(txtSDTNV, "Vui lòng nhập số điện thoại hợp lý");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
