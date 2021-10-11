using System;
using System.Collections.Generic;

namespace CleanArchBase.Domain.Entities
{
    public class BaseCliente
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public string Celular { get; private set; }
        public string Observacao { get; private set; }
        public string Foto { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime? DataUltimaAtualizacao { get; private set; }
        public bool Situacao { get; private set; }


        public Endereco Endereco { get; private set; }
        public int EnderecoId { get; private set; }
      
    }
}
