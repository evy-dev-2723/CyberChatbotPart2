using System;
using System.Windows.Forms;

namespace CyberBotPart2
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.voiceButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 10F);
            this.richTextBox1.ForeColor = System.Drawing.Color.Cyan;
            this.richTextBox1.Location = new System.Drawing.Point(20, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(800, 400);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "chatDisplay";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(20, 440);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(650, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "userInputBox";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.DarkCyan;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.ForeColor = System.Drawing.Color.White;
            this.sendButton.Location = new System.Drawing.Point(680, 438);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(140, 35);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send Message";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // voiceButton
            // 
            this.voiceButton.BackColor = System.Drawing.Color.DarkBlue;
            this.voiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voiceButton.ForeColor = System.Drawing.Color.White;
            this.voiceButton.Location = new System.Drawing.Point(20, 480);
            this.voiceButton.Name = "voiceButton";
            this.voiceButton.Size = new System.Drawing.Size(150, 35);
            this.voiceButton.TabIndex = 3;
            this.voiceButton.Text = "Play Voice Greeting";
            this.voiceButton.UseVisualStyleBackColor = false;
            this.voiceButton.Click += new System.EventHandler(this.voiceButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.DarkRed;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(680, 480);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(140, 35);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear Chat";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(180, 488);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(55, 20);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "Ready";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(838, 521);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.voiceButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void voiceButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button voiceButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label statusLabel;
    }
}

