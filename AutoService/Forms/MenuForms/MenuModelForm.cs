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
    public partial class MenuModelForm : Form
    {
        
public MenuModelForm()
        {
            InitializeComponent();
            this.getRecords();
        }

        private void ModelAdd_Click(object sender, EventArgs e)
        {
            ModelForm form = new ModelForm();
            form.FormClosed += new FormClosedEventHandler(this.OnFormClose);
            form.Show();
        }

        private void OnFormClose(object sender, EventArgs e)
        {
            this.getRecords();
        }
        private void getRecords()
        {
            using (SqlConnection con = new SqlConnection(ModelRepository.connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("SELECT id AS ID, name AS Name FROM models", con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT id AS ID, name AS Name FROM models", con))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        modelGridView.DataSource = table;
                    }
                }
            }
        }



        private void ModelDelete_Click(object sender, EventArgs e)
        {
            int index = modelGridView.SelectedCells.Count > 0 ? modelGridView.SelectedCells[0].RowIndex : -1;
            index = index != -1 ? Int32.Parse(modelGridView.Rows[index].Cells[0].Value.ToString()) : 0;
            if (index == 0)
            {
                MessageBox.Show("Please select row!", "No record selected?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete the record?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ModelRepository.Remove(index);
                this.getRecords();
            }
        }

        private void ModelEdit_Click(object sender, EventArgs e)
        {
            int index = modelGridView.SelectedCells.Count > 0 ? modelGridView.SelectedCells[0].RowIndex : -1;
            index = index != -1 ? Int32.Parse(modelGridView.Rows[index].Cells[0].Value.ToString()) : 0;
            ModelForm form = new ModelForm(index);
            form.FormClosed += new FormClosedEventHandler(this.OnFormClose);
            form.Show();
        }
    }
}
