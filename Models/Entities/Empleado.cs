using System;
using System.Collections.Generic;

namespace Models.Entities;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string NombresEmpleado { get; set; } = null!;

    public string ApellidosEmpleado { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public string Dui { get; set; } = null!;

    public string Isss { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string? EMail { get; set; }

    public int IdCargo { get; set; }

    public int IdDireccion { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual Cargo IdCargoNavigation { get; set; } = null!;

    public virtual Direccione IdDireccionNavigation { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
