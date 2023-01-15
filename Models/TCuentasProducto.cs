using System;
using System.Collections.Generic;

namespace SoftWarePos.Models
{
    public partial class TCuentasProducto
    {
        public uint Id { get; set; }
        public uint IdCta { get; set; }
        public double Cant { get; set; }
        public uint IdProd { get; set; }
        public double? Precio { get; set; }
        public uint? IdOpEnd { get; set; }
        public uint? IdOpTer { get; set; }
        public string? VerFact { get; set; }
        public string? Despacho { get; set; }
        public DateTime? FechaDesp { get; set; }
        public uint? IdOpTon { get; set; }
        public string? OpLlevar { get; set; }
        public string? NomProd { get; set; }

        public virtual TProducto IdProdNavigation { get; set; } = null!;
    }
}
