using SVRepository.Entities;

namespace SVServices.Interface
{
    public interface IMedidaService
    {
        public Task<List<Medida>> GetListSize();
    }
}
