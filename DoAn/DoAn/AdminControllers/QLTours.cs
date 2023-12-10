using DoAn.Models;
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

namespace DoAn.AdminControllers
{
    public partial class QLTours : UserControl
    {
        public QLTours()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();
        DataTable dt;
        void hienthiDSTours()
        {
            string chuoiTruyVan = "Select MaTour, TenTour, NgayDi, NgayVe, GiaTour, DiemBD.TenDiemBD, DiemKT.TenDiemKT, PhuongTien.TenPT, KhachSan.TenKS from Tours join DiemBD on Tours.MaDiemBD = DiemBD.MaDiemBD join DiemKT on DiemKT.MaDiemKT = Tours.MaDiemKT join PhuongTien on PhuongTien.MaPT = Tours.MaPT join KhachSan on Tours.MaKS = KhachSan.MaKS";
            dt = db.getDataTable(chuoiTruyVan);
            DataColumn[] key = new DataColumn[1];
            dt.PrimaryKey = new DataColumn[] { dt.Columns["MaTour"] };
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["MaTour"].HeaderText = "Mã tour";
            dataGridView1.Columns["TenTour"].HeaderText = "Tên Tour";
            dataGridView1.Columns["NgayDi"].HeaderText = "Ngày đi";
            dataGridView1.Columns["NgayVe"].HeaderText = "Ngày về";
            dataGridView1.Columns["GiaTour"].HeaderText = "Giá Tour";
            dataGridView1.Columns["TenDiemBD"].HeaderText = "Điểm bắt đầu";
            dataGridView1.Columns["TenDiemKT"].HeaderText = "Điểm kết thúc";
            dataGridView1.Columns["TenPT"].HeaderText = "Phương tiện";
            dataGridView1.Columns["TenKS"].HeaderText = "Khách sạn";
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        void databindding(DataTable dt)
        {
            numGiaTour.Minimum = 0;
            numGiaTour.Maximum = 1000000000000000;
            txtMaTour.DataBindings.Clear();
            txtTenTour.DataBindings.Clear();
            cboDiemBD.DataBindings.Clear();
            cboDiemKT.DataBindings.Clear();
            cboKS.DataBindings.Clear();
            cboPT.DataBindings.Clear();
            numGiaTour.DataBindings.Clear();
            dtNgayDi.DataBindings.Clear();
            dtNgayVe.DataBindings.Clear();

            txtMaTour.DataBindings.Add("Text", dt, "MaTour");
            txtTenTour.DataBindings.Add("Text", dt, "TenTour");
            cboDiemBD.DataBindings.Add("Text", dt, "TenDiemBD");
            cboDiemKT.DataBindings.Add("Text", dt, "TenDiemKT");
            cboKS.DataBindings.Add("Text", dt, "TenKS");
            cboPT.DataBindings.Add("Text", dt, "TenPT");
            dtNgayDi.DataBindings.Add("Value", dt, "NgayDi");
            dtNgayVe.DataBindings.Add("Value", dt, "NgayVe");
            numGiaTour.DataBindings.Add("Value", dt, "GiaTour");
            dtNgayDi.Format = DateTimePickerFormat.Custom;
            dtNgayDi.CustomFormat = "dd/MM/yyyy";
            dtNgayVe.Format = DateTimePickerFormat.Custom;
            dtNgayVe.CustomFormat = "dd/MM/yyyy";
        }
        void load_CboTenDBD()
        {
            DataSet ds = new DataSet();
            string chuoiTruyVan = "Select * from DiemBD";
            ds = db.GetDataSet(chuoiTruyVan);
            cboDiemBD.DataSource = ds.Tables[0];
            cboDiemBD.DisplayMember = "TenDiemBD";
            cboDiemBD.ValueMember = "MaDiemBD";
        }
        void load_CboTenDKT()
        {
            DataSet ds = new DataSet();
            string chuoiTruyVan = "Select * from DiemKT";
            ds = db.GetDataSet(chuoiTruyVan);
            cboDiemKT.DataSource = ds.Tables[0];
            cboDiemKT.DisplayMember = "TenDiemKT";
            cboDiemKT.ValueMember = "MaDiemKT";
        }
        void load_CboTenPT()
        {
            DataSet ds = new DataSet();
            string chuoiTruyVan = "Select * from PhuongTien";
            ds = db.GetDataSet(chuoiTruyVan);
            cboPT.DataSource = ds.Tables[0];
            cboPT.DisplayMember = "TenPT";
            cboPT.ValueMember = "MaPT";
        }
        void load_CboTenKS()
        {
            DataSet ds = new DataSet();
            string chuoiTruyVan = "Select * from KhachSan";
            ds = db.GetDataSet(chuoiTruyVan);
            cboKS.DataSource = ds.Tables[0];
            cboKS.DisplayMember = "TenKS";
            cboKS.ValueMember = "MaKS";
        }
        private void QLTours_Load(object sender, EventArgs e)
        {
            hienthiDSTours();
            databindding(dt);
            load_CboTenDBD();
            load_CboTenDKT();
            load_CboTenKS();
            load_CboTenPT();
            dtNgayDi.Format = DateTimePickerFormat.Custom;
            dtNgayDi.CustomFormat = "dd/MM/yyyy";
            dtNgayVe.Format = DateTimePickerFormat.Custom;
            dtNgayVe.CustomFormat = "dd/MM/yyyy";
        }

        private void btnThemTour_Click(object sender, EventArgs e)
        {
            List<DiemBD> lsbd = db.getDiemBD();
            List<diemkt> lskt = db.getDiemKT();
            List<PhuongTien> lspt = db.getPT();
            List<KhachSan> lsks = db.getKS();
            string mabd = "";
            string makt = "";
            string mapt = "";
            string maks = "";
            string tenbd = cboDiemBD.Text;
            string tenkt = cboDiemKT.Text;
            string tenpt = cboPT.Text;
            string tenks = cboKS.Text;
            foreach (var item in lsbd)
            {
                if (item.tendiembd == tenbd)
                {
                    mabd = item.madiembd;
                }
            }
            foreach (var item in lskt)
            {
                if (item.tendiemkt == tenkt)
                {
                    makt = item.madiemkt;
                }
            }
            foreach (var item in lspt)
            {
                if (item.tenpt == tenpt)
                {
                    mapt = item.mapt;
                }
            }
            foreach (var item in lsks)
            {
                if (item.TenKS == tenks)
                {
                    maks = item.MaKS;
                }
            }
            SqlConnection con = new SqlConnection(db.strConnect);
            con.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Insert into Tours values (@ma, @ten, @ngaydi, @ngayve,@giatour, @madiembd, @madiemkt, @mapt, @maks)";
            command.Connection = con;

            command.Parameters.Add("@ma", SqlDbType.VarChar).Value = txtMaTour.Text;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txtTenTour.Text;
            command.Parameters.Add("@ngaydi", SqlDbType.DateTime).Value = dtNgayDi.Value;
            command.Parameters.Add("@ngayve", SqlDbType.DateTime).Value = dtNgayVe.Value;
            command.Parameters.Add("@giatour", SqlDbType.Int).Value = numGiaTour.Value;
            command.Parameters.Add("@madiembd", SqlDbType.VarChar).Value = mabd.TrimEnd();
            command.Parameters.Add("@madiemkt", SqlDbType.VarChar).Value = makt.TrimEnd();
            command.Parameters.Add("@mapt", SqlDbType.VarChar).Value = mapt.TrimEnd();
            command.Parameters.Add("@maks", SqlDbType.VarChar).Value = maks.TrimEnd();
            int ret = command.ExecuteNonQuery();

            if (ret > 0)
            {
                MessageBox.Show("Thêm thành công!");
                hienthiDSTours();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
            con.Close();
        }
        bool ktkhoanngoai(string MaTour)
        {
            SqlConnection conn = new SqlConnection(db.strConnect);
            SqlCommand cmd = new SqlCommand("select count(*) from HoaDon where MaTour = @ma", conn);
            cmd.Parameters.AddWithValue("@ma", MaTour);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count > 0;
        }

        private void btnXoaTour_Click(object sender, EventArgs e)
        {
            string matour = dataGridView1.SelectedRows[0].Cells["MaTour"].Value.ToString();
            if (ktkhoanngoai(txtMaTour.Text))
            {
                MessageBox.Show("Tour đã được có người đặt không thể xóa");
                return;
            }
            DataRow dr = dt.Rows.Find(matour);
            if (dr != null)
            {
                dr.Delete();
            }
            string chuoiTruyVanXoa = "DELETE FROM Tours WHERE MaTour = @matour";
            SqlConnection con = new SqlConnection(db.strConnect);
            con.Open();
            SqlCommand command = new SqlCommand(chuoiTruyVanXoa, con);
            command.Parameters.AddWithValue("@matour", matour);
            int ret = command.ExecuteNonQuery();
            con.Close();

            if (ret > 0)
            {
                MessageBox.Show("Xóa thành công!");
                hienthiDSTours();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            databindding(dt);
        }

        private void btnSuaTour_Click(object sender, EventArgs e)
        {
            List<DiemBD> lsbd = db.getDiemBD();
            List<diemkt> lskt = db.getDiemKT();
            List<PhuongTien> lspt = db.getPT();
            List<KhachSan> lsks = db.getKS();
            string mabd = "";
            string makt = "";
            string mapt = "";
            string maks = "";
            string tenbd = cboDiemBD.Text;
            string tenkt = cboDiemKT.Text;
            string tenpt = cboPT.Text;
            string tenks = cboKS.Text;
            foreach (var item in lsbd)
            {
                if (item.tendiembd == tenbd)
                {
                    mabd = item.madiembd;
                }
            }
            foreach (var item in lskt)
            {
                if (item.tendiemkt == tenkt)
                {
                    makt = item.madiemkt;
                }
            }
            foreach (var item in lspt)
            {
                if (item.tenpt == tenpt)
                {
                    mapt = item.mapt;
                }
            }
            foreach (var item in lsks)
            {
                if (item.TenKS == tenks)
                {
                    maks = item.MaKS;
                }
            }
            SqlConnection con = new SqlConnection(db.strConnect);
            con.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Update Tours set TenTour = @ten, GiaTour = @giatour, NgayDi = @ngaydi, NgayVe = @ngayve, MaDiemBD = @madiembd, MaDiemKT = @madiemkt, MaPT = @mapt, MaKS = @maks where MaTour = @ma";
            command.Connection = con;

            command.Parameters.Add("@ma", SqlDbType.VarChar).Value = txtMaTour.Text;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txtTenTour.Text;
            command.Parameters.Add("@ngaydi", SqlDbType.DateTime).Value = dtNgayDi.Value;
            command.Parameters.Add("@ngayve", SqlDbType.DateTime).Value = dtNgayVe.Value;
            command.Parameters.Add("@giatour", SqlDbType.Int).Value = numGiaTour.Value;
            command.Parameters.Add("@madiembd", SqlDbType.VarChar).Value = mabd.TrimEnd();
            command.Parameters.Add("@madiemkt", SqlDbType.VarChar).Value = makt.TrimEnd();
            command.Parameters.Add("@mapt", SqlDbType.VarChar).Value = mapt.TrimEnd();
            command.Parameters.Add("@maks", SqlDbType.VarChar).Value = maks.TrimEnd();

            int ret = command.ExecuteNonQuery();

            if (ret > 0)
            {
                MessageBox.Show("Sửa thành công!");
                hienthiDSTours();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
            con.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "TenTour", "*" + txtTimKiem.Text + "*");
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }
    }
}
