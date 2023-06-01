using TrabalhoIntegrador.Controller;

namespace TrabalhoIntegrador.Model
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public decimal Valor { get; set; }

        public Produto() { }

        public Produto(string nome)
          => Nome = nome;

        public Produto(string nome, decimal valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public void Adicionar() => new ProdutoController().GravarProduto(this);

        public void Remover() => new ProdutoController().Deletar(this.Id);

        
    }
}


