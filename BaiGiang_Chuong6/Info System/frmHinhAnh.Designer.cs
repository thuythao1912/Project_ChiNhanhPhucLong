namespace ChiNhanhPhucLong
{
    partial class frmHinhAnh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHinhAnh));
            this.label5 = new System.Windows.Forms.Label();
            this.txtChonFile = new System.Windows.Forms.TextBox();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.cboChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnKhongLuu = new System.Windows.Forms.Button();
            this.dgvHinhAnh = new System.Windows.Forms.DataGridView();
            this.pcAvatar = new System.Windows.Forms.PictureBox();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(163, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(336, 37);
            this.label5.TabIndex = 17;
            this.label5.Text = "Danh Sách Hình Ảnh";
            // 
            // txtChonFile
            // 
            this.txtChonFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChonFile.Location = new System.Drawing.Point(196, 119);
            this.txtChonFile.Name = "txtChonFile";
            this.txtChonFile.Size = new System.Drawing.Size(343, 22);
            this.txtChonFile.TabIndex = 18;
            this.txtChonFile.TextChanged += new System.EventHandler(this.txtChonFile_TextChanged);
            // 
            // btnChonFile
            // 
            this.btnChonFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(58)))));
            this.btnChonFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChonFile.Location = new System.Drawing.Point(87, 117);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(85, 31);
            this.btnChonFile.TabIndex = 19;
            this.btnChonFile.Text = "Chọn";
            this.btnChonFile.UseVisualStyleBackColor = false;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // cboChiNhanh
            // 
            this.cboChiNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChiNhanh.FormattingEnabled = true;
            this.cboChiNhanh.Location = new System.Drawing.Point(196, 76);
            this.cboChiNhanh.Name = "cboChiNhanh";
            this.cboChiNhanh.Size = new System.Drawing.Size(343, 28);
            this.cboChiNhanh.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Chi nhánh";
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(58)))));
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLuu.Location = new System.Drawing.Point(258, 160);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(88, 30);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnKhongLuu
            // 
            this.btnKhongLuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKhongLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(58)))));
            this.btnKhongLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhongLuu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKhongLuu.Location = new System.Drawing.Point(363, 159);
            this.btnKhongLuu.Name = "btnKhongLuu";
            this.btnKhongLuu.Size = new System.Drawing.Size(93, 30);
            this.btnKhongLuu.TabIndex = 19;
            this.btnKhongLuu.Text = "Không lưu";
            this.btnKhongLuu.UseVisualStyleBackColor = false;
            this.btnKhongLuu.Click += new System.EventHandler(this.btnKhongLuu_Click);
            // 
            // dgvHinhAnh
            // 
            this.dgvHinhAnh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHinhAnh.Location = new System.Drawing.Point(23, 215);
            this.dgvHinhAnh.Name = "dgvHinhAnh";
            this.dgvHinhAnh.Size = new System.Drawing.Size(360, 176);
            this.dgvHinhAnh.TabIndex = 23;
            this.dgvHinhAnh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHinhAnh_CellClick);
            // 
            // pcAvatar
            // 
            this.pcAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pcAvatar.Image")));
            this.pcAvatar.Location = new System.Drawing.Point(408, 215);
            this.pcAvatar.Name = "pcAvatar";
            this.pcAvatar.Size = new System.Drawing.Size(205, 176);
            this.pcAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcAvatar.TabIndex = 24;
            this.pcAvatar.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(58)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.Location = new System.Drawing.Point(155, 406);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 30);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa hình";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmHinhAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(637, 463);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.pcAvatar);
            this.Controls.Add(this.dgvHinhAnh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboChiNhanh);
            this.Controls.Add(this.btnKhongLuu);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnChonFile);
            this.Controls.Add(this.txtChonFile);
            this.Controls.Add(this.label5);
            this.Name = "frmHinhAnh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHinhAnh";
            this.Load += new System.EventHandler(this.frmHinhAnh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtChonFile;
        private System.Windows.Forms.Button btnChonFile;
        private System.Windows.Forms.ComboBox cboChiNhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnKhongLuu;
        private System.Windows.Forms.DataGridView dgvHinhAnh;
        private System.Windows.Forms.PictureBox pcAvatar;
        private System.Windows.Forms.Button btnXoa;
    }
}