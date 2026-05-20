using Microsoft.Data.SqlClient;
using BonSucreApp.Models;

namespace BonSucreApp.DB
{
    internal class ReviewDB
    {
        private static string connectionString =
            "Server=localhost;Database=BonSucre;Trusted_Connection=true;TrustServerCertificate=True;";

        public static void AddReview(Review review)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query =
              "INSERT INTO Reviews (CustomerId, DessertId, Score, Date) " +
               "VALUES (@CustomerId, @DessertId, @Score, @Date)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@CustomerId", review.CustomerId);
                command.Parameters.AddWithValue("@DessertId", review.DessertId);
                command.Parameters.AddWithValue("@Score", review.Score);
                command.Parameters.AddWithValue("@Date", DateTime.Now);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}