using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaServicios.Api.CarritoCompra.Modelo
{
    public class CarritoSesion
    {
        public int CarritoSesionId { get; set; }
        public DateTime? FechaCreacion { get; set; }

        #region RELACION CON CARRITO SESION DETALLE
        public ICollection<CarritoSesionDetalle> ListaDetalle { get; set; } 
        #endregion
    }
}
