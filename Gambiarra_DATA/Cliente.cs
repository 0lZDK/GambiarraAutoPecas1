using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambiarra_DATA
{
    public class Cliente
    {
        public int idcliente {  get; set; }
        public string nome_cliente { get; set; }
        public string cpf {  get; set; }
        public string email { get; set; }
        public string veiculo { get; set; }
        public string telefone { get; set; }
        public string logradouro { get; set; }
        public string numero_casa { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public string complemento { get; set; }




    }
}
