namespace ProjetoTcc
{
    partial class TelaCompras
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
            listaFornecedorCompras = new ComboBox();
            label1 = new Label();
            ProdutosFornecedor = new Button();
            dataGridViewCompras = new DataGridView();
            BotaoCompra = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompras).BeginInit();
            SuspendLayout();
            // 
            // listaFornecedorCompras
            // 
            listaFornecedorCompras.FormattingEnabled = true;
            listaFornecedorCompras.Location = new Point(208, 5);
            listaFornecedorCompras.Name = "listaFornecedorCompras";
            listaFornecedorCompras.Size = new Size(205, 25);
            listaFornecedorCompras.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveCaption;
            label1.Font = new Font("Arial Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(190, 18);
            label1.TabIndex = 1;
            label1.Text = "Fornecedor Para Compra";
            label1.Click += label1_Click;
            // 
            // ProdutosFornecedor
            // 
            ProdutosFornecedor.Location = new Point(419, 5);
            ProdutosFornecedor.Name = "ProdutosFornecedor";
            ProdutosFornecedor.Size = new Size(75, 23);
            ProdutosFornecedor.TabIndex = 2;
            ProdutosFornecedor.Text = "Consulta Fornecedor";
            ProdutosFornecedor.UseVisualStyleBackColor = true;
            ProdutosFornecedor.Click += ProdutosFornecedor_Click;
            // 
            // dataGridViewCompras
            // 
            dataGridViewCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCompras.Location = new Point(3, 73);
            dataGridViewCompras.Name = "dataGridViewCompras";
            dataGridViewCompras.RowTemplate.Height = 27;
            dataGridViewCompras.Size = new Size(993, 337);
            dataGridViewCompras.TabIndex = 3;
            // 
            // BotaoCompra
            // 
            BotaoCompra.BackColor = Color.Red;
            BotaoCompra.Font = new Font("Arial Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BotaoCompra.ForeColor = SystemColors.ButtonHighlight;
            BotaoCompra.Location = new Point(873, 416);
            BotaoCompra.Name = "BotaoCompra";
            BotaoCompra.Size = new Size(111, 36);
            BotaoCompra.TabIndex = 4;
            BotaoCompra.Text = "COMPRAR";
            BotaoCompra.TextImageRelation = TextImageRelation.TextBeforeImage;
            BotaoCompra.UseVisualStyleBackColor = false;
            BotaoCompra.Click += BotaoCompra_Click;
            // 
            // TelaCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 459);
            Controls.Add(BotaoCompra);
            Controls.Add(dataGridViewCompras);
            Controls.Add(ProdutosFornecedor);
            Controls.Add(label1);
            Controls.Add(listaFornecedorCompras);
            Name = "TelaCompras";
            Text = "TelaCompras";
            Load += Produto_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox listaFornecedorCompras;
        private Label label1;
        private Button ProdutosFornecedor;
        private DataGridView dataGridViewCompras;
        private Button BotaoCompra;
    }
}