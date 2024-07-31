using backend_integrador.Models;

namespace backend_integrador.Data;

public interface IEmpresaRepository
{
    bool SaveChanges();

    IEnumerable<Empresa> GetAllEmpresas();

    Empresa GetEmpresaById(int id);

    void CreateEmpresa(Empresa empresa);

    void DeleteEmpresa(int id);
}