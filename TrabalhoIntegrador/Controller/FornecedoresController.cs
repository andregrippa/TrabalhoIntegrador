using TrabalhoIntegrador.Model;
using System.Data;
using System.Data.SqlClient;
using Dapper;
namespace TrabalhoIntegrador.Controller
{
    public class FornecedoresController
    {
        public string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre.grippa\Desktop\TrabalhoIntegrador\TrabalhoIntegrador\TrabalhoIntegrador\DAO\Banco.mdf;Integrated Security=True";
        public List<Usuario> BuscarFornecedor()
        {
            //using var connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre.grippa\Desktop\TrabalhoIntegrador\TrabalhoIntegrador\TrabalhoIntegrador\DAO\Banco.mdf;Integrated Security=True");
            using var connection = new SqlConnection(conn);
            return connection.Query<Usuario>("SELECT * FROM [Fornecedores]").ToList();
        }

        public void GravarFornecedor(Fornecedores forne)
        {
            using var connection = new SqlConnection(conn);
            connection.Execute("INSERT INTO [Fornecedores](Nome) VALUES (@Nome)", new { forne.Nome });
        }

        public void AtualizarFornecedores(int Id, Fornecedores forne)
        {
            using var connection = new SqlConnection(conn);
            connection.Execute("UPDATE [Fornecedores] SET [Nome] = @Nome, [Valor] = @Valor WHERE [Id] = @Id", new { forne.Nome, Id });
        }

        public void Deletar(int Id)
        {
            using var connection = new SqlConnection(conn);
            connection.Execute("DELETE [Fornecedores] WHERE [Id] = @Id", new { Id });
        }
    }
}