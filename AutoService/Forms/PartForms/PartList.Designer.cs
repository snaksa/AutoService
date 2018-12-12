namespace AutoService
{
    partial class PartList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartList));
            this.partEditButton = new System.Windows.Forms.Button();
            this.partsDataGridView = new System.Windows.Forms.DataGridView();
            this.PartRmv = new System.Windows.Forms.Button();
            this.PartAddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // partEditButton
            // 
            this.partEditButton.Location = new System.Drawing.Point(513, 15);
            this.partEditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partEditButton.Name = "partEditButton";
            this.partEditButton.Size = new System.Drawing.Size(93, 28);
            this.partEditButton.TabIndex = 7;
            this.partEditButton.Text = "Редакция";
            this.partEditButton.UseVisualStyleBackColor = true;
            this.partEditButton.Click += new System.EventHandler(this.partEditButton_Click);
            // 
            // partsDataGridView
            // 
            this.partsDataGridView.AllowUserToAddRows = false;
            this.partsDataGridView.AllowUserToDeleteRows = false;
            this.partsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.partsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.partsDataGridView.Location = new System.Drawing.Point(15, 54);
            this.partsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partsDataGridView.MultiSelect = false;
            this.partsDataGridView.Name = "partsDataGridView";
            this.partsDataGridView.ReadOnly = true;
            this.partsDataGridView.RowTemplate.Height = 24;
            this.partsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsDataGridView.Size = new System.Drawing.Size(592, 358);
            this.partsDataGridView.TabIndex = 6;
            // 
            // PartRmv
            // 
            this.PartRmv.Location = new System.Drawing.Point(296, 15);
            this.PartRmv.Margin = new System.Windows.Forms.Padding(4);
            this.PartRmv.Name = "PartRmv";
            this.PartRmv.Size = new System.Drawing.Size(191, 28);
            this.PartRmv.TabIndex = 5;
            this.PartRmv.Text = "Изтриване на част";
            this.PartRmv.UseVisualStyleBackColor = true;
            this.PartRmv.Click += new System.EventHandler(this.PartRmv_Click);
            // 
            // PartAddButton
            // 
            this.PartAddButton.Location = new System.Drawing.Point(15, 15);
            this.PartAddButton.Margin = new System.Windows.Forms.Padding(4);
            this.PartAddButton.Name = "PartAddButton";
            this.PartAddButton.Size = new System.Drawing.Size(273, 28);
            this.PartAddButton.TabIndex = 4;
            this.PartAddButton.Text = "Добавяне на резервна част";
            this.PartAddButton.UseVisualStyleBackColor = true;
            this.PartAddButton.Click += new System.EventHandler(this.PartAddButton_Click);
            // 
            // PartList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(627, 425);
            this.Controls.Add(this.partEditButton);
            this.Controls.Add(this.partsDataGridView);
            this.Controls.Add(this.PartRmv);
            this.Controls.Add(this.PartAddButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PartList";
            this.Text = "Parts";
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button partEditButton;
        private System.Windows.Forms.DataGridView partsDataGridView;
        private System.Windows.Forms.Button PartRmv;
        private System.Windows.Forms.Button PartAddButton;
    }
}