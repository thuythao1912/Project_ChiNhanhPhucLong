namespace ChiNhanhPhucLong
{
    partial class MainForm
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
            //Ensures that any ESRI libraries that have been used are unloaded in the correct order. 
            //Failure to do this may result in random crashes on exit due to the operating system unloading 
            //the libraries in the incorrect order. 
            ESRI.ArcGIS.ADF.COMSupport.AOUninitialize.Shutdown();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuExitApp = new System.Windows.Forms.ToolStripMenuItem();
            this.MapControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMoFileMxd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLuuFileMxdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChonFeature = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBoChonFeature = new System.Windows.Forms.ToolStripMenuItem();
            this.đốiVớiTOCControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDatBuddyControl_TOCControl = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTaoContextMennuPopup = new System.Windows.Forms.ToolStripMenuItem();
            this.đốiVớiToolbarControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDatBuddyControl_ToolbarControl = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThemCongCuNetworkAnalyst = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBarXY = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.MapControlToolStripMenuItem,
            this.đốiVớiTOCControlToolStripMenuItem,
            this.đốiVớiToolbarControlToolStripMenuItem,
            this.menuTroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewDoc,
            this.menuOpenDoc,
            this.menuSaveDoc,
            this.menuSaveAs,
            this.menuSeparator,
            this.menuExitApp});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuNewDoc
            // 
            this.menuNewDoc.Image = ((System.Drawing.Image)(resources.GetObject("menuNewDoc.Image")));
            this.menuNewDoc.ImageTransparentColor = System.Drawing.Color.White;
            this.menuNewDoc.Name = "menuNewDoc";
            this.menuNewDoc.Size = new System.Drawing.Size(171, 22);
            this.menuNewDoc.Text = "New Document";
            this.menuNewDoc.Click += new System.EventHandler(this.menuNewDoc_Click);
            // 
            // menuOpenDoc
            // 
            this.menuOpenDoc.Image = ((System.Drawing.Image)(resources.GetObject("menuOpenDoc.Image")));
            this.menuOpenDoc.ImageTransparentColor = System.Drawing.Color.White;
            this.menuOpenDoc.Name = "menuOpenDoc";
            this.menuOpenDoc.Size = new System.Drawing.Size(171, 22);
            this.menuOpenDoc.Text = "Open Document...";
            this.menuOpenDoc.Click += new System.EventHandler(this.menuOpenDoc_Click);
            // 
            // menuSaveDoc
            // 
            this.menuSaveDoc.Image = ((System.Drawing.Image)(resources.GetObject("menuSaveDoc.Image")));
            this.menuSaveDoc.ImageTransparentColor = System.Drawing.Color.White;
            this.menuSaveDoc.Name = "menuSaveDoc";
            this.menuSaveDoc.Size = new System.Drawing.Size(171, 22);
            this.menuSaveDoc.Text = "SaveDocument";
            this.menuSaveDoc.Click += new System.EventHandler(this.menuSaveDoc_Click);
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Name = "menuSaveAs";
            this.menuSaveAs.Size = new System.Drawing.Size(171, 22);
            this.menuSaveAs.Text = "Save As...";
            this.menuSaveAs.Click += new System.EventHandler(this.menuSaveAs_Click);
            // 
            // menuSeparator
            // 
            this.menuSeparator.Name = "menuSeparator";
            this.menuSeparator.Size = new System.Drawing.Size(168, 6);
            // 
            // menuExitApp
            // 
            this.menuExitApp.Name = "menuExitApp";
            this.menuExitApp.Size = new System.Drawing.Size(171, 22);
            this.menuExitApp.Text = "Exit";
            this.menuExitApp.Click += new System.EventHandler(this.menuExitApp_Click);
            // 
            // MapControlToolStripMenuItem
            // 
            this.MapControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMoFileMxd,
            this.menuLuuFileMxdToolStripMenuItem,
            this.menuChonFeature,
            this.menuBoChonFeature});
            this.MapControlToolStripMenuItem.Name = "MapControlToolStripMenuItem";
            this.MapControlToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.MapControlToolStripMenuItem.Text = "Đối với MapControl";
            // 
            // menuMoFileMxd
            // 
            this.menuMoFileMxd.Name = "menuMoFileMxd";
            this.menuMoFileMxd.Size = new System.Drawing.Size(162, 22);
            this.menuMoFileMxd.Text = "Mở File Mxd";
            this.menuMoFileMxd.Click += new System.EventHandler(this.menuMoFileMxd_Click);
            // 
            // menuLuuFileMxdToolStripMenuItem
            // 
            this.menuLuuFileMxdToolStripMenuItem.Name = "menuLuuFileMxdToolStripMenuItem";
            this.menuLuuFileMxdToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.menuLuuFileMxdToolStripMenuItem.Text = "Lưu File Mxd";
            this.menuLuuFileMxdToolStripMenuItem.Click += new System.EventHandler(this.menuLuuFileMxdToolStripMenuItem_Click);
            // 
            // menuChonFeature
            // 
            this.menuChonFeature.Name = "menuChonFeature";
            this.menuChonFeature.Size = new System.Drawing.Size(162, 22);
            this.menuChonFeature.Text = "Chọn Feature";
            this.menuChonFeature.Click += new System.EventHandler(this.menuChonFeature_Click);
            // 
            // menuBoChonFeature
            // 
            this.menuBoChonFeature.Name = "menuBoChonFeature";
            this.menuBoChonFeature.Size = new System.Drawing.Size(162, 22);
            this.menuBoChonFeature.Text = "Bỏ Chọn Feature";
            this.menuBoChonFeature.Click += new System.EventHandler(this.menuBoChonFeature_Click);
            // 
            // đốiVớiTOCControlToolStripMenuItem
            // 
            this.đốiVớiTOCControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDatBuddyControl_TOCControl,
            this.menuTaoContextMennuPopup});
            this.đốiVớiTOCControlToolStripMenuItem.Name = "đốiVớiTOCControlToolStripMenuItem";
            this.đốiVớiTOCControlToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.đốiVớiTOCControlToolStripMenuItem.Text = "Đối với TOCControl";
            // 
            // menuDatBuddyControl_TOCControl
            // 
            this.menuDatBuddyControl_TOCControl.Name = "menuDatBuddyControl_TOCControl";
            this.menuDatBuddyControl_TOCControl.Size = new System.Drawing.Size(217, 22);
            this.menuDatBuddyControl_TOCControl.Text = "Đặt Buddy Control";
            this.menuDatBuddyControl_TOCControl.Click += new System.EventHandler(this.menuDatBuddyControl_TOCControl_Click);
            // 
            // menuTaoContextMennuPopup
            // 
            this.menuTaoContextMennuPopup.Name = "menuTaoContextMennuPopup";
            this.menuTaoContextMennuPopup.Size = new System.Drawing.Size(217, 22);
            this.menuTaoContextMennuPopup.Text = "Tạo Context Mennu Popup";
            this.menuTaoContextMennuPopup.Click += new System.EventHandler(this.menuTaoContextMennuPopup_Click);
            // 
            // đốiVớiToolbarControlToolStripMenuItem
            // 
            this.đốiVớiToolbarControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDatBuddyControl_ToolbarControl,
            this.menuThemCongCuNetworkAnalyst});
            this.đốiVớiToolbarControlToolStripMenuItem.Name = "đốiVớiToolbarControlToolStripMenuItem";
            this.đốiVớiToolbarControlToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.đốiVớiToolbarControlToolStripMenuItem.Text = "Đối với ToolbarControl";
            // 
            // menuDatBuddyControl_ToolbarControl
            // 
            this.menuDatBuddyControl_ToolbarControl.Name = "menuDatBuddyControl_ToolbarControl";
            this.menuDatBuddyControl_ToolbarControl.Size = new System.Drawing.Size(245, 22);
            this.menuDatBuddyControl_ToolbarControl.Text = "Đặt Buddy Control";
            this.menuDatBuddyControl_ToolbarControl.Click += new System.EventHandler(this.menuDatBuddyControl_ToolbarControl_Click);
            // 
            // menuThemCongCuNetworkAnalyst
            // 
            this.menuThemCongCuNetworkAnalyst.Name = "menuThemCongCuNetworkAnalyst";
            this.menuThemCongCuNetworkAnalyst.Size = new System.Drawing.Size(245, 22);
            this.menuThemCongCuNetworkAnalyst.Text = "Thêm Công Cụ Network Analyst";
            this.menuThemCongCuNetworkAnalyst.Click += new System.EventHandler(this.menuThemCongCuNetworkAnalyst_Click);
            // 
            // menuTroGiup
            // 
            this.menuTroGiup.Name = "menuTroGiup";
            this.menuTroGiup.Size = new System.Drawing.Size(63, 20);
            this.menuTroGiup.Text = "Trợ giúp";
            this.menuTroGiup.Click += new System.EventHandler(this.menuTroGiup_Click);
            // 
            // axMapControl1
            // 
            this.axMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl1.Location = new System.Drawing.Point(191, 52);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(668, 512);
            this.axMapControl1.TabIndex = 2;
            this.axMapControl1.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl1_OnMouseMove);
            this.axMapControl1.OnSelectionChanged += new System.EventHandler(this.axMapControl1_OnSelectionChanged);
            this.axMapControl1.OnMapReplaced += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMapReplacedEventHandler(this.axMapControl1_OnMapReplaced);
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.axToolbarControl1.Location = new System.Drawing.Point(0, 24);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(859, 28);
            this.axToolbarControl1.TabIndex = 3;
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.axTOCControl1.Location = new System.Drawing.Point(3, 52);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(188, 512);
            this.axTOCControl1.TabIndex = 4;
            this.axTOCControl1.OnMouseDown += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseDownEventHandler(this.axTOCControl1_OnMouseDown);
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(466, 278);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 5;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 52);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 534);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarXY});
            this.statusStrip1.Location = new System.Drawing.Point(3, 564);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(856, 22);
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusBar1";
            // 
            // statusBarXY
            // 
            this.statusBarXY.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.statusBarXY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusBarXY.Name = "statusBarXY";
            this.statusBarXY.Size = new System.Drawing.Size(49, 17);
            this.statusBarXY.Text = "Test 123";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 586);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.axMapControl1);
            this.Controls.Add(this.axTOCControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.axToolbarControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArcEngine Controls Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuNewDoc;
        private System.Windows.Forms.ToolStripMenuItem menuOpenDoc;
        private System.Windows.Forms.ToolStripMenuItem menuSaveDoc;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuExitApp;
        private System.Windows.Forms.ToolStripSeparator menuSeparator;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBarXY;
        private System.Windows.Forms.ToolStripMenuItem MapControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đốiVớiTOCControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDatBuddyControl_TOCControl;
        private System.Windows.Forms.ToolStripMenuItem đốiVớiToolbarControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuTaoContextMennuPopup;
        private System.Windows.Forms.ToolStripMenuItem menuDatBuddyControl_ToolbarControl;
        private System.Windows.Forms.ToolStripMenuItem menuMoFileMxd;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem menuLuuFileMxdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuChonFeature;
        private System.Windows.Forms.ToolStripMenuItem menuThemCongCuNetworkAnalyst;
        private System.Windows.Forms.ToolStripMenuItem menuBoChonFeature;
        private System.Windows.Forms.ToolStripMenuItem menuTroGiup;
    }
}

