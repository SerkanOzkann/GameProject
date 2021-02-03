using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ödev5 Oyun Projesi
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, Tc = 1234567890, Ad = "Serkann", Soyadi = "Özkann", DogumTarihi = 1996 });
            

            CampainManager campainManager =new  CampainManager();
            campainManager.Add(new Campain { Id = 1, CampainName = " Yılbaşı" });
            Console.ReadKey();

            OrderManager orderManager = new OrderManager();
            orderManager.Order(gamer,campain);

            Console.WriteLine("Elimgen geleni yaptım.");
        }
    }
}
