using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;

using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.ADF;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Geodatabase;
using ContextMenu;

namespace ChiNhanhPhucLong
{
    public sealed partial class MainForm : Form
    {
        #region class private members
        private IMapControl3 m_mapControl = null;
        private string m_mapDocumentName = string.Empty;

        //De tao contextMenu + voi m_mapControl o tren
        private ITOCControl2 m_tocControl;
        private IToolbarMenu m_menuMap;
        private IToolbarMenu m_menuLayer;

        #endregion

        #region class constructor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            //get the MapControl
            m_mapControl = (IMapControl3)axMapControl1.Object;

            //disable the Save menu (since there is no document yet)
            menuSaveDoc.Enabled = false;

            //De tao Context Menu Ref: GeoMetry, Using: ContextMenu
            //Bat dau ContextMenu
            m_tocControl = (ITOCControl2)axTOCControl1.Object;  //Da co o tren
            m_mapControl = (IMapControl3)axMapControl1.Object;

            //Add custom commands to the map menu
            m_menuMap = new ToolbarMenu();
            m_menuMap.AddItem(new LayerVisibility(), 1, 0, false, esriCommandStyles.esriCommandStyleTextOnly);
            m_menuMap.AddItem(new LayerVisibility(), 2, 1, false, esriCommandStyles.esriCommandStyleTextOnly);
            //Add pre-defined menu to the map menu as a sub menu 
            m_menuMap.AddSubMenu("esriControls.ControlsFeatureSelectionMenu", 2, true);

            //Add custom commands to the map menu
            m_menuLayer = new ToolbarMenu();
            m_menuLayer.AddItem(new RemoveLayer(), -1, 0, false, esriCommandStyles.esriCommandStyleTextOnly);
            m_menuLayer.AddItem(new ScaleThresholds(), 1, 1, true, esriCommandStyles.esriCommandStyleTextOnly);
            m_menuLayer.AddItem(new ScaleThresholds(), 2, 2, false, esriCommandStyles.esriCommandStyleTextOnly);
            m_menuLayer.AddItem(new ScaleThresholds(), 3, 3, false, esriCommandStyles.esriCommandStyleTextOnly);
            m_menuLayer.AddItem(new LayerSelectable(), 1, 4, true, esriCommandStyles.esriCommandStyleTextOnly);
            m_menuLayer.AddItem(new LayerSelectable(), 2, 5, false, esriCommandStyles.esriCommandStyleTextOnly);
            m_menuLayer.AddItem(new ZoomToLayer(), -1, 6, true, esriCommandStyles.esriCommandStyleTextOnly);

            //Set the hook of each menu
            m_menuLayer.SetHook(m_mapControl);
            m_menuMap.SetHook(m_mapControl);

        }

        #region Main Menu event handlers
        private void menuNewDoc_Click(object sender, EventArgs e)
        {
            //execute New Document command
            ICommand command = new CreateNewDocument();
            command.OnCreate(m_mapControl.Object);
            command.OnClick();
        }

        private void menuOpenDoc_Click(object sender, EventArgs e)
        {
            //execute Open Document command
            ICommand command = new ControlsOpenDocCommandClass();
            command.OnCreate(m_mapControl.Object);
            command.OnClick();
        }

