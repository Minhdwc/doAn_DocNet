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
using DoAn.Models;

namespace DoAn.AdminControllers
{
    public partial class QLKH : UserControl
    {
        public QLKH()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();
        DataTable dt;
        bool ktTrung(string ma)
        {
            string chuoiTruyVan = "Select count(*) from KhachHang where MaKH = '" + ma + "'";
            int k = (int)db.getScalar(chuoiTruyVan);
            if (k != 0)
                return true;
            return false;
        }
        void hienThi_DSKH()
        {
            string chuoiTruyVan = "Select kh.*, hd.ThanhTien from KhachHang kh join HoaDon hd on kh.MaKH = hd.MaKH";
            dt = db.getDataTable(chuoiTruyVan);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["MaKH"].HeaderText = "Mã khách hàng";
            dataGridView1.Columns["TenKH"].HeaderText = "Tên khách hàng";
            dataGridView1.Columns["SDT"].HeaderText = "Số điện thoại";
            dataGridView1.Columns["GioiTinh"].HeaderText = "Giới tính";
            dataGridView1.Columns["SoVe"].HeaderText = "Số vé";
            dataGridView1.Columns["ThanhTien"].HeaderText = "Thành tiền";
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        private void QLUser_Load(object sender, EventArgs e)
        {
            hienThi_DSKH();
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            if (!ktTrung(txtMaKH.Text))
            {
                string gt = "";
                DataRow dr = dt.NewRow();
                dr["MaKH"] = txtMaKH.Text;
                dr["TenKH"] = txtTenKH.Text;
                dr["SDT"] = txtSDT.Text;
                if (rdioNam.Checked)
                    gt += "Nam";
                else
                    gt += "Nữ";
                dr["GioiTinh"] = gt;
                dr["SoVe"] = NumSoVe.Value;

                dt.Rows.Add(dr);

                string chuoiTruyVan = "Select * from KhachHang";
                int k = db.updateDataTable(dt, chuoiTruyVan);
                if (k != 0)
                {
                    MessageBox.Show("Thêm thành công");
                }    
                else
                    MessageBox.Show("Thêm thất bại");
            }
            else
                MessageBox.Show("Mã khách hàng đã tồn tại");
        }

        bool ktkhoanngoai(string MaKH)
        {
            SqlConnection conn = new SqlConnection(db.strConnect);
            SqlCommand cmd = new SqlCommand("select count(*) from HoaDon where MaKH = @ma", conn);
            cmd.Parameters.AddWithValue("@ma", MaKH);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count > 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows.Find(txtMaKH.Text);
            if(ktkhoanngoai(txtMaKH.Text))
            {
                MessageBox.Show("Khách hàng vẫn còn tồn tại trong hóa đơn nên không thể xóa");
                return;
            }
            if(dr!= null)
                dr.Delete();
            string chuoiTruyVan = "Select * from KhachHang";
            int k = db.updateDataTable(dt, chuoiTruyVan);
            if (k != 0)
            {
                MessageBox.Show("Xóa thành công");
                hienThi_DSKH();
            }    
            else
                MessageBox.Show("Xóa thất bại");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows.Find(txtMaKH.Text);
            string gt = "";

            if (dr != null)
            {
                if (rdioNam.Checked)
                    gt += "Nam";
                else
                    gt += "Nữ";
                dr["TenKH"] = txtTenKH.Text;
                dr["SDT"] = txtSDT.Text;
                dr["GioiTinh"] = gt;
                dr["SoVe"] = NumSoVe.Value;
            }
            string chuoiTruyVan = "Update KhachHang set TenKH = N'" + txtTenKH.Text + "', SDT = '" + txtSDT.Text + "', GioiTinh = '" + gt + "', SoVe = " + NumSoVe.Value + " where MaKH = '" + txtMaKH.Text + "'";
            int k = db.getNonQuery(chuoiTruyVan);
            if (k != 0)
            {
                MessageBox.Show("Sửa thành công");
                hienThi_DSKH();
            }    
            else
                MessageBox.Show("Sửa thất bại");
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            rdioNam.DataBindings.Clear();
            rdioNu.DataBindings.Clear();
            string gt = dt.Rows[e.RowIndex]["GioiTinh"].ToString();

            if (gt == "Nam")
            {
                rdioNam.Checked = true;
                rdioNu.Checked = false;
            }
            else
            {
                rdioNam.Checked = false;
                rdioNu.Checked = true;
            }
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", dt, "MaKH");
            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add("Text", dt, "TenKH");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dt, "SDT");

            NumSoVe.DataBindings.Clear();
            NumSoVe.DataBindings.Add("Text", dt, "SoVe");

            txtTien.DataBindings.Clear();
            txtTien.DataBindings.Add("Text", dt, "ThanhTien");

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string chuoiTruyVan = "Select kh.*, hd.ThanhTien from KhachHang kh join HoaDon hd on kh.MaKH = hd.MaKH where kh.TenKH Like N'%" + txtTimKiem.Text + "%'";
            dt = db.getDataTable(chuoiTruyVan);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["MaKH"].HeaderText = "Mã khách hàng";
            dataGridView1.Columns["TenKH"].HeaderText = "Tên khách hàng";
            dataGridView1.Columns["SDT"].HeaderText = "Số điện thoại";
            dataGridView1.Columns["GioiTinh"].HeaderText = "Giới tính";
            dataGridView1.Columns["SoVe"].HeaderText = "Số vé";
            dataGridView1.Columns["ThanhTien"].HeaderText = "Thành tiền";
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        bool isDigit(string s)
        {
            foreach(char c in s)
            {
                if(!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (!isDigit(txtSDT.Text))
            {
                errorProvider1.SetError(txtSDT, "Vui lòng nhập số điện thoại hợp lý");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
