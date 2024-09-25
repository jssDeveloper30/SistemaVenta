using SVRepository.Entities;

namespace SVRepository.Interfaces
{
    public interface IMedidaRepository
    {
        public Task<List<Medida>> GetListSize();
    }
}
