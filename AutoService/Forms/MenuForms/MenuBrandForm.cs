

using AutoService.Forms.MenuForms;
using AutoService.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AutoService.Forms
{
    public partial class MenuBrandForm : Form
    {
        public MenuBrandForm()
        {
            InitializeComponent();
            this.getRecords();
        }

        private void BrandAdd_Click(object sender, EventArgs e)
        {
            BrandForm form = new BrandForm();
            form.FormClosed += new FormClosedEventHandler(this.OnFormClose);
            form.Show();
        }

        private void BrandEdit_Click(object sender, EventArgs e)
        {
            int index = brandGridView.SelectedCells.Count > 0 ? brandGridView.SelectedCells[0].RowIndex : -1;
            index = index != -1 ? Int32.Parse(brandGridView.Rows[index].Cells[0].Value.ToString()) : 0;
            BrandForm form = new BrandForm(index);
            form.FormClosed += new FormClosedEventHandler(this.OnFormClose);
            form.Show();
        }


        private void OnFormClose(object sender, EventArgs e)
        {
            this.getRecords();
        }
        private void getRecords()
        {
            using (SqlConnection con = new SqlConnection(BrandRepository.connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("SELECT id AS ID, name AS Name FROM brands", con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT id AS ID, name AS Name FROM brands", con))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        brandGridView.DataSource = table;
                    }
                }
            }
        }

        private void BrandDelete_Click(object sender, EventArgs e)
        {
            int index = brandGridView.SelectedCells.Count > 0 ? brandGridView.SelectedCells[0].RowIndex : -1;
            index = index != -1 ? Int32.Parse(brandGridView.Rows[index].Cells[0].Value.ToString()) : 0;
            if (index == 0)
            {
                MessageBox.Show("Please select row!", "No record selected?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete the record?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                BrandRepository.Remove(index);
                this.getRecords();
            }
        }
    }
}
