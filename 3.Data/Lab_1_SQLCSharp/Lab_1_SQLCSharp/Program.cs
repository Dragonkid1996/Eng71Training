using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace Lab_1_SQLCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>();

            using (var connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Northwind; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            {
                connection.Open();
                Console.WriteLine(connection.State);


                ////READ
                //using (var command = new SqlCommand("select * from customers", connection))
                //{
                //    SqlDataReader sqlReader = command.ExecuteReader();

                //    while (sqlReader.Read())
                //    {
                //        //create variables for customer
                //        var customerID = sqlReader["CustomerID"].ToString();
                //        var contactName = sqlReader["ContactName"].ToString();
                //        var companyName = sqlReader["CompanyName"].ToString();
                //        var city = sqlReader["City"].ToString();
                //        var contactTitle = sqlReader["ContactTitle"].ToString();

                //        //new customer object
                //        var customer = new Customer { CustomerID = customerID, ContactName = contactName, 
                //                                      City = city, CompanyName = companyName, ContactTitle = contactTitle };
                //        customers.Add(customer);
                //    }

                //    foreach (var c in customers)
                //    {
                //        Console.WriteLine(c.GetFullName());
                //    }
                //}

                ////CREATE and insert

                //var newCustomer = new Customer
                //{
                //    CustomerID = "NEWE",
                //    ContactName = "Dominic Newell",
                //    ContactTitle = "Customer",
                //    City = "Bedford",
                //    CompanyName = "Sparta Global"
                //};

                //string sqlString = $"INSERT INTO CUSTOMERS(CustomerId, ContactName, ContactTitle, City, CompanyName) " +
                //                    $"VALUES ('{newCustomer.CustomerID}', '{newCustomer.ContactName}','{newCustomer.ContactTitle}','{newCustomer.City}','{newCustomer.CompanyName}')";

                //using (var command2 = new SqlCommand(sqlString, connection))
                //{
                //    int affected = command2.ExecuteNonQuery();
                //}

                ////UPDATE

                //var selectedCustomer = new Customer
                //{
                //    CustomerID = "NEWE",
                //    ContactName = "Dominic Newell",
                //    ContactTitle = "Customer",
                //    City = "Bedford",
                //    CompanyName = "Sparta Global"
                //};

                //string sqlString2 = $"UPDATE CUSTOMERS SET City = 'Berlin' WHERE CustomerID = '{selectedCustomer.CustomerID}'";

                //using (var command3 = new SqlCommand(sqlString2, connection))
                //{
                //    var affected = command3.ExecuteNonQuery();
                //};

                ////DELETE

                //var selectedCustomer2 = new Customer
                //{
                //    CustomerID = "NEWE",
                //    ContactName = "Dominic Newell",
                //    ContactTitle = "Customer",
                //    City = "Bedford",
                //    CompanyName = "Sparta Global"
                //};

                //var sqlstring3 = $"DELETE FROM CUSTOMERS WHERE CustomerID = '{selectedCustomer2.CustomerID}'";

                //using (var command4 = new SqlCommand(sqlstring3, connection))
                //{
                //    int affected = command4.ExecuteNonQuery();
                //}

                using(var updateCustomerCommand = new SqlCommand("UpdateCustomer", connection))
                {
                    updateCustomerCommand.CommandType = CommandType.StoredProcedure;
                    updateCustomerCommand.Parameters.AddWithValue("ID", "MANDA");
                    updateCustomerCommand.Parameters.AddWithValue("CustomerName", "Nish Mandal");
                    int affected = updateCustomerCommand.ExecuteNonQuery();
                }
            }
        }
    }

    public class Customer
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string City { get; set; }

        public string GetFullName()
        {
            return $"{ContactTitle} - {ContactName}";
        }
    }
}
