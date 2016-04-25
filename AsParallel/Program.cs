using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsParallel
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0,100);
            
            var parallelResult = numbers.AsParallel().Where(i => i % 2 == 0).ToArray();

            for (int i = 0; i < parallelResult.Length; i++)
            {
                Console.WriteLine(parallelResult[i].ToString());
            }

            /*
             Parallel runtime defene se vai rodar em paralelo ou sincrono, para forçar a execução em paralelo usar o método WithExecutionMode()
             * Você também pode limitar quantos processos o paralelismo irá usar com WithDegreeOfParallelism(), normalmente o PLINQ usa todos os processadores.
             * Com o parelelismo não é possivel vir em order, pois depende dos processadores livres para processar o resultado, porém é possível usar o AsOrdered()
             * para ordenar o resultado do parelelismo
             * Para garantir que o código rode em sequencia usar AsSequential()
             */
        }
    }
}
