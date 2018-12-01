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
            this.carListGrid = new System.Windows.Forms.DataGridView();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.carListGrid)).BeginInit();
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
            // 
            // carListGrid
            // 
            this.carListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.model,
            this.brand});
            this.carListGrid.Enabled = false;
            this.carListGrid.Location = new System.Drawing.Point(12, 234);
            this.carListGrid.Name = "carListGrid";
            this.carListGrid.Size = new System.Drawing.Size(510, 150);
            this.carListGrid.TabIndex = 3;
            // 
            // model
            // 
            this.model.HeaderText = "Модел";
            this.model.Name = "model";
            // 
            // brand
            // 
            this.brand.HeaderText = "Марка";
            this.brand.Name = "brand";
            // 
            // CarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 387);
            this.Controls.Add(this.carListGrid);
            this.Controls.Add(this.CarRmv);
            this.Controls.Add(this.CarAddButton);
            this.Name = "CarList";
            this.Text = "Auto";
            ((System.ComponentModel.ISupportInitialize)(this.carListGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CarAddButton;
        private System.Windows.Forms.Button CarRmv;
        private System.Windows.Forms.DataGridView carListGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
    }
}

