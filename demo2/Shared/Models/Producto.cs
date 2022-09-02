using System;
using System.Collections.Generic;

namespace demo2.Shared.Models
{
    public partial class Producto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Destino { get; set; }
        public int? Cantidad { get; set; }
        public DateTime? Enespera { get; set; }
        public DateTime? Encamion { get; set; }
        public string? Ubicacion { get; set; }
    }
}
