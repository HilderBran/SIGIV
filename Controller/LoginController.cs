using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class LoginController {
         
        public async Task<bool> Loggin(string username, string password) {
            bool result = false;
            try  {
                using(var context = new SigivContext())
                {
                    var user = await context.Usuarios.FirstOrDefaultAsync(
                          usuario => usuario.Equals(username));

                    if(user == null) {
                        throw new Exception("No se encontro el usuario");
                    }

                    result = BCrypt.Net.BCrypt.Verify(password, user?.Clave);
                }
            }
            catch (Exception exc) {
                throw new Exception(exc.Message);
            }
            return result;
        }
    }
}
