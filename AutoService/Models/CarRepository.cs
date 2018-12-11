using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AutoService.Models
{
    class CarRepository
    {
        public static string connectionString = System.Configuration
            .ConfigurationManager
            .ConnectionStrings["AutoServiceConnectionString"]
            .ConnectionString;

        public static Car Get(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(
                    "SELECT c.id as ID, c.regNumber as regNumber, m.id as modelId, m.name as modelName, "
                    + "b.id as brandId, b.name as brandName, "
                    + "c.year as Year, c.engineNumber, c.frameNumber, col.id as colorId, col.name as colorName, " 
                    + "c.engineVolume, c.description, c.ownerName, c.contactNumber "
                    + "FROM cars c "
                    + "LEFT JOIN models m ON m.id = c.modelId "
                    + "LEFT JOIN brands b ON b.id = m.brandId "
                    + "LEFT JOIN colors col ON col.id = c.colorId "
                    + "WHERE c.id = @id", con))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters["@id"].Value = id;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return new Car(
                                reader.GetInt32(0),
                                reader.GetString(1).Trim(),
                                new Model(reader.GetInt32(2), reader.GetString(3).Trim(), 
                                new Brand(reader.GetInt32(4), reader.GetString(5).Trim())),
                                reader.GetInt32(6),
                                reader.GetString(7).Trim(),
                                reader.GetString(8).Trim(),
                                new CarColor(reader.GetInt32(9), reader.GetString(10).Trim()),
                                reader.GetString(11).Trim(),
                                reader.GetString(12).Trim(),
                                reader.GetString(13).Trim(),
                                reader.GetString(14).Trim());
                        }
                    }
                }
            }

            return null;
        }

        public static List<Car> GetAll()
        {
            List<Car> models = new List<Car>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(
                     "SELECT c.id as ID, c.regNumber as regNumber, m.id as modelId, m.name as modelName, "
                    + "b.id as brandId, b.name as brandName, "
                    + "c.year as Year, c.engineNumber, c.frameNumber, col.id as colorId, col.name as colorName, "
                    + "c.engineVolume, c.description, c.ownerName, c.contactNumber "
                    + "FROM cars c "
                    + "LEFT JOIN models m ON m.id = c.modelId "
                    + "LEFT JOIN brands b ON b.id = m.brandId "
                    + "LEFT JOIN colors col ON col.id = c.colorId", con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            models.Add(new Car(
                                reader.GetInt32(0),
                                reader.GetString(1).Trim(),
                                new Model(reader.GetInt32(2), reader.GetString(3).Trim(),
                                new Brand(reader.GetInt32(4), reader.GetString(5).Trim())),
                                reader.GetInt32(6),
                                reader.GetString(7).Trim(),
                                reader.GetString(8).Trim(),
                                new CarColor(reader.GetInt32(9), reader.GetString(10).Trim()),
                                reader.GetString(11).Trim(),
                                reader.GetString(12).Trim(),
                                reader.GetString(13).Trim(),
                                reader.GetString(14).Trim()));
                        }
                    }
                }
            }

            return models;
        }

        public static void Add(Car car)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO cars (regNumber, modelId, "
                    + "year, engineNumber, frameNumber, colorId, "
                    + "engineVolume, description, ownerName, contactNumber) " +
                    "VALUES (@regNumber, @modelId, @year, @engineNumber, @frameNumber, @colorId, @engineVolume, @description, @ownerName, @contactNumber)", con))
                {
                    command.Parameters.AddWithValue("@regNumber", car.RegistrationNumber);
                    command.Parameters.AddWithValue("@modelId", car.Model.Id);
                    command.Parameters.AddWithValue("@year", car.Year);
                    command.Parameters.AddWithValue("@engineNumber", car.EngineNumber);
                    command.Parameters.AddWithValue("@frameNumber", car.FrameNumber);
                    command.Parameters.AddWithValue("@colorId", car.Color.Id);
                    command.Parameters.AddWithValue("@engineVolume", car.EngineVolume);
                    command.Parameters.AddWithValue("@description", car.Description);
                    command.Parameters.AddWithValue("@ownerName", car.CarOwnerName);
                    command.Parameters.AddWithValue("@contactNumber", car.ContactNumber);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void Update(Car car)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("UPDATE cars SET regNumber = @regNumber, modelId = @modelId, "
                    + "year = @year, engineNumber = @engineNumber, frameNumber = @frameNumber, colorId = @colorId, "
                    + "engineVolume = @engineVolume, description = @description, ownerName = @ownerName, contactNumber = @contactNumber WHERE id = @id", con))
                {
                    command.Parameters.AddWithValue("@id", car.Id);
                    command.Parameters.AddWithValue("@regNumber", car.RegistrationNumber);
                    command.Parameters.AddWithValue("@modelId", car.Model.Id);
                    command.Parameters.AddWithValue("@year", car.Year);
                    command.Parameters.AddWithValue("@engineNumber", car.EngineNumber);
                    command.Parameters.AddWithValue("@frameNumber", car.FrameNumber);
                    command.Parameters.AddWithValue("@colorId", car.Color.Id);
                    command.Parameters.AddWithValue("@engineVolume", car.EngineVolume);
                    command.Parameters.AddWithValue("@description", car.Description);
                    command.Parameters.AddWithValue("@ownerName", car.CarOwnerName);
                    command.Parameters.AddWithValue("@contactNumber", car.ContactNumber);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void Remove(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM cars WHERE id = @id", con))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters["@id"].Value = id;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
