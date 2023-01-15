using System;
using System.Collections.Generic;

namespace SoftWarePos.Models
{
    /// <summary>
    /// Clientes del Restaurante
    /// </summary>
    public partial class TCliente
    {
        public uint IdCli { get; set; }
        public string? NumIdCli { get; set; }
        public string? NomCli { get; set; }
        public string? ApeCli { get; set; }
        public string? DirCli { get; set; }
        public string? CelCli { get; set; }
        public string? MailCli { get; set; }
        public string? ObservCli { get; set; }
        public string? CiudCli { get; set; }
        public string? PaisCli { get; set; }
        public string? TipoCli { get; set; }
    }
}
