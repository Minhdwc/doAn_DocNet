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
    public partial class QLLKS : UserControl
    {
        public QLLKS()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();
        DataTable dt = new DataTable();
        string ma = "";
        string ten = "";
        bool ktkhoanngoai(string maloai)
        {
            SqlConnection conn = new SqlConnection(db.strConnect);
            SqlCommand cmd = new SqlCommand("select count(*) from KhachSan where MaLoaiKS = @ma", conn);
            cmd.Parameters.AddWithValue("@ma", maloai);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count > 0;
        }
        public QLLKS(string maloai, string tenloai)
        {
            InitializeComponent();
            ma = maloai;
            ten = tenloai;
        }
        bool ktTrungLoaiKS(string ma)
        {
            string chuoiTruyVan = "Select count(*) from LoaiKS where MaLoaiKS = '" + ma + "'";
            int k = (int)db.getScalar(chuoiTruyVan);
            if (k != 0)
                return true;
            return false;
        }

        private void QLLKS_Load(object sender, EventArgs e)
        {
            txtMaLoaiKS.Text = ma;
            txtTenLoaiKS.Text = ten;
        }

        private void btnThemLoaiKS_Click(object sender, EventArgs e)
        {
            if (!ktTrungLoaiKS(txtMaLoaiKS.Text))
            {
                dt.Columns.Add("MaLoaiKS", typeof(string));
                dt.Columns.Add("TenLoaiKS", typeof(string));
                DataRow dr = dt.NewRow();
                dr["MaLoaiKS"] = txtMaLoaiKS.Text;
                dr["TenLoaiKS"] = txtTenLoaiKS.Text;
                dt.Rows.Add(dr);

                string chuoiTruyVan = "Select * from LoaiKS";
                int k = db.updateDataTable(dt, chuoiTruyVan);
                if (k != 0)
                {
                    MessageBox.Show("Thêm thành công");
                    OnLoad(e);
                }
                else
                    MessageBox.Show("Thêm thất bại");
            }
            else
                MessageBox.Show("Mã loại đã tồn tại");
        }

        private void btnXoaLoaiKS_Click(object sender, EventArgs e)
        {
            dt.Columns.Add("MaLoaiKS", typeof(string));
            dt.Columns.Add("TenLoaiKS", typeof(string));
            dt.PrimaryKey = new DataColumn[] { dt.Columns["MaLoaiKS"] };
            DataRow dr = dt.Rows.Find(txtMaLoaiKS.Text);
            if(ktkhoanngoai(txtMaLoaiKS.Text))
            {
                MessageBox.Show("Không thể xóa vì nó là khóa ngoại");
                return;
            }    
            if (dr != null)
            {
                dr.Delete();
            }
            string chuoiTruyVanXoa = "DELETE FROM LoaiKS WHERE MaLoaiKS = @ma";
            SqlConnection con = new SqlConnection(db.strConnect);
            con.Open();
            SqlCommand command = new SqlCommand(chuoiTruyVanXoa, con);
            command.Parameters.AddWithValue("@ma", ma);
            int ret = command.ExecuteNonQuery();
            con.Close();

            if (ret > 0)
            {
                MessageBox.Show("Xóa thành công!");
                OnLoad(e);
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnSuaLoaiKS_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(db.strConnect);
            con.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Update LoaiKS set TenLoaiKS = @ten where MaLoaiKS = @ma";
            command.Connection = con;

            command.Parameters.Add("@ma", SqlDbType.VarChar).Value = txtMaLoaiKS.Text;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txtTenLoaiKS.Text;

            int ret = command.ExecuteNonQuery();

            if (ret > 0)
            {
                MessageBox.Show("Sửa thành công!");
                OnLoad(e);
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
            con.Close();
        }
    }
}
