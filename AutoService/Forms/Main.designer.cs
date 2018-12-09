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
            this.components = new System.ComponentModel.Container();
            this.autoButton = new System.Windows.Forms.Button();
            this.partsButton = new System.Windows.Forms.Button();
            this.cartsButton = new System.Windows.Forms.Button();
            this.employeesButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brandsToolStripMenuItem,
            this.modelsToolStripMenuItem,
            this.colorsToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // brandsToolStripMenuItem
            // 
            this.brandsToolStripMenuItem.Name = "brandsToolStripMenuItem";
            this.brandsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.brandsToolStripMenuItem.Text = "Brands";
            this.brandsToolStripMenuItem.Click += new System.EventHandler(this.brandsToolStripMenuItem_Click);
            // 
            // modelsToolStripMenuItem
            // 
            this.modelsToolStripMenuItem.Name = "modelsToolStripMenuItem";
            this.modelsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modelsToolStripMenuItem.Text = "Models";
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorsToolStripMenuItem.Text = "Colors";
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
            this.Name = "Main";
            this.Text = "Main";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button autoButton;
        private System.Windows.Forms.Button partsButton;
        private System.Windows.Forms.Button cartsButton;
        private System.Windows.Forms.Button employeesButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
    }
}