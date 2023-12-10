using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.Models;

namespace DoAn.AdminControllers
{
    public partial class QLDV : UserControl
    {
        public QLDV()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();
        DataTable dt;
        public void AddUser(UserControl user)
        {
            user.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(user);
            user.BringToFront();
        }
        public void hienthiPT()
        {
            string chuoiTruyVan = "Select * from PhuongTien";
            dt = db.getDataTable(chuoiTruyVan);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = new DataColumn[] { dt.Columns["MaPT"] };
            dtGridViewPT.DataSource = dt;
            dtGridViewPT.Columns["MaPT"].HeaderText = "Mã phương tiện";
            dtGridViewPT.Columns["TenPT"].HeaderText = "Tên phương tiện";
            foreach (DataGridViewColumn column in dtGridViewPT.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        
        
        void hienthiloaiKS()
        {
            string chuoiTruyVan = "Select * from LoaiKS";
            dt = db.getDataTable(chuoiTruyVan);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
            dtGridViewLoaiKS.DataSource = dt;
            dtGridViewLoaiKS.Columns["MaLoaiKS"].HeaderText = "Mã loại";
            dtGridViewLoaiKS.Columns["TenLoaiKS"].HeaderText = "Tên loại";
            foreach (DataGridViewColumn column in dtGridViewLoaiKS.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void QLDV_Load(object sender, EventArgs e)
        {
            hienthiPT();
            hienthiloaiKS();
        }

        private void dtGridViewPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridViewPT.Rows[e.RowIndex];
            string MaPT = row.Cells["MaPT"].Value.ToString();
            string TenPT = row.Cells["TenPT"].Value.ToString();
            QLPT frm = new QLPT(MaPT, TenPT);
            AddUser(frm);
        }

        private void dtGridViewLoaiKS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridViewLoaiKS.Rows[e.RowIndex];
            string MaLoai = row.Cells["MaLoaiKS"].Value.ToString();
            string TenLoai = row.Cells["TenLoaiKS"].Value.ToString();
            QLLKS frm = new QLLKS(MaLoai, TenLoai);
            AddUser(frm);
        }
    }
}
