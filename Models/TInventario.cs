using System;
using System.Collections.Generic;

namespace SoftWarePos.Models
{
    public partial class TInventario
    {
        public uint Id { get; set; }
        public uint IdProd { get; set; }
        public uint SaldoIni { get; set; }
        public uint CantEnt { get; set; }
        public uint CantSal { get; set; }
        public uint SaldoFin { get; set; }
    }
}
