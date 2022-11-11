using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace case1.Codes
{

    public struct DatoBeregning
    {

        //public string Sidste_synet_dato { get; set; }

        //public int sonuc;
        //public TimeSpan _forskel_dag;

        //public Dato(string _sidste_synet_dato)
        //{
        //    Sidste_synet_dato = _sidste_synet_dato;
        //    DateTime _nuværende_dato = DateTime.Now.Date;
        //    CultureInfo cultinf = new CultureInfo("da-DK");
        //    DateTime _ny_time = Convert.ToDateTime(Sidste_synet_dato, cultinf);
        //    _forskel_dag = _nuværende_dato - _ny_time;
        //    sonuc = Convert.ToInt32(_forskel_dag.Days);

        //}

        public string? FørsteTilsyn(DateOnly CarAge)
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);
            DateOnly Add4Years = CarAge.AddYears(4);
            if (Add4Years > today)
            {
                return $"Du skal til tilsyn efter den {Add4Years}";
            }
            return null;
        }

        //Beregner om bilen skal til tilsyn angående hvornår den sidst var til tilsyn.
        public string? Tilsyn(DateOnly SidstTilSynsDato)
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);
            DateOnly Add2Years = SidstTilSynsDato.AddYears(2);
            if (Add2Years < today) return $"Du skal til tilsyn efter den {Add2Years}";
            return null;
        }
    }
}