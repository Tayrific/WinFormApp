namespace WinFormApp1
{
    public partial class Form1 : Form
    {
        private TextBox messageTextBox;
        private  Label MessageLabel;
        private  Button ShowMessageButton;


        public Form1()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            messageTextBox = new TextBox();
            messageTextBox.Left = 25;
            messageTextBox.Top = 25;
            messageTextBox.Width = 200;
            this.Controls.Add(messageTextBox);

            ShowMessageButton = new Button();
            ShowMessageButton.Left = 25;
            ShowMessageButton.Top = 75;
            ShowMessageButton.Width = 200;
            ShowMessageButton.Text = "Show Message";
            this.Controls.Add(ShowMessageButton);
            ShowMessageButton.Click += ShowMessageButton_Click1;

            MessageLabel = new Label();
            MessageLabel.Left = 25;
            MessageLabel.Top = 125;
            MessageLabel.Width = 200;
            this.Controls.Add(MessageLabel);
 
        }

        private void ShowMessageButton_Click1(object? sender, EventArgs e)
        {
            MessageLabel.Text = messageTextBox.Text;
        }



    }
}
