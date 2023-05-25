using TrabalhoIntegrador.Model;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace TrabalhoIntegrador.Controller
{
    public class ProdutoController
    {
        public List<Produto> BuscarProdutos()
        {
            using var connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre.grippa\Desktop\TrabalhoIntegrador\TrabalhoIntegrador\TrabalhoIntegrador\DAO\Banco.mdf;Integrated Security=True");
            return connection.Query<Produto>("SELECT * FROM [Produto]").ToList();
        }

        public bool GravarProduto(Produto prod)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(@"insert into Produto (Nome, Quantidade) values (@nome, @qtd)", "@nome", prod.Nome, "@qtd");
            }
        }

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


        //public bool AtualizarProduto(Produto prod)
        //{
        //    BancoInstance banco;
        //    using (banco = new BancoInstance())
        //    {
        //        return banco.Banco.ExecuteNonQuery(@"update Produto set Nome=@nome, Quantidade=@qtd where Id=@id", "@nome", prod.Nome, "@qtd", prod.QtdEstoque, "@id", prod.Id);
        //    }
        //}


    }
}
