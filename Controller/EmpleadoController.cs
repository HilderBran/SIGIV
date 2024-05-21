using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Controller
{
    internal class EmpleadoController
    {
		public int Id{ get; set; }
		public string Nombres { get; set; } = null!;
		public string Apellidos { get; set; } = null!;
		public DateOnly FechaNacimiento { get; set; }
		public string Dui { get; set; } = null!;
		public string Isss { get; set; } = null!;
		public string Telefono { get; set; } = null!;
		public string EMail { get; set; } = null!;
		public int IdCargo { get; set; }
		public string Cargo { get; set; } = null!;
        public int IdDireccion { get; set; }
        public string Direccion { get; set; } = null!;

        public async Task<bool> AddEmpleado()
        {
            bool bandera = false;

            using (SigivContext context = new SigivContext())
            {
                Empleado empleado = new Empleado
                {
                    IdEmpleado = Id,
                    NombresEmpleado = Nombres,
                    ApellidosEmpleado = Apellidos,
                    FechaNacimiento = FechaNacimiento,
                    Dui = Dui,
                    Isss = Isss,
                    Telefono = Telefono,
                    EMail = EMail,
                    IdCargo = IdCargo,
                    IdDireccion = IdDireccion
                };
                context.Empleados.Add(empleado);
                await context.SaveChangesAsync();
                bandera = true;
            }
            return bandera;
        }
        public async Task<bool> DeleteAsync()
        {
            bool bandera = false;
            using (SigivContext context = new SigivContext())
            {
                Empleado empleado = await context.Empleados.FirstOrDefaultAsync(empleado => empleado.IdEmpleado == Id) ?? null!;
                if (empleado != null)
                {
                    context.Empleados.Remove(empleado);
                    await context.SaveChangesAsync();
                    bandera = true;
                }
            }
            return bandera;
        }
        public async static Task<List<EmpleadoController>> GetAsync()
        {
            List<EmpleadoController> empleados = new List<EmpleadoController>();
            using (SigivContext context = new SigivContext())
            {
                empleados = await context.Empleados.Include(empleado 
                    => empleado.IdDireccionNavigation).ThenInclude(direccion 
                    => direccion.IdDistritoNavigation).ThenInclude(distrito 
                    => distrito.IdMunicipioNavigation).ThenInclude(municipio 
                    => municipio.IdDepartamentoNavigation).ThenInclude(departamento 
                    => departamento.IdPaisNavigation).Include(empleado 
                    => empleado.IdCargoNavigation).Select(empleado 
                    => ConvertToController(empleado)).ToListAsync();
            }
            return empleados;
        }
        public async Task<List<EmpleadoController>> GetCargoByIdCargo(string IdMunicipio)
        {
            List<EmpleadoController> empleados = new List<EmpleadoController>();
            using (SigivContext context = new SigivContext())
            {
                empleados = await context.Empleados.Include(empleado
                                        => empleado.IdDireccionNavigation).ThenInclude(direccion
                                        => direccion.IdDistritoNavigation).ThenInclude(distrito
                                        => distrito.IdMunicipioNavigation).ThenInclude(municipio
                                        => municipio.IdDepartamentoNavigation).ThenInclude(departamento
                                        => departamento.IdPaisNavigation).Include(empleado
                                        => empleado.IdCargoNavigation).Where(empleado 
                                       => empleado.IdCargo == IdCargo).Select(empleado 
                                       => ConvertToController(empleado)).ToListAsync();
            }
            return empleados;
        }
        public static EmpleadoController ConvertToController(Empleado empleado)
        {
            return new EmpleadoController
            {
                Id = empleado.IdEmpleado,
                Nombres = empleado.NombresEmpleado,
                Apellidos= empleado.ApellidosEmpleado,
                FechaNacimiento = empleado.FechaNacimiento,
                Dui = empleado.Dui,
                Isss = empleado.Isss,
                Telefono = empleado.Telefono,
                EMail = empleado.EMail,
                IdCargo = empleado.IdCargo,
                Cargo = empleado.IdCargoNavigation.Cargo1,
                IdDireccion = empleado.IdDireccion,
                Direccion = string.Format($"{empleado.IdDireccionNavigation.IdDistritoNavigation.IdMunicipioNavigation.IdDepartamentoNavigation.IdPaisNavigation.Pais}," +
                                          $"{empleado.IdDireccionNavigation.IdDistritoNavigation.IdMunicipioNavigation.IdDepartamentoNavigation.Departamento1}," +
                                          $"{empleado.IdDireccionNavigation.IdDistritoNavigation.IdMunicipioNavigation.Municipio1}," +
                                          $"{empleado.IdDireccionNavigation.IdDistritoNavigation.Distrito1}," +
                                          $"{empleado.IdDireccionNavigation.Linea1}," +
                                          $"{empleado.IdDireccionNavigation.Linea2}")
            };
        }
    }
}
