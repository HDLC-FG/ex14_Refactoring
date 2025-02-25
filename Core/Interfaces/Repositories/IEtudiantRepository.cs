using Core.Entities;

namespace Core.Interfaces.Repositories
{
    public interface IEtudiantRepository
    {
        IList<Etudiant> GetAll();
        void Add(Etudiant student);
        bool Exists(string adresseEmail);
    }
}