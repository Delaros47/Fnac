using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Export;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using ProductManagement.Entities;

namespace ProductManagement.Forms
{
    public partial class MainForm : RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            EventLoads();
            longNavigator.Navigator.NavigatableControl = gridViewProducts.GridControl;
        }

        private ProductDal _productDal = new ProductDal();
        private int _productId = 0;
        private void EventLoads()
        {
            foreach (var item in ribbon.Items)
            {
                switch (item)
                {
                    case BarItem button:
                        button.ItemClick += Button_ItemClick;
                        break;
                }
            }
        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item==btnExport)
            {
                var link = (BarSubItemLink) e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }else if (e.Item==btnExcelFileStandard)
            {
                if (!Directory.Exists(Application.StartupPath+@"\Export\"))
                {
                    Directory.CreateDirectory(Application.StartupPath+@"\Export\");
                }

                var filePath = Application.StartupPath+"\\Export\\"+ DateTime.Now.ToLongDateString()+" "+DateTime.Now.Hour+";"+DateTime.Now.Minute+";"+DateTime.Now.Second;
                var opt = new XlsxExportOptionsEx
                {
                    ExportType = ExportType.Default,
                    SheetName = "Products",
                    TextExportMode = TextExportMode.Text
                };
                filePath = filePath + ".Xlsx";
                gridViewProducts.ExportToXlsx(filePath, opt);

                XtraMessageBox.Show($"File has successfully exported to {filePath}","Exporting file",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else if (e.Item==btnExcelFileFormatted)
            {
                if (!Directory.Exists(Application.StartupPath + @"\Export\"))
                {
                    Directory.CreateDirectory(Application.StartupPath + @"\Export\");
                }

                var filePath = Application.StartupPath + "\\Export\\" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.Hour + ";" + DateTime.Now.Minute + ";" + DateTime.Now.Second;
                var opt = new XlsxExportOptionsEx
                {
                    ExportType = ExportType.WYSIWYG,
                    SheetName = "Products",
                    TextExportMode = TextExportMode.Text
                };
                filePath = filePath + ".Xlsx";
                gridViewProducts.ExportToXlsx(filePath, opt);

                XtraMessageBox.Show($"File has successfully exported to {filePath}", "Exporting file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (e.Item==btnExcelFileUnformatted)
            {
                if (!Directory.Exists(Application.StartupPath + @"\Export\"))
                {
                    Directory.CreateDirectory(Application.StartupPath + @"\Export\");
                }

                var filePath = Application.StartupPath + "\\Export\\" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.Hour + ";" + DateTime.Now.Minute + ";" + DateTime.Now.Second;
                var opt = new CsvExportOptionsEx
                {
                    ExportType = ExportType.WYSIWYG,
                    TextExportMode = TextExportMode.Text
                };
                filePath = filePath + ".Csv";
                gridViewProducts.ExportToCsv(filePath, opt);

                XtraMessageBox.Show($"File has successfully exported to {filePath}", "Exporting file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (e.Item==btnWordFile)
            {
                if (!Directory.Exists(Application.StartupPath + @"\Export\"))
                {
                    Directory.CreateDirectory(Application.StartupPath + @"\Export\");
                }

                var filePath = Application.StartupPath + "\\Export\\" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.Hour + ";" + DateTime.Now.Minute + ";" + DateTime.Now.Second;

                filePath = filePath + ".Docx";
                gridViewProducts.ExportToDocx(filePath);

                XtraMessageBox.Show($"File has successfully exported to {filePath}", "Exporting file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (e.Item==btnPdfFile)
            {
                if (!Directory.Exists(Application.StartupPath + @"\Export\"))
                {
                    Directory.CreateDirectory(Application.StartupPath + @"\Export\");
                }

                var filePath = Application.StartupPath + "\\Export\\" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.Hour + ";" + DateTime.Now.Minute + ";" + DateTime.Now.Second;
                filePath = filePath + ".Pdf";
                gridViewProducts.ExportToPdf(filePath);

                XtraMessageBox.Show($"File has successfully exported to {filePath}", "Exporting file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (e.Item==btnTxtFile)
            {
                if (!Directory.Exists(Application.StartupPath + @"\Export\"))
                {
                    Directory.CreateDirectory(Application.StartupPath + @"\Export\");
                }

                var filePath = Application.StartupPath + "\\Export\\" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.Hour + ";" + DateTime.Now.Minute + ";" + DateTime.Now.Second;
                var opt = new TextExportOptions
                {
                    TextExportMode = TextExportMode.Text
                };
                filePath = filePath + ".Txt";
                gridViewProducts.ExportToText(filePath, opt);

                XtraMessageBox.Show($"File has successfully exported to {filePath}", "Exporting file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (e.Item==btnNew)
            {
                NewProduct();
            }else if (e.Item==btnSave)
            {
                SaveProduct();
            }else if (e.Item==btnUpdate)
            {
                UpdateProduct();
            }else if (e.Item==btnDelete)
            {
                DeleteProduct();
            }else if (e.Item==btnProducts)
            {
                RefreshProducts();
            }else if (e.Item==btnColumns)
            {
                if (gridViewProducts.CustomizationForm==null)
                {
                    gridViewProducts.ShowCustomization();
                }
                else
                {
                    gridViewProducts.HideCustomization();
                }
            }else if (e.Item==btnExit)
            {
                this.Close();
            }
        }

        private void UpdateProduct()
        {
            if (_productId==0)
            {
                return;
            }
            try
            {
                _productDal.Update(new Product
                {
                    ProductID = _productId,
                    BoxNumber = txtBoxNumber.Text,
                    StockKeepingUnit = txtStockKeepingUnit.Text,
                    Barcode = txtBarcode.Text,
                    SavedDateTime = Convert.ToDateTime(txtSavedDate.Text),
                    ProductName = txtProductName.Text
                });
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            XtraMessageBox.Show("Product has successfully updated", "Updating a product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshProducts();
            NewProduct();
        }

        private void DeleteProduct()
        {
            if (_productId == 0)
            {
                return;
            }

            DialogResult result = XtraMessageBox.Show("Are you sure to delete a product?", "Deleting a product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

            }
            else
            {
                return;
            }

            try
            {
                _productDal.Delete(_productId);

            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            XtraMessageBox.Show("Product has successfully updated", "Updating a product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshProducts();
            NewProduct();
        }

        private void NewProduct()
        {
            
            txtStockKeepingUnit.Text = string.Empty;
            txtBarcode.Text = string.Empty;
            txtSavedDate.Text = string.Empty;
            txtProductName.Text = string.Empty;
        }

        private void RefreshProducts()
        {
            gridControlProducts.DataSource = _productDal.GetAll();
        }

        private void SaveProduct()
        {
            try
            {
                _productDal.Insert(new Product
                {
                    BoxNumber = txtBoxNumber.Text,
                    StockKeepingUnit = txtStockKeepingUnit.Text,
                    Barcode = txtBarcode.Text,
                    SavedDateTime = Convert.ToDateTime(txtSavedDate.Text),
                    ProductName = txtProductName.Text,
                });
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            XtraMessageBox.Show("Product has successfully saved", "Saving a product",MessageBoxButtons.OK,MessageBoxIcon.Information);
            RefreshProducts();
            NewProduct();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshProducts();
        }

        private void gridViewProducts_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridViewProducts.FocusedRowHandle > -1)
            {
                _productId = (int)gridViewProducts.GetFocusedRowCellValue("ProductID");
                txtBoxNumber.Text = gridViewProducts.GetFocusedRowCellValue("BoxNumber").ToString();
                txtStockKeepingUnit.Text = gridViewProducts.GetFocusedRowCellValue("StockKeepingUnit").ToString();
                txtBarcode.Text = gridViewProducts.GetFocusedRowCellValue("Barcode").ToString();
                txtSavedDate.Text = Convert.ToDateTime(gridViewProducts.GetFocusedRowCellValue("SavedDateTime")).ToShortDateString();
                txtProductName.Text = gridViewProducts.GetFocusedRowCellValue("ProductName").ToString();
            }
            else
            {
                return;
            }
        }
    }
}