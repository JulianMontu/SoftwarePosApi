using System;
using System.Collections.Generic;

namespace SoftWarePos.Models
{
    /// <summary>
    /// Meseros del Restaurante
    /// </summary>
    public partial class TMesero
    {
        public uint IdMese { get; set; }
        public string NomMese { get; set; } = null!;
        public string? ApeMese { get; set; }
        public string? Cobrar { get; set; }
        public string? Activo { get; set; }
        public string? Anular { get; set; }
        public string? Elimina { get; set; }
    }
}
