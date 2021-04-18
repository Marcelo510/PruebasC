using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppCore5
{
    class Program
    {
        static async Task Main(string[] args)
        {
            


            //await Tareas();
            await Tareas2();
            Console.WriteLine("Esto esta al final de todo");
            //var duplicar = (valor) => { return valor * 2 }
        }


        private static async Task Tareas()
        {
            var Tarea = new Task(() =>
            {
                Thread.Sleep(4000);
                Console.WriteLine("Tarea interna 1");
            });

            Tarea.Start();

            await Tarea;

            Console.WriteLine("Terminó la tarea 1");
        }

        private static async Task Tareas2()
        {
            var Tarea2 = new Task(() =>
            {
                Thread.Sleep(4000);
                Console.WriteLine("Tarea interna 1");
            });



            var Tarea = new Task(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Tarea interna 2");
            });

            Tarea2.Start();
            Tarea.Start();

            await Tarea2;
            await Tarea;
            

            Console.WriteLine("Terminó la tarea 2");
        }
    }
}
