namespace DoAn.AdminControllers
{
    partial class QLDV
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
            this.dtGridViewPT = new System.Windows.Forms.DataGridView();
            this.dtGridViewLoaiKS = new System.Windows.Forms.DataGridView();
            this.panelContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewLoaiKS)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridViewPT
            // 
            this.dtGridViewPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewPT.Location = new System.Drawing.Point(0, 0);
            this.dtGridViewPT.Margin = new System.Windows.Forms.Padding(4);
            this.dtGridViewPT.Name = "dtGridViewPT";
            this.dtGridViewPT.RowHeadersWidth = 51;
            this.dtGridViewPT.RowTemplate.Height = 24;
            this.dtGridViewPT.Size = new System.Drawing.Size(343, 135);
            this.dtGridViewPT.TabIndex = 1;
            this.dtGridViewPT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewPT_CellContentClick);
            // 
            // dtGridViewLoaiKS
            // 
            this.dtGridViewLoaiKS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewLoaiKS.Location = new System.Drawing.Point(363, 0);
            this.dtGridViewLoaiKS.Margin = new System.Windows.Forms.Padding(4);
            this.dtGridViewLoaiKS.Name = "dtGridViewLoaiKS";
            this.dtGridViewLoaiKS.RowHeadersWidth = 51;
            this.dtGridViewLoaiKS.RowTemplate.Height = 24;
            this.dtGridViewLoaiKS.Size = new System.Drawing.Size(343, 135);
            this.dtGridViewLoaiKS.TabIndex = 2;
            this.dtGridViewLoaiKS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewLoaiKS_CellContentClick);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(3, 154);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(703, 239);
            this.panelContainer.TabIndex = 13;
            // 
            // QLDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.dtGridViewPT);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.dtGridViewLoaiKS);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QLDV";
            this.Size = new System.Drawing.Size(726, 420);
            this.Load += new System.EventHandler(this.QLDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewLoaiKS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGridViewPT;
        private System.Windows.Forms.DataGridView dtGridViewLoaiKS;
        private System.Windows.Forms.Panel panelContainer;
    }
}
