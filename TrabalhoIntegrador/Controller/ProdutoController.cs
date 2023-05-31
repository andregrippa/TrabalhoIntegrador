using TrabalhoIntegrador.Model;
using System.Data;
using System.Data.SqlClient;
using Dapper;
namespace TrabalhoIntegrador.Controller
{
    public class ProdutoController
    {
        public string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre.grippa\Desktop\TrabalhoIntegrador\TrabalhoIntegrador\TrabalhoIntegrador\DAO\Banco.mdf;Integrated Security=True";
        public List<Produto> BuscarProdutos()
        {
            //using var connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre.grippa\Desktop\TrabalhoIntegrador\TrabalhoIntegrador\TrabalhoIntegrador\DAO\Banco.mdf;Integrated Security=True");
            using var connection = new SqlConnection(conn);
            return connection.Query<Produto>("SELECT * FROM [Produto]").ToList();
        }

     
        //public Produto BuscaProduto(int id)
        //{
        //    BancoInstance banco;
        //    using (banco = new BancoInstance())
        //    {
        //        return banco.Banco.ExecuteNonQuery(@"insert into Produto (Nome, Quantidade) values (@nome, @qtd)", "@nome", prod.Nome, "@qtd", prod.QtdEstoque);
        //    }
        //    using var connection = new SqlConnection(conn);
        //    return connection.Query<Produto>("SELECT * FROM [Produto] WHERE [Id] = @Id", new { id }).FirstOrDefault();
        //}        //public Produto BuscaProduto(int id)
        //{
        //    BancoInstance banco;
        //    using (banco = new BancoInstance())
        //    {
        //        return banco.Banco.ExecuteNonQuery(@"insert into Produto (Nome, Quantidade) values (@nome, @qtd)", "@nome", prod.Nome, "@qtd", prod.QtdEstoque);
        //    }
        //    using var connection = new SqlConnection(conn);
        //    return connection.Query<Produto>("SELECT * FROM [Produto] WHERE [Id] = @Id", new { id }).FirstOrDefault();
        //}

        //public Produto BuscarPorId(int id)
        //{
        //    BancoInstance banco;
        //    DataTable retorno = new DataTable();
        //    using (banco = new BancoInstance())
        //    {
        //        banco.Banco.ExecuteQuery(@"select * from Produto where Id = @var", out retorno, "@var", id);

        //    }
        //    if (retorno.Rows.Count > 0)
        //        return new Produto(Convert.ToInt32(retorno.Rows[0]["Id"].ToString()), retorno.Rows[0]["Nome"].ToString());
        //    return null;
        //}

        public void GravarProduto(Produto prod)
        {
            using var connection = new SqlConnection(conn);
            connection.Execute("INSERT INTO [Produto](Nome, Valor) VALUES (@Nome, @Valor)", new { prod.Nome, prod.Valor });
        }

        //public bool AtualizarProduto(Produto prod)
        //{
        //    }
        //}

        public void AtualizarProduto(int Id, Produto prod)
        {
            using var connection = new SqlConnection(conn);
            connection.Execute("UPDATE [Produto] SET [Nome] = @Nome, [Valor] = @Valor WHERE [Id] = @Id", new { prod.Nome, prod.Valor, Id });
        }

        public void Deletar(int Id)
        {
            using var connection = new SqlConnection(conn);
            connection.Execute("DELETE [Produto] WHERE [Id] = @Id", new { Id });
        }
    }
}