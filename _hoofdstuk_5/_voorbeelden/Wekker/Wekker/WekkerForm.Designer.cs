﻿namespace Wekker
{
    partial class WekkerForm
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
            this.uurOmhoogButton = new System.Windows.Forms.Button();
            this.uurOmlaagButton = new System.Windows.Forms.Button();
            this.alarmOmTextBox = new System.Windows.Forms.TextBox();
            this.minuutOmhoogButton = new System.Windows.Forms.Button();
            this.minuutOmlaagButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uurOmhoogButton
            // 
            this.uurOmhoogButton.Location = new System.Drawing.Point(15, 12);
            this.uurOmhoogButton.Name = "uurOmhoogButton";
            this.uurOmhoogButton.Size = new System.Drawing.Size(25, 23);
            this.uurOmhoogButton.TabIndex = 0;
            this.uurOmhoogButton.Text = "+";
            this.uurOmhoogButton.UseVisualStyleBackColor = true;
            this.uurOmhoogButton.Click += new System.EventHandler(this.uurOmhoogButton_Click);
            // 
            // uurOmlaagButton
            // 
            this.uurOmlaagButton.Location = new System.Drawing.Point(15, 36);
            this.uurOmlaagButton.Name = "uurOmlaagButton";
            this.uurOmlaagButton.Size = new System.Drawing.Size(25, 23);
            this.uurOmlaagButton.TabIndex = 1;
            this.uurOmlaagButton.Text = "-";
            this.uurOmlaagButton.UseVisualStyleBackColor = true;
            this.uurOmlaagButton.Click += new System.EventHandler(this.uurOmlaagButton_Click);
            // 
            // alarmOmTextBox
            // 
            this.alarmOmTextBox.BackColor = System.Drawing.Color.Black;
            this.alarmOmTextBox.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmOmTextBox.ForeColor = System.Drawing.Color.Lime;
            this.alarmOmTextBox.Location = new System.Drawing.Point(46, 12);
            this.alarmOmTextBox.Name = "alarmOmTextBox";
            this.alarmOmTextBox.Size = new System.Drawing.Size(112, 48);
            this.alarmOmTextBox.TabIndex = 2;
            this.alarmOmTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minuutOmhoogButton
            // 
            this.minuutOmhoogButton.Location = new System.Drawing.Point(164, 12);
            this.minuutOmhoogButton.Name = "minuutOmhoogButton";
            this.minuutOmhoogButton.Size = new System.Drawing.Size(25, 23);
            this.minuutOmhoogButton.TabIndex = 3;
            this.minuutOmhoogButton.Text = "+";
            this.minuutOmhoogButton.UseVisualStyleBackColor = true;
            this.minuutOmhoogButton.Click += new System.EventHandler(this.minuutOmhoogButton_Click);
            // 
            // minuutOmlaagButton
            // 
            this.minuutOmlaagButton.Location = new System.Drawing.Point(164, 36);
            this.minuutOmlaagButton.Name = "minuutOmlaagButton";
            this.minuutOmlaagButton.Size = new System.Drawing.Size(25, 23);
            this.minuutOmlaagButton.TabIndex = 4;
            this.minuutOmlaagButton.Text = "-";
            this.minuutOmlaagButton.UseVisualStyleBackColor = true;
            this.minuutOmlaagButton.Click += new System.EventHandler(this.minuutOmlaagButton_Click);
            // 
            // WekkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 77);
            this.Controls.Add(this.minuutOmlaagButton);
            this.Controls.Add(this.minuutOmhoogButton);
            this.Controls.Add(this.alarmOmTextBox);
            this.Controls.Add(this.uurOmlaagButton);
            this.Controls.Add(this.uurOmhoogButton);
            this.Name = "WekkerForm";
            this.Text = "WekkerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uurOmhoogButton;
        private System.Windows.Forms.Button uurOmlaagButton;
        private System.Windows.Forms.TextBox alarmOmTextBox;
        private System.Windows.Forms.Button minuutOmhoogButton;
        private System.Windows.Forms.Button minuutOmlaagButton;
    }
}

