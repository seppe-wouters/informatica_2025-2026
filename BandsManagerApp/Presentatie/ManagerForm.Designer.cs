namespace Presentatie
{
    partial class ManagerForm
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
            lbBands = new ListBox();
            btnVoegToe = new Button();
            btnVerwijder = new Button();
            txtFilter = new TextBox();
            btnFilterOpNaam = new Button();
            btnFilterOpGenre = new Button();
            label1 = new Label();
            btnGeenFilter = new Button();
            cbFilterGenre = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // lbBands
            // 
            lbBands.FormattingEnabled = true;
            lbBands.ItemHeight = 15;
            lbBands.Location = new Point(12, 32);
            lbBands.Name = "lbBands";
            lbBands.Size = new Size(285, 364);
            lbBands.TabIndex = 0;
            // 
            // btnVoegToe
            // 
            btnVoegToe.BackColor = Color.FromArgb(128, 255, 128);
            btnVoegToe.Location = new Point(451, 30);
            btnVoegToe.Name = "btnVoegToe";
            btnVoegToe.Size = new Size(142, 53);
            btnVoegToe.TabIndex = 1;
            btnVoegToe.Text = "VoegToe";
            btnVoegToe.UseVisualStyleBackColor = false;
            btnVoegToe.Click += btnVoegToe_Click;
            // 
            // btnVerwijder
            // 
            btnVerwijder.BackColor = Color.FromArgb(255, 128, 128);
            btnVerwijder.Location = new Point(303, 32);
            btnVerwijder.Name = "btnVerwijder";
            btnVerwijder.Size = new Size(142, 51);
            btnVerwijder.TabIndex = 2;
            btnVerwijder.Text = "Verwijder";
            btnVerwijder.UseVisualStyleBackColor = false;
            btnVerwijder.Click += btnVerwijder_Click;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(303, 147);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(142, 23);
            txtFilter.TabIndex = 3;
            // 
            // btnFilterOpNaam
            // 
            btnFilterOpNaam.Location = new Point(303, 176);
            btnFilterOpNaam.Name = "btnFilterOpNaam";
            btnFilterOpNaam.Size = new Size(142, 46);
            btnFilterOpNaam.TabIndex = 4;
            btnFilterOpNaam.Text = "Filter Op Naam";
            btnFilterOpNaam.UseVisualStyleBackColor = true;
            btnFilterOpNaam.Click += btnFilterOpNaam_Click;
            // 
            // btnFilterOpGenre
            // 
            btnFilterOpGenre.Location = new Point(451, 176);
            btnFilterOpGenre.Name = "btnFilterOpGenre";
            btnFilterOpGenre.Size = new Size(142, 46);
            btnFilterOpGenre.TabIndex = 5;
            btnFilterOpGenre.Text = "Filter Op Genre";
            btnFilterOpGenre.UseVisualStyleBackColor = true;
            btnFilterOpGenre.Click += btnFilterOpGenre_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 129);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 6;
            label1.Text = "Filter Op Naam";
            // 
            // btnGeenFilter
            // 
            btnGeenFilter.Location = new Point(365, 228);
            btnGeenFilter.Name = "btnGeenFilter";
            btnGeenFilter.Size = new Size(142, 46);
            btnGeenFilter.TabIndex = 7;
            btnGeenFilter.Text = "Geen Filter";
            btnGeenFilter.UseVisualStyleBackColor = true;
            btnGeenFilter.Click += btnGeenFilter_Click;
            // 
            // cbFilterGenre
            // 
            cbFilterGenre.FormattingEnabled = true;
            cbFilterGenre.Location = new Point(451, 147);
            cbFilterGenre.Name = "cbFilterGenre";
            cbFilterGenre.Size = new Size(142, 23);
            cbFilterGenre.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(451, 129);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 9;
            label2.Text = "Filter Op Genre";
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 433);
            Controls.Add(label2);
            Controls.Add(cbFilterGenre);
            Controls.Add(btnGeenFilter);
            Controls.Add(label1);
            Controls.Add(btnFilterOpGenre);
            Controls.Add(btnFilterOpNaam);
            Controls.Add(txtFilter);
            Controls.Add(btnVerwijder);
            Controls.Add(btnVoegToe);
            Controls.Add(lbBands);
            Name = "ManagerForm";
            Text = "Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbBands;
        private Button btnVoegToe;
        private Button btnVerwijder;
        private TextBox txtFilter;
        private Button btnFilterOpNaam;
        private Button btnFilterOpGenre;
        private Label label1;
        private Button btnGeenFilter;
        private ComboBox cbFilterGenre;
        private Label label2;
    }
}
