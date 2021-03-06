﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedAndVirtualAndOverride
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Base
    {
        public virtual int MyMethod()
        {
            return 42;
        }
    }
    class Derived : Base
    {
        public sealed override int MyMethod()
        {
            return base.MyMethod() * 2;
        }
    }
    class Derived2 : Derived
    {
        // This line would give a compile error
        //public override int MyMethod() { return 1;}
    }
}
