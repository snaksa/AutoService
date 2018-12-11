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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarList));
            this.CarAddButton = new System.Windows.Forms.Button();
            this.CarRmv = new System.Windows.Forms.Button();
            this.carsDataGridView = new System.Windows.Forms.DataGridView();
            this.editCarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CarAddButton
            // 
            this.CarAddButton.Location = new System.Drawing.Point(-2, 2);
            this.CarAddButton.Name = "CarAddButton";
            this.CarAddButton.Size = new System.Drawing.Size(143, 23);
            this.CarAddButton.TabIndex = 0;
            this.CarAddButton.Text = "Добавяне на автомобил";
            this.CarAddButton.UseVisualStyleBackColor = true;
            this.CarAddButton.Click += new System.EventHandler(this.CarAddButton_Click);
            // 
            // CarRmv
            // 
            this.CarRmv.Location = new System.Drawing.Point(147, 2);
            this.CarRmv.Name = "CarRmv";
            this.CarRmv.Size = new System.Drawing.Size(143, 23);
            this.CarRmv.TabIndex = 1;
            this.CarRmv.Text = "Изтриване на автомобил";
            this.CarRmv.UseVisualStyleBackColor = true;
            this.CarRmv.Click += new System.EventHandler(this.CarRmv_Click);
            // 
            // carsDataGridView
            // 
            this.carsDataGridView.AllowUserToAddRows = false;
            this.carsDataGridView.AllowUserToDeleteRows = false;
            this.carsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.carsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.carsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.carsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.carsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.carsDataGridView.Location = new System.Drawing.Point(-2, 30);
            this.carsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.carsDataGridView.MultiSelect = false;
            this.carsDataGridView.Name = "carsDataGridView";
            this.carsDataGridView.ReadOnly = true;
            this.carsDataGridView.RowTemplate.Height = 24;
            this.carsDataGridView.RowTemplate.ReadOnly = true;
            this.carsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carsDataGridView.Size = new System.Drawing.Size(1245, 357);
            this.carsDataGridView.TabIndex = 2;
            // 
            // editCarButton
            // 
            this.editCarButton.Location = new System.Drawing.Point(295, 2);
            this.editCarButton.Margin = new System.Windows.Forms.Padding(2);
            this.editCarButton.Name = "editCarButton";
            this.editCarButton.Size = new System.Drawing.Size(70, 23);
            this.editCarButton.TabIndex = 3;
            this.editCarButton.Text = "Редакция";
            this.editCarButton.UseVisualStyleBackColor = true;
            this.editCarButton.Click += new System.EventHandler(this.editCarButton_Click);
            // 
            // CarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 387);
            this.Controls.Add(this.editCarButton);
            this.Controls.Add(this.carsDataGridView);
            this.Controls.Add(this.CarRmv);
            this.Controls.Add(this.CarAddButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CarList";
            this.Text = "Автомобили";
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

