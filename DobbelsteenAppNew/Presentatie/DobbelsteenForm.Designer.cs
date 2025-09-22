namespace Presentatie
{
    partial class DobbelsteenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DobbelsteenForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUitkomst = new System.Windows.Forms.TextBox();
            this.btnWerp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtUitkomst
            // 
            this.txtUitkomst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUitkomst.Location = new System.Drawing.Point(123, 91);
            this.txtUitkomst.Name = "txtUitkomst";
            this.txtUitkomst.ReadOnly = true;
            this.txtUitkomst.Size = new System.Drawing.Size(100, 29);
            this.txtUitkomst.TabIndex = 1;
            this.txtUitkomst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnWerp
            // 
            this.btnWerp.Location = new System.Drawing.Point(148, 322);
            this.btnWerp.Name = "btnWerp";
            this.btnWerp.Size = new System.Drawing.Size(75, 23);
            this.btnWerp.TabIndex = 2;
            this.btnWerp.Text = "Werp";
            this.btnWerp.UseVisualStyleBackColor = true;
            this.btnWerp.Click += new System.EventHandler(this.btnWerp_Click);
            // 
            // DobbelsteenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 390);
            this.Controls.Add(this.btnWerp);
            this.Controls.Add(this.txtUitkomst);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DobbelsteenForm";
            this.Text = "Dobbelsteen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUitkomst;
        private System.Windows.Forms.Button btnWerp;
    }
}

