using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Birds : Animals
    {
        public string Color { get; set; }
        public bool CanFly {  get; set; }
        public string CawSound { get; set; }
        public int Speed { get; set; }
    }
}
