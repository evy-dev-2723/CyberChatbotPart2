using System;
using System.Drawing;
using System.Windows.Forms;

namespace CyberBotPart2
{
    public partial class Form1 : Form
    {
        private Chatbot chatbot;
        private VoiceGreeting voiceGreeting;
        private string userName;
        private string userInterest;

        private RichTextBox chatDisplay;
        private TextBox userInputBox;
        private Button sendBtn; // renamed to avoid ambiguity with other partial declarations
        private Button voicePlayButton; // renamed to avoid ambiguity with other partial declarations
        private Button clearBtn;
        private Label statusLabelControl;

        public Form1()
        {
            this.Text = "🔐 Cybersecurity Chatbot - Part 2";
            this.Size = new Size(900, 650);
            this.BackColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;

            CreateControls();
            
            chatbot = new Chatbot();
            voiceGreeting = new VoiceGreeting();
            voiceGreeting.PlayGreeting();


            DisplayAsciiArt();
            AppendToChat("[Bot] Hello! What is your name?", Color.Cyan);
        }

        private void CreateControls()
        {
            chatDisplay = new RichTextBox
            {
                Location = new Point(20, 20),
                Size = new Size(840, 400),
                BackColor = Color.Black,
                ForeColor = Color.Cyan,
                Font = new Font("Consolas", 10),
                ReadOnly = true
            };
            this.Controls.Add(chatDisplay);

            userInputBox = new TextBox
            {
                Location = new Point(20, 440),
                  Size = new Size(690, 30),
                BackColor = Color.DarkGray,
                ForeColor = Color.White
            };
            userInputBox.KeyPress += UserInputBox_KeyPress;
            this.Controls.Add(userInputBox);

            sendBtn = new Button
            {
                Text = "Send",
                Location = new Point(720, 438),
                Size = new Size(140, 35),
                BackColor = Color.DarkCyan,
                ForeColor = Color.White
            };
            sendBtn.Click += SendButton_Click;
            this.Controls.Add(sendBtn);

            voicePlayButton = new Button
            {
                Text = "Play Voice",
                Location = new Point(20, 485),
                Size = new Size(150, 35),
                BackColor = Color.DarkBlue,
                ForeColor = Color.White
            };
                voicePlayButton.Click += VoiceButton_Click;
            this.Controls.Add(voicePlayButton);

            clearBtn = new Button
            {
                Text = "Clear",
                Location = new Point(720, 485),
                Size = new Size(140, 35),
                BackColor = Color.DarkRed,
                ForeColor = Color.White
            };
            clearBtn.Click += ClearButton_Click;
            this.Controls.Add(clearBtn);

                        statusLabelControl = new Label
            {
                Text = "Ready",
                Location = new Point(180, 493),
                Size = new Size(530, 25),
                ForeColor = Color.LightGreen
            };
            this.Controls.Add(statusLabelControl);
        }

        private void DisplayAsciiArt()
        {
            string art = @"
╔═══════════════════════════════════════════════════════════════════╗
║     ██████╗██╗   ██╗██████╗ ███████©║██████╗                       ║
║    ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗                      ║
║    ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝                      ║
║    ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗                      ║
║    ╚██████╗   ██║   ██████╔╝███████╗██║  ██║                      ║
║     ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝                      ║
║                                                                     ║
║         🔐  CYBERSECURITY AWARENESS BOT  🔐                      ║
╚═══════════════════════════════════════════════════════════════════╝";

            AppendToChat(art, Color.Cyan);
            AppendToChat("", Color.White);
            AppendToChat("🌍 WELCOME TO THE CYBERSECURITY AWARENESS BOT", Color.Yellow);
            AppendToChat("", Color.White);
        }

        private void ProcessUserInput()
        {
            string userInput = userInputBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                AppendToChat("Please enter a message.", Color.Red);
                userInputBox.Clear();
                return;
            }

            string displayName = string.IsNullOrEmpty(userName) ? "You" : userName;
            AppendToChat($"{displayName}: {userInput}", Color.LightGreen);
            userInputBox.Clear();

            // First time - get name
            if (string.IsNullOrEmpty(userName))
            {
                userName = userInput;
                chatbot.SetUserName(userName);
                AppendToChat($"Bot: Nice to meet you, {userName}! 🔐", Color.Cyan);
                AppendToChat($"Bot: Try asking me about: password, phishing, scam, or privacy", Color.Cyan);
                return;
            }

            // Exit command
            if (userInput.ToLower() == "exit")
            {
                AppendToChat($"Bot: Goodbye, {userName}! Stay safe online! 🔐", Color.Cyan);
                sendBtn.Enabled = false;
                userInputBox.Enabled = false;
                return;
            }

            statusLabelControl.Text = "Bot is thinking...";
            Application.DoEvents();

            string response = chatbot.GetResponse(userInput);
            AppendToChat($"Bot: {response}", Color.Cyan);

            statusLabelControl.Text = "Ready";
            userInputBox.Focus();
        }

        private void AppendToChat(string message, Color color)
        {
            if (chatDisplay.InvokeRequired)
            {
                chatDisplay.Invoke(new Action(() => AppendToChat(message, color)));
                return;
            }

            chatDisplay.SelectionStart = chatDisplay.TextLength;
            chatDisplay.SelectionLength = 0;
            chatDisplay.SelectionColor = color;
            chatDisplay.AppendText(message + "\n");
            chatDisplay.ScrollToCaret();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            ProcessUserInput();
        }

        private void VoiceButton_Click(object sender, EventArgs e)
        {
            try
            {
                statusLabelControl.Text = "Playing voice...";
                voiceGreeting.PlayGreeting();
                statusLabelControl.Text = "Ready";
                AppendToChat("Voice greeting played!", Color.Gray);
            }
            catch (Exception ex)
            {
                AppendToChat($"Error: {ex.Message}", Color.Red);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            chatDisplay.Clear();
            DisplayAsciiArt();
            AppendToChat("Bot: Chat cleared! What would you like to learn about?", Color.Cyan);
        }

        private void UserInputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ProcessUserInput();
                e.Handled = true;
            }
        }
    }
}