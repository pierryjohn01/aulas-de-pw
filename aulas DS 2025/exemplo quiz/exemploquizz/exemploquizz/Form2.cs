using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemploquizz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PONTOS p = new PONTOS();

            if (radioButton2.Checked == true)
            {
                MessageBox.Show("ACERTOU !!!");
                p.Certo = p.Certo + 1;
            }
            else
            {
                MessageBox.Show("ERROU !!!");
                p.Erro = p.Erro + 1;
            }
            Form3 tela = new Form3();
            tela.Show();
            this.Hide();
        }
    }
}
