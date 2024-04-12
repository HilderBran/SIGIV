-- create database if not exists SIGIV;
-- use SIGIV;

create table if not exists Paises(
	idPais char(3) primary key,
    Pais varchar(60) not null
);
create table if not exists Departamentos(
	idDepartamento char(2) primary key,
    Departamento varchar(60) not null,
    idPais char(3) not null
);
create table if not exists Municipios(
	idMunicipio char(3) primary key,
	Municipio varchar(60) not null,
	idDepartamento char(2) not null
);
create table if not exists Distritos(
	idDistrito varchar(5) primary key,
	Distrito varchar(60) not null,
	idMunicipio char(3) not null
);
create table if not exists Direcciones(
	idDireccion int auto_increment primary key,
    Linea1 varchar(100) not null,
    Linea2 varchar(100),
    idDistrito varchar(5) not null,
    CodigoPostal int
);
-- cliente
create table if not exists Clientes(
	IDCliente int auto_increment primary key,
	nombresCliente varchar(30) not null,
	apellidosCliente varchar(30) not null,
	dui nchar(11) not null,
	telefono nchar(11),
	eMail varchar(40),
	idDireccion int
); 

-- empleados
create table if not exists Cargos(
	idCargo int auto_increment primary key,
	cargo varchar(50) not null
);
create table  if not exists Empleados(
	idEmpleado int auto_increment primary key,
	nombresEmpleado varchar(30) not null,
	apellidosEmpleado varchar(30) not null,
	fechaNacimiento date not null,
	dui nchar(11) not null,
	ISSS nchar(15) not null,
	telefono nchar(11) not null,
	eMail varchar(40),
	idCargo int not null,
	idDireccion int not null
);

-- roles
create table if not exists Opciones(
	idOpcion int auto_increment primary key,
	opcion varchar(50) not null
);
create table if not exists Roles(
	idRol int auto_increment primary key,
	mombreRol varchar(50) not null
);
create table if not exists AsignacionRolesOpciones(
	idAsignacionRol int auto_increment primary key,
	idRol int not null,
	idOpcion int not null
);
-- usuarios para la manipuacion de datos
create table if not exists Usuarios(
	IDUsuario int auto_increment primary key,
	idEmpleado int not null,
	idRol int not null,
	usuario varchar(50) not null,
	clave nchar(40) not null
);

-- Proveedores
create table if not exists Proveedores(
	idProveedor int auto_increment primary key,
	compania varchar(20) not null,
    nit varchar(20) not null,
	telefonoProveedor nchar(11) not null,
	eMailProveedor varchar(30) not null,
    web varchar(100),
    giro varchar(60) not null,
	idDireccion int not null
);
create table if not exists ContactosProveedor(
	idContacto int auto_increment primary key,
	nombresContacto varchar(20),
	ApellidosContacto varchar(30),
    cargoContacto varchar(60) not null,
	telefonoContacto nchar(11) not null,
	eMailContacto varchar(30) not null,
    observacion varchar(150),
    idProveedor int not null
);

-- Productos
create table if not exists CategoriasProductos(
	idCategoria int auto_increment primary key,
	categoria varchar(40),
	detalles varchar(50)
);
create table if not exists DetallesStok(
	idStok int auto_increment primary key,
	cantidadStok int not null,
	descripcion varchar(30)
);
create table if not exists Productos(
	idProducto int auto_increment primary key,
	nombreP varchar(30) not null,
	descripcion varchar (45),
	precio double(10,2) not null,
	idCategoria int not null,
	idStok int not null
);

-- compras a proveedores
create table if not exists Pedidos(
	idPedido int auto_increment primary key,
	idProveedor int not null,
	fechaPedido datetime not null,
	fechaRecibido datetime not null,
	comentario varchar(100)
);
create table if not exists DetallesPedidos(
    idDetallep INT AUTO_INCREMENT PRIMARY KEY,
    idProductoNuevo INT NOT NULL,
    idPedido INT NOT NULL,
    cantidad INT NOT NULL,
    precioUnidad DOUBLE(10 , 2 ) NOT NULL,
    descuetoUnidad DOUBLE(10 , 2 ) NOT NULL,
    comentarios VARCHAR(200)
);
create table if not exists ProductosNuevos(
	idProductoNuevo int auto_increment primary key,
	nombreP varchar(30) not null,
	descripcion varchar (45),
	precio double(10,2) not null,
	idCategoria int not null,
	idStok int not null
);

-- facturas
create table if not exists Facturas(
	idFactura int auto_increment primary key,
	fechaFactura datetime not null,
	comentario varchar(40),
	idcliente int not null,
	idempleado int not null
);
create table if not exists DetallesFacturas(
	idDetalles int auto_increment primary key,
	idProducto int not null,
	idFactura int not null,
	cantidad int not null,
	iva double(10,2) not null,
	descuento double(10,2) not null
);

-- llaves foraneas

-- direcciones
alter table Departamentos add foreign key (idPais) references Paises(idPais);
alter table Municipios add FOREIGN key (idDepartamento) references Departamentos(idDepartamento);
alter table Distritos add FOREIGN key (idMunicipio) references Municipios(idMunicipio);
alter table Direcciones add FOREIGN key (idDistrito) references Distritos(idDistrito);

-- cliente
alter table Clientes add FOREIGN key (idDireccion) references Direcciones(idDireccion);

-- empleado
alter table Empleados add FOREIGN key (idDireccion) references Direcciones(idDireccion);
alter table Empleados add FOREIGN key (idCargo) references Cargos(idCargo);

-- roles
alter table AsignacionRolesOpciones add FOREIGN key (idRol) references Roles(idRol);
alter table AsignacionRolesOpciones add FOREIGN key (idOpcion) references Opciones(idOpcion);

alter table Usuarios add FOREIGN key (idRol) references Roles(idRol);
alter table Usuarios add FOREIGN key (idEmpleado) references Empleados(idEmpleado);

-- proveedores
alter table ContactosProveedor add foreign key(idProveedor) references Proveedores(idProveedor);

-- productos 
alter table Proveedores add FOREIGN key (idDireccion) references Direcciones(idDireccion);

alter table Productos add FOREIGN key (idCategoria) references CategoriasProductos(idCategoria);
alter table Productos add FOREIGN key (idStok) references DetallesStok(idStok);

-- pedidos
alter table Pedidos add FOREIGN key (idProveedor) references Proveedores(idProveedor);

alter table DetallesPedidos add FOREIGN key (idProductoNuevo) references ProductosNuevos(idProductoNuevo);
alter table DetallesPedidos add FOREIGN key (idPedido) references Pedidos(idPedido);

-- facturas
alter table Facturas add FOREIGN key (idEmpleado) references Empleados(idEmpleado);
alter table Facturas add FOREIGN key (idCliente) references Clientes(idCliente);

alter table DetallesFacturas add FOREIGN key (idProducto) references Productos(idProducto);
alter table DetallesFacturas add FOREIGN key (idFactura) references Facturas(idFactura);