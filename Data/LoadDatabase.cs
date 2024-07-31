using backend_integrador.Models;
using Microsoft.AspNetCore.Identity;

namespace backend_integrador.Data
{
    public class LoadDatabase
    {
        public static async Task InsertarData(AppDbContext context, UserManager<Usuario> usuarioManager)
        {
            if(!usuarioManager.Users.Any())
            {
                var usuario = new Usuario
                {
                    Nombre = "Adolf",
                    Apellido = "Hitler",
                    Email = "adolf@gmail.com",
                    UserName = "Furer",
                    Telefono = "0987654321"
                };

                await usuarioManager.CreateAsync(usuario, "Password7.-");
            }

            if(!context.Empresas.Any())
            {
                context.Empresas.AddRange(
                    new Empresa
                    {
                        Nombre = "Vercel",
                        Direccion = "Quito, Ecuador",
                        Ruc = 00000,
                        Telefono = "0983193403",
                        FechaCreacion = DateTime.Now
                    },
                     new Empresa
                     {
                         Nombre = "Nestle",
                         Direccion = "Quito, Ecuador",
                         Ruc = 00000123,
                         Telefono = "0983193402",
                         FechaCreacion = DateTime.Now
                     }
                );
            }
            context.SaveChanges();
        }
        
    }
}
