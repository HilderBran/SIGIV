using System;
using System.Collections.Generic;

namespace Models.Entities;

public partial class Contactosproveedor
{
    public int IdContacto { get; set; }

    public string? NombresContacto { get; set; }

    public string? ApellidosContacto { get; set; }

    public string CargoContacto { get; set; } = null!;

    public string TelefonoContacto { get; set; } = null!;

    public string EMailContacto { get; set; } = null!;

    public string? Observacion { get; set; }

    public int IdProveedor { get; set; }

    public virtual Proveedore IdProveedorNavigation { get; set; } = null!;
}
