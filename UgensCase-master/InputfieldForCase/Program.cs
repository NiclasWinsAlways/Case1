using System.ComponentModel;
using case1.Codes;
using System.Text.RegularExpressions;
using InputfieldForCase;
using System;

DateCheck a = new();
DatoBeregning b = new();
Bil C = new();

DateOnly CarAge;
DateOnly OversightDate;
bool check = false;
Console.WriteLine("Indtast venligst bilens mærke");
string CarType = Console.ReadLine().ToLower();
Console.WriteLine("Indtast venligst bilens model");
string CarName = Console.ReadLine().ToLower();
do
{
    Console.WriteLine("Indtast bilens årgang");
    string CarAgeInput = Console.ReadLine().ToLower();
    try
    {
        CarAge = a.ParseDate(CarAgeInput);
        check = true;
    }
    catch (Exception exception)
    {
        Console.WriteLine(exception.Message);
    }
} while (check != true);

string? checkUp = C.CarCheckUp(CarType, CarName, CarAge);
if (checkUp != null)
{
    Console.WriteLine(checkUp);
}
else
{
    string? Oversight = b.FørsteTilsyn(CarAge);
    if (Oversight == null)
    {
        do
        {
            check = false;
            Console.WriteLine("Indtast bilens sidste tilsynsdato");
            string OversightDateInput = Console.ReadLine().ToLower();
            try
            {
                OversightDate = a.ParseDate(OversightDateInput);
                check = true;
                string? GoOversight = b.Tilsyn(OversightDate);
                if (GoOversight != null)
                {
                    Console.WriteLine(GoOversight);
                }
                else
                {
                    Console.WriteLine("Bilen skal ikke til tilsyn");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        } while (check != true);
    }
    else
    {
        Console.WriteLine(Oversight);
    }
}


//if (TilsynsCheck.Tilsyn(CarAge))
//{
//    Console.WriteLine("Send den til tilsyn nu");
//}
//else
//{
//    Console.WriteLine("Du skal ikke sende den til tilsyn nu");
//}



//Lavet af Rasmus, Alexander, Niclas og Ozan