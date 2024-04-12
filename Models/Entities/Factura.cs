using System;
using System.Collections.Generic;

namespace Models.Entities;

public partial class Factura
{
    public int IdFactura { get; set; }

    public DateTime FechaFactura { get; set; }

    public string? Comentario { get; set; }

    public int Idcliente { get; set; }

    public int Idempleado { get; set; }

    public virtual ICollection<Detallesfactura> Detallesfacturas { get; set; } = new List<Detallesfactura>();

    public virtual Cliente IdclienteNavigation { get; set; } = null!;

    public virtual Empleado IdempleadoNavigation { get; set; } = null!;
}
