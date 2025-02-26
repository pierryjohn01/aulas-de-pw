namespace cardapio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "X TUDO";
            textBox2.Text = "X SALADA";
            textBox3.Text = "DOGÃO";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = "LARANJA";
            textBox5.Text = "MARACUJA";
            textBox6.Text = "UVA";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox7.Text = "PUDIM";
            textBox8.Text = "TORTA DE LIMÃO";
            textBox9.Text = "SANDEI";

        }
    }
}
