using LaMiaPizzeria.Models;

namespace LaMiaPizzeria.BusinessLogic
{
    public class ServizioPizza
    {
        public List<PizzaViewModel> Pizze { get; set; }

        public ServizioPizza()
        {
            Pizze = new List<PizzaViewModel>();

            Pizze.Add(new PizzaViewModel()
            {
                Id = 0,
                Descrizione = "Pizza Margherita",
                Nome = "Pizza Margherita",
                Prezzo = 9.50,
                UrlImmagine = "https://th.bing.com/th/id/OIP.31Kt0L2sA5RZ0dsdQSW8ygHaE7?pid=ImgDet&rs=1"
            });

            Pizze.Add(new PizzaViewModel()
            {
                Id = 1,
                Descrizione = "Pizza 4 Formaggi",
                Nome = "Pizza 4 Formaggi",
                Prezzo = 9.50,
                UrlImmagine = "https://th.bing.com/th/id/OIP.31Kt0L2sA5RZ0dsdQSW8ygHaE7?pid=ImgDet&rs=1"
            });

            Pizze.Add(new PizzaViewModel()
            {
                Id = 2,
                Descrizione = "Pizza Boscaiola",
                Nome = "Pizza Boscaiola",
                Prezzo = 9.50,
                UrlImmagine = "https://th.bing.com/th/id/OIP.31Kt0L2sA5RZ0dsdQSW8ygHaE7?pid=ImgDet&rs=1"
            });

            Pizze.Add(new PizzaViewModel()
            {
                Id = 3,
                Descrizione = "Pizza Capricciosa",
                Nome = "Pizza Capricciosa",
                Prezzo = 9.50,
                UrlImmagine = "https://th.bing.com/th/id/OIP.31Kt0L2sA5RZ0dsdQSW8ygHaE7?pid=ImgDet&rs=1"
            });

            Pizze.Add(new PizzaViewModel()
            {
                Id = 4,
                Descrizione = "Pizza Margherita",
                Nome = "Pizza Margherita",
                Prezzo = 9.50,
                UrlImmagine = "https://th.bing.com/th/id/OIP.31Kt0L2sA5RZ0dsdQSW8ygHaE7?pid=ImgDet&rs=1"
            });

            Pizze.Add(new PizzaViewModel()
            {
                Id = 5,
                Descrizione = "Pizza Margherita",
                Nome = "Pizza Margherita",
                Prezzo = 9.50,
                UrlImmagine = "https://th.bing.com/th/id/OIP.31Kt0L2sA5RZ0dsdQSW8ygHaE7?pid=ImgDet&rs=1"
            });
        }

    }
}
