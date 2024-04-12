using System;
using System.Collections.Generic;

namespace Models.Entities;

public partial class Pedido
{
    public int IdPedido { get; set; }

    public int IdProveedor { get; set; }

    public DateTime FechaPedido { get; set; }

    public DateTime FechaRecibido { get; set; }

    public string? Comentario { get; set; }

    public virtual ICollection<Detallespedido> Detallespedidos { get; set; } = new List<Detallespedido>();

    public virtual Proveedore IdProveedorNavigation { get; set; } = null!;
}
