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
using DoAn.Models;

namespace DoAn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();

        public bool KiemTraTK(string name, string pass)
        {
            string chuoiTruyVan = "SELECT COUNT(*) FROM TaiKhoan WHERE TenTK = '" + name + "' AND MatKhau = '" + pass + "'";
            int k = (int)db.getScalar(chuoiTruyVan);
            return k != 0;
        }
        private void btnDN_Click(object sender, EventArgs e)
        {
            bool TKHopLy = KiemTraTK(txtUser.Text, txtPass.Text);
            if(TKHopLy)
            {
                FormAdmin frmAdmin = new FormAdmin();
                frmAdmin.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác\nVui lòng nhập lại");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
