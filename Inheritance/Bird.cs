using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public bool doesItFly { get; set; }
        public string whatDoesItEat { get; set; }
        public string noiseItMAkes { get; set; }
        public string whereIsItFrom { get; set; }

        public string canItSwim { get; set; }
    }
}
