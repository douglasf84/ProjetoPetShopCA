namespace CleanArchBase.Domain.Entities
{
    public class ClientePJ : BaseCliente
    {
        public string Ie { get; private set; }
        public string Cnpj { get; private set; }
        public string Site { get; set; }
    }
}
