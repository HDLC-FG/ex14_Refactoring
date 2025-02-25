namespace Web.ViewModels
{
    public class UniversiteViewModel
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string NomForfait { get; set; }

        public UniversiteViewModel(int id, string nom, string nomForfait)
        {
            Id = id;
            Nom = nom;
            NomForfait = nomForfait;
        }
    }
}
