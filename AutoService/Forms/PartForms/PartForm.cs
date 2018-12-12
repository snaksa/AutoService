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
using System.Globalization;

namespace AutoService.Forms.PartForms
{
    public partial class PartForm : Form
    {
        int id = 0;
        public PartForm(int id = 0)
        {
            InitializeComponent();

            numberPictureBox.Visible = false;
            namePictureBox.Visible = false;
            pricePictureBox.Visible = false;

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
            double result;
            numberPictureBox.Visible = false;
            namePictureBox.Visible = false;
            pricePictureBox.Visible = false;
            bool error = false;
            if (nameTextBox.Text.Length == 0) {
                namePictureBox.Visible = true;
                error = true;
            }
            if (numberTextBox.Text.Length == 0) {
                numberPictureBox.Visible = true;
                error = true;
            }
            if (priceTextBox.Text.Length == 0 || !Double.TryParse(priceTextBox.Text, out result)) {
                pricePictureBox.Visible = true;
                error = true;
            }

            if (error) return;

            SpareParts p = new SpareParts(this.id, nameTextBox.Text, numberTextBox.Text, Double.Parse(priceTextBox.Text, CultureInfo.InvariantCulture));

            if (p.Id == 0) PartRepository.Add(p);
            else PartRepository.Update(p);

            this.Close();
        }

        private void numberPictureBox_MouseHover(object sender, EventArgs e) {
            toolTip1.SetToolTip(numberPictureBox, "Въведете номер!");
        }

        private void namePictureBox_MouseHover(object sender, EventArgs e) {
            toolTip1.SetToolTip(namePictureBox, "Въведете име!");
        }

        private void pricePictureBox_MouseHover(object sender, EventArgs e) {
            toolTip1.SetToolTip(pricePictureBox, "Въвдете цена!");
        }

    }
}
