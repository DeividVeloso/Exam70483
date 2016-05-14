using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExportingPublicKey
{
    class Program
    {
        static void Main(string[] args)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            
            string publicKeyXML = rsa.ToXmlString(false); //public KEy pass false
            string privateKeyXML = rsa.ToXmlString(true); // Private Key pass True
            
            Console.WriteLine(publicKeyXML);
            Console.WriteLine(privateKeyXML);
        }
    }
}
