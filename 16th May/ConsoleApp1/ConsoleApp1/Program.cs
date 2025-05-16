/*using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true";

        // Provide the query string with a parameter placeholder.
        string queryString =
            "SELECT ProductID, UnitPrice, ProductName FROM dbo.Products " +
            "WHERE UnitPrice > @pricePoint " +
            "ORDER BY UnitPrice DESC;";

        // Specify the parameter value.
        int paramValue = 5;

        // Create and open the connection in a using block. This
        // ensures that all resources will be closed and disposed
        // when the code exits.
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            // Create the Command and Parameter objects.
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@pricePoint", paramValue);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}", reader[0], reader[1], reader[2]);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //connections are closed and disposed by the using block.
            }
            Console.ReadLine();
        }
    }
} 

*/



/*using System;
using System.Data.SqlClient;

/// <summary>
/// Demonstrates how to work with SqlConnection objects
/// </summary>
class SqlConnectionDemo
{
    static void Main()
    {
        // 1. Instantiate the connection
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true";
        SqlConnection conn = new SqlConnection(connectionString);
        SqlDataReader rdr = null;

        try
        {
            // 2. Open the connection
            conn.Open();

            // 3. Pass the connection to a command object
            SqlCommand cmd = new SqlCommand("SELECT ContactName, City, CompanyName FROM Customers", conn);

            // 4. Use the connection
            // get query results
            rdr = cmd.ExecuteReader();

            string contactHeader = "Contact Name";
            string cityHeader = "City";
            string companyHeader = "Company Name";


            Console.WriteLine("Contact Name".PadRight(30) + "City".PadRight(20) + "Company Name");
            Console.WriteLine(new string('-', contactHeader.Length) + " ".PadRight(30 - contactHeader.Length, ' ') +
                              new string('-', cityHeader.Length) + " ".PadRight(20 - cityHeader.Length, ' ') +
                              new string('-', companyHeader.Length));


            while (rdr.Read())
            {
                string contactName = rdr["ContactName"].ToString();
                string city = rdr["City"].ToString();
                string companyName = rdr["CompanyName"].ToString();

                Console.WriteLine(contactName.PadRight(30) + city.PadRight(20) + companyName);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            // 6. Close the reader and the connection
            if (rdr != null)
            {
                rdr.Close();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }
        Console.ReadLine();
    }
} 
*/



using System;
using System.Data.SqlClient;

/// <summary>
/// Demonstrates how to join two tables (Customers and Orders) and display relevant data
/// </summary>
class SqlConnectionDemo
{
    static void Main()
    {
        // 1. Instantiate the connection
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true";
        SqlConnection conn = new SqlConnection(connectionString);
        SqlDataReader rdr = null;

        try
        {
            // 2. Open the connection
            conn.Open();

           
            SqlCommand cmd = new SqlCommand(@"
                SELECT
                    c.ContactName,
                    c.City,
                    c.CompanyName,
                    o.OrderID,
                    o.OrderDate
                FROM
                    Customers c
                INNER JOIN
                    Orders o ON c.CustomerID = o.CustomerID", conn);

            // 4. Use the connection
            // get query results
            rdr = cmd.ExecuteReader();

            string contactHeader = "Contact Name";
            string cityHeader = "City";
            string companyHeader = "Company Name";
            string orderIdHeader = "Order ID";
            string orderDateHeader = "Order Date";

            int contactWidth = 30;
            int cityWidth = 20;
            int companyWidth = 30;
            int orderIdWidth = 10;
            int orderDateWidth = 15;

            Console.WriteLine(contactHeader.PadRight(contactWidth) + "  " +
                              cityHeader.PadRight(cityWidth) + "  " +
                              companyHeader.PadRight(companyWidth) + "  " +
                              orderIdHeader.PadRight(orderIdWidth) + "  " +
                              orderDateHeader.PadRight(orderDateWidth));

            Console.WriteLine(new string('-', contactHeader.Length).PadRight(contactWidth, '-') + "  " +
                              new string('-', cityHeader.Length).PadRight(cityWidth, '-') + "  " +
                              new string('-', companyHeader.Length).PadRight(companyWidth, '-') + "  " +
                              new string('-', orderIdHeader.Length).PadRight(orderIdWidth, '-') + "  " +
                              new string('-', orderDateHeader.Length).PadRight(orderDateWidth, '-'));

            while (rdr.Read())
            {
                string contactName = rdr["ContactName"].ToString();
                string city = rdr["City"].ToString();
                string companyName = rdr["CompanyName"].ToString();
                string orderID = rdr["OrderID"].ToString();
                DateTime orderDate = rdr["OrderDate"] != DBNull.Value ? (DateTime)rdr["OrderDate"] : DateTime.MinValue;

                Console.WriteLine(contactName.PadRight(contactWidth) + "  " +
                                  city.PadRight(cityWidth) + "  " +
                                  companyName.PadRight(companyWidth) + "  " +
                                  orderID.PadRight(orderIdWidth) + "  " +
                                  orderDate.ToString("yyyy-MM-dd").PadRight(orderDateWidth));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            // 6. Close the reader and the connection
            if (rdr != null)
            {
                rdr.Close();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }
        Console.ReadLine();
    }
}