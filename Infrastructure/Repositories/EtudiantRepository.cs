using Core.Entities;
using Core.Interfaces.Repositories;

namespace Infrastructure.Repositories
{
    public class EtudiantRepository : IEtudiantRepository
    {
        private static readonly IList<Etudiant> _etudiants = new List<Etudiant>()
        {
            new Etudiant("quentin.martinez@cambridge.com", 1)
            {
                NbTelechargementMaximum = 10,
                NbLivreTelecharges = 5
            },
            new Etudiant("john.wick@oxford.com", 3)
            {
                NbTelechargementMaximum = 5,
                NbLivreTelecharges = 2
            },
            new Etudiant("harry.potter@poudlard.com", 2)
            {
                NbTelechargementMaximum = 5,
                NbLivreTelecharges = 0
            }
        };

        public EtudiantRepository()
        {
        }

        public IList<Etudiant> GetAll()
        {
            return _etudiants.ToList();
        }

        public void Add(Etudiant student)
        {
            _etudiants.Add(student);
        }

        public bool Exists(string adresseEmail)
        {
            return _etudiants.Any(etudiant => etudiant.AdresseEmail == adresseEmail);
        }
    }
}
