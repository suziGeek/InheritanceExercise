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

        public string featherColor { get; set; }
        public bool isPredator { get; set; }
        public bool doesFly { get; set; }
        public bool waterFoul { get; set; }
        
    }
}
