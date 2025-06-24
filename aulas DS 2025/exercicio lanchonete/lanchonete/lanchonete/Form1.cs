namespace lanchonete
{
    public partial class Form1 : Form
    {
        double valorpao, valorrecheio;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg;
            double total;
            total = 0;
            msg = " - Tipo de Recheio = Pão  " + comboBox2.Text;
            total = total + valorrecheio;
            msg = msg + valorpao;
            if (checkBox1.Checked == true)
            {
                total = total + 0.5;
            }
            if (checkBox2.Checked == true)
            {
                total = total + 0.5;
            }
            if (checkBox3.Checked == true)
            {
                total = total + 0.5;
            }
            if (checkBox4.Checked == true)
            {
                total = total + 0.5;
            }
            if (checkBox5.Checked == true)
            {
                total = total + 0.5;
            }
            if (checkBox6.Checked == true)
            {
                total = total + 0.5;
            }
            if (checkBox7.Checked == true)
            {
                total = total + 0.5;
            }
            if (checkBox8.Checked == true)
            {
                total = total + 0.5;
            }
            if (checkBox9.Checked == true)
            {
                total = total + 0.5;
            }
            msg = msg + " - Total = R$" + total;
            MessageBox.Show(msg);

        }
    }
}
