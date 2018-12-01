using System;
using System.Windows.Forms;
using AutoService.Models;

namespace AutoService.Forms.EmloyeeForms
{
    public partial class EmployeeForm : Form
    {
        private int id = 0;
        public EmployeeForm(int id = 0)
        {
            InitializeComponent();
            
            if(id != 0)
            {
                this.id = id;
                Employee employee = EmployeeRepository.Get(id);
                nameTextBox.Text = employee.Name;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;

            if (this.id != 0) EmployeeRepository.Update(this.id, name);
            else EmployeeRepository.Add(name);

            this.Close();
        }
    }
}
