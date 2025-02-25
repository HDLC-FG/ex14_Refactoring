using Core.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using Web.ViewModels;

namespace Web.Controllers
{
    public class UniversiteController : Controller
    {
        private readonly IUniversiteRepository universiteRepository;

        public UniversiteController(IUniversiteRepository universiteRepository)
        {
            this.universiteRepository = universiteRepository;
        }

        public IActionResult Index()
        {
            var universities = universiteRepository.GetAll();
            var universitesVm = universities.Select(u => new UniversiteViewModel(u.Id, u.Nom, u.Forfait.ToString()));
            return View(universitesVm);
        }
    }
}
