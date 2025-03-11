namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, n4, total;
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);
            n3 = double.Parse(textBox3.Text);
            n4 = double.Parse(textBox4.Text);
            total = (n1 + n2 + n3 + n4) / 4;
            textBox5.Text = total.ToString();
        }
    }
}
