namespace AutoService
{
    partial class CarList
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
            this.CarAddButton = new System.Windows.Forms.Button();
            this.CarRmv = new System.Windows.Forms.Button();
            this.carsDataGridView = new System.Windows.Forms.DataGridView();
            this.editCarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CarAddButton
            // 
            this.CarAddButton.Location = new System.Drawing.Point(83, 130);
            this.CarAddButton.Margin = new System.Windows.Forms.Padding(4);
            this.CarAddButton.Name = "CarAddButton";
            this.CarAddButton.Size = new System.Drawing.Size(191, 28);
            this.CarAddButton.TabIndex = 0;
            this.CarAddButton.Text = "Добавяне на автомобил";
            this.CarAddButton.UseVisualStyleBackColor = true;
            this.CarAddButton.Click += new System.EventHandler(this.CarAddButton_Click);
            // 
            // CarRmv
            // 
            this.CarRmv.Location = new System.Drawing.Point(83, 166);
            this.CarRmv.Margin = new System.Windows.Forms.Padding(4);
            this.CarRmv.Name = "CarRmv";
            this.CarRmv.Size = new System.Drawing.Size(191, 28);
            this.CarRmv.TabIndex = 1;
            this.CarRmv.Text = "Изтриване на автомобил";
            this.CarRmv.UseVisualStyleBackColor = true;
            // 
            // carsDataGridView
            // 
            this.carsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataGridView.Location = new System.Drawing.Point(12, 250);
            this.carsDataGridView.Name = "carsDataGridView";
            this.carsDataGridView.RowTemplate.Height = 24;
            this.carsDataGridView.Size = new System.Drawing.Size(688, 223);
            this.carsDataGridView.TabIndex = 2;
            // 
            // editCarButton
            // 
            this.editCarButton.Location = new System.Drawing.Point(316, 130);
            this.editCarButton.Name = "editCarButton";
            this.editCarButton.Size = new System.Drawing.Size(93, 34);
            this.editCarButton.TabIndex = 3;
            this.editCarButton.Text = "Redakciq";
            this.editCarButton.UseVisualStyleBackColor = true;
            this.editCarButton.Click += new System.EventHandler(this.editCarButton_Click);
            // 
            // CarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 476);
            this.Controls.Add(this.editCarButton);
            this.Controls.Add(this.carsDataGridView);
            this.Controls.Add(this.CarRmv);
            this.Controls.Add(this.CarAddButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CarList";
            this.Text = "Auto";
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CarAddButton;
        private System.Windows.Forms.Button CarRmv;
        private System.Windows.Forms.DataGridView carsDataGridView;
        private System.Windows.Forms.Button editCarButton;
    }
}

