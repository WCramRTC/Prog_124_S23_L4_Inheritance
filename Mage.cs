using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L4_Inheritance
{
    internal class Mage : Job
    {

        public override void Attack()
        {
            Console.WriteLine("Fireball");
        }
    }
}
