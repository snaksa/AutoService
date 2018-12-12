namespace AutoService.Forms.MenuForms
{
    partial class ModelList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelList));
            this.modelGridView = new System.Windows.Forms.DataGridView();
            this.ModelDelete = new System.Windows.Forms.Button();
            this.ModelEdit = new System.Windows.Forms.Button();
            this.ModelAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.modelGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // modelGridView
            // 
            this.modelGridView.AllowUserToAddRows = false;
            this.modelGridView.AllowUserToDeleteRows = false;
            this.modelGridView.BackgroundColor = System.Drawing.Color.White;
            this.modelGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modelGridView.Location = new System.Drawing.Point(16, 127);
            this.modelGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modelGridView.MultiSelect = false;
            this.modelGridView.Name = "modelGridView";
            this.modelGridView.ReadOnly = true;
            this.modelGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modelGridView.Size = new System.Drawing.Size(457, 218);
            this.modelGridView.TabIndex = 9;
            // 
            // ModelDelete
            // 
            this.ModelDelete.Location = new System.Drawing.Point(16, 91);
            this.ModelDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModelDelete.Name = "ModelDelete";
            this.ModelDelete.Size = new System.Drawing.Size(179, 28);
            this.ModelDelete.TabIndex = 8;
            this.ModelDelete.Text = "Изтриване на модел";
            this.ModelDelete.UseVisualStyleBackColor = true;
            this.ModelDelete.Click += new System.EventHandler(this.ModelDelete_Click);
            // 
            // ModelEdit
            // 
            this.ModelEdit.Location = new System.Drawing.Point(16, 55);
            this.ModelEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModelEdit.Name = "ModelEdit";
            this.ModelEdit.Size = new System.Drawing.Size(179, 28);
            this.ModelEdit.TabIndex = 7;
            this.ModelEdit.Text = "Редактиране на модел";
            this.ModelEdit.UseVisualStyleBackColor = true;
            this.ModelEdit.Click += new System.EventHandler(this.ModelEdit_Click);
            // 
            // ModelAdd
            // 
            this.ModelAdd.Location = new System.Drawing.Point(16, 20);
            this.ModelAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModelAdd.Name = "ModelAdd";
            this.ModelAdd.Size = new System.Drawing.Size(179, 28);
            this.ModelAdd.TabIndex = 6;
            this.ModelAdd.Text = "Добавяне на модел";
            this.ModelAdd.UseVisualStyleBackColor = true;
            this.ModelAdd.Click += new System.EventHandler(this.ModelAdd_Click);
            // 
            // ModelList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(488, 359);
            this.Controls.Add(this.modelGridView);
            this.Controls.Add(this.ModelDelete);
            this.Controls.Add(this.ModelEdit);
            this.Controls.Add(this.ModelAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModelList";
            this.Text = "Модел";
            ((System.ComponentModel.ISupportInitialize)(this.modelGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView modelGridView;
        private System.Windows.Forms.Button ModelDelete;
        private System.Windows.Forms.Button ModelEdit;
        private System.Windows.Forms.Button ModelAdd;
    }
}