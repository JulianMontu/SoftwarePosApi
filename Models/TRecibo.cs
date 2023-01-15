using System;
using System.Collections.Generic;

namespace SoftWarePos.Models
{
    public partial class TRecibo
    {
        public uint IdRbo { get; set; }
        public DateTime? FechaRbo { get; set; }
        public uint? NumRbo { get; set; }
        public uint? IdCli { get; set; }
        public double? VrTotal { get; set; }
        public string? NomCli { get; set; }
    }
}
