using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using AutoService.Models;

namespace AutoService.Forms.CardForms
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
                     "SELECT c.id as ID, c.number as Номер, e.name as Служител, c.dateIn as Приемане, c.dateOut as Изписване, " +
                     "car.regNumber as 'Рег. Номер', car.ownerName as Собственик, TotalPrice as 'Обща цена' " +
                     "FROM cards c " +
                     "LEFT JOIN employees e ON c.employeeId = e.id " +
                     "LEFT JOIN cars car ON c.carId = car.id " +
                     "LEFT JOIN(" +
                     "SELECT cp.cardId as cId, SUM(part.price) as TotalPrice " +
                     "FROM card_parts cp " +
                     "LEFT JOIN parts part ON part.id = cp.partId " +
                     "GROUP BY cp.cardId) s ON cId = c.id", con))
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

        private void RemoveCardButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сигурни ли сте, че искате да изтриете записа?", "Изтриване?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int index = cardsDataGridView.SelectedCells.Count > 0 ? cardsDataGridView.SelectedCells[0].RowIndex : -1;
                index = index != -1 ? Int32.Parse(cardsDataGridView.Rows[index].Cells[0].Value.ToString()) : 0;
                RepairCardRepository.Remove(index);
                this.getRecords();
            }
        }
    }
}

