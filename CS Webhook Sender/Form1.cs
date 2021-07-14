using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Webhook_Sender
{
    public partial class Form1 : Form
    {

        private static NameValueCollection webhookValues = new NameValueCollection();
        string link = "";

        public Form1()
        {
            InitializeComponent();
        }

        // -------------------------- Make window draggable --------------------------

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void topBarPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // -------------------------- Top bar buttons --------------------------
        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimiseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // -------------------------- Settings Menu buttons --------------------------
        private void applyLink_Click(object sender, EventArgs e)
        {
            string wLink = linkTextBox.Text;
            link = wLink;
            webhookLinkLabel.Text = "Webhook link: " + wLink;
        }

        private void applyPFP_Click(object sender, EventArgs e)
        {
            string wPFP = PFPTextBox.Text;
            webhookValues.Set("avatar_url", wPFP);
            webhookPFPLabel.Text = "Webhook profile picture: " + wPFP;
        }

        private void applyName_Click(object sender, EventArgs e)
        {
            string wName = nameTextBox.Text;
            webhookValues.Set("username", wName);
            webhookNameLabel.Text = "Webhook name: " + wName;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "txt files (*.txt)|*.txt";
                saveFileDialog.RestoreDirectory = true;

                if (Directory.Exists(Application.StartupPath + "\\saves"))
                    saveFileDialog.InitialDirectory = Application.StartupPath + "\\saves";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Stream fileStream = saveFileDialog.OpenFile();
                    using (StreamWriter sw = new StreamWriter(fileStream))
                    {
                        sw.WriteLine($"{link}|{webhookValues.Get("username")}|{webhookValues.Get("avatar_url")}");
                    }
                }
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.RestoreDirectory = true;

                if (Directory.Exists(Application.StartupPath + "\\saves"))
                    openFileDialog.InitialDirectory = Application.StartupPath + "\\saves";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Stream fileStream = openFileDialog.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        string content = reader.ReadToEnd();
                        string[] args = content.Split("|");

                        if (args.Length < 1 || args.Length > 3)
                            return;

                        string wLink, username, avatar_url;
                        wLink = args[0];
                        username = args[1];
                        avatar_url = args[2];

                        link = wLink;
                        webhookLinkLabel.Text = "Webhook link: " + wLink;
                        linkTextBox.Text = wLink;

                        webhookValues.Set("username", username);
                        webhookNameLabel.Text = "Webhook name: " + username;
                        nameTextBox.Text = username;

                        webhookValues.Set("avatar_url", avatar_url);
                        webhookPFPLabel.Text = "Webhook profile picture: " + avatar_url;
                        PFPTextBox.Text = avatar_url;

                    }
                }
            }
        }

        // -------------------------- Message menu buttons --------------------------

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            messageLength.Text = textBox1.Text.Length.ToString();
        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            webhookValues.Set("content", textBox1.Text);
            using (WebClient dWebHook = new WebClient())
            {
                dWebHook.UploadValues(link, webhookValues);
            }
        }

        // -------------------------- Side menu buttons --------------------------
        private void showSettings_Click(object sender, EventArgs e)
        {
            messageLabel.Visible = false;
            messagePanel.Visible = false;

            messagePanel.SendToBack();
            messageLabel.SendToBack();

            settingsLabel.Visible = true;
            settingsPanel.Visible = true;
            settingsLabel.BringToFront();
        }

        private void showMessage_Click(object sender, EventArgs e)
        {
            settingsLabel.Visible = false;
            settingsPanel.Visible = false;

            settingsPanel.SendToBack();
            settingsLabel.SendToBack();

            messageLabel.Visible = true;
            messagePanel.Visible = true;
            messageLabel.BringToFront();
        }
    }
}
