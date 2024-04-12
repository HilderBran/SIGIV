using System;
using System.Collections.Generic;

namespace Models.Entities;

public partial class Opcione
{
    public int IdOpcion { get; set; }

    public string Opcion { get; set; } = null!;

    public virtual ICollection<Asignacionrolesopcione> Asignacionrolesopciones { get; set; } = new List<Asignacionrolesopcione>();
}
