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
            this.materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            this.materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            this.materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            this.txtSoort = new System.Windows.Forms.TextBox();
            this.txtGewicht = new System.Windows.Forms.TextBox();
            this.txtPrijsPerKg = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            this.txtTotPrijs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(16, 89);
            this.materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(47, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Soort: ";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(16, 148);
            this.materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(82, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Prijs Per Kg";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(16, 117);
            this.materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(90, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Gewicht (kg)";
            // 
            // txtSoort
            // 
            this.txtSoort.Location = new System.Drawing.Point(140, 89);
            this.txtSoort.Name = "txtSoort";
            this.txtSoort.ReadOnly = true;
            this.txtSoort.Size = new System.Drawing.Size(100, 20);
            this.txtSoort.TabIndex = 3;
            // 
            // txtGewicht
            // 
            this.txtGewicht.Location = new System.Drawing.Point(140, 117);
            this.txtGewicht.Name = "txtGewicht";
            this.txtGewicht.ReadOnly = true;
            this.txtGewicht.Size = new System.Drawing.Size(100, 20);
            this.txtGewicht.TabIndex = 4;
            // 
            // txtPrijsPerKg
            // 
            this.txtPrijsPerKg.Location = new System.Drawing.Point(140, 148);
            this.txtPrijsPerKg.Name = "txtPrijsPerKg";
            this.txtPrijsPerKg.ReadOnly = true;
            this.txtPrijsPerKg.Size = new System.Drawing.Size(100, 20);
            this.txtPrijsPerKg.TabIndex = 5;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(16, 180);
            this.materialLabel4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(81, 19);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Totaal prijs";
            // 
            // txtTotPrijs
            // 
            this.txtTotPrijs.Location = new System.Drawing.Point(140, 180);
            this.txtTotPrijs.Name = "txtTotPrijs";
            this.txtTotPrijs.ReadOnly = true;
            this.txtTotPrijs.Size = new System.Drawing.Size(100, 20);
            this.txtTotPrijs.TabIndex = 7;
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 224);
            this.Controls.Add(this.txtTotPrijs);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtPrijsPerKg);
            this.Controls.Add(this.txtGewicht);
            this.Controls.Add(this.txtSoort);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "DetailsForm";
            this.Text = "Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TextBox txtSoort;
        private System.Windows.Forms.TextBox txtGewicht;
        private System.Windows.Forms.TextBox txtPrijsPerKg;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TextBox txtTotPrijs;
    }
}