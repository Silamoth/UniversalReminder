namespace Universal_Reminder
{
    partial class Config
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
            this.emailCheckBox = new System.Windows.Forms.CheckBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.windowsCheckBox = new System.Windows.Forms.CheckBox();
            this.textCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // emailCheckBox
            // 
            this.emailCheckBox.AutoSize = true;
            this.emailCheckBox.Location = new System.Drawing.Point(13, 13);
            this.emailCheckBox.Name = "emailCheckBox";
            this.emailCheckBox.Size = new System.Drawing.Size(82, 17);
            this.emailCheckBox.TabIndex = 0;
            this.emailCheckBox.Text = "Send E-mail";
            this.emailCheckBox.UseVisualStyleBackColor = true;
            this.emailCheckBox.CheckedChanged += new System.EventHandler(this.emailCheckBox_CheckedChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(51, 34);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(443, 20);
            this.emailTextBox.TabIndex = 1;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email:";
            // 
            // windowsCheckBox
            // 
            this.windowsCheckBox.AutoSize = true;
            this.windowsCheckBox.Location = new System.Drawing.Point(13, 96);
            this.windowsCheckBox.Name = "windowsCheckBox";
            this.windowsCheckBox.Size = new System.Drawing.Size(154, 17);
            this.windowsCheckBox.TabIndex = 3;
            this.windowsCheckBox.Text = "Send Windows Notification";
            this.windowsCheckBox.UseVisualStyleBackColor = true;
            this.windowsCheckBox.CheckedChanged += new System.EventHandler(this.windowsCheckBox_CheckedChanged);
            // 
            // textCheckBox
            // 
            this.textCheckBox.AutoSize = true;
            this.textCheckBox.Location = new System.Drawing.Point(13, 157);
            this.textCheckBox.Name = "textCheckBox";
            this.textCheckBox.Size = new System.Drawing.Size(75, 17);
            this.textCheckBox.TabIndex = 4;
            this.textCheckBox.Text = "Send Text";
            this.textCheckBox.UseVisualStyleBackColor = true;
            this.textCheckBox.CheckedChanged += new System.EventHandler(this.textCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phone Number:";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(97, 192);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(397, 20);
            this.phoneNumberTextBox.TabIndex = 6;
            this.phoneNumberTextBox.TextChanged += new System.EventHandler(this.phoneNumberTextBox_TextChanged);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 401);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCheckBox);
            this.Controls.Add(this.windowsCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailCheckBox);
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Config_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox emailCheckBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox windowsCheckBox;
        private System.Windows.Forms.CheckBox textCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
    }
}