using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public class VentaBussiness
    {
        public int Id { get; set; }
        public static List<Venta> GetVenta()
        {
            return VentaData.GetVenta();
        }
        public static bool DeleteVenta(int Id)
        {
            return VentaData.DeleteVenta(Id);
        }

        public static bool CreateVenta(Venta venta)
        {
            return VentaData.CreateVenta(venta);
        }

        public static bool UpdateVenta(int Id, Venta venta)
        {
            return VentaData.UpdateVenta(Id, venta);
        }

        public static Venta GetVentaByID(int Id)
        {
            return VentaData.GetVentaByID(Id);
        }
    }
}
