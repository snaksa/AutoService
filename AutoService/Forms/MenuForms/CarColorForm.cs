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

            if (id != 0)
            {
                this.id = id;
                CarColor ccolor = CarColorRepository.Get(id);
                carcolorTextBox.Text = ccolor.Name;
            }
        }
        private void CarColorAddButton_Click(object sender, System.EventArgs e)
        {
            string name = carcolorTextBox.Text;

            if (this.id != 0) CarColorRepository.Update(this.id, name);
            else CarColorRepository.Add(name);

            this.Close();
        }
    }
}

