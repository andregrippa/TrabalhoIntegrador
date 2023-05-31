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
            connection.Execute("INSERT INTO [Usuario](Nome, Cargo) VALUES (@Nome, @Cargo)", new { usu.Nome, usu.Cargo});
        }

        
        public void AtualizarUsuario(int Id, Usuario usu)
        {
            using var connection = new SqlConnection(conn);
            connection.Execute("UPDATE [Usuario] SET [Nome] = @Nome, [Valor] = @Valor WHERE [Id] = @Id", new { usu.Nome, usu.Cargo, Id });
        }

        public void Deletar(int Id)
        {
            using var connection = new SqlConnection(conn);
            connection.Execute("DELETE [Usuario] WHERE [Id] = @Id", new { Id });
        }

        //public bool AtualizarUsuario(Usuario usu)
        //{
        //    }
        //}

        //public bool GravarUsuario(Usuario usu);
        //public Usuario BuscaUsuario(int id, Usuario usu)
        //{
        //    BancoInstance banco;
        //    using (banco = new BancoInstance())
        //    {
        //        return banco.Banco.ExecuteNonQuery(@"insert into Usuario (Nome, Cargo) values (@nome, @cargo)", "@nome", usu.Nome, "@cargo", usu.cargo);
        //    }
        //    using var connection = new SqlConnection(conn);
        //    return connection.Query<Usuario>("SELECT * FROM [Usuario] WHERE [Id] = @Id", new { id }).FirstOrDefault();
        //}

        //public Usuario BuscarPorId(int id)
        //{
        //    BancoInstance banco;
        //    DataTable retorno = new DataTable();
        //    using (banco = new BancoInstance())
        //    {
        //        banco.Banco.ExecuteQuery(@"select * from Usuario where Id = @var", out retorno, "@var", id);

        //    }
        //    if (retorno.Rows.Count > 0)
        //        return new Usuario(Convert.ToInt32(retorno.Rows[0]["Id"].ToString()), retorno.Rows[0]["Nome"].ToString());
        //    return null;
        //}

    }
}