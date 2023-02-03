using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
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
                    Ean8 = reader["Ean8"].ToString(),
                    Ean13 = reader["Ean13"].ToString(),
                    SavedDateTime = Convert.ToDateTime(reader["SavedDateTime"]),
                    ProductName = reader["ProductName"].ToString()
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

            OleDbCommand command = new OleDbCommand("INSERT INTO Products(BoxNumber,Ean8,Ean13,SavedDateTime,ProductName)VALUES(@BoxNumber,@Ean8,@Ean13,@SavedDateTime,@ProductName)", _conection);
            command.Parameters.AddWithValue("@BoxNumber", product.BoxNumber);
            command.Parameters.AddWithValue("@Ean8", product.Ean8);
            command.Parameters.AddWithValue("@Ean13", product.Ean13);
            command.Parameters.AddWithValue("@SavedDateTime", product.SavedDateTime);
            command.Parameters.AddWithValue("@ProductName", product.ProductName);
            command.ExecuteNonQuery();
            _conection.Close();
        }

        public void Update(Product product)
        {
            CheckConnection();

            OleDbCommand command = new OleDbCommand("UPDATE Products SET BoxNumber=@BoxNumber,Ean8=@Ean8,Ean13=@Ean13,SavedDateTime=@SavedDateTime,ProductName=@ProductName WHERE ProductID=@ProductID", _conection);
            command.Parameters.AddWithValue("@BoxNumber", product.BoxNumber);
            command.Parameters.AddWithValue("@Ean8", product.Ean8);
            command.Parameters.AddWithValue("@Ean13", product.Ean13);
            command.Parameters.AddWithValue("@SavedDateTime", product.SavedDateTime);
            command.Parameters.AddWithValue("@ProductName", product.ProductName);
            command.Parameters.AddWithValue("@ProductID", product.ProductID);
            command.ExecuteNonQuery();
            _conection.Close();

        }

        public void Delete(int productID)
        {
            CheckConnection();

            OleDbCommand command = new OleDbCommand("DELETE FROM Products WHERE ProductID=@ProductID",_conection);
            command.Parameters.AddWithValue("@ProductID", productID);
            command.ExecuteNonQuery();
            _conection.Close();

        }





    }
}
