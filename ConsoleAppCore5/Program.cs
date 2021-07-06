using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppCore5
{
    class Program
    {
        static async Task Main(string[] args)
        {

            TaskAsyncColeccion taskAsyncColeccion = new();
            
            
            //await Tareas();
            //await Tareas2();
        }


        private static async Task Tareas()
        {
            var Tarea = new Task(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Tarea interna 1");
            });

            Tarea.Start();

            await Tarea;

            Console.WriteLine("Terminó la tarea 1");
        }

        private static async Task Tareas2()
        {
            var Tarea = new Task(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Tarea interna 2");
            });

            Tarea.Start();

            await Tarea;

            Console.WriteLine("Terminó la tarea 2");
        }
    }
}
