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
            this.txtTijd = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tAfteklok = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtTijd
            // 
            this.txtTijd.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtTijd.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTijd.ForeColor = System.Drawing.Color.Lime;
            this.txtTijd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTijd.Location = new System.Drawing.Point(12, 41);
            this.txtTijd.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.txtTijd.Name = "txtTijd";
            this.txtTijd.Size = new System.Drawing.Size(163, 58);
            this.txtTijd.TabIndex = 0;
            this.txtTijd.Text = "";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(163, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start op";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tAfteklok
            // 
            this.tAfteklok.Enabled = true;
            this.tAfteklok.Interval = 1000;
            this.tAfteklok.Tick += new System.EventHandler(this.tAfteklok_Tick);
            // 
            // AftelklokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 112);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtTijd);
            this.Name = "AftelklokForm";
            this.Text = "Aftelklok";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox txtTijd;
        private System.Windows.Forms.Timer tAfteklok;
    }
}

