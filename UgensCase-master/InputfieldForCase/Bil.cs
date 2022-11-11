using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InputfieldForCase
{
    public struct Bil
    {
        public string CarCheckUp(string Type, string Model, DateOnly Year)
        {

            string[] CallBackCar1= { "fiat", "ponto", "01/01/2010", "udstødning" };
            string[] CallBackCar2 = { "alfa romeo", "giulia", "01/08/2019", "styrtøjet" };
            string? iscar1 = CallBack(CallBackCar1, Year, Model, Type);
            string iscar2 = CallBack(CallBackCar2, Year, Model, Type);
            if (iscar1 != null)
            {
                return iscar1;
            }
            else if (iscar2 != null)
            {
                return iscar2;
            }
            return null;
        }
        public string CallBack(string[] car, DateOnly Year, string Model, string Type)
        {
            if (car.Contains(Type) && car.Contains(Model))
            {
                if (Year.CompareTo(DateOnly.Parse(car[2])) < 0)
                {
                    return $"Bilen har følgende fabriksfejl: {car[3]}";
                }
            }
            return null;
        }
    }
}

