namespace ChiNhanhPhucLong
{
    partial class frmTK_ChiNhanhTheoVung
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
            this.crChiNhanhTheoVung = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crChiNhanhTheoVung
            // 
            this.crChiNhanhTheoVung.ActiveViewIndex = -1;
            this.crChiNhanhTheoVung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crChiNhanhTheoVung.Cursor = System.Windows.Forms.Cursors.Default;
            this.crChiNhanhTheoVung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crChiNhanhTheoVung.Location = new System.Drawing.Point(0, 0);
            this.crChiNhanhTheoVung.Name = "crChiNhanhTheoVung";
            this.crChiNhanhTheoVung.Size = new System.Drawing.Size(1026, 658);
            this.crChiNhanhTheoVung.TabIndex = 0;
            // 
            // frmTK_ChiNhanhTheoVung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 658);
            this.Controls.Add(this.crChiNhanhTheoVung);
            this.Name = "frmTK_ChiNhanhTheoVung";
            this.Text = "frmTK_ChiNhanhTheoVung";
            this.Load += new System.EventHandler(this.frmTK_ChiNhanhTheoVung_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crChiNhanhTheoVung;

    }
}