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
    public partial class ModelForm : Form
    {
        private int id = 0;
        public ModelForm(int id = 0)
        {
            InitializeComponent();

            if (id != 0)
            {
                this.id = id;
                Model model =  ModelRepository.Get(id);
                modelTextBox.Text = model.Name;
            }
        }
        private void ModelAddButton_Click(object sender, System.EventArgs e)
        {
            string name = modelTextBox.Text;

            if (this.id != 0) ModelRepository.Update(this.id, name);
            else ModelRepository.Add(name);

            this.Close();
        }
    }
}
