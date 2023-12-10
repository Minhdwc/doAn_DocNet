using DoAn.AdminControllers;
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

namespace DoAn
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            
        }

        public FormAdmin(string str)
        {
            MessageBox.Show(str);
            InitializeComponent();

        }

        public void AddUser(UserControl user)
        {
            user.Dock = DockStyle.Fill;
            PanRight.Controls.Clear();
            PanRight.Controls.Add(user);
            user.BringToFront();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            QLKH user = new QLKH();
            AddUser(user);
        }

        private void btnKS_Click(object sender, EventArgs e)
        {
            QLKS user = new QLKS();
            AddUser(user);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDD_Click(object sender, EventArgs e)
        {
            QLDD user = new QLDD();
            AddUser(user);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            QLNV user = new QLNV();
            AddUser(user);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            QLHoaDon user = new QLHoaDon();
            AddUser(user);
        }

        private void btnTours_Click(object sender, EventArgs e)
        {
            QLTours user = new QLTours();
            AddUser(user);
        }

        private void btnDV_Click(object sender, EventArgs e)
        {
            QLDV user = new QLDV();
            AddUser(user);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
