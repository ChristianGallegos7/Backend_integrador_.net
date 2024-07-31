using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using backend_integrador.Models;
using Microsoft.IdentityModel.Tokens;

namespace backend_integrador.Token
{
    // Esta clase implementa la interfaz IJwtGenerador y se encarga de generar tokens JWT.
    public class JwtGenerator : IJwtGenerador
    {
        // Este método crea un token JWT para un usuario dado.
        // Recibe un objeto Usuario y devuelve una cadena que representa el token JWT.
        public string CrearToken(Usuario usuario)
        {
            // Se crean los claims (reclamaciones) que se incluirán en el payload del token.
            // Un claim es una declaración sobre el usuario, como su nombre de usuario, su ID y su email.
            var claims = new List<Claim>
            {
                // Claim que representa el nombre de usuario.
                new Claim(JwtRegisteredClaimNames.NameId, usuario.UserName!),
                // Claim que representa el ID del usuario.
                new Claim("userId", usuario.Id),
                // Claim que representa el email del usuario.
                new Claim("email", usuario.Email!)
            };

            // Se crea una clave de seguridad utilizando una palabra secreta.
            // Esta clave se usará para firmar el token y asegurar su integridad.
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Mi palabra secreta"));

            // Se crean las credenciales de firma utilizando la clave de seguridad y el algoritmo HMAC SHA-512.
            var credenciales = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            // Se define la descripción del token, incluyendo los claims, la fecha de expiración y las credenciales de firma.
            var tokenDescripcion = new SecurityTokenDescriptor
            {
                // Los claims que se incluirán en el token.
                Subject = new ClaimsIdentity(claims),
                // La fecha de expiración del token (30 días desde la creación).
                Expires = DateTime.Now.AddDays(30),
                // Las credenciales de firma que se utilizarán para firmar el token.
                SigningCredentials = credenciales
            };

            // Se crea un manejador de tokens JWT.
            var tokenHandler = new JwtSecurityTokenHandler();
            // Se crea el token utilizando la descripción del token.
            var token = tokenHandler.CreateToken(tokenDescripcion);

            // Se escribe el token en una cadena y se devuelve.
            return tokenHandler.WriteToken(token);
        }
    }
}
