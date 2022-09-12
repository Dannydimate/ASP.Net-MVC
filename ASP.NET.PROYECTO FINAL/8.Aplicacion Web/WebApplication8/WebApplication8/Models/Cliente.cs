namespace WebApplication8.Models
{
    public class Cliente : Entity
    {
        public string Name { get;  private set; }

        public string DocumentoI { get; private set; }

        public string TipoCliente { get; private set; }

        public Guid SupermercadoId { get; private set; }



        public Supermercado Supermercado { get; private set; }

        private Cliente() : base()
        {

        }

        private Cliente( Guid id, string name, string documentoI, string tipocliente, Guid supermercadoId) : base(id)
            
        {
            Name = name;
            DocumentoI = documentoI;
            TipoCliente = tipocliente;
            SupermercadoId = supermercadoId;
        }

        public static Cliente Build(Guid id, string name, string documentoI, string tipocliente, Guid supermercadoId)
        {
            return new Cliente(id, name, documentoI, tipocliente, supermercadoId);
        }

        internal static object Build(Func<Guid> newGuid, string name, string documentoI, string tipocliente, Guid supermercadoId)
        {
            throw new NotImplementedException();
        }
    }
}
