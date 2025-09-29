namespace Presentatie
{
    partial class Showroom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Showroom));
            this.cbAirco = new System.Windows.Forms.CheckBox();
            this.cbRadio = new System.Windows.Forms.CheckBox();
            this.txtPrijs = new System.Windows.Forms.TextBox();
            this.pbFotoAuto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAirco
            // 
            this.cbAirco.AutoSize = true;
            this.cbAirco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAirco.Location = new System.Drawing.Point(25, 52);
            this.cbAirco.Name = "cbAirco";
            this.cbAirco.Size = new System.Drawing.Size(57, 20);
            this.cbAirco.TabIndex = 0;
            this.cbAirco.Text = "Airco";
            this.cbAirco.UseVisualStyleBackColor = true;
            this.cbAirco.CheckedChanged += new System.EventHandler(this.cbAirco_CheckedChanged);
            // 
            // cbRadio
            // 
            this.cbRadio.AutoSize = true;
            this.cbRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRadio.Location = new System.Drawing.Point(25, 75);
            this.cbRadio.Name = "cbRadio";
            this.cbRadio.Size = new System.Drawing.Size(84, 20);
            this.cbRadio.TabIndex = 1;
            this.cbRadio.Text = "Autoradio";
            this.cbRadio.UseVisualStyleBackColor = true;
            this.cbRadio.CheckedChanged += new System.EventHandler(this.cbRadio_CheckedChanged);
            // 
            // txtPrijs
            // 
            this.txtPrijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrijs.Location = new System.Drawing.Point(25, 110);
            this.txtPrijs.Name = "txtPrijs";
            this.txtPrijs.ReadOnly = true;
            this.txtPrijs.Size = new System.Drawing.Size(100, 29);
            this.txtPrijs.TabIndex = 2;
            // 
            // pbFotoAuto
            // 
            this.pbFotoAuto.Image = ((System.Drawing.Image)(resources.GetObject("pbFotoAuto.Image")));
            this.pbFotoAuto.Location = new System.Drawing.Point(147, 52);
            this.pbFotoAuto.Name = "pbFotoAuto";
            this.pbFotoAuto.Size = new System.Drawing.Size(156, 87);
            this.pbFotoAuto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoAuto.TabIndex = 3;
            this.pbFotoAuto.TabStop = false;
            // 
            // Showroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 174);
            this.Controls.Add(this.pbFotoAuto);
            this.Controls.Add(this.txtPrijs);
            this.Controls.Add(this.cbRadio);
            this.Controls.Add(this.cbAirco);
            this.Name = "Showroom";
            this.Text = "Showroom";
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbAirco;
        private System.Windows.Forms.CheckBox cbRadio;
        private System.Windows.Forms.TextBox txtPrijs;
        private System.Windows.Forms.PictureBox pbFotoAuto;
    }
}

