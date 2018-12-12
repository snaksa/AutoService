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

namespace AutoService.Forms.MenuForms
{
    public partial class CarColorForm : Form
    {
        private int id = 0;
        public CarColorForm(int id = 0)
        {
            InitializeComponent();

            namePictureBox.Visible = false;

            if (id != 0)
            {
                this.id = id;
                CarColor color = CarColorRepository.Get(id);
                carcolorTextBox.Text = color.Name;
            }
        }
        private void CarColorAddButton_Click(object sender, System.EventArgs e)
        {
            namePictureBox.Visible = false;
            if (carcolorTextBox.Text.Length == 0) {
                namePictureBox.Visible = true;
                return;
            }

            string name = carcolorTextBox.Text;

            if (this.id != 0) CarColorRepository.Update(new CarColor(this.id, name));
            else CarColorRepository.Add(new CarColor(0, name));

            this.Close();
        }

        private void namePictureBox_MouseHover(object sender, EventArgs e) {
            toolTip1.SetToolTip(namePictureBox, "Въведете име!");
        }
    }
}

