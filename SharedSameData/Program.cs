using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedSameData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            object _lock = new object();

            var up = Task.Run(() =>
            {
                /*
                 After this change, the program always outputs 0 because access to the variable n is now synchronized. 
                 There is no way that one thread could change the value while the other thread is working with it.
                 */
                for (int i = 0; i < 1000000; i++)
                    lock (_lock)
                        n++;
            });

            for (int i = 0; i < 1000000; i++)
                lock (_lock)
                    n--;
            up.Wait();
            Console.WriteLine(n);
            /*
             Sempre que temos threads usando os mesmo dados não dá certo, pois ao mesmo tempo que ele adiciona outra thread subtrai seu valor, 
             assim nunca chega em zero, pois os dados estão compartilhados e sendo acessados ao mesmo tempo
             Sempre que roda ele imprime um valor diferente.
             * 
             Para resolver precisamos usar os dados sincronos.
             * Para deixar as thread sincronas usar a propriedade LOCK
             */
        }
    }
}
