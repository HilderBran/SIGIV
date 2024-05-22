using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class OpcionController
    {

        public int Id { get; set; }

        public string Nombre { get; set; } = null!;


        public async static Task<List<OpcionController>> GetAsync()
        {
            List<OpcionController> opcines = new List<OpcionController>();
            using (var context = new SigivContext())
            {
                opcines = await context.Opciones.Select(opcion  => ConvertToController(opcion))
                        .ToListAsync();
            }
            return  opcines;
        }

        public async Task<bool> SaveAsync()
        {
            bool result = false;

            using (var context = new SigivContext())
            {
                var opcion = new Opcione
                {
                    Opcion = this.Nombre,
                };
                context.Opciones.Add(opcion);
                int row = await context.SaveChangesAsync();
                result = row > 0;
            }

            return result;
        }


        public async Task<bool> DeleteAsync()
        {
            bool result = false;

            using (var context = new SigivContext())
            {
                var opcion = new Opcione
                {
                    IdOpcion = this.Id,
                    Opcion = this.Nombre,
                };
                context.Opciones.Remove(opcion);
                int row = await context.SaveChangesAsync();
                result = row > 0;
            }

            return result;
        }

        public async Task<bool> UpdateAsync()
        {
            bool result = false;

            using (var context = new SigivContext())
            {
                var opcion = new Opcione
                {
                    IdOpcion = this.Id,
                    Opcion = this.Nombre,
                };
                context.Opciones.Update(opcion);
                int row = await context.SaveChangesAsync();
                result = row > 0;
            }

            return result;
        }

        public static OpcionController ConvertToController(Opcione opcion)
        {
            return new OpcionController
            {
                Id = opcion.IdOpcion,
                Nombre = opcion.Opcion,
            };
        }

    }
}
