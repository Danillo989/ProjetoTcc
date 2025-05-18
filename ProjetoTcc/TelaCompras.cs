using ProjetoTccDal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetoTcc
{
    public partial class TelaCompras : Form
    {
        public TelaCompras()
        {
            InitializeComponent();
        }


        private void Produto_Load_1(object sender, EventArgs e)
        {
            CarregarFornecedores();


        }

        private void CarregarFornecedores()
        {
            BancoDados banco = new BancoDados();
            List<ConsultaFornecdor> fornecedores = banco.listaFornecedor();

            listaFornecedorCompras.DataSource = fornecedores;
            listaFornecedorCompras.DisplayMember = "nome";  // Nome visível no ComboBox
            listaFornecedorCompras.ValueMember = "id_fornecedor"; // Valor associado ao item

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void ProdutosFornecedor_Click()
        {
            BancoDados x = new BancoDados();
            DataTable tabela = new DataTable();

            dataGridViewCompras.ClearSelection();



                int id = Convert.ToInt32(listaFornecedorCompras.SelectedValue);
                var produto = x.ConsultaFornecedorCompraGrid(id);
                dataGridViewCompras.DataSource = produto;


            if (!dataGridViewCompras.Columns.Contains("Compra"))
            {
                tabela.Columns.Add();
                DataGridViewTextBoxColumn colunaCompra = new DataGridViewTextBoxColumn();
                colunaCompra.Name = "Compra";
                colunaCompra.HeaderText = "Compra";
                colunaCompra.ValueType = typeof(int);
                dataGridViewCompras.Columns.Add(colunaCompra);
            }
            

        }

        private void BotaoCompra_Click(object sender, EventArgs e)
        {


            BancoDados x = new BancoDados();

            foreach (DataGridViewRow row in dataGridViewCompras.Rows)
            {
                // Ignora a linha em branco no final (caso AllowUserToAddRows esteja ativado)
                if (row.IsNewRow)
                    continue;

                // Pega o ID do produto
                var idValue = row.Cells["id_produto"].Value;
                // Pega o valor do estoque da coluna "Compra"
                var estoqueValue = row.Cells["Compra"].Value;

                // Verifica se os valores são válidos antes de converter
                if (idValue != null && estoqueValue != null && int.TryParse(estoqueValue.ToString(), out int estoque))
                {
                    int idProduto = Convert.ToInt32(idValue);

                    // Chama o método para inserir no estoque
                    x.InsEstoque(idProduto, estoque);
                }
            }

            MessageBox.Show("Estoque atualizado com sucesso!");

            dataGridViewCompras.Columns.Clear();

            ProdutosFornecedor_Click();

        }
    }
}
