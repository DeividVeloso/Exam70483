using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
            queue.Enqueue(42);
            queue.Enqueue(10);
            int result;

            foreach (var item in queue)
            {
                if (queue.TryDequeue(out result))
                Console.WriteLine("Dequeued: {0}", result);
            }
            //if (queue.TryDequeue(out result))
            //    Console.WriteLine("Dequeued: {0}", result);
            // Dequeued: 42
        }
    }
}
