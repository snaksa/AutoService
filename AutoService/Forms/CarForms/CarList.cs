using AutoService.Forms;
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

namespace AutoService
{
    public partial class CarList : Form
    {
        public CarList()
        {
            InitializeComponent();
            this.getRecords();
        }

        private void CarAddButton_Click(object sender, EventArgs e)
        {
            CarForm form = new CarForm();
            form.FormClosed += new FormClosedEventHandler(this.OnFormClose);
            form.Show();
        }

        private void editCarButton_Click(object sender, EventArgs e)
        {
            int index = carsDataGridView.SelectedCells.Count > 0 ? carsDataGridView.SelectedCells[0].RowIndex : -1;
            index = index != -1 ? Int32.Parse(carsDataGridView.Rows[index].Cells[0].Value.ToString()) : 0;
            CarForm form = new CarForm(index);
            form.FormClosed += new FormClosedEventHandler(this.OnFormClose);
            form.Show();
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
                     "SELECT c.id as ID, c.regNumber as RegNumber, b.name as Brand, m.name as Model, "
                    + "c.year as Year, c.engineNumber as EngineNumber, c.frameNumber as FrameNumber, col.name as ColorName, c.engineVolume as EngineVolume, "
                    + "c.description as Description, c.ownerName as OwnerName, c.contactNumber as ContactNumber FROM cars c "
                    + "LEFT JOIN models m ON m.id = c.modelId "
                    + "LEFT JOIN brands b ON b.id = m.brandId "
                    + "LEFT JOIN colors col ON col.id = c.colorId "
                    , con))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    carsDataGridView.DataSource = table;
                }
            }
        }
    }
}
