using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public class ProductoBussiness
    {
        public int Id { get; set; }
        public static List<Producto> GetProducto()
        {
            return ProductoData.GetProducto();
        }
        
        public static bool DeleteProducto(int Id)
        {
            return ProductoData.DeleteProduct(Id);
        }

        public static bool CreateProducto(Producto producto)
        {
            return ProductoData.CreateProduct(producto);
        }

        public static bool UpdateProducto(Producto producto)
        {
            return ProductoData.UpdateProduct(producto);
        }

        public static Producto GetProductoByID(int Id)
        {
            return ProductoData.GetProductByID(Id);
        } 
    }
}
