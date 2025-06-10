namespace numeros_por_extenso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "0":
                    textBox1.Text = "Zero";
                    break;

                case "1":
                    textBox1.Text = "Um";
                    break;

                case "2":
                    textBox1.Text = "Dois";
                    break;

                case "3":
                    textBox1.Text = "Três";
                    break;

                case "4":
                    textBox1.Text = "Quatro";
                    break;


                case "5":
                    textBox1.Text = "Cinco";
                    break;

                case "6":
                    textBox1.Text = "Seis";
                    break;

                case "7":
                    textBox1.Text = "Sete";
                    break;

                case "8":
                    textBox1.Text = "Oito";
                    break;

                case "9":
                    textBox1.Text = "Nove";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}