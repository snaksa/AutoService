using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using AutoService.Models;

namespace AutoService.Forms.EmloyeeForms
{
    public partial class EmployeeList : Form
    {

        public EmployeeList()
        {
            InitializeComponent();
            this.getRecords();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            EmployeeForm form = new EmployeeForm();
            form.FormClosed += new FormClosedEventHandler(this.OnFormClose);
            form.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int index = employeesGrid.SelectedCells.Count > 0 ? employeesGrid.SelectedCells[0].RowIndex : -1;
            index = index != -1 ? Int32.Parse(employeesGrid.Rows[index].Cells[0].Value.ToString()) : 0;
            EmployeeForm form = new EmployeeForm(index);
            form.FormClosed += new FormClosedEventHandler(this.OnFormClose);
            form.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int index = employeesGrid.SelectedCells.Count > 0 ? employeesGrid.SelectedCells[0].RowIndex : -1;
            index = index != -1 ? Int32.Parse(employeesGrid.Rows[index].Cells[0].Value.ToString()) : 0;
            if (index == 0)
            {
                MessageBox.Show("Please select row!", "No record selected?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show("Сигурни ли сте, че искате да изтриете записа?", "Изтриване?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                EmployeeRepository.Remove(index);
                this.getRecords();
            }
        }

        private void OnFormClose(object sender, EventArgs e)
        {
            this.getRecords();
        }

        private void getRecords()
        {
            using (SqlConnection con = new SqlConnection(EmployeeRepository.connectionString))
            {
                con.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT id AS ID, name AS Име FROM employees", con))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    employeesGrid.DataSource = table;
                }
            }
        }
    }
}
