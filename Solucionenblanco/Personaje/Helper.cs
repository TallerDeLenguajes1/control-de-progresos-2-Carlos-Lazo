using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad

{
    static public class Helper
    {
        static public DateTime FechaAleAtoria(int años)
        {

            Random gen = new Random();
            DateTime start = DateTime.Today.AddDays(-años);
            int range = (DateTime.Today - start).Days;

            return start.AddDays(gen.Next(range));


        }
    }
}
