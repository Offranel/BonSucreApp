using Microsoft.Data.SqlClient;
using BonSucreApp.Models;

namespace BonSucreApp.DB
{
    internal class CustomerDB
    {
        private static string connectionString =
            "Server=localhost;Database=BonSucre;Trusted_Connection=true;TrustServerCertificate=True;";
        public static List<Customer> GetAllCustomers() 
        {
            List<Customer> customers = new List<Customer>();

            using (SqlConnection connection = new SqlConnection(connectionString)) 
            { 
                string query = "SELECT * FROM Customers";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                { 
                    Customer customer = new Customer();

                    customer.CustomerId = (int)reader["CustomerId"];
                    customer.Name = reader["Name"].ToString();
                    customer.Email = reader["Email"].ToString();
                    customer.DateOfBirth = (DateTime)reader["DateOfBirth"];

                    customers.Add(customer);
                }
            }
            
            return customers;
        }
    }
}
