namespace Presentatie
{
    partial class DetailsForm
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
            label1 = new Label();
            label2 = new Label();
            txtType = new TextBox();
            txtMerk = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "Merk";
            // 
            // txtType
            // 
            txtType.Location = new Point(59, 19);
            txtType.Name = "txtType";
            txtType.ReadOnly = true;
            txtType.Size = new Size(100, 23);
            txtType.TabIndex = 2;
            // 
            // txtMerk
            // 
            txtMerk.Location = new Point(59, 49);
            txtMerk.Name = "txtMerk";
            txtMerk.ReadOnly = true;
            txtMerk.Size = new Size(100, 23);
            txtMerk.TabIndex = 3;
            // 
            // DetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(186, 83);
            Controls.Add(txtMerk);
            Controls.Add(txtType);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DetailsForm";
            Text = "DetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtType;
        private TextBox txtMerk;
    }
}