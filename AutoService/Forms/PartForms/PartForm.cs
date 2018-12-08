using AutoService.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService.Forms.PartForms
{
    public partial class PartForm : Form
    {
        int id = 0;
        public PartForm(int id = 0)
        {
            InitializeComponent();
            SpareParts part = null;
            if (id != 0)
            {
                this.id = id;
                part = PartRepository.Get(id);
            }
            if (part != null)
            {
                numberTextBox.Text = part.Number;
                nameTextBox.Text = part.Name;
                priceTextBox.Text = part.Price.ToString();

            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
                SpareParts p = new SpareParts(this.id, nameTextBox.Text, numberTextBox.Text, Double.Parse(numberTextBox.Text));

                if (p.Id == 0) PartRepository.Add(p);
                else PartRepository.Update(p);

                this.Close();
            }
    }
}
