using System;
using System.Collections.Generic;

namespace SoftWarePos.Models
{
    /// <summary>
    /// Pedidos de la mesa
    /// </summary>
    public partial class TCuenta
    {
        public uint IdCta { get; set; }
        public DateTime FechaCta { get; set; }
        public uint IdMesa { get; set; }
        public uint IdMese { get; set; }
        public uint? IdCli { get; set; }
        public string? Clase { get; set; }
        public uint? IdResol { get; set; }
        public string? NumFact { get; set; }
        public string? NumCom { get; set; }
        public string? Impresa { get; set; }
        public string? Cancela { get; set; }
        public double? VrTot { get; set; }
        public double? VrEnt { get; set; }
        public double? VrCamb { get; set; }
        public uint? IdFormaPago { get; set; }
        public uint? IdTipoPago { get; set; }
        public string? Bloqueo { get; set; }
        public DateTime? FechaBloq { get; set; }
        public string? ImpreIpc { get; set; }
    }
}
