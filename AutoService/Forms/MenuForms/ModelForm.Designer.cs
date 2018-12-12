namespace AutoService.Forms.MenuForms
{
    partial class ModelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelForm));
            this.ModelAddButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.brandsDropdown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ModelAddButton
            // 
            this.ModelAddButton.Location = new System.Drawing.Point(65, 85);
            this.ModelAddButton.Name = "ModelAddButton";
            this.ModelAddButton.Size = new System.Drawing.Size(75, 23);
            this.ModelAddButton.TabIndex = 7;
            this.ModelAddButton.Text = "Запази";
            this.ModelAddButton.UseVisualStyleBackColor = true;
            this.ModelAddButton.Click += new System.EventHandler(this.ModelAddButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(13, 14);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(43, 13);
            this.label.TabIndex = 6;
            this.label.Text = "Модел:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(81, 14);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Марка:";
            // 
            // brandsDropdown
            // 
            this.brandsDropdown.FormattingEnabled = true;
            this.brandsDropdown.Location = new System.Drawing.Point(81, 41);
            this.brandsDropdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brandsDropdown.Name = "brandsDropdown";
            this.brandsDropdown.Size = new System.Drawing.Size(100, 21);
            this.brandsDropdown.TabIndex = 9;
            // 
            // ModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(230, 120);
            this.Controls.Add(this.brandsDropdown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModelAddButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.modelTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModelForm";
            this.Text = "Модел";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModelAddButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox brandsDropdown;
    }
}