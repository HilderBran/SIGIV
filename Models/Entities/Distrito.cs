using System;
using System.Collections.Generic;

namespace Models.Entities;

public partial class Distrito
{
    public string IdDistrito { get; set; } = null!;

    public string Distrito1 { get; set; } = null!;

    public string IdMunicipio { get; set; } = null!;

    public virtual ICollection<Direccione> Direcciones { get; set; } = new List<Direccione>();

    public virtual Municipio IdMunicipioNavigation { get; set; } = null!;
}
