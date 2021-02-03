using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class CampainManager : ICampainService
    {
        public void Add(Campain campain)
        {
            Console.WriteLine("Kampanya Eklendi.");
        }

        public void Delete(Campain campain)
        {
            Console.WriteLine("Silme Başarılı!");
        }

        public void Update(Campain campain)
        {
            Console.WriteLine("Güncelleme Başarılı!");
        }
    }
}
