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

        public int Valor { get; private set; }


        public Produto() 
        {

        }

        public Produto(string nome)
        {
            Nome = nome;
        }

        public Produto (string nome, int valor)
        {            
            Nome = nome;
            Valor = valor;
       
        }


    }

}
