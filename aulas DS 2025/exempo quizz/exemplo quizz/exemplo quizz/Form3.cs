using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_quizz
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          PONTOS p = new PONTOS();

            if (radioButton4.Checked == true)
            {
                MessageBox.Show("Acertou !!!");
                p.Certo = p.Certo + 1;
            }
            else
            {
                MessageBox.Show("ERROU !!!");
                p.Erro = p.Erro + 1;
            }
        }
    }
}
