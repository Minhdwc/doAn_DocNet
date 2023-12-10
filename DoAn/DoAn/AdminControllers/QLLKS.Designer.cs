namespace DoAn.AdminControllers
{
    partial class QLLKS
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSuaLoaiKS = new System.Windows.Forms.Button();
            this.btnXoaLoaiKS = new System.Windows.Forms.Button();
            this.btnThemLoaiKS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLoaiKS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLoaiKS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSuaLoaiKS
            // 
            this.btnSuaLoaiKS.Location = new System.Drawing.Point(338, 90);
            this.btnSuaLoaiKS.Margin = new System.Windows.Forms.Padding(6);
            this.btnSuaLoaiKS.Name = "btnSuaLoaiKS";
            this.btnSuaLoaiKS.Size = new System.Drawing.Size(123, 44);
            this.btnSuaLoaiKS.TabIndex = 30;
            this.btnSuaLoaiKS.Text = "Sửa";
            this.btnSuaLoaiKS.UseVisualStyleBackColor = true;
            this.btnSuaLoaiKS.Click += new System.EventHandler(this.btnSuaLoaiKS_Click);
            // 
            // btnXoaLoaiKS
            // 
            this.btnXoaLoaiKS.Location = new System.Drawing.Point(180, 90);
            this.btnXoaLoaiKS.Margin = new System.Windows.Forms.Padding(6);
            this.btnXoaLoaiKS.Name = "btnXoaLoaiKS";
            this.btnXoaLoaiKS.Size = new System.Drawing.Size(123, 44);
            this.btnXoaLoaiKS.TabIndex = 29;
            this.btnXoaLoaiKS.Text = "Xóa";
            this.btnXoaLoaiKS.UseVisualStyleBackColor = true;
            this.btnXoaLoaiKS.Click += new System.EventHandler(this.btnXoaLoaiKS_Click);
            // 
            // btnThemLoaiKS
            // 
            this.btnThemLoaiKS.Location = new System.Drawing.Point(27, 90);
            this.btnThemLoaiKS.Margin = new System.Windows.Forms.Padding(6);
            this.btnThemLoaiKS.Name = "btnThemLoaiKS";
            this.btnThemLoaiKS.Size = new System.Drawing.Size(115, 44);
            this.btnThemLoaiKS.TabIndex = 28;
            this.btnThemLoaiKS.Text = "Thêm";
            this.btnThemLoaiKS.UseVisualStyleBackColor = true;
            this.btnThemLoaiKS.Click += new System.EventHandler(this.btnThemLoaiKS_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 27);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tên loại";
            // 
            // txtTenLoaiKS
            // 
            this.txtTenLoaiKS.Location = new System.Drawing.Point(197, 47);
            this.txtTenLoaiKS.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtTenLoaiKS.Name = "txtTenLoaiKS";
            this.txtTenLoaiKS.Size = new System.Drawing.Size(293, 35);
            this.txtTenLoaiKS.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã loại khách sạn";
            // 
            // txtMaLoaiKS
            // 
            this.txtMaLoaiKS.Location = new System.Drawing.Point(197, 0);
            this.txtMaLoaiKS.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtMaLoaiKS.Name = "txtMaLoaiKS";
            this.txtMaLoaiKS.Size = new System.Drawing.Size(293, 35);
            this.txtMaLoaiKS.TabIndex = 24;
            // 
            // QLLKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnSuaLoaiKS);
            this.Controls.Add(this.btnXoaLoaiKS);
            this.Controls.Add(this.btnThemLoaiKS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenLoaiKS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaLoaiKS);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QLLKS";
            this.Size = new System.Drawing.Size(502, 156);
            this.Load += new System.EventHandler(this.QLLKS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSuaLoaiKS;
        private System.Windows.Forms.Button btnXoaLoaiKS;
        private System.Windows.Forms.Button btnThemLoaiKS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenLoaiKS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLoaiKS;
    }
}
