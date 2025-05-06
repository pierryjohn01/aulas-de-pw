namespace cruzadinha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "C")
            {
                textBox2.Focus();
            }
            else
            {
                textBox1.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "A")
            {
                textBox3.Focus();
            }
            else
            {
                textBox2.Text = "";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "C")
            {
                textBox4.Focus();
            }
            else
            {
                textBox3.Text = "";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "H")
            {
                textBox5.Focus();
            }
            else
            {
                textBox4.Text = "";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "O")
            {
                textBox6.Focus();
            }
            else
            {
                textBox5.Text = "";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == "R")
            {
                textBox7.Focus();
            }
            else
            {
                textBox6.Text = "";
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text == "O")
            {
                textBox9.Focus();
            }
            else
            {
                textBox8.Text = "";
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "R")
            {
                textBox8.Focus();
            }
            else
            {
                textBox7.Text = "";
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text == "A")
            {
                textBox10.Focus();
            }
            else
            {
                textBox9.Text = "";
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "M")
            {
                textBox11.Focus();
            }
            else
            {
                textBox10.Text = "";
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text == "E")
            {
                textBox12.Focus();
            }
            else
            {
                textBox11.Text = "";
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text == "L")
            {
                textBox13.Focus();
            }
            else
            {
                textBox12.Text = "";
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (textBox13.Text == "O")
            {
                textBox14.Focus();
            }
            else
            {
                textBox13.Text = "";
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (textBox14.Text == "B")
            {
                textBox15.Focus();
            }
            else
            {
                textBox14.Text = "";
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (textBox15.Text == "L")
            {
                textBox16.Focus();
            }
            else
            {
                textBox15.Text = "";
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (textBox16.Text == "A")
            {
                textBox17.Focus();
            }
            else
            {
                textBox16.Text = "";
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (textBox17.Text == "T")
            {
                textBox18.Focus();
            }
            else
            {
                textBox17.Text = "";
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            if (textBox18.Text == "R")
            {
                textBox19.Focus();
            }
            else
            {
                textBox18.Text = "";
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            if (textBox19.Text == "M")
            {
                textBox20.Focus();
            }
            else
            {
                textBox19.Text = "";
            }
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            if (textBox20.Text == "B")
            {
                textBox21.Focus();
            }
            else
            {
                textBox20.Text = "";
            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            if (textBox21.Text == "O")
            {
                textBox22.Focus();
            }
            else
            {
                textBox21.Text = "";
            }
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            if (textBox22.Text == "N")
            {
                textBox23.Focus();
            }
            else
            {
                textBox22.Text = "";
            }
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            if (textBox23.Text == "E")
            {
                textBox24.Focus();
            }
            else
            {
                textBox23.Text = "";
            }
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            if (textBox24.Text == "R")
            {
                textBox25.Focus();
            }
            else
            {
                textBox24.Text = "";
            }
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            if (textBox25.Text == "L")
            {
                textBox26.Focus();
            }
            else
            {
                textBox25.Text = "";
            }
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            if (textBox26.Text == "H")
            {
                textBox27.Focus();
            }
            else
            {
                textBox26.Text = "";
            }
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            if (textBox27.Text == "A")
            {
                MessageBox.Show("Parabéns! Você completou a cruzadinha!!!");
            }
            else
            {
                textBox27.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
            textBox25.Clear();
            textBox26.Clear();
            textBox27.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
