using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppGestionProductos.DAL;
using AppGestionProductos.BLL;

namespace AppGestionProductos
{
    public class Program
    {
        public static void Main()
        {
            // Inyección de dependencias manual
            IProductRepository repository = new ProductRepository();
            ProductService productService = new ProductService(repository);

            // Crear un producto
            Product product = new Product { Id = 1, Name = "Laptop", Price = 1500.00M };

            // Añadir el producto
            productService.AddProduct(product);

            // Obtener el producto y mostrar sus detalles
            var retrievedProduct = productService.GetProduct(1);
            Console.WriteLine($"Producto recuperado: ID = {retrievedProduct.Id}, Nombre = {retrievedProduct.Name}, Precio = {retrievedProduct.Price}");
        }
    }
}
