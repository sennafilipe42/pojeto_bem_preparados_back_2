using System.Collections.Generic;
using Domain.Entities;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Data.SqlClient;

namespace Domain.Repository
{
    public class UserRepository : RepositoryConnector, Interfaces.IUserRepository
    {
        public UserRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public void Add(User obj)
        {
            throw new System.NotImplementedException();
        }

        public User Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            IEnumerable<User> retorno;
            string sql = "SELECT * FROM TREINA_USUARIOS";
            using (var con = new SqlConnection(base.GetConnection()))
            {
                retorno = con.Query<User>(sql);
            }

            return retorno;
        }

        public void Remove(User obj)
        {
            throw new System.NotImplementedException();
        }

        public void Update(User obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
