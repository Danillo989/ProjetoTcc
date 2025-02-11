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
            BancoDados banco = new();
            SqlConnection conexao = banco.GetConnection();
            {
                try
                {
                    conexao.Open();
                    MessageBox.Show("Conexão bem-sucedida!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}