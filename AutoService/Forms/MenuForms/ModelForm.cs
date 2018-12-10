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
        List<Brand> brands;

        public ModelForm(int id = 0)
        {
            InitializeComponent();

            brands = BrandRepository.GetAll();
            foreach (Brand b in brands)
                brandsDropdown.Items.Add(b.Name);

            if (id != 0)
            {
                this.id = id;
                Model model =  ModelRepository.Get(id);
                modelTextBox.Text = model.Name;
                brandsDropdown.Text = model.Brand.Name;
            }
            else
            {
                brandsDropdown.Text = brands.Count > 0 ? brands[0].Name : "";
            }
        }
        private void ModelAddButton_Click(object sender, System.EventArgs e)
        {
            string name = modelTextBox.Text;
            Brand b = this.brands[brandsDropdown.SelectedIndex];

            if (this.id != 0) ModelRepository.Update(new Model(this.id, name, b));
            else ModelRepository.Add(new Model(0, name, b));

            this.Close();
        }
    }
}
