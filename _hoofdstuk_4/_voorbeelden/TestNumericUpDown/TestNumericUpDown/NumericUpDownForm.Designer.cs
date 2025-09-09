namespace TestNumericUpDown
{
    partial class NumericUpDownForm
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
            this.vakTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vakNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.overzettenButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vakNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // vakTextBox
            // 
            this.vakTextBox.Location = new System.Drawing.Point(19, 158);
            this.vakTextBox.Name = "vakTextBox";
            this.vakTextBox.Size = new System.Drawing.Size(123, 20);
            this.vakTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "een tekstvak:";
            // 
            // vakNumericUpDown
            // 
            this.vakNumericUpDown.Location = new System.Drawing.Point(22, 43);
            this.vakNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.vakNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.vakNumericUpDown.Name = "vakNumericUpDown";
            this.vakNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.vakNumericUpDown.TabIndex = 2;
            this.vakNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "een NumericUpDown:";
            // 
            // overzettenButton
            // 
            this.overzettenButton.Location = new System.Drawing.Point(22, 90);
            this.overzettenButton.Name = "overzettenButton";
            this.overzettenButton.Size = new System.Drawing.Size(120, 23);
            this.overzettenButton.TabIndex = 4;
            this.overzettenButton.Text = "overzetten";
            this.overzettenButton.UseVisualStyleBackColor = true;
            // 
            // NumericUpDownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 231);
            this.Controls.Add(this.overzettenButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vakNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vakTextBox);
            this.Name = "NumericUpDownForm";
            this.Text = "NumericUpDownForm";
            ((System.ComponentModel.ISupportInitialize)(this.vakNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vakTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown vakNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button overzettenButton;
    }
}

