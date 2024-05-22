using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class DepartamentoController
    {
        public string Id { get; set; } = null!;

        public string Nombre { get; set; } = null!;

        public string IdPais { get; set; } = null!;

        public string Pais { get; set; } = null!;

        public async static Task<List<DepartamentoController>> GetDepartamentos()
        {
            List<DepartamentoController> departamentos = new List<DepartamentoController>();
            using (Models.Entities.SigivContext db = new Models.Entities.SigivContext())
            {
                departamentos = await db.Departamentos.Include(d => d.IdPaisNavigation)
                    .Select(d => ConvertToController(d))
                    .ToListAsync();
            }
            return departamentos;
        }
        public async static Task<List<DepartamentoController>> GetDepartamentosByIdPais(string id)
        {
            List<DepartamentoController> departamentos = new List<DepartamentoController>();
            using (Models.Entities.SigivContext db = new Models.Entities.SigivContext())
            {
                departamentos = await db.Departamentos.Include(d => d.IdPaisNavigation)
                    .Where(d => d.IdPais == id)
                    .Select(d => ConvertToController(d))
                    .ToListAsync();
            }
            return departamentos;
        }

        public static DepartamentoController ConvertToController(Models.Entities.Departamento departamento)
        {
            return new DepartamentoController
            {
                Id = departamento.IdDepartamento,
                Nombre = departamento.Departamento1,
                IdPais = departamento.IdPais,
                Pais = departamento.IdPaisNavigation.Pais,
            };
        }

        public async static Task<DepartamentoController> GetDepartamento(string id)
        {
            DepartamentoController departamento = new DepartamentoController();
            using (Models.Entities.SigivContext db = new Models.Entities.SigivContext())
            {
                Models.Entities.Departamento d = await db.Departamentos.FindAsync(id)??null!;
                departamento = ConvertToController(d);
            }
            return departamento;
        }

        public async Task<bool> Agregar()
        {
            bool exito = false;
            using (Models.Entities.SigivContext db = new Models.Entities.SigivContext())
            {
                Models.Entities.Departamento departamento = new Models.Entities.Departamento
                {
                    IdDepartamento = Id,
                    Departamento1 = Nombre,
                    IdPais = IdPais,
                };
                db.Departamentos.Add(departamento);
                exito = await db.SaveChangesAsync() > 0;
            }
            return exito;
        }

        public async Task<bool> Editar()
        {
            bool exito = false;
            using (Models.Entities.SigivContext db = new Models.Entities.SigivContext())
            {
                Models.Entities.Departamento departamento = await db.Departamentos.FindAsync(Id)??null!;
                if (departamento != null)
                {
                    departamento.Departamento1 = Nombre;
                    departamento.IdPais = IdPais;
                    db.Departamentos.Update(departamento);
                    exito = await db.SaveChangesAsync() > 0;
                }
            }
            return exito;
        }

        public async Task<bool> Eliminar()
        {
            bool exito = false;
            using (Models.Entities.SigivContext db = new Models.Entities.SigivContext())
            {
                Models.Entities.Departamento departamento = await db.Departamentos.FindAsync(Id)??null!;
                if (departamento != null)
                {
                    db.Departamentos.Remove(departamento);
                    exito = await db.SaveChangesAsync() > 0;
                }
            }
            return exito;
        }

        public async static Task<List<DepartamentoController>> Buscar(string busqueda)
        {
            List<DepartamentoController> departamentos = new List<DepartamentoController>();
            using (Models.Entities.SigivContext db = new Models.Entities.SigivContext())
            {
                departamentos = await db.Departamentos.Include(d => d.IdPaisNavigation)
                    .Where(d => d.Departamento1.Contains(busqueda)
                    || d.IdDepartamento.Contains(busqueda)
                    || d.IdPaisNavigation.Pais.Contains(busqueda))
                    .Select(d => ConvertToController(d))
                    .ToListAsync();
            }
            return departamentos;
        }
    }
}
