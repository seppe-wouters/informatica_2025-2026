namespace Presentatie
{
    partial class StartForm
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
            this.btnKlassiek = new System.Windows.Forms.Button();
            this.btn12Zijdig = new System.Windows.Forms.Button();
            this.numAantalzijde = new System.Windows.Forms.NumericUpDown();
            this.btnXZijde = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAantalzijde)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKlassiek
            // 
            this.btnKlassiek.Location = new System.Drawing.Point(30, 12);
            this.btnKlassiek.Name = "btnKlassiek";
            this.btnKlassiek.Size = new System.Drawing.Size(132, 42);
            this.btnKlassiek.TabIndex = 0;
            this.btnKlassiek.Text = "Klassieke Dobbelsteen";
            this.btnKlassiek.UseVisualStyleBackColor = true;
            this.btnKlassiek.Click += new System.EventHandler(this.btnKlassiek_Click);
            // 
            // btn12Zijdig
            // 
            this.btn12Zijdig.Location = new System.Drawing.Point(30, 60);
            this.btn12Zijdig.Name = "btn12Zijdig";
            this.btn12Zijdig.Size = new System.Drawing.Size(132, 42);
            this.btn12Zijdig.TabIndex = 1;
            this.btn12Zijdig.Text = "12-Zijdige dobbelsteen";
            this.btn12Zijdig.UseVisualStyleBackColor = true;
            this.btn12Zijdig.Click += new System.EventHandler(this.btn12Zijdig_Click);
            // 
            // numAantalzijde
            // 
            this.numAantalzijde.Location = new System.Drawing.Point(30, 128);
            this.numAantalzijde.Name = "numAantalzijde";
            this.numAantalzijde.Size = new System.Drawing.Size(132, 20);
            this.numAantalzijde.TabIndex = 2;
            // 
            // btnXZijde
            // 
            this.btnXZijde.Location = new System.Drawing.Point(30, 154);
            this.btnXZijde.Name = "btnXZijde";
            this.btnXZijde.Size = new System.Drawing.Size(132, 23);
            this.btnXZijde.TabIndex = 3;
            this.btnXZijde.Text = "X aantal zijde";
            this.btnXZijde.UseVisualStyleBackColor = true;
            this.btnXZijde.Click += new System.EventHandler(this.btnXZijde_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 196);
            this.Controls.Add(this.btnXZijde);
            this.Controls.Add(this.numAantalzijde);
            this.Controls.Add(this.btn12Zijdig);
            this.Controls.Add(this.btnKlassiek);
            this.Name = "StartForm";
            this.Text = "StartForm";
            ((System.ComponentModel.ISupportInitialize)(this.numAantalzijde)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKlassiek;
        private System.Windows.Forms.Button btn12Zijdig;
        private System.Windows.Forms.NumericUpDown numAantalzijde;
        private System.Windows.Forms.Button btnXZijde;
    }
}