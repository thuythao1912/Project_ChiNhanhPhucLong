namespace ChiNhanhPhucLong
{
    partial class frmThemDanhGia
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
            this.txtTenChiNhanh = new System.Windows.Forms.Label();
            this.txtIDChiNhanh = new System.Windows.Forms.Label();
            this.txtDanhGia = new System.Windows.Forms.RichTextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTenChiNhanh
            // 
            this.txtTenChiNhanh.AutoSize = true;
            this.txtTenChiNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenChiNhanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(58)))));
            this.txtTenChiNhanh.Location = new System.Drawing.Point(92, 18);
            this.txtTenChiNhanh.Name = "txtTenChiNhanh";
            this.txtTenChiNhanh.Size = new System.Drawing.Size(264, 31);
            this.txtTenChiNhanh.TabIndex = 34;
            this.txtTenChiNhanh.Text = "Đánh giá chi nhánh";
            this.txtTenChiNhanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIDChiNhanh
            // 
            this.txtIDChiNhanh.AutoSize = true;
            this.txtIDChiNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDChiNhanh.ForeColor = System.Drawing.Color.Tomato;
            this.txtIDChiNhanh.Location = new System.Drawing.Point(354, 18);
            this.txtIDChiNhanh.Name = "txtIDChiNhanh";
            this.txtIDChiNhanh.Size = new System.Drawing.Size(44, 31);
            this.txtIDChiNhanh.TabIndex = 35;
            this.txtIDChiNhanh.Text = "ID";
            this.txtIDChiNhanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDanhGia
            // 
            this.txtDanhGia.Location = new System.Drawing.Point(48, 78);
            this.txtDanhGia.Name = "txtDanhGia";
            this.txtDanhGia.Size = new System.Drawing.Size(434, 126);
            this.txtDanhGia.TabIndex = 37;
            this.txtDanhGia.Text = "";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Tomato;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuu.Location = new System.Drawing.Point(146, 229);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 35);
            this.btnLuu.TabIndex = 38;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(58)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(276, 229);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 35);
            this.btnXoa.TabIndex = 38;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmThemDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 304);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtDanhGia);
            this.Controls.Add(this.txtIDChiNhanh);
            this.Controls.Add(this.txtTenChiNhanh);
            this.Name = "frmThemDanhGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemDanhGia";
            this.Load += new System.EventHandler(this.frmThemDanhGia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTenChiNhanh;
        private System.Windows.Forms.Label txtIDChiNhanh;
        private System.Windows.Forms.RichTextBox txtDanhGia;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
    }
}