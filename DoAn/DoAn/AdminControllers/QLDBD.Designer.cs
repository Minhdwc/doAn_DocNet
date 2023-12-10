namespace DoAn.AdminControllers
{
    partial class QLDBD
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
            this.btnSuaDBD = new System.Windows.Forms.Button();
            this.btnXoaDBD = new System.Windows.Forms.Button();
            this.btnThemDBD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDiemBD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDiemBD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSuaDBD
            // 
            this.btnSuaDBD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDBD.Location = new System.Drawing.Point(321, 138);
            this.btnSuaDBD.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaDBD.Name = "btnSuaDBD";
            this.btnSuaDBD.Size = new System.Drawing.Size(107, 49);
            this.btnSuaDBD.TabIndex = 16;
            this.btnSuaDBD.Text = "Sửa";
            this.btnSuaDBD.UseVisualStyleBackColor = true;
            this.btnSuaDBD.Click += new System.EventHandler(this.btnSuaDBD_Click);
            // 
            // btnXoaDBD
            // 
            this.btnXoaDBD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDBD.Location = new System.Drawing.Point(175, 138);
            this.btnXoaDBD.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaDBD.Name = "btnXoaDBD";
            this.btnXoaDBD.Size = new System.Drawing.Size(108, 49);
            this.btnXoaDBD.TabIndex = 15;
            this.btnXoaDBD.Text = "Xóa";
            this.btnXoaDBD.UseVisualStyleBackColor = true;
            this.btnXoaDBD.Click += new System.EventHandler(this.btnXoaDBD_Click);
            // 
            // btnThemDBD
            // 
            this.btnThemDBD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDBD.Location = new System.Drawing.Point(31, 138);
            this.btnThemDBD.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemDBD.Name = "btnThemDBD";
            this.btnThemDBD.Size = new System.Drawing.Size(101, 49);
            this.btnThemDBD.TabIndex = 14;
            this.btnThemDBD.Text = "Thêm";
            this.btnThemDBD.UseVisualStyleBackColor = true;
            this.btnThemDBD.Click += new System.EventHandler(this.btnThemDBD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên điểm bắt đầu";
            // 
            // txtTenDiemBD
            // 
            this.txtTenDiemBD.Location = new System.Drawing.Point(186, 78);
            this.txtTenDiemBD.Margin = new System.Windows.Forms.Padding(6);
            this.txtTenDiemBD.Name = "txtTenDiemBD";
            this.txtTenDiemBD.Size = new System.Drawing.Size(304, 36);
            this.txtTenDiemBD.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã điểm bắt đầu";
            // 
            // txtMaDiemBD
            // 
            this.txtMaDiemBD.Location = new System.Drawing.Point(186, 26);
            this.txtMaDiemBD.Margin = new System.Windows.Forms.Padding(6);
            this.txtMaDiemBD.Name = "txtMaDiemBD";
            this.txtMaDiemBD.Size = new System.Drawing.Size(304, 36);
            this.txtMaDiemBD.TabIndex = 10;
            // 
            // QLDBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnSuaDBD);
            this.Controls.Add(this.btnXoaDBD);
            this.Controls.Add(this.btnThemDBD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenDiemBD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaDiemBD);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QLDBD";
            this.Size = new System.Drawing.Size(496, 213);
            this.Load += new System.EventHandler(this.QLDBD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSuaDBD;
        private System.Windows.Forms.Button btnXoaDBD;
        private System.Windows.Forms.Button btnThemDBD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDiemBD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDiemBD;
    }
}
