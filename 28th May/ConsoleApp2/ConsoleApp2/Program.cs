// See https://aka.ms/new-console-template for more information 
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Runtime.Intrinsics.X86;

/// <summary>
/// Demonstrates how to join two tables (Customers and Orders) and display relevant data
/// </summary>

/*  

1. List All Customers (SqlDataReader)
Task: Use SqlConnection and SqlCommand to fetch all customers from the Customers
table. Print CustomerID, CompanyName, and Country.
*/

/*using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Data.SqlClient;

class SqlConnectionDemo
{
static void Main()
{
SqlConnectionDemo demo = new SqlConnectionDemo();
demo.ListAllCustomers();

}

public void ListAllCustomers()
{
string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true";
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
*/


/*2. Search Orders by Customer ID (Parameterized Query)
Task: Write a method GetOrdersByCustomer(string customerId) Use SqlCommand with
 WHERE CustomerID = @customerId to fetch and display orders.  
*/

/*using System.Text;
using Microsoft.Data.SqlClient;

class SqlConnectionDemo
{
    static void Main()
    {
        SqlConnectionDemo demo = new SqlConnectionDemo();
        demo.GetOrdersByCustomer("1"); 
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
}
*/

/* 
 3. Insert a New Product (ExecuteNonQuery)
 Task: Insert a new record into the Products table with:
 ProductName: "Test Product"
 SupplierID: 1
 CategoryID: 1
 UnitPrice: 25
 */


/* using System.Text;
using Microsoft.Data.SqlClient;

class SqlConnectionDemo
{
    static void Main()
    {
        SqlConnectionDemo demo = new SqlConnectionDemo();
        demo.InsertNewProduct();
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

}
*/

/* 
  4. Update Employee Title (Parameter Binding)
 Task: Update the Title of an employee based on their EmployeeID. Use
 SqlCommand.Parameters.AddWithValue.
 */

/* using System;
using Microsoft.Data.SqlClient; 

class SqlConnectionDemo
{
    static void Main()
    {
        SqlConnectionDemo demo = new SqlConnectionDemo();
        demo.UpdateEmployeeTitle(1, "Regional Manager"); // Update EmployeeID 1's title
    }

    public void UpdateEmployeeTitle(int employeeId, string newTitle)
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true";
        string query = "UPDATE Employees SET Title = @Title WHERE EmployeeID = @EmployeeID";

        using (SqlConnection connection = new SqlConnection(connectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@Title", newTitle);
            command.Parameters.AddWithValue("@EmployeeID", employeeId);

            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            Console.WriteLine($"{rowsAffected} employee(s) updated.");
        }
    }


}
*/

/*  5. Delete a Product (DELETE Query)
 Task: Delete a product from the Products table using its ProductID. Ensure user
 input is protected using parameterized queries. 

*/

/*using System;
using Microsoft.Data.SqlClient;

class SqlConnectionDemo
{
    static void Main()
    {
        SqlConnectionDemo demo = new SqlConnectionDemo();
        demo.DeleteProduct(1);
    }
    public void DeleteProduct(int productId)
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true";
        string query = "DELETE FROM Products WHERE ProductID = @ProductID";

        using (SqlConnection connection = new SqlConnection(connectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@ProductID", productId);

            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            Console.WriteLine($"{rowsAffected} product(s) deleted.");
        }
    }
}
*/

/* 
  6. Join Orders and Customers (INNER JOIN)
 Task: Join Orders and Customers to display:
 OrderID
 CompanyName
 OrderDate Use SqlCommand and display the results in a DataReader.
 */

