namespace C__aula2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        using System;
using System.Windows.Forms;

namespace FecharGuia
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent(Form1);
            }

            // M�todo que ser� chamado ao clicar no bot�o
            private void btnFecharGuia_Click(object sender, EventArgs e)
            {
                // Fecha a guia ou formul�rio ativo
                this.Close(Form1);
            }
        }
    }

}
}
