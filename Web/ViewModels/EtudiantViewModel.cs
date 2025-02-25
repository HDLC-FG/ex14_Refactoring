using Core.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;

namespace Web.ViewModels
{
    public class EtudiantViewModel
    {
        public EtudiantViewModel()
        {
        }

        public EtudiantViewModel(List<Universite> universities)
        {
            Universites = new SelectList(universities, "Id", "Name");
        }

        public string? Email { get; set; }

        [DisplayName("Université")]
        public int UniversiteId { get; set; }

        public SelectList? Universites { get; set; }
    }
}
