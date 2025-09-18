using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GambiarraAutoPecas1
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaEstoque telaestoque = new TelaEstoque();
            telaestoque.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaClienteLoja telaclienteloka = new TelaClienteLoja();
            telaclienteloka.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPedidos telaPedidos = new TelaPedidos();
            telaPedidos.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerenciar gerenciar = new Gerenciar();
            gerenciar.ShowDialog();
        }
    }
}
