using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.Sql;
using Gambiarra_DATA;
using System.Security.Permissions;

namespace GambiarraAutoPecas1
{
    public partial class TelaClienteLoja : Form
    {
        string _conexao = GambiarraAutoPecas1.Properties.Settings.Default.conexao;

        public TelaClienteLoja()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelaClienteLoja_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            Cliente_DAO cliente_DAO = new Cliente_DAO(_conexao);

            if (txbNome.Text == "" || mtbCpf.Text == "" || txbEmail.Text == "" || txbVeic.Text == "" || mtbTel.Text == "" || txbLogradouro.Text == "" || txbNumero.Text == "" || txbBairro.Text == "" || mtbCep.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    cliente.nome_cliente = txbNome.Text;
                    cliente.cpf = mtbCpf.Text;
                    cliente.email = txbEmail.Text;
                    cliente.veiculo = txbVeic.Text;
                    cliente.telefone = mtbTel.Text;
                    cliente.logradouro = txbLogradouro.Text;
                    cliente.numero_casa = txbNumero.Text;
                    cliente.bairro = txbBairro.Text;
                    cliente.cep = mtbCep.Text;
                    cliente.complemento = txbComplemento.Text;
                    cliente_DAO.InserirCliente(cliente);
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbNome.Clear();
                    mtbCpf.Clear();
                    txbEmail.Clear();
                    txbVeic.Clear();
                    mtbTel.Clear();
                    txbLogradouro.Clear();
                    txbNumero.Clear();
                    txbBairro.Clear();
                    mtbCep.Clear();
                    txbComplemento.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar o cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

