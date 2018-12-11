using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AutoService.Models;

namespace AutoService.Forms.CardForms
{
    public partial class SelectPartForm : Form
    {
        List<SpareParts> parts;
        int id;

        public SelectPartForm(int id)
        {
            InitializeComponent();

            this.id = id;

            parts = PartRepository.GetAll();
            foreach (SpareParts part in parts)
                partsCombobox.Items.Add(part.Name);

            partsCombobox.SelectedIndex = 0;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            RepairCardRepository.AddPart(this.id, this.parts[partsCombobox.SelectedIndex]);
            this.Close();
        }
    }
}
