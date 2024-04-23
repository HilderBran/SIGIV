using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class PaisController
    {
        public async Task <bool> AddPais(string IdPais, string Pais)
        {
            bool bandera = false;

            try
            {
                Paise paise = new Paise();
                paise.IdPais = IdPais;
                paise.Pais = Pais;
                using  (SigivContext context = new SigivContext())
                {
                    context.Paises.Add(paise);

                    await context.SaveChangesAsync();
                }
                bandera = true;
            }
            catch (Exception)
            {

                throw;
            } 
            return bandera;
        }

        public async Task<bool> DetelePais(string IdPais, string Pais)
        {
            bool bandera = false;

            try
            {
                Paise paise = new Paise();
                paise.IdPais = IdPais;
                paise.Pais = Pais;
                using (SigivContext context = new SigivContext())
                {
                    context.Paises.Remove(paise);

                    await context.SaveChangesAsync();
                }
                bandera = true;
            }
            catch (Exception)
            {

                throw;
            }
            return bandera;
        }

        public async Task<List<Paise>> GetPaises()
        {
            List<Paise> ListPais;
            try
            {
                using (SigivContext context = new SigivContext())
                {
                  var result = await context.Paises.ToListAsync();
                    ListPais = result;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return ListPais;  
        }
        public async Task<bool> Actualizarpais(string IdPais, string Pais)
        {
            bool bandera = false;
            try
            {
                Paise paise = new Paise();
                paise.IdPais = IdPais;
                paise.Pais = Pais;

                using (SigivContext context = new SigivContext())
                {
                    context.Paises.Update(paise);

                    await context.SaveChangesAsync();
                }
                bandera = true;
            }
            catch (Exception)
            {
                throw;
            }
            return bandera;
        }
    }


}
