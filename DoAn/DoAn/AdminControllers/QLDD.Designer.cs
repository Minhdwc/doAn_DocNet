namespace DoAn.AdminControllers
{
    partial class QLDD
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
            this.dtGridViewDiemKT = new System.Windows.Forms.DataGridView();
            this.dtGridViewDiemBD = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewDiemKT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewDiemBD)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridViewDiemKT
            // 
            this.dtGridViewDiemKT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewDiemKT.Location = new System.Drawing.Point(416, 5);
            this.dtGridViewDiemKT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtGridViewDiemKT.Name = "dtGridViewDiemKT";
            this.dtGridViewDiemKT.RowHeadersWidth = 51;
            this.dtGridViewDiemKT.RowTemplate.Height = 24;
            this.dtGridViewDiemKT.Size = new System.Drawing.Size(399, 169);
            this.dtGridViewDiemKT.TabIndex = 16;
            this.dtGridViewDiemKT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewDiemKT_CellContentClick);
            // 
            // dtGridViewDiemBD
            // 
            this.dtGridViewDiemBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewDiemBD.Location = new System.Drawing.Point(4, 5);
            this.dtGridViewDiemBD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtGridViewDiemBD.Name = "dtGridViewDiemBD";
            this.dtGridViewDiemBD.RowHeadersWidth = 51;
            this.dtGridViewDiemBD.RowTemplate.Height = 24;
            this.dtGridViewDiemBD.Size = new System.Drawing.Size(399, 169);
            this.dtGridViewDiemBD.TabIndex = 15;
            this.dtGridViewDiemBD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewDiemBD_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtGridViewDiemBD);
            this.panel1.Controls.Add(this.dtGridViewDiemKT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 194);
            this.panel1.TabIndex = 18;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContainer.Location = new System.Drawing.Point(0, 194);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(817, 208);
            this.panelContainer.TabIndex = 17;
            // 
            // QLDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QLDD";
            this.Size = new System.Drawing.Size(817, 454);
            this.Load += new System.EventHandler(this.QLDD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewDiemKT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewDiemBD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridViewDiemKT;
        private System.Windows.Forms.DataGridView dtGridViewDiemBD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContainer;
    }
}
