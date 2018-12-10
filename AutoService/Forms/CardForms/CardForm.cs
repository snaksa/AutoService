using AutoService.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Autoservice.Models;
using System.Data.SqlClient;

namespace AutoService.Forms
{
    public partial class CardForm : Form
    {
        int id = 0;
        List<Car> cars;
        List<Employee> employees;

        public CardForm(int id = 0)
        {
            InitializeComponent();
            RepairCard card = null;

            cars = CarRepository.GetAll();
            foreach (Car c in cars)
                carDropdown.Items.Add(c.RegistrationNumber);

            employees = EmployeeRepository.GetAll();
            foreach (Employee e in employees)
                employeeDropdown.Items.Add(e.Name);

            this.getParts(id);
            if (id != 0)
            {
                this.id = id;
                card = RepairCardRepository.Get(id);
            }

            if (card != null)
            {
                dateInDatetime.Value = card.In;
                dateOutDatetime.Value = card.Out;
                descriptionTextbox.Text = card.Description;
                numberTextbox.Text = card.Number;
                carDropdown.Text = card.Car.RegistrationNumber;
                employeeDropdown.Text = card.Employee.Name;
            }
            else
            {
                carDropdown.Text = this.cars.Count > 0 ? this.cars[0].RegistrationNumber : "";
                employeeDropdown.Text = this.employees.Count > 0 ? this.employees[0].Name : "";
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            RepairCard p = new RepairCard(this.id, numberTextbox.Text, 
                dateInDatetime.Value, dateOutDatetime.Value, 
                this.cars[carDropdown.SelectedIndex], descriptionTextbox.Text, 
                this.employees[employeeDropdown.SelectedIndex]);

            if (p.Id == 0) RepairCardRepository.Add(p);
            else RepairCardRepository.Update(p);

            this.Close();
        }

        private void getParts(int id)
        {
            using (SqlConnection con = new SqlConnection(CarRepository.connectionString))
            {
                con.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(
                    "SELECT id as ID, name as Name, number as Number, price as Price " +
                    "FROM card_parts p " +
                    "LEFT JOIN parts part ON part.id = p.partId " +
                    "WHERE p.cardId = @id", con))
                {
                    adapter.SelectCommand.Parameters.Add("@id", SqlDbType.Int);
                    adapter.SelectCommand.Parameters["@id"].Value = id;
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    partsGridView.DataSource = table;
                }
            }
        }

        private void addPartButton_Click(object sender, EventArgs e)
        {

        }
    }
}
