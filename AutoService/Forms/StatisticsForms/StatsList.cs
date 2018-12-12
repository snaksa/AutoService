using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using AutoService.Forms.CardForms;
using AutoService.Models;

namespace AutoService.Forms.StatisticsForms
{
    public partial class StatsList : Form
    {
        List<Car> cars;
        public StatsList()
        {
            InitializeComponent();
            
            dateTimePicker.Visible = true;
            carDropdown.Visible = false;
            thirdShowButton.Visible = false;
            this.showCardButton.Visible = false;

            typeDropdown.SelectedIndex = 0;

            cars = CarRepository.GetAll();
            foreach (Car c in cars)
                carDropdown.Items.Add(c.RegistrationNumber);
        }

        private void typeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeDropdown.SelectedIndex == 0 || typeDropdown.SelectedIndex == 1)
            {
                dateTimePicker.Visible = true;
                carDropdown.Visible = false;

                showButton.Visible = true;
                thirdShowButton.Visible = false;
            }
            else if (typeDropdown.SelectedIndex == 2)
            {
                dateTimePicker.Visible = false;

                carDropdown.Visible = true;
                carDropdown.SelectedIndex = 0;

                showButton.Visible = true;
                thirdShowButton.Visible = false;
            }
            else if (typeDropdown.SelectedIndex == 3)
            {
                carDropdown.Visible = false;
                dateTimePicker.Visible = false;
                showButton.Visible = false;
                thirdShowButton.Visible = true;
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            if (typeDropdown.SelectedIndex == 0)
            {
                DateTime date = dateTimePicker.Value;
                SqlDataAdapter adapter = RepairCardRepository.GetAfterStartDate(date);
                adapter.Fill(table);
                resultsDataGridView.DataSource = table;
                int a = table.Rows.Count;
            }
            if (typeDropdown.SelectedIndex == 1)
            {
                DateTime date = dateTimePicker.Value;
                SqlDataAdapter adapter = RepairCardRepository.GetBeforeEndDate(date);
                adapter.Fill(table);
                resultsDataGridView.DataSource = table;
            }
            if (typeDropdown.SelectedIndex == 2)
            {
                DateTime date = dateTimePicker.Value;
                Car car = this.cars[carDropdown.SelectedIndex];
                SqlDataAdapter adapter = RepairCardRepository.GetByCar(car);
                adapter.Fill(table);
                resultsDataGridView.DataSource = table;
            }
            if (typeDropdown.SelectedIndex == 3)
            {
                SqlDataAdapter adapter = RepairCardRepository.GetNotReady();
                adapter.Fill(table);
                resultsDataGridView.DataSource = table;
            }

            showCardButton.Visible = table.Rows.Count > 0;
        }

        private void showCardButton_Click(object sender, EventArgs e)
        {
            int index = resultsDataGridView.SelectedCells.Count > 0 ? resultsDataGridView.SelectedCells[0].RowIndex : -1;
            index = index != -1 ? Int32.Parse(resultsDataGridView.Rows[index].Cells[0].Value.ToString()) : 0;
            CardForm form = new CardForm(index);
            form.FormClosed += new FormClosedEventHandler(this.OnFormClose);
            form.Show();
        }

        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            this.showButton_Click(null, null);
        }
    }
}
