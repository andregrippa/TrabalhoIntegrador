using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoIntegrador.Controller;

namespace TrabalhoIntegrador.View
{
    public partial class RelatorioProdutos : Form
    {
        public RelatorioProdutos()
        {
            InitializeComponent();
            dataGridView1.DataSource = new ProdutoController().BuscarProdutos();
        }

        private void RelatorioProdutos_Load(object sender, EventArgs e)
        {

        }
    }
}
