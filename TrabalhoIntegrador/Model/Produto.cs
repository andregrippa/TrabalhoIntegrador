using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoIntegrador.Model
{
    public class Produto
    {
        public int Id { get; private set; }

        public string Nome { get; private set; }

        public int QtdEstoque { get; private set; }

        public List<int> Assinantes { get; private set; }

        public Produto() 
        {
          teste
        }

        public Produto(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public Produto (int id, string nome, int qtdEstoque)
        {
            Id = id;
            Nome = nome;
            QtdEstoque = qtdEstoque;
            Assinantes = new List<int>();   

        }
    }

}
