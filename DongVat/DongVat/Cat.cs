using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Cat : DongVat
    {
        public override void speak()
        {
            Console.WriteLine("meo meo");
        }
        public override void eat()
        {
            Console.WriteLine("ca");
        }
        public override void move()
        {
            Console.WriteLine("di");
        }

    }
}
