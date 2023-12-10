using DoAn.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace DoAn.AdminControllers
{
    public partial class QLKS : UserControl
    {
        public QLKS()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();
        DataTable dt;
        void hienthi()
        {
            string chuoiTruyVan = "Select MaKS, TenKS, DiaChi, TenLoaiKS from KhachSan join LoaiKS on KhachSan.MaLoaiKS = LoaiKS.MaLoaiKS";
            dt = db.getDataTable(chuoiTruyVan);
            DataColumn[] key = new DataColumn[1];
            dt.PrimaryKey = new DataColumn[] { dt.Columns["MaKS"] };
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["MaKS"].HeaderText = "Mã khách sạn";
            dataGridView1.Columns["TenKS"].HeaderText = "Tên khách sạn";
            dataGridView1.Columns["DiaChi"].HeaderText = "Địa chỉ khách sạn";
            dataGridView1.Columns["TenLoaiKS"].HeaderText = "Tên loại khách sạn";
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        void load_Cbo()
        {
            DataSet ds = new DataSet();
            string chuoiTruyVan = "Select * from LoaiKS";
            ds = db.GetDataSet(chuoiTruyVan);
            cboLoaiKS.DataSource = ds.Tables[0];
            cboLoaiKS.DisplayMember = "TenLoaiKS";
            cboLoaiKS.ValueMember = "MaLoaiKS";
        }
        void databindding(DataTable dt)
        {
            txtMaKS.DataBindings.Clear();
            txtTenKS.DataBindings.Clear();
            txtDiaChiKS.DataBindings.Clear();
            cboLoaiKS.DataBindings.Clear();

            txtMaKS.DataBindings.Add("Text", dt, "MaKS");
            txtTenKS.DataBindings.Add("Text", dt, "TenKS");
            txtDiaChiKS.DataBindings.Add("Text", dt, "DiaChi");
            cboLoaiKS.DataBindings.Add("Text", dt, "TenLoaiKS");
        }
        private void QLKS_Load(object sender, EventArgs e)
        {
            hienthi();
            load_Cbo();
            databindding(dt);
        }
        private void bntThemKS_Click(object sender, EventArgs e)
        {
            List<LoaiKS> ls = db.GetLoaiKSs();
            string maloi = "";
            string tenloi = cboLoaiKS.Text;
            foreach (var item in ls)
            {
                if (item.tenloai == tenloi)
                {
                    maloi = item.ma;
                }
            }

            SqlConnection con = new SqlConnection(db.strConnect);
            con.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Insert into KhachSan values (@ma, @ten, @gia, @diachi, @maloaiks)";
            command.Connection = con;

            command.Parameters.Add("@ma", SqlDbType.VarChar).Value = txtMaKS.Text;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txtTenKS.Text;
            command.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = txtDiaChiKS.Text;
            command.Parameters.Add("@maloaiks", SqlDbType.VarChar).Value = maloi.TrimEnd();

            int ret = command.ExecuteNonQuery();

            if (ret > 0)
            {
                MessageBox.Show("Thêm thành công!");
                hienthi();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
                con.Close();
        }
        bool ktkhoanngoai(string MaKS)
        {
            SqlConnection conn = new SqlConnection(db.strConnect);
            SqlCommand cmd = new SqlCommand("select count(*) from Tours where MaKS = @ma", conn);
            cmd.Parameters.AddWithValue("@ma", MaKS);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count > 0;
        }
        private void btnXoaKS_Click(object sender, EventArgs e)
        {
            string maKS = dataGridView1.SelectedRows[0].Cells["MaKS"].Value.ToString();
            DataRow dr = dt.Rows.Find(maKS);
            if(ktkhoanngoai(maKS))
            {
                MessageBox.Show("Khách sạn vẫn còn tồn tại trong hóa đơn");
                return;
            }    
            if (dr != null)
            {
                dr.Delete();
            }
            string chuoiTruyVanXoa = "DELETE FROM KhachSan WHERE MaKS = @maKS";
            SqlConnection con = new SqlConnection(db.strConnect);
            con.Open();
            SqlCommand command = new SqlCommand(chuoiTruyVanXoa, con);
            command.Parameters.AddWithValue("@maKS", maKS);
            int ret = command.ExecuteNonQuery();
            con.Close();

            if (ret > 0)
            {
                MessageBox.Show("Xóa thành công!");
                hienthi();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnSuaKS_Click(object sender, EventArgs e)
        {
            List<LoaiKS> ls = db.GetLoaiKSs();
            string maloi = "";
            string tenloi = cboLoaiKS.Text;
            foreach (var item in ls)
            {
                if (item.tenloai == tenloi)
                {
                    maloi = item.ma;
                }
            }
            SqlConnection con = new SqlConnection(db.strConnect);
            con.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Update KhachSan set TenKS = @ten, DiaChi = @diachi, MaLoaiKS = @maloaiks where MaKS = @ma";
            command.Connection = con;

            command.Parameters.Add("@ma", SqlDbType.VarChar).Value = txtMaKS.Text;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txtTenKS.Text;
            command.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = txtDiaChiKS.Text;
            command.Parameters.Add("@maloaiks", SqlDbType.VarChar).Value = maloi.TrimEnd();

            int ret = command.ExecuteNonQuery();

            if (ret > 0)
            {
                MessageBox.Show("Sửa thành công!");
                hienthi();
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string chuoiTruyVan = "Select MaKS, TenKS, DiaChi, TenLoaiKS from KhachSan join LoaiKS on KhachSan.MaLoaiKS = LoaiKS.MaLoaiKS where TenKS Like N'%" + txtTimKiem.Text + "%'";
            dt = db.getDataTable(chuoiTruyVan);
            DataColumn[] key = new DataColumn[1];
            dt.PrimaryKey = new DataColumn[] { dt.Columns["MaKS"] };
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["MaKS"].HeaderText = "Mã khách sạn";
            dataGridView1.Columns["TenKS"].HeaderText = "Tên khách sạn";
            dataGridView1.Columns["DiaChi"].HeaderText = "Địa chỉ khách sạn";
            dataGridView1.Columns["TenLoaiKS"].HeaderText = "Tên loại khách sạn";
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
