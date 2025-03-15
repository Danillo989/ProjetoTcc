namespace ProjetoTcc
{
    partial class Produto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            listaFronecedor = new ComboBox();
            label6 = new Label();
            cadastrar_produto = new Button();
            preco = new TextBox();
            label5 = new Label();
            descricao = new TextBox();
            label4 = new Label();
            qtd_embalagem = new TextBox();
            label3 = new Label();
            embalagem = new TextBox();
            label2 = new Label();
            idproduto = new TextBox();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listaFronecedor);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cadastrar_produto);
            groupBox1.Controls.Add(preco);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(descricao);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(qtd_embalagem);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(embalagem);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(idproduto);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(761, 379);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Produto";
            // 
            // listaFronecedor
            // 
            listaFronecedor.AccessibleRole = AccessibleRole.Caret;
            listaFronecedor.FormattingEnabled = true;
            listaFronecedor.Location = new Point(114, 119);
            listaFronecedor.Name = "listaFronecedor";
            listaFronecedor.Size = new Size(123, 25);
            listaFronecedor.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 127);
            label6.Name = "label6";
            label6.Size = new Size(75, 17);
            label6.TabIndex = 11;
            label6.Text = "Fornecedor";
            // 
            // cadastrar_produto
            // 
            cadastrar_produto.Location = new Point(580, 167);
            cadastrar_produto.Name = "cadastrar_produto";
            cadastrar_produto.Size = new Size(75, 23);
            cadastrar_produto.TabIndex = 10;
            cadastrar_produto.Text = "Cadastrar";
            cadastrar_produto.UseVisualStyleBackColor = true;
            cadastrar_produto.Click += cadastrar_produto_Click;
            // 
            // preco
            // 
            preco.Location = new Point(466, 74);
            preco.Name = "preco";
            preco.Size = new Size(79, 25);
            preco.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(419, 82);
            label5.Name = "label5";
            label5.Size = new Size(41, 17);
            label5.TabIndex = 8;
            label5.Text = "Preço";
            // 
            // descricao
            // 
            descricao.Location = new Point(360, 32);
            descricao.Name = "descricao";
            descricao.Size = new Size(379, 25);
            descricao.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 36);
            label4.Name = "label4";
            label4.Size = new Size(65, 17);
            label4.TabIndex = 6;
            label4.Text = "Descrição";
            // 
            // qtd_embalagem
            // 
            qtd_embalagem.Location = new Point(200, 74);
            qtd_embalagem.Name = "qtd_embalagem";
            qtd_embalagem.Size = new Size(48, 25);
            qtd_embalagem.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 82);
            label3.Name = "label3";
            label3.Size = new Size(168, 17);
            label3.TabIndex = 4;
            label3.Text = "Quantidade da Embalagem";
            // 
            // embalagem
            // 
            embalagem.Location = new Point(349, 74);
            embalagem.Name = "embalagem";
            embalagem.Size = new Size(64, 25);
            embalagem.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 82);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 2;
            label2.Text = "Embalagem";
            // 
            // idproduto
            // 
            idproduto.Location = new Point(134, 31);
            idproduto.Name = "idproduto";
            idproduto.Size = new Size(114, 25);
            idproduto.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 39);
            label1.Name = "label1";
            label1.Size = new Size(102, 17);
            label1.TabIndex = 0;
            label1.Text = "Codigo Produto";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Produto
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Produto";
            Text = "Produto";
            Load += Produto_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox preco;
        private Label label5;
        private TextBox descricao;
        private Label label4;
        private TextBox qtd_embalagem;
        private Label label3;
        private TextBox embalagem;
        private Label label2;
        private TextBox idproduto;
        private Label label1;
        private Button cadastrar_produto;
        private ComboBox listaFronecedor;
        private Label label6;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}