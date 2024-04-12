using System;
using System.Collections.Generic;

namespace Models.Entities;

public partial class Proveedore
{
    public int IdProveedor { get; set; }

    public string Compania { get; set; } = null!;

    public string Nit { get; set; } = null!;

    public string TelefonoProveedor { get; set; } = null!;

    public string EMailProveedor { get; set; } = null!;

    public string? Web { get; set; }

    public string Giro { get; set; } = null!;

    public int IdDireccion { get; set; }

    public virtual ICollection<Contactosproveedor> Contactosproveedors { get; set; } = new List<Contactosproveedor>();

    public virtual Direccione IdDireccionNavigation { get; set; } = null!;

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
