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
    public partial class QLPT : UserControl
    {
        public QLPT()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();
        DataTable dt = new DataTable();

        string ma = "";
        string ten = "";
        public QLPT(string maPt, string tenPt)
        {
            InitializeComponent();
            ma = maPt;
            ten = tenPt;
        }
        bool ktTrungPT(string ma)
        {
            string chuoiTruyVan = "Select count(*) from PhuongTien where MaPT = '" + ma + "'";
            int k = (int)db.getScalar(chuoiTruyVan);
            if (k != 0)
                return true;
            return false;
        }

        bool ktkhoanngoai(string maPT)
        {
            SqlConnection conn = new SqlConnection(db.strConnect);
            SqlCommand cmd = new SqlCommand("select count(*) from Tours where MaPT = @ma", conn);
            cmd.Parameters.AddWithValue("@ma", maPT);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count > 0;
        }

        private void QLPT_Load(object sender, EventArgs e)
        {
            txtMaPT.Text = ma;
            txtTenPT.Text = ten;
        }

        private void btnThemPT_Click(object sender, EventArgs e)
        {
            if (!ktTrungPT(txtMaPT.Text))
            {
                string chuoiTruyVan = "Insert into PhuongTien Values('" + txtMaPT.Text + "', N'" + txtTenPT.Text + "')";
                int k = (int)db.getNonQuery(chuoiTruyVan);
                if (k != 0)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
                MessageBox.Show("Mã phương tiện đã tồn tại");
        }

        private void btnXoaPT_Click(object sender, EventArgs e)
        {
            string chuoiTruyVan = "Delete from PhuongTien where MaPT = '"+txtMaPT.Text+"'";
            int k = (int)db.getNonQuery(chuoiTruyVan);
            if (k != 0)
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }


        private void btnSuaPT_Click(object sender, EventArgs e)
        {
            string chuoiTruyVan = "Update PhuongTien set TenPT = N'" + txtTenPT.Text + "' where MaPT = '"+txtMaPT.Text+"'";
            int k = (int)db.getNonQuery(chuoiTruyVan);
            if (k != 0)
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }
    }
}
