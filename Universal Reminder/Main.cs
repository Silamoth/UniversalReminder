using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Net.Sockets;
using System.Net;
using Windows.UI.Notifications;
using Windows.Data;
using System.Runtime;
using Tulpep.NotificationWindow;

namespace Universal_Reminder
{
    public partial class Main : Form
    {
        bool sendEmail, sendText, sendNotification;
        String emailAddress, phoneNumber;

        List<DateTime> reminderTimes;
        List<String> reminders;

        public Main()
        {
            InitializeComponent();
        }

        private void configButton_Click(object sender, EventArgs e)
        {
            Config config = new Config(sendEmail, sendText, sendNotification, emailAddress, phoneNumber);
            config.ShowDialog();
            sendEmail = config.NewSendEmail;
            sendText = config.NewSendText;
            sendNotification = config.NewSendNotification;
            emailAddress = config.NewEmailAddress;
            phoneNumber = config.NewPhoneNumber;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            reminderTimes = new List<DateTime>();
            reminders = new List<String>();

            if (File.Exists("config.txt"))
            {
                StreamReader reader = new StreamReader("config.txt");

                bool.TryParse(reader.ReadLine(), out sendEmail);
                bool.TryParse(reader.ReadLine(), out sendText);
                bool.TryParse(reader.ReadLine(), out sendNotification);
                emailAddress = reader.ReadLine();
                phoneNumber = reader.ReadLine();

                reader.Close();
            }
            else
            {
                StreamWriter writer = new StreamWriter("config.txt");

                writer.WriteLine("False");
                writer.WriteLine("False");
                writer.WriteLine("True");
                writer.WriteLine(String.Empty);
                writer.WriteLine(String.Empty);

                writer.Close();
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter writer = new StreamWriter("config.txt");

            writer.WriteLine(sendEmail.ToString());
            writer.WriteLine(sendText.ToString());
            writer.WriteLine(sendNotification.ToString());
            writer.WriteLine(emailAddress);
            writer.WriteLine(phoneNumber);

            writer.Close();

            notifyIcon.Visible = true;
            Hide();

            e.Cancel = true;
        }

        private void addReminderButton_Click(object sender, EventArgs e)
        {
            if (titleTextBox.Text == String.Empty)
            {
                MessageBox.Show("The reminder title cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (reminderTextBox.Text == String.Empty)
            {
                MessageBox.Show("The reminder cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (urgencyComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("You must select an urgency level.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<String> stuffToSend = new List<String>();
            stuffToSend.Add(titleTextBox.Text);
            stuffToSend.Add(reminderTextBox.Text);
            stuffToSend.Add((String)urgencyComboBox.SelectedItem);
            stuffToSend.Add(TimeZoneInfo.Local.ToSerializedString());
            stuffToSend.Add(reminderDatePicker.Value.ToLongDateString());
            stuffToSend.Add(reminderTimePicker.Value.ToLongTimeString());

            if (sendEmail)
                stuffToSend.Add(emailAddress);
            else
                stuffToSend.Add(String.Empty);

            if (sendText)
                stuffToSend.Add(phoneNumber);
            else
                stuffToSend.Add(String.Empty);
            
            if (stuffToSend.Count > 0)
            {
                try
                {
                    TcpClient client = new TcpClient("13.58.218.127", 9000);      //Connect

                    StreamReader reader = new StreamReader(client.GetStream());
                    StreamWriter writer = new StreamWriter(client.GetStream());

                    //Receive connection verification
                    byte[] buffer = new byte[client.Client.ReceiveBufferSize];
                    client.Client.Receive(buffer);
                    String response = Encoding.ASCII.GetString(buffer).TrimEnd(new char[] { '\n', '\r', '\0' });

                    int index = 0;

                    while (index < stuffToSend.Count && response == "HTTP/1.0 200 OK")
                    {
                        //Send next thing
                        byte[] toBeSent = Encoding.ASCII.GetBytes(stuffToSend[index]);
                        writer.BaseStream.Write(toBeSent, 0, toBeSent.Length);
                        writer.Flush();

                        //Receive verification
                        buffer = new byte[client.Client.ReceiveBufferSize];
                        client.Client.Receive(buffer);
                        response = Encoding.ASCII.GetString(buffer).TrimEnd(new char[] { '\n', '\r', '\0' });

                        index++;
                    }

                    reader.Close();
                    writer.Close();
                    client.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (sendNotification)
            {
                DateTime remindTime = new DateTime(reminderDatePicker.Value.Year, reminderDatePicker.Value.Month, reminderDatePicker.Value.Day,
                    reminderTimePicker.Value.Hour, reminderTimePicker.Value.Minute, reminderTimePicker.Value.Second);
                reminderTimes.Add(remindTime);
                reminders.Add(reminderTextBox.Text);
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < reminderTimes.Count; i++)
            {
                if (reminderTimes[i].Year == DateTime.Now.Year && reminderTimes[i].Month == DateTime.Now.Month && reminderTimes[i].Day == DateTime.Now.Day &&
                     reminderTimes[i].Hour == DateTime.Now.Hour && reminderTimes[i].Minute == DateTime.Now.Minute)
                {
                    PopupNotifier popup = new PopupNotifier();
                    popup.TitleText = "Reminder";
                    popup.ContentText = reminders[i];
                    popup.Popup();

                    reminderTimes.RemoveAt(i);
                    reminders.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}