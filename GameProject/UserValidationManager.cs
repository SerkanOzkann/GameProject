using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {   //Somut
        public bool Validate(Gamer gamer)
        {
            if (gamer.DogumTarihi==1996 && gamer.Tc==1234567890 && gamer.Ad=="Serkan" && gamer.Soyadi=="Özkan")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
