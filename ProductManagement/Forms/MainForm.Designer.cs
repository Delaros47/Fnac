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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnProducts = new DevExpress.XtraBars.BarButtonItem();
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnExport = new DevExpress.XtraBars.BarSubItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnColumns = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageProducts = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControlProducts = new ProductManagement.UserControls.Grids.MyGridControl();
            this.gridViewProducts = new ProductManagement.UserControls.Grids.MyGridView();
            this.colProductID = new ProductManagement.UserControls.Grids.MyGridColumn();
            this.colBoxNumber = new ProductManagement.UserControls.Grids.MyGridColumn();
            this.colStockKeepingUnit = new ProductManagement.UserControls.Grids.MyGridColumn();
            this.colBarcode = new ProductManagement.UserControls.Grids.MyGridColumn();
            this.colProductName = new ProductManagement.UserControls.Grids.MyGridColumn();
            this.colSavedDateTime = new ProductManagement.UserControls.Grids.MyGridColumn();
            this.longNavigator1 = new ProductManagement.UserControls.Navigators.LongNavigator();
            this.myDataLayoutControl1 = new ProductManagement.UserControls.Controls.MyDataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.myTextEdit1 = new ProductManagement.UserControls.Controls.MyTextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.myTextEdit2 = new ProductManagement.UserControls.Controls.MyTextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.myTextEdit3 = new ProductManagement.UserControls.Controls.MyTextEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.myDateEdit1 = new ProductManagement.UserControls.Controls.MyDateEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.myMemoEdit1 = new ProductManagement.UserControls.Controls.MyMemoEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myMemoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
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
            this.btnColumns});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 10;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageProducts});
            this.ribbon.Size = new System.Drawing.Size(1290, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnProducts
            // 
            this.btnProducts.Caption = "Products";
            this.btnProducts.Id = 1;
            this.btnProducts.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnProducts.ImageOptions.SvgImage")));
            this.btnProducts.Name = "btnProducts";
            // 
            // btnNew
            // 
            this.btnNew.Caption = "New";
            this.btnNew.Id = 2;
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.LargeImage")));
            this.btnNew.Name = "btnNew";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Update";
            this.btnUpdate.Id = 3;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.LargeImage")));
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
            this.btnExit.Name = "btnExit";
            // 
            // btnExport
            // 
            this.btnExport.Caption = "Export";
            this.btnExport.Id = 7;
            this.btnExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.ImageOptions.Image")));
            this.btnExport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExport.ImageOptions.LargeImage")));
            this.btnExport.Name = "btnExport";
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Save";
            this.btnSave.Id = 8;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.LargeImage")));
            this.btnSave.Name = "btnSave";
            // 
            // btnColumns
            // 
            this.btnColumns.Caption = "Columns";
            this.btnColumns.Id = 9;
            this.btnColumns.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnColumns.ImageOptions.Image")));
            this.btnColumns.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnColumns.ImageOptions.LargeImage")));
            this.btnColumns.Name = "btnColumns";
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnProducts);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUpdate);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnColumns);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnExport);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnExit);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 868);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1290, 31);
            // 
            // gridControlProducts
            // 
            this.gridControlProducts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlProducts.Location = new System.Drawing.Point(0, 341);
            this.gridControlProducts.MainView = this.gridViewProducts;
            this.gridControlProducts.MenuManager = this.ribbon;
            this.gridControlProducts.Name = "gridControlProducts";
            this.gridControlProducts.Size = new System.Drawing.Size(1290, 503);
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
            this.colStockKeepingUnit,
            this.colBarcode,
            this.colProductName,
            this.colSavedDateTime});
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
            this.colBoxNumber.Width = 200;
            // 
            // colStockKeepingUnit
            // 
            this.colStockKeepingUnit.AppearanceCell.Options.UseTextOptions = true;
            this.colStockKeepingUnit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStockKeepingUnit.Caption = "Stock Keeping Unit";
            this.colStockKeepingUnit.FieldName = "StockKeepingUnit";
            this.colStockKeepingUnit.Name = "colStockKeepingUnit";
            this.colStockKeepingUnit.OptionsColumn.AllowEdit = false;
            this.colStockKeepingUnit.Visible = true;
            this.colStockKeepingUnit.VisibleIndex = 1;
            this.colStockKeepingUnit.Width = 200;
            // 
            // colBarcode
            // 
            this.colBarcode.AppearanceCell.Options.UseTextOptions = true;
            this.colBarcode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBarcode.Caption = "Barcode";
            this.colBarcode.FieldName = "Barcode";
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.OptionsColumn.AllowEdit = false;
            this.colBarcode.Visible = true;
            this.colBarcode.VisibleIndex = 2;
            this.colBarcode.Width = 225;
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
            // longNavigator1
            // 
            this.longNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator1.Location = new System.Drawing.Point(0, 844);
            this.longNavigator1.Name = "longNavigator1";
            this.longNavigator1.Size = new System.Drawing.Size(1290, 24);
            this.longNavigator1.TabIndex = 5;
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.myMemoEdit1);
            this.myDataLayoutControl1.Controls.Add(this.myDateEdit1);
            this.myDataLayoutControl1.Controls.Add(this.myTextEdit3);
            this.myDataLayoutControl1.Controls.Add(this.myTextEdit2);
            this.myDataLayoutControl1.Controls.Add(this.myTextEdit1);
            this.myDataLayoutControl1.Location = new System.Drawing.Point(12, 149);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(367, 173);
            this.myDataLayoutControl1.TabIndex = 8;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
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
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 210D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 24D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition4.Height = 24D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition5.Height = 24D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5});
            this.Root.Size = new System.Drawing.Size(367, 173);
            this.Root.TextVisible = false;
            // 
            // myTextEdit1
            // 
            this.myTextEdit1.EnterMoveNextControl = true;
            this.myTextEdit1.Location = new System.Drawing.Point(105, 12);
            this.myTextEdit1.MenuManager = this.ribbon;
            this.myTextEdit1.Name = "myTextEdit1";
            this.myTextEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.myTextEdit1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.myTextEdit1.Properties.MaxLength = 50;
            this.myTextEdit1.Size = new System.Drawing.Size(250, 20);
            this.myTextEdit1.StyleController = this.myDataLayoutControl1;
            this.myTextEdit1.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.myTextEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(347, 24);
            this.layoutControlItem1.Text = "Box Number";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(89, 13);
            // 
            // myTextEdit2
            // 
            this.myTextEdit2.EnterMoveNextControl = true;
            this.myTextEdit2.Location = new System.Drawing.Point(105, 36);
            this.myTextEdit2.MenuManager = this.ribbon;
            this.myTextEdit2.Name = "myTextEdit2";
            this.myTextEdit2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.myTextEdit2.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.myTextEdit2.Properties.MaxLength = 50;
            this.myTextEdit2.Size = new System.Drawing.Size(250, 20);
            this.myTextEdit2.StyleController = this.myDataLayoutControl1;
            this.myTextEdit2.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.myTextEdit2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(347, 24);
            this.layoutControlItem2.Text = "Stock Keeping Unit";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(89, 13);
            // 
            // myTextEdit3
            // 
            this.myTextEdit3.EnterMoveNextControl = true;
            this.myTextEdit3.Location = new System.Drawing.Point(105, 60);
            this.myTextEdit3.MenuManager = this.ribbon;
            this.myTextEdit3.Name = "myTextEdit3";
            this.myTextEdit3.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.myTextEdit3.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.myTextEdit3.Properties.MaxLength = 50;
            this.myTextEdit3.Size = new System.Drawing.Size(250, 20);
            this.myTextEdit3.StyleController = this.myDataLayoutControl1;
            this.myTextEdit3.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.myTextEdit3;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(347, 24);
            this.layoutControlItem3.Text = "Barcode";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(89, 13);
            // 
            // myDateEdit1
            // 
            this.myDateEdit1.EditValue = null;
            this.myDateEdit1.EnterMoveNextControl = true;
            this.myDateEdit1.Location = new System.Drawing.Point(105, 84);
            this.myDateEdit1.MenuManager = this.ribbon;
            this.myDateEdit1.Name = "myDateEdit1";
            this.myDateEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.myDateEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.myDateEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.myDateEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.myDateEdit1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.myDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.myDateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.myDateEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.myDateEdit1.Size = new System.Drawing.Size(250, 20);
            this.myDateEdit1.StyleController = this.myDataLayoutControl1;
            this.myDateEdit1.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.myDateEdit1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(347, 24);
            this.layoutControlItem4.Text = "Saved Date";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(89, 13);
            // 
            // myMemoEdit1
            // 
            this.myMemoEdit1.EnterMoveNextControl = true;
            this.myMemoEdit1.Location = new System.Drawing.Point(105, 108);
            this.myMemoEdit1.MenuManager = this.ribbon;
            this.myMemoEdit1.Name = "myMemoEdit1";
            this.myMemoEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.myMemoEdit1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.myMemoEdit1.Properties.MaxLength = 250;
            this.myMemoEdit1.Size = new System.Drawing.Size(250, 53);
            this.myMemoEdit1.StyleController = this.myDataLayoutControl1;
            this.myMemoEdit1.TabIndex = 8;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.myMemoEdit1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem5.Size = new System.Drawing.Size(347, 57);
            this.layoutControlItem5.Text = "Product Name";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(89, 13);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 899);
            this.Controls.Add(this.myDataLayoutControl1);
            this.Controls.Add(this.gridControlProducts);
            this.Controls.Add(this.longNavigator1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Fnac - Product Management";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myMemoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
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
        private UserControls.Grids.MyGridColumn colStockKeepingUnit;
        private UserControls.Grids.MyGridColumn colProductName;
        private UserControls.Grids.MyGridColumn colSavedDateTime;
        private UserControls.Grids.MyGridColumn colBarcode;
        private UserControls.Navigators.LongNavigator longNavigator1;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnColumns;
        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl1;
        private UserControls.Controls.MyMemoEdit myMemoEdit1;
        private UserControls.Controls.MyDateEdit myDateEdit1;
        private UserControls.Controls.MyTextEdit myTextEdit3;
        private UserControls.Controls.MyTextEdit myTextEdit2;
        private UserControls.Controls.MyTextEdit myTextEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}