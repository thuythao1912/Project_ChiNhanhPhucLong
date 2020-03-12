namespace ChiNhanhPhucLong
{
    partial class frmTK_ChiNhanhToanQuoc
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
            this.crChiNhanh = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crChiNhanh
            // 
            this.crChiNhanh.ActiveViewIndex = -1;
            this.crChiNhanh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crChiNhanh.Cursor = System.Windows.Forms.Cursors.Default;
            this.crChiNhanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crChiNhanh.Location = new System.Drawing.Point(0, 0);
            this.crChiNhanh.Name = "crChiNhanh";
            this.crChiNhanh.Size = new System.Drawing.Size(1026, 658);
            this.crChiNhanh.TabIndex = 0;
            // 
            // frmTK_ChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 658);
            this.Controls.Add(this.crChiNhanh);
            this.Name = "frmTK_ChiNhanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTK_ChiNhanh";
            this.Load += new System.EventHandler(this.frmTK_ChiNhanh_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crChiNhanh;
    }
}