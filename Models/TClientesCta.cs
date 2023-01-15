using System;
using System.Collections.Generic;

namespace SoftWarePos.Models
{
    public partial class TClientesCta
    {
        public uint IdCliCta { get; set; }
        public string? Control { get; set; }
        public uint IdCta { get; set; }
        public DateTime FechaCta { get; set; }
        public DateTime? FechaPago { get; set; }
        public uint IdCli { get; set; }
        public string? NumCom { get; set; }
        public string? NumFact { get; set; }
        public uint? NumRbo { get; set; }
        public double VrTot { get; set; }
    }
}
