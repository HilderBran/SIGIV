using System;
using System.Collections.Generic;

namespace Models.Entities;

public partial class Asignacionrolesopcione
{
    public int IdAsignacionRol { get; set; }

    public int IdRol { get; set; }

    public int IdOpcion { get; set; }

    public virtual Opcione IdOpcionNavigation { get; set; } = null!;

    public virtual Role IdRolNavigation { get; set; } = null!;
}
