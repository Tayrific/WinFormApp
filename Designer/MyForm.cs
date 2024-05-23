namespace Designer
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void messageButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = messageTextBox.Text;
        }

        private void MyForm_Load(object sender, EventArgs e)
        {
            listBox.Items.Add("Oranges");
            listBox.Items.Add("Apples");
            listBox.Items.Add("Bananas");
            listBox.Items.Add("Grapes");

        }

        private void listButton_Click(object sender, EventArgs e)
        {
            listLabel.Text = listBox.Text;
        }
    }
}
