using Microsoft.Data.SqlClient;
using BonSucreApp.Models;


namespace BonSucreApp.DB
{
    internal static class DessertDB
    {
        private static string connectionString =
            "Server=localhost;Database=BonSucre;Trusted_Connection=true;TrustServerCertificate=True;";

        public static List<Desert> GetAllDesserts()
        {
            List<Desert> desserts = new List<Desert>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Desserts";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Desert dessert = new Desert();

                    dessert.DessertId = (int)reader["DessertId"];
                    dessert.Name = reader["Name"].ToString();

                    desserts.Add(dessert);
                }
            }

            return desserts;
        }
    }
}
