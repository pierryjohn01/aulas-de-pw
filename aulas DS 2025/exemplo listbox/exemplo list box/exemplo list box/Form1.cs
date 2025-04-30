namespace exemplo_list_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
                MessageBox.Show("você deve selecionar um item a excluir");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

