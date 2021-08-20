using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static ConsoleAppCore5.Enumerable;

namespace ConsoleAppCore5
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //var numero = "1454542384567";

            //var final = "";
            //var x = 0;


            //for (int i = numero.Length - 1; i > -1; i--)
            //{
            //    x++;
            //    final = numero.Substring(i, 1) + final;
            //    if (x == 3 && i > 0)
            //    {
            //        x = 0;
            //        final = "," + final;
            //    }
            //}

            //Console.WriteLine(final);




            //ConsoleAppCore5.Enumerable datos = new Enumerable();
            //IQueryable<numeros> lst = datos.ObtenerDatos();

            //var Json = new { nombre = "Marcelo", edad = 40};

            //Func<int, int> suma = (a) =>
            //{
            //    return 2 + a; 
            //};

            //Console.WriteLine(suma(4));


            List<Task> lst = new List<Task>();
            lst.Add(Task.Run(() => Tareas()));
            lst.Add(Task.Run(() => Tareas2()));

            await Task.WhenAll(lst);


            //Task oTask = Task.WhenAll(lst);
            //oTask.Wait();

            //try
            //{
            //    oTask.Wait();
            //}
            //catch (Exception)
            //{

            //    throw;
            //}


            //await Tareas();
            //await Tareas2();
            //Task ver = Task.WaitAll(Tareas());
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
            return;
        }

        private static async Task Tareas2()
        {
            var Tarea = new Task(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Tarea interna 2");
            });

            Tarea.Start();

            await Tarea;

            Console.WriteLine("Terminó la tarea 2");
            return;
        }
    }
}
