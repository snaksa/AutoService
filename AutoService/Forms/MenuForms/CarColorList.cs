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

namespace AutoService.Forms.MenuForms
{
    public partial class CarColorList : Form
    {
        public CarColorList()
        {
            InitializeComponent();
            this.getRecords();
        }

        private void CarColorAdd_Click(object sender, EventArgs e)
        {
            CarColorForm form = new CarColorForm();
            form.FormClosed += new FormClosedEventHandler(this.OnFormClose);
            form.Show();
        }

        private void OnFormClose(object sender, EventArgs e)
        {
            this.getRecords();
        }
        private void getRecords()
        {
            using (SqlConnection con = new SqlConnection(CarColorRepository.connectionString))
            {
                con.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT id AS ID, name AS Name FROM colors", con))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    carcolorGridView.DataSource = table;
                }
            }
        }



        private void CarColorDelete_Click(object sender, EventArgs e)
        {
            int index = carcolorGridView.SelectedCells.Count > 0 ? carcolorGridView.SelectedCells[0].RowIndex : -1;
            index = index != -1 ? Int32.Parse(carcolorGridView.Rows[index].Cells[0].Value.ToString()) : 0;
            if (index == 0)
            {
                MessageBox.Show("Please select row!", "No record selected?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete the record?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                CarColorRepository.Remove(index);
                this.getRecords();
            }
        }

        private void CarColorEdit_Click(object sender, EventArgs e)
        {
            int index = carcolorGridView.SelectedCells.Count > 0 ? carcolorGridView.SelectedCells[0].RowIndex : -1;
            index = index != -1 ? Int32.Parse(carcolorGridView.Rows[index].Cells[0].Value.ToString()) : 0;
            CarColorForm form = new CarColorForm(index);
            form.FormClosed += new FormClosedEventHandler(this.OnFormClose);
            form.Show();
        }
    }
}
