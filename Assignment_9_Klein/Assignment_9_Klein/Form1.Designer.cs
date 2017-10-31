namespace Assignment_9_Klein
{
    partial class Form1
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
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.option1Bttn = new System.Windows.Forms.Button();
            this.option2Bttn = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.correctLabel = new System.Windows.Forms.Label();
            this.wrongLabel = new System.Windows.Forms.Label();
            this.result1Label = new System.Windows.Forms.Label();
            this.result2Label = new System.Windows.Forms.Label();
            this.correctCountLabel = new System.Windows.Forms.Label();
            this.wrongCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(7, 10);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(397, 36);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Which one will contain the higher number? \r\nMake your choice, view your score, th" +
    "en click Next.";
            this.instructionsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // option1Bttn
            // 
            this.option1Bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Bttn.Location = new System.Drawing.Point(67, 79);
            this.option1Bttn.Name = "option1Bttn";
            this.option1Bttn.Size = new System.Drawing.Size(100, 45);
            this.option1Bttn.TabIndex = 1;
            this.option1Bttn.Text = "1";
            this.option1Bttn.UseVisualStyleBackColor = true;
            this.option1Bttn.Click += new System.EventHandler(this.option1Bttn_Click);
            // 
            // option2Bttn
            // 
            this.option2Bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Bttn.Location = new System.Drawing.Point(240, 79);
            this.option2Bttn.Name = "option2Bttn";
            this.option2Bttn.Size = new System.Drawing.Size(100, 45);
            this.option2Bttn.TabIndex = 2;
            this.option2Bttn.Text = "2";
            this.option2Bttn.UseVisualStyleBackColor = true;
            this.option2Bttn.Click += new System.EventHandler(this.option2Bttn_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(328, 229);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(74, 33);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctLabel.Location = new System.Drawing.Point(64, 186);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(73, 20);
            this.correctLabel.TabIndex = 4;
            this.correctLabel.Text = "Correct:";
            // 
            // wrongLabel
            // 
            this.wrongLabel.AutoSize = true;
            this.wrongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongLabel.Location = new System.Drawing.Point(64, 235);
            this.wrongLabel.Name = "wrongLabel";
            this.wrongLabel.Size = new System.Drawing.Size(66, 20);
            this.wrongLabel.TabIndex = 5;
            this.wrongLabel.Text = "Wrong:";
            // 
            // result1Label
            // 
            this.result1Label.AutoSize = true;
            this.result1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result1Label.Location = new System.Drawing.Point(105, 127);
            this.result1Label.Name = "result1Label";
            this.result1Label.Size = new System.Drawing.Size(21, 24);
            this.result1Label.TabIndex = 6;
            this.result1Label.Text = "?";
            // 
            // result2Label
            // 
            this.result2Label.AutoSize = true;
            this.result2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result2Label.Location = new System.Drawing.Point(277, 127);
            this.result2Label.Name = "result2Label";
            this.result2Label.Size = new System.Drawing.Size(21, 24);
            this.result2Label.TabIndex = 7;
            this.result2Label.Text = "?";
            // 
            // correctCountLabel
            // 
            this.correctCountLabel.AutoSize = true;
            this.correctCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctCountLabel.Location = new System.Drawing.Point(143, 186);
            this.correctCountLabel.Name = "correctCountLabel";
            this.correctCountLabel.Size = new System.Drawing.Size(19, 20);
            this.correctCountLabel.TabIndex = 8;
            this.correctCountLabel.Text = "0";
            // 
            // wrongCountLabel
            // 
            this.wrongCountLabel.AutoSize = true;
            this.wrongCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongCountLabel.Location = new System.Drawing.Point(143, 235);
            this.wrongCountLabel.Name = "wrongCountLabel";
            this.wrongCountLabel.Size = new System.Drawing.Size(19, 20);
            this.wrongCountLabel.TabIndex = 9;
            this.wrongCountLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 274);
            this.Controls.Add(this.wrongCountLabel);
            this.Controls.Add(this.correctCountLabel);
            this.Controls.Add(this.result2Label);
            this.Controls.Add(this.result1Label);
            this.Controls.Add(this.wrongLabel);
            this.Controls.Add(this.correctLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.option2Bttn);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.option1Bttn);
            this.Name = "Form1";
            this.Text = "Assignment 9 - Klein";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button option1Bttn;
        private System.Windows.Forms.Button option2Bttn;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Label wrongLabel;
        private System.Windows.Forms.Label result1Label;
        private System.Windows.Forms.Label result2Label;
        private System.Windows.Forms.Label correctCountLabel;
        private System.Windows.Forms.Label wrongCountLabel;
    }
}

