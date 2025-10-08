namespace Presentatie
{
    partial class KioskForm
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
            lbBestelling = new ListBox();
            lbMenu = new ListBox();
            btnVoegToe = new Button();
            btnVerwijder = new Button();
            btnTotaal = new Button();
            lblTotprijs = new Label();
            SuspendLayout();
            // 
            // lbBestelling
            // 
            lbBestelling.BackColor = SystemColors.ScrollBar;
            lbBestelling.FormattingEnabled = true;
            lbBestelling.ItemHeight = 15;
            lbBestelling.Location = new Point(32, 47);
            lbBestelling.Name = "lbBestelling";
            lbBestelling.Size = new Size(156, 94);
            lbBestelling.TabIndex = 0;
            // 
            // lbMenu
            // 
            lbMenu.BackColor = SystemColors.ScrollBar;
            lbMenu.FormattingEnabled = true;
            lbMenu.ItemHeight = 15;
            lbMenu.Location = new Point(214, 47);
            lbMenu.Name = "lbMenu";
            lbMenu.Size = new Size(153, 94);
            lbMenu.TabIndex = 1;
            // 
            // btnVoegToe
            // 
            btnVoegToe.Location = new Point(32, 205);
            btnVoegToe.Name = "btnVoegToe";
            btnVoegToe.Size = new Size(75, 23);
            btnVoegToe.TabIndex = 2;
            btnVoegToe.Text = "Voeg toe";
            btnVoegToe.UseVisualStyleBackColor = true;
            btnVoegToe.Click += btnVoegToe_Click;
            // 
            // btnVerwijder
            // 
            btnVerwijder.Location = new Point(113, 205);
            btnVerwijder.Name = "btnVerwijder";
            btnVerwijder.Size = new Size(75, 23);
            btnVerwijder.TabIndex = 3;
            btnVerwijder.Text = "Verwijder";
            btnVerwijder.UseVisualStyleBackColor = true;
            btnVerwijder.Click += btnVerwijder_Click;
            // 
            // btnTotaal
            // 
            btnTotaal.Location = new Point(194, 205);
            btnTotaal.Name = "btnTotaal";
            btnTotaal.Size = new Size(100, 23);
            btnTotaal.TabIndex = 4;
            btnTotaal.Text = "Toon totaalprijs";
            btnTotaal.UseVisualStyleBackColor = true;
            btnTotaal.Click += btnTotaal_Click;
            // 
            // lblTotprijs
            // 
            lblTotprijs.AutoSize = true;
            lblTotprijs.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotprijs.Location = new Point(32, 169);
            lblTotprijs.Name = "lblTotprijs";
            lblTotprijs.Size = new Size(0, 25);
            lblTotprijs.TabIndex = 5;
            // 
            // KioskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(405, 275);
            Controls.Add(lblTotprijs);
            Controls.Add(btnTotaal);
            Controls.Add(btnVerwijder);
            Controls.Add(btnVoegToe);
            Controls.Add(lbMenu);
            Controls.Add(lbBestelling);
            Name = "KioskForm";
            Text = "Kiosk";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbBestelling;
        private ListBox lbMenu;
        private Button btnVoegToe;
        private Button btnVerwijder;
        private Button btnTotaal;
        private Label lblTotprijs;
    }
}
