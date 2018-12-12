namespace AutoService.Forms.StatisticsForms
{
    partial class StatsList
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
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.typeDropdown = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.showButton = new System.Windows.Forms.Button();
            this.carDropdown = new System.Windows.Forms.ComboBox();
            this.thirdShowButton = new System.Windows.Forms.Button();
            this.showCardButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridView.Location = new System.Drawing.Point(12, 58);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.RowTemplate.Height = 24;
            this.resultsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultsDataGridView.Size = new System.Drawing.Size(1015, 276);
            this.resultsDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Справка по:";
            // 
            // typeDropdown
            // 
            this.typeDropdown.FormattingEnabled = true;
            this.typeDropdown.Items.AddRange(new object[] {
            "начална дата",
            "крайна дата",
            "автомобил",
            "неприключени карти"});
            this.typeDropdown.Location = new System.Drawing.Point(103, 10);
            this.typeDropdown.Name = "typeDropdown";
            this.typeDropdown.Size = new System.Drawing.Size(121, 24);
            this.typeDropdown.TabIndex = 2;
            this.typeDropdown.SelectedIndexChanged += new System.EventHandler(this.typeDropdown_SelectedIndexChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(239, 11);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 3;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(456, 11);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 4;
            this.showButton.Text = "Покажи";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // carDropdown
            // 
            this.carDropdown.FormattingEnabled = true;
            this.carDropdown.Location = new System.Drawing.Point(239, 10);
            this.carDropdown.Name = "carDropdown";
            this.carDropdown.Size = new System.Drawing.Size(200, 24);
            this.carDropdown.TabIndex = 5;
            // 
            // thirdShowButton
            // 
            this.thirdShowButton.Location = new System.Drawing.Point(239, 9);
            this.thirdShowButton.Name = "thirdShowButton";
            this.thirdShowButton.Size = new System.Drawing.Size(78, 23);
            this.thirdShowButton.TabIndex = 6;
            this.thirdShowButton.Text = "Покажи";
            this.thirdShowButton.UseVisualStyleBackColor = true;
            this.thirdShowButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // showCardButton
            // 
            this.showCardButton.Location = new System.Drawing.Point(952, 13);
            this.showCardButton.Name = "showCardButton";
            this.showCardButton.Size = new System.Drawing.Size(75, 23);
            this.showCardButton.TabIndex = 7;
            this.showCardButton.Text = "Преглед";
            this.showCardButton.UseVisualStyleBackColor = true;
            this.showCardButton.Click += new System.EventHandler(this.showCardButton_Click);
            // 
            // StatsList
            // 
            this.ClientSize = new System.Drawing.Size(1039, 345);
            this.Controls.Add(this.showCardButton);
            this.Controls.Add(this.thirdShowButton);
            this.Controls.Add(this.carDropdown);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.typeDropdown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultsDataGridView);
            this.Name = "StatsList";
            this.Text = "Справки";
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.DataGridView resultsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeDropdown;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.ComboBox carDropdown;
        private System.Windows.Forms.Button thirdShowButton;
        private System.Windows.Forms.Button showCardButton;
    }
}