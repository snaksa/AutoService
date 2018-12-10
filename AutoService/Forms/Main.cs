using AutoService.Forms.EmloyeeForms;
using AutoService.Forms.MenuForms;
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

   
        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuBrandForm form = new MenuBrandForm();
            form.Show();
        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuModelForm form = new MenuModelForm();
            form.Show();
        }

        private void carColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuCarColor form = new MenuCarColor();
            form.Show();
        }
    }
}
