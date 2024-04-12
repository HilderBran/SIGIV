using System;
using System.Collections.Generic;

namespace Models.Entities;

public partial class Detallespedido
{
    public int IdDetallep { get; set; }

    public int IdProductoNuevo { get; set; }

    public int IdPedido { get; set; }

    public int Cantidad { get; set; }

    public double PrecioUnidad { get; set; }

    public double DescuetoUnidad { get; set; }

    public string? Comentarios { get; set; }

    public virtual Pedido IdPedidoNavigation { get; set; } = null!;

    public virtual Productosnuevo IdProductoNuevoNavigation { get; set; } = null!;
}
