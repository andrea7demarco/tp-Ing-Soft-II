namespace TiendaApp.Services
{
    public class TiendaServices
    {
        private List<Producto> inventario = new();

        public void AgregarProducto(Producto producto)
        {
            inventario.Add(producto);
        }

        public List<Producto> ObtenerInventario()
        {
            return inventario;
        }
    }
}