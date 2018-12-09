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
            this.SuspendLayout();
            // 
            // ModelAddButton
            // 
            this.ModelAddButton.Location = new System.Drawing.Point(12, 33);
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
            this.label.Location = new System.Drawing.Point(11, 7);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(39, 13);
            this.label.TabIndex = 6;
            this.label.Text = "Model:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(79, 7);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 5;
            // 
            // ModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 71);
            this.Controls.Add(this.ModelAddButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.modelTextBox);
            this.Name = "ModelForm";
            this.Text = "ModelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModelAddButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox modelTextBox;
    }
}