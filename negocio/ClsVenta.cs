using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1.entidades;

namespace Parcial.negocio
{

    public class ClsVentas
    {
        public String Cobro(Venta ven)
        {
            double ApliDesc = ven.PreProducto * ven.CantidadProducto;

            if (ApliDesc > 50)
            {
                ven.NuevoDescue = ApliDesc - 10;
                return $"por sus compras de $50 obten el descuento de 10 su total es de ${ven.NuevoDescue}";
            }
            else
            {
                return $"por su compra usted no aplica para el descuento ${ApliDesc}";
            }
        }
    }
}
    
