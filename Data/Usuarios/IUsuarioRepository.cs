using backend_integrador.Dtos.UsuarioDtos;

namespace backend_integrador.Data.Usuarios;

public interface IUsuarioRepository
{
    Task<UsuarioResponseDto> GetUsuario();

    Task<UsuarioResponseDto> Login(UsuarioLoginRequestDto request);

    Task<UsuarioResponseDto> RegistroUsuario(UsuarioRegistroRequestDto request);
}


