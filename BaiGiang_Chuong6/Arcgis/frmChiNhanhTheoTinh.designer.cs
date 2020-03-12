namespace ChiNhanhPhucLong
{
    partial class frmChiNhanhTheoTinh
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
            this.dgvChiNhanhTheoTinh = new System.Windows.Forms.DataGridView();
            this.txtIdTinh = new System.Windows.Forms.Label();
            this.txtChiNhanhTheoTinh = new System.Windows.Forms.Label();
            this.txtVung = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiNhanhTheoTinh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChiNhanhTheoTinh
            // 
            this.dgvChiNhanhTheoTinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiNhanhTheoTinh.Location = new System.Drawing.Point(44, 111);
            this.dgvChiNhanhTheoTinh.Name = "dgvChiNhanhTheoTinh";
            this.dgvChiNhanhTheoTinh.Size = new System.Drawing.Size(780, 180);
            this.dgvChiNhanhTheoTinh.TabIndex = 18;
            this.dgvChiNhanhTheoTinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiNhanhTheoTinh_CellClick);
            // 
            // txtIdTinh
            // 
            this.txtIdTinh.AutoSize = true;
            this.txtIdTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdTinh.ForeColor = System.Drawing.Color.Tomato;
            this.txtIdTinh.Location = new System.Drawing.Point(530, 21);
            this.txtIdTinh.Name = "txtIdTinh";
            this.txtIdTinh.Size = new System.Drawing.Size(50, 37);
            this.txtIdTinh.TabIndex = 36;
            this.txtIdTinh.Text = "ID";
            this.txtIdTinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtChiNhanhTheoTinh
            // 
            this.txtChiNhanhTheoTinh.AutoSize = true;
            this.txtChiNhanhTheoTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiNhanhTheoTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(58)))));
            this.txtChiNhanhTheoTinh.Location = new System.Drawing.Point(58, 21);
            this.txtChiNhanhTheoTinh.Name = "txtChiNhanhTheoTinh";
            this.txtChiNhanhTheoTinh.Size = new System.Drawing.Size(477, 37);
            this.txtChiNhanhTheoTinh.TabIndex = 37;
            this.txtChiNhanhTheoTinh.Text = "DANH SÁCH CHI NHÁNH TẠI";
            // 
            // txtVung
            // 
            this.txtVung.AutoSize = true;
            this.txtVung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVung.Location = new System.Drawing.Point(358, 69);
            this.txtVung.Name = "txtVung";
            this.txtVung.Size = new System.Drawing.Size(60, 24);
            this.txtVung.TabIndex = 38;
            this.txtVung.Text = "label1";
            this.txtVung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Vùng:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmChiNhanhTheoTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVung);
            this.Controls.Add(this.txtChiNhanhTheoTinh);
            this.Controls.Add(this.txtIdTinh);
            this.Controls.Add(this.dgvChiNhanhTheoTinh);
            this.Name = "frmChiNhanhTheoTinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Chi Nhánh";
            this.Load += new System.EventHandler(this.frmChiNhanhTheoTinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiNhanhTheoTinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChiNhanhTheoTinh;
        private System.Windows.Forms.Label txtIdTinh;
        private System.Windows.Forms.Label txtChiNhanhTheoTinh;
        private System.Windows.Forms.Label txtVung;
        private System.Windows.Forms.Label label1;
    }
}