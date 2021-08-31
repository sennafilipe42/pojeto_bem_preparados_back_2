using System;
using System.Data.SqlClient;
using Dapper;
using Domain.Entities;

namespace Infra
{
    public class DbConnection
    {

        static void Main(string[] args)
        {

            var stringConexao = "Server= localhost; Database= senna; Integrated Security=True;";

            var sql = "SELECT TOP 10 * FROM TREINA_USUARIOS";

            var sqlConnection = new SqlConnection(stringConexao);
            var usuarios = sqlConnection.Query<User>(sql);

            foreach (var u in usuarios)
            {
                Console.WriteLine(u.Nome);

            }

        }
    }
}
