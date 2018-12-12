namespace AutoService.Forms.CardForms
{
    partial class CardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.nomerErrorLabel = new System.Windows.Forms.Label();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.priceErrorLabel = new System.Windows.Forms.Label();
            this.dateInDatetime = new System.Windows.Forms.DateTimePicker();
            this.dateOutDatetime = new System.Windows.Forms.DateTimePicker();
            this.carDropdown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.employeeDropdown = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.descriptionTextbox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numberTextbox = new System.Windows.Forms.TextBox();
            this.partsGridView = new System.Windows.Forms.DataGridView();
            this.addPartButton = new System.Windows.Forms.Button();
            this.removePartButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.numberPictureBox = new System.Windows.Forms.PictureBox();
            this.dateInPictureBox = new System.Windows.Forms.PictureBox();
            this.carPictureBox = new System.Windows.Forms.PictureBox();
            this.employeePictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.partsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateInPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(32, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Постъпване:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(40, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Изписване:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(436, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кола:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(368, 311);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 28);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Запази";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nomerErrorLabel
            // 
            this.nomerErrorLabel.AutoSize = true;
            this.nomerErrorLabel.Location = new System.Drawing.Point(241, 114);
            this.nomerErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomerErrorLabel.Name = "nomerErrorLabel";
            this.nomerErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.nomerErrorLabel.TabIndex = 7;
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.Location = new System.Drawing.Point(579, 124);
            this.nameErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.nameErrorLabel.TabIndex = 8;
            // 
            // priceErrorLabel
            // 
            this.priceErrorLabel.AutoSize = true;
            this.priceErrorLabel.Location = new System.Drawing.Point(575, 160);
            this.priceErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceErrorLabel.Name = "priceErrorLabel";
            this.priceErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.priceErrorLabel.TabIndex = 9;
            // 
            // dateInDatetime
            // 
            this.dateInDatetime.Location = new System.Drawing.Point(132, 149);
            this.dateInDatetime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateInDatetime.Name = "dateInDatetime";
            this.dateInDatetime.Size = new System.Drawing.Size(200, 22);
            this.dateInDatetime.TabIndex = 10;
            // 
            // dateOutDatetime
            // 
            this.dateOutDatetime.Location = new System.Drawing.Point(132, 188);
            this.dateOutDatetime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateOutDatetime.Name = "dateOutDatetime";
            this.dateOutDatetime.Size = new System.Drawing.Size(200, 22);
            this.dateOutDatetime.TabIndex = 11;
            this.dateOutDatetime.ValueChanged += new System.EventHandler(this.dateOutDatetime_ValueChanged);
            // 
            // carDropdown
            // 
            this.carDropdown.FormattingEnabled = true;
            this.carDropdown.Location = new System.Drawing.Point(504, 110);
            this.carDropdown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carDropdown.Name = "carDropdown";
            this.carDropdown.Size = new System.Drawing.Size(201, 24);
            this.carDropdown.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(408, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Служител:";
            // 
            // employeeDropdown
            // 
            this.employeeDropdown.FormattingEnabled = true;
            this.employeeDropdown.Location = new System.Drawing.Point(504, 148);
            this.employeeDropdown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeDropdown.Name = "employeeDropdown";
            this.employeeDropdown.Size = new System.Drawing.Size(201, 24);
            this.employeeDropdown.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(403, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Описание:";
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Location = new System.Drawing.Point(503, 185);
            this.descriptionTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(203, 73);
            this.descriptionTextbox.TabIndex = 16;
            this.descriptionTextbox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(64, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Номер:";
            // 
            // numberTextbox
            // 
            this.numberTextbox.Location = new System.Drawing.Point(131, 111);
            this.numberTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numberTextbox.Name = "numberTextbox";
            this.numberTextbox.Size = new System.Drawing.Size(201, 22);
            this.numberTextbox.TabIndex = 18;
            // 
            // partsGridView
            // 
            this.partsGridView.AllowUserToAddRows = false;
            this.partsGridView.AllowUserToDeleteRows = false;
            this.partsGridView.BackgroundColor = System.Drawing.Color.White;
            this.partsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsGridView.Location = new System.Drawing.Point(7, 350);
            this.partsGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partsGridView.MultiSelect = false;
            this.partsGridView.Name = "partsGridView";
            this.partsGridView.ReadOnly = true;
            this.partsGridView.RowTemplate.Height = 24;
            this.partsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsGridView.Size = new System.Drawing.Size(872, 276);
            this.partsGridView.TabIndex = 19;
            // 
            // addPartButton
            // 
            this.addPartButton.Location = new System.Drawing.Point(7, 311);
            this.addPartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(116, 32);
            this.addPartButton.TabIndex = 20;
            this.addPartButton.Text = "Добави част";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.addPartButton_Click);
            // 
            // removePartButton
            // 
            this.removePartButton.Location = new System.Drawing.Point(132, 310);
            this.removePartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removePartButton.Name = "removePartButton";
            this.removePartButton.Size = new System.Drawing.Size(119, 33);
            this.removePartButton.TabIndex = 21;
            this.removePartButton.Text = "Изтрий част";
            this.removePartButton.UseVisualStyleBackColor = true;
            this.removePartButton.Click += new System.EventHandler(this.removePartButton_Click);
            // 
            // numberPictureBox
            // 
            this.numberPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.numberPictureBox.ErrorImage = global::AutoService.Properties.Resources.car;
            this.numberPictureBox.Image = global::AutoService.Properties.Resources.high_priority;
            this.numberPictureBox.Location = new System.Drawing.Point(340, 111);
            this.numberPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.numberPictureBox.Name = "numberPictureBox";
            this.numberPictureBox.Size = new System.Drawing.Size(31, 23);
            this.numberPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.numberPictureBox.TabIndex = 22;
            this.numberPictureBox.TabStop = false;
            this.numberPictureBox.MouseHover += new System.EventHandler(this.numberPictureBox_MouseHover);
            // 
            // dateInPictureBox
            // 
            this.dateInPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.dateInPictureBox.Image = global::AutoService.Properties.Resources.high_priority;
            this.dateInPictureBox.Location = new System.Drawing.Point(340, 151);
            this.dateInPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.dateInPictureBox.Name = "dateInPictureBox";
            this.dateInPictureBox.Size = new System.Drawing.Size(31, 23);
            this.dateInPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dateInPictureBox.TabIndex = 23;
            this.dateInPictureBox.TabStop = false;
            this.dateInPictureBox.MouseHover += new System.EventHandler(this.dateInPictureBox_MouseHover);
            // 
            // carPictureBox
            // 
            this.carPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.carPictureBox.Image = global::AutoService.Properties.Resources.high_priority;
            this.carPictureBox.Location = new System.Drawing.Point(713, 109);
            this.carPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.carPictureBox.Name = "carPictureBox";
            this.carPictureBox.Size = new System.Drawing.Size(31, 23);
            this.carPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carPictureBox.TabIndex = 24;
            this.carPictureBox.TabStop = false;
            this.carPictureBox.MouseHover += new System.EventHandler(this.carPictureBox_MouseHover);
            // 
            // employeePictureBox
            // 
            this.employeePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.employeePictureBox.Image = global::AutoService.Properties.Resources.high_priority;
            this.employeePictureBox.Location = new System.Drawing.Point(713, 147);
            this.employeePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.employeePictureBox.Name = "employeePictureBox";
            this.employeePictureBox.Size = new System.Drawing.Size(31, 23);
            this.employeePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.employeePictureBox.TabIndex = 25;
            this.employeePictureBox.TabStop = false;
            this.employeePictureBox.MouseHover += new System.EventHandler(this.employeePictureBox_MouseHover);
            // 
            // descriptionPictureBox
            // 
            this.descriptionPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.descriptionPictureBox.Image = global::AutoService.Properties.Resources.high_priority;
            this.descriptionPictureBox.Location = new System.Drawing.Point(713, 185);
            this.descriptionPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionPictureBox.Name = "descriptionPictureBox";
            this.descriptionPictureBox.Size = new System.Drawing.Size(31, 23);
            this.descriptionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.descriptionPictureBox.TabIndex = 26;
            this.descriptionPictureBox.TabStop = false;
            this.descriptionPictureBox.MouseHover += new System.EventHandler(this.descriptionPictureBox_MouseHover);
            // 
            // CardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoService.Properties.Resources.bckgrndRepairCard;
            this.ClientSize = new System.Drawing.Size(883, 631);
            this.Controls.Add(this.descriptionPictureBox);
            this.Controls.Add(this.employeePictureBox);
            this.Controls.Add(this.carPictureBox);
            this.Controls.Add(this.dateInPictureBox);
            this.Controls.Add(this.numberPictureBox);
            this.Controls.Add(this.removePartButton);
            this.Controls.Add(this.addPartButton);
            this.Controls.Add(this.partsGridView);
            this.Controls.Add(this.numberTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.employeeDropdown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.carDropdown);
            this.Controls.Add(this.dateOutDatetime);
            this.Controls.Add(this.dateInDatetime);
            this.Controls.Add(this.priceErrorLabel);
            this.Controls.Add(this.nameErrorLabel);
            this.Controls.Add(this.nomerErrorLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CardForm";
            this.Text = "Ремонтна карта";
            ((System.ComponentModel.ISupportInitialize)(this.partsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateInPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label nomerErrorLabel;
        private System.Windows.Forms.Label nameErrorLabel;
        private System.Windows.Forms.Label priceErrorLabel;
        private System.Windows.Forms.DateTimePicker dateInDatetime;
        private System.Windows.Forms.DateTimePicker dateOutDatetime;
        private System.Windows.Forms.ComboBox carDropdown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox employeeDropdown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox descriptionTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox numberTextbox;
        private System.Windows.Forms.DataGridView partsGridView;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.Button removePartButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox numberPictureBox;
        private System.Windows.Forms.PictureBox dateInPictureBox;
        private System.Windows.Forms.PictureBox carPictureBox;
        private System.Windows.Forms.PictureBox employeePictureBox;
        private System.Windows.Forms.PictureBox descriptionPictureBox;
    }
}