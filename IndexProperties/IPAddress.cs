using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexProperties
{
    public class IPAddress
    {
        private int[] ip;
        public int this[int index]
        {
            get
            {
                return ip[index];
            }
            set
            {
                if (value == 0 || value == 1)
                    ip[index] = value;
                else
                    throw new Exception("Invalid value");
            }
        }
    }
}
