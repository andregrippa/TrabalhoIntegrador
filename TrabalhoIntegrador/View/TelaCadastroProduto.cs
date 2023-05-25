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
using TrabalhoIntegrador.Model;

namespace TrabalhoIntegrador.View
{
    public partial class TelaCadastroProduto : Form
    {
        public TelaCadastroProduto()
        {
            InitializeComponent();
        }

        private void TelaCadastroProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //new Produto(textBox1.Text, decimal.Parse(textBox2.Text)).Adicionar();
            new ProdutoController().Deletar(1);

            new ProdutoController().AtualizarProduto(2, new Produto("feijao", 2000));
        }
    }
}
