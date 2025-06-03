namespace exercio_dia_06_06
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
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double quantidade_max, quantidade_min, total;

            quantidade_max = double.Parse (textBox2.Text);
            quantidade_min = double.Parse (textBox1.Text);
            total = (quantidade_max + quantidade_min)/2;
            textBox3.Text = total.ToString();

            if (total <=5)
            {
                MessageBox.Show("Quantidade baixa, renovar estoque");
            }
            
            else{
            
                MessageBox.Show("Quantidade está normal");
            }


        }
    }
}
