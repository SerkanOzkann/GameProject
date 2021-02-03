using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    interface ICampainService
    {
        // SOYUT
        // Kampanya işlemlerini gerçekleştirmek için bir CampainService İnterface oluşturduk.  Service=Manager

        void Add(Campain campain);

        void Update(Campain campain);

        void Delete(Campain campain);
    }
}
