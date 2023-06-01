namespace TrabalhoIntegrador.Model
{
    public class Colaborador
    {
        public int Id { get; set; }

        public string  Nome { get; set; }

        public string Funcao { get; set; }

        public Colaborador()
        {

        }

        public Colaborador (int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public Colaborador (int id, string nome, string funcao)
        {
            Id = id;    
            Nome = nome;
            Funcao = funcao;    
            
        }


    }
}
