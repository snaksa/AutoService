namespace AutoService.Forms
{
    partial class Main
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
            this.autoButton = new System.Windows.Forms.Button();
            this.partsButton = new System.Windows.Forms.Button();
            this.cartsButton = new System.Windows.Forms.Button();
            this.employeesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // autoButton
            // 
            this.autoButton.Location = new System.Drawing.Point(38, 30);
            this.autoButton.Name = "autoButton";
            this.autoButton.Size = new System.Drawing.Size(75, 23);
            this.autoButton.TabIndex = 0;
            this.autoButton.Text = "Автомобили";
            this.autoButton.UseVisualStyleBackColor = true;
            this.autoButton.Click += new System.EventHandler(this.autoButton_Click);
            // 
            // partsButton
            // 
            this.partsButton.Location = new System.Drawing.Point(38, 69);
            this.partsButton.Name = "partsButton";
            this.partsButton.Size = new System.Drawing.Size(75, 23);
            this.partsButton.TabIndex = 1;
            this.partsButton.Text = "Части";
            this.partsButton.UseVisualStyleBackColor = true;
            this.partsButton.Click += new System.EventHandler(this.partsButton_Click);
            // 
            // cartsButton
            // 
            this.cartsButton.Location = new System.Drawing.Point(38, 110);
            this.cartsButton.Name = "cartsButton";
            this.cartsButton.Size = new System.Drawing.Size(75, 23);
            this.cartsButton.TabIndex = 2;
            this.cartsButton.Text = "Карти";
            this.cartsButton.UseVisualStyleBackColor = true;
            // 
            // employeesButton
            // 
            this.employeesButton.Location = new System.Drawing.Point(38, 151);
            this.employeesButton.Name = "employeesButton";
            this.employeesButton.Size = new System.Drawing.Size(75, 23);
            this.employeesButton.TabIndex = 3;
            this.employeesButton.Text = "Служители";
            this.employeesButton.UseVisualStyleBackColor = true;
            this.employeesButton.Click += new System.EventHandler(this.employeesButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 385);
            this.Controls.Add(this.employeesButton);
            this.Controls.Add(this.cartsButton);
            this.Controls.Add(this.partsButton);
            this.Controls.Add(this.autoButton);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button autoButton;
        private System.Windows.Forms.Button partsButton;
        private System.Windows.Forms.Button cartsButton;
        private System.Windows.Forms.Button employeesButton;
    }
}