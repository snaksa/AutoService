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
            this.ModelAddButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.brandsDropdown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ModelAddButton
            // 
            this.ModelAddButton.Location = new System.Drawing.Point(13, 74);
            this.ModelAddButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModelAddButton.Name = "ModelAddButton";
            this.ModelAddButton.Size = new System.Drawing.Size(100, 28);
            this.ModelAddButton.TabIndex = 7;
            this.ModelAddButton.Text = "Запази";
            this.ModelAddButton.UseVisualStyleBackColor = true;
            this.ModelAddButton.Click += new System.EventHandler(this.ModelAddButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(15, 9);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(50, 17);
            this.label.TabIndex = 6;
            this.label.Text = "Model:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(105, 9);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(132, 22);
            this.modelTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Brand:";
            // 
            // brandsDropdown
            // 
            this.brandsDropdown.FormattingEnabled = true;
            this.brandsDropdown.Location = new System.Drawing.Point(105, 42);
            this.brandsDropdown.Name = "brandsDropdown";
            this.brandsDropdown.Size = new System.Drawing.Size(132, 24);
            this.brandsDropdown.TabIndex = 9;
            // 
            // ModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 148);
            this.Controls.Add(this.brandsDropdown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModelAddButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.modelTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModelForm";
            this.Text = "ModelForm";
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