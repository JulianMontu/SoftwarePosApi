using System;
using System.Collections.Generic;

namespace SoftWarePos.Models
{
    public partial class TUsuario
    {
        public uint IdUsu { get; set; }
        public string? NomUsu { get; set; }
        public string? ClaveUsu { get; set; }
        public string? Activo { get; set; }
        public string? Nombres { get; set; }
        public string? Email { get; set; }
        public string? Contacto { get; set; }
        public uint? MenuSiste { get; set; }
        public uint? Menuprodu { get; set; }
        public uint? MenuContab { get; set; }
        public uint? MenuMesas { get; set; }
        public uint? MenuRepo { get; set; }
    }
}