        private void menuSaveDoc_Click(object sender, EventArgs e)
        {
            //execute Save Document command
            if (m_mapControl.CheckMxFile(m_mapDocumentName))
            {
                //create a new instance of a MapDocument
                IMapDocument mapDoc = new MapDocumentClass();
                mapDoc.Open(m_mapDocumentName, string.Empty);

                //Make sure that the MapDocument is not readonly
                if (mapDoc.get_IsReadOnly(m_mapDocumentName))
                {
                    MessageBox.Show("Map document is read only!");
                    mapDoc.Close();
                    return;
                }

                //Replace its contents with the current map
                mapDoc.ReplaceContents((IMxdContents)m_mapControl.Map);

                //save the MapDocument in order to persist it
                mapDoc.Save(mapDoc.UsesRelativePaths, false);

                //close the MapDocument
                mapDoc.Close();
            }
        }

        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            //execute SaveAs Document command
            ICommand command = new ControlsSaveAsDocCommandClass();
            command.OnCreate(m_mapControl.Object);
            command.OnClick();
        }

        private void menuExitApp_Click(object sender, EventArgs e)
        {
            //exit the application
            Application.Exit();
        }
        #endregion

        //listen to MapReplaced evant in order to update the statusbar and the Save menu
        private void axMapControl1_OnMapReplaced(object sender, IMapControlEvents2_OnMapReplacedEvent e)
        {
            //get the current document name from the MapControl
            m_mapDocumentName = m_mapControl.DocumentFilename;

            //if there is no MapDocument, diable the Save menu and clear the statusbar
            if (m_mapDocumentName == string.Empty)
            {
                menuSaveDoc.Enabled = false;
                statusBarXY.Text = string.Empty;
            }
            else
            {
                //enable the Save manu and write the doc name to the statusbar
                menuSaveDoc.Enabled = true;
                statusBarXY.Text = Path.GetFileName(m_mapDocumentName);
            }
        }

        private void axMapControl1_OnMouseMove(object sender, IMapControlEvents2_OnMouseMoveEvent e)
        {
            statusBarXY.Text = string.Format("{0}, {1}  {2}", e.mapX.ToString("#######.##"), e.mapY.ToString("#######.##"), axMapControl1.MapUnits.ToString().Substring(4));
        }

        private void axTOCControl1_OnMouseDown(object sender, ITOCControlEvents_OnMouseDownEvent e)
        {
            if (e.button != 2) return;

            esriTOCControlItem item = esriTOCControlItem.esriTOCControlItemNone;
            IBasicMap map = null;
            ILayer layer = null;
            object other = null;
            object index = null;

            //Determine what kind of item is selected
            m_tocControl.HitTest(e.x, e.y, ref item, ref map, ref layer, ref other, ref index);

            //Ensure the item gets selected 
            if (item == esriTOCControlItem.esriTOCControlItemMap)
                m_tocControl.SelectItem(map, null);
            else
                m_tocControl.SelectItem(layer, null);

            //Set the layer into the CustomProperty (this is used by the custom layer commands)			
            m_mapControl.CustomProperty = layer;

            //Popup the correct context menu
            if (item == esriTOCControlItem.esriTOCControlItemMap) m_menuMap.PopupMenu(e.x, e.y, m_tocControl.hWnd);
            if (item == esriTOCControlItem.esriTOCControlItemLayer) m_menuLayer.PopupMenu(e.x, e.y, m_tocControl.hWnd);

        }

        private void menuTaoContextMennuPopup_Click(object sender, EventArgs e)
        {
            //De tao Context Menu Ref: GeoMetry, Using: ContextMenu
            //Bat dau ContextMenu
            m_tocControl = (ITOCControl2)axTOCControl1.Object;  //Da co o tren
            m_mapControl = (IMapControl3)axMapControl1.Object;

            //Add custom commands to the map menu
            m_menuMap = new ToolbarMenu();
            m_menuMap.AddItem(new LayerVisibility(), 1, 0, false, esriCommandStyles.esriCommandStyleTextOnly);
            m_menuMap.AddItem(new LayerVisibility(), 2, 1, false, esriCommandStyles.esriCommandStyleTextOnly);
            //Add pre-defined menu to the map menu as a sub menu 
            m_menuMap.AddSubMenu("esriControls.ControlsFeatureSelectionMenu", 2, true);

            //Add custom commands to the map menu
            m_menuLayer = new ToolbarMenu();
            m_menuLayer.AddItem(new RemoveLayer(), -1, 0, false, esriCommandStyles.esriCommandStyleTextOnly);
            m_menuLayer.AddItem(new ScaleThresholds(), 1, 1, true, esriCommandStyles.esriCommandStyleTextOnly);
            m_menuLayer.AddItem(new ScaleThresholds(), 2, 2, false, esriCommandStyles.esriCommandStyleTextOnly);
            m_menuLayer.AddItem(new ScaleThresholds(), 3, 3, false, esriCommandStyles.esriCommandStyleTextOnly);
            m_menuLayer.AddItem(new LayerSelectable(), 1, 4, true, esriCommandStyles.esriCommandStyleTextOnly);
            m_menuLayer.AddItem(new LayerSelectable(), 2, 5, false, esriCommandStyles.esriCommandStyleTextOnly);
            m_menuLayer.AddItem(new ZoomToLayer(), -1, 6, true, esriCommandStyles.esriCommandStyleTextOnly);

            //Set the hook of each menu
            m_menuLayer.SetHook(m_mapControl);
            m_menuMap.SetHook(m_mapControl);

        }

        private void menuDatBuddyControl_TOCControl_Click(object sender, EventArgs e)
        {
            axTOCControl1.SetBuddyControl(axMapControl1);
        }

        private void menuDatBuddyControl_ToolbarControl_Click(object sender, EventArgs e)
        {
            axToolbarControl1.SetBuddyControl(axMapControl1);
        }

        private void menuMoFileMxd_Click(object sender, EventArgs e)
        {
            //Them dieu khien: OpenFileDialog1
            openFileDialog1.Title = "Tìm File Mxd";
            openFileDialog1.Filter = "Map Documents (*.mxd) | *.mxd";
            openFileDialog1.InitialDirectory = @"D:\Giao trinh\Gis\Dulieu";
            openFileDialog1.ShowDialog();
            string sFilePath;
            sFilePath = openFileDialog1.FileName;
            if (axMapControl1.CheckMxFile(sFilePath))
                axMapControl1.LoadMxFile(sFilePath);
            axMapControl1.Extent = axMapControl1.FullExtent;
        }

        private void menuLuuFileMxdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IMapDocument mapDoc = new MapDocument();
            mapDoc.Open(axMapControl1.DocumentFilename, string.Empty);
            mapDoc.ReplaceContents((IMxdContents)axMapControl1.Map);
            mapDoc.Save(mapDoc.UsesRelativePaths, true);
            mapDoc.Close();


        }

        private void menuChonFeature_Click(object sender, EventArgs e)
        {
            ICommand command = new ControlsSelectFeaturesTool();
            command.OnCreate(axMapControl1.Object);
            axMapControl1.CurrentTool = (ITool)command;
            Toancuc.cancelselection = false;

        }

        private void menuThemCongCuNetworkAnalyst_Click(object sender, EventArgs e)
        {
            axToolbarControl1.AddItem("esriControls.ControlsNetworkAnalystToolbar", 0, -1, false, 0, esriCommandStyles.esriCommandStyleIconOnly);
        }

        private void menuBoChonFeature_Click(object sender, EventArgs e)
        {
            Toancuc.cancelselection = true;
            axMapControl1.CurrentTool = null;
            axMapControl1.Map.ClearSelection();
            axMapControl1.Refresh();
        }

        private void axMapControl1_OnSelectionChanged(object sender, EventArgs e)
        {

            if (Toancuc.cancelselection == true) return;

            //Add Ref: GeoDatabase, Using:GeoDatabase
            IMap map = axMapControl1.Map;

            IEnumFeatureSetup enumfeaturesetup = (IEnumFeatureSetup)map.FeatureSelection;
            enumfeaturesetup.AllFields = true;

            IEnumFeature enumfeature = (IEnumFeature)enumfeaturesetup;

            IFeature feature = enumfeature.Next();

            try
            {
                IFields fields = feature.Fields;

                if (fields.FindField("MA") >= 0)
                {
                    Toancuc.ma = feature.get_Value(fields.FindField("MA"));
                    if (Toancuc.ma[0] == 'D')
                    {
                        frmChiTietChiNhanh frm;
                        bool hasShown = false;
                        foreach (var item in Application.OpenForms)
                        {
                            if (item is frmChiTietChiNhanh)
                            {
                                frm = ((frmChiTietChiNhanh)item);
                                frm.Activate();
                                hasShown = true;
                            }
                        }
                        if (hasShown == false)
                        {
                            frmChiTietChiNhanh form = new frmChiTietChiNhanh(Toancuc.ma);
                            form.ShowDialog();
                        }
                    }
                    else if (Toancuc.ma[0] == 'T')
                    {
                        frmChiNhanhTheoTinh frm;
                        bool hasShown = false;
                        foreach (var item in Application.OpenForms)
                        {
                            if (item is frmChiNhanhTheoTinh)
                            {
                                frm = ((frmChiNhanhTheoTinh)item);
                                frm.Activate();
                                hasShown = true;
                            }
                        }
                        if (hasShown == false)
                        {
                            frmChiNhanhTheoTinh form = new frmChiNhanhTheoTinh(Toancuc.ma);
                            form.ShowDialog();
                        }
                    }
                    else if (Toancuc.ma[0] == 'V')
                    {
                        frmChiNhanhTheoVung frm;
                        bool hasShown = false;
                        foreach (var item in Application.OpenForms)
                        {
                            if (item is frmChiNhanhTheoVung)
                            {
                                frm = ((frmChiNhanhTheoVung)item);
                                frm.Activate();
                                hasShown = true;
                            }
                        }
                        if (hasShown == false)
                        {
                            frmChiNhanhTheoVung form = new frmChiNhanhTheoVung(Toancuc.ma);
                            form.ShowDialog();
                        }
                    }
                }

                else
                {
                    Toancuc.ma = "KHONG CO TRUONG MA";
                    MessageBox.Show("Không tìm thấy dữ liệu!", "Thông báo");
                }
            }
            catch { 
                MessageBox.Show("Đã có lỗi xảy ra! Vui lòng thử lại!", "Thông báo");
            }

        }

        private void menuTroGiup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xin liên hệ: TRẦN MINH ĐỨC - BÀNH NGỌC THỤY THẢO, Khoa CNTT & TT - ĐH Cần Thơ");
        }

    }
}