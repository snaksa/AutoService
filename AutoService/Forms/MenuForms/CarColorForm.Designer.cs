namespace AutoService.Forms.MenuForms
{
    partial class CarColorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarColorForm));
            this.CarColorAddButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.carcolorTextBox = new System.Windows.Forms.TextBox();
            this.namePictureBox = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.namePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CarColorAddButton
            // 
            this.CarColorAddButton.Location = new System.Drawing.Point(88, 53);
            this.CarColorAddButton.Margin = new System.Windows.Forms.Padding(4);
            this.CarColorAddButton.Name = "CarColorAddButton";
            this.CarColorAddButton.Size = new System.Drawing.Size(100, 28);
            this.CarColorAddButton.TabIndex = 10;
            this.CarColorAddButton.Text = "Запази";
            this.CarColorAddButton.UseVisualStyleBackColor = true;
            this.CarColorAddButton.Click += new System.EventHandler(this.CarColorAddButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(16, 20);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(45, 17);
            this.label.TabIndex = 9;
            this.label.Text = "Цвят:";
            // 
            // carcolorTextBox
            // 
            this.carcolorTextBox.Location = new System.Drawing.Point(71, 20);
            this.carcolorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.carcolorTextBox.Name = "carcolorTextBox";
            this.carcolorTextBox.Size = new System.Drawing.Size(132, 22);
            this.carcolorTextBox.TabIndex = 8;
            // 
            // namePictureBox
            // 
            this.namePictureBox.Image = global::AutoService.Properties.Resources.high_priority;
            this.namePictureBox.Location = new System.Drawing.Point(213, 20);
            this.namePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.namePictureBox.Name = "namePictureBox";
            this.namePictureBox.Size = new System.Drawing.Size(26, 22);
            this.namePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.namePictureBox.TabIndex = 11;
            this.namePictureBox.TabStop = false;
            this.namePictureBox.MouseHover += new System.EventHandler(this.namePictureBox_MouseHover);
            // 
            // CarColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(267, 100);
            this.Controls.Add(this.namePictureBox);
            this.Controls.Add(this.CarColorAddButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.carcolorTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CarColorForm";
            this.Text = "Цвят:";
            ((System.ComponentModel.ISupportInitialize)(this.namePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CarColorAddButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox carcolorTextBox;
        private System.Windows.Forms.PictureBox namePictureBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}