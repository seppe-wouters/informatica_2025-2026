namespace Presentatie
{
    partial class AutoForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbGehuurd = new ListBox();
            lbBeschikbaar = new ListBox();
            btnHuur = new Button();
            btnBrengTerug = new Button();
            btnDetails = new Button();
            SuspendLayout();
            // 
            // lbGehuurd
            // 
            lbGehuurd.BackColor = SystemColors.ScrollBar;
            lbGehuurd.FormattingEnabled = true;
            lbGehuurd.ItemHeight = 15;
            lbGehuurd.Location = new Point(12, 12);
            lbGehuurd.Name = "lbGehuurd";
            lbGehuurd.Size = new Size(261, 124);
            lbGehuurd.TabIndex = 0;
            // 
            // lbBeschikbaar
            // 
            lbBeschikbaar.BackColor = SystemColors.ScrollBar;
            lbBeschikbaar.FormattingEnabled = true;
            lbBeschikbaar.ItemHeight = 15;
            lbBeschikbaar.Location = new Point(279, 12);
            lbBeschikbaar.Name = "lbBeschikbaar";
            lbBeschikbaar.Size = new Size(247, 124);
            lbBeschikbaar.TabIndex = 1;
            // 
            // btnHuur
            // 
            btnHuur.Location = new Point(12, 163);
            btnHuur.Name = "btnHuur";
            btnHuur.Size = new Size(75, 23);
            btnHuur.TabIndex = 2;
            btnHuur.Text = "Huur";
            btnHuur.UseVisualStyleBackColor = true;
            btnHuur.Click += btnHuur_Click;
            // 
            // btnBrengTerug
            // 
            btnBrengTerug.Location = new Point(93, 163);
            btnBrengTerug.Name = "btnBrengTerug";
            btnBrengTerug.Size = new Size(79, 23);
            btnBrengTerug.TabIndex = 3;
            btnBrengTerug.Text = "Breng Terug";
            btnBrengTerug.UseVisualStyleBackColor = true;
            btnBrengTerug.Click += btnBrengTerug_Click;
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(178, 163);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(75, 23);
            btnDetails.TabIndex = 4;
            btnDetails.Text = "Details";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // AutoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(537, 213);
            Controls.Add(btnDetails);
            Controls.Add(btnBrengTerug);
            Controls.Add(btnHuur);
            Controls.Add(lbBeschikbaar);
            Controls.Add(lbGehuurd);
            Name = "AutoForm";
            Text = "AutoVerhuur";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbGehuurd;
        private ListBox lbBeschikbaar;
        private Button btnHuur;
        private Button btnBrengTerug;
        private Button btnDetails;
    }
}
