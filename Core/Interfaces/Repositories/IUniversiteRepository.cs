using Core.Entities;

namespace Core.Interfaces.Repositories
{
    public interface IUniversiteRepository
    {
        IList<Universite> GetAll();
        Universite GetById(int id);
    }
}