using System;
using System.Collections.Generic;

namespace SoftWarePos.Models
{
    public partial class TPwd
    {
        public uint Id { get; set; }
        public string? PwAdmin { get; set; }
        public string? PwAnular { get; set; }
        public string? PwComanda { get; set; }
    }
}
