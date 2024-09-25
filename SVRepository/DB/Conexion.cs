using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVRepository.DB
{
    public class Conexion
    {
        private readonly IConfiguration _configuration;
        private readonly string _cadenaSql;

        public Conexion(IConfiguration configuration)
        {
            _configuration = configuration;
            _cadenaSql = _configuration.GetConnectionString("CadenaSql")!;
        }

        public SqlConnection GetConexion()
        {
            return new SqlConnection(_cadenaSql);
        }
    }
}
