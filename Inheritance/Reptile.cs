using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile: Animal
    {
        public Reptile()
        {

        }

        public int Length { get; set; }
        public bool HasScales { get; set; }
        public bool DoesSwim { get; set; }



    }
}
