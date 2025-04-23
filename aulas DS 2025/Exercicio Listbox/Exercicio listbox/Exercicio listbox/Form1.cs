namespace Exercicio_listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string precoText = txtPreco.Text;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(precoText))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            if (!decimal.TryParse(precoText, out decimal preco))
            {
                MessageBox.Show("Preço inválido. Digite um número válido.");
                return;
            }

            string item = $"{nome} - R$ {preco:F2}";
            lstProdutos.Items.Add(item);

            // Limpar campos após adicionar
            txtNome.Clear();
            txtPreco.Clear();
            txtNome.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lstProdutos.SelectedIndex != -1)
            {
                lstProdutos.Items.RemoveAt(lstProdutos.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecione um item para excluir.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtPreco.Clear();
            lstProdutos.Items.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
