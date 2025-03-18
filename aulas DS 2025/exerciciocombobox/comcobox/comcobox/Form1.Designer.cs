namespace comcobox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            comboBox3 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pão de Alho Recheado com Queijo", "Linguiça Artesanal com Molho de Mostarda e Mel", "Bruschettas de Tomate e Manjericão", "Espetinho de Queijo Coalho com Melado de Cana", "Ceviche de Peixe Branco" });
            comboBox1.Location = new Point(140, 222);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(315, 23);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(140, 181);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 1;
            label1.Text = "ENTRADA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(140, 270);
            label2.Name = "label2";
            label2.Size = new Size(174, 25);
            label2.TabIndex = 2;
            label2.Text = "PRATO PRINCIPAL";
            // 
            // comboBox2
            // 
            comboBox2.FlatStyle = FlatStyle.Popup;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Costela no Bafo", "Picanha Grelhada com Alho e Alecrim", "Frango Caipira Grelhado com Molho de Laranja e Mostarda", "Churrasco de Cordeiro com Molho de Hortelã", "Espetinho Misto de Carne, Frango e Legumes" });
            comboBox2.Location = new Point(140, 309);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(315, 23);
            comboBox2.TabIndex = 3;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(1038, 185);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 4;
            button1.Text = "MOSTRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(1094, 553);
            button2.Name = "button2";
            button2.Size = new Size(121, 42);
            button2.TabIndex = 5;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(1283, 553);
            button3.Name = "button3";
            button3.Size = new Size(121, 42);
            button3.TabIndex = 6;
            button3.Text = "Sair";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(138, 366);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 8;
            label3.Text = "SOBREMESA";
            // 
            // comboBox3
            // 
            comboBox3.FlatStyle = FlatStyle.Popup;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Pudim de Leite Condensado", "Mousse de Maracujá", "Torta de Limão com Merengue", "Churros Recheados com Doce de Leite", "Cocada Cremosa" });
            comboBox3.Location = new Point(138, 394);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(317, 23);
            comboBox3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Location = new Point(1038, 247);
            label4.Name = "label4";
            label4.Size = new Size(10, 15);
            label4.TabIndex = 10;
            label4.Text = " ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Location = new Point(1038, 280);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Location = new Point(1038, 309);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1492, 645);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox3);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
        private ComboBox comboBox3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
