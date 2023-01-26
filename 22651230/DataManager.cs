using _22651230.ClassModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22651230
{
    public class DataManager
    {

        private static DataManager instance = null;
        private string connectionString;
        private SqlConnection connection;
        public DataManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataManager();
                }
                return instance;
            }
        }

        public DataManager()
        {
            try
            {
                connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + Path.GetFullPath(Directory.GetCurrentDirectory() + "\\..\\..\\shop.mdf") + "\";Integrated Security=True";
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void Dispose()
        {
            connection.Close();
            instance = null;
        }

        #region Clients
        public bool InsertClients(Client client)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Clients (FirstName,LastName,PhoneNum,Adres)VALUES(@fname, @lname, @ph,@ad)", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@fname", client.FirstName);
                cmd.Parameters.AddWithValue("@lname", client.LastName);
                cmd.Parameters.AddWithValue("@ph", client.Phone);
                cmd.Parameters.AddWithValue("@ad", client.Adres);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool UpdateClients(Client client)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Clients SET FirstName = @fn,LastName = @ln,PhoneNum = @p,Adres = @a WHERE ID =  @id", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@fn", client.FirstName);
                cmd.Parameters.AddWithValue("@ln", client.LastName);
                cmd.Parameters.AddWithValue("@p", client.Phone);
                cmd.Parameters.AddWithValue("@a", client.Adres);
                cmd.Parameters.AddWithValue("@id", client.Id);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool DeleteClients(Client client)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Clients WHERE ID =  @id", connection);

                
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", client.Id);


                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public List<Client> SelectClients()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT FirstName,LastName,ID FROM CLIENTS" , connection);


                List<Client> positions = new List<Client>();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        positions.Add(new Client((string)reader["FirstName"], (string)reader["LastName"],(int)reader["ID"]));
                    }
                }

                return positions;
            }
            catch (Exception)
            {
                return null;
            }

           
        }
        #endregion

        #region Workers
        public bool InsertWorkers(Worker worker)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Workers (FirstName,LastName,PhoneNum)VALUES(@fname, @lname, @ph)", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@fname", worker.FirstName);
                cmd.Parameters.AddWithValue("@lname", worker.LastName);
                cmd.Parameters.AddWithValue("@ph", worker.Phone);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool UpdateWorkers(Worker worker)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Workers SET FirstName = @fname,LastName = @lname,Phonenum = @ph WHERE  ID = @id", connection);

                cmd.CommandType = CommandType.Text;               

                cmd.Parameters.AddWithValue("@fname", worker.FirstName);
                cmd.Parameters.AddWithValue("@lname", worker.LastName);
                cmd.Parameters.AddWithValue("@ph", worker.Phone);
                cmd.Parameters.AddWithValue("@id", worker.ID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool DeleteWorkers(Worker worker)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Workers WHERE ID = @id", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", worker.ID);
                cmd.CommandType = CommandType.Text;



                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public List<Worker> SelectWorkers()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT FirstName,LastName,ID FROM Workers", connection);


                List<Worker> positions = new List<Worker>();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        positions.Add(new Worker((string)reader["FirstName"], (string)reader["LastName"], (int)reader["ID"]));
                    }
                }

                return positions;
            }
            catch (Exception)
            {
                return null;
            }


        }
        #endregion

        #region Couriers
        public bool InsertCouriers(Courier courier)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Couriers (Name_,Price)VALUES(@name, @price)", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", courier.FirstName);
                cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(courier.Price));

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool UpdateCouriers(Courier courier)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Couriers SET Name_ = @name,Price = @price WHERE ID = @id ", connection);

                cmd.CommandType = CommandType.Text;;

                cmd.Parameters.AddWithValue("@name", courier.FirstName);
                cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(courier.Price));
                cmd.Parameters.AddWithValue("@id", courier.Id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool DeleteCouriers(Courier courier)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Couriers WHERE WHERE ID = @id", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", courier.Id);



                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public List<Courier> SelectCouriers()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT FirstName,ID FROM Workers", connection);


                List<Courier> positions = new List<Courier>();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        positions.Add(new Courier((string)reader["FirstName"], (int)reader["ID"]));
                    }
                }

                return positions;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

        #region Products
        public bool InsertProducts(Product product)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Products (Name_,Quantity,ProdType,PriceOne)VALUES(@name, @quant, @typeID, @price)", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", product.ProdName);
                cmd.Parameters.AddWithValue("@quant", product.Quantity);                
                cmd.Parameters.AddWithValue("@typeId", product.ProductType.Id);
                cmd.Parameters.AddWithValue("@pr", product.Price);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool UpdateProducts(Product product)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Products SET Name_ = @name,Quantity = @quant,ProdType = @typeId,PriceOne = @price WHERE ID = @id", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", product.ProdName);
                cmd.Parameters.AddWithValue("@quant", product.Quantity);                
                cmd.Parameters.AddWithValue("@typeId", product.ProductType.Id);
                cmd.Parameters.AddWithValue("@pr", product.Price);
                cmd.Parameters.AddWithValue("@id", product.Id);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool DeleteProducts(Product product)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Products WHERE ID = @id", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", product.Id);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public List<Product> SelectProducts()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT Name_,ID FROM Products", connection);


                List<Product> positions = new List<Product>();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        positions.Add(new Product((string)reader["Name_"], (int)reader["ID"]));
                    }
                }

                return positions;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

        #region ProductsType
        public bool InsertProdType(ProductType prodType)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO ProductType(Name_)VALUES(@name)", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", prodType.Name);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool UpdateProdType(ProductType prodType)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE ProductType SET Name_ = @name WHERE ID = @id", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", prodType.Name);
                cmd.Parameters.AddWithValue("@id", prodType.Id);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public bool DeleteProdType(ProductType prodType)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM ProductType WHERE WHERE ID = @id", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", prodType.Id);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public List<ProductType> SelectProdTypes()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT Name_,ID FROM ProductType", connection);


                List<ProductType> positions = new List<ProductType>();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        positions.Add(new ProductType((string)reader["Name_"], (int)reader["ID"]));
                    }
                }

                return positions;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

        #region Shipment
        public bool InsertShipment(Shipment shipment)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Shipments (ID,Worker,Client,Courier,DateShipment)VALUES(@id, @worker, @client, @courier, @date)", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", shipment.Id);
                cmd.Parameters.AddWithValue("@worker", shipment.Worker.ID);
                cmd.Parameters.AddWithValue("@client", shipment.Client.Id);
                cmd.Parameters.AddWithValue("@courier", shipment.Courier.Id);
                cmd.Parameters.AddWithValue("@date", shipment.Dateship);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("INSERT INTO ShipmentPackage (Shipment,Pruduct,Quantity)VALUES(@id, @prid, @quant)", connection);
                for (int i = 0; i < shipment.package.Count; i++)
                {
                   
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", shipment.Id);
                    cmd.Parameters.AddWithValue("@prid", shipment.package[i].Product.Id);
                    cmd.Parameters.AddWithValue("@quant", shipment.package[i].Quantity);
                    cmd.ExecuteNonQuery();

                }

                
            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        //public bool UpdateShipment(Product product)
        //{
        //    bool successful = true;

        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand("UPDATE Products SET Name_ = @name,Quantity = @quant,ProdType = @typeId,PriceOne = @price WHERE ID = @id", connection);

        //        cmd.CommandType = CommandType.Text;
        //        cmd.Parameters.AddWithValue("@name", product.ProdName);
        //        cmd.Parameters.AddWithValue("@quant", product.Quantity);
        //        cmd.Parameters.AddWithValue("@typeId", product.ProductType.Id);
        //        cmd.Parameters.AddWithValue("@pr", product.Price);
        //        cmd.Parameters.AddWithValue("@name", product.Id);

        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception)
        //    {
        //        successful = false;
        //    }

        //    return successful;
        //}
        public bool DeleteShipment(Shipment shipment)
        {
            bool successful = true;

            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Shipments WHERE ID = @id", connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", shipment.Id);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("DELETE FROM ShipmentPackage WHERE ID = @id)", connection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", shipment.Id);
                cmd.ExecuteNonQuery();

                


            }
            catch (Exception)
            {
                successful = false;
            }

            return successful;
        }
        public List<Shipment> SelectShipment()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT Name_,ID FROM Products", connection);
                

                List<Shipment> positions = new List<Shipment>();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        positions.Add(new Shipment((int)reader["ID"]));
                    }
                }

                return positions;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
    }
}
