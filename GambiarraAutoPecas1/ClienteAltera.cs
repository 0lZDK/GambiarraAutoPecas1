using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gambiarra_DATA;

namespace GambiarraAutoPecas1
{
    public partial class ClienteAltera : Form
    {
        string _conexao = GambiarraAutoPecas1.Properties.Settings.Default.conexao;
        public ClienteAltera(int codigo)
        {
            InitializeComponent();
            if(codigo >0)
            {
                Cliente cliente = new Cliente();

                Cliente_DAO clienteDao = new Cliente_DAO(_conexao);

                if (cliente == null )
                {
                    MessageBox.Show("Cliente não encontrado","Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txbBairro.Text = cliente.bairro;
                    txbComplemento.Text = cliente.complemento;
                    txbEmail.Text = cliente.email;
                    txbLogradouro.Text = cliente.logradouro;
                    txbNome.Text = cliente.nome_cliente;
                    txbNumero.Text = cliente.numero_casa.ToString();
                    txbVeic.Text = cliente.veiculo;
                    mtbCep.Text = cliente.cep.ToString();
                    mtbCpf.Text = cliente.cpf.ToString();
                    mtbTel.Text = cliente.telefone.ToString();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            Cliente_DAO clienteDao = new Cliente_DAO(_conexao);

            try
            {
                cliente.bairro = txbBairro.Text;
                cliente.complemento = txbComplemento.Text;
                cliente.email = txbEmail.Text;
                cliente.logradouro = txbLogradouro.Text;
                cliente.nome_cliente = txbNome.Text;
                cliente.numero_casa = txbNumero.Text;
                cliente.veiculo = txbVeic.Text;
                cliente.cep = mtbCep.Text;     
                cliente.cpf = mtbCpf.Text;
                cliente.telefone = mtbTel.Text;
                
                int codigo = Convert.ToInt32(lblCod.Text);

                cliente.idcliente = codigo;
                clienteDao.AlteraCliente(cliente);

                this.Close();

            }
            catch(Exception Erro)
            {
                MessageBox.Show("Ocorreu um Erro "+ Erro," Atenção", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
