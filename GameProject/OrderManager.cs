using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class OrderManager : IOrderService
    {
        public void Order(Gamer gamer, Campain campain)
        {
            Console.WriteLine("Satış başarılı!");
        }

       
    }
}
