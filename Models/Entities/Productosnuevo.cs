using System;
using System.Collections.Generic;

namespace Models.Entities;

public partial class Productosnuevo
{
    public int IdProductoNuevo { get; set; }

    public string NombreP { get; set; } = null!;

    public string? Descripcion { get; set; }

    public double Precio { get; set; }

    public int IdCategoria { get; set; }

    public int IdStok { get; set; }

    public virtual ICollection<Detallespedido> Detallespedidos { get; set; } = new List<Detallespedido>();
}
