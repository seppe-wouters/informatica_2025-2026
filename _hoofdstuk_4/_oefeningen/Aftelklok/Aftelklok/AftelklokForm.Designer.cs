namespace Aftelklok
{
    partial class AftelklokForm
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
            this.components = new System.ComponentModel.Container();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.opnieuwOpStarttijd = new System.Windows.Forms.Button();
            this.aftelklokTimer = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayTextBox
            // 
            this.displayTextBox.BackColor = System.Drawing.Color.Black;
            this.displayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTextBox.ForeColor = System.Drawing.Color.Lime;
            this.displayTextBox.Location = new System.Drawing.Point(27, 41);
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.Size = new System.Drawing.Size(128, 49);
            this.displayTextBox.TabIndex = 0;
            this.displayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // opnieuwOpStarttijd
            // 
            this.opnieuwOpStarttijd.Location = new System.Drawing.Point(27, 12);
            this.opnieuwOpStarttijd.Name = "opnieuwOpStarttijd";
            this.opnieuwOpStarttijd.Size = new System.Drawing.Size(128, 23);
            this.opnieuwOpStarttijd.TabIndex = 1;
            this.opnieuwOpStarttijd.Text = "Op starttijd";
            this.opnieuwOpStarttijd.UseVisualStyleBackColor = true;
            this.opnieuwOpStarttijd.Click += new System.EventHandler(this.opnieuwOpStarttijd_Click);
            // 
            // aftelklokTimer
            // 
            this.aftelklokTimer.Interval = 1000;
            this.aftelklokTimer.Tick += new System.EventHandler(this.aftelklokTimer_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 96);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(93, 96);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // AftelklokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 129);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.opnieuwOpStarttijd);
            this.Controls.Add(this.displayTextBox);
            this.Name = "AftelklokForm";
            this.Text = "Aftelklok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Button opnieuwOpStarttijd;
        private System.Windows.Forms.Timer aftelklokTimer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
    }
}

