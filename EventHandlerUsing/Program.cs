using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.CreateAndRaise();
        }

        public class MyArgs : EventArgs
        {
            public MyArgs(int value)
            {
                Value = value;
            }
            public int Value { get; set; }
        }

        public class Pub
        {
            public event EventHandler<MyArgs> OnChange = delegate { };
            public void Raise()
            {
                OnChange(this, new MyArgs(42));
            }
        }

        public void CreateAndRaise()
        {
            Pub p = new Pub();
            p.OnChange += (sender, e) => Console.WriteLine("Event raised: {0}", e.Value);
            p.Raise();
        }
    }
}
