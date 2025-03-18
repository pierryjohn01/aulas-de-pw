namespace comcobox
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

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            comboBox3.Text = " ";
            label4.Text = " ";
            label5.Text = " ";
            label6.Text = " ";
    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = comboBox1.Text;
;           label5.Text = comboBox2.Text;
            label6.Text = comboBox3.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
