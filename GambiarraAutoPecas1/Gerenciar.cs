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
    public partial class Gerenciar : Form
    {
        string _conexao = GambiarraAutoPecas1.Properties.Settings.Default.conexao;
        public Gerenciar()
        {
            InitializeComponent();
            Listar();

            ConfiguraDtg();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlteraPecas_Click(object sender, EventArgs e)
        {

        }
        private void ConfiguraDtg()
        {
            dtgAlteraBuscaPecas.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dtgAlteraBuscaPecas.RowHeadersWidth = 25;

            dtgAlteraBuscaPecas.Columns["idpecas"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgAlteraBuscaPecas.Columns["idpecas"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaPecas.Columns["idpecas"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaPecas.Columns["idpecas"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgAlteraBuscaPecas.Columns["idpecas"].HeaderText = "ID";

            dtgAlteraBuscaPecas.Columns["nome_peca"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgAlteraBuscaPecas.Columns["nome_peca"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaPecas.Columns["nome_peca"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaPecas.Columns["nome_peca"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgAlteraBuscaPecas.Columns["nome_peca"].HeaderText = "Nome";

            dtgAlteraBuscaPecas.Columns["marca"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgAlteraBuscaPecas.Columns["marca"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaPecas.Columns["marca"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaPecas.Columns["marca"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgAlteraBuscaPecas.Columns["marca"].HeaderText = "marca";

            dtgAlteraBuscaPecas.Columns["modelo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgAlteraBuscaPecas.Columns["modelo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaPecas.Columns["modelo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaPecas.Columns["modelo"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgAlteraBuscaPecas.Columns["modelo"].HeaderText = "modelo";

            dtgAlteraBuscaPecas.Columns["montadora"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgAlteraBuscaPecas.Columns["montadora"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaPecas.Columns["montadora"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaPecas.Columns["montadora"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgAlteraBuscaPecas.Columns["montadora"].HeaderText = "montadora";

            dtgAlteraBuscaPecas.Columns["fabricante"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgAlteraBuscaPecas.Columns["fabricante"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaPecas.Columns["fabricante"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaPecas.Columns["fabricante"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgAlteraBuscaPecas.Columns["fabricante"].HeaderText = "fabricante";

            dtgAlteraBuscaPecas.Columns["quantidade"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgAlteraBuscaPecas.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaPecas.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaPecas.Columns["quantidade"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgAlteraBuscaPecas.Columns["quantidade"].HeaderText = "Quantidade";


            dtgAlteraBuscaCli.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dtgAlteraBuscaCli.RowHeadersWidth = 25;

            dtgAlteraBuscaCli.Columns["idcliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgAlteraBuscaCli.Columns["idcliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaCli.Columns["idcliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaCli.Columns["idcliente"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgAlteraBuscaCli.Columns["idcliente"].HeaderText = "ID";

            dtgAlteraBuscaCli.Columns["nome_cliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgAlteraBuscaCli.Columns["nome_cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaCli.Columns["nome_cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaCli.Columns["nome_cliente"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgAlteraBuscaCli.Columns["nome_cliente"].HeaderText = "Nome";

            dtgAlteraBuscaCli.Columns["cpf"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgAlteraBuscaCli.Columns["cpf"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaCli.Columns["cpf"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaCli.Columns["cpf"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgAlteraBuscaCli.Columns["cpf"].HeaderText = "CPF";

            dtgAlteraBuscaCli.Columns["email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgAlteraBuscaCli.Columns["email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaCli.Columns["email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaCli.Columns["email"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgAlteraBuscaCli.Columns["email"].HeaderText = "E-mail";

            dtgAlteraBuscaCli.Columns["veiculo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgAlteraBuscaCli.Columns["veiculo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaCli.Columns["veiculo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaCli.Columns["veiculo"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgAlteraBuscaCli.Columns["veiculo"].HeaderText = "Veículo";

            dtgAlteraBuscaCli.Columns["telefone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgAlteraBuscaCli.Columns["telefone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaCli.Columns["telefone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaCli.Columns["telefone"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgAlteraBuscaCli.Columns["telefone"].HeaderText = "Telefone";

            dtgAlteraBuscaCli.Columns["logradouro"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgAlteraBuscaCli.Columns["logradouro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaCli.Columns["logradouro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaCli.Columns["logradouro"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgAlteraBuscaCli.Columns["logradouro"].HeaderText = "Logradouro";

            dtgAlteraBuscaCli.Columns["numero_casa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgAlteraBuscaCli.Columns["numero_casa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaCli.Columns["numero_casa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaCli.Columns["numero_casa"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgAlteraBuscaCli.Columns["numero_casa"].HeaderText = "Nº";

            dtgAlteraBuscaCli.Columns["bairro"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgAlteraBuscaCli.Columns["bairro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaCli.Columns["bairro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaCli.Columns["bairro"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgAlteraBuscaCli.Columns["bairro"].HeaderText = "Bairro";

            dtgAlteraBuscaCli.Columns["cep"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgAlteraBuscaCli.Columns["cep"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaCli.Columns["cep"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaCli.Columns["cep"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgAlteraBuscaCli.Columns["cep"].HeaderText = "CEP";

            dtgAlteraBuscaCli.Columns["complemento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgAlteraBuscaCli.Columns["complemento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaCli.Columns["complemento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgAlteraBuscaCli.Columns["complemento"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgAlteraBuscaCli.Columns["complemento"].HeaderText = "Complemento";
        }

        private void Listar()
        {
            Pecas_DAO pecas_DAO = new Pecas_DAO(_conexao);

            string busca = txbAlteraBuscarPeca.Text.ToString();
            DataSet dsPecas = new DataSet();
            dsPecas = pecas_DAO.BuscarPecas(busca);

            dtgAlteraBuscaPecas.DataSource = dsPecas;
            dtgAlteraBuscaPecas.DataMember = "Pecas";

            Cliente_DAO cliente_DAO = new Cliente_DAO(_conexao);

            string buscar = txbAlteraBuscarCLi.Text.ToString();
            DataSet dsClientes = new DataSet();
            dsClientes = cliente_DAO.BuscarCliente(buscar);

            dtgAlteraBuscaCli.DataSource = dsClientes;
            dtgAlteraBuscaCli.DataMember = "Clientes";
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbAlteraBuscarPeca.Text))
            {

                MessageBox.Show("Por favor, insira um nome, Montadora, Marca ou fabricante para buscar.", "Busca Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Listar();
        }

        private void dtgAlteraBuscaCli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarPeca_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbAlteraBuscarPeca.Text))
            {

                MessageBox.Show("Por favor, insira um nome, Montadora, Marca ou fabricante para buscar.", "Busca Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Listar();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbAlteraBuscarCLi.Text))
            {

                MessageBox.Show("Por favor, insira um nome ou CPF para buscar.", "Busca Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Listar();
        }

        private void btnAlteraCliente_Click(object sender, EventArgs e)
        {
            if (dtgAlteraBuscaCli.Rows.Count > 0)
            {
                int codigo = Convert.ToInt32(dtgAlteraBuscaCli.SelectedCells[0].Value);


                ClienteAltera clienteAltera = new ClienteAltera();
                clienteAltera.ShowDialog();

                Listar();
            }
            else
            {
                MessageBox.Show("Selecione um Cliente","Atenção",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
