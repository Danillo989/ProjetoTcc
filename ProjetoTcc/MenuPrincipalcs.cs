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
    }
}
