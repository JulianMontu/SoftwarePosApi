using System;
using System.Collections.Generic;

namespace SoftWarePos.Models
{
    /// <summary>
    /// Bodegas para los productos
    /// </summary>
    public partial class TBodega
    {
        public uint IdBod { get; set; }
        public string? NomBod { get; set; }
    }
}
