// using System;
// using System.Data.SqlClient;
// using System.Threading.Tasks;
// using Dapper;
// using Domain.Entities;

// namespace Infra
// {
//     public class DbConnection
//     {

//         static async Task Main(string[] args)
//         {

//             var stringConexao = "Server= localhost; Database= senna; Integrated Security=True;";

//             var sql = "SELECT TOP 10 * FROM TREINA_USUARIOS";
//             // var sql2 = "SELECT TOP 1 * FROM TREINA_USUARIOS WHERE USUARIO = @USUARIO";


//             //lista
//             using (var sqlConnection = new SqlConnection(stringConexao))
//             {
//                 var usuarios = await sqlConnection.QueryAsync<User>(sql);

//                 foreach (var u in usuarios)
//                 {
//                     Console.WriteLine("Query: " + u.Nome);

//                 }

//             }

//             // using (var sqlConnection = new SqlConnection(stringConexao))
//             // {

//             //     var usuario = await sqlConnection.QueryFirstAsync<User>(sql2, new { usuario = "JOSE" });

//             //     Console.WriteLine("QueryFirst: " + usuario.Nome);
//             // }
//         }
//     }
// }
