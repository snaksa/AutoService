namespace AutoService.Forms.MenuForms
{
    partial class BrandForm
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
            this.label = new System.Windows.Forms.Label();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.BrandAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(11, 12);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Brand:";
            // 
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(79, 12);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(100, 20);
            this.brandTextBox.TabIndex = 2;
            // 
            // BrandAddButton
            // 
            this.BrandAddButton.Location = new System.Drawing.Point(12, 38);
            this.BrandAddButton.Name = "BrandAddButton";
            this.BrandAddButton.Size = new System.Drawing.Size(75, 23);
            this.BrandAddButton.TabIndex = 4;
            this.BrandAddButton.Text = "Запази";
            this.BrandAddButton.UseVisualStyleBackColor = true;
            this.BrandAddButton.Click += new System.EventHandler(this.BrandAddButton_Click);
            // 
            // BrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BrandAddButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.brandTextBox);
            this.Name = "BrandForm";
            this.Text = "BrandForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.Button BrandAddButton;
    }
}