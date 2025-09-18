using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Security.Principal;

namespace Gambiarra_DATA
{

    public class Cliente_DAO
    {
        private readonly string _conexao;

        public Cliente_DAO(string conexao)
        {
            _conexao = conexao;
        }

        public DataSet BuscarCliente(string busca)
        {
            const string query = @"SELECT * FROM Clientes WHERE nome_cliente LIKE @busca OR cpf LIKE @busca";

            try
            {
                using (var conexao = new SqlConnection(_conexao))
                {
                    using (var comando = new SqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@busca", "%" + busca + "%");
                        using (var adaptador = new SqlDataAdapter(comando))
                        {
                            var dsClientes = new DataSet();
                            adaptador.Fill(dsClientes, "Clientes");
                            return dsClientes;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar clientes. Detalhes: " + ex.Message);
            }
        }

        public void InserirCliente(Cliente cliente)
        {
            const string query = @"INSERT INTO Clientes (nome_cliente, cpf, email, veiculo, telefone, logradouro, numero_casa, bairro, cep, complemento)
                                           VALUES (@nome_cliente, @cpf, @email, @veiculo, @telefone, @logradouro, @numero_casa, @bairro, @cep, @complemento)";
            try
            {
                using (SqlConnection conexao = new SqlConnection(_conexao))
                {
                    using (SqlCommand comando = new SqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome_cliente", cliente.nome_cliente);
                        comando.Parameters.AddWithValue("@cpf", cliente.cpf);
                        comando.Parameters.AddWithValue("@email", cliente.email);
                        comando.Parameters.AddWithValue("@veiculo", cliente.veiculo);
                        comando.Parameters.AddWithValue("@telefone", cliente.telefone);
                        comando.Parameters.AddWithValue("@logradouro", cliente.logradouro);
                        comando.Parameters.AddWithValue("@numero_casa", cliente.numero_casa);
                        comando.Parameters.AddWithValue("@bairro", cliente.bairro);
                        comando.Parameters.AddWithValue("@cep", cliente.cep);
                        comando.Parameters.AddWithValue("@complemento", cliente.complemento);
                        conexao.Open();
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir cliente. Detalhes: " + ex.Message);
            }
        }
        public void AlteraCliente(Cliente clientes)
        {
            const string query = @"UPDATE clientes SET nome_cliente = @nome_cliente, cpf = @cpf, email = @email, veiculo = @veiculo,
                                  telefone = @telefone, logradouro = @logradouro, numero_casa = @numero_casa, bairro = bairro, cep = @cep
                                  complemento = @complemento";
            try
            {
                using (var conexaoBD = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBD))
                {
                    comando.Parameters.Add("@nome_cliente", SqlDbType.NVarChar).Value = clientes.nome_cliente ?? (object)DBNull.Value;
                    comando.Parameters.Add("@cpf", SqlDbType.NVarChar).Value = clientes.nome_cliente ?? (object)DBNull.Value;
                    comando.Parameters.Add("@email", SqlDbType.NVarChar).Value = clientes.nome_cliente ?? (object)DBNull.Value;
                    comando.Parameters.Add("@veiculo", SqlDbType.NVarChar).Value = clientes.nome_cliente ?? (object)DBNull.Value;
                    comando.Parameters.Add("@telefone", SqlDbType.NVarChar).Value = clientes.nome_cliente ?? (object)DBNull.Value;
                    comando.Parameters.Add("@logradouro", SqlDbType.NVarChar).Value = clientes.nome_cliente ?? (object)DBNull.Value;
                    comando.Parameters.Add("@numero_casa", SqlDbType.NVarChar).Value = clientes.nome_cliente ?? (object)DBNull.Value;
                    comando.Parameters.Add("@bairro", SqlDbType.NVarChar).Value = clientes.nome_cliente ?? (object)DBNull.Value;
                    comando.Parameters.Add("@cep", SqlDbType.NVarChar).Value = clientes.nome_cliente ?? (object)DBNull.Value;
                    comando.Parameters.Add("@complemento", SqlDbType.NVarChar).Value = clientes.nome_cliente ?? (object)DBNull.Value;

                    conexaoBD.Open();
                    comando.ExecuteNonQuery();

                }
            }
            catch(SqlException ex)
            {
                throw new Exception($"Erro no banco de dados ao alterar Cliente {ex.Message}", ex);
            }
            catch(Exception ex) 
            {
                throw new Exception($"Erro ao alterar dados do Cliente{ex.Message}", ex);
            }



        }

           

            
    }
}
