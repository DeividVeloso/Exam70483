Thread.Join usado para forçar a terminar o serviço, somente depois das duas threads referenciadas

			Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(0);
            }
            t.Join();

Thread.Sleep(0) - Usado para sinalizar para windows que a thread foi finalizada, isso faz a CPU trocar para outra thread.


Foreground Thread - é usada para manter a thread viva, mesmo após sua execução. Somente quando todas as thread são executadas que a aplicação para a execução

Background thread - termina a execução.

Passando parametro para uma thread, com um evento delegate

Aqui eu chamo o metodo ThreadMethod passando como parametro t.Start(5)

Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
t.Start(5);
t.Join();


Ao invés de usar o thread.Abort que é chamado pro outra thread, que pode gerar excessão caso alguma thread esteja rodando sem finalizar.
usamos uma shared variable que espera a execução terminar para finalizar. usandop também o Join(); que aguarda todas as treads finalizarem.

public static void Main()
        {
            bool stopped = false;
            Thread t = new Thread(new ThreadStart(() =>
                                    {
                                        while (!stopped)
                                        {
                                            Console.WriteLine("Running...");
                                            Thread.Sleep(1000);
                                        }
                                    }));

            t.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            stopped = true;
            t.Join();
        }


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

