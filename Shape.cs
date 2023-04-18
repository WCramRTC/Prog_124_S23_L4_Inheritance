using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L4_Inheritance
{
    internal class Shape
    {
        // what is a shape
        // how many dimension
        // 2d and 3d
        // triangle
        // circle
        // square
        string _color;

        // Created a constructor that took a property
        public Shape(string color)
        {
            _color = color;
        }


        // star
        // hexagon
        // cube
        // cylinder
        // rectangle

        public override string ToString()
        {
            return $"This is a basic {_color} Shape Object";
        } // ToString()

    } // class

} // namepsace
