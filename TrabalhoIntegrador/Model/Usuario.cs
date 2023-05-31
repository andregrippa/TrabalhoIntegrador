using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoIntegrador.Controller;

namespace TrabalhoIntegrador.Model
{
    public class Usuario
    {
        public string Nome { get; set; }

        public int Id { get; set; }

        public string Cargo { get; set; }

        public Usuario() { }

        public Usuario(int id, string nome, string cargo)
        {
            Nome = nome;
            Id = id;
            Cargo = cargo;
        }

        public void Adicionar() => new UsuarioController().GravarUsuario(this);
        public void Remover() => new UsuarioController().DeletarUsuario(this.Id);
    }
}
