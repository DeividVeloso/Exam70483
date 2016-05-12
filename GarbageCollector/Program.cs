using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter stream = File.CreateText("temp.dat");
            stream.Write("some data");

            //File.Delete("temp.dat"); // Throws an IOException because the file is already open.
            GC.Collect();
            GC.WaitForPendingFinalizers();
            File.Delete("temp.dat");
        }
    }
}
