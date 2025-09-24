namespace CocktailApp
{
    partial class IngredientenForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNaamCocktail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWater = new System.Windows.Forms.Label();
            this.lblAlcohol = new System.Windows.Forms.Label();
            this.lblPercentFrisdrank = new System.Windows.Forms.Label();
            this.lblNaamFrisdrank = new System.Windows.Forms.Label();
            this.cbIsAlcholisch = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam cocktail: ";
            // 
            // lblNaamCocktail
            // 
            this.lblNaamCocktail.AutoSize = true;
            this.lblNaamCocktail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaamCocktail.Location = new System.Drawing.Point(134, 23);
            this.lblNaamCocktail.Name = "lblNaamCocktail";
            this.lblNaamCocktail.Size = new System.Drawing.Size(0, 20);
            this.lblNaamCocktail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Percentage Water";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Percentage Alcohol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Percentage Frisdrank";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Alcoholisch";
            // 
            // lblWater
            // 
            this.lblWater.AutoSize = true;
            this.lblWater.Location = new System.Drawing.Point(135, 80);
            this.lblWater.Name = "lblWater";
            this.lblWater.Size = new System.Drawing.Size(0, 13);
            this.lblWater.TabIndex = 6;
            // 
            // lblAlcohol
            // 
            this.lblAlcohol.AutoSize = true;
            this.lblAlcohol.Location = new System.Drawing.Point(135, 104);
            this.lblAlcohol.Name = "lblAlcohol";
            this.lblAlcohol.Size = new System.Drawing.Size(0, 13);
            this.lblAlcohol.TabIndex = 7;
            // 
            // lblPercentFrisdrank
            // 
            this.lblPercentFrisdrank.AutoSize = true;
            this.lblPercentFrisdrank.Location = new System.Drawing.Point(135, 133);
            this.lblPercentFrisdrank.Name = "lblPercentFrisdrank";
            this.lblPercentFrisdrank.Size = new System.Drawing.Size(0, 13);
            this.lblPercentFrisdrank.TabIndex = 8;
            // 
            // lblNaamFrisdrank
            // 
            this.lblNaamFrisdrank.AutoSize = true;
            this.lblNaamFrisdrank.Location = new System.Drawing.Point(231, 133);
            this.lblNaamFrisdrank.Name = "lblNaamFrisdrank";
            this.lblNaamFrisdrank.Size = new System.Drawing.Size(0, 13);
            this.lblNaamFrisdrank.TabIndex = 9;
            // 
            // cbIsAlcholisch
            // 
            this.cbIsAlcholisch.AutoCheck = false;
            this.cbIsAlcholisch.AutoSize = true;
            this.cbIsAlcholisch.Location = new System.Drawing.Point(92, 202);
            this.cbIsAlcholisch.Name = "cbIsAlcholisch";
            this.cbIsAlcholisch.Size = new System.Drawing.Size(15, 14);
            this.cbIsAlcholisch.TabIndex = 10;
            this.cbIsAlcholisch.UseVisualStyleBackColor = true;
            // 
            // IngredientenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 406);
            this.Controls.Add(this.cbIsAlcholisch);
            this.Controls.Add(this.lblNaamFrisdrank);
            this.Controls.Add(this.lblPercentFrisdrank);
            this.Controls.Add(this.lblAlcohol);
            this.Controls.Add(this.lblWater);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNaamCocktail);
            this.Controls.Add(this.label1);
            this.Name = "IngredientenForm";
            this.Text = "Cocktail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNaamCocktail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWater;
        private System.Windows.Forms.Label lblAlcohol;
        private System.Windows.Forms.Label lblPercentFrisdrank;
        private System.Windows.Forms.Label lblNaamFrisdrank;
        private System.Windows.Forms.CheckBox cbIsAlcholisch;
    }
}

