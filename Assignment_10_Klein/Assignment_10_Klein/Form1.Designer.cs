namespace Assignment_10_Klein
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
            this.NavTab = new System.Windows.Forms.TabControl();
            this.EntryTabBox = new System.Windows.Forms.TabPage();
            this.ExitBttn = new System.Windows.Forms.Button();
            this.AddFriendBttn = new System.Windows.Forms.Button();
            this.BirthDayTextBox = new System.Windows.Forms.TextBox();
            this.MonthTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.BirthDayLabel = new System.Windows.Forms.Label();
            this.BirthMonthLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.ReadTabBox = new System.Windows.Forms.TabPage();
            this.ReadFileTextBox = new System.Windows.Forms.TextBox();
            this.ExitBttnTB2 = new System.Windows.Forms.Button();
            this.ReadBttn = new System.Windows.Forms.Button();
            this.ReminderTabBox = new System.Windows.Forms.TabPage();
            this.RemindersTextBox = new System.Windows.Forms.TextBox();
            this.ReminderTabExitBttn = new System.Windows.Forms.Button();
            this.ReminderButton = new System.Windows.Forms.Button();
            this.SearchMonthTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NavTab.SuspendLayout();
            this.EntryTabBox.SuspendLayout();
            this.ReadTabBox.SuspendLayout();
            this.ReminderTabBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavTab
            // 
            this.NavTab.Controls.Add(this.EntryTabBox);
            this.NavTab.Controls.Add(this.ReadTabBox);
            this.NavTab.Controls.Add(this.ReminderTabBox);
            this.NavTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavTab.ItemSize = new System.Drawing.Size(100, 25);
            this.NavTab.Location = new System.Drawing.Point(5, 5);
            this.NavTab.Name = "NavTab";
            this.NavTab.SelectedIndex = 0;
            this.NavTab.Size = new System.Drawing.Size(475, 305);
            this.NavTab.TabIndex = 0;
            this.NavTab.SelectedIndexChanged += new System.EventHandler(this.NavTab_Change);
            // 
            // EntryTabBox
            // 
            this.EntryTabBox.Controls.Add(this.ExitBttn);
            this.EntryTabBox.Controls.Add(this.AddFriendBttn);
            this.EntryTabBox.Controls.Add(this.BirthDayTextBox);
            this.EntryTabBox.Controls.Add(this.MonthTextBox);
            this.EntryTabBox.Controls.Add(this.PhoneTextBox);
            this.EntryTabBox.Controls.Add(this.LastNameTextBox);
            this.EntryTabBox.Controls.Add(this.FirstNameTextBox);
            this.EntryTabBox.Controls.Add(this.BirthDayLabel);
            this.EntryTabBox.Controls.Add(this.BirthMonthLabel);
            this.EntryTabBox.Controls.Add(this.PhoneNumberLabel);
            this.EntryTabBox.Controls.Add(this.LastNameLabel);
            this.EntryTabBox.Controls.Add(this.FirstNameLabel);
            this.EntryTabBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryTabBox.Location = new System.Drawing.Point(4, 29);
            this.EntryTabBox.Name = "EntryTabBox";
            this.EntryTabBox.Padding = new System.Windows.Forms.Padding(3);
            this.EntryTabBox.Size = new System.Drawing.Size(467, 272);
            this.EntryTabBox.TabIndex = 0;
            this.EntryTabBox.Text = "Entry";
            this.EntryTabBox.UseVisualStyleBackColor = true;
            // 
            // ExitBttn
            // 
            this.ExitBttn.Location = new System.Drawing.Point(338, 193);
            this.ExitBttn.Name = "ExitBttn";
            this.ExitBttn.Size = new System.Drawing.Size(100, 23);
            this.ExitBttn.TabIndex = 11;
            this.ExitBttn.Text = "Exit";
            this.ExitBttn.UseVisualStyleBackColor = true;
            this.ExitBttn.Click += new System.EventHandler(this.ExitBttn_Click);
            // 
            // AddFriendBttn
            // 
            this.AddFriendBttn.Location = new System.Drawing.Point(338, 140);
            this.AddFriendBttn.Name = "AddFriendBttn";
            this.AddFriendBttn.Size = new System.Drawing.Size(100, 23);
            this.AddFriendBttn.TabIndex = 10;
            this.AddFriendBttn.Text = "Enter Friend";
            this.AddFriendBttn.UseVisualStyleBackColor = true;
            this.AddFriendBttn.Click += new System.EventHandler(this.AddFriendBttn_Click);
            // 
            // BirthDayTextBox
            // 
            this.BirthDayTextBox.Location = new System.Drawing.Point(201, 214);
            this.BirthDayTextBox.MaxLength = 2;
            this.BirthDayTextBox.Name = "BirthDayTextBox";
            this.BirthDayTextBox.Size = new System.Drawing.Size(53, 22);
            this.BirthDayTextBox.TabIndex = 9;
            // 
            // MonthTextBox
            // 
            this.MonthTextBox.Location = new System.Drawing.Point(201, 163);
            this.MonthTextBox.MaxLength = 2;
            this.MonthTextBox.Name = "MonthTextBox";
            this.MonthTextBox.Size = new System.Drawing.Size(53, 22);
            this.MonthTextBox.TabIndex = 8;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(201, 112);
            this.PhoneTextBox.Mask = "999-9999";
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(79, 22);
            this.PhoneTextBox.TabIndex = 7;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(201, 61);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(163, 22);
            this.LastNameTextBox.TabIndex = 6;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(201, 10);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(163, 22);
            this.FirstNameTextBox.TabIndex = 5;
            // 
            // BirthDayLabel
            // 
            this.BirthDayLabel.AutoSize = true;
            this.BirthDayLabel.Location = new System.Drawing.Point(13, 221);
            this.BirthDayLabel.Name = "BirthDayLabel";
            this.BirthDayLabel.Size = new System.Drawing.Size(167, 16);
            this.BirthDayLabel.TabIndex = 4;
            this.BirthDayLabel.Text = "Enter Birth Day (eg: 24)";
            // 
            // BirthMonthLabel
            // 
            this.BirthMonthLabel.AutoSize = true;
            this.BirthMonthLabel.Location = new System.Drawing.Point(13, 169);
            this.BirthMonthLabel.Name = "BirthMonthLabel";
            this.BirthMonthLabel.Size = new System.Drawing.Size(180, 16);
            this.BirthMonthLabel.TabIndex = 3;
            this.BirthMonthLabel.Text = "Enter Birth Month (eg: 10)";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(13, 117);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(154, 16);
            this.PhoneNumberLabel.TabIndex = 2;
            this.PhoneNumberLabel.Text = "Enter Phone Number:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(13, 65);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(126, 16);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Enter Last Name:";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(13, 13);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(127, 16);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "Enter First Name:";
            // 
            // ReadTabBox
            // 
            this.ReadTabBox.Controls.Add(this.ReadFileTextBox);
            this.ReadTabBox.Controls.Add(this.ExitBttnTB2);
            this.ReadTabBox.Controls.Add(this.ReadBttn);
            this.ReadTabBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadTabBox.Location = new System.Drawing.Point(4, 29);
            this.ReadTabBox.Name = "ReadTabBox";
            this.ReadTabBox.Padding = new System.Windows.Forms.Padding(3);
            this.ReadTabBox.Size = new System.Drawing.Size(467, 272);
            this.ReadTabBox.TabIndex = 1;
            this.ReadTabBox.Text = "Read";
            this.ReadTabBox.UseVisualStyleBackColor = true;
            // 
            // ReadFileTextBox
            // 
            this.ReadFileTextBox.Enabled = false;
            this.ReadFileTextBox.Location = new System.Drawing.Point(19, 15);
            this.ReadFileTextBox.Multiline = true;
            this.ReadFileTextBox.Name = "ReadFileTextBox";
            this.ReadFileTextBox.Size = new System.Drawing.Size(428, 209);
            this.ReadFileTextBox.TabIndex = 2;
            // 
            // ExitBttnTB2
            // 
            this.ExitBttnTB2.Location = new System.Drawing.Point(255, 240);
            this.ExitBttnTB2.Name = "ExitBttnTB2";
            this.ExitBttnTB2.Size = new System.Drawing.Size(75, 23);
            this.ExitBttnTB2.TabIndex = 1;
            this.ExitBttnTB2.Text = "Exit";
            this.ExitBttnTB2.UseVisualStyleBackColor = true;
            this.ExitBttnTB2.Click += new System.EventHandler(this.ExitBttnTB2_Click);
            // 
            // ReadBttn
            // 
            this.ReadBttn.Location = new System.Drawing.Point(120, 240);
            this.ReadBttn.Name = "ReadBttn";
            this.ReadBttn.Size = new System.Drawing.Size(75, 23);
            this.ReadBttn.TabIndex = 0;
            this.ReadBttn.Text = "Read";
            this.ReadBttn.UseVisualStyleBackColor = true;
            this.ReadBttn.Click += new System.EventHandler(this.ReadBttn_Click);
            // 
            // ReminderTabBox
            // 
            this.ReminderTabBox.Controls.Add(this.RemindersTextBox);
            this.ReminderTabBox.Controls.Add(this.ReminderTabExitBttn);
            this.ReminderTabBox.Controls.Add(this.ReminderButton);
            this.ReminderTabBox.Controls.Add(this.SearchMonthTextBox);
            this.ReminderTabBox.Controls.Add(this.label1);
            this.ReminderTabBox.Location = new System.Drawing.Point(4, 29);
            this.ReminderTabBox.Name = "ReminderTabBox";
            this.ReminderTabBox.Size = new System.Drawing.Size(467, 272);
            this.ReminderTabBox.TabIndex = 2;
            this.ReminderTabBox.Text = "Reminder";
            this.ReminderTabBox.UseVisualStyleBackColor = true;
            // 
            // RemindersTextBox
            // 
            this.RemindersTextBox.Enabled = false;
            this.RemindersTextBox.Location = new System.Drawing.Point(3, 3);
            this.RemindersTextBox.Multiline = true;
            this.RemindersTextBox.Name = "RemindersTextBox";
            this.RemindersTextBox.Size = new System.Drawing.Size(460, 194);
            this.RemindersTextBox.TabIndex = 12;
            // 
            // ReminderTabExitBttn
            // 
            this.ReminderTabExitBttn.Location = new System.Drawing.Point(250, 240);
            this.ReminderTabExitBttn.Name = "ReminderTabExitBttn";
            this.ReminderTabExitBttn.Size = new System.Drawing.Size(75, 23);
            this.ReminderTabExitBttn.TabIndex = 11;
            this.ReminderTabExitBttn.Text = "Exit";
            this.ReminderTabExitBttn.UseVisualStyleBackColor = true;
            this.ReminderTabExitBttn.Click += new System.EventHandler(this.ReminderTabExitBttn_Click);
            // 
            // ReminderButton
            // 
            this.ReminderButton.Location = new System.Drawing.Point(120, 240);
            this.ReminderButton.Name = "ReminderButton";
            this.ReminderButton.Size = new System.Drawing.Size(83, 23);
            this.ReminderButton.TabIndex = 10;
            this.ReminderButton.Text = "Reminder";
            this.ReminderButton.UseVisualStyleBackColor = true;
            this.ReminderButton.Click += new System.EventHandler(this.ReminderButton_Click);
            // 
            // SearchMonthTextBox
            // 
            this.SearchMonthTextBox.ForeColor = System.Drawing.Color.Black;
            this.SearchMonthTextBox.Location = new System.Drawing.Point(341, 203);
            this.SearchMonthTextBox.MaxLength = 2;
            this.SearchMonthTextBox.Name = "SearchMonthTextBox";
            this.SearchMonthTextBox.Size = new System.Drawing.Size(53, 22);
            this.SearchMonthTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which Month\'s Birthday Do You Want to Display? --->";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.NavTab);
            this.Name = "Form1";
            this.Text = "Friends";
            this.NavTab.ResumeLayout(false);
            this.EntryTabBox.ResumeLayout(false);
            this.EntryTabBox.PerformLayout();
            this.ReadTabBox.ResumeLayout(false);
            this.ReadTabBox.PerformLayout();
            this.ReminderTabBox.ResumeLayout(false);
            this.ReminderTabBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl NavTab;
        private System.Windows.Forms.TabPage EntryTabBox;
        private System.Windows.Forms.TabPage ReadTabBox;
        private System.Windows.Forms.TabPage ReminderTabBox;
        private System.Windows.Forms.Button ExitBttn;
        private System.Windows.Forms.Button AddFriendBttn;
        private System.Windows.Forms.TextBox BirthDayTextBox;
        private System.Windows.Forms.TextBox MonthTextBox;
        private System.Windows.Forms.MaskedTextBox PhoneTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label BirthDayLabel;
        private System.Windows.Forms.Label BirthMonthLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Button ExitBttnTB2;
        private System.Windows.Forms.Button ReadBttn;
        private System.Windows.Forms.Button ReminderTabExitBttn;
        private System.Windows.Forms.Button ReminderButton;
        private System.Windows.Forms.TextBox SearchMonthTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ReadFileTextBox;
        private System.Windows.Forms.TextBox RemindersTextBox;
        
    }
}

