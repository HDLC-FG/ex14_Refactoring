namespace Core.Entities
{
    public class Etudiant
    {
        public int Id { get; set; }
        public string AdresseEmail { get; private set; }
        public int UniversiteId { get; private set; }
        public int NbTelechargementMaximum { get; set; }
        public int NbLivreTelecharges { get; set; }

        public Etudiant(string emailAddress, int universityId)
        {
            AdresseEmail = emailAddress;
            UniversiteId = universityId;
        }
    }
}
