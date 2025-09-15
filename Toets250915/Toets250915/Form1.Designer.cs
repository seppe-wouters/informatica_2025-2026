namespace Toets250915
{
    partial class Form1
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
            this.txtAantalLiter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrijsPerLiter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHuidigeKmStand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVorigeKmStand = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotPrijs = new System.Windows.Forms.Label();
            this.lblVerbruikPer100km = new System.Windows.Forms.Label();
            this.btnBereken = new System.Windows.Forms.Button();
            this.btnWissen = new System.Windows.Forms.Button();
            this.picTanken = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTanken)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAantalLiter
            // 
            this.txtAantalLiter.Location = new System.Drawing.Point(161, 29);
            this.txtAantalLiter.Name = "txtAantalLiter";
            this.txtAantalLiter.Size = new System.Drawing.Size(100, 20);
            this.txtAantalLiter.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aantal liter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prijs per liter";
            // 
            // txtPrijsPerLiter
            // 
            this.txtPrijsPerLiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtPrijsPerLiter.Location = new System.Drawing.Point(161, 62);
            this.txtPrijsPerLiter.Name = "txtPrijsPerLiter";
            this.txtPrijsPerLiter.ReadOnly = true;
            this.txtPrijsPerLiter.Size = new System.Drawing.Size(100, 20);
            this.txtPrijsPerLiter.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Huidige kilometerstand";
            // 
            // txtHuidigeKmStand
            // 
            this.txtHuidigeKmStand.Location = new System.Drawing.Point(161, 99);
            this.txtHuidigeKmStand.Name = "txtHuidigeKmStand";
            this.txtHuidigeKmStand.Size = new System.Drawing.Size(100, 20);
            this.txtHuidigeKmStand.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vorige Kilometerstand";
            // 
            // txtVorigeKmStand
            // 
            this.txtVorigeKmStand.Location = new System.Drawing.Point(161, 134);
            this.txtVorigeKmStand.Name = "txtVorigeKmStand";
            this.txtVorigeKmStand.Size = new System.Drawing.Size(100, 20);
            this.txtVorigeKmStand.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Totale prijs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Verbruik / 100km";
            // 
            // lblTotPrijs
            // 
            this.lblTotPrijs.AutoSize = true;
            this.lblTotPrijs.Location = new System.Drawing.Point(503, 32);
            this.lblTotPrijs.Name = "lblTotPrijs";
            this.lblTotPrijs.Size = new System.Drawing.Size(0, 13);
            this.lblTotPrijs.TabIndex = 10;
            // 
            // lblVerbruikPer100km
            // 
            this.lblVerbruikPer100km.AutoSize = true;
            this.lblVerbruikPer100km.Location = new System.Drawing.Point(503, 69);
            this.lblVerbruikPer100km.Name = "lblVerbruikPer100km";
            this.lblVerbruikPer100km.Size = new System.Drawing.Size(0, 13);
            this.lblVerbruikPer100km.TabIndex = 11;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(37, 198);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(75, 23);
            this.btnBereken.TabIndex = 12;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // btnWissen
            // 
            this.btnWissen.Location = new System.Drawing.Point(133, 198);
            this.btnWissen.Name = "btnWissen";
            this.btnWissen.Size = new System.Drawing.Size(75, 23);
            this.btnWissen.TabIndex = 13;
            this.btnWissen.Text = "Wissen";
            this.btnWissen.UseVisualStyleBackColor = true;
            this.btnWissen.Click += new System.EventHandler(this.btnWissen_Click);
            // 
            // picTanken
            // 
            this.picTanken.ImageLocation = "../../Photos/Tanken.jpg";
            this.picTanken.Location = new System.Drawing.Point(361, 104);
            this.picTanken.Name = "picTanken";
            this.picTanken.Size = new System.Drawing.Size(169, 105);
            this.picTanken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTanken.TabIndex = 14;
            this.picTanken.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 267);
            this.Controls.Add(this.picTanken);
            this.Controls.Add(this.btnWissen);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.lblVerbruikPer100km);
            this.Controls.Add(this.lblTotPrijs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVorigeKmStand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHuidigeKmStand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrijsPerLiter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAantalLiter);
            this.Name = "Form1";
            this.Text = "Tankbeurt 2025";
            ((System.ComponentModel.ISupportInitialize)(this.picTanken)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAantalLiter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrijsPerLiter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHuidigeKmStand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVorigeKmStand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotPrijs;
        private System.Windows.Forms.Label lblVerbruikPer100km;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Button btnWissen;
        private System.Windows.Forms.PictureBox picTanken;
    }
}

