namespace TiendaApp.Services
{
    public class ProductoServices
    {
        public void AgregarProducto(Tienda tienda, string nombre, decimal precio, string categoria)
        {
            if (precio < 0)
            {
                var producto = new Producto(nombre, precio, categoria);
                inventario.AgregarProducto(producto);

                Console.WriteLine($"Producto '{nombre}' agregado a la tienda '{tienda.Nombre}'.");
            }
            
        }
    }
}