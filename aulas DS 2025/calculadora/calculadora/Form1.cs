namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n1, n2, total;
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);
            total = n1 - n2;
            textBox3.Text = total.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, total;
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);
            total = n1 + n2;
            textBox3.Text = total.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double n1, n2, total;
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);
            total = n1 * n2;
            textBox3.Text = total.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double n1, n2, total;
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);
            total = n1 / n2;
            textBox3.Text = total.ToString();
        }
    }
}
