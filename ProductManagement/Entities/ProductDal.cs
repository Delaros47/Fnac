using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManagement.Entities
{
    
    public class ProductDal
    {
        private static string myPath = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Database\\FnacDatabase.accdb;Persist Security Info=False;";
        private OleDbConnection _conection = new OleDbConnection(myPath);

        public void CheckConnection()
        {
            if (_conection.State == ConnectionState.Closed)
            {
                _conection.Open();
            }
        }

        public List<Product> GetAll()
        {
            CheckConnection();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Products", _conection);
            OleDbDataReader reader = cmd.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product _product = new Product
                {
                    ProductID = Convert.ToInt32(reader["ProductID"]),
                    BoxNumber = reader["BoxNumber"].ToString(),
                    StockKeepingUnit = reader["StockKeepingUnit"].ToString(),
                    Barcode = reader["Barcode"].ToString(),
                    ProductName = reader["ProductName"].ToString(),
                    SavedDateTime = Convert.ToDateTime(reader["SavedDateTime"])
                };
                products.Add(_product);
            }
            reader.Close();
            _conection.Close();
            return products;
        }

        public void Insert(Product product)
        {
            CheckConnection();

            OleDbCommand command = new OleDbCommand("INSERT INTO Products(BoxNumber,StockKeepingUnit,Barcode,SavedDateTime,ProductName)VALUES(@BoxNumber,@StockKeepingUnit,@Barcode,@SavedDateTime,@ProductName)", _conection);
            command.Parameters.AddWithValue("@BoxNumber", product.BoxNumber);
            command.Parameters.AddWithValue("@StockKeepingUnit", product.StockKeepingUnit);
            command.Parameters.AddWithValue("@Barcode", product.Barcode);
            command.Parameters.AddWithValue("@SavedDateTime", product.SavedDateTime);
            command.Parameters.AddWithValue("@ProductName", product.ProductName);
            command.ExecuteNonQuery();
            _conection.Close();
        }
    }
}
