using System;
using System.Collections.Generic;

namespace Models.Entities;

public partial class Direccione
{
    public int IdDireccion { get; set; }

    public string Linea1 { get; set; } = null!;

    public string? Linea2 { get; set; }

    public string IdDistrito { get; set; } = null!;

    public int? CodigoPostal { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();

    public virtual Distrito IdDistritoNavigation { get; set; } = null!;

    public virtual ICollection<Proveedore> Proveedores { get; set; } = new List<Proveedore>();
}
