using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTcc
{
    public partial class MenuPrincipalcs : Form
    {
        public MenuPrincipalcs()
        {
            InitializeComponent();
        }

        private void Fornecedor_Click(object sender, EventArgs e)
        {
            var fornecedor = new Form1();
            fornecedor.Show();
            this.Visible = true;

        }

        private void cadastro_produto_Click(object sender, EventArgs e)
        {
            var produto = new Produto();
            produto.Show();
            this.Visible = true;

        }

        private void gridproduto_Click(object sender, EventArgs e)
        {
            var grid = new ConsultaProduto();
            grid.Show();
            this.Visible = true;
        }
    }
}
