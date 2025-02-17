using ProjetoTccDal;
using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace ProjetoTcc
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //BancoDados banco = new();
            //SqlConnection conexao = banco.GetConnection();
            //{
            //    try
            //    {
            //        conexao.Open();
            //        MessageBox.Show("Conexão bem-sucedida!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Erro ao conectar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}

        }


        private void Cadastrar_Fornecedor_Click(object sender, EventArgs e)
        {

            BancoDados banco = new BancoDados();

            if (Id_Fornecedor.Text.Equals("") || cnpj.Text.Equals("") || endereco.Text.Equals("") || nome.Text.Equals("") || telefone.Text.Equals(""))
            {
                Exception ex = new Exception();


                MessageBox.Show("Favor preencher Todos os campos " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
             
            if (cnpj.Text.Length != 14  )
            {
                Exception ex = new Exception();


                MessageBox.Show("CNPJ incorreto (Favor Digitar so os numeros)" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            try
            {
                banco.InsFornecedor(Id_Fornecedor.Text, cnpj.Text, endereco.Text, nome.Text, telefone.Text);
                MessageBox.Show("FORNECEDOR CADASTRADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("FORNECEDOR NÃO CADASTRADO " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          

            Id_Fornecedor.Clear();
            cnpj.Clear();
            endereco.Clear();
            nome.Clear();
            telefone.Clear();

          

        }

  
    }
}