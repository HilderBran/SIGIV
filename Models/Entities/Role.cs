using System;
using System.Collections.Generic;

namespace Models.Entities;

public partial class Role
{
    public int IdRol { get; set; }

    public string MombreRol { get; set; } = null!;

    public virtual ICollection<Asignacionrolesopcione> Asignacionrolesopciones { get; set; } = new List<Asignacionrolesopcione>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
