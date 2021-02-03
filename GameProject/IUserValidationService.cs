using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    interface IUserValidationService
            //Soyut
    {       // Bu bir Kullanıcı doğrulama servisidir.
            // Burada oyuncu dan alınan veriler teyit edilir.

        bool Validate(Gamer gamer);    // volidate=Doğrula


    }
}
