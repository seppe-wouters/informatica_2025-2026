namespace Presentatie
{
    partial class SpookhuisForm
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
            this.lbWachtrij = new System.Windows.Forms.ListBox();
            this.dtTijdslot = new System.Windows.Forms.DateTimePicker();
            this.NumAantalPersonen = new System.Windows.Forms.NumericUpDown();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVoegtoe = new ReaLTaiizor.Controls.MaterialButton();
            this.btnEerste = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVoorang = new ReaLTaiizor.Controls.MaterialButton();
            this.materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            this.txtAantalVerwerkt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumAantalPersonen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWachtrij
            // 
            this.lbWachtrij.FormattingEnabled = true;
            this.lbWachtrij.Location = new System.Drawing.Point(24, 71);
            this.lbWachtrij.Name = "lbWachtrij";
            this.lbWachtrij.Size = new System.Drawing.Size(170, 134);
            this.lbWachtrij.TabIndex = 0;
            // 
            // dtTijdslot
            // 
            this.dtTijdslot.Location = new System.Drawing.Point(229, 133);
            this.dtTijdslot.Name = "dtTijdslot";
            this.dtTijdslot.Size = new System.Drawing.Size(200, 20);
            this.dtTijdslot.TabIndex = 1;
            // 
            // NumAantalPersonen
            // 
            this.NumAantalPersonen.Location = new System.Drawing.Point(317, 107);
            this.NumAantalPersonen.Name = "NumAantalPersonen";
            this.NumAantalPersonen.Size = new System.Drawing.Size(112, 20);
            this.NumAantalPersonen.TabIndex = 2;
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(317, 81);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(112, 20);
            this.txtNaam.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aantal Personen";
            // 
            // btnVoegtoe
            // 
            this.btnVoegtoe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVoegtoe.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVoegtoe.Depth = 0;
            this.btnVoegtoe.HighEmphasis = true;
            this.btnVoegtoe.Icon = null;
            this.btnVoegtoe.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVoegtoe.Location = new System.Drawing.Point(276, 162);
            this.btnVoegtoe.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVoegtoe.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVoegtoe.Name = "btnVoegtoe";
            this.btnVoegtoe.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVoegtoe.Size = new System.Drawing.Size(91, 36);
            this.btnVoegtoe.TabIndex = 6;
            this.btnVoegtoe.Text = "Voeg toe";
            this.btnVoegtoe.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVoegtoe.UseAccentColor = false;
            this.btnVoegtoe.UseVisualStyleBackColor = true;
            this.btnVoegtoe.Click += new System.EventHandler(this.btnVoegtoe_Click);
            // 
            // btnEerste
            // 
            this.btnEerste.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEerste.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEerste.Depth = 0;
            this.btnEerste.HighEmphasis = true;
            this.btnEerste.Icon = null;
            this.btnEerste.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnEerste.Location = new System.Drawing.Point(24, 214);
            this.btnEerste.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEerste.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnEerste.Name = "btnEerste";
            this.btnEerste.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEerste.Size = new System.Drawing.Size(144, 36);
            this.btnEerste.TabIndex = 7;
            this.btnEerste.Text = "Verwerk Eerste";
            this.btnEerste.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEerste.UseAccentColor = false;
            this.btnEerste.UseVisualStyleBackColor = true;
            this.btnEerste.Click += new System.EventHandler(this.btnEerste_Click);
            // 
            // btnVoorang
            // 
            this.btnVoorang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVoorang.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVoorang.Depth = 0;
            this.btnVoorang.HighEmphasis = true;
            this.btnVoorang.Icon = null;
            this.btnVoorang.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVoorang.Location = new System.Drawing.Point(24, 262);
            this.btnVoorang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVoorang.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVoorang.Name = "btnVoorang";
            this.btnVoorang.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVoorang.Size = new System.Drawing.Size(195, 36);
            this.btnVoorang.TabIndex = 8;
            this.btnVoorang.Text = "Verwerk Met Voorang";
            this.btnVoorang.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVoorang.UseAccentColor = false;
            this.btnVoorang.UseVisualStyleBackColor = true;
            this.btnVoorang.Click += new System.EventHandler(this.btnVoorang_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(21, 327);
            this.materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(186, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Aantal Personen Verwerkt:";
            // 
            // txtAantalVerwerkt
            // 
            this.txtAantalVerwerkt.Location = new System.Drawing.Point(211, 326);
            this.txtAantalVerwerkt.Name = "txtAantalVerwerkt";
            this.txtAantalVerwerkt.ReadOnly = true;
            this.txtAantalVerwerkt.Size = new System.Drawing.Size(100, 20);
            this.txtAantalVerwerkt.TabIndex = 10;
            // 
            // SpookhuisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 381);
            this.Controls.Add(this.txtAantalVerwerkt);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnVoorang);
            this.Controls.Add(this.btnEerste);
            this.Controls.Add(this.btnVoegtoe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.NumAantalPersonen);
            this.Controls.Add(this.dtTijdslot);
            this.Controls.Add(this.lbWachtrij);
            this.FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            this.Name = "SpookhuisForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "SpookHuis";
            ((System.ComponentModel.ISupportInitialize)(this.NumAantalPersonen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbWachtrij;
        private System.Windows.Forms.DateTimePicker dtTijdslot;
        private System.Windows.Forms.NumericUpDown NumAantalPersonen;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ReaLTaiizor.Controls.MaterialButton btnVoegtoe;
        private ReaLTaiizor.Controls.MaterialButton btnEerste;
        private ReaLTaiizor.Controls.MaterialButton btnVoorang;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox txtAantalVerwerkt;
    }
}