/* using System;
using Microsoft.Data.SqlClient;


class OrderCustomerJoin
{
    static void Main()
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true";
        string sqlquery = "SELECT o.OrderID, c.CompanyName, o.OrderDate FROM Orders o INNER JOIN Customers c ON o.CustomerID = c.CustomerID";

        using (SqlConnection connection = new SqlConnection(connectionString))
        using (SqlCommand command = new SqlCommand(sqlquery, connection))
        {
            try
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("{0,-10} {1,-40} {2}", "OrderID", "CompanyName", "OrderDate");
                    Console.WriteLine(new string('-', 80));

                    while (reader.Read())
                    {
                        string orderId = reader["OrderID"]?.ToString() ?? string.Empty;
                        string companyName = reader["CompanyName"]?.ToString() ?? string.Empty;
                        string orderDate = Convert.ToDateTime(reader["OrderDate"]).ToString("yyyy-MM-dd");

                        Console.WriteLine("{0,-10} {1,-40} {2}", orderId, companyName, orderDate);
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
*/

/* 
  7. Display Total Sales by Category (GROUP BY + Aggregation)
 Task: Use SqlDataAdapter and DataTable to run:
 SELECT CategoryID, SUM(UnitPrice * Quantity) AS TotalSales 
FROM [Order Details] 
GROUP BY CategoryID
 Display results using a loop in C#
 */
/* using System;
using System.Data;
using Microsoft.Data.SqlClient;

class SqlConnectionDemo
{
    static void Main()
    {
        SqlConnectionDemo demo = new SqlConnectionDemo();
        demo.DisplayTotalSalesByCategory();
    }

    public void DisplayTotalSalesByCategory()
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true";
        string query = @"
            SELECT p.CategoryID, SUM(od.UnitPrice * od.Quantity) AS TotalSales
            FROM [Order Details] od
            INNER JOIN Products p ON od.ProductID = p.ProductID
            GROUP BY p.CategoryID";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count == 0)
                {
                    Console.WriteLine("No data found for the query.");
                    return;
                }

                Console.WriteLine("CategoryID\tTotalSales");
                foreach (DataRow row in table.Rows)
                {
                    int categoryId = row.Field<int>("CategoryID");
                    decimal totalSales = row.Field<decimal>("TotalSales");
                    Console.WriteLine($"{categoryId}\t\t{totalSales:C}");
                }
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("SQL Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
*/

/* 
  8. Execute Stored Procedure - CustOrderHist
Task: Call Northwind's built-in stored procedure 
CustOrderHist which takes
 @CustomerID and returns product names and totals for that customer.
 cmd.CommandText = "CustOrderHist"; 
cmd.CommandType = CommandType.StoredProcedure;
 */

