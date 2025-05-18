namespace ProjetoTcc
{
    partial class MenuPrincipalcs
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
            Menu = new GroupBox();
            gridproduto = new Button();
            cadastro_produto = new Button();
            Fornecedor = new Button();
            Compras = new Button();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.Controls.Add(Compras);
            Menu.Controls.Add(gridproduto);
            Menu.Controls.Add(cadastro_produto);
            Menu.Controls.Add(Fornecedor);
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(293, 248);
            Menu.TabIndex = 0;
            Menu.TabStop = false;
            Menu.Text = "Menu Principal";
            // 
            // gridproduto
            // 
            gridproduto.Location = new Point(3, 127);
            gridproduto.Name = "gridproduto";
            gridproduto.Size = new Size(154, 35);
            gridproduto.TabIndex = 1;
            gridproduto.Text = "Consulta Produto";
            gridproduto.UseVisualStyleBackColor = true;
            gridproduto.Click += gridproduto_Click;
            // 
            // cadastro_produto
            // 
            cadastro_produto.Location = new Point(0, 85);
            cadastro_produto.Name = "cadastro_produto";
            cadastro_produto.Size = new Size(154, 36);
            cadastro_produto.TabIndex = 1;
            cadastro_produto.Text = "Cadastro Produto";
            cadastro_produto.UseVisualStyleBackColor = true;
            cadastro_produto.Click += cadastro_produto_Click;
            // 
            // Fornecedor
            // 
            Fornecedor.Location = new Point(0, 40);
            Fornecedor.Name = "Fornecedor";
            Fornecedor.Size = new Size(154, 39);
            Fornecedor.TabIndex = 0;
            Fornecedor.Text = "Cadastro Fornecedor";
            Fornecedor.UseVisualStyleBackColor = true;
            Fornecedor.Click += Fornecedor_Click;
            // 
            // Compras
            // 
            Compras.Location = new Point(3, 168);
            Compras.Name = "Compras";
            Compras.Size = new Size(152, 38);
            Compras.TabIndex = 2;
            Compras.Text = "Tela de Compras ";
            Compras.UseVisualStyleBackColor = true;
            Compras.Click += Compras_Click;
            // 
            // MenuPrincipalcs
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Menu);
            Name = "MenuPrincipalcs";
            Text = "MenuPrincipalcs";
            Menu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Menu;
        private Button Fornecedor;
        private Button cadastro_produto;
        private Button gridproduto;
        private Button Compras;
    }
}