using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaServicios.Api.CarritoCompra.Modelo
{
    public class CarritoSesionDetalle
    {
        public int CarritoSesionDetalleId { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string ProductoSeleccionado { get; set; }

        #region RELACION UNO A MUCHOS CON CARRITO SESION
        public int CarritoSesionId { get; set; }
        public CarritoSesion CarritoSesion { get; set; } 
        #endregion
    }
}
