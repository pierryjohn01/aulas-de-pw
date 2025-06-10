namespace exemlo_switch_combobox
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
                case "1":
                    textBox1.Text = "Domingo";
                    break;

                case "2":
                    textBox1.Text = "Segunda-Feira";
                    break;

                case "3":
                    textBox1.Text = "Terça-Feira";
                    break;

                case "4":
                    textBox1.Text = "Quarta-Feira";
                    break;

                case "5":
                    textBox1.Text = "Quinta-Feira";
                    break;

                case "6":
                    textBox1.Text = "Sexta-Feira";
                    break;

                case "7":
                    textBox1.Text = "Sábado";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}