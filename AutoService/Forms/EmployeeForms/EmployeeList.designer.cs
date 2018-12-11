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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeList));
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.employeesGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.Location = new System.Drawing.Point(171, 9);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Изтрий";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.Location = new System.Drawing.Point(90, 9);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Редактирай";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.Transparent;
            this.newButton.Location = new System.Drawing.Point(9, 9);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 3;
            this.newButton.Text = "Нов";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // employeesGrid
            // 
            this.employeesGrid.AllowUserToAddRows = false;
            this.employeesGrid.AllowUserToDeleteRows = false;
            this.employeesGrid.BackgroundColor = System.Drawing.Color.Silver;
            this.employeesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.employeesGrid.Location = new System.Drawing.Point(9, 37);
            this.employeesGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.employeesGrid.MultiSelect = false;
            this.employeesGrid.Name = "employeesGrid";
            this.employeesGrid.ReadOnly = true;
            this.employeesGrid.RowTemplate.Height = 24;
            this.employeesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeesGrid.Size = new System.Drawing.Size(237, 185);
            this.employeesGrid.TabIndex = 4;
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(259, 222);
            this.Controls.Add(this.employeesGrid);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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