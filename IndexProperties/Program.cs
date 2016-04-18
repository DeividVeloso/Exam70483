using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress myIP = new IPAddress();
            // initialize the IP address to all zeros
            for (int i = 0; i < 32; i++)
            {
                myIP[i] = 0;
            }
        }
    }
}
