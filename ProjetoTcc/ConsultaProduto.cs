using ProjetoTccDal;
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
    public partial class ConsultaProduto : Form
    {
        public ConsultaProduto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }




        private void gridButton_Click(object sender, EventArgs e)
        {


            BancoDados x = new BancoDados();
            DataTable tabela = new DataTable();
            tabela.Columns.Add();
            var produto = x.ConsultaProdutoGrid(plu.Text);

            dataGridView1.DataSource = produto;




        }
    }
}
