﻿using AutoService.Forms;
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

namespace AutoService
{
    public partial class PartList : Form
    {
        public PartList()
        {
            InitializeComponent();
            this.getRecords();
        }

        private void PartAddButton_Click(object sender, EventArgs e)
        {
            PartForm form = new PartForm();
            form.FormClosed += new FormClosedEventHandler(this.OnFormClose);
            form.Show();
        }

        private void editPartButton_Click(object sender, EventArgs e)
        {
            int index = partsDataGridView.SelectedCells.Count > 0 ? partsDataGridView.SelectedCells[0].RowIndex : -1;
            index = index != -1 ? Int32.Parse(partsDataGridView.Rows[index].Cells[0].Value.ToString()) : 0;
            PartForm form = new PartForm(index);
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
                     "SELECT p.id as ID, p.name as Име, p.number as Номер, p.price as Цена FROM parts p"
                    , con))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    partsDataGridView.DataSource = table;
                }
            }
        }


        private void partEditButton_Click(object sender, EventArgs e)
        {
            int index = partsDataGridView.SelectedCells.Count > 0 ? partsDataGridView.SelectedCells[0].RowIndex : -1;
            index = index != -1 ? Int32.Parse(partsDataGridView.Rows[index].Cells[0].Value.ToString()) : 0;
            PartForm form = new PartForm(index);
            form.FormClosed += new FormClosedEventHandler(this.OnFormClose);
            form.Show();
        }

        private void PartRmv_Click(object sender, EventArgs e)
        {
            int index = partsDataGridView.SelectedCells.Count > 0 ? partsDataGridView.SelectedCells[0].RowIndex : -1;
            index = index != -1 ? Int32.Parse(partsDataGridView.Rows[index].Cells[0].Value.ToString()) : 0;
            if (index == 0)
            {
                MessageBox.Show("Please select row!", "No record selected?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show("Сигурни ли сте, че искате да изтриете записа?", "Изтриване?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (PartRepository.IsUsed(index))
                {
                    MessageBox.Show("Частта се използва в карта!", "Използвана част!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    PartRepository.Remove(PartRepository.Get(index));
                    this.getRecords();
                }
            }
        }
    }
}

