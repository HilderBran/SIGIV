using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace Models.Entities;

public partial class SigivContext : DbContext
{
    public SigivContext()
    {
    }

    public SigivContext(DbContextOptions<SigivContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Asignacionrolesopcione> Asignacionrolesopciones { get; set; }

    public virtual DbSet<Cargo> Cargos { get; set; }

    public virtual DbSet<Categoriasproducto> Categoriasproductos { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Contactosproveedor> Contactosproveedors { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<Detallesfactura> Detallesfacturas { get; set; }

    public virtual DbSet<Detallespedido> Detallespedidos { get; set; }

    public virtual DbSet<Detallesstok> Detallesstoks { get; set; }

    public virtual DbSet<Direccione> Direcciones { get; set; }

    public virtual DbSet<Distrito> Distritos { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<Municipio> Municipios { get; set; }

    public virtual DbSet<Opcione> Opciones { get; set; }

    public virtual DbSet<Paise> Paises { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Productosnuevo> Productosnuevos { get; set; }

    public virtual DbSet<Proveedore> Proveedores { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        => optionsBuilder.UseMySql("server=localhost;database=SIGIV;uid=root;pwd=admin", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.44-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("latin1_swedish_ci")
            .HasCharSet("latin1");

        modelBuilder.Entity<Asignacionrolesopcione>(entity =>
        {
            entity.HasKey(e => e.IdAsignacionRol).HasName("PRIMARY");

            entity.ToTable("asignacionrolesopciones");

            entity.HasIndex(e => e.IdOpcion, "idOpcion");

            entity.HasIndex(e => e.IdRol, "idRol");

            entity.Property(e => e.IdAsignacionRol)
                .HasColumnType("int(11)")
                .HasColumnName("idAsignacionRol");
            entity.Property(e => e.IdOpcion)
                .HasColumnType("int(11)")
                .HasColumnName("idOpcion");
            entity.Property(e => e.IdRol)
                .HasColumnType("int(11)")
                .HasColumnName("idRol");

            entity.HasOne(d => d.IdOpcionNavigation).WithMany(p => p.Asignacionrolesopciones)
                .HasForeignKey(d => d.IdOpcion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("asignacionrolesopciones_ibfk_2");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Asignacionrolesopciones)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("asignacionrolesopciones_ibfk_1");
        });

        modelBuilder.Entity<Cargo>(entity =>
        {
            entity.HasKey(e => e.IdCargo).HasName("PRIMARY");

            entity.ToTable("cargos");

            entity.Property(e => e.IdCargo)
                .HasColumnType("int(11)")
                .HasColumnName("idCargo");
            entity.Property(e => e.Cargo1)
                .HasMaxLength(50)
                .HasColumnName("cargo");
        });

        modelBuilder.Entity<Categoriasproducto>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PRIMARY");

            entity.ToTable("categoriasproductos");

            entity.Property(e => e.IdCategoria)
                .HasColumnType("int(11)")
                .HasColumnName("idCategoria");
            entity.Property(e => e.Categoria)
                .HasMaxLength(40)
                .HasColumnName("categoria");
            entity.Property(e => e.Detalles)
                .HasMaxLength(50)
                .HasColumnName("detalles");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Idcliente).HasName("PRIMARY");

            entity.ToTable("clientes");

            entity.HasIndex(e => e.IdDireccion, "idDireccion");

            entity.Property(e => e.Idcliente)
                .HasColumnType("int(11)")
                .HasColumnName("IDCliente");
            entity.Property(e => e.ApellidosCliente)
                .HasMaxLength(30)
                .HasColumnName("apellidosCliente");
            entity.Property(e => e.Dui)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("dui")
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.EMail)
                .HasMaxLength(40)
                .HasColumnName("eMail");
            entity.Property(e => e.IdDireccion)
                .HasColumnType("int(11)")
                .HasColumnName("idDireccion");
            entity.Property(e => e.NombresCliente)
                .HasMaxLength(30)
                .HasColumnName("nombresCliente");
            entity.Property(e => e.Telefono)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("telefono")
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");

            entity.HasOne(d => d.IdDireccionNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdDireccion)
                .HasConstraintName("clientes_ibfk_1");
        });

        modelBuilder.Entity<Contactosproveedor>(entity =>
        {
            entity.HasKey(e => e.IdContacto).HasName("PRIMARY");

            entity.ToTable("contactosproveedor");

            entity.HasIndex(e => e.IdProveedor, "idProveedor");

            entity.Property(e => e.IdContacto)
                .HasColumnType("int(11)")
                .HasColumnName("idContacto");
            entity.Property(e => e.ApellidosContacto).HasMaxLength(30);
            entity.Property(e => e.CargoContacto)
                .HasMaxLength(60)
                .HasColumnName("cargoContacto");
            entity.Property(e => e.EMailContacto)
                .HasMaxLength(30)
                .HasColumnName("eMailContacto");
            entity.Property(e => e.IdProveedor)
                .HasColumnType("int(11)")
                .HasColumnName("idProveedor");
            entity.Property(e => e.NombresContacto)
                .HasMaxLength(20)
                .HasColumnName("nombresContacto");
            entity.Property(e => e.Observacion)
                .HasMaxLength(150)
                .HasColumnName("observacion");
            entity.Property(e => e.TelefonoContacto)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("telefonoContacto")
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.Contactosproveedors)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("contactosproveedor_ibfk_1");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.IdDepartamento).HasName("PRIMARY");

            entity.ToTable("departamentos");

            entity.HasIndex(e => e.IdPais, "idPais");

            entity.Property(e => e.IdDepartamento)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("idDepartamento");
            entity.Property(e => e.Departamento1)
                .HasMaxLength(60)
                .HasColumnName("Departamento");
            entity.Property(e => e.IdPais)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("idPais");

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.Departamentos)
                .HasForeignKey(d => d.IdPais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("departamentos_ibfk_1");
        });

        modelBuilder.Entity<Detallesfactura>(entity =>
        {
            entity.HasKey(e => e.IdDetalles).HasName("PRIMARY");

            entity.ToTable("detallesfacturas");

            entity.HasIndex(e => e.IdFactura, "idFactura");

            entity.HasIndex(e => e.IdProducto, "idProducto");

            entity.Property(e => e.IdDetalles)
                .HasColumnType("int(11)")
                .HasColumnName("idDetalles");
            entity.Property(e => e.Cantidad)
                .HasColumnType("int(11)")
                .HasColumnName("cantidad");
            entity.Property(e => e.Descuento)
                .HasColumnType("double(10,2)")
                .HasColumnName("descuento");
            entity.Property(e => e.IdFactura)
                .HasColumnType("int(11)")
                .HasColumnName("idFactura");
            entity.Property(e => e.IdProducto)
                .HasColumnType("int(11)")
                .HasColumnName("idProducto");
            entity.Property(e => e.Iva)
                .HasColumnType("double(10,2)")
                .HasColumnName("iva");

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.Detallesfacturas)
                .HasForeignKey(d => d.IdFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("detallesfacturas_ibfk_2");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.Detallesfacturas)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("detallesfacturas_ibfk_1");
        });

