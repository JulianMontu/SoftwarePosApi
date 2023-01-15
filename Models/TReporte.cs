using System;
using System.Collections.Generic;

namespace SoftWarePos.Models
{
    public partial class TReporte
    {
        public uint IdtReporte { get; set; }
        public string? Forma { get; set; }
        public double? Valor { get; set; }
    }
}
