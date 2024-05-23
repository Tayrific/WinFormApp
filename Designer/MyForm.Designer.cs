namespace Designer
{
    partial class MyForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            messageButton = new Button();
            messageTextBox = new TextBox();
            messageLabel = new Label();
            listBox = new ListBox();
            listButton = new Button();
            listLabel = new Label();
            SuspendLayout();
            // 
            // messageButton
            // 
            messageButton.Location = new Point(25, 75);
            messageButton.Name = "messageButton";
            messageButton.Size = new Size(200, 30);
            messageButton.TabIndex = 0;
            messageButton.Text = "Show Message";
            messageButton.UseVisualStyleBackColor = true;
            messageButton.Click += messageButton_Click;
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(25, 25);
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(200, 23);
            messageTextBox.TabIndex = 1;
            // 
            // messageLabel
            // 
            messageLabel.Location = new Point(25, 125);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(200, 15);
            messageLabel.TabIndex = 2;
            messageLabel.Text = "[message]";
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(501, 12);
            listBox.Name = "listBox";
            listBox.Size = new Size(329, 199);
            listBox.TabIndex = 3;
            // 
            // listButton
            // 
            listButton.Location = new Point(569, 226);
            listButton.Name = "listButton";
            listButton.Size = new Size(211, 61);
            listButton.TabIndex = 4;
            listButton.Text = "button1";
            listButton.UseVisualStyleBackColor = true;
            listButton.Click += listButton_Click;
            // 
            // listLabel
            // 
            listLabel.AutoSize = true;
            listLabel.Location = new Point(659, 307);
            listLabel.Name = "listLabel";
            listLabel.Size = new Size(0, 15);
            listLabel.TabIndex = 5;
            // 
            // MyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 761);
            Controls.Add(listLabel);
            Controls.Add(listButton);
            Controls.Add(listBox);
            Controls.Add(messageLabel);
            Controls.Add(messageTextBox);
            Controls.Add(messageButton);
            Name = "MyForm";
            Text = "MyForm";
            Load += MyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button messageButton;
        private TextBox messageTextBox;
        private Label messageLabel;
        private ListBox listBox;
        private Button listButton;
        private Label listLabel;
    }
}
