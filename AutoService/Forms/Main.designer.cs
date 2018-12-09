namespace AutoService.Forms
{
    partial class Main
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
            this.autoButton = new System.Windows.Forms.Button();
            this.partsButton = new System.Windows.Forms.Button();
            this.cartsButton = new System.Windows.Forms.Button();
            this.employeesButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.brandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // autoButton
            // 
            this.autoButton.Location = new System.Drawing.Point(38, 30);
            this.autoButton.Name = "autoButton";
            this.autoButton.Size = new System.Drawing.Size(75, 23);
            this.autoButton.TabIndex = 0;
            this.autoButton.Text = "Автомобили";
            this.autoButton.UseVisualStyleBackColor = true;
            this.autoButton.Click += new System.EventHandler(this.autoButton_Click);
            // 
            // partsButton
            // 
            this.partsButton.Location = new System.Drawing.Point(38, 69);
            this.partsButton.Name = "partsButton";
            this.partsButton.Size = new System.Drawing.Size(75, 23);
            this.partsButton.TabIndex = 1;
            this.partsButton.Text = "Части";
            this.partsButton.UseVisualStyleBackColor = true;
            this.partsButton.Click += new System.EventHandler(this.partsButton_Click);
            // 
            // cartsButton
            // 
            this.cartsButton.Location = new System.Drawing.Point(38, 110);
            this.cartsButton.Name = "cartsButton";
            this.cartsButton.Size = new System.Drawing.Size(75, 23);
            this.cartsButton.TabIndex = 2;
            this.cartsButton.Text = "Карти";
            this.cartsButton.UseVisualStyleBackColor = true;
            // 
            // employeesButton
            // 
            this.employeesButton.Location = new System.Drawing.Point(38, 151);
            this.employeesButton.Name = "employeesButton";
            this.employeesButton.Size = new System.Drawing.Size(75, 23);
            this.employeesButton.TabIndex = 3;
            this.employeesButton.Text = "Служители";
            this.employeesButton.UseVisualStyleBackColor = true;
            this.employeesButton.Click += new System.EventHandler(this.employeesButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brandToolStripMenuItem,
            this.modelToolStripMenuItem,
            this.carColorToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem1.Text = "Modify";
            // 
            // brandToolStripMenuItem
            // 
            this.brandToolStripMenuItem.Name = "brandToolStripMenuItem";
            this.brandToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.brandToolStripMenuItem.Text = "Brand";
            this.brandToolStripMenuItem.Click += new System.EventHandler(this.brandToolStripMenuItem_Click);
            // 
            // modelToolStripMenuItem
            // 
            this.modelToolStripMenuItem.Name = "modelToolStripMenuItem";
            this.modelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modelToolStripMenuItem.Text = "Model";
            this.modelToolStripMenuItem.Click += new System.EventHandler(this.modelToolStripMenuItem_Click);
            // 
            // carColorToolStripMenuItem
            // 
            this.carColorToolStripMenuItem.Name = "carColorToolStripMenuItem";
            this.carColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.carColorToolStripMenuItem.Text = "Car Color";
            this.carColorToolStripMenuItem.Click += new System.EventHandler(this.carColorToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 385);
            this.Controls.Add(this.employeesButton);
            this.Controls.Add(this.cartsButton);
            this.Controls.Add(this.partsButton);
            this.Controls.Add(this.autoButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button autoButton;
        private System.Windows.Forms.Button partsButton;
        private System.Windows.Forms.Button cartsButton;
        private System.Windows.Forms.Button employeesButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem brandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carColorToolStripMenuItem;
    }
}