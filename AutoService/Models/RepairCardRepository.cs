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
                                reader.GetString(1).Trim(),
                                reader.GetDateTime(2),
                                reader.IsDBNull(3) ? null : (DateTime?)reader.GetDateTime(3),
                                new Car(reader.GetInt32(4), reader.GetString(5).Trim()),
                                reader.GetString(6).Trim(),
                                new Employee(reader.GetInt32(7), reader.GetString(8).Trim()));
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
                using (SqlCommand command = new SqlCommand("INSERT INTO cards (dateIn, dateOut, carId, employeeId, description, number) VALUES(@dateIn, @dateOut, @carId, @employeeId, @description, @number)", con))
                {
                    command.Parameters.AddWithValue("@dateIn", card.In);
                    command.Parameters.AddWithValue("@dateOut", card.Out != null ? card.Out : (object)DBNull.Value);
                    command.Parameters.AddWithValue("@carId", card.Car.Id);
                    command.Parameters.AddWithValue("@employeeId", card.Employee.Id);
                    command.Parameters.AddWithValue("@description", card.Description);
                    command.Parameters.AddWithValue("@number", card.Number);
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
                    "UPDATE cards SET dateIn = @dateIn, dateOut = @dateOut, carId = @carId, " +
                    "employeeId = @employeeId, description = @description, number = @number " +
                    "WHERE id = @id", con))
                {
                    command.Parameters.AddWithValue("@id", card.Id);
                    command.Parameters.AddWithValue("@dateIn", card.In);
                    command.Parameters.AddWithValue("@dateOut", card.Out != null ? card.Out : (object)DBNull.Value);
                    command.Parameters.AddWithValue("@carId", card.Car.Id);
                    command.Parameters.AddWithValue("@employeeId", card.Employee.Id);
                    command.Parameters.AddWithValue("@description", card.Description);
                    command.Parameters.AddWithValue("@number", card.Number);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void Remove(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand("DELETE FROM card_parts WHERE cardId = @id", con))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }

                using (SqlCommand command = new SqlCommand("DELETE FROM cards WHERE id = @id", con))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddPart(int id, SpareParts part)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO card_parts (cardId, partId) VALUES(@cardId, @partId)", con))
                {
                    command.Parameters.AddWithValue("@cardId", id);
                    command.Parameters.AddWithValue("@partId", part.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void RemovePart(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM card_parts WHERE id = @id", con))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void RemoveByCar(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("DELETE p FROM card_parts p " +
                    "LEFT JOIN cards card ON p.cardId = card.id " +
                    "WHERE card.carId = @id", con))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }

                using (SqlCommand command = new SqlCommand("DELETE FROM cards " +
                    "WHERE carId = @id", con))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static SqlDataAdapter GetAfterStartDate(DateTime date)
        {
            SqlConnection con = new SqlConnection(CarRepository.connectionString);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(
                 "SELECT c.id as ID, c.number as Номер, e.name as 'Име на служител', c.dateIn as 'Приемане', c.dateOut as 'Изписване', " +
                 "car.regNumber as 'Рег. номер', car.ownerName as 'Собственик', TotalPrice as 'Обща цена' " +
                 "FROM cards c " +
                 "LEFT JOIN employees e ON c.employeeId = e.id " +
                 "LEFT JOIN cars car ON c.carId = car.id " +
                 "LEFT JOIN(" +
                 "SELECT cp.cardId as cId, SUM(part.price) as TotalPrice " +
                 "FROM card_parts cp " +
                 "LEFT JOIN parts part ON part.id = cp.partId " +
                 "GROUP BY cp.cardId) s ON cId = c.id " +
                 "WHERE c.dateIn >= @date ", con);
            adapter.SelectCommand.Parameters.AddWithValue("@date", date);
            return adapter;
        }

        public static SqlDataAdapter GetBeforeEndDate(DateTime date)
        {
            SqlConnection con = new SqlConnection(CarRepository.connectionString);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(
                "SELECT c.id as ID, c.number as Номер, e.name as 'Име на служител', c.dateIn as 'Приемане', c.dateOut as 'Изписване', " +
                 "car.regNumber as 'Рег. номер', car.ownerName as 'Собственик', TotalPrice as 'Обща цена' " +
                 "FROM cards c " +
                 "LEFT JOIN employees e ON c.employeeId = e.id " +
                 "LEFT JOIN cars car ON c.carId = car.id " +
                 "LEFT JOIN(" +
                 "SELECT cp.cardId as cId, SUM(part.price) as TotalPrice " +
                 "FROM card_parts cp " +
                 "LEFT JOIN parts part ON part.id = cp.partId " +
                 "GROUP BY cp.cardId) s ON cId = c.id " +
                 "WHERE c.dateOut <= @date ", con);
            adapter.SelectCommand.Parameters.AddWithValue("@date", date);
            return adapter;
        }

        public static SqlDataAdapter GetByCar(Car car)
        {
            SqlConnection con = new SqlConnection(CarRepository.connectionString);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(
                "SELECT c.id as ID, c.number as Номер, e.name as 'Име на служител', c.dateIn as 'Приемане', c.dateOut as 'Изписване', " +
                 "car.regNumber as 'Рег. номер', car.ownerName as 'Собственик', TotalPrice as 'Обща цена' " +
                 "FROM cards c " +
                 "LEFT JOIN employees e ON c.employeeId = e.id " +
                 "LEFT JOIN cars car ON c.carId = car.id " +
                 "LEFT JOIN(" +
                 "SELECT cp.cardId as cId, SUM(part.price) as TotalPrice " +
                 "FROM card_parts cp " +
                 "LEFT JOIN parts part ON part.id = cp.partId " +
                 "GROUP BY cp.cardId) s ON cId = c.id " +
                 "WHERE c.carId = @id ", con);

            adapter.SelectCommand.Parameters.AddWithValue("@id", car.Id);
            return adapter;

        }

        public static SqlDataAdapter GetNotReady()
        {
            SqlConnection con = new SqlConnection(CarRepository.connectionString);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(
                "SELECT c.id as ID, c.number as Номер, e.name as 'Име на служител', c.dateIn as 'Приемане', c.dateOut as 'Изписване', " +
                 "car.regNumber as 'Рег. номер', car.ownerName as 'Собственик', TotalPrice as 'Обща цена' " +
                 "FROM cards c " +
                 "LEFT JOIN employees e ON c.employeeId = e.id " +
                 "LEFT JOIN cars car ON c.carId = car.id " +
                 "LEFT JOIN(" +
                 "SELECT cp.cardId as cId, SUM(part.price) as TotalPrice " +
                 "FROM card_parts cp " +
                 "LEFT JOIN parts part ON part.id = cp.partId " +
                 "GROUP BY cp.cardId) s ON cId = c.id " +
                 "WHERE c.dateOut IS NULL", con);
            return adapter;
        }
    }
}
