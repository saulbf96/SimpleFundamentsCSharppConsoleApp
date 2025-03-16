using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAppCsharp10
{

    public class SportCar : Car
    {
        //agregar metodo publico 
        public string GetPetName()
        {
            PetName = "Red";
            return PetName;
        }
    }
}
