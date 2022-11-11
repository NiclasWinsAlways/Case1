using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace case1.Codes
{
    public struct DateCheck
    {
        public DateOnly ParseDate(string? input)
        {
            DateOnly date;
            CultureInfo culture = new CultureInfo("da-DK");
            try
            {
                date = DateOnly.Parse(input, culture);
            }
            catch (Exception exception)
            {
//Fejl hvis formatten af datetime er forkert
                throw new Exception("Formattet er forkert skrevet. Prøv DD-MM-YYYY eller DD-MM-YYYY");
            }
            if (date.CompareTo(DateOnly.FromDateTime(DateTime.Now)) > 0)
            {
//Hvis den angivet dato er i fremtiden.
                throw new("Denne dato er i fremtiden");
            }
            return date;
        }
    }
}
