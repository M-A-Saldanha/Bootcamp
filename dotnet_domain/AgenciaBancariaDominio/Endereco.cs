using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AgenciaBancariaDominio
{
    public class Endereco
    {
        public Endereco(string logradouro, string cep, string cidade, string estado)
        {
            this.Logradouro = logradouro.ValidarStringVazia();
            this.CEP = cep.ValidarStringVazia();
            this.Cidade = cidade.ValidarStringVazia();
            this.Estado = estado.ValidarStringVazia();
        
        }
        public string Logradouro { get; private set; }
        public string CEP { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
    }
}
