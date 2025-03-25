using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Mage : IWrapee
    {
        public void Attack()
        {
            Console.WriteLine("Attack with spell");
        }

        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
