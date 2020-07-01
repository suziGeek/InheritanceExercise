using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        { 
        }

        public string FeatherColor { get; set; }
        public bool IsPredator { get; set; }
        public bool DoesFly { get; set; }
        public bool WaterFoul { get; set; }
        
    }
}
