﻿namespace C__aula2
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnFecharGuia = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(334, 24);
            label1.Name = "label1";
            label1.Size = new Size(168, 30);
            label1.TabIndex = 0;
            label1.Text = "1° PROGRAMA";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(168, 147);
            textBox1.MaxLength = 50;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(168, 259);
            textBox2.MaxLength = 2;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 135);
            label2.Name = "label2";
            label2.Size = new Size(104, 35);
            label2.TabIndex = 3;
            label2.Text = "NOME:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(58, 247);
            label3.Name = "label3";
            label3.Size = new Size(108, 35);
            label3.TabIndex = 4;
            label3.Text = "IDADE:";
            // 
            // btnFecharGuia
            // 
            btnFecharGuia.BackColor = SystemColors.ButtonFace;
            btnFecharGuia.DialogResult = DialogResult.Continue;
            btnFecharGuia.ForeColor = SystemColors.ActiveCaptionText;
            btnFecharGuia.Location = new Point(713, 415);
            btnFecharGuia.Name = "btnFecharGuia";
            btnFecharGuia.Size = new Size(75, 23);
            btnFecharGuia.TabIndex = 5;
            btnFecharGuia.Text = "close";
            btnFecharGuia.UseVisualStyleBackColor = false;
            btnFecharGuia.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.DialogResult = DialogResult.Continue;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(613, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnFecharGuia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem pROGRAMAToolStripMenuItem;
        private Button btnFecharGuia;
        private Button button1;
    }
}
