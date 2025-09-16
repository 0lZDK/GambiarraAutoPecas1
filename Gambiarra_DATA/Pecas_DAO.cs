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
    public class Pecas_DAO
    {
        private readonly string _conexao;

        public Pecas_DAO(string conexao)
        {
            _conexao = conexao;
        }

        public DataSet BuscarPecas(object busca)
        {
            const string query = @"SELECT * FROM Pecas WHERE nome_peca LIKE @busca OR fabricante LIKE @busca OR modelo LIKE @busca OR marca LIKE @busca";

            try
            {
                using (var conexao = new SqlConnection(_conexao))
                {
                    using (var comando = new SqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@busca", "%" + busca + "%");
                        using (var adaptador = new SqlDataAdapter(comando))
                        {
                            var dsPecas = new DataSet();
                            adaptador.Fill(dsPecas, "Pecas");
                            return dsPecas;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar peça. Detalhes: " + ex.Message);
            }
        }

        public void InserirPecas(Pecas pecas)
        {
            const string query = @"INSERT INTO Pecas (nome_peca, marca, modelo, montadora, fabricante, quantidade)
                                           VALUES (@nome_peca, @marca, @modelo, @montadora, @fabricante, @quantidade)";
            try
            {
                using (SqlConnection conexao = new SqlConnection(_conexao))
                {
                    using (SqlCommand comando = new SqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome_peca", pecas.nome_peca);
                        comando.Parameters.AddWithValue("@marca", pecas.marca);
                        comando.Parameters.AddWithValue("@modelo", pecas.modelo);
                        comando.Parameters.AddWithValue("@montadora", pecas.montadora);
                        comando.Parameters.AddWithValue("@fabricante", pecas.fabricante);
                        comando.Parameters.AddWithValue("@quantidade", pecas.quantidade);
                       
                        conexao.Open();
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir peça. Detalhes: " + ex.Message);
            }
        }
    }
}
