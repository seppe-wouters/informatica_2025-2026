namespace Presentatie
{
    partial class Dobbelsteen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dobbelsteen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnWerpen = new System.Windows.Forms.Button();
            this.txtAantalZijde = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "../../photos/DobbelsteenBlanco.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(25, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnWerpen
            // 
            this.btnWerpen.Location = new System.Drawing.Point(62, 223);
            this.btnWerpen.Name = "btnWerpen";
            this.btnWerpen.Size = new System.Drawing.Size(94, 67);
            this.btnWerpen.TabIndex = 1;
            this.btnWerpen.Text = "Werpen";
            this.btnWerpen.UseVisualStyleBackColor = true;
            // 
            // txtAantalZijde
            // 
            this.txtAantalZijde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAantalZijde.Location = new System.Drawing.Point(62, 71);
            this.txtAantalZijde.Name = "txtAantalZijde";
            this.txtAantalZijde.Size = new System.Drawing.Size(100, 26);
            this.txtAantalZijde.TabIndex = 2;
            this.txtAantalZijde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Dobbelsteen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 323);
            this.Controls.Add(this.txtAantalZijde);
            this.Controls.Add(this.btnWerpen);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Dobbelsteen";
            this.Text = "Dobbelsteen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnWerpen;
        private System.Windows.Forms.TextBox txtAantalZijde;
    }
}

