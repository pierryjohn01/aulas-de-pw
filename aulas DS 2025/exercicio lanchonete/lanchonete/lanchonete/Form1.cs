using System.Windows.Forms;

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
            double total, qntd;
            total = 0;
            msg = " - Tipo de Recheio =  " + comboBox1.Text;
            total = total + valorrecheio;
            msg = msg + " - Tipo de Pão = " + comboBox2.Text;
            total = total + valorpao;
            msg = msg + " - Sabores de Suco = ";
            msg = msg + " - Refrigerante = ";
            msg = msg + " - Cerveja = ";
            msg = msg + " - Batida = ";
            msg = msg + " - Bomboms = ";
            msg = msg + " - Tortas = ";
            msg = msg + " - Sorvetes = ";
            qntd = double.Parse(textBox1.Text);


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
            msg = msg + " - Total = R$" + total * qntd;
            MessageBox.Show(msg);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int op;
            op = comboBox1.SelectedIndex;
            switch (op)
            {
                case 0:
                    valorrecheio = 1.5;
                    break;
                case 1:
                    valorrecheio = 2.2;
                    break;
                case 2:
                    valorrecheio = 2.0;
                    break;
                case 3:
                    valorrecheio = 1.2;
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int op2;
            op2 = comboBox2.SelectedIndex;
            switch (op2)
            {
                case 0:
                    valorpao = 0.3;
                    break;
                case 1:
                    valorpao = 0.5;
                    break;
                case 2:
                    valorpao = 0.4;
                    break;
                case 3:
                    valorpao = 0.35;
                    break;
                case 4:
                    valorpao = 0.35;
                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Lanches")
            {
                comboBox1.Text = "";
                comboBox2.Text = "";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                textBox1.Text = "";
            }
            if (tabControl1.SelectedTab.Text == "Bebidas")
            {
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                checkBox18.Checked = false;
                checkBox19.Checked = false;
                checkBox20.Checked = false;
                checkBox21.Checked = false;
                checkBox22.Checked = false;
                checkBox23.Checked = false;
                checkBox24.Checked = false;
                checkBox25.Checked = false;
                checkBox26.Checked = false;
                checkBox27.Checked = false;
            }
            checkBox28.Checked = false;
            if (tabControl1.SelectedTab.Text == "Doces")
            {
                checkBox28.Checked = false;
                checkBox29.Checked = false;
                checkBox30.Checked = false;
                checkBox31.Checked = false;
                checkBox32.Checked = false;
                checkBox33.Checked = false;
                checkBox34.Checked = false;
                checkBox35.Checked = false;
                checkBox36.Checked = false;
                checkBox37.Checked = false;
                checkBox38.Checked = false;
                checkBox39.Checked = false;
                checkBox40.Checked = false;
                checkBox41.Checked = false;
                checkBox42.Checked = false;
                checkBox43.Checked = false;
                checkBox44.Checked = false;
                checkBox45.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
