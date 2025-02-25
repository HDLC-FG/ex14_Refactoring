namespace Core.Interfaces.Services
{
    public interface IRegistreService
    {
        bool AjouterEtudiant(string? adresseMail, int universiteId, bool bonus = false);
    }
}