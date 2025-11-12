namespace Presentatie
{
    partial class VoegToeForm
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
            txtNaam = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtLand = new TextBox();
            label3 = new Label();
            cbGenre = new ComboBox();
            numPopulariteit = new NumericUpDown();
            label4 = new Label();
            BtnVoegToe = new Button();
            ((System.ComponentModel.ISupportInitialize)numPopulariteit).BeginInit();
            SuspendLayout();
            // 
            // txtNaam
            // 
            txtNaam.Location = new Point(12, 42);
            txtNaam.Name = "txtNaam";
            txtNaam.Size = new Size(167, 23);
            txtNaam.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Naam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 115);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 3;
            label2.Text = "Land";
            // 
            // txtLand
            // 
            txtLand.Location = new Point(12, 133);
            txtLand.Name = "txtLand";
            txtLand.Size = new Size(167, 23);
            txtLand.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 68);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "Genre";
            // 
            // cbGenre
            // 
            cbGenre.FormattingEnabled = true;
            cbGenre.Location = new Point(13, 89);
            cbGenre.Name = "cbGenre";
            cbGenre.Size = new Size(166, 23);
            cbGenre.TabIndex = 1;
            // 
            // numPopulariteit
            // 
            numPopulariteit.Location = new Point(13, 182);
            numPopulariteit.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPopulariteit.Name = "numPopulariteit";
            numPopulariteit.Size = new Size(166, 23);
            numPopulariteit.TabIndex = 3;
            numPopulariteit.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 164);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 7;
            label4.Text = "Populariteit";
            // 
            // BtnVoegToe
            // 
            BtnVoegToe.BackColor = Color.FromArgb(128, 255, 128);
            BtnVoegToe.Location = new Point(13, 221);
            BtnVoegToe.Name = "BtnVoegToe";
            BtnVoegToe.Size = new Size(166, 41);
            BtnVoegToe.TabIndex = 8;
            BtnVoegToe.Text = "Voeg Toe";
            BtnVoegToe.UseVisualStyleBackColor = false;
            BtnVoegToe.Click += BtnVoegToe_Click;
            // 
            // VoegToeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(190, 286);
            Controls.Add(BtnVoegToe);
            Controls.Add(label4);
            Controls.Add(numPopulariteit);
            Controls.Add(cbGenre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtLand);
            Controls.Add(label1);
            Controls.Add(txtNaam);
            Name = "VoegToeForm";
            Text = "VoegToeForm";
            ((System.ComponentModel.ISupportInitialize)numPopulariteit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNaam;
        private Label label1;
        private Label label2;
        private TextBox txtLand;
        private Label label3;
        private ComboBox cbGenre;
        private NumericUpDown numPopulariteit;
        private Label label4;
        private Button BtnVoegToe;
    }
}