        modelBuilder.Entity<Detallespedido>(entity =>
        {
            entity.HasKey(e => e.IdDetallep).HasName("PRIMARY");

            entity.ToTable("detallespedidos");

            entity.HasIndex(e => e.IdPedido, "idPedido");

            entity.HasIndex(e => e.IdProductoNuevo, "idProductoNuevo");

            entity.Property(e => e.IdDetallep)
                .HasColumnType("int(11)")
                .HasColumnName("idDetallep");
            entity.Property(e => e.Cantidad)
                .HasColumnType("int(11)")
                .HasColumnName("cantidad");
            entity.Property(e => e.Comentarios)
                .HasMaxLength(200)
                .HasColumnName("comentarios");
            entity.Property(e => e.DescuetoUnidad)
                .HasColumnType("double(10,2)")
                .HasColumnName("descuetoUnidad");
            entity.Property(e => e.IdPedido)
                .HasColumnType("int(11)")
                .HasColumnName("idPedido");
            entity.Property(e => e.IdProductoNuevo)
                .HasColumnType("int(11)")
                .HasColumnName("idProductoNuevo");
            entity.Property(e => e.PrecioUnidad)
                .HasColumnType("double(10,2)")
                .HasColumnName("precioUnidad");

            entity.HasOne(d => d.IdPedidoNavigation).WithMany(p => p.Detallespedidos)
                .HasForeignKey(d => d.IdPedido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("detallespedidos_ibfk_2");

            entity.HasOne(d => d.IdProductoNuevoNavigation).WithMany(p => p.Detallespedidos)
                .HasForeignKey(d => d.IdProductoNuevo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("detallespedidos_ibfk_1");
        });

        modelBuilder.Entity<Detallesstok>(entity =>
        {
            entity.HasKey(e => e.IdStok).HasName("PRIMARY");

            entity.ToTable("detallesstok");

            entity.Property(e => e.IdStok)
                .HasColumnType("int(11)")
                .HasColumnName("idStok");
            entity.Property(e => e.CantidadStok)
                .HasColumnType("int(11)")
                .HasColumnName("cantidadStok");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(30)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<Direccione>(entity =>
        {
            entity.HasKey(e => e.IdDireccion).HasName("PRIMARY");

            entity.ToTable("direcciones");

            entity.HasIndex(e => e.IdDistrito, "idDistrito");

            entity.Property(e => e.IdDireccion)
                .HasColumnType("int(11)")
                .HasColumnName("idDireccion");
            entity.Property(e => e.CodigoPostal).HasColumnType("int(11)");
            entity.Property(e => e.IdDistrito)
                .HasMaxLength(5)
                .HasColumnName("idDistrito");
            entity.Property(e => e.Linea1).HasMaxLength(100);
            entity.Property(e => e.Linea2).HasMaxLength(100);

            entity.HasOne(d => d.IdDistritoNavigation).WithMany(p => p.Direcciones)
                .HasForeignKey(d => d.IdDistrito)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("direcciones_ibfk_1");
        });

        modelBuilder.Entity<Distrito>(entity =>
        {
            entity.HasKey(e => e.IdDistrito).HasName("PRIMARY");

            entity.ToTable("distritos");

            entity.HasIndex(e => e.IdMunicipio, "idMunicipio");

            entity.Property(e => e.IdDistrito)
                .HasMaxLength(5)
                .HasColumnName("idDistrito");
            entity.Property(e => e.Distrito1)
                .HasMaxLength(60)
                .HasColumnName("Distrito");
            entity.Property(e => e.IdMunicipio)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("idMunicipio");

            entity.HasOne(d => d.IdMunicipioNavigation).WithMany(p => p.Distritos)
                .HasForeignKey(d => d.IdMunicipio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("distritos_ibfk_1");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.IdEmpleado).HasName("PRIMARY");

            entity.ToTable("empleados");

            entity.HasIndex(e => e.IdCargo, "idCargo");

            entity.HasIndex(e => e.IdDireccion, "idDireccion");

            entity.Property(e => e.IdEmpleado)
                .HasColumnType("int(11)")
                .HasColumnName("idEmpleado");
            entity.Property(e => e.ApellidosEmpleado)
                .HasMaxLength(30)
                .HasColumnName("apellidosEmpleado");
            entity.Property(e => e.Dui)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("dui")
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.EMail)
                .HasMaxLength(40)
                .HasColumnName("eMail");
            entity.Property(e => e.FechaNacimiento).HasColumnName("fechaNacimiento");
            entity.Property(e => e.IdCargo)
                .HasColumnType("int(11)")
                .HasColumnName("idCargo");
            entity.Property(e => e.IdDireccion)
                .HasColumnType("int(11)")
                .HasColumnName("idDireccion");
            entity.Property(e => e.Isss)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("ISSS")
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.NombresEmpleado)
                .HasMaxLength(30)
                .HasColumnName("nombresEmpleado");
            entity.Property(e => e.Telefono)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("telefono")
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");

            entity.HasOne(d => d.IdCargoNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdCargo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("empleados_ibfk_2");

            entity.HasOne(d => d.IdDireccionNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdDireccion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("empleados_ibfk_1");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.IdFactura).HasName("PRIMARY");

            entity.ToTable("facturas");

            entity.HasIndex(e => e.Idcliente, "idcliente");

            entity.HasIndex(e => e.Idempleado, "idempleado");

            entity.Property(e => e.IdFactura)
                .HasColumnType("int(11)")
                .HasColumnName("idFactura");
            entity.Property(e => e.Comentario)
                .HasMaxLength(40)
                .HasColumnName("comentario");
            entity.Property(e => e.FechaFactura)
                .HasColumnType("datetime")
                .HasColumnName("fechaFactura");
            entity.Property(e => e.Idcliente)
                .HasColumnType("int(11)")
                .HasColumnName("idcliente");
            entity.Property(e => e.Idempleado)
                .HasColumnType("int(11)")
                .HasColumnName("idempleado");

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.Idcliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("facturas_ibfk_2");

            entity.HasOne(d => d.IdempleadoNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.Idempleado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("facturas_ibfk_1");
        });

        modelBuilder.Entity<Municipio>(entity =>
        {
            entity.HasKey(e => e.IdMunicipio).HasName("PRIMARY");

            entity.ToTable("municipios");

            entity.HasIndex(e => e.IdDepartamento, "idDepartamento");

            entity.Property(e => e.IdMunicipio)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("idMunicipio");
            entity.Property(e => e.IdDepartamento)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("idDepartamento");
            entity.Property(e => e.Municipio1)
                .HasMaxLength(60)
                .HasColumnName("Municipio");

            entity.HasOne(d => d.IdDepartamentoNavigation).WithMany(p => p.Municipios)
                .HasForeignKey(d => d.IdDepartamento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("municipios_ibfk_1");
        });

        modelBuilder.Entity<Opcione>(entity =>
        {
            entity.HasKey(e => e.IdOpcion).HasName("PRIMARY");

            entity.ToTable("opciones");

            entity.Property(e => e.IdOpcion)
                .HasColumnType("int(11)")
                .HasColumnName("idOpcion");
            entity.Property(e => e.Opcion)
                .HasMaxLength(50)
                .HasColumnName("opcion");
        });

        modelBuilder.Entity<Paise>(entity =>
        {
            entity.HasKey(e => e.IdPais).HasName("PRIMARY");

            entity.ToTable("paises");

            entity.Property(e => e.IdPais)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("idPais");
            entity.Property(e => e.Pais).HasMaxLength(60);
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.IdPedido).HasName("PRIMARY");

            entity.ToTable("pedidos");

            entity.HasIndex(e => e.IdProveedor, "idProveedor");

            entity.Property(e => e.IdPedido)
                .HasColumnType("int(11)")
                .HasColumnName("idPedido");
            entity.Property(e => e.Comentario)
                .HasMaxLength(100)
                .HasColumnName("comentario");
            entity.Property(e => e.FechaPedido)
                .HasColumnType("datetime")
                .HasColumnName("fechaPedido");
            entity.Property(e => e.FechaRecibido)
                .HasColumnType("datetime")
                .HasColumnName("fechaRecibido");
            entity.Property(e => e.IdProveedor)
                .HasColumnType("int(11)")
                .HasColumnName("idProveedor");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("pedidos_ibfk_1");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PRIMARY");

            entity.ToTable("productos");

            entity.HasIndex(e => e.IdCategoria, "idCategoria");

            entity.HasIndex(e => e.IdStok, "idStok");

            entity.Property(e => e.IdProducto)
                .HasColumnType("int(11)")
                .HasColumnName("idProducto");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(45)
                .HasColumnName("descripcion");
            entity.Property(e => e.IdCategoria)
                .HasColumnType("int(11)")
                .HasColumnName("idCategoria");
            entity.Property(e => e.IdStok)
                .HasColumnType("int(11)")
                .HasColumnName("idStok");
            entity.Property(e => e.NombreP)
                .HasMaxLength(30)
                .HasColumnName("nombreP");
            entity.Property(e => e.Precio)
                .HasColumnType("double(10,2)")
                .HasColumnName("precio");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("productos_ibfk_1");

            entity.HasOne(d => d.IdStokNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdStok)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("productos_ibfk_2");
        });

        modelBuilder.Entity<Productosnuevo>(entity =>
        {
            entity.HasKey(e => e.IdProductoNuevo).HasName("PRIMARY");

            entity.ToTable("productosnuevos");

            entity.Property(e => e.IdProductoNuevo)
                .HasColumnType("int(11)")
                .HasColumnName("idProductoNuevo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(45)
                .HasColumnName("descripcion");
            entity.Property(e => e.IdCategoria)
                .HasColumnType("int(11)")
                .HasColumnName("idCategoria");
            entity.Property(e => e.IdStok)
                .HasColumnType("int(11)")
                .HasColumnName("idStok");
            entity.Property(e => e.NombreP)
                .HasMaxLength(30)
                .HasColumnName("nombreP");
            entity.Property(e => e.Precio)
                .HasColumnType("double(10,2)")
                .HasColumnName("precio");
        });

        modelBuilder.Entity<Proveedore>(entity =>
        {
            entity.HasKey(e => e.IdProveedor).HasName("PRIMARY");

            entity.ToTable("proveedores");

            entity.HasIndex(e => e.IdDireccion, "idDireccion");

            entity.Property(e => e.IdProveedor)
                .HasColumnType("int(11)")
                .HasColumnName("idProveedor");
            entity.Property(e => e.Compania)
                .HasMaxLength(20)
                .HasColumnName("compania");
            entity.Property(e => e.EMailProveedor)
                .HasMaxLength(30)
                .HasColumnName("eMailProveedor");
            entity.Property(e => e.Giro)
                .HasMaxLength(60)
                .HasColumnName("giro");
            entity.Property(e => e.IdDireccion)
                .HasColumnType("int(11)")
                .HasColumnName("idDireccion");
            entity.Property(e => e.Nit)
                .HasMaxLength(20)
                .HasColumnName("nit");
            entity.Property(e => e.TelefonoProveedor)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("telefonoProveedor")
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.Web)
                .HasMaxLength(100)
                .HasColumnName("web");

            entity.HasOne(d => d.IdDireccionNavigation).WithMany(p => p.Proveedores)
                .HasForeignKey(d => d.IdDireccion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("proveedores_ibfk_1");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PRIMARY");

            entity.ToTable("roles");

            entity.Property(e => e.IdRol)
                .HasColumnType("int(11)")
                .HasColumnName("idRol");
            entity.Property(e => e.MombreRol)
                .HasMaxLength(50)
                .HasColumnName("mombreRol");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Idusuario).HasName("PRIMARY");

            entity.ToTable("usuarios");

            entity.HasIndex(e => e.IdEmpleado, "idEmpleado");

            entity.HasIndex(e => e.IdRol, "idRol");

            entity.Property(e => e.Idusuario)
                .HasColumnType("int(11)")
                .HasColumnName("IDUsuario");
            entity.Property(e => e.Clave)
                .HasMaxLength(40)
                .IsFixedLength()
                .HasColumnName("clave")
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.IdEmpleado)
                .HasColumnType("int(11)")
                .HasColumnName("idEmpleado");
            entity.Property(e => e.IdRol)
                .HasColumnType("int(11)")
                .HasColumnName("idRol");
            entity.Property(e => e.Usuario1)
                .HasMaxLength(50)
                .HasColumnName("usuario");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdEmpleado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("usuarios_ibfk_2");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("usuarios_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
