using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {
        //public event EventHandler ThresholdReached;

        //public static void Main()
        //{
        //    Thread t = new Thread(new ThreadStart(ThreadMethod));
        //    t.Start();
        //    for (int i = 0; i < 4; i++)
        //    {
        //        Console.WriteLine("Main thread: Do some work.");
        //        Thread.Sleep(0);
        //    }
        //    t.Join();

        //    Console.ReadLine();
        //}

        //public static void ThreadMethod()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine("ThreadProc: {0}", i);
        //        Thread.Sleep(0);
        //    }
        //}

        /*
            Passando parametro para thread
         */
        //public static void ThreadMethod(object o)
        //{
        //    for (int i = 0; i < (int)o; i++)
        //    {
        //        Console.WriteLine("ThreadProc: {0}", i);
        //        Thread.Sleep(0);
        //    }
        //}
        //public static void Main()
        //{
        //    Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
        //    t.Start(5);
        //    t.Join();

        //    Console.ReadLine();
        //}

        /*
         Ao invés de usar o thread.Abort que é chamado pro outra thread, que pode gerar excessão caso alguma thread esteja rodando sem finalizar.
         * usamos uma shared variable que espera a execução terminar para finalizar. usandop também o Join(); que aguarda todas as treads finalizarem.
         */


        //public static void ThreadMethod(object o)
        //{
        //    for (int i = 0; i < (int)o; i++)
        //    {
        //        Console.WriteLine("ThreadProc: {0}", i);
        //        Thread.Sleep(0);
        //    }
        //}
        //public static void Main()
        //{
        //    bool stopped = false;
        //    Thread t = new Thread(new ThreadStart(() =>
        //                            {
        //                                while (!stopped)
        //                                {
        //                                    Console.WriteLine("Running...");
        //                                    Thread.Sleep(1000);
        //                                }
        //                            }));

        //    t.Start();
        //    Console.WriteLine("Press any key to exit");
        //    Console.ReadKey();
        //    stopped = true;
        //    t.Join();
        //}

        /*
         Com ThreadStaticAtributte você consegue usar variaveis compartilhadas individuais, 
         * por exemplo a variavel field fica unica para cada thread, 
         * mesmo as não sendo instanciada e mesmo sendo variavel de tipo que é armazenada por valor
         * 
         * Na priomeira Thread a variavel field fica com valor 10
         * Na segunda Thread a variavel field fica com valor 10
           Observe que ela só é declarada uma unica vez.
         */
        //[ThreadStatic]
        //public static int _field = 0;
        //public static void Main()
        //{
        //    new Thread(() =>
        //    {
        //        for (int x = 0; x < 10; x++)
        //        {
        //            _field++;
        //            Console.WriteLine("Thread A: {0}", _field);
        //        }
        //    }).Start();



        //    new Thread(() =>
        //    {
        //        for (int x = 0; x < 10; x++)
        //        {
        //            _field++;
        //            Console.WriteLine("Thread B: {0}", _field);
        //        }
        //    }).Start();



        //    Console.ReadKey();
        //}


        /*
         Local Variavel
         */

        //public static ThreadLocal<int> _field =
        //                                new ThreadLocal<int>(() =>
        //                                {
        //                                    return Thread.CurrentThread.ManagedThreadId;
        //                                });

        //public static void Main()
        //{
        //    new Thread(() =>
        //    {
        //        for (int x = 0; x < _field.Value; x++)
        //        {
        //            Console.WriteLine("Thread A: {0}", x);
        //        }
        //    }).Start();




        //    new Thread(() =>
        //    {
        //        for (int x = 0; x < _field.Value; x++)
        //        {
        //            Console.WriteLine("Thread B: {0}", x);
        //        }
        //    }).Start();


        //    Console.ReadKey();
        //}

        public static void Main()
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a thread from threadpool");
            });
            Console.ReadLine();
        }

    }
}
