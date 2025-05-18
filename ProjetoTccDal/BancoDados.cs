using System;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Data.Common;
using System.Collections.Generic;
using static System.Formats.Asn1.AsnWriter;
using System.Data;

namespace ProjetoTccDal
{
    public class BancoDados
    {
        public string _connectionString { get; set; }

        protected DbConnection sConn = null;




        public SqlConnection GetConnection()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;

            return new SqlConnection(_connectionString);
        }


        public void Conectar()
        {
            try {

                BancoDados banco = new();
                SqlConnection conexao = banco.GetConnection();
                conexao.Open();
               

                if (sConn == null)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;
                    sConn = new SqlConnection(connectionString); // Inicializa a conexão
                }

                if (sConn.State != ConnectionState.Open)
                {
                    sConn.Open();
                }

            }
           catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Finalizar()
        {
            try
            {
                BancoDados banco = new();
                SqlConnection conexao = banco.GetConnection();
                conexao.Close();
               sConn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public void InsFornecedor(string Id_fornecedor, string cnpj, string endereco, string nome, string telefone)
        {
            Conectar();

            try
            {

                if (sConn == null)
                    throw new Exception("Erro: Conexão com o banco de dados não foi inicializada.");

                using (DbCommand cmd = sConn.CreateCommand())
                {
                    DbParameterCollection cmdParams = cmd.Parameters;

                    DbParameter par_Id_fornecedor = cmd.CreateParameter();
                    par_Id_fornecedor.ParameterName = "@Id_fornecedor";
                    par_Id_fornecedor.Value = Id_fornecedor;
                    cmdParams.Add(par_Id_fornecedor);


                    DbParameter par_cnpj = cmd.CreateParameter();
                    par_cnpj.ParameterName = "@cnpj";
                    par_cnpj.Value = cnpj;
                    cmdParams.Add(par_cnpj);

                    DbParameter par_endereco = cmd.CreateParameter();
                    par_endereco.ParameterName = "@Endereco";
                    par_endereco.Value = endereco;
                    cmdParams.Add(par_endereco);

                    DbParameter par_nome = cmd.CreateParameter();
                    par_nome.ParameterName = "@nome";
                    par_nome.Value = nome;
                    cmdParams.Add(par_nome);

                    DbParameter par_telefone = cmd.CreateParameter();
                    par_telefone.ParameterName = "@telefone";
                    par_telefone.Value = telefone;
                    cmdParams.Add(par_telefone);

                    cmd.CommandText = "ERP_PRODUTOS_INS_FORNECEDOR";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();

                }

            }

            catch (Exception ex) {

                throw new Exception();
            }

            Finalizar();

        }


        public void InsProduto(int id_produto, string embalagem, int qtd_embalagem,string descricao, float preco, int id_formecedor)
        {

            Conectar();
            try
            {
                using (DbCommand cmd = sConn.CreateCommand())
                {
                    DbParameterCollection cmdParams = cmd.Parameters;

                    DbParameter par_id_produto = cmd.CreateParameter();
                    par_id_produto.ParameterName = "@ID_PRODUTO";
                    par_id_produto.Value = id_produto;
                    cmdParams.Add(par_id_produto);

                    DbParameter par_embalagem = cmd.CreateParameter();
                    par_embalagem.ParameterName = "@EMBALAGEM";
                    par_embalagem.Value = embalagem;
                    cmdParams.Add(par_embalagem);

                    DbParameter par_qtd_embalagem = cmd.CreateParameter();
                    par_qtd_embalagem.ParameterName = "@QTD_EMBALAGEM";
                    par_qtd_embalagem.Value = qtd_embalagem;
                    cmdParams.Add(par_qtd_embalagem);

                    DbParameter par_descricao = cmd.CreateParameter();
                    par_descricao.ParameterName = "@DESCRICAO";
                    par_descricao.Value = descricao;
                    cmdParams.Add(par_descricao);

                    DbParameter par_preco = cmd.CreateParameter();
                    par_preco.ParameterName = "@preco";
                    par_preco.Value = preco;
                    cmdParams.Add(par_preco);

                    DbParameter par_id_formecedor = cmd.CreateParameter();
                    par_id_formecedor.ParameterName = "@ID_FORNECEDOR";
                    par_id_formecedor.Value = id_formecedor;
                    cmdParams.Add(par_id_formecedor);


                    cmd.CommandText = "ERP_PRODUTOS_INS_PRODUTOS";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();

                }


            }
            catch (Exception ex)
            {
                throw new Exception();
            }

            Finalizar();
        }



        public   List<ConsultaProduto> ConsultaProdutoGrid(string produto)
        {
            List<ConsultaProduto> lst = new List<ConsultaProduto>();
            Conectar();
            try
            {


                
                using (DbCommand cmd = sConn.CreateCommand())
                {
                 

                    DbParameterCollection cmdParams = cmd.Parameters;

                    DbParameter par_id_produto = cmd.CreateParameter();
                    par_id_produto.ParameterName = "@PLU";
                    par_id_produto.Value = produto;
                    cmdParams.Add(par_id_produto);

                    cmd.CommandText = "CONSULTA_PRODUTO";
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ConsultaProduto item = new ConsultaProduto();

                            if (!dr.IsDBNull(0))
                                item.Id_Produto = Convert.ToString(dr[0]);

                            if (!dr.IsDBNull(1))
                                item.Descricao = Convert.ToString(dr[1]);

                            if (!dr.IsDBNull(2))
                                item.Embalagem = Convert.ToString(dr[2]);
                            if (!dr.IsDBNull(3))
                                item.Qtd_Embalagem = Convert.ToString(dr[3]);

                            if (!dr.IsDBNull(4))
                                item.Preco = Convert.ToString(dr[4]);

                            if (!dr.IsDBNull(5))
                                item.Id_Fornecedor = Convert.ToString(dr[5]);

                            if (!dr.IsDBNull(6))
                                item.Nome = Convert.ToString(dr[6]);

                            lst.Add(item);

                        }
                    }

                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally { Finalizar(); }

            return lst;
        }





        public List<ConsultaFornecdor> listaFornecedor()
        {
            List<ConsultaFornecdor> lst = new List<ConsultaFornecdor>();
            Conectar();
            try
            {

                using (DbCommand cmd = sConn.CreateCommand())
                {
                    DbParameterCollection cmdParams = cmd.Parameters;
                    cmd.CommandText = "CosultaFornecedor";
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ConsultaFornecdor item = new ConsultaFornecdor();

                            if (!dr.IsDBNull(0))
                                item.id_fornecedor = Convert.ToString(dr[0]);

                            if (!dr.IsDBNull(1))
                                item.nome = Convert.ToString(dr[1]);

                            lst.Add(item);

                        }
                    }

                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally { Finalizar(); }

            return lst;
        }



        public List<ConsultaProduto> ConsultaFornecedorCompraGrid(int fornecedor)
        {
            List<ConsultaProduto> lst = new List<ConsultaProduto>();
            Conectar();
            try
            {



                using (DbCommand cmd = sConn.CreateCommand())
                {


                    DbParameterCollection cmdParams = cmd.Parameters;

                    DbParameter par_id_produto = cmd.CreateParameter();
                    par_id_produto.ParameterName = "@FORNECEDOR";
                    par_id_produto.Value = fornecedor;
                    cmdParams.Add(par_id_produto);

                    cmd.CommandText = "CONSULTA_COMPRA";
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ConsultaProduto item = new ConsultaProduto();

                            if (!dr.IsDBNull(0))
                                item.Id_Produto = Convert.ToString(dr[0]);

                            if (!dr.IsDBNull(1))
                                item.Descricao = Convert.ToString(dr[1]);

                            if (!dr.IsDBNull(2))
                                item.Embalagem = Convert.ToString(dr[2]);
                            if (!dr.IsDBNull(3))
                                item.Qtd_Embalagem = Convert.ToString(dr[3]);

                            if (!dr.IsDBNull(4))
                                item.Preco = Convert.ToString(dr[4]);

                            if (!dr.IsDBNull(5))
                                item.Id_Fornecedor = Convert.ToString(dr[5]);

                            if (!dr.IsDBNull(6))
                                item.Nome = Convert.ToString(dr[6]);

                            if (!dr.IsDBNull(7))
                                item.Estoque = Convert.ToString(dr[7]);

                            lst.Add(item);

                        }
                    }

                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally { Finalizar(); }

            return lst;
        }


        public void InsEstoque(int id_produto,int estoque )
        {

            Conectar();
            try
            {
                using (DbCommand cmd = sConn.CreateCommand())
                {
                    DbParameterCollection cmdParams = cmd.Parameters;

                    DbParameter par_id_produto = cmd.CreateParameter();
                    par_id_produto.ParameterName = "@ID_PRODUTO";
                    par_id_produto.Value = id_produto;
                    cmdParams.Add(par_id_produto);

                    DbParameter par_estoque = cmd.CreateParameter();
                    par_estoque.ParameterName = "@ESTOQUE";
                    par_estoque.Value = estoque;
                    cmdParams.Add(par_estoque);



                    cmd.CommandText = "INS_ESTOQUE";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();

                }


            }
            catch (Exception ex)
            {
                throw new Exception();
            }

            Finalizar();
        }









    }
}