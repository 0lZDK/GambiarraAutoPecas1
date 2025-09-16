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

using System.Configuration;
using System.Data.Sql;
using System.Security.Permissions;

namespace GambiarraAutoPecas1
{
    public partial class TelaEstoque : Form
    {
        string _conexao = GambiarraAutoPecas1.Properties.Settings.Default.conexao;

        public TelaEstoque()
        {
            InitializeComponent();
            ListarPeca();
            ConfiguraDtg();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {





        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Pecas pecas = new Pecas();
            Pecas_DAO pecas_dao = new Pecas_DAO(_conexao);

            if (txbPeca.Text == "" || txbMarca.Text == "" || txbModelo.Text == "" || cbFabricante.Text == "" || cbMontadora.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    pecas.nome_peca = txbPeca.Text;
                    pecas.marca = txbMarca.Text;
                    pecas.modelo = txbModelo.Text;
                    pecas.montadora = cbMontadora.Text;
                    pecas.fabricante = cbFabricante.Text;
                    pecas.quantidade = Convert.ToInt32(txbQuantidade.Text);
                    pecas_dao.InserirPecas(pecas);
                    MessageBox.Show("Peças cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbPeca.Clear();
                    txbMarca.Clear();
                    txbModelo.Clear();
                    cbMontadora.ResetText();
                    cbFabricante.ResetText();
                    txbQuantidade.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar o cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ConfiguraDtg()
        {
            dtgEstoque.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dtgEstoque.RowHeadersWidth = 25;
            
            dtgEstoque.Columns["idpecas"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgEstoque.Columns["idpecas"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgEstoque.Columns["idpecas"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgEstoque.Columns["idpecas"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgEstoque.Columns["idpecas"].HeaderText = "ID";
            
            dtgEstoque.Columns["nome_peca"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgEstoque.Columns["nome_peca"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgEstoque.Columns["nome_peca"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgEstoque.Columns["nome_peca"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgEstoque.Columns["nome_peca"].HeaderText = "Nome";
            
            dtgEstoque.Columns["marca"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgEstoque.Columns["marca"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgEstoque.Columns["marca"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgEstoque.Columns["marca"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgEstoque.Columns["marca"].HeaderText = "marca";
            
            dtgEstoque.Columns["modelo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgEstoque.Columns["modelo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgEstoque.Columns["modelo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgEstoque.Columns["modelo"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgEstoque.Columns["modelo"].HeaderText = "modelo";
            
            dtgEstoque.Columns["montadora"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgEstoque.Columns["montadora"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgEstoque.Columns["montadora"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgEstoque.Columns["montadora"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgEstoque.Columns["montadora"].HeaderText = "montadora";
            
            dtgEstoque.Columns["fabricante"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgEstoque.Columns["fabricante"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgEstoque.Columns["fabricante"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgEstoque.Columns["fabricante"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgEstoque.Columns["fabricante"].HeaderText = "fabricante";

            dtgEstoque.Columns["quantidade"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgEstoque.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgEstoque.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgEstoque.Columns["quantidade"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dtgEstoque.Columns["quantidade"].HeaderText = "Quantidade";
        }

        private void ListarPeca()
        {
            Pecas_DAO pecas_DAO = new Pecas_DAO(_conexao);

            string busca = txbBuscarPeca.Text.ToString();
            DataSet dsPecas= new DataSet();
            dsPecas = pecas_DAO.BuscarPecas(busca);

            dtgEstoque.DataSource = dsPecas;
            dtgEstoque.DataMember = "Pecas";
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbBuscarPeca.Text))
            {

                MessageBox.Show("Por favor, insira um nome, Montadora, Marca ou fabricante para buscar.", "Busca Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListarPeca();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
