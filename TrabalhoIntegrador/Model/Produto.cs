using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoIntegrador.Controller;

namespace TrabalhoIntegrador.Model
{
    public class Produto
    {

        public int Id { get; set; }
        public string Nome { get; set; }

        public decimal Valor { get; set; }

        public int QtdEstoque { get; set; }
        public Produto() {}


        public Produto(string nome)
        => Nome = nome;

        public Produto(string nome, int valor) {}

        public Produto(string nome, decimal valor, int qtdestoque)
        {
            Nome = nome;
            Valor = valor;
            QtdEstoque = qtdestoque;
        }

        public void Adicionar() => new ProdutoController().GravarProduto(this);
        //public void Atualizar() => new ProdutoController().AtualizarProduto(this);
        public void Remover() => new ProdutoController().Deletar(this.Id);


    }
}