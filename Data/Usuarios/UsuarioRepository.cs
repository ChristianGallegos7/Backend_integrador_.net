using backend_integrador.Dtos.UsuarioDtos;
using backend_integrador.Models;
using backend_integrador.Token;
using Microsoft.AspNetCore.Identity;

namespace backend_integrador.Data.Usuarios;


public class UsuarioRepository : IUsuarioRepository
{
    private readonly UserManager<Usuario> _userManager;
    private readonly SignInManager<Usuario> _signInManager;

    private readonly IJwtGenerador _jwtGenerador;

    private readonly AppDbContext _contexto;

    private readonly IUsuarioSesion _usuarioSesion;


    public UsuarioRepository()
    {
        UserManager<Usuario> userManager,
        SignInManager<Usuario> SignInManager,
        IJwtGenerador jwtGenerador,
    }

    public Task<UsuarioResponseDto> GetUsuario()
    {
        throw new NotImplementedException();
    }

    public Task<UsuarioResponseDto> Login(UsuarioLoginRequestDto request)
    {
        throw new NotImplementedException();
    }

    public Task<UsuarioResponseDto> RegistroUsuario(UsuarioRegistroRequestDto request)
    {
        throw new NotImplementedException();
    }
}