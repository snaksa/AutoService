namespace AutoService.Forms
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
            ((System.ComponentModel.ISupportInitialize)(this.partsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Постъпване:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Изписване:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кола:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(384, 140);
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
            this.nomerErrorLabel.Location = new System.Drawing.Point(251, 43);
            this.nomerErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomerErrorLabel.Name = "nomerErrorLabel";
            this.nomerErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.nomerErrorLabel.TabIndex = 7;
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.Location = new System.Drawing.Point(251, 119);
            this.nameErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.nameErrorLabel.TabIndex = 8;
            // 
            // priceErrorLabel
            // 
            this.priceErrorLabel.AutoSize = true;
            this.priceErrorLabel.Location = new System.Drawing.Point(247, 155);
            this.priceErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceErrorLabel.Name = "priceErrorLabel";
            this.priceErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.priceErrorLabel.TabIndex = 9;
            // 
            // dateInDatetime
            // 
            this.dateInDatetime.Location = new System.Drawing.Point(129, 43);
            this.dateInDatetime.Name = "dateInDatetime";
            this.dateInDatetime.Size = new System.Drawing.Size(200, 22);
            this.dateInDatetime.TabIndex = 10;
            // 
            // dateOutDatetime
            // 
            this.dateOutDatetime.Location = new System.Drawing.Point(129, 73);
            this.dateOutDatetime.Name = "dateOutDatetime";
            this.dateOutDatetime.Size = new System.Drawing.Size(200, 22);
            this.dateOutDatetime.TabIndex = 11;
            // 
            // carDropdown
            // 
            this.carDropdown.FormattingEnabled = true;
            this.carDropdown.Location = new System.Drawing.Point(129, 105);
            this.carDropdown.Name = "carDropdown";
            this.carDropdown.Size = new System.Drawing.Size(202, 24);
            this.carDropdown.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Служител:";
            // 
            // employeeDropdown
            // 
            this.employeeDropdown.FormattingEnabled = true;
            this.employeeDropdown.Location = new System.Drawing.Point(129, 143);
            this.employeeDropdown.Name = "employeeDropdown";
            this.employeeDropdown.Size = new System.Drawing.Size(202, 24);
            this.employeeDropdown.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Описание:";
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Location = new System.Drawing.Point(128, 177);
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(203, 95);
            this.descriptionTextbox.TabIndex = 16;
            this.descriptionTextbox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Номер:";
            // 
            // numberTextbox
            // 
            this.numberTextbox.Location = new System.Drawing.Point(129, 19);
            this.numberTextbox.Name = "numberTextbox";
            this.numberTextbox.Size = new System.Drawing.Size(202, 22);
            this.numberTextbox.TabIndex = 18;
            // 
            // partsGridView
            // 
            this.partsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsGridView.Location = new System.Drawing.Point(7, 350);
            this.partsGridView.Name = "partsGridView";
            this.partsGridView.RowTemplate.Height = 24;
            this.partsGridView.Size = new System.Drawing.Size(872, 276);
            this.partsGridView.TabIndex = 19;
            // 
            // addPartButton
            // 
            this.addPartButton.Location = new System.Drawing.Point(602, 312);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(75, 32);
            this.addPartButton.TabIndex = 20;
            this.addPartButton.Text = "Add part";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.addPartButton_Click);
            // 
            // removePartButton
            // 
            this.removePartButton.Location = new System.Drawing.Point(694, 311);
            this.removePartButton.Name = "removePartButton";
            this.removePartButton.Size = new System.Drawing.Size(119, 33);
            this.removePartButton.TabIndex = 21;
            this.removePartButton.Text = "Remove part";
            this.removePartButton.UseVisualStyleBackColor = true;
            // 
            // CardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 631);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CardForm";
            this.Text = "Cards";
            ((System.ComponentModel.ISupportInitialize)(this.partsGridView)).EndInit();
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
    }
}