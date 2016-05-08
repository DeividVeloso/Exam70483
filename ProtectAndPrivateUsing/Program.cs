using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectAndPrivateUsing
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public class Base
        {
            private int _privateField = 42;
            private void MyPrivateMethod() { }

            protected int _protectedField = 42;
            protected void MyProtectedMethod() { }
        }
        public class Derived : Base
        {
            public void MyDerivedMethod()
            {
                //_privateField = 41; // Not OK, this will generate a compile error
                _protectedField = 43; // OK, protected fields can be accessed
               
                //MyPrivateMethod(); // Not OK, this will generate a compile error
                MyProtectedMethod(); // OK, protected methods can be accessed
            }
        }

        public class Nova
        {
            public void Chupa()
            {
                //Base obj = new Base();
                //obj.
                //MyProtectedMethod();
            }
        }
    }
}
