namespace WebApplication8.Models
{
    public class Supermercado : Entity
    {
        public string NameSuper { get; private set; }

        public string Direccion { get; private set; }

        public Boolean Autoservicio { get; private set; }

        public List<Cliente> Clientes { get; private set; }
        public static bool IsValid { get; private set; }

        private Supermercado() : base()
        {

        }

        private Supermercado(Guid id, string namesuper, string direccion, Boolean autoservicio) : base(id)
        {
            NameSuper = namesuper;
            Direccion = direccion;
            Autoservicio = autoservicio;
            List<Cliente> Clientes = new List<Cliente>();
        }

        public static Supermercado Build(Guid id, string namesuper, string direccion, Boolean autoservicio)
        {
            return new Supermercado(id, namesuper, direccion, autoservicio);
        }
    }
}
