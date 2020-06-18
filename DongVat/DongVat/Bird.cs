using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Bird : DongVat
    {
        public override void speak()
        {
            Console.WriteLine("chip chip");
        }
        public override void eat()
        {
            Console.WriteLine("sau");
        }
        public override void move()
        {
            Console.WriteLine("bay");
        }
    }
}
