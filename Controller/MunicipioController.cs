using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class MunicipioController
    {
        public string Id { get; set; } = null!;

        public string Nombre { get; set; } = null!;

        public string IdDepartamento { get; set; } = null!;

        public string Departamento { get; set; } = null!;

        public async Task<bool> AddMunicipio()
        {
            bool bandera = false;

            using (SigivContext context = new SigivContext())
            {
                Municipio municipio = new Municipio
                {
                    IdMunicipio = Id,
                    Municipio1 = Nombre,
                    IdDepartamento = IdDepartamento
                };
                context.Municipios.Add(municipio);
                await context.SaveChangesAsync();
                bandera = true;
            }
            return bandera;
        }

        public async Task<bool> DeteleMunicipio()
        {
            bool bandera = false;

            using (SigivContext context = new SigivContext())
            {
                Municipio municipio = await context.Municipios.FirstOrDefaultAsync(municipio
                                                              => municipio.IdMunicipio == Id) ?? null!;
                if (municipio != null)
                {
                    context.Municipios.Remove(municipio);
                    await context.SaveChangesAsync();
                    bandera = true;
                }
            }
            return bandera;
        }

        public async static Task<List<MunicipioController>> GetMunicipios()
        {
            List<MunicipioController> municipios = new List<MunicipioController>();

            using (SigivContext context = new SigivContext())
            {
                municipios = await context.Municipios.Include(municipio 
                    => municipio.IdDepartamentoNavigation).Select(municipio 
                    => ConvertToController(municipio)).ToListAsync();
            }
            return municipios;
        }

        public async static Task<List<MunicipioController>> GetMunicipiosByIdDepartamento(string IdDepartamento)
        {
            List<MunicipioController> municipios = new List<MunicipioController>();

            using (SigivContext context = new SigivContext())
            {
                municipios = await context.Municipios.Include(municipio 
                                       => municipio.IdDepartamentoNavigation).Where(municipio 
                                       => municipio.IdDepartamento == IdDepartamento).Select(municipio 
                                       => ConvertToController(municipio)).ToListAsync();
            }
            return municipios;
        }

        public async Task<MunicipioController> GetMunicipioById(string IdMunicipio)
        {
            MunicipioController municipio = new MunicipioController();

            using (SigivContext context = new SigivContext())
            {
                municipio = ConvertToController(await context.Municipios.Include(municipio 
                                       => municipio.IdDepartamentoNavigation).FirstOrDefaultAsync(municipio 
                                       => municipio.IdMunicipio == IdMunicipio) ?? null!);
            }
            return municipio;
        }

        public async Task<bool> UpdateMunicipio()
        {
            bool bandera = false;

            using (SigivContext context = new SigivContext())
            {
                context.Municipios.Update(new Municipio
                {
                    IdMunicipio = Id,
                    Municipio1 = Nombre,
                    IdDepartamento = IdDepartamento
                });
                await context.SaveChangesAsync();
                bandera = true;
            }
            return bandera;
        }

        public async static Task<List<MunicipioController>> FiltrarMunicipios(String query)
        {
            List<MunicipioController> municipios = new List<MunicipioController>();

            using (SigivContext context = new SigivContext())
            {
                municipios = await context.Municipios.Include(municipio 
                                       => municipio.IdDepartamentoNavigation).Where(municipio 
                                       => municipio.Municipio1.Contains(query)).Select(municipio 
                                       => ConvertToController(municipio)).ToListAsync();
            }
            return municipios;
        }

        public static MunicipioController ConvertToController(Municipio municipio)
        {
            return new MunicipioController
            {
                Id = municipio.IdMunicipio,
                Nombre = municipio.Municipio1,
                IdDepartamento = municipio.IdDepartamento,
                Departamento = municipio.IdDepartamentoNavigation.Departamento1
            };
        } 
    }
}
