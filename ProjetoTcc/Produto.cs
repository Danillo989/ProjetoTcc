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
    public partial class Produto : Form
    {
        public Produto()
        {
            InitializeComponent();

        }

        private void cadastrar_produto_Click(object sender, EventArgs e)
        {
            try
            {
                BancoDados banco = new BancoDados();

                int produto = Convert.ToInt32(idproduto.Text);
                string emb = embalagem.Text;
                int qtd_emb = Convert.ToInt32(qtd_embalagem.Text);
                string desc = descricao.Text;
                float pr = float.Parse(preco.Text);
                int fornecedor = Convert.ToInt32(listaFronecedor.SelectedValue);
                banco.InsProduto(produto, emb, qtd_emb, desc, pr, fornecedor);


                idproduto.Clear();
                embalagem.Clear();
                qtd_embalagem.Clear();
                descricao.Clear();
                preco.Clear();

                MessageBox.Show("Produto inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao inserir produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void CarregarFornecedores()
        {
            BancoDados banco = new BancoDados();
            List<ConsultaFornecdor> fornecedores = banco.listaFornecedor();

            listaFronecedor.DataSource = fornecedores;
            listaFronecedor.DisplayMember = "nome";  // Nome visível no ComboBox
            listaFronecedor.ValueMember = "id_fornecedor"; // Valor associado ao item
        }



        private void Produto_Load_1(object sender, EventArgs e)
        {
            CarregarFornecedores();
        }
    }



}
