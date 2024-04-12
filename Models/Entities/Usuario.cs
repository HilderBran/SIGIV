using System;
using System.Collections.Generic;

namespace Models.Entities;

public partial class Usuario
{
    public int Idusuario { get; set; }

    public int IdEmpleado { get; set; }

    public int IdRol { get; set; }

    public string Usuario1 { get; set; } = null!;

    public string Clave { get; set; } = null!;

    public virtual Empleado IdEmpleadoNavigation { get; set; } = null!;

    public virtual Role IdRolNavigation { get; set; } = null!;
}
