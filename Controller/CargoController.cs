using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace Controller
{
    public class CargoController
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public  static CargoController ConvertToController(Cargo cargo)
        {
            return new CargoController
            {
                Id = cargo.IdCargo,
                Nombre = cargo.Cargo1
            };
        }

        public async static Task<List<CargoController>> GetCargos()
        {
            List<CargoController> cargos = new List<CargoController>();
            using (var db = new Models.Entities.SigivContext())
            {
                cargos = await db.Cargos.Select(c => ConvertToController(c)).ToListAsync();
            }
            return cargos;
        }

        public async static Task<CargoController> GetCargo(int id)
        {
            CargoController cargo = new CargoController();
            using (var db = new Models.Entities.SigivContext())
            {
                cargo = ConvertToController(await db.Cargos.FindAsync(id)??null!);
            }
            return cargo;
        }

        public async Task<bool> DeteleCargo()
        {
            bool bandera = false;

            using (SigivContext context = new SigivContext())
            {
                Cargo cargo = await context.Cargos.FirstOrDefaultAsync(cargo
                              => cargo.IdCargo == Id) ?? null!;
                if (cargo != null)
                {
                    context.Cargos.Remove(cargo);
                    await context.SaveChangesAsync();
                    bandera = true;
                }
            }
            return bandera;
        }

        public async Task<bool> UpdateCargo()
        {
            bool bandera = false;

            using (SigivContext context = new SigivContext())
            {
                Cargo cargo = await context.Cargos.FirstOrDefaultAsync(cargo
                              => cargo.IdCargo == Id) ?? null!;
                if (cargo != null)
                {
                    cargo.Cargo1 = Nombre;
                    await context.SaveChangesAsync();
                    bandera = true;
                }
            }
            return bandera;
        }

        public async Task<bool> AddCargo()
        {
            bool bandera = false;

            using (SigivContext context = new SigivContext())
            {
                Cargo cargo = new Cargo
                {
                    Cargo1 = Nombre
                };
                context.Cargos.Add(cargo);
                await context.SaveChangesAsync();
                bandera = true;
            }
            return bandera;
        }

        public async static Task<List<CargoController>> FiltrarCargos(string filtro)
        {
            List<CargoController> cargos = new List<CargoController>();
            using (var db = new Models.Entities.SigivContext())
            {
                cargos = await db.Cargos.Where(c => c.Cargo1.Contains(filtro)).Select(c 
                    => ConvertToController(c)).ToListAsync();
            }
            return cargos;
        }
    }
}
