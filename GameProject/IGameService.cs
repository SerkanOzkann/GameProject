using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    interface IGameService
    {

        // SOYUT
        // Oyuncu işlemlerini gerçekleştirmek için bir GamerService İnterface oluşturduk.  Service=Manager

        void Add(Gamer gamer);


        void Update(Gamer gamer);


        void Delete(Gamer gamer);
       

    }
}
