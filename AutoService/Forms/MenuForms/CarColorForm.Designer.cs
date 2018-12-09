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
            this.CarColorAddButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.carcolorTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CarColorAddButton
            // 
            this.CarColorAddButton.Location = new System.Drawing.Point(13, 35);
            this.CarColorAddButton.Name = "CarColorAddButton";
            this.CarColorAddButton.Size = new System.Drawing.Size(75, 23);
            this.CarColorAddButton.TabIndex = 10;
            this.CarColorAddButton.Text = "Запази";
            this.CarColorAddButton.UseVisualStyleBackColor = true;
            this.CarColorAddButton.Click += new System.EventHandler(this.CarColorAddButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(34, 13);
            this.label.TabIndex = 9;
            this.label.Text = "Color:";
            // 
            // carcolorTextBox
            // 
            this.carcolorTextBox.Location = new System.Drawing.Point(80, 9);
            this.carcolorTextBox.Name = "carcolorTextBox";
            this.carcolorTextBox.Size = new System.Drawing.Size(100, 20);
            this.carcolorTextBox.TabIndex = 8;
            // 
            // CarColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 81);
            this.Controls.Add(this.CarColorAddButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.carcolorTextBox);
            this.Name = "CarColorForm";
            this.Text = "CarColorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CarColorAddButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox carcolorTextBox;
    }
}