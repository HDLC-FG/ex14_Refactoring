using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;

namespace Core.Services
{
    public class RegistreService : IRegistreService
    {
        private readonly IEtudiantRepository etudiantRepository;
        private readonly IUniversiteRepository universiteRepository;

        public RegistreService(IEtudiantRepository etudiantRepository, IUniversiteRepository universiteRepository)
        {
            this.etudiantRepository = etudiantRepository;
            this.universiteRepository = universiteRepository;
        }

        public bool AjouterEtudiant(string? adresseMail, int universiteId, bool bonus = false)
        {
            Console.WriteLine(string.Format($"Log: Debut Ajout d'un etudiant avec cet e-mail '{adresseMail}'"));

            if (string.IsNullOrWhiteSpace(adresseMail))
            {
                Console.WriteLine(string.Format("Log: Fin Ajout d'un etudiant, adresse mail non renseigné"));
                return false; 
            }
            if(etudiantRepository.Exists(adresseMail))
            {
                Console.WriteLine(string.Format($"Log: Fin Ajout d'un etudiant, étudiant non trouvé avec cet e-mail '{adresseMail}'"));
                return false;
            }

            var universite = universiteRepository.GetById(universiteId);
            var etudiantEnCours = new Etudiant(adresseMail, universiteId);

            etudiantEnCours.NbTelechargementMaximum = universite.Forfait switch
            {
                Forfait.Standard => 10 + (bonus ? 5 : 0),
                Forfait.Premium => 20 + (bonus ? 10 : 0),
                Forfait.Illimité => -1,
                _ => throw new Exception("Forfait non pris en charge")
            };

            etudiantRepository.Add(etudiantEnCours);

            Console.WriteLine(string.Format($"Log: Fin Ajout d'un etudiant avec cet e-mail '{adresseMail}'"));
            return true;
        }
    }
}
