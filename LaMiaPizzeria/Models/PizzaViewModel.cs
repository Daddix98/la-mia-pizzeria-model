namespace LaMiaPizzeria.Models
{
    public class PizzaViewModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descrizione { get; set; }
        public string? UrlImmagine { get; set; }
        public double Prezzo { get; set; }
    }
}
