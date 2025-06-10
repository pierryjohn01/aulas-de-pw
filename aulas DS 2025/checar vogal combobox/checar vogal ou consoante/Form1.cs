namespace checar_vogal_ou_consoante
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
                case "A":
                    textBox1.Text = "Vogal";
                    break;

                case "B":
                    textBox1.Text = "Consoante";
                    break;

                case "C":
                    textBox1.Text = "Consoante";
                    break;

                case "D":
                    textBox1.Text = "Consoante";
                    break;

                case "E":
                    textBox1.Text = "Vogal";
                    break;

                case "F":
                    textBox1.Text = "Consoante";
                    break;

                case "G":
                    textBox1.Text = "Consoante";
                    break;

                case "H":
                    textBox1.Text = "Consoante";
                    break;

                case "I":
                    textBox1.Text = "Vogal";
                    break;

                case "J":
                    textBox1.Text = "Consoante";
                    break;

                case "K":
                    textBox1.Text = "Consoante";
                    break;

                case "L":
                    textBox1.Text = "Consoante";
                    break;

                case "M":
                    textBox1.Text = "Consoante";
                    break;

                case "N":
                    textBox1.Text = "Consoante";
                    break;

                case "O":
                    textBox1.Text = "Vogal";
                    break;

                case "P":
                    textBox1.Text = "Consoante";
                    break;

                case "Q":
                    textBox1.Text = "Consoante";
                    break;

                case "R":
                    textBox1.Text = "Consoante";
                    break;

                case "S":
                    textBox1.Text = "Consoante";
                    break;

                case "T":
                    textBox1.Text = "Consoante";
                    break;

                case "U":
                    textBox1.Text = "Vogal";
                    break;

                case "V":
                    textBox1.Text = "Consoante";
                    break;

                case "W":
                    textBox1.Text = "Consoante";
                    break;

                case "X":
                    textBox1.Text = "Consoante";
                    break;

                case "Y":
                    textBox1.Text = "Consoante";
                    break;

                case "Z":
                    textBox1.Text = "Consoante";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}