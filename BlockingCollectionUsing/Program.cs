using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockingCollectionUsing
{
    class Program
    {
        public static void Main()
        {
            BlockingCollection<string> col = new BlockingCollection<string>();
            Task read = Task.Run(() =>
            {
                //while (true)
                //{
                //    Console.WriteLine(col.Take());
                //}
                foreach (string v in col.GetConsumingEnumerable()) //Fica bloqueado até encontrar um novo item.
                    Console.WriteLine(v);
            });
            Task write = Task.Run(() =>
            {
                while (true)
                {
                    string s = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(s)) break;
                    col.Add(s);
                }
            });
            write.Wait();

            /*
             Esta coleção serve para remover e adicionar dados. A remoção de um item da coleção pode ser bloqueado até que tenhamos a garantia que ele está disponível,
             e adicionar é algo rápido, mas se limitamos o tamanho da coleção novas inserções serão bloqueadas.
             A coleção BlockingCollection na verdade é um revestimento de outras coleções, se não mudarmos nada nela,
             na verdade ela irá se comportar como a coleção ConcurrentQueue.
             */
        }
    }
}
