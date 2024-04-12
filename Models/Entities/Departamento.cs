using System;
using System.Collections.Generic;

namespace Models.Entities;

public partial class Departamento
{
    public string IdDepartamento { get; set; } = null!;

    public string Departamento1 { get; set; } = null!;

    public string IdPais { get; set; } = null!;

    public virtual Paise IdPaisNavigation { get; set; } = null!;

    public virtual ICollection<Municipio> Municipios { get; set; } = new List<Municipio>();
}
