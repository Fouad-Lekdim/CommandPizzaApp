using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDataAccess___Data_Layer
{
    public class clsPizzaDataAccess
    {
        public static bool GetPizzaSizePrice(string size, ref int sizeId, ref float price)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * from PizzaSizes WHERE Size = @size;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@size", size);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    price = Convert.ToSingle(reader["Price"]);
                    sizeId = (int)reader["PizzaSizeId"];
                    reader.Close();
                }
                
            }
            catch (Exception ex)
            {

                isFound=false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool GetCrustTypePrice(string crustType, ref int crustTypeId, ref float crustPrice)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * from CrustTypes WHERE CrustType = @CrustType;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@CrustType", crustType);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    crustPrice = Convert.ToSingle(reader["CrustPrice"]);
                    crustTypeId = (int)reader["CrustId"];

                    reader.Close();
                }

            }
            catch (Exception ex)
            {

                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int AddNewPizzaOrder(int sizeId, int crustId, string toppings,
            string whereToEat, float totalPrice)
        {
            int orderId = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT into Orders (PizzaSizeId, CrustTypeId, Toppings, WhereToEat,
                             TotalPrice) values (@sizeId, @crustId, @toppings, @whereToEat, @totalPrice);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@sizeId", sizeId);
            cmd.Parameters.AddWithValue("@crustId", crustId);
            cmd.Parameters.AddWithValue("@toppings", toppings);
            cmd.Parameters.AddWithValue("@whereToEat", whereToEat);
            cmd.Parameters.AddWithValue("@totalPrice", totalPrice);

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    orderId = insertedID;
                }
            }
            catch (Exception)
            {
                ;
            }
            finally { 
                connection.Close();            
            }

            return orderId;
        }
                
        public static DataTable GetAllPizzaOrders()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select * from Orders;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();

            }
            catch (Exception ex)
            {

                ;
            }
            finally
            {
                connection.Close(); 
            }

            return dt;
        }

        public static bool GetPizzaOrderById(int orderId, ref int pizzaSizeId, ref int CrustTypeId,
                                  ref string toppings, ref string whereToEat, ref float totalPrice)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * from Orders Where OrderNumber = @orderid;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@orderid", orderId);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    pizzaSizeId = (int)reader["PizzaSizeId"];
                    CrustTypeId = (int)reader["CrustTypeId"];
                    
                    if (reader["Toppings"] != DBNull.Value)
                    {
                        toppings = (string)reader["Toppings"];
                    }
                    else
                    {
                        toppings = "";
                    }

                    whereToEat = (string)reader["WhereToEat"];
                    totalPrice = Convert.ToSingle(reader["TotalPrice"]);

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

    }
}
