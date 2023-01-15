using System;
using System.Collections.Generic;

namespace SoftWarePos.Models
{
    public partial class TOpcionesBebida
    {
        public uint IdOpBeb { get; set; }
        public string NomOpBeb { get; set; } = null!;
        public uint IdProd { get; set; }
    }
}
