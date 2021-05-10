using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            var text = "HelloMediumReader";
            var number = new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Console.WriteLine(text[5]);
            Console.WriteLine(number[number.Length - 2]);




            

            
        }


        public void dispose()
        {
            string path = @"c:\texto.txt";

            using (writer writer = new(path))
            {
                writer.write("jfjf");

            }
            var writer2 = new writer(path);

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
