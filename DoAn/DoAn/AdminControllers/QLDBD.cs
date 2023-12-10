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
    public partial class QLDBD : UserControl
    {
        public QLDBD()
        {
        }
        DBConnect db = new DBConnect();
        DataTable dt = new DataTable();

        string ma = "";
        string ten = "";
        public QLDBD(string madiemkt, string tendiemkt)
        {
            InitializeComponent();
            ma = madiemkt;
            ten = tendiemkt;
        }
        bool ktTrungDBD(string ma)
        {
            string chuoiTruyVan = "Select count(*) from DiemBD where MaDiemBD = '" + ma + "'";
            int k = (int)db.getScalar(chuoiTruyVan);
            if (k != 0)
                return true;
            return false;
        }
        bool ktkhoanngoai(string maDBD)
        {
            SqlConnection conn = new SqlConnection(db.strConnect);
            SqlCommand cmd = new SqlCommand("select count(*) from Tours where MaDiemBD = @ma", conn);
            cmd.Parameters.AddWithValue("@ma", maDBD);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count > 0;
        }
        private void QLDBD_Load(object sender, EventArgs e)
        {
            txtMaDiemBD.Text = ma;
            txtTenDiemBD.Text = ten;
        }

        private void btnThemDBD_Click(object sender, EventArgs e)
        {
            if (!ktTrungDBD(txtMaDiemBD.Text))
            {
                string chuoiTruyVan = "Insert into DiemBD values('" + txtMaDiemBD
                    .Text + "', N'" + txtTenDiemBD.Text + "')";
                int k = db.getNonQuery(chuoiTruyVan);
                if (k != 0)
                    MessageBox.Show("Thêm thành công");
                else
                    MessageBox.Show("Thêm thất bại");
            }
            else
                MessageBox.Show("Mã điểm bắt đầu đã tồn tại");
        }

        private void btnXoaDBD_Click(object sender, EventArgs e)
        {
            if (ktkhoanngoai(txtMaDiemBD.Text))
            {
                MessageBox.Show("Không thể xóa vì nó là khóa ngoại");
                return;
            }
            string chuoiTruyVanXoa = "DELETE FROM DiemBD WHERE MaDiemBD = '"+txtMaDiemBD.Text+"'";
            int k = db.getNonQuery(chuoiTruyVanXoa);
            if (k!= 0)
            {
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnSuaDBD_Click(object sender, EventArgs e)
        {
            if(ktTrungDBD(txtMaDiemBD.Text))
            {
                string chuoiTruyVan = "Update DiemBD set TenDiemBD = N'" + txtTenDiemBD.Text + "' where MaDiemBD = '" + txtMaDiemBD.Text + "'";
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
