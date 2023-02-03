namespace ProductManagement.Forms
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRule3ColorScale formatConditionRule3ColorScale2 = new DevExpress.XtraEditors.FormatConditionRule3ColorScale();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition7 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition8 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition9 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition10 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraPrinting.BarCode.EAN13Generator eaN13Generator2 = new DevExpress.XtraPrinting.BarCode.EAN13Generator();
            DevExpress.XtraPrinting.BarCode.EAN8Generator eaN8Generator2 = new DevExpress.XtraPrinting.BarCode.EAN8Generator();
            this.colSavedDateTime = new ProductManagement.UserControls.Grids.MyGridColumn();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnProducts = new DevExpress.XtraBars.BarButtonItem();
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnExport = new DevExpress.XtraBars.BarSubItem();
            this.btnExcelFiles = new DevExpress.XtraBars.BarSubItem();
            this.btnExcelFileStandard = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcelFileFormatted = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcelFileUnformatted = new DevExpress.XtraBars.BarButtonItem();
            this.btnWordFile = new DevExpress.XtraBars.BarButtonItem();
            this.btnPdfFile = new DevExpress.XtraBars.BarButtonItem();
            this.btnTxtFile = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnColumns = new DevExpress.XtraBars.BarButtonItem();
            this.barNew = new DevExpress.XtraBars.BarStaticItem();
            this.barNewDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barSave = new DevExpress.XtraBars.BarStaticItem();
            this.barSaveDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barUpdate = new DevExpress.XtraBars.BarStaticItem();
            this.barUpdateDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barDelete = new DevExpress.XtraBars.BarStaticItem();
            this.barDeleteDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barRefresh = new DevExpress.XtraBars.BarStaticItem();
            this.barRefreshDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barColumns = new DevExpress.XtraBars.BarStaticItem();
            this.barColumnsDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barExport = new DevExpress.XtraBars.BarStaticItem();
            this.barExportDescription = new DevExpress.XtraBars.BarStaticItem();
            this.barExit = new DevExpress.XtraBars.BarStaticItem();
            this.barExitDescription = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPageProducts = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControlProducts = new ProductManagement.UserControls.Grids.MyGridControl();
            this.gridViewProducts = new ProductManagement.UserControls.Grids.MyGridView();
            this.colProductID = new ProductManagement.UserControls.Grids.MyGridColumn();
            this.colBoxNumber = new ProductManagement.UserControls.Grids.MyGridColumn();
            this.colEan8 = new ProductManagement.UserControls.Grids.MyGridColumn();
            this.colEan13 = new ProductManagement.UserControls.Grids.MyGridColumn();
            this.colProductName = new ProductManagement.UserControls.Grids.MyGridColumn();
            this.longNavigator = new ProductManagement.UserControls.Navigators.LongNavigator();
            this.myDataLayoutControl = new ProductManagement.UserControls.Controls.MyDataLayoutControl();
            this.txtProductName = new ProductManagement.UserControls.Controls.MyMemoEdit();
            this.txtSavedDate = new ProductManagement.UserControls.Controls.MyDateEdit();
            this.txtEan13 = new ProductManagement.UserControls.Controls.MyTextEdit();
            this.txtEan8 = new ProductManagement.UserControls.Controls.MyTextEdit();
            this.txtBoxNumber = new ProductManagement.UserControls.Controls.MyTextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.barCodeControlEan13 = new DevExpress.XtraEditors.BarCodeControl();
            this.lblSearch = new DevExpress.XtraEditors.LabelControl();
            this.txtSearchEan13 = new ProductManagement.UserControls.Controls.MyTextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.barCodeControlEan8 = new DevExpress.XtraEditors.BarCodeControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSearchEan8 = new ProductManagement.UserControls.Controls.MyTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSavedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSavedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEan13.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEan8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchEan13.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchEan8.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // colSavedDateTime
            // 
            this.colSavedDateTime.AppearanceCell.Options.UseTextOptions = true;
            this.colSavedDateTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSavedDateTime.Caption = "Date Time";
            this.colSavedDateTime.FieldName = "SavedDateTime";
            this.colSavedDateTime.Name = "colSavedDateTime";
            this.colSavedDateTime.OptionsColumn.AllowEdit = false;
            this.colSavedDateTime.Visible = true;
            this.colSavedDateTime.VisibleIndex = 3;
            this.colSavedDateTime.Width = 150;
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnProducts,
            this.btnNew,
            this.btnUpdate,
            this.btnDelete,
            this.btnExit,
            this.btnExport,
            this.btnSave,
            this.btnColumns,
            this.btnExcelFiles,
            this.btnExcelFileStandard,
            this.btnWordFile,
            this.btnExcelFileFormatted,
            this.btnExcelFileUnformatted,
            this.btnPdfFile,
            this.btnTxtFile,
            this.barNew,
            this.barNewDescription,
            this.barSave,
            this.barSaveDescription,
            this.barUpdate,
            this.barUpdateDescription,
            this.barDelete,
            this.barDeleteDescription,
            this.barRefresh,
            this.barRefreshDescription,
            this.barColumns,
            this.barColumnsDescription,
            this.barExport,
            this.barExportDescription,
            this.barExit,
            this.barExitDescription});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 33;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageProducts});
            this.ribbon.Size = new System.Drawing.Size(1190, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnProducts
            // 
            this.btnProducts.Caption = "Products";
            this.btnProducts.Id = 1;
            this.btnProducts.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnProducts.ImageOptions.SvgImage")));
            this.btnProducts.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.btnProducts.Name = "btnProducts";
            // 
            // btnNew
            // 
            this.btnNew.Caption = "New";
            this.btnNew.Id = 2;
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.LargeImage")));
            this.btnNew.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1);
            this.btnNew.Name = "btnNew";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Update";
            this.btnUpdate.Id = 3;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.LargeImage")));
            this.btnUpdate.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3);
            this.btnUpdate.Name = "btnUpdate";
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete";
            this.btnDelete.Id = 4;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.LargeImage")));
            this.btnDelete.Name = "btnDelete";
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Exit";
            this.btnExit.Id = 6;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.LargeImage")));
            this.btnExit.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.btnExit.Name = "btnExit";
            // 
            // btnExport
            // 
            this.btnExport.Caption = "Export";
            this.btnExport.Id = 7;
            this.btnExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.ImageOptions.Image")));
            this.btnExport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExport.ImageOptions.LargeImage")));
            this.btnExport.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12);
            this.btnExport.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcelFiles),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnWordFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPdfFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTxtFile)});
            this.btnExport.Name = "btnExport";
            // 
            // btnExcelFiles
            // 
            this.btnExcelFiles.Caption = "Excel Files";
            this.btnExcelFiles.Id = 10;
            this.btnExcelFiles.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelFiles.ImageOptions.Image")));
            this.btnExcelFiles.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcelFileStandard),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcelFileFormatted),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcelFileUnformatted)});
            this.btnExcelFiles.Name = "btnExcelFiles";
            // 
            // btnExcelFileStandard
            // 
            this.btnExcelFileStandard.Caption = "Excel File (Standard)";
            this.btnExcelFileStandard.Id = 11;
            this.btnExcelFileStandard.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelFileStandard.ImageOptions.Image")));
            this.btnExcelFileStandard.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G), (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.btnExcelFileStandard.Name = "btnExcelFileStandard";
            // 
            // btnExcelFileFormatted
            // 
            this.btnExcelFileFormatted.Caption = "Excel File (Formatted)";
            this.btnExcelFileFormatted.Id = 13;
            this.btnExcelFileFormatted.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelFileFormatted.ImageOptions.Image")));
            this.btnExcelFileFormatted.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G), (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this.btnExcelFileFormatted.Name = "btnExcelFileFormatted";
            // 
            // btnExcelFileUnformatted
            // 
            this.btnExcelFileUnformatted.Caption = "Excel File (UnFormatted)";
            this.btnExcelFileUnformatted.Id = 14;
            this.btnExcelFileUnformatted.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelFileUnformatted.ImageOptions.Image")));
            this.btnExcelFileUnformatted.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G), (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z));
            this.btnExcelFileUnformatted.Name = "btnExcelFileUnformatted";
            // 
            // btnWordFile
            // 
            this.btnWordFile.Caption = "Word File";
            this.btnWordFile.Id = 12;
            this.btnWordFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnWordFile.ImageOptions.Image")));
            this.btnWordFile.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G), (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W));
            this.btnWordFile.Name = "btnWordFile";
            // 
            // btnPdfFile
            // 
            this.btnPdfFile.Caption = "Pdf File";
            this.btnPdfFile.Id = 15;
            this.btnPdfFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPdfFile.ImageOptions.Image")));
            this.btnPdfFile.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G), (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.btnPdfFile.Name = "btnPdfFile";
            // 
            // btnTxtFile
            // 
            this.btnTxtFile.Caption = "Txt File";
            this.btnTxtFile.Id = 16;
            this.btnTxtFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTxtFile.ImageOptions.Image")));
            this.btnTxtFile.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G), (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T));
            this.btnTxtFile.Name = "btnTxtFile";
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Save";
            this.btnSave.Id = 8;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.LargeImage")));
            this.btnSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2);
            this.btnSave.Name = "btnSave";
            // 
            // btnColumns
            // 
            this.btnColumns.Caption = "Columns";
            this.btnColumns.Id = 9;
            this.btnColumns.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnColumns.ImageOptions.Image")));
            this.btnColumns.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnColumns.ImageOptions.LargeImage")));
            this.btnColumns.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C));
            this.btnColumns.Name = "btnColumns";
            // 
            // barNew
            // 
            this.barNew.Caption = "F1 :";
            this.barNew.Id = 17;
            this.barNew.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barNew.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barNew.ItemAppearance.Normal.Options.UseFont = true;
            this.barNew.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barNew.Name = "barNew";
            // 
            // barNewDescription
            // 
            this.barNewDescription.Caption = "New";
            this.barNewDescription.Id = 18;
            this.barNewDescription.Name = "barNewDescription";
            // 
            // barSave
            // 
            this.barSave.Caption = "F2 :";
            this.barSave.Id = 19;
            this.barSave.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barSave.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barSave.ItemAppearance.Normal.Options.UseFont = true;
            this.barSave.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barSave.Name = "barSave";
            // 
            // barSaveDescription
            // 
            this.barSaveDescription.Caption = "Save";
            this.barSaveDescription.Id = 20;
            this.barSaveDescription.Name = "barSaveDescription";
            // 
            // barUpdate
            // 
            this.barUpdate.Caption = "F3 :";
            this.barUpdate.Id = 21;
            this.barUpdate.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barUpdate.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barUpdate.ItemAppearance.Normal.Options.UseFont = true;
            this.barUpdate.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barUpdate.Name = "barUpdate";
            // 
            // barUpdateDescription
            // 
            this.barUpdateDescription.Caption = "Update";
            this.barUpdateDescription.Id = 22;
            this.barUpdateDescription.Name = "barUpdateDescription";
            // 
            // barDelete
            // 
            this.barDelete.Caption = "Del :";
            this.barDelete.Id = 23;
            this.barDelete.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barDelete.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barDelete.ItemAppearance.Normal.Options.UseFont = true;
            this.barDelete.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barDelete.Name = "barDelete";
            // 
            // barDeleteDescription
            // 
            this.barDeleteDescription.Caption = "Delete";
            this.barDeleteDescription.Id = 24;
            this.barDeleteDescription.Name = "barDeleteDescription";
            // 
            // barRefresh
            // 
            this.barRefresh.Caption = "F5 :";
            this.barRefresh.Id = 25;
            this.barRefresh.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barRefresh.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barRefresh.ItemAppearance.Normal.Options.UseFont = true;
            this.barRefresh.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barRefresh.Name = "barRefresh";
            // 
            // barRefreshDescription
            // 
            this.barRefreshDescription.Caption = "Refresh Products";
            this.barRefreshDescription.Id = 26;
            this.barRefreshDescription.Name = "barRefreshDescription";
            // 
            // barColumns
            // 
            this.barColumns.Caption = "Alt + C :";
            this.barColumns.Id = 27;
            this.barColumns.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barColumns.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barColumns.ItemAppearance.Normal.Options.UseFont = true;
            this.barColumns.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barColumns.Name = "barColumns";
            // 
            // barColumnsDescription
            // 
            this.barColumnsDescription.Caption = "Columns";
            this.barColumnsDescription.Id = 28;
            this.barColumnsDescription.Name = "barColumnsDescription";
            // 
            // barExport
            // 
            this.barExport.Caption = "F12 :";
            this.barExport.Id = 29;
            this.barExport.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barExport.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barExport.ItemAppearance.Normal.Options.UseFont = true;
            this.barExport.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barExport.Name = "barExport";
            // 
            // barExportDescription
            // 
            this.barExportDescription.Caption = "Export";
            this.barExportDescription.Id = 30;
            this.barExportDescription.Name = "barExportDescription";
            // 
            // barExit
            // 
            this.barExit.Caption = "Ctrl + E :";
            this.barExit.Id = 31;
            this.barExit.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barExit.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barExit.ItemAppearance.Normal.Options.UseFont = true;
            this.barExit.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barExit.Name = "barExit";
            // 
            // barExitDescription
            // 
            this.barExitDescription.Caption = "Exit";
            this.barExitDescription.Id = 32;
            this.barExitDescription.Name = "barExitDescription";
            // 
            // ribbonPageProducts
            // 
            this.ribbonPageProducts.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPageProducts.Name = "ribbonPageProducts";
            this.ribbonPageProducts.Text = "Products";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUpdate);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnProducts);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnColumns);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnExport);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnExit);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barNew);
            this.ribbonStatusBar.ItemLinks.Add(this.barNewDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barSave, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barSaveDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barUpdate, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barUpdateDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barDelete, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barDeleteDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barRefresh, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barRefreshDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barColumns, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barColumnsDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barExport, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barExportDescription);
            this.ribbonStatusBar.ItemLinks.Add(this.barExit, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barExitDescription);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 768);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1190, 31);
            // 
            // gridControlProducts
            // 
            this.gridControlProducts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlProducts.Location = new System.Drawing.Point(0, 339);
            this.gridControlProducts.MainView = this.gridViewProducts;
            this.gridControlProducts.MenuManager = this.ribbon;
            this.gridControlProducts.Name = "gridControlProducts";
            this.gridControlProducts.Size = new System.Drawing.Size(1190, 405);
            this.gridControlProducts.TabIndex = 2;
            this.gridControlProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProducts});
            // 
            // gridViewProducts
            // 
            this.gridViewProducts.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridViewProducts.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewProducts.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewProducts.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewProducts.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewProducts.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewProducts.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewProducts.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewProducts.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewProducts.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductID,
            this.colBoxNumber,
            this.colEan8,
            this.colEan13,
            this.colProductName,
            this.colSavedDateTime});
            gridFormatRule2.Column = this.colSavedDateTime;
            gridFormatRule2.Name = "Format0";
            gridFormatRule2.Rule = formatConditionRule3ColorScale2;
            this.gridViewProducts.FormatRules.Add(gridFormatRule2);
            this.gridViewProducts.GridControl = this.gridControlProducts;
            this.gridViewProducts.Name = "gridViewProducts";
            this.gridViewProducts.OptionsMenu.EnableColumnMenu = false;
            this.gridViewProducts.OptionsMenu.EnableFooterMenu = false;
            this.gridViewProducts.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewProducts.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewProducts.OptionsPrint.AutoWidth = false;
            this.gridViewProducts.OptionsPrint.PrintFooter = false;
            this.gridViewProducts.OptionsPrint.PrintGroupFooter = false;
            this.gridViewProducts.OptionsView.ColumnAutoWidth = false;
            this.gridViewProducts.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewProducts.OptionsView.RowAutoHeight = true;
            this.gridViewProducts.OptionsView.ShowAutoFilterRow = true;
            this.gridViewProducts.OptionsView.ShowGroupPanel = false;
            this.gridViewProducts.OptionsView.ShowViewCaption = true;
            this.gridViewProducts.ViewCaption = "Products";
            this.gridViewProducts.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewProducts_FocusedRowChanged);
            // 
            // colProductID
            // 
            this.colProductID.Caption = "Product ID";
            this.colProductID.FieldName = "ProductID";
            this.colProductID.Name = "colProductID";
            this.colProductID.OptionsColumn.AllowEdit = false;
            this.colProductID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colBoxNumber
            // 
            this.colBoxNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colBoxNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBoxNumber.Caption = "Box Number";
            this.colBoxNumber.FieldName = "BoxNumber";
            this.colBoxNumber.Name = "colBoxNumber";
            this.colBoxNumber.OptionsColumn.AllowEdit = false;
            this.colBoxNumber.Visible = true;
            this.colBoxNumber.VisibleIndex = 0;
            this.colBoxNumber.Width = 150;
            // 
            // colEan8
            // 
            this.colEan8.AppearanceCell.Options.UseTextOptions = true;
            this.colEan8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEan8.Caption = "EAN-8";
            this.colEan8.FieldName = "Ean8";
            this.colEan8.Name = "colEan8";
            this.colEan8.OptionsColumn.AllowEdit = false;
            this.colEan8.Visible = true;
            this.colEan8.VisibleIndex = 1;
            this.colEan8.Width = 170;
            // 
            // colEan13
            // 
            this.colEan13.AppearanceCell.Options.UseTextOptions = true;
            this.colEan13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEan13.Caption = "EAN-13";
            this.colEan13.FieldName = "Ean13";
            this.colEan13.Name = "colEan13";
            this.colEan13.OptionsColumn.AllowEdit = false;
            this.colEan13.Visible = true;
            this.colEan13.VisibleIndex = 2;
            this.colEan13.Width = 225;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Product Name";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.OptionsColumn.AllowEdit = false;
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 4;
            this.colProductName.Width = 475;
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 744);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1190, 24);
            this.longNavigator.TabIndex = 5;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.txtProductName);
            this.myDataLayoutControl.Controls.Add(this.txtSavedDate);
            this.myDataLayoutControl.Controls.Add(this.txtEan13);
            this.myDataLayoutControl.Controls.Add(this.txtEan8);
            this.myDataLayoutControl.Controls.Add(this.txtBoxNumber);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 143);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.Root;
            this.myDataLayoutControl.Size = new System.Drawing.Size(367, 196);
            this.myDataLayoutControl.TabIndex = 0;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // txtProductName
            // 
            this.txtProductName.EnterMoveNextControl = true;
            this.txtProductName.Location = new System.Drawing.Point(111, 108);
            this.txtProductName.MenuManager = this.ribbon;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtProductName.Properties.Appearance.Options.UseFont = true;
            this.txtProductName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtProductName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtProductName.Properties.MaxLength = 250;
            this.txtProductName.Size = new System.Drawing.Size(244, 76);
            this.txtProductName.StyleController = this.myDataLayoutControl;
            this.txtProductName.TabIndex = 4;
            // 
            // txtSavedDate
            // 
            this.txtSavedDate.EditValue = null;
            this.txtSavedDate.EnterMoveNextControl = true;
            this.txtSavedDate.Location = new System.Drawing.Point(111, 84);
            this.txtSavedDate.MenuManager = this.ribbon;
            this.txtSavedDate.Name = "txtSavedDate";
            this.txtSavedDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtSavedDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtSavedDate.Properties.Appearance.Options.UseFont = true;
            this.txtSavedDate.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSavedDate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtSavedDate.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtSavedDate.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSavedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSavedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSavedDate.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.txtSavedDate.Properties.MaskSettings.Set("useAdvancingCaret", true);
            this.txtSavedDate.Size = new System.Drawing.Size(244, 20);
            this.txtSavedDate.StyleController = this.myDataLayoutControl;
            this.txtSavedDate.TabIndex = 3;
            // 
            // txtEan13
            // 
            this.txtEan13.EnterMoveNextControl = true;
            this.txtEan13.Location = new System.Drawing.Point(111, 60);
            this.txtEan13.MenuManager = this.ribbon;
            this.txtEan13.Name = "txtEan13";
            this.txtEan13.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtEan13.Properties.Appearance.Options.UseFont = true;
            this.txtEan13.Properties.Appearance.Options.UseTextOptions = true;
            this.txtEan13.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtEan13.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtEan13.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtEan13.Properties.MaxLength = 50;
            this.txtEan13.Size = new System.Drawing.Size(244, 20);
            this.txtEan13.StyleController = this.myDataLayoutControl;
            this.txtEan13.TabIndex = 2;
            // 
            // txtEan8
            // 
            this.txtEan8.EnterMoveNextControl = true;
            this.txtEan8.Location = new System.Drawing.Point(111, 36);
            this.txtEan8.MenuManager = this.ribbon;
            this.txtEan8.Name = "txtEan8";
            this.txtEan8.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtEan8.Properties.Appearance.Options.UseFont = true;
            this.txtEan8.Properties.Appearance.Options.UseTextOptions = true;
            this.txtEan8.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtEan8.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtEan8.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtEan8.Properties.MaxLength = 50;
            this.txtEan8.Size = new System.Drawing.Size(244, 20);
            this.txtEan8.StyleController = this.myDataLayoutControl;
            this.txtEan8.TabIndex = 1;
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.EditValue = "MEM-001";
            this.txtBoxNumber.EnterMoveNextControl = true;
            this.txtBoxNumber.Location = new System.Drawing.Point(111, 12);
            this.txtBoxNumber.MenuManager = this.ribbon;
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtBoxNumber.Properties.Appearance.Options.UseFont = true;
            this.txtBoxNumber.Properties.Appearance.Options.UseTextOptions = true;
            this.txtBoxNumber.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtBoxNumber.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtBoxNumber.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtBoxNumber.Properties.MaxLength = 50;
            this.txtBoxNumber.Size = new System.Drawing.Size(244, 20);
            this.txtBoxNumber.StyleController = this.myDataLayoutControl;
            this.txtBoxNumber.TabIndex = 0;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition2.Width = 210D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition2});
            rowDefinition6.Height = 24D;
            rowDefinition6.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition7.Height = 24D;
            rowDefinition7.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition8.Height = 24D;
            rowDefinition8.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition9.Height = 24D;
            rowDefinition9.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition10.Height = 24D;
            rowDefinition10.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition6,
            rowDefinition7,
            rowDefinition8,
            rowDefinition9,
            rowDefinition10});
            this.Root.Size = new System.Drawing.Size(367, 196);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtBoxNumber;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(347, 24);
            this.layoutControlItem1.Text = "Box Number";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(89, 13);
            this.layoutControlItem1.TextToControlDistance = 10;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtEan8;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(347, 24);
            this.layoutControlItem2.Text = "EAN-8";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(89, 13);
            this.layoutControlItem2.TextToControlDistance = 10;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtEan13;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(347, 24);
            this.layoutControlItem3.Text = "EAN-13";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(89, 13);
            this.layoutControlItem3.TextToControlDistance = 10;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.txtSavedDate;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(347, 24);
            this.layoutControlItem4.Text = "Saved Date";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(89, 13);
            this.layoutControlItem4.TextToControlDistance = 10;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.txtProductName;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem5.Size = new System.Drawing.Size(347, 80);
            this.layoutControlItem5.Text = "Product Name";
            this.layoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(89, 13);
            this.layoutControlItem5.TextToControlDistance = 10;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(995, 158);
            this.pictureEdit1.MenuManager = this.ribbon;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(183, 156);
            this.pictureEdit1.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.barCodeControlEan13);
            this.panelControl1.Controls.Add(this.lblSearch);
            this.panelControl1.Controls.Add(this.txtSearchEan13);
            this.panelControl1.Location = new System.Drawing.Point(682, 158);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(289, 156);
            this.panelControl1.TabIndex = 1;
            // 
            // barCodeControlEan13
            // 
            this.barCodeControlEan13.Location = new System.Drawing.Point(48, 48);
            this.barCodeControlEan13.Name = "barCodeControlEan13";
            this.barCodeControlEan13.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.barCodeControlEan13.Size = new System.Drawing.Size(225, 94);
            this.barCodeControlEan13.Symbology = eaN13Generator2;
            this.barCodeControlEan13.TabIndex = 1;
            this.barCodeControlEan13.Text = "0000000000000";
            // 
            // lblSearch
            // 
            this.lblSearch.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblSearch.Appearance.Options.UseForeColor = true;
            this.lblSearch.Location = new System.Drawing.Point(5, 24);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(36, 13);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "EAN-13";
            // 
            // txtSearchEan13
            // 
            this.txtSearchEan13.EnterMoveNextControl = true;
            this.txtSearchEan13.Location = new System.Drawing.Point(48, 21);
            this.txtSearchEan13.MenuManager = this.ribbon;
            this.txtSearchEan13.Name = "txtSearchEan13";
            this.txtSearchEan13.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtSearchEan13.Properties.Appearance.Options.UseFont = true;
            this.txtSearchEan13.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtSearchEan13.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSearchEan13.Properties.MaxLength = 50;
            this.txtSearchEan13.Size = new System.Drawing.Size(225, 20);
            this.txtSearchEan13.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.barCodeControlEan8);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.txtSearchEan8);
            this.panelControl2.Location = new System.Drawing.Point(387, 158);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(289, 156);
            this.panelControl2.TabIndex = 8;
            // 
            // barCodeControlEan8
            // 
            this.barCodeControlEan8.Location = new System.Drawing.Point(79, 47);
            this.barCodeControlEan8.Name = "barCodeControlEan8";
            this.barCodeControlEan8.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.barCodeControlEan8.Size = new System.Drawing.Size(160, 94);
            this.barCodeControlEan8.Symbology = eaN8Generator2;
            this.barCodeControlEan8.TabIndex = 1;
            this.barCodeControlEan8.Text = "0000000000000";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "EAN-8";
            // 
            // txtSearchEan8
            // 
            this.txtSearchEan8.EnterMoveNextControl = true;
            this.txtSearchEan8.Location = new System.Drawing.Point(48, 21);
            this.txtSearchEan8.MenuManager = this.ribbon;
            this.txtSearchEan8.Name = "txtSearchEan8";
            this.txtSearchEan8.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtSearchEan8.Properties.Appearance.Options.UseFont = true;
            this.txtSearchEan8.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtSearchEan8.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSearchEan8.Properties.MaxLength = 50;
            this.txtSearchEan8.Size = new System.Drawing.Size(225, 20);
            this.txtSearchEan8.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 799);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.myDataLayoutControl);
            this.Controls.Add(this.gridControlProducts);
            this.Controls.Add(this.longNavigator);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("MainForm.IconOptions.Image")));
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Fnac - Product Management";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSavedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSavedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEan13.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEan8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchEan13.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchEan8.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageProducts;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnProducts;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarSubItem btnExport;
        private UserControls.Grids.MyGridControl gridControlProducts;
        private UserControls.Grids.MyGridView gridViewProducts;
        private UserControls.Grids.MyGridColumn colProductID;
        private UserControls.Grids.MyGridColumn colBoxNumber;
        private UserControls.Grids.MyGridColumn colEan8;
        private UserControls.Grids.MyGridColumn colProductName;
        private UserControls.Grids.MyGridColumn colSavedDateTime;
        private UserControls.Grids.MyGridColumn colEan13;
        private UserControls.Navigators.LongNavigator longNavigator;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnColumns;
        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private UserControls.Controls.MyMemoEdit txtProductName;
        private UserControls.Controls.MyDateEdit txtSavedDate;
        private UserControls.Controls.MyTextEdit txtEan13;
        private UserControls.Controls.MyTextEdit txtEan8;
        private UserControls.Controls.MyTextEdit txtBoxNumber;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraBars.BarSubItem btnExcelFiles;
        private DevExpress.XtraBars.BarButtonItem btnExcelFileStandard;
        private DevExpress.XtraBars.BarButtonItem btnExcelFileFormatted;
        private DevExpress.XtraBars.BarButtonItem btnExcelFileUnformatted;
        private DevExpress.XtraBars.BarButtonItem btnWordFile;
        private DevExpress.XtraBars.BarButtonItem btnPdfFile;
        private DevExpress.XtraBars.BarButtonItem btnTxtFile;
        private DevExpress.XtraBars.BarStaticItem barNew;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraBars.BarStaticItem barNewDescription;
        private DevExpress.XtraBars.BarStaticItem barSave;
        private DevExpress.XtraBars.BarStaticItem barSaveDescription;
        private DevExpress.XtraBars.BarStaticItem barUpdate;
        private DevExpress.XtraBars.BarStaticItem barUpdateDescription;
        private DevExpress.XtraBars.BarStaticItem barDelete;
        private DevExpress.XtraBars.BarStaticItem barDeleteDescription;
        private DevExpress.XtraBars.BarStaticItem barRefresh;
        private DevExpress.XtraBars.BarStaticItem barRefreshDescription;
        private DevExpress.XtraBars.BarStaticItem barColumns;
        private DevExpress.XtraBars.BarStaticItem barColumnsDescription;
        private DevExpress.XtraBars.BarStaticItem barExport;
        private DevExpress.XtraBars.BarStaticItem barExportDescription;
        private DevExpress.XtraBars.BarStaticItem barExit;
        private DevExpress.XtraBars.BarStaticItem barExitDescription;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.BarCodeControl barCodeControlEan13;
        private DevExpress.XtraEditors.LabelControl lblSearch;
        private UserControls.Controls.MyTextEdit txtSearchEan13;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.BarCodeControl barCodeControlEan8;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private UserControls.Controls.MyTextEdit txtSearchEan8;
    }
}