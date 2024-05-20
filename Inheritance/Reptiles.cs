using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptiles : Animals
    {
        public bool Tasty {  get; set; }
        public string EyeColor { get; set; }
        public int TailLength { get; set; } 
        public int NumberOfToes { get; set; }

    }
}
