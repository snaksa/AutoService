using AutoService.Models;
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
    public partial class BrandForm : Form
    {
        private int id = 0;
        public BrandForm(int id = 0)
        {
            InitializeComponent();

            namePictureBox.Visible = false;

            if (id != 0)
            {
                this.id = id;
                Brand brand = BrandRepository.Get(id);
                brandTextBox.Text = brand.Name;
            }
        }
        private void BrandAddButton_Click(object sender, System.EventArgs e)
        {
            namePictureBox.Visible = false;
            if (brandTextBox.Text.Length == 0) {
                namePictureBox.Visible = true;
                return;
            }

            string name = brandTextBox.Text;

            if (this.id != 0) BrandRepository.Update(new Brand(this.id, name));
            else BrandRepository.Add(name);

            this.Close();
        }

        private void namePictureBox_MouseHover(object sender, System.EventArgs e) {
            toolTip1.SetToolTip(namePictureBox, "Въведете име!");
        }
    }
}
