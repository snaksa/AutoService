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

namespace AutoService.Forms.CardForms
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

            if (id != 0)
            {
                this.id = id;
                card = RepairCardRepository.Get(id);
            }


            dateOutDatetime.CustomFormat = " ";
            dateOutDatetime.Format = DateTimePickerFormat.Custom;

            if (card != null)
            {
                this.getParts();
                dateInDatetime.Value = card.In;
                if (card.Out != null)
                {
                    dateOutDatetime.Value = (DateTime)card.Out;
                }
                descriptionTextbox.Text = card.Description;
                numberTextbox.Text = card.Number;
                carDropdown.Text = card.Car.RegistrationNumber;
                employeeDropdown.Text = card.Employee.Name;
            }
            else
            {
                carDropdown.Text = this.cars.Count > 0 ? this.cars[0].RegistrationNumber : "";
                employeeDropdown.Text = this.employees.Count > 0 ? this.employees[0].Name : "";
                partsGridView.Visible = false;
                addPartButton.Visible = false;
                removePartButton.Visible = false;
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            DateTime? dateOut = null;
            if (dateOutDatetime.Format != DateTimePickerFormat.Custom)
            {
                dateOut = dateOutDatetime.Value;
            }
            RepairCard p = new RepairCard(this.id, numberTextbox.Text,
                dateInDatetime.Value, dateOut,
                this.cars[carDropdown.SelectedIndex], descriptionTextbox.Text,
                this.employees[employeeDropdown.SelectedIndex]);

            if (p.Id == 0) RepairCardRepository.Add(p);
            else RepairCardRepository.Update(p);

            this.Close();
        }

        private void getParts()
        {
            using (SqlConnection con = new SqlConnection(CarRepository.connectionString))
            {
                con.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(
                    "SELECT p.id as ID, part.name as Name, part.number as Number, part.price as Price " +
                    "FROM card_parts p " +
                    "LEFT JOIN parts part ON part.id = p.partId " +
                    "WHERE p.cardId = @id", con))
                {
                    adapter.SelectCommand.Parameters.Add("@id", SqlDbType.Int);
                    adapter.SelectCommand.Parameters["@id"].Value = this.id;
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    partsGridView.DataSource = table;
                }
            }
        }

        private void addPartButton_Click(object sender, EventArgs e)
        {
            SelectPartForm form = new SelectPartForm(this.id);
            form.FormClosed += new FormClosedEventHandler(this.OnFormClose);
            form.Show();
        }

        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            this.getParts();
        }

        private void removePartButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int index = partsGridView.SelectedCells.Count > 0 ? partsGridView.SelectedCells[0].RowIndex : -1;
                index = index != -1 ? Int32.Parse(partsGridView.Rows[index].Cells[0].Value.ToString()) : 0;
                RepairCardRepository.RemovePart(index);
                this.getParts();
            }
        }

        private void dateOutDatetime_ValueChanged(object sender, EventArgs e)
        {
            dateOutDatetime.Format = DateTimePickerFormat.Long;
        }
    }
}
