
namespace ProjetoTcc
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
            groupBox1 = new GroupBox();
            Cadastrar_Fornecedor = new Button();
            telefone = new TextBox();
            label5 = new Label();
            nome = new TextBox();
            label4 = new Label();
            endereco = new TextBox();
            label3 = new Label();
            cnpj = new TextBox();
            label2 = new Label();
            Id_Fornecedor = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Cadastrar_Fornecedor);
            groupBox1.Controls.Add(telefone);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(nome);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(endereco);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cnpj);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Id_Fornecedor);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(36, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(864, 385);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro Fornecedor";
            // 
            // Cadastrar_Fornecedor
            // 
            Cadastrar_Fornecedor.BackColor = Color.FromArgb(128, 255, 128);
            Cadastrar_Fornecedor.ForeColor = SystemColors.ActiveCaptionText;
            Cadastrar_Fornecedor.Location = new Point(631, 269);
            Cadastrar_Fornecedor.Name = "Cadastrar_Fornecedor";
            Cadastrar_Fornecedor.Size = new Size(75, 23);
            Cadastrar_Fornecedor.TabIndex = 10;
            Cadastrar_Fornecedor.Text = "Cadastrar";
            Cadastrar_Fornecedor.UseVisualStyleBackColor = false;
            Cadastrar_Fornecedor.Click += Cadastrar_Fornecedor_Click;
            // 
            // telefone
            // 
            telefone.Location = new Point(69, 164);
            telefone.Name = "telefone";
            telefone.Size = new Size(147, 25);
            telefone.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 167);
            label5.Name = "label5";
            label5.Size = new Size(57, 17);
            label5.TabIndex = 8;
            label5.Text = "Telefone";
            // 
            // nome
            // 
            nome.Location = new Point(130, 112);
            nome.Name = "nome";
            nome.Size = new Size(576, 25);
            nome.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 120);
            label4.Name = "label4";
            label4.Size = new Size(118, 17);
            label4.TabIndex = 6;
            label4.Text = "Nome da Empresa";
          
            // 
            // endereco
            // 
            endereco.Location = new Point(75, 67);
            endereco.Name = "endereco";
            endereco.Size = new Size(631, 25);
            endereco.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 75);
            label3.Name = "label3";
            label3.Size = new Size(63, 17);
            label3.TabIndex = 4;
            label3.Text = "Endereço";
            // 
            // cnpj
            // 
            cnpj.Location = new Point(285, 23);
            cnpj.Name = "cnpj";
            cnpj.Size = new Size(199, 25);
            cnpj.TabIndex = 3;
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 31);
            label2.Name = "label2";
            label2.Size = new Size(37, 17);
            label2.TabIndex = 2;
            label2.Text = "CNPJ";
           
            // 
            // Id_Fornecedor
            // 
            Id_Fornecedor.Location = new Point(101, 23);
            Id_Fornecedor.Name = "Id_Fornecedor";
            Id_Fornecedor.Size = new Size(115, 25);
            Id_Fornecedor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 31);
            label1.Name = "label1";
            label1.Size = new Size(95, 17);
            label1.TabIndex = 0;
            label1.Text = "ID Formecedor";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox Id_Fornecedor;
        private Label label2;
        private TextBox cnpj;
        private TextBox endereco;
        private Label label3;
        private Label label4;
        private TextBox nome;
        private TextBox telefone;
        private Label label5;
        private Button Cadastrar_Fornecedor;
    }
}