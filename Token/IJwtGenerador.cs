using backend_integrador.Models;

namespace backend_integrador.Token
{
    public interface IJwtGenerador
    {
        string CrearToken(Usuario usuario);
    }
}
