using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskWaitAllUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            Task[] tasks = new Task[3];
            tasks[0] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("1");
                return 1;
            });
            tasks[1] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("2");
                return 2;
            });
            tasks[2] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("3");
                return 3;
            }
            );
            Task.WaitAll(tasks);//Espera todas as task terminarem para continuar a execução
           
            Console.WriteLine("Depois que todas executaram");
            Thread.Sleep(6000);

            /*
             Se não colocar o WaitAll ele executa a primeira e encerra o programa, deixando executarem em segundo plano,
             * Se eu tirar o WaitAll ele executa o "Depois que todas executarem" e depois as thread 123
             * Agora se eu colocar o WaitAll ele imprime primeiro as threads 123 e depois o "Depois que todas executarem"
             */
        }
    }
}
