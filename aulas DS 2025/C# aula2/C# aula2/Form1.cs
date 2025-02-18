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

            // Método que será chamado ao clicar no botão
            private void btnFecharGuia_Click(object sender, EventArgs e)
            {
                // Fecha a guia ou formulário ativo
                this.Close(Form1);
            }
        }
    }

}
}
