using Microsoft.Extensions.Configuration;

namespace Domain.Repository
{
    public class RepositoryConnector
    {
        //injeção de dependencia
        public IConfiguration _configuration;
        public RepositoryConnector(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnection()
        {
            return _configuration.GetSection("Connections").GetSection("ConnectionStringSQL").Value;
        }

    }
}
