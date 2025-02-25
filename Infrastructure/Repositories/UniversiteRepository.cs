using Core;
using Core.Entities;
using Core.Interfaces.Repositories;

namespace Infrastructure.Repositories
{
    public class UniversiteRepository : IUniversiteRepository
    {
        private readonly IList<Universite> _universites = new List<Universite>()
        {
            new Universite()
            {
                Id = 1,
                Nom = "Cambridge",
                Forfait = Forfait.Standard
            },
            new Universite()
            {
                Id = 2,
                Nom = "Poudlard",
                Forfait = Forfait.Premium
            },
            new Universite()
            {
                Id = 3,
                Nom = "University of Oxford",
                Forfait = Forfait.Premium
            }
        };

        public UniversiteRepository()
        {
        }

        public IList<Universite> GetAll()
        {
            return _universites.ToList();
        }

        public Universite GetById(int id)
        {
            return _universites.Single(x => x.Id == id);
        }
    }
}
