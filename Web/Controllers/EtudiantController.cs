using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Web.ViewModels;

namespace Web.Controllers
{
    public class EtudiantController : Controller
    {
        private readonly IRegistreService _registreService;
        private readonly IUniversiteRepository _universiteRepository;
        private readonly IEtudiantRepository _etudiantRepository;

        public EtudiantController(IRegistreService registreService, IUniversiteRepository universityRepository, IEtudiantRepository edutiantRepository)
        {
            _registreService = registreService;
            _universiteRepository = universityRepository;
            _etudiantRepository = edutiantRepository;
        }

        public IActionResult Index()
        {
            var etudiants = _etudiantRepository.GetAll();
            var etudiantsVM = etudiants.Select(e => new EtudiantViewModel
            {
                Email = e.AdresseEmail,
                UniversiteId = e.UniversiteId,
            }).ToList();
            
            return View(etudiantsVM);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(EtudiantViewModel viewModel)
        {
            _registreService.AjouterEtudiant(viewModel.Email, viewModel.UniversiteId);
            return RedirectToAction(nameof(Index));
        }
    }
}
