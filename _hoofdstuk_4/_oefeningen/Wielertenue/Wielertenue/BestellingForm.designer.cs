namespace Wielertenue
{
    partial class BestellingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestellingForm));
            this.wielertruiPictureBox = new System.Windows.Forms.PictureBox();
            this.wielertenuePictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numAantal = new System.Windows.Forms.NumericUpDown();
            this.cbWaterdichtZakje = new System.Windows.Forms.CheckBox();
            this.cbSuperzeem = new System.Windows.Forms.CheckBox();
            this.cbBroek = new System.Windows.Forms.CheckBox();
            this.txtPrijs = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.wielertruiPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wielertenuePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAantal)).BeginInit();
            this.SuspendLayout();
            // 
            // wielertruiPictureBox
            // 
            this.wielertruiPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("wielertruiPictureBox.Image")));
            this.wielertruiPictureBox.Location = new System.Drawing.Point(16, 9);
            this.wielertruiPictureBox.Name = "wielertruiPictureBox";
            this.wielertruiPictureBox.Size = new System.Drawing.Size(358, 345);
            this.wielertruiPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wielertruiPictureBox.TabIndex = 0;
            this.wielertruiPictureBox.TabStop = false;
            // 
            // wielertenuePictureBox
            // 
            this.wielertenuePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("wielertenuePictureBox.Image")));
            this.wielertenuePictureBox.Location = new System.Drawing.Point(16, 9);
            this.wielertenuePictureBox.Name = "wielertenuePictureBox";
            this.wielertenuePictureBox.Size = new System.Drawing.Size(358, 345);
            this.wielertenuePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wielertenuePictureBox.TabIndex = 0;
            this.wielertenuePictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aantal";
            // 
            // numAantal
            // 
            this.numAantal.Location = new System.Drawing.Point(462, 38);
            this.numAantal.Name = "numAantal";
            this.numAantal.Size = new System.Drawing.Size(87, 20);
            this.numAantal.TabIndex = 2;
            this.numAantal.ValueChanged += new System.EventHandler(this.numAantal_ValueChanged);
            // 
            // cbWaterdichtZakje
            // 
            this.cbWaterdichtZakje.AutoSize = true;
            this.cbWaterdichtZakje.Location = new System.Drawing.Point(422, 97);
            this.cbWaterdichtZakje.Name = "cbWaterdichtZakje";
            this.cbWaterdichtZakje.Size = new System.Drawing.Size(108, 17);
            this.cbWaterdichtZakje.TabIndex = 3;
            this.cbWaterdichtZakje.Text = "Waterdicht Zakje";
            this.cbWaterdichtZakje.UseVisualStyleBackColor = true;
            this.cbWaterdichtZakje.CheckedChanged += new System.EventHandler(this.cbWaterdichtZakje_CheckedChanged);
            // 
            // cbSuperzeem
            // 
            this.cbSuperzeem.AutoSize = true;
            this.cbSuperzeem.Location = new System.Drawing.Point(422, 199);
            this.cbSuperzeem.Name = "cbSuperzeem";
            this.cbSuperzeem.Size = new System.Drawing.Size(79, 17);
            this.cbSuperzeem.TabIndex = 4;
            this.cbSuperzeem.Text = "Superzeem";
            this.cbSuperzeem.UseVisualStyleBackColor = true;
            this.cbSuperzeem.CheckedChanged += new System.EventHandler(this.cbSuperzeem_CheckedChanged);
            // 
            // cbBroek
            // 
            this.cbBroek.AutoSize = true;
            this.cbBroek.Location = new System.Drawing.Point(422, 176);
            this.cbBroek.Name = "cbBroek";
            this.cbBroek.Size = new System.Drawing.Size(122, 17);
            this.cbBroek.TabIndex = 5;
            this.cbBroek.Text = "Inclusief wielerbroek";
            this.cbBroek.UseVisualStyleBackColor = true;
            this.cbBroek.CheckedChanged += new System.EventHandler(this.cbBroek_CheckedChanged);
            // 
            // txtPrijs
            // 
            this.txtPrijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrijs.Location = new System.Drawing.Point(422, 291);
            this.txtPrijs.Name = "txtPrijs";
            this.txtPrijs.ReadOnly = true;
            this.txtPrijs.Size = new System.Drawing.Size(127, 31);
            this.txtPrijs.TabIndex = 6;
            this.txtPrijs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BestellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(629, 369);
            this.Controls.Add(this.txtPrijs);
            this.Controls.Add(this.cbBroek);
            this.Controls.Add(this.cbSuperzeem);
            this.Controls.Add(this.cbWaterdichtZakje);
            this.Controls.Add(this.numAantal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wielertenuePictureBox);
            this.Controls.Add(this.wielertruiPictureBox);
            this.Name = "BestellingForm";
            this.Text = "BestellingWielertenueForm";
            ((System.ComponentModel.ISupportInitialize)(this.wielertruiPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wielertenuePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAantal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox wielertruiPictureBox;
        private System.Windows.Forms.PictureBox wielertenuePictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numAantal;
        private System.Windows.Forms.CheckBox cbWaterdichtZakje;
        private System.Windows.Forms.CheckBox cbSuperzeem;
        private System.Windows.Forms.CheckBox cbBroek;
        private System.Windows.Forms.TextBox txtPrijs;
    }
}