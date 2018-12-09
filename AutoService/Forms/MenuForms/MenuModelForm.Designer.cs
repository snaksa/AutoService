namespace AutoService.Forms.MenuForms
{
    partial class MenuModelForm
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
            this.modelGridView = new System.Windows.Forms.DataGridView();
            this.ModelDelete = new System.Windows.Forms.Button();
            this.ModelEdit = new System.Windows.Forms.Button();
            this.ModelAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.modelGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // modelGridView
            // 
            this.modelGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modelGridView.Enabled = false;
            this.modelGridView.Location = new System.Drawing.Point(12, 124);
            this.modelGridView.Name = "modelGridView";
            this.modelGridView.Size = new System.Drawing.Size(240, 150);
            this.modelGridView.TabIndex = 9;
            // 
            // ModelDelete
            // 
            this.ModelDelete.Location = new System.Drawing.Point(12, 74);
            this.ModelDelete.Name = "ModelDelete";
            this.ModelDelete.Size = new System.Drawing.Size(134, 23);
            this.ModelDelete.TabIndex = 8;
            this.ModelDelete.Text = "Изтриване на модел";
            this.ModelDelete.UseVisualStyleBackColor = true;
            this.ModelDelete.Click += new System.EventHandler(this.ModelDelete_Click);
            // 
            // ModelEdit
            // 
            this.ModelEdit.Location = new System.Drawing.Point(12, 45);
            this.ModelEdit.Name = "ModelEdit";
            this.ModelEdit.Size = new System.Drawing.Size(134, 23);
            this.ModelEdit.TabIndex = 7;
            this.ModelEdit.Text = "Редактиране на модел";
            this.ModelEdit.UseVisualStyleBackColor = true;
            this.ModelEdit.Click += new System.EventHandler(this.ModelEdit_Click);
            // 
            // ModelAdd
            // 
            this.ModelAdd.Location = new System.Drawing.Point(12, 16);
            this.ModelAdd.Name = "ModelAdd";
            this.ModelAdd.Size = new System.Drawing.Size(134, 23);
            this.ModelAdd.TabIndex = 6;
            this.ModelAdd.Text = "Добавяне на модел";
            this.ModelAdd.UseVisualStyleBackColor = true;
            this.ModelAdd.Click += new System.EventHandler(this.ModelAdd_Click);
            // 
            // MenuModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 292);
            this.Controls.Add(this.modelGridView);
            this.Controls.Add(this.ModelDelete);
            this.Controls.Add(this.ModelEdit);
            this.Controls.Add(this.ModelAdd);
            this.Name = "MenuModelForm";
            this.Text = "MenuModelForm";
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