using TrabalhoIntegrador.Model;
using System.Data;
using System.Data.SqlClient;
using Dapper;
namespace TrabalhoIntegrador.Controller
{
    public class UsuarioController
    {
        public string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre.grippa\Desktop\TrabalhoIntegrador\TrabalhoIntegrador\TrabalhoIntegrador\DAO\Banco.mdf;Integrated Security=True";
        public List<Usuario> BuscarUsuario()
        {
            //using var connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre.grippa\Desktop\TrabalhoIntegrador\TrabalhoIntegrador\TrabalhoIntegrador\DAO\Banco.mdf;Integrated Security=True");
            using var connection = new SqlConnection(conn);
            return connection.Query<Usuario>("SELECT * FROM [Usuario]").ToList();
        }
        public void GravarUsuario(Usuario usu)
        {
            using var connection = new SqlConnection(conn);
            connection.Execute("INSERT INTO [Usuario](Nome, Cargo) VALUES (@Nome, @Cargo)", new { usu.Nome, usu.Cargo });
        }


        public void AtualizarUsuario(int Id, Usuario usu)
        {
            using var connection = new SqlConnection(conn);
            connection.Execute("UPDATE [Usuario] SET [Nome] = @Nome, [Valor] = @Valor WHERE [Id] = @Id", new { usu.Nome, usu.Cargo, Id });
        }

        public void DeletarUsuario(int Id)
        {
            using var connection = new SqlConnection(conn);
            connection.Execute("DELETE [Usuario] WHERE [Id] = @Id", new { Id });
        }

    }
}