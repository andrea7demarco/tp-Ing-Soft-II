using TiendaApp.Models;

namespace TiendaApp.Services
{
    public class ProductoServices
    {
        public void AgregarProducto(Tienda tienda, int id, string nombre, decimal precio, string categoria)
        {
            if (precio >= 0)
            {
                var producto = new Producto(id, nombre, precio, categoria);
                

                Console.WriteLine($"Producto '{nombre}' agregado a la tienda '{tienda.Nombre}'.");
            } else
            {
                Console.WriteLine("El precio no puede ser negativo.");
            }

        }
    }
}