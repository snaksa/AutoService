using AutoService.Forms;
using AutoService.Forms.PartForms;
using AutoService.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService.Forms
{
    public partial class CardList : Form
    {
        public CardList()
        {
            InitializeComponent();
            this.getRecords();
        }

        private void OnFormClose(object sender, EventArgs e)
        {
            this.getRecords();
        }

        private void getRecords()
        {
            using (SqlConnection con = new SqlConnection(CarRepository.connectionString))
            {
                con.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(
                     "SELECT c.id as ID, e.name as EmloyeeName, c.dateIn as DateIn, c.dateOut as DateOut, " +
                     "car.regNumber as CarRegNumber, car.ownerName as OwnerName " +
                     "FROM cards c " +
                     "LEFT JOIN employees e ON c.employeeId = e.id " +
                     "LEFT JOIN cars car ON c.carId = car.id"
                    , con))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    cardsDataGridView.DataSource = table;
                }
            }
        }

        private void CardAddButton_Click_1(object sender, EventArgs e)
        {
            CardForm form = new CardForm();
            form.FormClosed += new FormClosedEventHandler(this.OnFormClose);
            form.Show();
        }

        private void cardEditButton_Click(object sender, EventArgs e)
        {
            int index = cardsDataGridView.SelectedCells.Count > 0 ? cardsDataGridView.SelectedCells[0].RowIndex : -1;
            index = index != -1 ? Int32.Parse(cardsDataGridView.Rows[index].Cells[0].Value.ToString()) : 0;
            CardForm form = new CardForm(index);
            form.FormClosed += new FormClosedEventHandler(this.OnFormClose);
            form.Show();
        }
    }
}

