using System;
using System.Data.SqlClient;

class SqlConnectionDemo
{
    static void Main()
    {
        SqlConnectionDemo demo = new SqlConnectionDemo();
        demo.ListAllCustomers();
    }

    public void ListAllCustomers()
    {
        string connectionString = "your_connection_string_here";
        string query = "SELECT CustomerID, CompanyName, Country FROM Customers";

        using (SqlConnection connection = new SqlConnection(connectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                Console.WriteLine("CustomerID\tCompanyName\tCountry");
                while (reader.Read())
                {
                    string customerId = reader["CustomerID"].ToString();
                    string companyName = reader["CompanyName"].ToString();
                    string country = reader["Country"].ToString();
                    Console.WriteLine($"{customerId}\t{companyName}\t{country}");
                }
            }
        }
    }
}


static void Main()
{
    SqlConnectionDemo demo = new SqlConnectionDemo();
    demo.GetOrdersByCustomer("ALFKI"); // Replace "ALFKI" with the desired CustomerID
}

public void GetOrdersByCustomer(string customerId)
{
    string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true";
    string query = "SELECT OrderID, OrderDate, ShipCountry FROM Orders WHERE CustomerID = @customerId";

    using (SqlConnection connection = new SqlConnection(connectionString))
    using (SqlCommand command = new SqlCommand(query, connection))
    {
        command.Parameters.AddWithValue("@customerId", customerId);

        connection.Open();
        using (SqlDataReader reader = command.ExecuteReader())
        {
            Console.WriteLine("OrderID\tOrderDate\tShipCountry");
            while (reader.Read())
            {
                string orderId = reader["OrderID"].ToString();
                string orderDate = reader["OrderDate"].ToString();
                string shipCountry = reader["ShipCountry"].ToString();
                Console.WriteLine($"{orderId}\t{orderDate}\t{shipCountry}");
            }
        }
    }
}


public void InsertNewProduct()
{
    string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true";
    string query = @"INSERT INTO Products (ProductName, SupplierID, CategoryID, UnitPrice)
                     VALUES (@ProductName, @SupplierID, @CategoryID, @UnitPrice)";

    using (SqlConnection connection = new SqlConnection(connectionString))
    using (SqlCommand command = new SqlCommand(query, connection))
    {
        command.Parameters.AddWithValue("@ProductName", "Test Product");
        command.Parameters.AddWithValue("@SupplierID", 1);
        command.Parameters.AddWithValue("@CategoryID", 1);
        command.Parameters.AddWithValue("@UnitPrice", 25);

        connection.Open();
        int rowsAffected = command.ExecuteNonQuery();
        Console.WriteLine($"{rowsAffected} product(s) inserted.");
    }
}
static void Main()
{
    SqlConnectionDemo demo = new SqlConnectionDemo();
    demo.InsertNewProduct();
}
