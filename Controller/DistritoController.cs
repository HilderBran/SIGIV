using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class DistritoController
    {
        public string Id { get; set; } = null!;

        public string Nombre { get; set; } = null!;

        public string IdMunicipio { get; set; } = null!;

        public string Municipio { get; set; } = null!;

        public async Task<bool> AddDistrito()
        {
            bool bandera = false;

            using (SigivContext context = new SigivContext())
            {
                Distrito distrito = new Distrito
                {
                    IdDistrito = Id,
                    Distrito1 = Nombre,
                    IdMunicipio = IdMunicipio
                };
                context.Distritos.Add(distrito);
                await context.SaveChangesAsync();
                bandera = true;
            }
            return bandera;
        }

        public async Task<bool> DeteleDistrito()
        {
            bool bandera = false;

            using (SigivContext context = new SigivContext())
            {
                Distrito distrito = await context.Distritos.FirstOrDefaultAsync(distrito
                                    => distrito.IdDistrito == Id) ?? null!;
                if (distrito != null)
                {
                    context.Distritos.Remove(distrito);
                    await context.SaveChangesAsync();
                    bandera = true;
                }
            }
            return bandera;
        }

        public async static Task<List<DistritoController>> GetDistritos()
        {
            List<DistritoController> distritos = new List<DistritoController>();

            using (SigivContext context = new SigivContext())
            {
                distritos = await context.Distritos.Select(distrito => new DistritoController
                {
                    Id = distrito.IdDistrito,
                    Nombre = distrito.Distrito1,
                    IdMunicipio = distrito.IdMunicipio,
                    Municipio = distrito.IdMunicipioNavigation.Municipio1
                }).ToListAsync();
            }
            return distritos;
        }

        public static DistritoController ConvertToController(Distrito distrito)
        {
            return new DistritoController
            {
                Id = distrito.IdDistrito,
                Nombre = distrito.Distrito1,
                IdMunicipio = distrito.IdMunicipio,
                Municipio = distrito.IdMunicipioNavigation.Municipio1
            };
        }

        public async static Task<List<DistritoController>> GetDistritosByIdMunicipio(string IdMunicipio)
        {
            List<DistritoController> distritos = new List<DistritoController>();

            using (SigivContext context = new SigivContext())
            {
                distritos = await context.Distritos.Where(distrito
                            => distrito.IdMunicipio == IdMunicipio).Select(distrito
                            => ConvertToController(distrito)).ToListAsync();
            }
            return distritos;
        }

        public async static Task<DistritoController> GetDistritoById(string Id)
        {
            DistritoController distrito = new DistritoController();

            using (SigivContext context = new SigivContext())
            {
                distrito = ConvertToController(await context.Distritos.FirstOrDefaultAsync(distrito
                                               => distrito.IdDistrito == Id) ?? null!);
            }
            return distrito;
        }

        public async Task<bool> UpdateDistrito()
        {
            bool bandera = false;

            using (SigivContext context = new SigivContext())
            {
                Distrito distrito = await context.Distritos.FirstOrDefaultAsync(distrito
                                    => distrito.IdDistrito == Id) ?? null!;
                if (distrito != null)
                {
                    distrito.Distrito1 = Nombre;
                    distrito.IdMunicipio = IdMunicipio;
                    await context.SaveChangesAsync();
                    bandera = true;
                }
            }
            return bandera;
        }

        public async static Task<List<DistritoController >> FiltrarDistritos (string query)
        {
            List<DistritoController> distritos = new List<DistritoController>();

            using (SigivContext context = new SigivContext())
            {
                distritos = await context.Distritos.Include(distrito
                                       => distrito.IdMunicipioNavigation).Where(distrito
                                       => distrito.Distrito1.Contains(query)).Select(distrito
                                       => ConvertToController(distrito)).ToListAsync();
            }
            return distritos;
        }
    }
}
