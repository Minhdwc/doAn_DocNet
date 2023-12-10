namespace DoAn.AdminControllers
{
    partial class QLDKT
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
            this.txtMaDiemKT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDiemKT = new System.Windows.Forms.TextBox();
            this.btnSuaDKT = new System.Windows.Forms.Button();
            this.btnXoaDKT = new System.Windows.Forms.Button();
            this.btnThemDKT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMaDiemKT
            // 
            this.txtMaDiemKT.Location = new System.Drawing.Point(223, 5);
            this.txtMaDiemKT.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDiemKT.Name = "txtMaDiemKT";
            this.txtMaDiemKT.Size = new System.Drawing.Size(222, 35);
            this.txtMaDiemKT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã điểm kết thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên điểm kết thúc";
            // 
            // txtTenDiemKT
            // 
            this.txtTenDiemKT.Location = new System.Drawing.Point(223, 61);
            this.txtTenDiemKT.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDiemKT.Name = "txtTenDiemKT";
            this.txtTenDiemKT.Size = new System.Drawing.Size(222, 35);
            this.txtTenDiemKT.TabIndex = 2;
            // 
            // btnSuaDKT
            // 
            this.btnSuaDKT.Location = new System.Drawing.Point(292, 115);
            this.btnSuaDKT.Name = "btnSuaDKT";
            this.btnSuaDKT.Size = new System.Drawing.Size(93, 35);
            this.btnSuaDKT.TabIndex = 9;
            this.btnSuaDKT.Text = "Sửa";
            this.btnSuaDKT.UseVisualStyleBackColor = true;
            this.btnSuaDKT.Click += new System.EventHandler(this.btnSuaDKT_Click);
            // 
            // btnXoaDKT
            // 
            this.btnXoaDKT.Location = new System.Drawing.Point(155, 115);
            this.btnXoaDKT.Name = "btnXoaDKT";
            this.btnXoaDKT.Size = new System.Drawing.Size(93, 35);
            this.btnXoaDKT.TabIndex = 8;
            this.btnXoaDKT.Text = "Xóa";
            this.btnXoaDKT.UseVisualStyleBackColor = true;
            this.btnXoaDKT.Click += new System.EventHandler(this.btnXoaDKT_Click);
            // 
            // btnThemDKT
            // 
            this.btnThemDKT.Location = new System.Drawing.Point(21, 115);
            this.btnThemDKT.Name = "btnThemDKT";
            this.btnThemDKT.Size = new System.Drawing.Size(89, 35);
            this.btnThemDKT.TabIndex = 7;
            this.btnThemDKT.Text = "Thêm";
            this.btnThemDKT.UseVisualStyleBackColor = true;
            this.btnThemDKT.Click += new System.EventHandler(this.btnThemDKT_Click);
            // 
            // QLDKT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnSuaDKT);
            this.Controls.Add(this.btnXoaDKT);
            this.Controls.Add(this.btnThemDKT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenDiemKT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaDiemKT);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QLDKT";
            this.Size = new System.Drawing.Size(464, 174);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaDiemKT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDiemKT;
        private System.Windows.Forms.Button btnSuaDKT;
        private System.Windows.Forms.Button btnXoaDKT;
        private System.Windows.Forms.Button btnThemDKT;
    }
}
