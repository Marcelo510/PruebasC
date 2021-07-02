using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public static class RecorreArreglo
    {
        public static void While(List<int> numbers)
        {
            int i = 0;
            while (i < numbers.Count)
            {
                Console.WriteLine(numbers[i]);
                i++;
            }
        }

        public static void DoWhile(List<int> numbers)
        {
            int i = 0;
            do
            {
                Console.WriteLine(numbers[i]);
                i++;
            } while (i < numbers.Count);
        }

        public static void For(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static void ForEach(List<int> numbers)
        {
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        public static void ForEachObject(List<int> numbers)
        {
            foreach (var item in numbers.Select((i, num)=> new { i, num}))
            {
                Console.WriteLine(item.i + " " + item.num);
            }
        }

        public static void MetodoForEach(List<int> numbers)
        {
            numbers.ForEach((num) => Console.WriteLine(num));
        }

        public static void Recursiva(List<int> numbers, int i = 0)
        {
            if (i < numbers.Count)
            {
                Console.WriteLine(numbers[i++]);
                Recursiva(numbers, i);
            }
            else
                return;
        }

        public static void Action(List<int> numbers)
        {
            int i = 0;
            Action fn = null;

            fn = () =>
            {
                if (i < numbers.Count)
                {
                    Console.WriteLine(numbers[i]);
                    i++;
                    fn();
                }
            };

            fn();
        }


        public static Action ReturnAction(List<int> numbers)
        {
            int i = 0;
            Action fn = null;

            fn = () =>
            {
                if (i < numbers.Count)
                {
                    Console.WriteLine(numbers[i]);
                    i++;
                    fn();
                }
            };

            return fn;
        }


    }
}
