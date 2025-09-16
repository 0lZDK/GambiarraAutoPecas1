using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Security.Principal;
namespace Gambiarra_DATA
{
    public class Pedidos_DAO
    {
        private readonly string _conexao;

        public Pedidos_DAO(string conexao)
        {
            _conexao = conexao;
        }
    }
}
