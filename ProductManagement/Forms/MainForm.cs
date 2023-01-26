using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
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
                
            }else if (e.Item==btnExcelFileFormatted)
            {
                
            }else if (e.Item==btnExcelFileUnformatted)
            {
                
            }else if (e.Item==btnWordFile)
            {
                
            }else if (e.Item==btnPdfFile)
            {
                
            }else if (e.Item==btnTxtFile)
            {
                
            }else if (e.Item==btnNew)
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
                
            }else if (e.Item==btnExit)
            {
                this.Close();
            }
        }

        private void UpdateProduct()
        {
            
        }

        private void DeleteProduct()
        {
            
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

        private void gridViewProducts_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewProducts.FocusedRowHandle>-1)
            {
                return;
            }
            else
            {
                XtraMessageBox.Show("Please choose a proper column in the table", "Saving a product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}