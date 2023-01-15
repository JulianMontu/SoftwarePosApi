using System;
using System.Collections.Generic;

namespace SoftWarePos.Models
{
    /// <summary>
    /// Mesas para cargar cuentas
    /// </summary>
    public partial class TMesa
    {
        public uint IdMesa { get; set; }
        public string? NomMesa { get; set; }
        public string? Estado { get; set; }
    }
}
