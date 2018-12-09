namespace AutoService.Forms.MenuForms
{
    partial class MenuCarColor
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
            this.carcolorGridView = new System.Windows.Forms.DataGridView();
            this.CarColorDelete = new System.Windows.Forms.Button();
            this.CarColorEdit = new System.Windows.Forms.Button();
            this.CarColorAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carcolorGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // carcolorGridView
            // 
            this.carcolorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carcolorGridView.Enabled = false;
            this.carcolorGridView.Location = new System.Drawing.Point(12, 119);
            this.carcolorGridView.Name = "carcolorGridView";
            this.carcolorGridView.Size = new System.Drawing.Size(240, 150);
            this.carcolorGridView.TabIndex = 13;
            // 
            // CarColorDelete
            // 
            this.CarColorDelete.Location = new System.Drawing.Point(12, 69);
            this.CarColorDelete.Name = "CarColorDelete";
            this.CarColorDelete.Size = new System.Drawing.Size(134, 23);
            this.CarColorDelete.TabIndex = 12;
            this.CarColorDelete.Text = "Изтриване на цвят";
            this.CarColorDelete.UseVisualStyleBackColor = true;
            this.CarColorDelete.Click += new System.EventHandler(this.CarColorDelete_Click);
            // 
            // CarColorEdit
            // 
            this.CarColorEdit.Location = new System.Drawing.Point(12, 40);
            this.CarColorEdit.Name = "CarColorEdit";
            this.CarColorEdit.Size = new System.Drawing.Size(134, 23);
            this.CarColorEdit.TabIndex = 11;
            this.CarColorEdit.Text = "Редактиране на цвят";
            this.CarColorEdit.UseVisualStyleBackColor = true;
            this.CarColorEdit.Click += new System.EventHandler(this.CarColorEdit_Click);
            // 
            // CarColorAdd
            // 
            this.CarColorAdd.Location = new System.Drawing.Point(12, 11);
            this.CarColorAdd.Name = "CarColorAdd";
            this.CarColorAdd.Size = new System.Drawing.Size(134, 23);
            this.CarColorAdd.TabIndex = 10;
            this.CarColorAdd.Text = "Добавяне на цвят";
            this.CarColorAdd.UseVisualStyleBackColor = true;
            this.CarColorAdd.Click += new System.EventHandler(this.CarColorAdd_Click);
            // 
            // MenuCarColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 290);
            this.Controls.Add(this.carcolorGridView);
            this.Controls.Add(this.CarColorDelete);
            this.Controls.Add(this.CarColorEdit);
            this.Controls.Add(this.CarColorAdd);
            this.Name = "MenuCarColor";
            this.Text = "MenuCarColor";
            ((System.ComponentModel.ISupportInitialize)(this.carcolorGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView carcolorGridView;
        private System.Windows.Forms.Button CarColorDelete;
        private System.Windows.Forms.Button CarColorEdit;
        private System.Windows.Forms.Button CarColorAdd;
    }
}