using Autoservice.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace AutoService.Models
{
    class PartRepository
    {
        public static string connectionString = System.Configuration
            .ConfigurationManager
            .ConnectionStrings["AutoServiceConnectionString"]
            .ConnectionString;

        public static SpareParts Get(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("SELECT id as ID, name as Name, number as Number, price as Price  FROM parts where id = @id", con))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters["@id"].Value = id;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return new SpareParts(reader.GetInt32(0), reader.GetString(1).Trim(),reader.GetString(2).Trim(), double.Parse(reader.GetString(3), CultureInfo.InvariantCulture));
                        }
                    }
                }
            }

            return null;
        }
        public static List<SpareParts> GetAll()
        {
            List<SpareParts> parts = new List<SpareParts>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("SELECT id as ID, name as Name, number as Number, price as Price FROM parts", con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            parts.Add(new SpareParts(reader.GetInt32(0), reader.GetString(1).Trim(), reader.GetString(2).Trim(), reader.GetDouble(3)));
                        }
                    }
                }
            }

            return parts;
        }

        public static List<SpareParts> GetByCard(RepairCard card)
        {
            List<SpareParts> parts = new List<SpareParts>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(
                    "SELECT id as ID, name as Name, number as Number, price as Price FROM card_parts p " +
                    "LEFT JOIN parts part ON part.id = p.partId " +
                    "WHERE p.cardId = @id", con))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters["@id"].Value = card.Id;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            parts.Add(new SpareParts(reader.GetInt32(0), reader.GetString(1).Trim(), reader.GetString(2).Trim(), reader.GetDouble(3)));
                        }
                    }
                }
            }

            return parts;
        }

        public static void Add(SpareParts part)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO parts (name,number,price) VALUES(@name,@number,@price)", con))
                {
                  
                    command.Parameters.AddWithValue("@name", part.Name);
                    command.Parameters.AddWithValue("@number", part.Number);
                    command.Parameters.AddWithValue("@price", part.Price);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void Update(SpareParts part)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("UPDATE parts SET name = @name, number = @number, price = @price WHERE id = @id", con))
                {
                    command.Parameters.AddWithValue("@id", part.Id);
                    command.Parameters.AddWithValue("@name", part.Name);
                    command.Parameters.AddWithValue("@number", part.Number);
                    command.Parameters.AddWithValue("@price", part.Price);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void Remove(SpareParts part)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM parts WHERE id = @id", con))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters["@id"].Value = part.Id;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
