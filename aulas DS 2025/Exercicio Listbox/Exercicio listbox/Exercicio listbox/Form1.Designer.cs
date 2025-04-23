namespace Exercicio_listbox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            txtPreco = new TextBox();
            lstProdutos = new ListBox();
            btnAdicionar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 32);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 95);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Preço";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(96, 29);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(151, 23);
            txtNome.TabIndex = 2;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(96, 92);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(151, 23);
            txtPreco.TabIndex = 3;
            // 
            // lstProdutos
            // 
            lstProdutos.FormattingEnabled = true;
            lstProdutos.ItemHeight = 15;
            lstProdutos.Location = new Point(351, 29);
            lstProdutos.Name = "lstProdutos";
            lstProdutos.Size = new Size(195, 274);
            lstProdutos.TabIndex = 4;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(40, 145);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(172, 145);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(351, 329);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(471, 329);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 8;
            btnFechar.Text = "Sair";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFechar);
            Controls.Add(btnLimpar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAdicionar);
            Controls.Add(lstProdutos);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtPreco;
        private ListBox lstProdutos;
        private Button btnAdicionar;
        private Button btnExcluir;
        private Button btnLimpar;
        private Button btnFechar;
    }
}
