namespace DoAn.AdminControllers
{
    partial class QLPT
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
            this.btnSuaPT = new System.Windows.Forms.Button();
            this.btnXoaPT = new System.Windows.Forms.Button();
            this.btnThemPT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenPT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSuaPT
            // 
            this.btnSuaPT.Location = new System.Drawing.Point(338, 90);
            this.btnSuaPT.Margin = new System.Windows.Forms.Padding(6);
            this.btnSuaPT.Name = "btnSuaPT";
            this.btnSuaPT.Size = new System.Drawing.Size(123, 44);
            this.btnSuaPT.TabIndex = 23;
            this.btnSuaPT.Text = "Sửa";
            this.btnSuaPT.UseVisualStyleBackColor = true;
            this.btnSuaPT.Click += new System.EventHandler(this.btnSuaPT_Click);
            // 
            // btnXoaPT
            // 
            this.btnXoaPT.Location = new System.Drawing.Point(180, 90);
            this.btnXoaPT.Margin = new System.Windows.Forms.Padding(6);
            this.btnXoaPT.Name = "btnXoaPT";
            this.btnXoaPT.Size = new System.Drawing.Size(123, 44);
            this.btnXoaPT.TabIndex = 22;
            this.btnXoaPT.Text = "Xóa";
            this.btnXoaPT.UseVisualStyleBackColor = true;
            this.btnXoaPT.Click += new System.EventHandler(this.btnXoaPT_Click);
            // 
            // btnThemPT
            // 
            this.btnThemPT.Location = new System.Drawing.Point(27, 90);
            this.btnThemPT.Margin = new System.Windows.Forms.Padding(6);
            this.btnThemPT.Name = "btnThemPT";
            this.btnThemPT.Size = new System.Drawing.Size(115, 44);
            this.btnThemPT.TabIndex = 21;
            this.btnThemPT.Text = "Thêm";
            this.btnThemPT.UseVisualStyleBackColor = true;
            this.btnThemPT.Click += new System.EventHandler(this.btnThemPT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 27);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên phương tiện";
            // 
            // txtTenPT
            // 
            this.txtTenPT.Location = new System.Drawing.Point(201, 50);
            this.txtTenPT.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtTenPT.Name = "txtTenPT";
            this.txtTenPT.Size = new System.Drawing.Size(293, 35);
            this.txtTenPT.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 27);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã phương tiện";
            // 
            // txtMaPT
            // 
            this.txtMaPT.Location = new System.Drawing.Point(201, 0);
            this.txtMaPT.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(293, 35);
            this.txtMaPT.TabIndex = 17;
            // 
            // QLPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnSuaPT);
            this.Controls.Add(this.btnXoaPT);
            this.Controls.Add(this.btnThemPT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenPT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaPT);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QLPT";
            this.Size = new System.Drawing.Size(553, 169);
            this.Load += new System.EventHandler(this.QLPT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSuaPT;
        private System.Windows.Forms.Button btnXoaPT;
        private System.Windows.Forms.Button btnThemPT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenPT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPT;
    }
}
