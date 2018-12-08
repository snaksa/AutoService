using AutoService.Forms.EmloyeeForms;
using AutoService.Forms.PartForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            EmployeeList form = new EmployeeList();
            form.Show();
        }

        private void autoButton_Click(object sender, EventArgs e)
        {
            CarList form = new CarList();
            form.Show();
        }

        private void partsButton_Click(object sender, EventArgs e)
        {
            PartList form = new PartList();
            form.Show();
        }
    }
}
