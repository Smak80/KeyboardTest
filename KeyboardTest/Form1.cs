namespace KeyboardTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.H)
            {
                textBox1.Text = "Ctrl+H pressed";
            } else 
                textBox1.Text = e.KeyValue.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ModifierKeys == Keys.Alt)
            {
                textBox1.Text = "Alt Move";
            }
        }
    }
}