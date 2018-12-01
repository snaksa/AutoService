namespace AutoService.Forms.EmloyeeForms
{
    partial class EmployeeList
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.employeesGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(707, 14);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 28);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Изтрий";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(599, 14);
            this.editButton.Margin = new System.Windows.Forms.Padding(4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 28);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Редактирай";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(491, 15);
            this.newButton.Margin = new System.Windows.Forms.Padding(4);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(100, 28);
            this.newButton.TabIndex = 3;
            this.newButton.Text = "Нов";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // employeesGrid
            // 
            this.employeesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.employeesGrid.Location = new System.Drawing.Point(12, 174);
            this.employeesGrid.Name = "employeesGrid";
            this.employeesGrid.RowTemplate.Height = 24;
            this.employeesGrid.Size = new System.Drawing.Size(795, 150);
            this.employeesGrid.TabIndex = 4;
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 336);
            this.Controls.Add(this.employeesGrid);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeList";
            this.Text = "Служители";
            ((System.ComponentModel.ISupportInitialize)(this.employeesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.DataGridView employeesGrid;
    }
}