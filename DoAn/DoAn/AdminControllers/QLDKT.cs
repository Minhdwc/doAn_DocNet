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
    public partial class QLDKT : UserControl
    {
        public QLDKT()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();
        DataTable dt = new DataTable();

        string ma = "";
        string ten = "";
        public QLDKT(string madiemkt, string tendiemkt)
        {
            InitializeComponent();
            ma= madiemkt;
            ten= tendiemkt;
        }
        bool ktTrungDKT(string ma)
        {
            string chuoiTruyVan = "Select count(*) from DiemKT where MaDiemKT = '" + ma + "'";
            int k = (int)db.getScalar(chuoiTruyVan);
            if (k != 0)
                return true;
            return false;
        }
        bool ktkhoanngoai(string maDKT)
        {
            SqlConnection conn = new SqlConnection(db.strConnect);
            SqlCommand cmd = new SqlCommand("select count(*) from Tours where MaDiemKT = @ma", conn);
            cmd.Parameters.AddWithValue("@ma", maDKT);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count > 0;
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            txtMaDiemKT.Text = ma;
            txtTenDiemKT.Text = ten;
        }

        private void btnThemDKT_Click(object sender, EventArgs e)
        {
            if (!ktTrungDKT(txtMaDiemKT.Text))
            {
                string chuoiTruyVan = "Insert into DiemKT values('" + txtMaDiemKT
                    .Text + "', N'" + txtTenDiemKT.Text + "')";
                int k = db.getNonQuery(chuoiTruyVan);
                if (k != 0)
                    MessageBox.Show("Thêm thành công");
                else
                    MessageBox.Show("Thêm thất bại");
            }
            else
                MessageBox.Show("Mã điểm bắt đầu đã tồn tại");
        }

        private void btnXoaDKT_Click(object sender, EventArgs e)
        {
            if (ktkhoanngoai(txtMaDiemKT.Text))
            {
                MessageBox.Show("Không thể xóa vì nó là khóa ngoại");
                return;
            }
            string chuoiTruyVanXoa = "DELETE FROM DiemKT WHERE MaDiemKT = '" + txtMaDiemKT.Text + "'";
            int k = db.getNonQuery(chuoiTruyVanXoa);
            if (k != 0)
            {
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnSuaDKT_Click(object sender, EventArgs e)
        {
            if (ktTrungDKT(txtMaDiemKT.Text))
            {
                string chuoiTruyVan = "Update DiemKT set TenDiemKT = N'" + txtTenDiemKT.Text + "' where MaDiemKT = '" + txtMaDiemKT.Text + "'";
                int k = db.getNonQuery(chuoiTruyVan);
                if (k != 0)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                    MessageBox.Show("Thêm thất bại");
            }
            else
            {
                MessageBox.Show("Mã điểm bắt đầu không thể sửa");
            }
        }
    }
}
