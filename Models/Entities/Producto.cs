using System;
using System.Collections.Generic;

namespace Models.Entities;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string NombreP { get; set; } = null!;

    public string? Descripcion { get; set; }

    public double Precio { get; set; }

    public int IdCategoria { get; set; }

    public int IdStok { get; set; }

    public virtual ICollection<Detallesfactura> Detallesfacturas { get; set; } = new List<Detallesfactura>();

    public virtual Categoriasproducto IdCategoriaNavigation { get; set; } = null!;

    public virtual Detallesstok IdStokNavigation { get; set; } = null!;
}
