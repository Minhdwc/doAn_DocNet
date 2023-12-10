namespace DoAn
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PanLeft = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDV = new System.Windows.Forms.Button();
            this.btnDD = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnKS = new System.Windows.Forms.Button();
            this.btnTours = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanRight = new System.Windows.Forms.Panel();
            this.PanLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanLeft
            // 
            this.PanLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanLeft.Controls.Add(this.panel2);
            this.PanLeft.Controls.Add(this.panel1);
            this.PanLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanLeft.Location = new System.Drawing.Point(0, 0);
            this.PanLeft.Margin = new System.Windows.Forms.Padding(4);
            this.PanLeft.Name = "PanLeft";
            this.PanLeft.Size = new System.Drawing.Size(229, 636);
            this.PanLeft.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.btnDangXuat);
            this.panel2.Controls.Add(this.btnDV);
            this.panel2.Controls.Add(this.btnDD);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.btnNhanVien);
            this.panel2.Controls.Add(this.btnHoaDon);
            this.panel2.Controls.Add(this.btnKS);
            this.panel2.Controls.Add(this.btnTours);
            this.panel2.Controls.Add(this.btnUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 506);
            this.panel2.TabIndex = 17;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangXuat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.ImageKey = "(none)";
            this.btnDangXuat.ImageList = this.imageList1;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 394);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(229, 56);
            this.btnDangXuat.TabIndex = 24;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnDV
            // 
            this.btnDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDV.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDV.ImageKey = "luggae.png";
            this.btnDV.ImageList = this.imageList1;
            this.btnDV.Location = new System.Drawing.Point(0, 338);
            this.btnDV.Name = "btnDV";
            this.btnDV.Size = new System.Drawing.Size(229, 56);
            this.btnDV.TabIndex = 23;
            this.btnDV.Text = "Dịch vụ";
            this.btnDV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDV.UseVisualStyleBackColor = true;
            this.btnDV.Click += new System.EventHandler(this.btnDV_Click);
            // 
            // btnDD
            // 
            this.btnDD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDD.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDD.ImageKey = "map.png";
            this.btnDD.ImageList = this.imageList1;
            this.btnDD.Location = new System.Drawing.Point(0, 282);
            this.btnDD.Name = "btnDD";
            this.btnDD.Size = new System.Drawing.Size(229, 56);
            this.btnDD.TabIndex = 22;
            this.btnDD.Text = "Địa điểm";
            this.btnDD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDD.UseVisualStyleBackColor = true;
            this.btnDD.Click += new System.EventHandler(this.btnDD_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(0, 450);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(229, 56);
            this.button5.TabIndex = 21;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhanVien.ImageKey = "user.png";
            this.btnNhanVien.ImageList = this.imageList1;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 226);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(229, 56);
            this.btnNhanVien.TabIndex = 20;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDon.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHoaDon.ImageKey = "bill.png";
            this.btnHoaDon.ImageList = this.imageList1;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 170);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(229, 56);
            this.btnHoaDon.TabIndex = 19;
            this.btnHoaDon.Text = "Hóa đơn";
            this.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnKS
            // 
            this.btnKS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKS.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKS.ImageKey = "hotel.png";
            this.btnKS.ImageList = this.imageList1;
            this.btnKS.Location = new System.Drawing.Point(0, 114);
            this.btnKS.Name = "btnKS";
            this.btnKS.Size = new System.Drawing.Size(229, 56);
            this.btnKS.TabIndex = 18;
            this.btnKS.Text = "Khách sạn";
            this.btnKS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKS.UseVisualStyleBackColor = true;
            this.btnKS.Click += new System.EventHandler(this.btnKS_Click);
            // 
            // btnTours
            // 
            this.btnTours.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTours.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTours.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTours.ImageKey = "travel.png";
            this.btnTours.ImageList = this.imageList1;
            this.btnTours.Location = new System.Drawing.Point(0, 57);
            this.btnTours.Name = "btnTours";
            this.btnTours.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTours.Size = new System.Drawing.Size(229, 57);
            this.btnTours.TabIndex = 17;
            this.btnTours.Text = "Tours";
            this.btnTours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTours.UseVisualStyleBackColor = true;
            this.btnTours.Click += new System.EventHandler(this.btnTours_Click);
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.ImageKey = "(none)";
            this.btnUser.ImageList = this.imageList1;
            this.btnUser.Location = new System.Drawing.Point(0, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUser.Size = new System.Drawing.Size(229, 57);
            this.btnUser.TabIndex = 16;
            this.btnUser.Text = "Khách hàng";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 100);
            this.panel1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAn.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(45, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // PanRight
            // 
            this.PanRight.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PanRight.BackgroundImage = global::DoAn.Properties.Resources.IMG_20210505_223544;
            this.PanRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanRight.Location = new System.Drawing.Point(229, 0);
            this.PanRight.Margin = new System.Windows.Forms.Padding(4);
            this.PanRight.Name = "PanRight";
            this.PanRight.Size = new System.Drawing.Size(895, 636);
            this.PanRight.TabIndex = 1;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1124, 636);
            this.Controls.Add(this.PanRight);
            this.Controls.Add(this.PanLeft);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.PanLeft.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanLeft;
        private System.Windows.Forms.Panel PanRight;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDD;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnKS;
        private System.Windows.Forms.Button btnTours;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDV;
        private System.Windows.Forms.Button btnDangXuat;
    }
}