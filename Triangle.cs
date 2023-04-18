using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L4_Inheritance
{
    // To inherit from another class
    internal class Triangle : Polygon
    {

        // Child classes inherit everything BUT constructors
        // You must manually build the constructor in the child class
  

        // base
    

        public Triangle(string color, int numOfSides = 3) : base(color, numOfSides = 3)
        {
        }

        public override string ToString()
        {
            return base.ToString() + $" and a triangle with {NumOfSides} sides";
        } // ToString();

    } // class

} // name
