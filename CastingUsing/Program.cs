using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingUsing
{
    class Program
    {
        static void Main(string[] args)
        {

            //Base class input in a derived class, use casting explicit
            Object stream = new MemoryStream();
            MemoryStream memoryStream = (MemoryStream)stream;

            //Derived class input in Base class, don't use casting, because is implicit
            MemoryStream stream2 = new MemoryStream();
            Object implicitObj = stream2;



        }


    }
}
