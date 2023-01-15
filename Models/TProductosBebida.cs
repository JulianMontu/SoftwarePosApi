using System;
using System.Collections.Generic;

namespace SoftWarePos.Models
{
    /// <summary>
    /// Fusionar las bebidas
    /// </summary>
    public partial class TProductosBebida
    {
        public uint IdPb { get; set; }
        public uint IdProd { get; set; }
        public uint IdOpBeb { get; set; }
    }
}
