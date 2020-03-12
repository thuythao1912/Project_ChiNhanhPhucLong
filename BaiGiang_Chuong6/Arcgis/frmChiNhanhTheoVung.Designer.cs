namespace ChiNhanhPhucLong
{
    partial class frmChiNhanhTheoVung
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
            this.txtChiNhanhTheoTinh = new System.Windows.Forms.Label();
            this.txtIdVung = new System.Windows.Forms.Label();
            this.dgvChiNhanhTheoVung = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiNhanhTheoVung)).BeginInit();
            this.SuspendLayout();
            // 
            // txtChiNhanhTheoTinh
            // 
            this.txtChiNhanhTheoTinh.AutoSize = true;
            this.txtChiNhanhTheoTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiNhanhTheoTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(58)))));
            this.txtChiNhanhTheoTinh.Location = new System.Drawing.Point(81, 16);
            this.txtChiNhanhTheoTinh.Name = "txtChiNhanhTheoTinh";
            this.txtChiNhanhTheoTinh.Size = new System.Drawing.Size(346, 25);
            this.txtChiNhanhTheoTinh.TabIndex = 43;
            this.txtChiNhanhTheoTinh.Text = "DANH SÁCH CHI NHÁNH VÙNG";
            // 
            // txtIdVung
            // 
            this.txtIdVung.AutoSize = true;
            this.txtIdVung.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdVung.ForeColor = System.Drawing.Color.Tomato;
            this.txtIdVung.Location = new System.Drawing.Point(433, 16);
            this.txtIdVung.Name = "txtIdVung";
            this.txtIdVung.Size = new System.Drawing.Size(34, 25);
            this.txtIdVung.TabIndex = 42;
            this.txtIdVung.Text = "ID";
            this.txtIdVung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvChiNhanhTheoVung
            // 
            this.dgvChiNhanhTheoVung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiNhanhTheoVung.Location = new System.Drawing.Point(12, 54);
            this.dgvChiNhanhTheoVung.Name = "dgvChiNhanhTheoVung";
            this.dgvChiNhanhTheoVung.Size = new System.Drawing.Size(965, 180);
            this.dgvChiNhanhTheoVung.TabIndex = 41;
            this.dgvChiNhanhTheoVung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiNhanhTheoVung_CellClick);
            // 
            // frmChiNhanhTheoVung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 261);
            this.Controls.Add(this.txtChiNhanhTheoTinh);
            this.Controls.Add(this.txtIdVung);
            this.Controls.Add(this.dgvChiNhanhTheoVung);
            this.Name = "frmChiNhanhTheoVung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChiNhanhTheoVung";
            this.Load += new System.EventHandler(this.frmChiNhanhTheoVung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiNhanhTheoVung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtChiNhanhTheoTinh;
        private System.Windows.Forms.Label txtIdVung;
        private System.Windows.Forms.DataGridView dgvChiNhanhTheoVung;
    }
}