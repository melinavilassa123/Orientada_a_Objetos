using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploStruct
{
    struct Struct
    {
        public double X, Y;

        public override string ToString()
        {
            return "(" + X + "," + Y + ")";
        }
    }
}
