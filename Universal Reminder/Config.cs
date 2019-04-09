using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Universal_Reminder
{
    public partial class Config : Form
    {
        bool newSendEmail, newSendText, newSendNotification;
        String newEmailAddress, newPhoneNumber;

        public Config(bool sendEmail, bool sendText, bool sendNotification, String emailAddress, String phoneNumber)
        {
            InitializeComponent();

            emailCheckBox.Checked = sendEmail;
            emailTextBox.Enabled = sendEmail;
            textCheckBox.Checked = sendText;
            phoneNumberTextBox.Enabled = sendText;
            windowsCheckBox.Checked = sendNotification;
            emailTextBox.Text = emailAddress;
            phoneNumberTextBox.Text = phoneNumber;

            newSendEmail = sendEmail;
            newSendText = sendText;
            newSendNotification = sendNotification;
            newEmailAddress = emailAddress;
            newPhoneNumber = phoneNumber;
        }

        private void emailCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            emailTextBox.Enabled = emailCheckBox.Checked;
            newSendEmail = emailCheckBox.Checked;
            newEmailAddress = String.Empty;
            emailTextBox.Text = String.Empty;
        }

        private void textCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            phoneNumberTextBox.Enabled = textCheckBox.Checked;
            newSendText = textCheckBox.Checked;
            newPhoneNumber = String.Empty;
            phoneNumberTextBox.Text = String.Empty;
        }

        private void windowsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            newSendNotification = windowsCheckBox.Checked;
        }

        private void Config_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(windowsCheckBox.Checked || textCheckBox.Checked || emailCheckBox.Checked))
            {
                MessageBox.Show("You must select at least one form of notification.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            newEmailAddress = emailTextBox.Text;
        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            newPhoneNumber = phoneNumberTextBox.Text;
        }

        public bool NewSendEmail
        {
            get { return newSendEmail; }
        }

        public bool NewSendText
        {
            get { return newSendText; }
        }

        public bool NewSendNotification
        {
            get { return newSendNotification; }
        }

        public String NewEmailAddress
        {
            get { return newEmailAddress; }
        }

        public String NewPhoneNumber
        {
            get { return newPhoneNumber; }
        }                
    }
}