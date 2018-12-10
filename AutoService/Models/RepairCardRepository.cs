using Autoservice.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace AutoService.Models
{
    class RepairCardRepository
    {
        public static string connectionString = System.Configuration
            .ConfigurationManager
            .ConnectionStrings["AutoServiceConnectionString"]
            .ConnectionString;

        public static RepairCard Get(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(
                    "SELECT card.id as ID, card.number as number, card.dateIn as DateIn, " +
                    "card.dateOut as DateOut, car.id as carId, car.regNumber as carNumber, " +
                    "card.description as descrition, employee.id as employeeId, employee.name as employeeName " +
                    "FROM cards card " +
                    "LEFT JOIN cars car ON car.id = card.carId " +
                    "LEFT JOIN employees employee ON employee.id = card.employeeId " +
                    "where card.id = @id", con))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters["@id"].Value = id;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return new RepairCard(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetDateTime(2),
                                reader.GetDateTime(3),
                                new Car(reader.GetInt32(4), reader.GetString(5)),
                                reader.GetString(6),
                                new Employee(reader.GetInt32(7), reader.GetString(8)));
                        }
                    }
                }
            }

            return null;
        }

        public static void Add(RepairCard card)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO cards (dateIn, dateOut, carId, employeeId, description) VALUES(@dateIn, @dateOut, @carId, @employeeId, @description)", con))
                {
                    command.Parameters.AddWithValue("@dateIn", card.In);
                    command.Parameters.AddWithValue("@dateOut", card.Out);
                    command.Parameters.AddWithValue("@carId", card.Car.Id);
                    command.Parameters.AddWithValue("@employeeId", card.Employee.Id);
                    command.Parameters.AddWithValue("@description", card.Description);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void Update(RepairCard card)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(
                    "UPDATE parts SET dateIn = @dateIn, dateOut = @dateOut, carId = @carId, " +
                    "employeeId = @employeeId, description = @description " +
                    "WHERE id = @id", con))
                {
                    command.Parameters.AddWithValue("@id", card.Id);
                    command.Parameters.AddWithValue("@dateIn", card.In);
                    command.Parameters.AddWithValue("@dateOut", card.Out);
                    command.Parameters.AddWithValue("@carId", card.Car.Id);
                    command.Parameters.AddWithValue("@employeeId", card.Employee.Id);
                    command.Parameters.AddWithValue("@description", card.Description);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void Remove(RepairCard card)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM cards WHERE id = @id", con))
                {
                    command.Parameters.AddWithValue("@id", card.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
