using TrabalhoIntegrador.Controller;

namespace TrabalhoIntegrador.Model
{
    public class Fornecedores
    {
        public int Id { get; set; }
        public string Nome { get; set; }


        public Fornecedores() { }

        public Fornecedores(int id, string nome) 
        { 
            Nome = nome;
            Id = id;
        }
        public void Adicionar() => new FornecedoresController().GravarFornecedor(this);
        //public void Atualizar() => new ProdutoController().AtualizarProduto(this);
        public void Remover() => new FornecedoresController().Deletar(this.Id);

    }
}
