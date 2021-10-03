using System.Collections.Generic;

namespace CleanArchBase.Domain.Entities
{
    public class Endereco
    {
        public int Id { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Cep { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }

        public ICollection<ClientePF> ClientesPF { get; set; }
        public ICollection<ClientePJ> ClientesPJ { get; set; }
    }
}
