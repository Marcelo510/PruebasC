using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            dynamic a = "Marcelo";
            dynamic b = "otro";

            a = 1;
            
            Console.WriteLine(a + b);



        }

        public void GeneraList()
        {
            var LaLista = new List<(int numero, string cadena)>
            {
                (1, "Marcelo"),
                (2, "Alonso")
            };


            



        }
    }
}
