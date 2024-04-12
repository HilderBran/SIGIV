using System;
using System.Collections.Generic;

namespace Models.Entities;

public partial class Categoriasproducto
{
    public int IdCategoria { get; set; }

    public string? Categoria { get; set; }

    public string? Detalles { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
