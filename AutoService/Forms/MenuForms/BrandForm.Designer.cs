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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandForm));
            this.label = new System.Windows.Forms.Label();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.BrandAddButton = new System.Windows.Forms.Button();
            this.namePictureBox = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.namePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Silver;
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(35, 15);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(54, 17);
            this.label.TabIndex = 3;
            this.label.Text = "Марка:";
            // 
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(105, 15);
            this.brandTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(132, 22);
            this.brandTextBox.TabIndex = 2;
            // 
            // BrandAddButton
            // 
            this.BrandAddButton.Location = new System.Drawing.Point(123, 47);
            this.BrandAddButton.Margin = new System.Windows.Forms.Padding(4);
            this.BrandAddButton.Name = "BrandAddButton";
            this.BrandAddButton.Size = new System.Drawing.Size(100, 28);
            this.BrandAddButton.TabIndex = 4;
            this.BrandAddButton.Text = "Запази";
            this.BrandAddButton.UseVisualStyleBackColor = true;
            this.BrandAddButton.Click += new System.EventHandler(this.BrandAddButton_Click);
            // 
            // namePictureBox
            // 
            this.namePictureBox.Image = global::AutoService.Properties.Resources.high_priority;
            this.namePictureBox.Location = new System.Drawing.Point(245, 15);
            this.namePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.namePictureBox.Name = "namePictureBox";
            this.namePictureBox.Size = new System.Drawing.Size(31, 23);
            this.namePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.namePictureBox.TabIndex = 5;
            this.namePictureBox.TabStop = false;
            this.namePictureBox.MouseHover += new System.EventHandler(this.namePictureBox_MouseHover);
            // 
            // BrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(293, 98);
            this.Controls.Add(this.namePictureBox);
            this.Controls.Add(this.BrandAddButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.brandTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BrandForm";
            this.Text = "Марка";
            ((System.ComponentModel.ISupportInitialize)(this.namePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.Button BrandAddButton;
        private System.Windows.Forms.PictureBox namePictureBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}