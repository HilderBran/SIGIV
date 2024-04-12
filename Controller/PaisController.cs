using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
