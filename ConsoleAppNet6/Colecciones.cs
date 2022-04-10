using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNet6
{
    public static class Colecciones
    {
        

        public static void List()
        {

            List<string> firstList = new()
            {
                "Ford",
                "Dodge"
            };

            firstList.Add("otro");

            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }

        }

        public static void Cola()
        {
            Queue<string> laCola = new Queue<string>();
            laCola.Enqueue("Primero");
            laCola.Enqueue("Segundo");
            laCola.Enqueue("Tercero");

            Console.WriteLine("Antes de ejecutar la primer");

            foreach (var item in laCola)
            {

                Console.WriteLine(item);
            }

            Console.WriteLine("");

            //Al mostrar el primero lo quita de la cola
            Console.WriteLine(laCola.Dequeue());

            Console.WriteLine("Después de ejecutar la primer");

            foreach (var item in laCola)
            {

                Console.WriteLine(item);
            }
        }

        public static void Stack()
        {
            Stack<string> laCola = new Stack<string>();
            laCola.Push("Primero");
            laCola.Push("Segundo");
            laCola.Push("Tercero");

            Console.WriteLine("Antes de ejecutar la primer");

            foreach (var item in laCola)
            {

                Console.WriteLine(item);
            }

            Console.WriteLine("");

            //Al mostrar el ultimo lo quita de la cola
            Console.WriteLine(laCola.Pop());

            Console.WriteLine("Después de ejecutar la primer");

            foreach (var item in laCola)
            {

                Console.WriteLine(item);
            }
        }
    }
}
