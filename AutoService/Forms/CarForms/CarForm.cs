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

namespace AutoService.Forms
{
    public partial class CarForm : Form
    {
        int id = 0;
        List<Brand> brands;
        List<Model> models;
        List<CarColor> colors;

        public CarForm(int id = 0)
        {
            InitializeComponent();

            this.hideErrors();

            Car car = null;
            if (id != 0)
            {
                this.id = id;
                car = CarRepository.Get(id);
            }

            colors = CarColorRepository.GetAll();
            foreach (CarColor c in colors)
                colorDropdown.Items.Add(c.Name);

            brands = BrandRepository.GetAll();
            foreach (Brand b in brands)
                brandDropdown.Items.Add(b.Name);

            if (car == null)
                if (brands.Count > 0) models = ModelRepository.GetForBrand(brands[0].Id);
                else models = new List<Model>();
            else
                models = ModelRepository.GetForBrand(car.Model.Brand.Id);

            foreach (Model m in models)
                modelDropdown.Items.Add(m.Name);

            if (car != null)
            {
                regTextbox.Text = car.RegistrationNumber;
                yearTextbox.Text = car.Year.ToString();
                engineTextbox.Text = car.EngineNumber;
                frameTextbox.Text = car.FrameNumber;
                engineVolumeTextbox.Text = car.EngineVolume;
                descriptionTextbox.Text = car.Description;
                ownerTextbox.Text = car.CarOwnerName;
                phoneTextbox.Text = car.ContactNumber;

                brandDropdown.Text = car.Model != null ? car.Model.Brand.Name : "";
                modelDropdown.Text = car.Model != null ? car.Model.Name : "";
                colorDropdown.Text = car.Color != null ? car.Color.Name : "";
            }
            else
            {
                brandDropdown.Text = this.brands.Count > 0 ? this.brands[0].Name : "";
                modelDropdown.Text = this.models.Count > 0 ? this.models[0].Name : "";
                colorDropdown.Text = this.colors.Count > 0 ? this.colors[0].Name : "";
            }
        }

        private void CarSave_Click(object sender, EventArgs e)
        {
            this.hideErrors();
            bool error = false;
            int result;
            if (regTextbox.Text.Length <= 0) {
                regPictureBox.Visible = true;
                error = true;
            }
            if (engineTextbox.Text.Length <= 0) {
                enginePictureBox.Visible = true;
                error = true;
            }
            if (engineVolumeTextbox.Text.Length <= 0) {
                engineVolumePictureBox.Visible = true;
                error = true;
            }
            if (yearTextbox.Text.Length <= 0 && !Int32.TryParse(yearTextbox.Text, out result)) {
                yearPictureBox.Visible = true;
                error = true;
            }
            if (descriptionTextbox.Text.Length <= 0) {
                descriptionPictureBox.Visible = true;
                error = true;
            }
            if (ownerTextbox.Text.Length <= 0) {
                ownerPictureBox.Visible = true;
                error = true;
            }
            if (phoneTextbox.Text.Length <= 0) {
                phonePictureBox.Visible = true;
                error = true;
            }
            if (frameTextbox.Text.Length <= 0) {
                ramaPictureBox.Visible = true;
                error = true;
            }
            if (modelDropdown.SelectedIndex == -1) {
                modelPictureBox.Visible = true;
                error = true;
            }
            if (brandDropdown.SelectedIndex == -1) {
                brandPicturebox.Visible = true;
                error = true;
            }
            if (colorDropdown.SelectedIndex == -1) {
                colorPictureBox.Visible = true;
                error = true;
            }

            if(error) return;

            Car c = new Car(this.id, regTextbox.Text, this.models[modelDropdown.SelectedIndex], Int32.Parse(yearTextbox.Text), engineTextbox.Text, frameTextbox.Text,
                this.colors[colorDropdown.SelectedIndex], engineVolumeTextbox.Text, descriptionTextbox.Text, ownerTextbox.Text, phoneTextbox.Text);

            if (c.Id == 0) CarRepository.Add(c);
            else CarRepository.Update(c);

            this.Close();
        }

        private void brandDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelDropdown.Enabled = false;
            modelDropdown.Items.Clear();
            this.models = ModelRepository.GetForBrand(this.brands[brandDropdown.SelectedIndex].Id);
            foreach (Model m in this.models)
                modelDropdown.Items.Add(m.Name);
            modelDropdown.Text = this.models.Count > 0 ? this.models[0].Name : "";
            modelDropdown.Enabled = true;
        }


        private void brandPictureBox_MouseHover(object sender, EventArgs e) {
            toolTip1.SetToolTip(brandPicturebox, "Изберете марка!");
        }

        private void modelPictureBox_MouseHover(object sender, EventArgs e) {
            toolTip1.SetToolTip(modelPictureBox, "Изберете модел!");
        }

        private void yearPictureBox_MouseHover(object sender, EventArgs e) {
            toolTip1.SetToolTip(yearPictureBox, "Въвдете година!");
        }

        private void colorPictureBox_MouseHover(object sender, EventArgs e) {
            toolTip1.SetToolTip(colorPictureBox, "Изберете цвят!");
        }

        private void ownerPictureBox_MouseHover(object sender, EventArgs e) {
            toolTip1.SetToolTip(ownerPictureBox, "Въвдете собственик!");
        }

        private void phonePictureBox_MouseHover(object sender, EventArgs e) {
            toolTip1.SetToolTip(phonePictureBox, "Въвдете телефон!");
        }

        private void regPictureBox_MouseHover(object sender, EventArgs e) {
            toolTip1.SetToolTip(regPictureBox, "Въвдете номер!");
        }

        private void enginePictureBox_MouseHover(object sender, EventArgs e) {
            toolTip1.SetToolTip(enginePictureBox, "Въвдете двигател!");
        }

        private void ramaPictureBox_MouseHover(object sender, EventArgs e) {
            toolTip1.SetToolTip(ramaPictureBox, "Въвдете рама!");
        }

        private void engineVolumePictureBox_MouseHover(object sender, EventArgs e) {
            toolTip1.SetToolTip(engineVolumePictureBox, "Въвдете обем!");
        }

        private void descriptionPictureBox_MouseHover(object sender, EventArgs e) {
            toolTip1.SetToolTip(descriptionPictureBox, "Въвдете описание!");
        }

        private void hideErrors() {
            modelPictureBox.Visible = false;
            brandPicturebox.Visible = false;
            yearPictureBox.Visible = false;
            colorPictureBox.Visible = false;
            ownerPictureBox.Visible = false;
            phonePictureBox.Visible = false;
            regPictureBox.Visible = false;
            enginePictureBox.Visible = false;
            ramaPictureBox.Visible = false;
            engineVolumePictureBox.Visible = false;
            descriptionPictureBox.Visible = false;
        }

    }
}
