namespace backend_integrador.Data;
using backend_integrador.Models;

public class EmpresaRepository : IEmpresaRepository
{
    private readonly AppDbContext _contexto;

    public EmpresaRepository(AppDbContext contexto)
    {
        _contexto = contexto;
    }

    public void CreateEmpresa(Empresa empresa)
    {
        empresa.FechaCreacion = DateTime.Now;
        _contexto.Empresas!.Add(empresa);
    }

    public void DeleteEmpresa(int id)
    {
        var empresa = _contexto.Empresas!.FirstOrDefault(x => x.Id == id);

        _contexto.Empresas!.Remove(empresa!);
    }

    public IEnumerable<Empresa> GetAllEmpresas()
    {
       return _contexto.Empresas!.ToList(); 
    }

    public Empresa GetEmpresaById(int id)
    {
        return _contexto.Empresas!.FirstOrDefault(x => x.Id == id)!;
    }

    public bool SaveChanges()
    {
        return (_contexto.SaveChanges() >= 0);  
    }
}