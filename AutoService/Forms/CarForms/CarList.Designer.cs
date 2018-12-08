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
            this.CarAddButton.Location = new System.Drawing.Point(62, 106);
            this.CarAddButton.Name = "CarAddButton";
            this.CarAddButton.Size = new System.Drawing.Size(143, 23);
            this.CarAddButton.TabIndex = 0;
            this.CarAddButton.Text = "Добавяне на автомобил";
            this.CarAddButton.UseVisualStyleBackColor = true;
            this.CarAddButton.Click += new System.EventHandler(this.CarAddButton_Click);
            // 
            // CarRmv
            // 
            this.CarRmv.Location = new System.Drawing.Point(62, 135);
            this.CarRmv.Name = "CarRmv";
            this.CarRmv.Size = new System.Drawing.Size(143, 23);
            this.CarRmv.TabIndex = 1;
            this.CarRmv.Text = "Изтриване на автомобил";
            this.CarRmv.UseVisualStyleBackColor = true;
            this.CarRmv.Click += new System.EventHandler(this.CarRmv_Click);
            // 
            // carsDataGridView
            // 
            this.carsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataGridView.Location = new System.Drawing.Point(9, 203);
            this.carsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.carsDataGridView.Name = "carsDataGridView";
            this.carsDataGridView.RowTemplate.Height = 24;
            this.carsDataGridView.Size = new System.Drawing.Size(516, 181);
            this.carsDataGridView.TabIndex = 2;
            // 
            // editCarButton
            // 
            this.editCarButton.Location = new System.Drawing.Point(237, 106);
            this.editCarButton.Margin = new System.Windows.Forms.Padding(2);
            this.editCarButton.Name = "editCarButton";
            this.editCarButton.Size = new System.Drawing.Size(70, 28);
            this.editCarButton.TabIndex = 3;
            this.editCarButton.Text = "Redakciq";
            this.editCarButton.UseVisualStyleBackColor = true;
            this.editCarButton.Click += new System.EventHandler(this.editCarButton_Click);
            // 
            // CarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 387);
            this.Controls.Add(this.editCarButton);
            this.Controls.Add(this.carsDataGridView);
            this.Controls.Add(this.CarRmv);
            this.Controls.Add(this.CarAddButton);
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

