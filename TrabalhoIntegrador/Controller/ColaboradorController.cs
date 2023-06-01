using System.Data.SqlClient;
using Dapper;
using TrabalhoIntegrador.Model;

namespace TrabalhoIntegrador.Controller
{
    public class ColaboradorController
    {
        public string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre.grippa\Desktop\TrabalhoIntegrador\TrabalhoIntegrador\TrabalhoIntegrador\DAO\Banco.mdf;Integrated Security=True";

        public List<Usuario> BuscarColaborador()
        {
            //using var connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre.grippa\Desktop\TrabalhoIntegrador\TrabalhoIntegrador\TrabalhoIntegrador\DAO\Banco.mdf;Integrated Security=True");
            using var connection = new SqlConnection(conn);
            return connection.Query<Usuario>("SELECT * FROM [Colaborador]").ToList();
        }

        public void GravarcColaborador(Colaborador colab)
        {
            using var connection = new SqlConnection(conn);
            connection.Execute("INSERT INTO [Colaborador](Nome) VALUES (@Nome)", new { colab.Nome });
        }

        public void AtualizarFornecedores(int Id, Colaborador colab)
        {
            using var connection = new SqlConnection(conn);
            connection.Execute("UPDATE [Colaborador] SET [Nome] = @Nome Id = @Id", new { colab.Nome, Id });
        }

        public void Deletar(int Id)
        {
            using var connection = new SqlConnection(conn);
            connection.Execute("DELETE [Colaborador] WHERE [Id] = @Id", new { Id });
        }
    }
}
}
