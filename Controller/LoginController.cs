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

        private string username = null!;
        private string password = null!;

        public string Username { 
            get
            {
                if (this.username == null) {
                    throw new Exception($"El usuario no puede ser nulo");
                }
                return this.username;
            }
            set => this.username = value; 
        }

        public string Password {
            get
            {
                if(this.password == null) {
                    throw new Exception("La contraseña no puede ser nulo");
                }
                return this.password;
            }
            set => this.password = value;
        }


        public async Task<bool> Loggin() {
            bool result = false;
            try  {
                using(var context = new SigivContext())
                {
                    var user = await context.Usuarios.FirstOrDefaultAsync(
                          usuario => usuario.Equals(this.Username));

                    if(user == null) {
                        throw new Exception("No se encontro el usuario");
                    }

                    result = BCrypt.Net.BCrypt.Verify(this.Password, user?.Clave);
                }
            }
            catch (Exception exc) {
                throw new Exception(exc.Message);
            }
            return result;
        }
    }
}
