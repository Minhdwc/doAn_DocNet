using DoAn.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.AdminControllers
{
    public partial class QLDD : UserControl
    {
        public QLDD()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();
        DataTable dt;
        void hienthiDiemBD()
        {
            string chuoiTruyVan = "Select * from DiemBD";
            dt = db.getDataTable(chuoiTruyVan);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
            dtGridViewDiemBD.DataSource = dt;
            dtGridViewDiemBD.Columns["MaDiemBD"].HeaderText = "Mã điểm bắt đầu";
            dtGridViewDiemBD.Columns["TenDiemBD"].HeaderText = "Tên điểm bắt đầu";
            foreach (DataGridViewColumn column in dtGridViewDiemBD.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        void hienthiDiemKT()
        {
            string chuoiTruyVan = "Select * from DiemKT";
            dt = db.getDataTable(chuoiTruyVan);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
            dtGridViewDiemKT.DataSource = dt;
            dtGridViewDiemKT.Columns["MaDiemKT"].HeaderText = "Mã điểm kết thúc";
            dtGridViewDiemKT.Columns["TenDiemKT"].HeaderText = "Tên điểm kết thúc";
            foreach (DataGridViewColumn column in dtGridViewDiemKT.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        private void QLDD_Load(object sender, EventArgs e)
        {
            hienthiDiemBD();
            hienthiDiemKT();
        }
        public void AddUser(UserControl user)
        {
            user.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(user);
            user.BringToFront();
        }
        private void dtGridViewDiemKT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridViewDiemKT.Rows[e.RowIndex];
            string Madkt = row.Cells["MaDiemKT"].Value.ToString();
            string Tendkt = row.Cells["TenDiemKT"].Value.ToString();
            QLDKT frm = new QLDKT(Madkt, Tendkt);
            AddUser(frm);
        }

        private void dtGridViewDiemBD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridViewDiemBD.Rows[e.RowIndex];
            string Madbd = row.Cells["MaDiemBD"].Value.ToString();
            string Tendbd = row.Cells["TenDiemBD"].Value.ToString();
            QLDBD frm = new QLDBD(Madbd, Tendbd);
            AddUser(frm);
        }
    }
}
