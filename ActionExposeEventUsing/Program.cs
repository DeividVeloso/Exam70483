using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionExposeEventUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.CreateAndRaise();
        }

        public event Action OnChange = delegate { };

        public void Raise()
        {
            if (OnChange != null)
            {
                OnChange();
            }
        }

        public void CreateAndRaise()
        {
            Program p = new Program();
            p.OnChange += () => Console.WriteLine("Event raised to method 1");
            p.OnChange += () => Console.WriteLine("Event raised to method 2");
            p.Raise();
        }
    }
}
