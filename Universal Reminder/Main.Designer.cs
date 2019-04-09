namespace Universal_Reminder
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reminderTextBox = new System.Windows.Forms.TextBox();
            this.urgencyComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addReminderButton = new System.Windows.Forms.Button();
            this.reminderDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.reminderTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.configButton = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "UNIVERSAL REMINDER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reminder Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(96, 124);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(676, 20);
            this.titleTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reminder:";
            // 
            // reminderTextBox
            // 
            this.reminderTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.reminderTextBox.Location = new System.Drawing.Point(96, 167);
            this.reminderTextBox.Multiline = true;
            this.reminderTextBox.Name = "reminderTextBox";
            this.reminderTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reminderTextBox.Size = new System.Drawing.Size(676, 116);
            this.reminderTextBox.TabIndex = 4;
            // 
            // urgencyComboBox
            // 
            this.urgencyComboBox.FormattingEnabled = true;
            this.urgencyComboBox.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Critical"});
            this.urgencyComboBox.Location = new System.Drawing.Point(96, 302);
            this.urgencyComboBox.Name = "urgencyComboBox";
            this.urgencyComboBox.Size = new System.Drawing.Size(121, 21);
            this.urgencyComboBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Urgency:";
            // 
            // addReminderButton
            // 
            this.addReminderButton.Location = new System.Drawing.Point(12, 526);
            this.addReminderButton.Name = "addReminderButton";
            this.addReminderButton.Size = new System.Drawing.Size(106, 23);
            this.addReminderButton.TabIndex = 7;
            this.addReminderButton.Text = "Add Reminder";
            this.addReminderButton.UseVisualStyleBackColor = true;
            this.addReminderButton.Click += new System.EventHandler(this.addReminderButton_Click);
            // 
            // reminderDatePicker
            // 
            this.reminderDatePicker.Location = new System.Drawing.Point(96, 380);
            this.reminderDatePicker.Name = "reminderDatePicker";
            this.reminderDatePicker.Size = new System.Drawing.Size(200, 20);
            this.reminderDatePicker.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Reminder Date:";
            // 
            // reminderTimePicker
            // 
            this.reminderTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.reminderTimePicker.Location = new System.Drawing.Point(96, 451);
            this.reminderTimePicker.Name = "reminderTimePicker";
            this.reminderTimePicker.ShowUpDown = true;
            this.reminderTimePicker.Size = new System.Drawing.Size(200, 20);
            this.reminderTimePicker.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Reminder Time:";
            // 
            // configButton
            // 
            this.configButton.Location = new System.Drawing.Point(648, 526);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(75, 23);
            this.configButton.TabIndex = 12;
            this.configButton.Text = "Configure";
            this.configButton.UseVisualStyleBackColor = true;
            this.configButton.Click += new System.EventHandler(this.configButton_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "DON\'T CLSOE";
            this.notifyIcon.BalloonTipTitle = "Universal Reminder";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "This program must always run to work";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 30000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.configButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.reminderTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reminderDatePicker);
            this.Controls.Add(this.addReminderButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.urgencyComboBox);
            this.Controls.Add(this.reminderTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Universal Reminder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reminderTextBox;
        private System.Windows.Forms.ComboBox urgencyComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addReminderButton;
        private System.Windows.Forms.DateTimePicker reminderDatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker reminderTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button configButton;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer timer;
    }
}

