using System;
using System.Collections.Generic;

namespace SoftWarePos.Models
{
    public partial class TResolucion
    {
        public uint IdResol { get; set; }
        public DateTime? FechaResol { get; set; }
        public string? PrefijoFact { get; set; }
        public string? NumIniFact { get; set; }
        public string? NumFinFact { get; set; }
        public string? NumActFact { get; set; }
        public string? DescripResol { get; set; }
        public string? Activa { get; set; }
        public string? NomEmpre { get; set; }
        public string? NomRepre { get; set; }
        public string? Nit { get; set; }
        public string? DirEmpre { get; set; }
        public string? TelEmpre { get; set; }
        public string? CiudEmpre { get; set; }
        public string? ComentA { get; set; }
        public string? ComentB { get; set; }
        public string? RegimenEmpre { get; set; }
    }
}
