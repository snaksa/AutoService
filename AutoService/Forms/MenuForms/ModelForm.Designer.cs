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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelForm));
            this.ModelAddButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.brandsDropdown = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ModelAddButton
            // 
            this.ModelAddButton.Location = new System.Drawing.Point(124, 90);
            this.ModelAddButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.label.Location = new System.Drawing.Point(17, 17);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(55, 17);
            this.label.TabIndex = 6;
            this.label.Text = "Модел:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(108, 17);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(132, 22);
            this.modelTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Марка:";
            // 
            // brandsDropdown
            // 
            this.brandsDropdown.FormattingEnabled = true;
            this.brandsDropdown.Location = new System.Drawing.Point(108, 50);
            this.brandsDropdown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brandsDropdown.Name = "brandsDropdown";
            this.brandsDropdown.Size = new System.Drawing.Size(132, 24);
            this.brandsDropdown.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoService.Properties.Resources.high_priority;
            this.pictureBox1.Location = new System.Drawing.Point(251, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AutoService.Properties.Resources.high_priority;
            this.pictureBox2.Location = new System.Drawing.Point(248, 52);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // ModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(307, 148);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.brandsDropdown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModelAddButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.modelTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModelForm";
            this.Text = "Модел";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModelAddButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox brandsDropdown;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}