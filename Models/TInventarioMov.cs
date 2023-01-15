using System;
using System.Collections.Generic;

namespace SoftWarePos.Models
{
    /// <summary>
    /// Movimientos
    /// </summary>
    public partial class TInventarioMov
    {
        public uint Id { get; set; }
        public DateTime Fecha { get; set; }
        public uint IdProd { get; set; }
        public uint Cant { get; set; }
        public double Precio { get; set; }
        public string Detalle { get; set; } = null!;
        public uint TipoMov { get; set; }
    }
}
