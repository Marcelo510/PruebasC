using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNet6
{
    public static class Strings
    {
        
        public const string _sA = "Hola";
        public const string _sB = " otra vez";
        

        public static string StringCon() => string.Concat(_sA, _sB);
        public static string StringForm() => string.Format("{0}{1}", _sA, _sB);
        public static string StringInter() => $"{_sA}{_sB}";
        public static string StringAdd() => _sA + _sB;
        public static string StringBuilder()
        {
            var builder = new StringBuilder();
            builder.Append(_sA);
            builder.Append(_sB);
            return builder.ToString();
        }


        public static void arrancar()
        {
            Stopwatch timeMeasure = new Stopwatch();
            timeMeasure.Start();
            for (int i = 0; i < 1000; i++)
            {
                var resu = StringCon();
            }
            timeMeasure.Stop();
            Console.WriteLine($"Tiempo: {timeMeasure.Elapsed.TotalMilliseconds} ms");
            
        }

        

    }

    

    

}
