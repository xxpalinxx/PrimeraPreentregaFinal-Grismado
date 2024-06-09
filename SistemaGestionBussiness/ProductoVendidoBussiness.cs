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
    }
}
