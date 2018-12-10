using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AutoService.Models
{
    class ModelRepository
    {
        public static string connectionString = System.Configuration
            .ConfigurationManager
            .ConnectionStrings["AutoServiceConnectionString"]
            .ConnectionString;

        public static Model Get(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("SELECT m.id as ID, m.name as Name, b.id as brandId, b.name as brandName FROM models m LEFT JOIN brands b ON m.brandId = b.id where m.id = @id", con))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters["@id"].Value = id;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return new Model(reader.GetInt32(0), reader.GetString(1).Trim(), new Brand(reader.GetInt32(2), reader.GetString(3)));
                        }
                    }
                }
            }

            return null;
        }

        public static List<Model> GetAll()
        {
            List<Model> models = new List<Model>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("SELECT id as ID, name as Name FROM models", con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            models.Add(new Model(reader.GetInt32(0), reader.GetString(1)));
                        }
                    }
                }
            }

            return models;
        }

        public static List<Model> GetForBrand(int brandId)
        {
            List<Model> models = new List<Model>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("SELECT id as ID, name as Name FROM models where brandId = @id", con))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters["@id"].Value = brandId;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {   
                        while (reader.Read())
                            models.Add(new Model(reader.GetInt32(0), reader.GetString(1)));
                    }
                }
            }

            return models;
        }

        public static void Add(Model m)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO models (name, brandId) VALUES(@name, @brand)", con))
                {
                    command.Parameters.Add("@name", SqlDbType.NVarChar);
                    command.Parameters["@name"].Value = m.Name;
                    command.Parameters.Add("@brandId", SqlDbType.Int);
                    command.Parameters["@brandId"].Value = m.Brand.Id;

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void Update(Model model)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("UPDATE models SET name = @name, brandId = @brandId WHERE id = @id", con))
                {
                    command.Parameters.AddWithValue("@id", model.Id);
                    command.Parameters.AddWithValue("@name", model.Name);
                    command.Parameters.AddWithValue("@brandId", model.Brand.Id);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void Remove(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM models WHERE id = @id", con))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
