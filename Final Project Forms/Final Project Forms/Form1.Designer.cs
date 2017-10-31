using System;
using System.Windows.Forms;

namespace Final_Project_Forms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxOrder = new System.Windows.Forms.ListBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.radioWaffleCone = new System.Windows.Forms.RadioButton();
            this.radioSugarCone = new System.Windows.Forms.RadioButton();
            this.radioWaffleBowl = new System.Windows.Forms.RadioButton();
            this.radioBowl = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxFlavor = new System.Windows.Forms.ListBox();
            this.listBoxScopes = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonIC = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButtonFY = new System.Windows.Forms.RadioButton();
            this.btnCone = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.listBoxOrder);
            this.panel1.Controls.Add(this.btnComplete);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(340, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MaximumSize = new System.Drawing.Size(800, 800);
            this.panel1.MinimumSize = new System.Drawing.Size(271, 522);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 522);
            this.panel1.TabIndex = 0;
            // 
            // listBoxOrder
            // 
            this.listBoxOrder.FormattingEnabled = true;
            this.listBoxOrder.Location = new System.Drawing.Point(4, 37);
            this.listBoxOrder.Name = "listBoxOrder";
            this.listBoxOrder.Size = new System.Drawing.Size(437, 433);
            this.listBoxOrder.TabIndex = 3;
            // 
            // btnComplete
            // 
            this.btnComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComplete.Location = new System.Drawing.Point(198, 487);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(130, 23);
            this.btnComplete.TabIndex = 2;
            this.btnComplete.Text = "Complete Order";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnComplete_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Customer ID";
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(83, 54);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(246, 20);
            this.textBoxFName.TabIndex = 5;
            this.textBoxFName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxFName_Validating);
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(83, 80);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(246, 20);
            this.textBoxLName.TabIndex = 6;
            this.textBoxLName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLName_Validating);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(83, 106);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(246, 20);
            this.textBoxID.TabIndex = 7;
            this.textBoxID.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxID_Validating);
            // 
            // radioWaffleCone
            // 
            this.radioWaffleCone.AutoSize = true;
            this.radioWaffleCone.Checked = true;
            this.radioWaffleCone.Location = new System.Drawing.Point(19, 241);
            this.radioWaffleCone.Name = "radioWaffleCone";
            this.radioWaffleCone.Size = new System.Drawing.Size(84, 17);
            this.radioWaffleCone.TabIndex = 8;
            this.radioWaffleCone.TabStop = true;
            this.radioWaffleCone.Text = "Waffle Cone";
            this.radioWaffleCone.UseVisualStyleBackColor = true;
            // 
            // radioSugarCone
            // 
            this.radioSugarCone.AutoSize = true;
            this.radioSugarCone.Location = new System.Drawing.Point(18, 264);
            this.radioSugarCone.Name = "radioSugarCone";
            this.radioSugarCone.Size = new System.Drawing.Size(81, 17);
            this.radioSugarCone.TabIndex = 9;
            this.radioSugarCone.Text = "Sugar Cone";
            this.radioSugarCone.UseVisualStyleBackColor = true;
            // 
            // radioWaffleBowl
            // 
            this.radioWaffleBowl.AutoSize = true;
            this.radioWaffleBowl.Location = new System.Drawing.Point(19, 287);
            this.radioWaffleBowl.Name = "radioWaffleBowl";
            this.radioWaffleBowl.Size = new System.Drawing.Size(82, 17);
            this.radioWaffleBowl.TabIndex = 10;
            this.radioWaffleBowl.Text = "Waffle Bowl";
            this.radioWaffleBowl.UseVisualStyleBackColor = true;
            // 
            // radioBowl
            // 
            this.radioBowl.AutoSize = true;
            this.radioBowl.Location = new System.Drawing.Point(19, 310);
            this.radioBowl.Name = "radioBowl";
            this.radioBowl.Size = new System.Drawing.Size(48, 17);
            this.radioBowl.TabIndex = 11;
            this.radioBowl.Text = "Bowl";
            this.radioBowl.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cone";
            // 
            // listBoxFlavor
            // 
            this.listBoxFlavor.FormattingEnabled = true;
            this.listBoxFlavor.Items.AddRange(new object[] {
            " ",
            " ",
            " ",
            " "});
            this.listBoxFlavor.Location = new System.Drawing.Point(130, 245);
            this.listBoxFlavor.Name = "listBoxFlavor";
            this.listBoxFlavor.Size = new System.Drawing.Size(120, 82);
            this.listBoxFlavor.TabIndex = 13;
            // 
            // listBoxScopes
            // 
            this.listBoxScopes.FormattingEnabled = true;
            this.listBoxScopes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.listBoxScopes.Location = new System.Drawing.Point(273, 245);
            this.listBoxScopes.Name = "listBoxScopes";
            this.listBoxScopes.Size = new System.Drawing.Size(40, 82);
            this.listBoxScopes.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(163, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Flavor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(253, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Scope(s)";
            // 
            // radioButtonIC
            // 
            this.radioButtonIC.AutoSize = true;
            this.radioButtonIC.Location = new System.Drawing.Point(6, 3);
            this.radioButtonIC.Name = "radioButtonIC";
            this.radioButtonIC.Size = new System.Drawing.Size(73, 17);
            this.radioButtonIC.TabIndex = 17;
            this.radioButtonIC.Text = "Ice Cream";
            this.radioButtonIC.UseVisualStyleBackColor = true;
            this.radioButtonIC.CheckedChanged += new System.EventHandler(this.radioButtonIC_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Ice Cream or Yogurt?:";
            // 
            // radioButtonFY
            // 
            this.radioButtonFY.AutoSize = true;
            this.radioButtonFY.Location = new System.Drawing.Point(96, 3);
            this.radioButtonFY.Name = "radioButtonFY";
            this.radioButtonFY.Size = new System.Drawing.Size(56, 17);
            this.radioButtonFY.TabIndex = 19;
            this.radioButtonFY.Text = "Yogurt";
            this.radioButtonFY.UseVisualStyleBackColor = true;
            this.radioButtonFY.CheckedChanged += new System.EventHandler(this.radioButtonFY_CheckedChanged);
            // 
            // btnCone
            // 
            this.btnCone.Location = new System.Drawing.Point(64, 343);
            this.btnCone.Name = "btnCone";
            this.btnCone.Size = new System.Drawing.Size(75, 23);
            this.btnCone.TabIndex = 20;
            this.btnCone.Text = "Add Cone";
            this.btnCone.UseVisualStyleBackColor = true;
            this.btnCone.Click += new System.EventHandler(this.btnCone_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(158, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "*Max of 10 per order*";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(35, 445);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(220, 26);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "Order total is:    $0:00";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonFY);
            this.panel2.Controls.Add(this.radioButtonIC);
            this.panel2.Location = new System.Drawing.Point(177, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 24);
            this.panel2.TabIndex = 23;
            //
            //MessageBox Button
            //
            this.btnComplete.Name = "MbtnComplete";
            this.btnComplete.Size = new System.Drawing.Size(130, 23);
            this.btnComplete.TabIndex = 2;
            this.btnComplete.Text = "Complete Order";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnComplete_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 522);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxScopes);
            this.Controls.Add(this.listBoxFlavor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioBowl);
            this.Controls.Add(this.radioWaffleBowl);
            this.Controls.Add(this.radioSugarCone);
            this.Controls.Add(this.radioWaffleCone);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimumSize = new System.Drawing.Size(622, 561);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.RadioButton radioWaffleCone;
        private System.Windows.Forms.RadioButton radioSugarCone;
        private System.Windows.Forms.RadioButton radioWaffleBowl;
        private System.Windows.Forms.RadioButton radioBowl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxFlavor;
        private System.Windows.Forms.ListBox listBoxScopes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.RadioButton radioButtonIC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButtonFY;
        private System.Windows.Forms.Button btnCone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBoxOrder;

        public MessageBoxDefaultButton MbtnComplete { get; private set; }
        internal MessageBoxtButtons MsbtnComplete { get; private set; }
        public MessageBoxButtons MsgbtnComplete { get; private set; }
    }
}

