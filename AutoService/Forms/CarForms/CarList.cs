using AutoService.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService
{
    public partial class CarList : Form
    {
        public CarList()
        {
            InitializeComponent();
        }

        private void CarAddButton_Click(object sender, EventArgs e)
        {
            CarForm form = new CarForm();
            form.Show();
        }
    }
}
