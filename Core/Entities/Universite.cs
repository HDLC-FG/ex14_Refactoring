namespace Core.Entities
{
    public class Universite
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public Forfait Forfait { get; set; }
    }
}