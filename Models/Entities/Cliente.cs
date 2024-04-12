using System;
using System.Collections.Generic;

namespace Models.Entities;

public partial class Cliente
{
    public int Idcliente { get; set; }

    public string NombresCliente { get; set; } = null!;

    public string ApellidosCliente { get; set; } = null!;

    public string Dui { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? EMail { get; set; }

    public int? IdDireccion { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual Direccione? IdDireccionNavigation { get; set; }
}
