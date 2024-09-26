using SVRepository.Entities;

namespace SVServices.Interface
{
    public interface IProductoService
    {
        Task<List<Producto>> GetProduct(string search = "");
        Task<string> CreateProduct(Producto objeto);
        Task<string> EditProduct(Producto objeto);
    }
}
