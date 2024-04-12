using System;
using System.Collections.Generic;

namespace Models.Entities;

public partial class Detallesstok
{
    public int IdStok { get; set; }

    public int CantidadStok { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
