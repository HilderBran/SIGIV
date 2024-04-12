using System;
using System.Collections.Generic;

namespace Models.Entities;

public partial class Paise
{
    public string IdPais { get; set; } = null!;

    public string Pais { get; set; } = null!;

    public virtual ICollection<Departamento> Departamentos { get; set; } = new List<Departamento>();
}
