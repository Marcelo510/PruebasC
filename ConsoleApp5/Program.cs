using System;
using System.Collections.Generic;


namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            RecorreArreglo.While(numbers);
            Console.WriteLine("-------------------");
            RecorreArreglo.DoWhile(numbers);
            Console.WriteLine("-------------------");
            RecorreArreglo.For(numbers);
            Console.WriteLine("-------------------");
            RecorreArreglo.ForEach(numbers);
            Console.WriteLine("-------------------");
            RecorreArreglo.ForEachObject(numbers);
            Console.WriteLine("-------------------");
            RecorreArreglo.MetodoForEach(numbers);
            Console.WriteLine("----Recursiva---------------");
            RecorreArreglo.Recursiva(numbers);
            Console.WriteLine("----Action------------------");
            RecorreArreglo.Action(numbers);
            Console.WriteLine("----Return Action-----------");
            Action Executor = RecorreArreglo.ReturnAction(numbers);
            Executor();


            Console.ReadLine();



            //var obten = GMail.GetContacts("marceloakd0@gmail.com", "achernar1990");

            //var ver = new { field = 2 };
            //Console.WriteLine(ver.field);

            //var text = "HelloMediumReader";
            //var number = new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            //Console.WriteLine(text[5]);
            //Console.WriteLine(number[number.Length - 2]);
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
