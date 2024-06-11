using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public class ProductoVendidoBussiness
    {
        public int Id { get; set; }
        public static List<ProductoVendido> GetProductoVendido()
        {
            return ProductoVendidoData.GetProductoVendido();
        }
        public static bool DeleteProductoVendido(int Id)
        {
            return ProductoVendidoData.DeleteProductoVendido(Id);
        }

        public static bool CreateProductoVendido(ProductoVendido productoVendido)
        {
            return ProductoVendidoData.CreateProductoVendido(productoVendido);
        }

        public static bool UpdateProductoVendido(ProductoVendido productoVendido)
        {
            return ProductoVendidoData.UpdateProductoVendido(productoVendido);
        }

        public static ProductoVendido GetProductoVendidoByID(int Id)
        {
            return ProductoVendidoData.GetProductoVendidoByID(Id);
        }
    }
}
