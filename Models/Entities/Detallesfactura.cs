using System;
using System.Collections.Generic;

namespace Models.Entities;

public partial class Detallesfactura
{
    public int IdDetalles { get; set; }

    public int IdProducto { get; set; }

    public int IdFactura { get; set; }

    public int Cantidad { get; set; }

    public double Iva { get; set; }

    public double Descuento { get; set; }

    public virtual Factura IdFacturaNavigation { get; set; } = null!;

    public virtual Producto IdProductoNavigation { get; set; } = null!;
}
