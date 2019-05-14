using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolymorphism
{
    class Canon : PrinterWindows
    {
        public override void Show()
        {
            Name = "Canon";

            Console.WriteLine("{0} display dimension : 9.5*12", Name);
        }
    }
}
