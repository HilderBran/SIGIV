using System;
using System.Collections.Generic;

namespace Models.Entities;

public partial class Municipio
{
    public string IdMunicipio { get; set; } = null!;

    public string Municipio1 { get; set; } = null!;

    public string IdDepartamento { get; set; } = null!;

    public virtual ICollection<Distrito> Distritos { get; set; } = new List<Distrito>();

    public virtual Departamento IdDepartamentoNavigation { get; set; } = null!;
}
