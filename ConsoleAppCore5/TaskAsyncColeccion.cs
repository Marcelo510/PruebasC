using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCore5
{
    public class TaskAsyncColeccion
    {

        public TaskAsyncColeccion()
        {
            Task[] Tarea = new Task[3];
            Tarea[0] = Task.Run(Request1);
            Tarea[1] = Task.Run(Request2);
            Tarea[2] = Task.Run(Request1);

            Console.WriteLine(Tarea[0].Status);

            Console.WriteLine("Esto lo hago mientras se van ejecutando los request");
            Task.WaitAll(Tarea);

            Console.WriteLine(Tarea[0].Status);
            Console.WriteLine("Terminó la app");
        }



        public static void Request1()
        {
            Task.Delay(2000);
            Console.WriteLine("Tarea número 1");
        }

        public static void Request2()
        {
            Task.Delay(1000);
            Console.WriteLine("Tarea número 2");
        }

    }

    
}