/* using System;
using System.Data;
using Microsoft.Data.SqlClient;

class SqlConnectionDemo
{
    private const string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true";

    static void Main()
    {
        var demo = new SqlConnectionDemo();
        demo.DisplayTotalSalesByCategory();
        Console.WriteLine("\n" + new string('=', 50) + "\n");
        demo.ExecuteCustOrderHist("ALFKI");
    }

    public void DisplayTotalSalesByCategory()
    {
        const string query = @"
            SELECT p.CategoryID, SUM(od.UnitPrice * od.Quantity) AS TotalSales
            FROM [Order Details] od
            INNER JOIN Products p ON od.ProductID = p.ProductID
            GROUP BY p.CategoryID";

        try
        {
            using var connection = new SqlConnection(ConnectionString);
            using var adapter = new SqlDataAdapter(query, connection);
            var table = new DataTable();
            adapter.Fill(table);

            Console.WriteLine("=== Total Sales by Category ===");
            if (table.Rows.Count == 0)
            {
                Console.WriteLine("No data found for the query.");
                return;
            }

            Console.WriteLine("{0,-12} {1,15}", "CategoryID", "TotalSales");
            foreach (DataRow row in table.Rows)
            {
                var categoryId = row.Field<int>("CategoryID");
                var totalSales = row.Field<decimal>("TotalSales");
                Console.WriteLine("{0,-12} {1,15:C}", categoryId, totalSales);
            }
            Console.WriteLine();
        }
        catch (SqlException ex)
        {
            Console.WriteLine("SQL Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    public void ExecuteCustOrderHist(string customerId)
    {
        try
        {
            using var connection = new SqlConnection(ConnectionString);
            using var cmd = new SqlCommand("CustOrderHist", connection)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@CustomerID", customerId);

            connection.Open();
            using var reader = cmd.ExecuteReader();
            Console.WriteLine("=== Customer Order History ===");
            Console.WriteLine("{0,-40} {1,10}", "ProductName", "Total");
            while (reader.Read())
            {
                var productName = reader["ProductName"].ToString();
                var total = Convert.ToInt32(reader["Total"]);
                Console.WriteLine("{0,-40} {1,10}", productName, total);
            }
            Console.WriteLine();
        }
        catch (SqlException ex)
        {
            Console.WriteLine("SQL Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
*/
/* 
  9. Simulate Transaction - Insert Order and Details
 Task: Use 
SqlTransaction to:
 Insert into 
Orders
 Insert into 
Order Details Commit if both succeed; rollback otherwise 
*/
/* using System;
using System.Data;
using Microsoft.Data.SqlClient;

class Program
{
    static void Main()
    {
        InsertOrderWithDetails();
    }

    static void InsertOrderWithDetails()
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true";

        using SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();

        SqlTransaction transaction = connection.BeginTransaction();

        try
        {
            
            string insertOrderSql = @"
                INSERT INTO Orders (CustomerID, EmployeeID, OrderDate, ShipCountry)
                VALUES (@CustomerID, @EmployeeID, @OrderDate, @ShipCountry);
                SELECT SCOPE_IDENTITY();";

            using SqlCommand orderCmd = new SqlCommand(insertOrderSql, connection, transaction);
            orderCmd.Parameters.AddWithValue("@CustomerID", "ALFKI");
            orderCmd.Parameters.AddWithValue("@EmployeeID", 1);
            orderCmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);
            orderCmd.Parameters.AddWithValue("@ShipCountry", "Germany");

            int orderId = Convert.ToInt32(orderCmd.ExecuteScalar());

            
            string insertDetailSql = @"
                INSERT INTO [Order Details] (OrderID, ProductID, UnitPrice, Quantity, Discount)
                VALUES (@OrderID, @ProductID, @UnitPrice, @Quantity, @Discount);";

            using SqlCommand detailCmd = new SqlCommand(insertDetailSql, connection, transaction);
            detailCmd.Parameters.AddWithValue("@OrderID", orderId);
            detailCmd.Parameters.AddWithValue("@ProductID", 1);
            detailCmd.Parameters.AddWithValue("@UnitPrice", 10.0m);
            detailCmd.Parameters.AddWithValue("@Quantity", 5);
            detailCmd.Parameters.AddWithValue("@Discount", 0);

            detailCmd.ExecuteNonQuery();

            transaction.Commit();
            Console.WriteLine("Order and order details inserted successfully.");
        }
        catch (Exception ex)
        {
            transaction.Rollback();
            Console.WriteLine("Transaction rolled back. Error: " + ex.Message);
        }
    }
}
*/ 

/* 
  Use SqlDataAdapter + DataSet (Disconnected Model)
 Task: Load all 
Products using 
SqlDataAdapter into a 
with 
UnitsInStock > 20 .
 DataSet . Display only product
 */ 

using System;
using System.Data;
using Microsoft.Data.SqlClient;

class Program
{
    static void Main()
    {
        LoadProductsWithStockGreaterThan20();
    }

    static void LoadProductsWithStockGreaterThan20()
    {
        string connectionString = "Server=.;Database=NorthWind;Trusted_Connection=True;";
        string query = "SELECT * FROM Products WHERE UnitsInStock > 20";

        try
        {

            using SqlConnection connection = new SqlConnection(connectionString);

            using SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataSet ds = new DataSet();


            adapter.Fill(ds, "FilteredProducts");


            DataTable productsTable = ds.Tables["FilteredProducts"];


            Console.WriteLine("Products with UnitsInStock > 20:");
            foreach (DataRow row in productsTable.Rows)
            {
                Console.WriteLine($"ProductID: {row["ProductID"]}, ProductName: {row["ProductName"]}, UnitsInStock: {row["UnitsInStock"]}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
} 
