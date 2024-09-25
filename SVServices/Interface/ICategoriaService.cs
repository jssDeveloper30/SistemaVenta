using SVRepository.Entities;

namespace SVServices.Interface
{
    public interface ICategoriaService
    {
        Task<List<Categoria>> GetCategory(string buscar = "");
        Task<string> CreateCategory(Categoria objeto);
        Task<string> EditCategory(Categoria objeto);
    }
}
