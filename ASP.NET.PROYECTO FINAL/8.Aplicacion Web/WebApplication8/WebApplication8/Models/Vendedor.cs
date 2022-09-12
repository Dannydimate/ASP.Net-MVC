namespace WebApplication8.Models
{
    public class Vendedor : Entity
    {
        public int CodigoVendedor { get; private set; }

        public string Cargo { get; private set; }

        public string Ventas { get; private set; }

        public Guid ClienteId { get; private set; }

        public Cliente Cliente { get; private set; }

        private Vendedor() : base()
        {

        }

        private Vendedor(Guid id, int codigoVendedor, string cargo, string ventas, Guid clienteId) : base(id)
        {
            CodigoVendedor = codigoVendedor;
            Cargo = cargo;
            Ventas = ventas;
            ClienteId = clienteId;
        }

        public static Vendedor Build(Guid id, int codigoVendedor, string cargo, string ventas, Guid clienteId)
        {
            return new Vendedor(id, codigoVendedor, cargo, ventas, clienteId);
        }
    }
}
