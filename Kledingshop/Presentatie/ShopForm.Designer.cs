namespace Presentatie
{
    partial class ShopForm
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
            this.lbKleding = new System.Windows.Forms.ListBox();
            this.rbNaam = new System.Windows.Forms.RadioButton();
            this.rbPrijs = new System.Windows.Forms.RadioButton();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnBroek = new System.Windows.Forms.Button();
            this.btnTrui = new System.Windows.Forms.Button();
            this.btnTshirt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbKleding
            // 
            this.lbKleding.FormattingEnabled = true;
            this.lbKleding.Location = new System.Drawing.Point(52, 73);
            this.lbKleding.Name = "lbKleding";
            this.lbKleding.Size = new System.Drawing.Size(182, 108);
            this.lbKleding.TabIndex = 0;
            // 
            // rbNaam
            // 
            this.rbNaam.AutoSize = true;
            this.rbNaam.Location = new System.Drawing.Point(240, 73);
            this.rbNaam.Name = "rbNaam";
            this.rbNaam.Size = new System.Drawing.Size(70, 17);
            this.rbNaam.TabIndex = 1;
            this.rbNaam.TabStop = true;
            this.rbNaam.Text = "Op Naam";
            this.rbNaam.UseVisualStyleBackColor = true;
            this.rbNaam.CheckedChanged += new System.EventHandler(this.rbNaam_CheckedChanged);
            // 
            // rbPrijs
            // 
            this.rbPrijs.AutoSize = true;
            this.rbPrijs.Location = new System.Drawing.Point(240, 96);
            this.rbPrijs.Name = "rbPrijs";
            this.rbPrijs.Size = new System.Drawing.Size(61, 17);
            this.rbPrijs.TabIndex = 2;
            this.rbPrijs.TabStop = true;
            this.rbPrijs.Text = "Op Prijs";
            this.rbPrijs.UseVisualStyleBackColor = true;
            this.rbPrijs.CheckedChanged += new System.EventHandler(this.rbPrijs_CheckedChanged);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(52, 202);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(182, 23);
            this.btnDetails.TabIndex = 4;
            this.btnDetails.Text = "Toon details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnBroek
            // 
            this.btnBroek.Location = new System.Drawing.Point(240, 119);
            this.btnBroek.Name = "btnBroek";
            this.btnBroek.Size = new System.Drawing.Size(75, 23);
            this.btnBroek.TabIndex = 5;
            this.btnBroek.Text = "Broek";
            this.btnBroek.UseVisualStyleBackColor = true;
            this.btnBroek.Click += new System.EventHandler(this.btnBroek_Click);
            // 
            // btnTrui
            // 
            this.btnTrui.Location = new System.Drawing.Point(240, 177);
            this.btnTrui.Name = "btnTrui";
            this.btnTrui.Size = new System.Drawing.Size(75, 23);
            this.btnTrui.TabIndex = 6;
            this.btnTrui.Text = "Trui";
            this.btnTrui.UseVisualStyleBackColor = true;
            this.btnTrui.Click += new System.EventHandler(this.btnTrui_Click);
            // 
            // btnTshirt
            // 
            this.btnTshirt.Location = new System.Drawing.Point(240, 148);
            this.btnTshirt.Name = "btnTshirt";
            this.btnTshirt.Size = new System.Drawing.Size(75, 23);
            this.btnTshirt.TabIndex = 7;
            this.btnTshirt.Text = "t-shirt";
            this.btnTshirt.UseVisualStyleBackColor = true;
            this.btnTshirt.Click += new System.EventHandler(this.btnTshirt_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTshirt);
            this.Controls.Add(this.btnTrui);
            this.Controls.Add(this.btnBroek);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.rbPrijs);
            this.Controls.Add(this.rbNaam);
            this.Controls.Add(this.lbKleding);
            this.Name = "ShopForm";
            this.Text = "Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbKleding;
        private System.Windows.Forms.RadioButton rbNaam;
        private System.Windows.Forms.RadioButton rbPrijs;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnBroek;
        private System.Windows.Forms.Button btnTrui;
        private System.Windows.Forms.Button btnTshirt;
    }
}

