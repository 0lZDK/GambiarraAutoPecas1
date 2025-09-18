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
    public partial class TelaPedidos : Form
    {
        string _conexao = GambiarraAutoPecas1.Properties.Settings.Default.conexao;

        public TelaPedidos()
        {
            InitializeComponent();
            ListarCliente();
            ConfigurarDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txbBuscarCLi.Text))
            {
                
                MessageBox.Show("Por favor, insira um nome ou CPF para buscar.", "Busca Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void ConfigurarDataGridView()
        {
            dtgBuscaCli.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dtgBuscaCli.RowHeadersWidth = 25;

            dtgBuscaCli.Columns["idcliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgBuscaCli.Columns["idcliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgBuscaCli.Columns["idcliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgBuscaCli.Columns["idcliente"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgBuscaCli.Columns["idcliente"].HeaderText = "ID";

            dtgBuscaCli.Columns["nome_cliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgBuscaCli.Columns["nome_cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgBuscaCli.Columns["nome_cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgBuscaCli.Columns["nome_cliente"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgBuscaCli.Columns["nome_cliente"].HeaderText = "Nome";

            dtgBuscaCli.Columns["cpf"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgBuscaCli.Columns["cpf"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgBuscaCli.Columns["cpf"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgBuscaCli.Columns["cpf"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgBuscaCli.Columns["cpf"].HeaderText = "CPF";

            dtgBuscaCli.Columns["email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgBuscaCli.Columns["email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgBuscaCli.Columns["email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgBuscaCli.Columns["email"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgBuscaCli.Columns["email"].HeaderText = "E-mail";

            dtgBuscaCli.Columns["veiculo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgBuscaCli.Columns["veiculo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgBuscaCli.Columns["veiculo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgBuscaCli.Columns["veiculo"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgBuscaCli.Columns["veiculo"].HeaderText = "Veículo";

            dtgBuscaCli.Columns["telefone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgBuscaCli.Columns["telefone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgBuscaCli.Columns["telefone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgBuscaCli.Columns["telefone"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgBuscaCli.Columns["telefone"].HeaderText = "Telefone";

            dtgBuscaCli.Columns["logradouro"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgBuscaCli.Columns["logradouro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgBuscaCli.Columns["logradouro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgBuscaCli.Columns["logradouro"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgBuscaCli.Columns["logradouro"].HeaderText = "Logradouro";

            dtgBuscaCli.Columns["numero_casa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgBuscaCli.Columns["numero_casa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgBuscaCli.Columns["numero_casa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgBuscaCli.Columns["numero_casa"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgBuscaCli.Columns["numero_casa"].HeaderText = "Nº";

            dtgBuscaCli.Columns["bairro"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgBuscaCli.Columns["bairro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgBuscaCli.Columns["bairro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgBuscaCli.Columns["bairro"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgBuscaCli.Columns["bairro"].HeaderText = "Bairro";

            dtgBuscaCli.Columns["cep"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgBuscaCli.Columns["cep"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgBuscaCli.Columns["cep"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgBuscaCli.Columns["cep"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgBuscaCli.Columns["cep"].HeaderText = "CEP";

            dtgBuscaCli.Columns["complemento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgBuscaCli.Columns["complemento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgBuscaCli.Columns["complemento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgBuscaCli.Columns["complemento"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgBuscaCli.Columns["complemento"].HeaderText = "Complemento";
        }

        private void ListarCliente()
        {
            Cliente_DAO cliente_DAO = new Cliente_DAO(_conexao);

            string busca = txbBuscarCLi.Text.ToString();
            DataSet dsClientes = new DataSet();
            dsClientes = cliente_DAO.BuscarCliente(busca);

            dtgBuscaCli.DataSource = dsClientes;
            dtgBuscaCli.DataMember = "Clientes";
        }

        private void dtgBuscaCli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
