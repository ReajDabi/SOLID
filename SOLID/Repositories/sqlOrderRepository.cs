using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SOLID.Repositories
{
    public class sqlOrderRepository : IOrderRepository
    {
        private readonly string connectionString;

        public sqlOrderRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void SaveOrder(string email, decimal total)
        {
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();

                string sql = "INSERT INTO Orders (Email, Total)" + "VALUES (@e,@t)";

                using (SqlCommand cmd = new SqlCommand(sql , conn))
                {

                    cmd.Parameters.AddWithValue("@e", email);
                    cmd.Parameters.AddWithValue("@t", total);
                    cmd.ExecuteNonQuery(); }
            }
        }
    } }
