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
        
        //public static void DeleteProducto(int Id)
        //{
        //    ProductoData.DeleteProduct(Id);
        //}

        
        
    }
}
