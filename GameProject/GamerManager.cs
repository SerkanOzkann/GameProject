using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class GamerManager : IGameService
    {
        //SOMUT

        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)   // soyut,fake yapı.
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)== true)
            {
                Console.WriteLine("Kayıt Başaralı!");
            }
            else { Console.WriteLine("Kayıt Başarısız, Doğrulama Başarısız."); }
            
        }

        public void Delete(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt Silindi!");
            }
            else { Console.WriteLine("Silme Başarısız, Doğrulama Başarısız."); }
        }

        public void Update(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt Güncellendi!");
            }
            else { Console.WriteLine("Güncelleme Başarısız, Doğrulama Başarısız."); }
        }
    }
}
