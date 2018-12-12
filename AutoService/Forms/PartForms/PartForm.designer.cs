﻿namespace AutoService.Forms.PartForms
{
    partial class PartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.nomerErrorLabel = new System.Windows.Forms.Label();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.priceErrorLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.numberPictureBox = new System.Windows.Forms.PictureBox();
            this.namePictureBox = new System.Windows.Forms.PictureBox();
            this.pricePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numberPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Име:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(60, 108);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Запази";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(60, 10);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(60, 37);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(60, 66);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 6;
            // 
            // nomerErrorLabel
            // 
            this.nomerErrorLabel.AutoSize = true;
            this.nomerErrorLabel.Location = new System.Drawing.Point(179, 14);
            this.nomerErrorLabel.Name = "nomerErrorLabel";
            this.nomerErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.nomerErrorLabel.TabIndex = 7;
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.Location = new System.Drawing.Point(179, 41);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.nameErrorLabel.TabIndex = 8;
            // 
            // priceErrorLabel
            // 
            this.priceErrorLabel.AutoSize = true;
            this.priceErrorLabel.Location = new System.Drawing.Point(176, 70);
            this.priceErrorLabel.Name = "priceErrorLabel";
            this.priceErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.priceErrorLabel.TabIndex = 9;
            // 
            // numberPictureBox
            // 
            this.numberPictureBox.Image = global::AutoService.Properties.Resources.repair;
            this.numberPictureBox.Location = new System.Drawing.Point(166, 12);
            this.numberPictureBox.Name = "numberPictureBox";
            this.numberPictureBox.Size = new System.Drawing.Size(19, 18);
            this.numberPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.numberPictureBox.TabIndex = 10;
            this.numberPictureBox.TabStop = false;
            this.numberPictureBox.MouseHover += new System.EventHandler(this.numberPictureBox_MouseHover);
            // 
            // namePictureBox
            // 
            this.namePictureBox.Image = global::AutoService.Properties.Resources.repair;
            this.namePictureBox.Location = new System.Drawing.Point(166, 39);
            this.namePictureBox.Name = "namePictureBox";
            this.namePictureBox.Size = new System.Drawing.Size(19, 18);
            this.namePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.namePictureBox.TabIndex = 11;
            this.namePictureBox.TabStop = false;
            this.namePictureBox.MouseHover += new System.EventHandler(this.namePictureBox_MouseHover);
            // 
            // pricePictureBox
            // 
            this.pricePictureBox.Image = global::AutoService.Properties.Resources.repair;
            this.pricePictureBox.Location = new System.Drawing.Point(166, 66);
            this.pricePictureBox.Name = "pricePictureBox";
            this.pricePictureBox.Size = new System.Drawing.Size(19, 18);
            this.pricePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pricePictureBox.TabIndex = 12;
            this.pricePictureBox.TabStop = false;
            this.pricePictureBox.MouseHover += new System.EventHandler(this.pricePictureBox_MouseHover);
            // 
            // PartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(197, 143);
            this.Controls.Add(this.pricePictureBox);
            this.Controls.Add(this.namePictureBox);
            this.Controls.Add(this.numberPictureBox);
            this.Controls.Add(this.priceErrorLabel);
            this.Controls.Add(this.nameErrorLabel);
            this.Controls.Add(this.nomerErrorLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PartForm";
            this.Text = "Части";
            ((System.ComponentModel.ISupportInitialize)(this.numberPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label nomerErrorLabel;
        private System.Windows.Forms.Label nameErrorLabel;
        private System.Windows.Forms.Label priceErrorLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox numberPictureBox;
        private System.Windows.Forms.PictureBox namePictureBox;
        private System.Windows.Forms.PictureBox pricePictureBox;
    }
}