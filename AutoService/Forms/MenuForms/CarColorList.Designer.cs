namespace AutoService.Forms.MenuForms
{
    partial class CarColorList
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
            this.carcolorGridView.Location = new System.Drawing.Point(16, 146);
            this.carcolorGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carcolorGridView.Name = "carcolorGridView";
            this.carcolorGridView.Size = new System.Drawing.Size(320, 185);
            this.carcolorGridView.TabIndex = 13;
            // 
            // CarColorDelete
            // 
            this.CarColorDelete.Location = new System.Drawing.Point(16, 85);
            this.CarColorDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CarColorDelete.Name = "CarColorDelete";
            this.CarColorDelete.Size = new System.Drawing.Size(179, 28);
            this.CarColorDelete.TabIndex = 12;
            this.CarColorDelete.Text = "Изтриване на цвят";
            this.CarColorDelete.UseVisualStyleBackColor = true;
            this.CarColorDelete.Click += new System.EventHandler(this.CarColorDelete_Click);
            // 
            // CarColorEdit
            // 
            this.CarColorEdit.Location = new System.Drawing.Point(16, 49);
            this.CarColorEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CarColorEdit.Name = "CarColorEdit";
            this.CarColorEdit.Size = new System.Drawing.Size(179, 28);
            this.CarColorEdit.TabIndex = 11;
            this.CarColorEdit.Text = "Редактиране на цвят";
            this.CarColorEdit.UseVisualStyleBackColor = true;
            this.CarColorEdit.Click += new System.EventHandler(this.CarColorEdit_Click);
            // 
            // CarColorAdd
            // 
            this.CarColorAdd.Location = new System.Drawing.Point(16, 14);
            this.CarColorAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CarColorAdd.Name = "CarColorAdd";
            this.CarColorAdd.Size = new System.Drawing.Size(179, 28);
            this.CarColorAdd.TabIndex = 10;
            this.CarColorAdd.Text = "Добавяне на цвят";
            this.CarColorAdd.UseVisualStyleBackColor = true;
            this.CarColorAdd.Click += new System.EventHandler(this.CarColorAdd_Click);
            // 
            // CarColorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 357);
            this.Controls.Add(this.carcolorGridView);
            this.Controls.Add(this.CarColorDelete);
            this.Controls.Add(this.CarColorEdit);
            this.Controls.Add(this.CarColorAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CarColorList";
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